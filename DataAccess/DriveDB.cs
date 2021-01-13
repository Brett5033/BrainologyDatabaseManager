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
        // Currently Stored Locally, plan to integrate with Google Drive
        private const string Path = @"..\..\Drives.xml";

        private const string PathBackup = @"..\..\DrivesBackup.xml";

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        private string[] Scopes = { DriveService.Scope.Drive };
        private string ApplicationName = "Drive API .NET BrainologyDatabaseManager";

        private string PreviousMD5 = "";

        private MetroFramework.Controls.MetroLabel UploadProgress;

        public DriveDB(MetroFramework.Controls.MetroLabel UploadProgress)
        {
            this.UploadProgress = UploadProgress;
            var w = new FRMLoadingPanel();
            w.Show();
            AsyncDownloadGoogleDrive();
            w.Close();
            //MessageBox.Show(w, "Authorizing Google Drive, may ask to sign into BrainologyDatabase@gmail.com \n See Login Info if need be." , "Google Drive Prompt Potentially Incoming");

            //DownloadGoogleDriveData();
        }

        private async void AsyncDownloadGoogleDrive()
        {
            //var w = new FRMLoadingPanel();
            //w.Show();
            //await Task.Delay(TimeSpan.FromSeconds(7))
            //    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
            await Task.Run(() => DownloadGoogleDriveData());

        }

        #region DriveAPI
        public void UploadGoogleDriveData(bool ShowMessages)
        {
            // Authorize Google Drive
            Console.WriteLine("Starting Data Upload");

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

            service.HttpClient.Timeout = TimeSpan.FromMinutes(100);

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;
            Console.WriteLine("Files:");
            string fileID = "";
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    Console.WriteLine("{0} ({1})", file.Name, file.Id);
                    // Download Drives.xml
                    //file.ExportLinks.Keys.
                    //OutputStream outputStream = new ByteArrayOutputStream();
                    //driveService.files().get(fileId).executeMediaAndDownloadTo(outputStream);
                    if(file.Name == "Drives.xml" && PreviousMD5 != file.Md5Checksum)
                    {
                        Console.WriteLine("Drives.xml found, changes have been made");
                        fileID = file.Id;
                        // High Probability File has been modified 
                        // Download File and incorporate changes before uploading
                        string fileName = "temp" + file.Name;
                        string tempPath = string.Format(@"..\..\{0}", fileName);
                        Console.WriteLine(string.Format("Attempting to download Google Drive data to {0}", tempPath));
                        DownloadFile(service, file, tempPath);

                        if (File.Exists(tempPath))
                            Console.WriteLine("Temp File Successfully downloaded");
                        else
                            Console.WriteLine("Temp File Failed to download");

                        DataManagerWrapper wrapper = BaseReadXMLContents(tempPath);
                        DataManager.IncorporateDriveData(wrapper.driveData);
                        File.Delete(tempPath);
                        // Local XMl should be up-to-date with Google Drive XMl
                    }
                    else if(file.Name == "Drives.xml" && PreviousMD5 == file.Md5Checksum)
                    {
                        Console.WriteLine("Drives.xml found but no changes by other users have been made");
                        fileID = file.Id;
                    }
                }
                //Console.WriteLine("Drives.xml not found in google drive");
            }
            else
            {
                Console.WriteLine("No files found.");
            }
            Console.WriteLine("uploading Drives.xml");
            var responce = uploadFile(service, Path, "", fileID, ShowMessages);
            DataManager.DatabaseChanges = false;
        }

        public Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service, string _uploadFile, string _parent, string fileID, bool ShowMessages, string _descrp = "Data XML")
        {
            if (System.IO.File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = System.IO.Path.GetFileName(_uploadFile);
                body.Description = _descrp;
                body.MimeType = "text/xml";
                // body.Parents = new List<string> { _parent };// UN comment if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
                
                try
                {
                    if (fileID == "")
                    {
                        Console.WriteLine("File not found, Creating file");
                        using (var stream = new FileStream(_uploadFile, FileMode.Open))
                        {
                            FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, body.MimeType);
                            //request.SupportsTeamDrives = true;
                            // You can bind event handler with progress changed event and response recieved(completed event)
                            //request.ProgressChanged += Request_ProgressChanged;
                            //request.ResponseReceived += Request_ResponseReceived;
                            request.Fields = "id";
                            request.Upload();
                            if(ShowMessages)
                            MessageBox.Show(body.Name + " successfully uploaded.", "File Upload Complete");
                            return request.ResponseBody;
                        }
                    }
                    else
                    {
                        Console.WriteLine("File found, Updating file");
                        using (var updateStream = new FileStream(_uploadFile, FileMode.Open))
                        {
                            FilesResource.UpdateMediaUpload request = _service.Files.Update(body, fileID, updateStream, body.MimeType);
                            //request.SupportsTeamDrives = true;
                            // You can bind event handler with progress changed event and response recieved(completed event)
                            //request.ProgressChanged += Request_ProgressChanged;
                            //request.ResponseReceived += Request_ResponseReceived;
                            request.Fields = "id";
                            request.Upload();
                            if(ShowMessages)
                            MessageBox.Show(body.Name + " successfully uploaded.", "File Upload Complete");
                            return request.ResponseBody;
                        };
                        
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace + "\n" + e.Source, "Error Occured");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.", "404");
                return null;
            }
        }

        private void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        {
            UploadProgress.Text += obj.Status + " " + obj.BytesSent;
        }

        private void Request_ResponseReceived(Google.Apis.Drive.v3.Data.File obj)
        {
            if (obj != null)
            {
                MessageBox.Show("File was uploaded sucessfully--" + obj.Name);
            }
        }

        public void DownloadGoogleDriveData()
        {
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
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;
            Console.WriteLine("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    // Download Drives.xml
                    //file.ExportLinks.Keys.
                    //OutputStream outputStream = new ByteArrayOutputStream();
                    //driveService.files().get(fileId).executeMediaAndDownloadTo(outputStream);
                    if (file.Name == "Drives.xml")
                    {
                        PreviousMD5 = file.Md5Checksum;
                        DownloadFile(service, file, string.Format(@"..\..\{0}", file.Name));
                        ReadXMLContents();
                    }

                    Console.WriteLine("{0} ({1})", file.Name, file.Id);
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }

        }

        private void DownloadFile(DriveService service, Google.Apis.Drive.v3.Data.File file, string saveTo)
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

        private void SaveStream(MemoryStream stream, string saveTo)
        {
            using (FileStream file = new FileStream(saveTo, FileMode.Create, FileAccess.Write))
            {
                stream.WriteTo(file);
            }
        }

        #endregion

        public void SerializeToXML()
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

        public void ReadXMLContents()
        {
            DataManagerWrapper wrapper = BaseReadXMLContents(Path);
            if (wrapper == null)
                return;

            wrapper.SaveDriveObjects();
            
            // Reads the order date.
            foreach (DriveObject obj in DataManager.DriveData)
                Console.WriteLine("Drive Name: " + obj.name);
            

        }

        private DataManagerWrapper BaseReadXMLContents(string path)
        {
            if (!File.Exists(path))
                return null;
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
            fs.Close();
            return dataWrapper;
        }

        private void Serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
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
