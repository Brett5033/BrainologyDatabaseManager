using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainologyDatabaseManager.Common;
using BrainologyDatabaseManager;
using System.IO;

namespace BrainologyDatabaseManager.DataAccess
{
    public static class DataManager
    {
        /// <summary>
        /// List of Drives as DriveObjects
        /// </summary>
        public static List<DriveObject> DriveData = new List<DriveObject>();

        public static List<Tag> RegisteredTags = new List<Tag>();

        public static List<TagPreset> RegisteredPresets = new List<TagPreset>();

        /// <summary>
        /// True when new files have been manually added but not written to XML file.
        /// </summary>
        public static bool UnsavedChanges = false;

        /// <summary>
        /// True when any saved change has occured and XML should be uploaded
        /// </summary>
        public static bool DatabaseChanges = false;

        public static List<DriveObject> ChangedObjects = new List<DriveObject>();

        public static void IncorporateDriveData(List<DriveObject> newList)
        {
            // Look through the drives that the new list and copy the drive contents, ignoring the currently accessible drives
            // In theory (I hope) any drives currently accessible shouldnt be changed by any other system
            // We assume other drives are more up-to-date
            var driveList = DriveInfo.GetDrives();


            foreach (DriveObject newListObject in newList)
            {
                bool FoundOnLocalSystem = false;
                // Check if active on system
                foreach(DriveObject localObject in ChangedObjects)
                {
                    if(newListObject.Equals(localObject))
                    {
                        // Local DriveObject found, leave alone
                        FoundOnLocalSystem = true;
                        break;
                    }
                }
                if (!FoundOnLocalSystem)
                {
                    // No local changes
                    bool newDriveObject = true;
                    for(int i = 0; i < DriveData.Count; i++)
                    {
                        if (newDriveObject.Equals(DriveData.ElementAt(i)))
                        {
                            // Current Object Found, replace
                            DriveData[i] = newListObject;
                            newDriveObject = false;
                        }
                    }
                    if (newDriveObject)
                    {
                        DriveData.Add(newListObject);
                    }
                }
            }
            ChangedObjects.Clear();
        }

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
            attributes.Add("Size: " + obj.getFormattedSize());
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
                if (options.SpecifyDrives && i != options.DriveIndex)
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

                foreach (DriveObject child in currentNode.getSubDirectories())
                {
                    SearchByNameHelper(foundObjects, child, searchParameter, ref SearchCount, options);
                }
                // Any Filter Options go here \/

                
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
            if (IsTagRegistered(ID))
            {
                return false;
            }
            else
            {
                Tag t = new Tag(ID.ToUpper());
                t.ID.Replace(' ', '_');
                for (int i = 0; i < RegisteredTags.Count-1; i++)
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

        public static bool IsTagRegistered(Tag t)
        {
            return RegisteredTags.Contains(t);
        }

        public static bool IsTagRegistered(string ID)
        {
            return RegisteredTags.Contains(GetTag(ID));
        }

        public static Tag GetTag(string ID)
        {
            Tag t = new Tag(ID.ToUpper());
            t.ID.Replace(' ', '_');
            int index = RegisteredTags.IndexOf(t);
            if (index != -1)
            {
                return RegisteredTags.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public static TagPreset GetPreset(string ID)
        {
            foreach(TagPreset preset in RegisteredPresets)
            {
                if (preset.ID == ID)
                    return preset;
            }
            return null;
        }
        #endregion
    }

    public class Tag
    {
        public string ID;

        public Tag()
        {
            ID = "NULL_TAG";
        }

        public Tag(string ID)
        {
            this.ID = ID;
        }

        public override bool Equals(Object otherTag)
        {
            return ID == ((Tag)otherTag).ID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class TagPreset
    {
        public string ID;

        public List<Tag> Tags;

        public TagPreset()
        {
            this.ID = "Null_Preset";
            Tags = new List<Tag>();
        }

        public TagPreset(string ID)
        {
            this.ID = ID;
            Tags = new List<Tag>();
        }

        public TagPreset(string ID, List<Tag> Tags)
        {
            this.ID = ID;
            this.Tags = Tags;
        }

        public bool AddTag(Tag t)
        {
            if (!Tags.Contains(t))
            {
                Tags.Add(t);
                return true;
            }
            return false;
        }

        public bool RemoveTag(Tag t)
        {
            if (Tags.Contains(t))
            {
                Tags.Remove(t);
                return true;
            }
            return false;
        }

        public override bool Equals(Object otherPreset)
        {
            return ID == ((TagPreset)otherPreset).ID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
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
