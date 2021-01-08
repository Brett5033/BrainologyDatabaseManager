using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BrainologyDatabaseManager.Common;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Resolvers;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace BrainologyDatabaseManager.DataAccess
{
    public class DataManagerWrapper
    {
        public List<DriveObject> driveData;

        public DataManagerWrapper()
        {
            driveData = new List<DriveObject>();
        }

        public void CacheData()
        {
            driveData = DataManager.DriveData;
        }

        public void SaveDriveObjects()
        {
            DataManager.DriveData = driveData;
        }
    }

    public class DriveDB
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "Drive API .NET BrainologyDatabaseManager";

        public DriveDB()
        {
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(10))
                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            MessageBox.Show(w, "Authorizing Google Drive, may ask to sign into BrainologyDatabase@gmail.com \n See Login Info if need be." , "Google Drive Prompt Incoming");

            // Authorize Google Drive

            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    // Download Drives.xml
                    //file.ExportLinks.Keys.
                    //OutputStream outputStream = new ByteArrayOutputStream();
                    //driveService.files().get(fileId).executeMediaAndDownloadTo(outputStream);
                    DownloadFile(service, file, string.Format(@"..\..\{0}", file.Name));

                    Console.WriteLine("{0} ({1})", file.Name, file.Id);
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }
        }

        private static void DownloadFile(DriveService service, Google.Apis.Drive.v3.Data.File file, string saveTo)
        {

            var request = service.Files.Get(file.Id);
            var stream = new MemoryStream();

            // Add a handler which will be notified on progress changes.
            // It will notify on each chunk download and when the
            // download is completed or failed.
            request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
            {
                switch (progress.Status)
                {
                    case Google.Apis.Download.DownloadStatus.Downloading:
                        {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Completed:
                        {
                            Console.WriteLine("Download complete.");
                            SaveStream(stream, saveTo);
                            break;
                        }
                    case Google.Apis.Download.DownloadStatus.Failed:
                        {
                            Console.WriteLine("Download failed.");
                            break;
                        }
                }
            };
            request.Download(stream);

        }

        private static void SaveStream(MemoryStream stream, string saveTo)
        {
            using (FileStream file = new FileStream(saveTo, FileMode.Create, FileAccess.Write))
            {
                stream.WriteTo(file);
            }
        }


        // Currently Stored Locally, plan to integrate with Google Drive
        private const string Path = @"..\..\Drives.xml";

        private const string PathBackup = @"..\..\DrivesBackup.xml";

        public void SerializeDrives()
        {
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            XmlSerializer serializer =
            new XmlSerializer(typeof(DataManagerWrapper));
            TextWriter writer = new StreamWriter(Path);

            // Serializes the drives, and closes the TextWriter.
            //foreach(DriveObject obj in DataManager.DriveData)
            //serializer.Serialize(writer, obj);

            DataManagerWrapper dataWrapper = new DataManagerWrapper();
            dataWrapper.CacheData();
            serializer.Serialize(writer, dataWrapper);
            writer.Close();
        }

        public void ReadDriveSaves()
        {

            if (!File.Exists(Path))
                return;
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(DataManagerWrapper));
            // If the XML document has been altered with unknown
            // nodes or attributes, handles them with the
            // UnknownNode and UnknownAttribute events.
            serializer.UnknownNode += new
            XmlNodeEventHandler(Serializer_UnknownNode);
            serializer.UnknownAttribute += new
            XmlAttributeEventHandler(serializer_UnknownAttribute);
            

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(Path, FileMode.Open);

            // Declares an object variable of the type to be deserialized.
            //List<DriveObject> driveObjects = new List<DriveObject>();
            DataManagerWrapper dataWrapper = new DataManagerWrapper();

            // Uses the Deserialize method to restore the object's state
            // with data from the XML document. */
            //while(fs.Length != fs.Position)
            //    driveObjects.Add((DriveObject)serializer.Deserialize(fs));
            dataWrapper = (DataManagerWrapper)serializer.Deserialize(fs);
            dataWrapper.SaveDriveObjects();
            
            // Reads the order date.
            foreach (DriveObject obj in DataManager.DriveData)
                Console.WriteLine("Drive Name: " + obj.name);
            fs.Close();

        }

        private void Serializer_UnknownNode
        (object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private void serializer_UnknownAttribute
        (object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }

        public void BackupDB()
        {
            File.Copy(Path, PathBackup, true);
        }

        public void RestoreDB()
        {
            File.Copy(PathBackup, Path, true);
        }

        public void ClearDB()
        {
            BackupDB();
            File.Delete(Path);
        }
    }
}
