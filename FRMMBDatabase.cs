using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrainologyDatabaseManager.Common;
using BrainologyDatabaseManager.DataAccess;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;

namespace BrainologyDatabaseManager
{
    public partial class FRMMBDatabase : MetroForm
    {  
        public enum TabFormControl
        {
            Welcome,
            Search,
            DriveLoad,
            Optimization
        }



        // Class Variables

        public TabFormControl currentSubForm;
        
        public DriveDB driveDatabase;

        // Drive Manager
        private DriveObject currentlySelectedObject = null;
        private DriveObject parentOfCurrent = null;

        // Search Manager
        private int searchCount = 0;
        private int totalSearches = 0;
        FilterOptions filterOptions;
        DriveObject selectedNode = null;
        List<List<DriveObject>> DisplayedObjects;

        public FRMMBDatabase()
        {
            InitializeComponent();
        }

        private void FRMMBDatabase_Load(object sender, EventArgs e)
        {
            // Load all drive data from the XML File
            driveDatabase = new DriveDB();
            driveDatabase.ReadDriveSaves();

            // Drive Manager Load
            DisplayActiveDrives();
            displayDriveReadIn();

            // Search Manager Load
            filterOptions = new FilterOptions();
            DisplayedObjects = new List<List<DriveObject>>();

            MTABWindowSelector.SelectTab((int)TabFormControl.Welcome);
        }

        
        private void MTABWindowSelector_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            // Check for any saves that need to be made
            if (e.TabPageIndex == (int)TabFormControl.Welcome)
            {

            }
            else if (e.TabPageIndex == (int)TabFormControl.Search)
            {
            }
            else if (e.TabPageIndex == (int)TabFormControl.DriveLoad)
            {
                if (DataManager.databaseChangesMade)
                {
                    var window = MessageBox.Show(
                        "Do you wish to write changes to the database?",
                        "Changes Detected?",
                        MessageBoxButtons.YesNo);
                    if (window == DialogResult.Yes)
                    {
                        SerializeNewData();
                    }
                }
            }
            else if(e.TabPageIndex == (int)TabFormControl.Optimization)
            {

            }
        }

        private void MTABWindowSelector_Selected(object sender, TabControlEventArgs e)
        {
            // Refresh any data that should be displayed for a given tab page
            if (e.TabPageIndex == (int)TabFormControl.Welcome)
            {
                currentSubForm = TabFormControl.Welcome;
            } 
            else if (e.TabPageIndex == (int)TabFormControl.Search)
            {
                foreach (DriveObject obj in DataManager.DriveData)
                {
                    ComboBXDriveSelect.Items.Add(obj.name);
                }
                currentSubForm = TabFormControl.Search;
            } 
            else if(e.TabPageIndex == (int)TabFormControl.DriveLoad)
            {
                DisplayActiveDrives();
                displayDriveReadIn();
                currentSubForm = TabFormControl.DriveLoad;
            }
            else if (e.TabPageIndex == (int)TabFormControl.Optimization)
            {
                LBXDrivePriority.Items.Clear();
                foreach(DriveObject obj in DataManager.DriveData)
                {
                    LBXDrivePriority.Items.Add(obj.name);
                }
            }
        }

        #region SearchManager
        private void ReadInFilters()
        {
            if (RBTNName.Checked)
                filterOptions.searchFilter = SearchFilter.Name;
            else
                filterOptions.searchFilter = SearchFilter.Tag;

            //filterOptions.DriveSort 
            filterOptions.exactMatch = CBXExactMatch.Checked;
            filterOptions.DriveSort = CBXDrive.Checked;
            filterOptions.AlphaSort = CBXAlpha.Checked;
            filterOptions.DateSort = CBXDate.Checked;
            filterOptions.SizeSort = CBXSize.Checked;
            filterOptions.SpecifyDrives = CBXSpecifyDrive.Checked;
            if (filterOptions.SpecifyDrives && ComboBXDriveSelect.SelectedIndex != -1)
            {
                filterOptions.DriveIndex = ComboBXDriveSelect.SelectedIndex;
            }

        }

