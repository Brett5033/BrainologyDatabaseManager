using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using BrainologyDatabaseManager.DataAccess;

namespace BrainologyDatabaseManager.Common
{
    public class DriveObject : IEquatable<DriveObject>
    {
        public string path;
        public string name;
        public DateTime date;
        /// <summary>
        /// File Size stored in KB
        /// </summary>
        public decimal size;
        public string comments;

        public List<Tag> tags;
        public List<DriveObject> subDirectories;

        public enum DriveObjectType
        {
            Directory,
            File
        }

        public DriveObjectType driveObjectType;

        #region Constructors
        public DriveObject()
        {
            driveObjectType = DriveObjectType.Directory;
            path = null;
            name = null;
            date = new DateTime();
            comments = null;
            size = 0;
            subDirectories = new List<DriveObject>();
        }

        public DriveObject(string path, string name, DateTime date, decimal size, string comment, DriveObjectType type)
        {
            driveObjectType = type;
            this.path = path;
            this.name = name;
            this.date = date;
            this.size = size;
            this.comments = comment;
            subDirectories = new List<DriveObject>();
            tags = new List<Tag>();
        }

        public DriveObject(string path, string name, DateTime date, decimal size, string comment, Tag[] tags ,DriveObject[] directoryItems, DriveObjectType type)
        {
            driveObjectType = type;
            this.path = path;
            this.name = name;
            this.date = date;
            this.size = size;
            this.comments = comment;
            this.tags = new List<Tag>();
            foreach(Tag tag in tags)
            {
                this.tags.Add(tag);
            }
            subDirectories = new List<DriveObject>();
            foreach (DriveObject dir in directoryItems)
            {
                subDirectories.Add(dir);
            }
        }

        public DriveObject(DriveObject prevDriveObj)
        {
            this.driveObjectType = prevDriveObj.driveObjectType;
            this.path = prevDriveObj.path;
            this.name = prevDriveObj.name;
            this.date = prevDriveObj.date;
            this.size = prevDriveObj.size;
            this.comments = prevDriveObj.comments;
            this.tags = new List<Tag>(prevDriveObj.tags);
            this.subDirectories = new List<DriveObject>();
        }
        #endregion

        public List<DriveObject> getSubDirectories()
        {
            return subDirectories;
        }

        public List<Tag> getTags()
        {
            return tags;
        }

        public bool AddRegisteredTag(Tag t)
        {
            if (!tags.Contains(t))
            {
                tags.Add(t);
                return true;
            }
            return false;
        }

        public bool RemoveRegisteredTag(Tag t)
        {
            if (tags.Contains(t))
            {
                tags.Remove(t);
                return true;
            }
            return false;
        }

        public string getDriveObjectType()
        {
            return driveObjectType.ToString();
        }

        public string getFormattedSize()
        {
            if (size / (1024m * 1024m) > 1m)
                return ((size / (1024m * 1024m)).ToString("f2") + " GB");
            else if (size / (1024m) > 1m)
                return ((size / (1024m)).ToString("f2") + " MB");
            else
                return (size.ToString("f2") + "KB");
        }

        public DriveObject getSubDirectory(int index)
        {
            return subDirectories.ElementAt(index);
        }

        public string[] getSubDirectoryNames()
        {
            string[] names = new string[subDirectories.Count];
            for (int i = 0; i < subDirectories.Count; i++)
            {
                names[i] = subDirectories.ElementAt(i).name;
            }
            return names;
        }

        public void addSubDirectory(DriveObject subDir)
        {
            subDirectories.Add(subDir);
        }

        public int subDirectoryCount()
        {
            int count = 0;
            if (subDirectories.Count == 0)
                return 0;
            foreach (DriveObject dir in subDirectories)
            {
                count += subDirectoryCountHelper(dir, count);
            }
            return count;
        }

        private int subDirectoryCountHelper(DriveObject subDir, int count)
        {
            if(subDir.getSubDirectories().Count == 0)
            {
                return 1;
            }
            foreach(DriveObject dir in subDir.getSubDirectories())
            {
                count += subDirectoryCountHelper(dir, count);
            }
            return count;
        }

        public bool Equals(DriveObject obj)
        {
            return (
                this.name == obj.name &&
                this.date == obj.date &&
                this.size == obj.size
                );
        }

        public override int GetHashCode()
        {
            return string.Format("{0}-{1}-{2}", name, date.ToString(), size.ToString()).GetHashCode();
        }

    }

    
}
