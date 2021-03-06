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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

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
        private DriveObject DM_CurrentlySelectedObject = null;
        private DriveObject DM_ParentOfCurrent = null;

        // Search Manager
        private int Search_SearchCount = 0;
        private int Search_TotalSearches = 0;
        private FilterOptions Search_filterOptions = new FilterOptions();
        private DriveObject Search_SelectedNode = null;
        private List<int> Search_SelectedNodeIndexes = new List<int>();
        private TagPreset Search_SelectedPreset = null;
        private List<List<DriveObject>> Search_DisplayedObjects;

        // Optimization Manager
        List<List<DriveObject>> Opti_DeletableObjects;
        string ExcelPath = string.Format(@"{0}\BrainologyDatbaseExcelSaves",Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        // Debug
        public bool DebugFormShowing = false;
        FRMDebug DebugForm;

        public FRMMBDatabase(DriveDB db)
        {
            InitializeComponent();
            this.Icon = BrainologyDatabaseManager.Properties.Resources.marketingbrainologylogo_icon;
            // Load all drive data from the XML File
            driveDatabase = db;
            
        }

        private void FRMMBDatabase_Load(object sender, EventArgs e)
        {
            driveDatabase.ReadXMLContents();
            Activate();

            // Drive Manager Load
            DisplayActiveDrives();
            displayDriveReadIn();

            // Search Manager Load
            Search_filterOptions = new FilterOptions();
            Search_DisplayedObjects = new List<List<DriveObject>>();
            RefreshTagList();
            RefreshPresetList();

            // Optimization

            // Debug
            DebugForm = new FRMDebug(this);
            HideDebug();

            //MTABWindowSelector.SelectTab((int)TabFormControl.Welcome);
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
                if (DataManager.UnsavedChanges)
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
                ListActiveDrives();
                
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

        #region Welcome
        private void LNKUserGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LNKUserGuide.Text);
        }

        private void LNKGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(LNKGithub.Text);
        }
        #endregion 

        #region SearchManager
        private void ReadInFilters()
        {
            if (RBTNName.Checked)
                Search_filterOptions.searchFilter = SearchFilter.Name;
            else
                Search_filterOptions.searchFilter = SearchFilter.Tag;

            //filterOptions.DriveSort 
            Search_filterOptions.exactMatch = CBXExactMatch.Checked;
            Search_filterOptions.DriveSort = CBXDrive.Checked;
            Search_filterOptions.AlphaSort = CBXAlpha.Checked;
            Search_filterOptions.DateSort = CBXDate.Checked;
            Search_filterOptions.SizeSort = CBXSize.Checked;
            Search_filterOptions.SpecifyDrives = CBXSpecifyDrive.Checked;
            if (Search_filterOptions.SpecifyDrives && ComboBXDriveSelect.SelectedIndex != -1)
            {
                Search_filterOptions.DriveIndex = ComboBXDriveSelect.SelectedIndex;
            }

        }

        private void RefreshSearch()
        {
            if (TXTSearch.Text != "")
            {
                

                ReadInFilters();
                Search_TotalSearches = 0;
                List<List<DriveObject>> matchingObjects = DataManager.SearchDrives(TXTSearch.Text, ref Search_TotalSearches, Search_filterOptions);
                Search_DisplayedObjects = matchingObjects;

                //Update Search Count
                Search_SearchCount = 0;
                foreach (List<DriveObject> list in matchingObjects)
                {
                    Search_SearchCount += list.Count;
                }

                //
                if (Search_SearchCount == 0)
                {
                    TVSearchView.Nodes.Clear();
                    TVSearchView.Nodes.Add("No Items Found");
                }
                else
                {
                    RefreshSearchResults();
                }

                TXTSearchData.Text = "Found " + Search_SearchCount + " Matching Entries in " + Search_TotalSearches + " Total Searches";
            }
        }

        private void RefreshSearchResults()
        {
            TVSearchView.Nodes.Clear();
            Search_SelectedNode = null;
            // Sort results by Drive, changing the root nodes for each
            if (Search_filterOptions.DriveSort)
            {
                for (int i = 0; i < Search_DisplayedObjects.Count; i++)
                {
                    /*if (Search_DisplayedObjects[i].Count == 0)
                    {
                        continue;
                    }*/

                    TreeNode driveNode = new TreeNode(DataManager.DriveData.ElementAt(i).name);

                    TVSearchView.Nodes.Add(driveNode);

                    // Filter Drive Input
                    if (Search_filterOptions.AlphaSort)
                    {
                        Search_DisplayedObjects[i] = DataManager.AlphaSortDriveObjects(Search_DisplayedObjects.ElementAt(i));
                    }
                    else if (Search_filterOptions.DateSort)
                    {
                        Search_DisplayedObjects[i] = DataManager.DateSortDriveObjects(Search_DisplayedObjects.ElementAt(i));
                    }
                    else if (Search_filterOptions.SizeSort)
                    {
                        Search_DisplayedObjects[i] = DataManager.SizeSortDriveObjects(Search_DisplayedObjects.ElementAt(i));
                    }

                    foreach (DriveObject obj in Search_DisplayedObjects.ElementAt(i))
                    {
                        TreeNode rootNode = new TreeNode(obj.name);

                        // If drive sort active, filters subnodes by root drive node
                        driveNode.Nodes.Add(rootNode);

                        rootNode.Nodes.Add(obj.getDriveObjectType() + ",  Date: " + obj.date.ToString() + ", Size: " + obj.getFormattedSize());

                        string existsOnDrives = "Exists on Drives: ";
                        for (int j = 0; j < Search_DisplayedObjects.Count; j++)
                        {
                            foreach (DriveObject driveObj in Search_DisplayedObjects.ElementAt(j))
                            {
                                if (obj.Equals(driveObj))
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
                    driveNode.Expand();

                }
            }
            else // Sort as one big ol list
            {
                List<DriveObject> massList = new List<DriveObject>();
                for (int i = 0; i < Search_DisplayedObjects.Count; i++)
                {
                    foreach (DriveObject obj in Search_DisplayedObjects.ElementAt(i))
                    {
                        massList.Add(obj);
                    }
                }

                // Filter Drive Input
                if (Search_filterOptions.AlphaSort)
                {
                    massList = DataManager.AlphaSortDriveObjects(massList);
                }
                else if (Search_filterOptions.DateSort)
                {
                    massList = DataManager.DateSortDriveObjects(massList);
                }
                else if (Search_filterOptions.SizeSort)
                {
                    massList = DataManager.SizeSortDriveObjects(massList);
                }

                foreach (DriveObject obj in massList)
                {
                    TreeNode rootNode = new TreeNode(obj.name);

                    // If drive sort active, filters subnodes by root drive node
                    TVSearchView.Nodes.Add(rootNode);

                    rootNode.Nodes.Add(obj.getDriveObjectType() + ",  Date: " + obj.date.ToString() + ", Size: " + obj.getFormattedSize());

                    string existsOnDrives = "Exists on Drives: ";
                    for (int j = 0; j < Search_DisplayedObjects.Count; j++)
                    {
                        foreach (DriveObject driveObj in Search_DisplayedObjects.ElementAt(j))
                        {
                            if (obj.Equals(driveObj))
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

        private void RefreshTagList()
        {

            List<string> checkedItems = new List<string>();
            foreach(string c in CLBXTags.CheckedItems)
            {
                checkedItems.Add(c);
            }

            CLBXTags.Items.Clear();
            DataManager.LogMessage(string.Format("{0} items in checked list", checkedItems.Count));
            
            foreach(Tag t in DataManager.RegisteredTags)
            {
                CLBXTags.Items.Add(t.ID);
                // Check if was checked
                
                if (checkedItems.Contains(t.ID))
                {
                    DataManager.LogMessage(string.Format("{0} was check, checking again", t.ID));
                    CLBXTags.SetItemChecked(CLBXTags.Items.Count - 1, true);
                }
            }
        }

        private void RefreshPresetList()
        {
            Search_SelectedPreset = null;
            LBXTagPresets.Items.Clear();
            foreach (TagPreset preset in DataManager.RegisteredPresets)
            {
                LBXTagPresets.Items.Add(preset.ID);
            }
        }

        private void LBXTagPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBXTagPresets.SelectedItem == null)
                return;
            string ID = LBXTagPresets.SelectedItem.ToString();
            Search_SelectedPreset = DataManager.GetPreset(ID);

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            RefreshSearch();
        }

        private void ListActiveDrives()
        {
            ComboBXDriveSelect.Items.Clear();
            foreach (DriveObject obj in DataManager.DriveData)
            {
                ComboBXDriveSelect.Items.Add(obj.name);
            }
        }
        private void CBXSpecifyDrive_CheckedChanged(object sender, EventArgs e)
        {
            ComboBXDriveSelect.Enabled = CBXSpecifyDrive.Checked;
            Search_filterOptions.SpecifyDrives = CBXSpecifyDrive.Checked;
        }

        private void TVSearchView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<int> indexes = new List<int>();
            TreeNode tNode = e.Node;
            // Just By-Pass The Data About a Node
            //if (tNode.Nodes.Count == 0)
            //    return;

            if(tNode.Parent == null && tNode.Nodes.Count == 0)
            {
                return;
            }
            
            while (tNode.Parent != null)
            {
                indexes.Add(tNode.Parent.Nodes.IndexOf(tNode));
                if (indexes.Last() < 0)
                {
                    DataManager.LogMessage(string.Format("{0} could not find self: Parent: {1}", tNode.Name, tNode.Parent.Name));
                    return;
                }
                tNode = tNode.Parent;
            }
            indexes.Add(TVSearchView.Nodes.IndexOf(tNode));
            indexes.Reverse();
            Search_SelectedNodeIndexes = indexes;

            foreach (int i in indexes)
                DataManager.LogMessage(i.ToString());
            //DataManager.LogMessage(string.Format("Fetching Data of {0}", tNode.Name));
            if (e.Node.Parent != null)
                Search_SelectedNode = Search_DisplayedObjects.ElementAt(indexes[0]).ElementAt(indexes[1]);
            else
                Search_SelectedNode = Search_DisplayedObjects.ElementAt(indexes[0]).ElementAt(0);
        }

        /// <summary>
        /// Search Tag Registry based on search filter, displaying results to the Tag Checked-ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TXTTagSearch_TextChanged(object sender, EventArgs e)
        {
            // Refresh Registered Tags
            CLBXTags.Items.Clear();
            string filter = TXTTagSearch.Text;
            filter = filter.ToUpper();
            filter.Replace(' ', '_');
            foreach(Tag tag in DataManager.RegisteredTags)
            {
                if(tag.ID.Contains(filter))
                {
                    CLBXTags.Items.Add(tag.ID);
                }
            }
        }

        private void BTNApplyTag_Click(object sender, EventArgs e)
        {
            if(Search_SelectedNode != null)
            {
                foreach(string tag in CLBXTags.CheckedItems)
                {
                    Tag t = DataManager.GetTag(tag);
                    if(t != null)
                    {
                        Search_SelectedNode.AddRegisteredTag(t);
                    }
                    else
                    {
                        DataManager.LogMessage(string.Format("Null tag found at {0}", tag));
                    }
                }
                DataManager.UnsavedChanges = true;
                RefreshSearchResults();
            }
            else
            {
                MessageBox.Show("No Search Item Selected, please select an item to apply a Tag", "Selection Error");
            }
        }

        private void BTNRemoveSelectedTags_Click(object sender, EventArgs e)
        {
            if (Search_SelectedNode != null)
            {
                foreach (string tag in CLBXTags.CheckedItems)
                {
                    Tag t = DataManager.GetTag(tag);
                    if (t != null)
                    {
                        Search_SelectedNode.RemoveRegisteredTag(t);
                    }
                    else
                    {
                        DataManager.LogMessage(string.Format("Null tag found at {0}", tag));
                    }
                }
                DataManager.UnsavedChanges = true;
                RefreshSearchResults();
            }
            else
            {
                MessageBox.Show("No Search Item Selected, please select an item to apply a Tag", "Selection Error");
            }
        }
        
        private void BTNClearSelectedTags_Click(object sender, EventArgs e)
        {
            foreach(int i in CLBXTags.CheckedIndices)
            {
                CLBXTags.SetItemChecked(i, false);
            }
            RefreshTagList();
        }

        private void BTNRemoveAllTags_Click(object sender, EventArgs e)
        {
            if (Search_SelectedNode != null)
            {
                foreach (string tag in CLBXTags.Items)
                {
                    Tag t = DataManager.GetTag(tag);
                    if (t != null)
                    {
                        Search_SelectedNode.RemoveRegisteredTag(t);
                    }
                    else
                    {
                        DataManager.LogMessage(string.Format("Null tag found at {0}", tag));
                    }
                }
                DataManager.UnsavedChanges = true;
                RefreshSearchResults();
            }
            else
            {
                MessageBox.Show("No Search Item Selected, please select an item to apply a Tag", "Selection Error");
            }
        }

        private void BTNTagCreate_Click(object sender, EventArgs e)
        {
            if(TXTTagWizardName.Text != "")
            {
                if (!DataManager.IsTagRegistered(TXTTagWizardName.Text))
                {
                    DataManager.RegisterTag(TXTTagWizardName.Text);
                }
                else
                {
                    MessageBox.Show("Tag is already registered", "Duplicate Tag");
                }
                DataManager.UnsavedChanges = true;
                RefreshTagList();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Tag Name to create a Tag", "Entry Error");
                TXTTagWizardName.Focus();
            }
        }

        private void BTNDeleteTag_Click(object sender, EventArgs e)
        {
            if(TXTTagWizardName.Text != "" && DataManager.IsTagRegistered(TXTTagWizardName.Text))
            {
                Tag t = DataManager.GetTag(TXTTagWizardName.Text);
                if(MessageBox.Show(string.Format("Are you sure you wish to delete the Tag ({0})\n This will delete the Tag from all file entires",t.ID),"Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Remove Tag from all DriveObjects
                    foreach(DriveObject root in DataManager.DriveData)
                    {
                        DeleteTagHelper(root, t);
                    }

                    // Remove Tag from all Presets
                    foreach(TagPreset preset in DataManager.RegisteredPresets)
                    {
                        if (preset.RemoveTag(t))
                            DataManager.LogMessage(string.Format("Tag ({0}) removed from preset {1}", t.ID, preset.ID));
                    }

                    DataManager.RegisteredTags.Remove(t);

                    // Refresh Tag List, Presets, and 
                    DataManager.UnsavedChanges = true;
                    RefreshSearchResults();
                    RefreshTagList();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Tag ID if you wish to delete a Tag", "Missing Tag ID");
                TXTTagWizardName.Focus();
            }
        }

        private void DeleteTagHelper(DriveObject currObj, Tag t)
        {
            foreach(DriveObject obj in currObj.getSubDirectories())
            {
                DeleteTagHelper(obj, t);
                if (obj.RemoveRegisteredTag(t))
                    DataManager.LogMessage(string.Format("Deleted Tag ({0}) from {1}", t.ID, obj.path));
            }
        }

        private void BTNApplyTagPreset_Click(object sender, EventArgs e)
        {
            if (Search_SelectedPreset != null)
            {
                for (int i = 0; i < CLBXTags.Items.Count; i++)
                {
                    if (Search_SelectedPreset.Tags.Contains(DataManager.GetTag(CLBXTags.Items[i].ToString())))
                        CLBXTags.SetItemChecked(i, true);
                    else
                        CLBXTags.SetItemChecked(i, false);
                }

                RefreshTagList();
            }
            else
            {
                MessageBox.Show("No Preset Selected, please select an item to apply a Tag", "Selection Error");
            }
        }

        private void BTNTagPresetAdd_Click(object sender, EventArgs e)
        {
            if (Search_SelectedPreset == null)
            {
                MessageBox.Show("Please Select a Preset before adding Tags", "No Preset Selected");
                return;
            }

            List<Tag> newTagList = new List<Tag>();
            foreach (int i in CLBXTags.CheckedIndices)
            {
                Tag t = DataManager.GetTag(CLBXTags.Items[i].ToString());
                newTagList.Add(t);
            }
            foreach(Tag t in newTagList)
            {
                if (!Search_SelectedPreset.Tags.Contains(t))
                {
                    Search_SelectedPreset.Tags.Add(t);
                    DataManager.LogMessage(string.Format("Tag ({0}) added to Preset {1}", t.ID, Search_SelectedPreset.ID));
                }
            }
            DataManager.UnsavedChanges = true;
        }

        private void BTNTagPresetRemove_Click(object sender, EventArgs e)
        {
            List<Tag> newTagList = new List<Tag>();
            foreach (int i in CLBXTags.CheckedIndices)
            {
                Tag t = DataManager.GetTag(CLBXTags.Items[i].ToString());
                newTagList.Add(t);
            }
            foreach (Tag t in newTagList)
            {
                if (Search_SelectedPreset.Tags.Contains(t))
                {
                    Search_SelectedPreset.Tags.Remove(t);
                    DataManager.LogMessage(string.Format("Tag ({0}) removed from Preset {1}", t.ID, Search_SelectedPreset.ID));
                }
            }
            DataManager.UnsavedChanges = true;
        }

        private void BTNNewTagPreset_Click(object sender, EventArgs e)
        {
            if (TXTTagPresetName.Text != "")
            {
                List<Tag> newTagList = new List<Tag>();
                foreach (int i in CLBXTags.CheckedIndices)
                {
                    Tag t = DataManager.GetTag(CLBXTags.Items[i].ToString());
                    newTagList.Add(t);
                }
                TagPreset preset = new TagPreset(TXTTagPresetName.Text, newTagList);
                if (!DataManager.RegisteredPresets.Contains(preset))
                {
                    DataManager.RegisteredPresets.Add(preset);
                    RefreshPresetList();
                    DataManager.UnsavedChanges = true;
                }
            }
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
        public async void LoadNewDriveData()
        {
            if (TXTDrivePath.Text != "" && Directory.Exists(TXTDrivePath.Text))
            {
                PGBarScanSystem.Visible = true;
                LBLProgress.Visible = true;
                PGBarScanSystem.Value = 0;

                DriveObject d = new DriveObject();
                await Task.Run(() => LoadNewDriveDataHelper(ref d));

                if (TXTNickname.Text != "")
                {
                    d.name = TXTNickname.Text;
                }
                DataManager.DriveData.Add(d);
                DataManager.ChangedObjects.Add(new DriveObject(d));
                displayDriveContents(DataManager.DriveData.Last(), TVDriveView.Nodes);
                DataManager.UnsavedChanges = true;

                PGBarScanSystem.Value = 100;
                PGBarScanSystem.Visible = false;
                LBLProgress.Visible = false;
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

        public void LoadNewDriveDataHelper(ref DriveObject d)
        {
            // Path is a valid directory
            d = DriveReader.getDriveContents(TXTDrivePath.Text);
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
            DataManager.LogMessage("Selected the node: " + e.Node.Text);
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
                DataManager.LogMessage(path.Last().ToString());
                n = n.Parent;
            }

            // Index path is build with lowest first, so much switch to get root index first
            path.Reverse();

            // Path of indexes leading to the selected object
            DriveObject driveObject = DataManager.DriveData.ElementAt(path.ElementAt(0));
            for (int i = 1; i < path.Count; i++)
            {
                DataManager.LogMessage(driveObject.name);
                if (i == path.Count - 1)
                    DM_ParentOfCurrent = driveObject;
                driveObject = driveObject.getSubDirectory(path.ElementAt(i));

            }
            DM_CurrentlySelectedObject = driveObject;
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
            driveDatabase.SerializeToXML();
            MessageBox.Show("Data written to database", "Write Successful");
            if (DataManager.UnsavedChanges)
                DataManager.DatabaseChanges = true;
            DataManager.UnsavedChanges = false;
            LBLChangesMade.Visible = false;
        }

        private void BTNReadDriveData_Click(object sender, EventArgs e)
        {
            driveDatabase.ReadXMLContents();
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
            if (DM_CurrentlySelectedObject != null)
            {
                var result = MessageBox.Show("Deleting " + DM_CurrentlySelectedObject.name + ", Are you sure?", "Deleting Entry", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    

                    bool deleted = false;

                    if (DM_ParentOfCurrent == null)
                    {
                        DataManager.LogMessage("Current: " + DM_CurrentlySelectedObject.name + " : Parent is null");
                        deleted = DataManager.DriveData.Remove(DM_CurrentlySelectedObject);
                    }
                    else
                    {
                        DataManager.LogMessage("Current: " + DM_CurrentlySelectedObject.name + " : Parent: " + DM_ParentOfCurrent.name);
                        deleted = DM_ParentOfCurrent.getSubDirectories().Remove(DM_CurrentlySelectedObject);
                    }

                    if (deleted)
                    {
                        DataManager.ChangedObjects.Add(new DriveObject(DM_CurrentlySelectedObject));
                        displayDriveReadIn();
                        MessageBox.Show("Entry Removed Successfully", "Delete Entry");
                        DataManager.UnsavedChanges = true;
                        LBLChangesMade.Enabled = true;
                        DM_CurrentlySelectedObject = null;
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Attempt to delete {0} failed", DM_CurrentlySelectedObject.path), "Deletion Failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Entry Not Found", "Delete Entry");
            }

        }

        private void BTNUploadXML_Click(object sender, EventArgs e)
        {
            driveDatabase.UploadGoogleDriveData(true);
        }

        private void BTNDownloadXML_Click(object sender, EventArgs e)
        {
            driveDatabase.DownloadGoogleDriveData();
            displayDriveReadIn();
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

        private int[] GetDrivePriority()
        {
            int[] sortedArray = new int[DataManager.DriveData.Count];
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < sortedArray.Length; j++)
                {
                    if (LBXDrivePriority.Items[i].ToString() == DataManager.DriveData.ElementAt(j).name)
                    {
                        // Match Found, add to List
                        sortedArray[i] = j;
                        break;
                    }
                }
            }
            return sortedArray;
        }

        private void ProcessOptimization()
        {
            if (TXTOptiNumCopies.Text == "" || !Int32.TryParse(TXTOptiNumCopies.Text, out int copiesAllowed))
            {
                MessageBox.Show("Please input a valid whole number for # of Copies", "Input Error");
            }
            else if (TXTMinimumSize.Text == "" || !Decimal.TryParse(TXTMinimumSize.Text, out decimal minimumSize))
            {
                MessageBox.Show("Please input a valid decimal or whole number for Minimum Size", "Input Error");
            }
            else
            {
                int[] sortedDrivePriority = GetDrivePriority();
                minimumSize *= 1024;

                // Set Filter Options and then search by Filter

                bool Both = RBTNOptiBoth.Checked;
                bool FoldersOnly = RBTNOptFoldersOnly.Checked;
                bool FilesOnly = RBTNOptiFilesOnly.Checked;
                FilterOptions filterOptions = new FilterOptions();
                filterOptions.AlphaSort = true;
                int count = 0;
                List<List<DriveObject>> FilteredList = DataManager.SearchDrives(TXTOptiFilter.Text, ref count, filterOptions);
                List<List<DriveObject>> PriorityList = new List<List<DriveObject>>();
                // Sort results according to drive priority
                for (int i = 0; i < FilteredList.Count; i++)
                {
                    PriorityList.Add(FilteredList.ElementAt(sortedDrivePriority[i]));
                }

                // We have a 2d list of all matching DriveObjects

                var dictionary = new Dictionary<DriveObject, int>();
                Opti_DeletableObjects = new List<List<DriveObject>>();

                for (int i = 0; i < PriorityList.Count; i++)
                {
                    Opti_DeletableObjects.Add(new List<DriveObject>());
                    foreach (DriveObject obj in PriorityList.ElementAt(i))
                    {
                        // Check Filters
                        if (Both || FoldersOnly && obj.driveObjectType == DriveObject.DriveObjectType.Directory || FilesOnly && obj.driveObjectType == DriveObject.DriveObjectType.File)
                        {
                            if (dictionary.ContainsKey(obj))
                            {
                                // At least 1 copy has been found
                                // Add to count value, if above copies allowed
                                int copies = 0;
                                if (dictionary.TryGetValue(obj, out copies))
                                {
                                    // Increments the map count (ie. adding itself)
                                    copies++;
                                    if (copies > copiesAllowed)
                                    {
                                        // Found a duplicate that can be deleted
                                        Opti_DeletableObjects.ElementAt(i).Add(obj);
                                    }
                                }
                            }
                            else
                            {
                                // Object is not present, add to list
                                dictionary.Add(obj, 1);
                            }
                        }
                    }
                }
                if (CBXConsolidateResults.Checked)
                    ConsolidateResults();
                if (!CBXSaveToExcel.Checked)
                    DisplayOptimizationList(sortedDrivePriority, minimumSize);
                else
                    WriteExcelSheet(sortedDrivePriority, minimumSize);
            }
        }
        private void BTNProcessOptimization_Click(object sender, EventArgs e)
        {
            ProcessOptimization();
        }

        /// <summary>
        /// Minimizes the list of Deletable DriveObjects by removing child Objects whose parent and siblings are also deletable
        /// </summary>
        private void ConsolidateResults()
        {
            for(int i = 0; i < DataManager.DriveData.Count; i++)
            {
                DataManager.LogMessage(string.Format("{0} deletable objects in {1} before Consolidation", Opti_DeletableObjects.ElementAt(i).Count, DataManager.DriveData.ElementAt(i).name));
                ConsolidateHelper(i, DataManager.DriveData.ElementAt(i), false);
                DataManager.LogMessage(string.Format("{0} deletable objects in {1} after Consolidation", Opti_DeletableObjects.ElementAt(i).Count, DataManager.DriveData.ElementAt(i).name));
                // A root node should never be removed cause yeah
            }
        }

        private bool ConsolidateHelper(int listIndex, DriveObject currObj, bool IntentToRemove)
        {
            if (!IntentToRemove) // First Pass, looking to see if children match
            {
                bool AllChildrenAreRedundant = true;
                for (int i = 0; i < currObj.getSubDirectories().Count; i++)
                {
                    if (!ConsolidateHelper(listIndex, currObj.getSubDirectory(i), false))
                    {
                        // A single child is not deletable, the whole root folder should not be deleted
                        AllChildrenAreRedundant = false;
                    }
                }
                if (AllChildrenAreRedundant)
                {
                    // All children should be removed from the deletable list
                    for (int i = 0; i < currObj.getSubDirectories().Count; i++)
                    {
                        ConsolidateHelper(listIndex, currObj.getSubDirectory(i), true);
                    }
                }
                // True only if itself and all its children are deletable
                return DriveObjectIsDeletable(currObj) && AllChildrenAreRedundant;
            }
            else
            {
                // I think this doesnt not have to traverse down as each parent should only have to look at its children nodes
                return Opti_DeletableObjects.ElementAt(listIndex).Remove(currObj);
            }

        }

        private bool DriveObjectIsDeletable(DriveObject obj)
        {
            foreach(List<DriveObject> list in Opti_DeletableObjects)
            {
                if (list.Contains(obj))
                    return true;
            }
            return false;
        }

        private void DisplayOptimizationList(int[] priorityList, decimal minSize)
        {
            LVOptimizationResults.Items.Clear();
            for(int i = 0; i < Opti_DeletableObjects.Count; i++)
            {
                string driveName = i + ":" + DataManager.DriveData.ElementAt(priorityList[i]).name;
                //DataManager.LogMessage(string.Format("{0} Deletable Objects in {1} found",Opti_DeletableObjects.ElementAt(i).Count , driveName));
                var driveGroup = new ListViewGroup();
                driveGroup.Name = driveName;
                driveGroup.Header = driveName;
                LVOptimizationResults.Groups.Add(driveGroup);
                
                foreach(DriveObject obj in Opti_DeletableObjects.ElementAt(i))
                {
                    if (obj.size < minSize)
                        continue;
                    string[] values = { obj.name, obj.path, obj.date.ToString(), obj.getFormattedSize() };
                    var item = new ListViewItem();
                    item.Text = obj.name;
                    item.SubItems.Add(obj.path);
                    item.SubItems.Add(obj.date.ToString());
                    item.SubItems.Add(obj.getFormattedSize());
                    item.BackColor = Color.Red;
                    //DataManager.LogMessage(item.ToString());

                    // Add to both list and grouping
                    LVOptimizationResults.Items.Add(item);
                    driveGroup.Items.Add(item);
                }
                
                
            }
        }

        private void WriteExcelSheet(int[] priorityList, decimal minSize)
        {
            Excel.Application xlApp = new Excel.Application();
            if(xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed, please check that excel is working first.", "Excel Error");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet = new Excel.Worksheet();
            object misValue = System.Reflection.Missing.Value;
            string fileName = "Brainology_Database_Optimization.xls";

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            int driveOffset = 0;
            for(int i = 0; i < priorityList.Length; i++)
            {
                if(Opti_DeletableObjects.ElementAt(i).Count == 0)
                {
                    // Skip Drive, increase i offset to keep Worksheets in order
                    driveOffset++;
                    continue;
                }

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(xlWorkBook.Worksheets[i+1-driveOffset], misValue, misValue, misValue);
                xlWorkSheet.Name = DataManager.DriveData.ElementAt(priorityList[i]).name;
                
                xlWorkSheet.Cells[1, 1] = "Name";
                xlWorkSheet.Cells[1, 2] = "Path";
                xlWorkSheet.Cells[1, 3] = "Date";
                xlWorkSheet.Cells[1, 4] = "Size";

                int xOffset = 0;
                for (int x = 2; x <= Opti_DeletableObjects.ElementAt(i).Count+1; x++)
                {
                    if (Opti_DeletableObjects.ElementAt(i).ElementAt(x - 2).size > minSize)
                    {
                        // An individual Drive Object
                        xlWorkSheet.Cells[x - xOffset, 1] = Opti_DeletableObjects.ElementAt(i).ElementAt(x - 2).name;
                        xlWorkSheet.Cells[x - xOffset, 2] = Opti_DeletableObjects.ElementAt(i).ElementAt(x - 2).path;
                        xlWorkSheet.Cells[x - xOffset, 3] = Opti_DeletableObjects.ElementAt(i).ElementAt(x - 2).date.ToString();
                        xlWorkSheet.Cells[x - xOffset, 4] = Opti_DeletableObjects.ElementAt(i).ElementAt(x - 2).getFormattedSize();
                    }
                    else
                    {
                        //DataManager.LogMessage(string.Format("The size of {0} is smaller than the min {1} kb)", Opti_DeletableObjects.ElementAt(i).ElementAt(x - 2).size, minSize));
                        xOffset++;
                    }
                }
                xlWorkSheet.Columns.AutoFit();
            }

            if(!Directory.Exists(ExcelPath))
            {
                Directory.CreateDirectory(ExcelPath);
            }

            DataManager.LogMessage(string.Format(@"Attempting to save Excel Sheet to {0}\.{1}", ExcelPath, fileName));
            if (Directory.Exists(ExcelPath))
            {
                DataManager.LogMessage("Directory Exists");
                xlWorkBook.SaveAs(string.Format(@"{0}\.{1}", ExcelPath, fileName), Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }
            else
            {
                DataManager.LogMessage("Directory Not Found");
            }
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show(string.Format("Your Excel File is saved to {0}", ExcelPath));
            Process.Start("explorer", string.Format(@"{0}\.{1}", ExcelPath, fileName));
        }
        #endregion

        #region Debug

        private void HideDebug()
        {
            
            if (DebugForm == null || !DebugFormShowing)
                DataManager.LogMessage("Debug Page is null");
            else
            {
                DebugForm.Close();
                DebugFormShowing = false;
            }
        }

        private void ShowDebug()
        {
            if (DebugFormShowing)
                return;
            DebugForm = new FRMDebug(this);
            DebugForm.Show();
            DebugFormShowing = true;
        }
        
        #endregion

        private void FRMMBDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Enter)
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
                else if (currentSubForm == TabFormControl.Optimization)
                {
                    ProcessOptimization();
                }
                e.Handled = true;
            }
            if(e.Control && e.Control && e.KeyCode == Keys.D)
            {
                if (DebugFormShowing)
                {
                    HideDebug();
                }
                else
                {
                    ShowDebug();
                }
                
            }
        }

        private async void BTNScanSystem_Click(object sender, EventArgs e)
        {
            DataManager.LogMessage("Starting System Scan");
            PGBarScanSystem.Visible = true;
            LBLProgress.Visible = true;
            //this.Enabled = false;
            PGBarScanSystem.Value = 0;
            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                PGBarScanSystem.Value = v;
            });

            // Run operation in another thread

            await Task.Run(() => ScanSystem(progress));


            //PGBarScanSystem.Value = 75;
            if (DataManager.UnsavedChanges)
            {
                driveDatabase.SerializeToXML();
                driveDatabase.UploadGoogleDriveData(false);
            }
            //await Task.Run(() => driveDatabase.SerializeDrives());
            
            // Drive Manager Load
            DisplayActiveDrives();
            displayDriveReadIn();

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
            string RootPath = Path.GetPathRoot(Environment.SystemDirectory);
            if (SystemDrives.Length > 0)
                DataManager.UnsavedChanges = true;
            for(int i = 0; i < SystemDrives.Length; i++)
            {
                // TODO: More Testing required, not sure if different systems would have different C drive names
                if (SystemDrives[i].RootDirectory.FullName == RootPath)
                {
                    DataManager.LogMessage(SystemDrives[i].Name + " is Root Directory, Pass");
                    continue;
                }
                // Clear matching drives from the data set
                bool newDrive = true;
                for(int j = 0; j < DataManager.DriveData.Count; j++)
                {
                    if(SystemDrives[i].Name == DataManager.DriveData.ElementAt(j).name || SystemDrives[i].VolumeLabel == DataManager.DriveData.ElementAt(j).name)
                    {
                        //Matching Drive Found in Database, Remove drive from Database
                        DataManager.DriveData.RemoveAt(j);

                        // Read in Data from root drive
                        DriveObject d = DriveReader.getDriveContents(SystemDrives.ElementAt(i).RootDirectory.FullName, SystemDrives.ElementAt(i).VolumeLabel);
                        DataManager.DriveData.Insert(j, d);
                        DataManager.ChangedObjects.Add(new DriveObject(d));
                        newDrive = false;
                    }
                }
                if (newDrive)
                {
                    // Read in Data from root drive
                    DataManager.LogMessage("New Drive Found");
                    DataManager.DriveData.Add(DriveReader.getDriveContents(SystemDrives.ElementAt(i).RootDirectory.FullName, SystemDrives.ElementAt(i).VolumeLabel));
                }

                // Use progress to notify UI thread that progress has
                // changed
                if (progress != null)
                    progress.Report((i * (int)(50/SystemDrives.Length)));
            }
            
        }

        private bool asyncShouldClose = false;
        private async void FRMMBDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!asyncShouldClose)
            {

                e.Cancel = true;
                try
                {
                    LBLFormClosing.Visible = true;
                    await Task.Run(() => ClosingFormHelper());
                }
                finally
                {
                    LBLFormClosing.Visible = false;
                }

                DataManager.LogMessage("Form Closing");
                asyncShouldClose = true;
                Close();
            }
        }

        private void ClosingFormHelper()
        {
            // Form Closing, Write and upload all changes
            if (DataManager.UnsavedChanges)
                driveDatabase.SerializeToXML();
            if (DataManager.DatabaseChanges)
                driveDatabase.UploadGoogleDriveData(false);
        }

        private void TTMain_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