        private void RefreshSearch()
        {
            if (TXTSearch.Text != "")
            {
                TVSearchView.Nodes.Clear();

                ReadInFilters();

                List<List<DriveObject>> matchingObjects = DataManager.SearchByName(TXTSearch.Text, ref totalSearches, filterOptions);
                DisplayedObjects = matchingObjects;

                //Update Search Count
                searchCount = 0;
                foreach (List<DriveObject> list in matchingObjects)
                {
                    searchCount += list.Count;
                }

                //
                if (searchCount == 0)
                {
                    TVSearchView.Nodes.Add("No Items Found");
                }
                else
                {
                    // Sort results by Drive, changing the root nodes for each
                    if (filterOptions.DriveSort)
                    {
                        for (int i = 0; i < matchingObjects.Count; i++)
                        {
                            TreeNode driveNode = new TreeNode(DataManager.DriveData.ElementAt(i).name);

                            TVSearchView.Nodes.Add(driveNode);

                            // Filter Drive Input
                            if (filterOptions.AlphaSort)
                            {
                                matchingObjects[i] = DataManager.AlphaSortDriveObjects(matchingObjects.ElementAt(i));
                            }
                            else if (filterOptions.DateSort)
                            {
                                matchingObjects[i] = DataManager.DateSortDriveObjects(matchingObjects.ElementAt(i));
                            }
                            else if (filterOptions.SizeSort)
                            {
                                matchingObjects[i] = DataManager.SizeSortDriveObjects(matchingObjects.ElementAt(i));
                            }

                            foreach (DriveObject obj in matchingObjects.ElementAt(i))
                            {
                                TreeNode rootNode = new TreeNode(obj.name);

                                // If drive sort active, filters subnodes by root drive node
                                driveNode.Nodes.Add(rootNode);

                                rootNode.Nodes.Add(obj.getDriveObjectType() + ",  Date: " + obj.date.ToString() + ", Size: " + obj.size);

                                string existsOnDrives = "Exists on Drives: ";
                                for (int j = 0; j < matchingObjects.Count; j++)
                                {
                                    foreach (DriveObject driveObj in matchingObjects.ElementAt(j))
                                    {
                                        if (obj.Match(driveObj))
                                        {
                                            existsOnDrives += DataManager.DriveData.ElementAt(j).name + ", ";
                                            break;
                                        }
                                    }
                                }
                                rootNode.Nodes.Add(existsOnDrives);

                                rootNode.Nodes.Add(obj.path);

                                TreeNode tagRoot = new TreeNode("Tags:");
                                rootNode.Nodes.Add(tagRoot);
                                foreach (Tag tag in obj.getTags())
                                {
                                    tagRoot.Nodes.Add(tag.ID);
                                }

                                rootNode.Nodes.Add(obj.comments);
                            }

                        }
                    }
                    else // Sort as one big ol list
                    {
                        List<DriveObject> massList = new List<DriveObject>();
                        for (int i = 0; i < matchingObjects.Count; i++)
                        {
                            foreach (DriveObject obj in matchingObjects.ElementAt(i))
                            {
                                massList.Add(obj);
                            }
                        }

                        // Filter Drive Input
                        if (filterOptions.AlphaSort)
                        {
                            massList = DataManager.AlphaSortDriveObjects(massList);
                        }
                        else if (filterOptions.DateSort)
                        {
                            massList = DataManager.DateSortDriveObjects(massList);
                        }
                        else if (filterOptions.SizeSort)
                        {
                            massList = DataManager.SizeSortDriveObjects(massList);
                        }

                        foreach (DriveObject obj in massList)
                        {
                            TreeNode rootNode = new TreeNode(obj.name);

                            // If drive sort active, filters subnodes by root drive node
                            TVSearchView.Nodes.Add(rootNode);

                            rootNode.Nodes.Add(obj.getDriveObjectType() + ",  Date: " + obj.date.ToString() + ", Size: " + obj.size);

                            string existsOnDrives = "Exists on Drives: ";
                            for (int j = 0; j < matchingObjects.Count; j++)
                            {
                                foreach (DriveObject driveObj in matchingObjects.ElementAt(j))
                                {
                                    if (obj.Match(driveObj))
                                    {
                                        existsOnDrives += DataManager.DriveData.ElementAt(j).name + ", ";
                                        break;
                                    }
                                }
                            }
                            rootNode.Nodes.Add(existsOnDrives);

                            rootNode.Nodes.Add(obj.path);

                            TreeNode tagRoot = new TreeNode("Tags:");
                            rootNode.Nodes.Add(tagRoot);
                            foreach (Tag tag in obj.getTags())
                            {
                                tagRoot.Nodes.Add(tag.ID);
                            }

                            rootNode.Nodes.Add(obj.comments);
                        }
                    }
                }

                TXTSearchData.Text = "Found " + searchCount + " Matching Entries in " + totalSearches + " Total Searches";
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            RefreshSearch();
        }
        private void CBXSpecifyDrive_CheckedChanged(object sender, EventArgs e)
        {
            ComboBXDriveSelect.Enabled = CBXSpecifyDrive.Checked;
            filterOptions.SpecifyDrives = CBXSpecifyDrive.Checked;
        }

        private void TVSearchView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode tNode = e.Node;
            while (tNode.Parent != null)
            {
                tNode = tNode.Parent;
            }
            int itemIndex = TVSearchView.Nodes.IndexOf(tNode);
            selectedNode = DataManager.DriveData.ElementAt(itemIndex);
        }
        #endregion
        
