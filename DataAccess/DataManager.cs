using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainologyDatabaseManager.Common;
using BrainologyDatabaseManager;

namespace BrainologyDatabaseManager.DataAccess
{
    public static class DataManager
    {
        /// <summary>
        /// List of Drives as DriveObjects
        /// </summary>
        public static List<DriveObject> DriveData = new List<DriveObject>();

        private static List<Tag> RegisteredTags = new List<Tag>();

        public static bool databaseChangesMade = false;

        public static List<string> GetDriveObjectData(DriveObject obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Null Drive object");
                return null;
            }
            List<string> attributes = new List<string>();
            Console.WriteLine("Drive Object " + obj.name + " selected");
            attributes.Add("Path: " + obj.path);
            attributes.Add("Name: " + obj.name);
            attributes.Add("Date: " + obj.date);
            if(obj.size / (1024m * 1024m) > 1m)
                attributes.Add("Size: " + (obj.size / (1024m * 1024m)).ToString("f2") + " GB");
            else if (obj.size / (1024m) > 1m)
                attributes.Add("Size: " + (obj.size / (1024m)).ToString("f2") + " MB");
            else
                attributes.Add("Size: " + obj.size.ToString("f2") + "KB");
            attributes.Add("Tags:");
            foreach(Tag tag in obj.getTags())
            {
                attributes.Add("\t" + tag.ID);
            }
            attributes.Add("Comment: " + obj.comments);
            return attributes;

        }

        public static List<List<DriveObject>> SearchByName(string searchParamter, ref int SearchCount, FilterOptions options)
        {
            if(!options.exactMatch && options.searchFilter == SearchFilter.Name)
                searchParamter = searchParamter.ToLower();
            List<List<DriveObject>> sortedFoundObjects = new List<List<DriveObject>>();
            for(int i = 0; i < DriveData.Count; i++)
            {
                if (options.SpecifyDrives && i == options.DriveIndex)
                    continue;
                List<DriveObject> foundObjects = new List<DriveObject>();
                SearchByNameHelper(foundObjects, DriveData.ElementAt(i), searchParamter, ref SearchCount, options);
                sortedFoundObjects.Add(foundObjects);
            }
            return sortedFoundObjects;
        }

        private static List<DriveObject> SearchByNameHelper(List<DriveObject> foundObjects, DriveObject currentNode ,string searchParameter, ref int SearchCount, FilterOptions options)
        {
            if(currentNode != null)
            {
                foreach(DriveObject child in currentNode.getSubDirectories())
                {
                    SearchByNameHelper(foundObjects, child, searchParameter, ref SearchCount, options);
                }
                // Any Filter Options go here \/

                switch (options.searchFilter)
                {
                    case SearchFilter.Name:
                        {

                            string nodeName = "";
                            if (!options.exactMatch)
                                nodeName = currentNode.name.ToLower();
                            else
                                nodeName = currentNode.name;

                            if (nodeName.Contains(searchParameter))
                                foundObjects.Add(currentNode);
                            break;
                        }
                    case SearchFilter.Tag:
                        {
                            if (currentNode.getTags().Contains(new Tag(searchParameter)))
                                foundObjects.Add(currentNode);
                                    
                            break;
                        }
                }

                SearchCount++;
            }
            return foundObjects;
        }
        
        public static List<DriveObject> AlphaSortDriveObjects(List<DriveObject> orgin)
        {
            List<DriveObject> sortedList = new List<DriveObject>();

            // Selection sort
            for(int i = 0; i < orgin.Count; i++)
            {
                //Console.WriteLine("Sorting #" + i);
                // Set max to 
                int max_index = i;
                for (int j = 0; j < orgin.Count; j++)
                {
                    //Console.WriteLine("\tComparing " + orgin.ElementAt(max_index).name + " to " + orgin.ElementAt(j).name);
                    if (orgin.ElementAt(max_index).name.CompareTo(orgin.ElementAt(j).name) > 0)
                    {
                        max_index = j;
                    }
                }
                //Console.WriteLine("\tMax element " + orgin.ElementAt(max_index) + " found at index: " + max_index);
                sortedList.Add(orgin.ElementAt(max_index));
                orgin.RemoveAt(max_index);
                i--;
            }

            return sortedList;
        }

        public static List<DriveObject> DateSortDriveObjects(List<DriveObject> orgin)
        {
            List<DriveObject> sortedList = new List<DriveObject>();

            // Selection sort
            for (int i = 0; i < orgin.Count; i++)
            {
                //Console.WriteLine("Sorting #" + i);
                // Set max to 
                int max_index = i;
                for (int j = 0; j < orgin.Count; j++)
                {
                    //Console.WriteLine("\tComparing " + orgin.ElementAt(max_index).name + " to " + orgin.ElementAt(j).name);
                    if (orgin.ElementAt(max_index).date.CompareTo(orgin.ElementAt(j).date) > 0)
                    {
                        max_index = j;
                    }
                }
                //Console.WriteLine("\tMax element " + orgin.ElementAt(max_index) + " found at index: " + max_index);
                sortedList.Add(orgin.ElementAt(max_index));
                orgin.RemoveAt(max_index);
                i--;
            }

            return sortedList;
        }

        public static List<DriveObject> SizeSortDriveObjects(List<DriveObject> orgin)
        {
            List<DriveObject> sortedList = new List<DriveObject>();

            // Selection sort
            for (int i = 0; i < orgin.Count; i++)
            {
                //Console.WriteLine("Sorting #" + i);
                // Set max to 
                int max_index = i;
                for (int j = 0; j < orgin.Count; j++)
                {
                    //Console.WriteLine("\tComparing " + orgin.ElementAt(max_index).name + " to " + orgin.ElementAt(j).name);
                    if (orgin.ElementAt(max_index).size < orgin.ElementAt(j).size)
                    {
                        max_index = j;
                    }
                }
                //Console.WriteLine("\tMax element " + orgin.ElementAt(max_index) + " found at index: " + max_index);
                sortedList.Add(orgin.ElementAt(max_index));
                orgin.RemoveAt(max_index);
                i--;
            }

            return sortedList;
        }

        #region Tags
        public static bool RegisterTag(string ID)
        {
            Tag t = new Tag(ID.ToUpper());
            if (RegisteredTags.Contains(t))
            {
                return false;
            }
            else
            {
                for(int i = 0; i < RegisteredTags.Count-1; i++)
                {
                    if(RegisteredTags.ElementAt(i+1).ID.CompareTo(t.ID) >= 0)
                    {
                        RegisteredTags.Insert(i, t);
                        return true;
                    }
                }
                RegisteredTags.Add(t);
            }
            return false;
        }

        public static bool TagIsRegistered(Tag t)
        {
            return RegisteredTags.Contains(t);
        }

        public static bool TagIsRegistered(string ID)
        {
            Tag t = new Tag(ID.ToUpper());
            return RegisteredTags.Contains(t);
        }
        #endregion
    }

    public class FilterOptions
    {
        public bool DriveSort;
        public bool AlphaSort;
        public bool DateSort;
        public bool SizeSort;

        public bool exactMatch;

        public bool SpecifyDrives;
        public int DriveIndex;

        public SearchFilter searchFilter;

        public FilterOptions()
        {
            DriveSort = true;
            AlphaSort = false;
            DateSort = false;
            SizeSort = false;

            exactMatch = false;

            SpecifyDrives = false;
            DriveIndex = 0;

            searchFilter = SearchFilter.Name;
        }

    }

    public enum SearchFilter
    {
        Name,
        Tag
    }

}
