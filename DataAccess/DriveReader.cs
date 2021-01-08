using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainologyDatabaseManager.Common
{
    public static class DriveReader
    {
        /// <summary>
        /// Builds a DriveObject for the given root and all subDirectories and Files
        /// </summary>
        /// <param name="DrivePath"></param>
        /// <returns></returns>
        public static DriveObject getDriveContents(string DrivePath)
        {
            Console.WriteLine("Getting Drive Contents of " + DrivePath);
            // Form Directory Object
            DriveObject rootDrive = ConstructDriveObject(DrivePath, DriveObject.DriveObjectType.Directory);
            Console.WriteLine("Root Drive Object made");
            ProcessDirectory(rootDrive);
            return rootDrive;
        } 

        /// <summary>
        /// Recursivly searches through a given path, building nested DriveObjects for all subdirectories and files.
        /// </summary>
        /// <param name="curDirectory"></param>
        private static decimal ProcessDirectory(DriveObject curDirectory)
        {
            decimal size = 0;
            try
            {
                
                Console.WriteLine("Processing Directory of path: " + curDirectory.path);
                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = Directory.GetDirectories(curDirectory.path);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    if (Directory.Exists(subdirectory))
                    {
                        DriveObject subDriveObject = ConstructDriveObject(subdirectory, DriveObject.DriveObjectType.Directory);
                        curDirectory.addSubDirectory(subDriveObject);
                        size += ProcessDirectory(subDriveObject);
                    }
                }

                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles(curDirectory.path);
                foreach (string fileName in fileEntries)
                {
                    if (File.Exists(fileName))
                    {
                        DriveObject subDriveObject = ConstructDriveObject(fileName, DriveObject.DriveObjectType.File);
                        curDirectory.addSubDirectory(subDriveObject);
                        size += subDriveObject.size;
                    }
                }
                curDirectory.size = size;
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            return size;
        }


        /// <summary>
        /// Builder for DriveObjects
        /// </summary>
        /// <param name="path"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static DriveObject ConstructDriveObject(string path, DriveObject.DriveObjectType type)
        {
            string name;
            DateTime date;
            decimal size;
            string comment;
            if(type == DriveObject.DriveObjectType.Directory)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                name = dir.Name;
                date = dir.LastWriteTime;
                size = 0m;
            }
            else
            {
                FileInfo file = new FileInfo(path);
                name = file.Name;
                date = file.LastWriteTime;
                size = (decimal)file.Length / 1024m;
            }

            return new DriveObject(path, name, date, size, "", type);
        }
    }

    
}