        #region DriveManager
        /// <summary>
        /// Listener to load in directories from a path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNLoadDriveData_Click(object sender, EventArgs e)
        {
            LoadNewDriveData();
        }

        /// <summary>
        /// Loads in all directories from the given File Path in TXTDrivePath
        /// </summary>
        public void LoadNewDriveData()
        {
            if (TXTDrivePath.Text != "" && Directory.Exists(TXTDrivePath.Text))
            {
                // Path is a valid directory
                DataManager.DriveData.Add(DriveReader.getDriveContents(TXTDrivePath.Text));
                displayDriveContents(DataManager.DriveData.Last(), TVDriveView.Nodes);
                DataManager.databaseChangesMade = true;
                LBLChangesMade.Visible = true;
            }
            else if (TXTDrivePath.Text == "")
            {
                MessageBox.Show("Please give a valid File Path.", "Path Missing");
            }
            else
            {
                MessageBox.Show("Please give a valid File Path.", "Path Invalid");
            }
        }

        /// <summary>
        /// Recursive loop through all DriveObjects to display to the Tree View Collection
        /// </summary>
        /// <param name="currentDriveObj"></param>
        /// <param name="nodes"></param>
        public void displayDriveContents(DriveObject currentDriveObj, TreeNodeCollection nodes)
        {
            TreeNode newNode = new TreeNode(currentDriveObj.name);
            nodes.Add(newNode);
            foreach (DriveObject obj in currentDriveObj.getSubDirectories())
            {
                displayDriveContents(obj, newNode.Nodes);
            }
        }

        /// <summary>
        /// Reads in all DriveObjects stored within the DataManager List
        /// </summary>
        public void displayDriveReadIn()
        {
            ClearTreeView();
            for (int i = 0; i < DataManager.DriveData.Count; i++)
            {
                if (DataManager.DriveData.ElementAt(i) == null)
                {
                    DataManager.DriveData.RemoveAt(i);
                    i--;
                    continue;
                }
                displayDriveContents(DataManager.DriveData.ElementAt(i), TVDriveView.Nodes);
            }
        }

        private void ClearTreeView()
        {
            TVDriveView.Nodes.Clear();
        }

        private void TVDriveView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("Selected the node: " + e.Node.Text);
            LBXFileData.Items.Clear();
            DriveObject selectedObject = getSelectedDriveObject(e.Node);
            List<string> attributes = DataManager.GetDriveObjectData(selectedObject);
            foreach (string att in attributes)
            {
                LBXFileData.Items.Add(att);
            }
        }

        private DriveObject getSelectedDriveObject(TreeNode node)
        {
            // Get the File Path of the Selected Node
            List<int> path = new List<int>();
            TreeNode n = node;
            while (n != null)
            {
                path.Add(n.Index);
                Console.WriteLine(path.Last());
                n = n.Parent;
            }

            // Index path is build with lowest first, so much switch to get root index first
            path.Reverse();

            // Path of indexes leading to the selected object
            DriveObject driveObject = DataManager.DriveData.ElementAt(path.ElementAt(0));
            for (int i = 1; i < path.Count; i++)
            {
                Console.WriteLine(driveObject.name);
                if (i == path.Count - 1)
                    parentOfCurrent = driveObject;
                driveObject = driveObject.getSubDirectory(path.ElementAt(i));

            }
            currentlySelectedObject = driveObject;
            return driveObject;
        }

        private void DisplayActiveDrives()
        {
            var driveList = DriveInfo.GetDrives();
            LBXDrives.Items.Clear();
            foreach (DriveInfo drive in driveList)
            {
                //if(drive.DriveType == DriveType.Removable)
                LBXDrives.Items.Add("Drive" + drive.Name);
                //bool driveExists = false;

                //Add to RemovableDrive list or whatever activity you want
            }
        }
        private void BTNWriteDriveData_Click(object sender, EventArgs e)
        {
            SerializeNewData();
        }

        private void SerializeNewData()
        {
            driveDatabase.SerializeDrives();
            MessageBox.Show("Data written to database", "Write Successful");
            DataManager.databaseChangesMade = false;
            LBLChangesMade.Visible = false;
        }

        private void BTNReadDriveData_Click(object sender, EventArgs e)
        {
            driveDatabase.ReadDriveSaves();
        }

        private void BTNRefreshDrives_Click(object sender, EventArgs e)
        {
            LBXDrives.Items.Clear();
            DisplayActiveDrives();
        }

        private void BTNClearFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the stored data? \n(Only do this if you know what you are doing)", "Clear Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                driveDatabase.ClearDB();
                DataManager.DriveData.Clear();
                displayDriveReadIn();
            }
        }

        private void BTNBackup_Click(object sender, EventArgs e)
        {
            driveDatabase.BackupDB();
        }

        private void BTNRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restore the backup? \n(Only do this if you know what you are doing)", "Backup Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                driveDatabase.RestoreDB();
                displayDriveReadIn();
            }
        }

        private void BTNFindFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TXTDrivePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;

            if (parentOfCurrent == null)
            {
                Console.WriteLine("Current: " + currentlySelectedObject.name + " : Parent is null");
                deleted = DataManager.DriveData.Remove(currentlySelectedObject);
            }
            else
            {
                Console.WriteLine("Current: " + currentlySelectedObject.name + " : Parent: " + parentOfCurrent.name);
                deleted = parentOfCurrent.getSubDirectories().Remove(currentlySelectedObject);
            }


            if (currentlySelectedObject != null)
            {
                var result = MessageBox.Show("Deleting " + currentlySelectedObject.name + ", Are you sure?", "Deleting Entry", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    currentlySelectedObject = null;
                    displayDriveReadIn();
                    MessageBox.Show("Entry Removed Successfully", "Delete Entry");
                    DataManager.databaseChangesMade = true;
                }
            }
            else
            {
                MessageBox.Show("Entry Not Found", "Delete Entry");
            }

        }
        #endregion

        #region StorageOptimization
        private void LBXDrivePriority_DragDrop(object sender, DragEventArgs e)
        {
            Point point = LBXDrivePriority.PointToClient(new Point(e.X, e.Y));
            int index = this.LBXDrivePriority.IndexFromPoint(point);
            if (index < 0) index = this.LBXDrivePriority.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            this.LBXDrivePriority.Items.Remove(data);
            this.LBXDrivePriority.Items.Insert(index, data);
            
        }

        private void LBXDrivePriority_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LBXDrivePriority_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.LBXDrivePriority.SelectedItem == null) return;
            this.LBXDrivePriority.DoDragDrop(this.LBXDrivePriority.SelectedItem, DragDropEffects.Move);
        }
        #endregion

        private void FRMMBDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(currentSubForm == TabFormControl.Search)
                {
                    RefreshSearch();
                }
                else if(currentSubForm == TabFormControl.DriveLoad)
                {
                    LoadNewDriveData();
                }
                else if(currentSubForm == TabFormControl.Welcome)
                {

                }
                e.Handled = true;
            }
        }

        private async void BTNScanSystem_Click(object sender, EventArgs e)
        {
            PGBarScanSystem.Visible = true;
            LBLProgress.Visible = true;
            this.Enabled = false;
            PGBarScanSystem.Value = 0;
            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                PGBarScanSystem.Value = v;
            });

            // Run operation in another thread
            await Task.Run(() => ScanSystem(progress));

            // Drive Manager Load
            DisplayActiveDrives();
            displayDriveReadIn();
            //PGBarScanSystem.Value = 75;
            driveDatabase.SerializeDrives();
            //await Task.Run(() => driveDatabase.SerializeDrives());

            PGBarScanSystem.Value = 100;
            PGBarScanSystem.Visible = false;
            LBLProgress.Visible = false;
            this.Enabled = true;
        }

        public void ScanSystem(IProgress<int> progress)
        {
            // This method is executed in the context of
            // another thread (different than the main UI thread),
            // so use only thread-safe code
            var SystemDrives = DriveInfo.GetDrives();
            for(int i = 0; i < SystemDrives.Length; i++)
            {
                // TODO: More Testing required, not sure if different systems would have different C drive names
                if (SystemDrives[i].DriveType != DriveType.Removable)
                    continue;
                // Clear matching drives from the data set
                bool newDrive = true;
                for(int j = 0; j < DataManager.DriveData.Count; j++)
                {
                    if(SystemDrives[i].Name == DataManager.DriveData.ElementAt(j).name)
                    {
                        //Matching Drive Found in Database, Remove drive from Database
                        DataManager.DriveData.RemoveAt(j);

                        // Read in Data from root drive
                        DataManager.DriveData.Insert(j, DriveReader.getDriveContents(SystemDrives.ElementAt(i).RootDirectory.FullName));
                        newDrive = false;
                    }
                }
                if (newDrive)
                {
                    // Read in Data from root drive
                    DataManager.DriveData.Add(DriveReader.getDriveContents(SystemDrives.ElementAt(i).RootDirectory.FullName));
                }

                // Use progress to notify UI thread that progress has
                // changed
                if (progress != null)
                    progress.Report((i * (int)(50/SystemDrives.Length)));
            }
            
        }

        
    }
}
