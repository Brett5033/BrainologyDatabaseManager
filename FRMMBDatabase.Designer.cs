namespace BrainologyDatabaseManager
{
    partial class FRMMBDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.PNLSubForms = new System.Windows.Forms.Panel();
            this.MTABWindowSelector = new MetroFramework.Controls.MetroTabControl();
            this.TPWelcome = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.TPDriveManager = new System.Windows.Forms.TabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BTNDelete = new MetroFramework.Controls.MetroButton();
            this.BTNRefreshDrives = new MetroFramework.Controls.MetroButton();
            this.BTNRestore = new MetroFramework.Controls.MetroButton();
            this.BTNBackup = new MetroFramework.Controls.MetroButton();
            this.BTNClearFile = new MetroFramework.Controls.MetroButton();
            this.BTNReadDriveData = new MetroFramework.Controls.MetroButton();
            this.BTNWriteDriveData = new MetroFramework.Controls.MetroButton();
            this.LBLFileData = new MetroFramework.Controls.MetroLabel();
            this.BTNFindFolder = new MetroFramework.Controls.MetroButton();
            this.BTNLoadDriveData = new MetroFramework.Controls.MetroButton();
            this.LBLDriveView = new MetroFramework.Controls.MetroLabel();
            this.LBLDrivePath = new MetroFramework.Controls.MetroLabel();
            this.LBXDrives = new System.Windows.Forms.ListBox();
            this.LBXFileData = new System.Windows.Forms.ListBox();
            this.TXTDrivePath = new System.Windows.Forms.TextBox();
            this.TVDriveView = new System.Windows.Forms.TreeView();
            this.TPSearchManager = new System.Windows.Forms.TabPage();
            this.TXTSearchData = new MetroFramework.Controls.MetroTextBox();
            this.TXTTagSearch = new MetroFramework.Controls.MetroTextBox();
            this.BTNSearch = new MetroFramework.Controls.MetroButton();
            this.ComboBXDriveSelect = new MetroFramework.Controls.MetroComboBox();
            this.CBXSpecifyDrive = new MetroFramework.Controls.MetroCheckBox();
            this.LBLTag = new MetroFramework.Controls.MetroLabel();
            this.LBLDriveSelect = new MetroFramework.Controls.MetroLabel();
            this.LBLSearch = new MetroFramework.Controls.MetroLabel();
            this.TXTSearch = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBXSize = new MetroFramework.Controls.MetroCheckBox();
            this.CBXAlpha = new MetroFramework.Controls.MetroCheckBox();
            this.CBXDate = new MetroFramework.Controls.MetroCheckBox();
            this.CBXDrive = new MetroFramework.Controls.MetroCheckBox();
            this.CLBXTags = new System.Windows.Forms.CheckedListBox();
            this.GBSearchAttributes = new System.Windows.Forms.GroupBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.CBXExactMatch = new MetroFramework.Controls.MetroCheckBox();
            this.GBXFilter = new System.Windows.Forms.GroupBox();
            this.RBTNTag = new MetroFramework.Controls.MetroRadioButton();
            this.RBTNName = new MetroFramework.Controls.MetroRadioButton();
            this.TVSearchView = new System.Windows.Forms.TreeView();
            this.TPStorageOptimization = new System.Windows.Forms.TabPage();
            this.BTNScanSystem = new MetroFramework.Controls.MetroButton();
            this.PGBarScanSystem = new MetroFramework.Controls.MetroProgressBar();
            this.LBXDrivePriority = new System.Windows.Forms.ListBox();
            this.LBLProgress = new MetroFramework.Controls.MetroLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.LBLDrivePriority = new MetroFramework.Controls.MetroLabel();
            this.LBLChangesMade = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.Col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Occurences = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTABWindowSelector.SuspendLayout();
            this.TPWelcome.SuspendLayout();
            this.TPDriveManager.SuspendLayout();
            this.TPSearchManager.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBSearchAttributes.SuspendLayout();
            this.GBXFilter.SuspendLayout();
            this.TPStorageOptimization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLSubForms
            // 
            this.PNLSubForms.AutoSize = true;
            this.PNLSubForms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNLSubForms.Location = new System.Drawing.Point(23, 143);
            this.PNLSubForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLSubForms.Name = "PNLSubForms";
            this.PNLSubForms.Size = new System.Drawing.Size(0, 0);
            this.PNLSubForms.TabIndex = 2;
            // 
            // MTABWindowSelector
            // 
            this.MTABWindowSelector.AllowDrop = true;
            this.MTABWindowSelector.Controls.Add(this.TPWelcome);
            this.MTABWindowSelector.Controls.Add(this.TPSearchManager);
            this.MTABWindowSelector.Controls.Add(this.TPDriveManager);
            this.MTABWindowSelector.Controls.Add(this.TPStorageOptimization);
            this.MTABWindowSelector.Location = new System.Drawing.Point(3, 63);
            this.MTABWindowSelector.Margin = new System.Windows.Forms.Padding(4);
            this.MTABWindowSelector.Name = "MTABWindowSelector";
            this.MTABWindowSelector.SelectedIndex = 3;
            this.MTABWindowSelector.Size = new System.Drawing.Size(1271, 730);
            this.MTABWindowSelector.Style = MetroFramework.MetroColorStyle.Magenta;
            this.MTABWindowSelector.TabIndex = 4;
            this.MTABWindowSelector.UseSelectable = true;
            this.MTABWindowSelector.Selected += new System.Windows.Forms.TabControlEventHandler(this.MTABWindowSelector_Selected);
            this.MTABWindowSelector.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MTABWindowSelector_Deselecting);
            // 
            // TPWelcome
            // 
            this.TPWelcome.BackColor = System.Drawing.SystemColors.Window;
            this.TPWelcome.Controls.Add(this.metroLabel1);
            this.TPWelcome.Controls.Add(this.label2);
            this.TPWelcome.Location = new System.Drawing.Point(4, 38);
            this.TPWelcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPWelcome.Name = "TPWelcome";
            this.TPWelcome.Size = new System.Drawing.Size(1111, 699);
            this.TPWelcome.TabIndex = 0;
            this.TPWelcome.Text = "  Welcome  ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(294, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(412, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Welcome, Database Software is a Work In Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 1;
            // 
            // TPDriveManager
            // 
            this.TPDriveManager.BackColor = System.Drawing.SystemColors.Window;
            this.TPDriveManager.Controls.Add(this.LBLChangesMade);
            this.TPDriveManager.Controls.Add(this.metroLabel2);
            this.TPDriveManager.Controls.Add(this.BTNDelete);
            this.TPDriveManager.Controls.Add(this.BTNRefreshDrives);
            this.TPDriveManager.Controls.Add(this.BTNRestore);
            this.TPDriveManager.Controls.Add(this.BTNBackup);
            this.TPDriveManager.Controls.Add(this.BTNClearFile);
            this.TPDriveManager.Controls.Add(this.BTNReadDriveData);
            this.TPDriveManager.Controls.Add(this.BTNWriteDriveData);
            this.TPDriveManager.Controls.Add(this.LBLFileData);
            this.TPDriveManager.Controls.Add(this.BTNFindFolder);
            this.TPDriveManager.Controls.Add(this.BTNLoadDriveData);
            this.TPDriveManager.Controls.Add(this.LBLDriveView);
            this.TPDriveManager.Controls.Add(this.LBLDrivePath);
            this.TPDriveManager.Controls.Add(this.LBXDrives);
            this.TPDriveManager.Controls.Add(this.LBXFileData);
            this.TPDriveManager.Controls.Add(this.TXTDrivePath);
            this.TPDriveManager.Controls.Add(this.TVDriveView);
            this.TPDriveManager.Location = new System.Drawing.Point(4, 38);
            this.TPDriveManager.Margin = new System.Windows.Forms.Padding(4);
            this.TPDriveManager.Name = "TPDriveManager";
            this.TPDriveManager.Padding = new System.Windows.Forms.Padding(31, 33, 31, 33);
            this.TPDriveManager.Size = new System.Drawing.Size(1263, 688);
            this.TPDriveManager.TabIndex = 2;
            this.TPDriveManager.Text = "  Drive Manager  ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(610, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 20);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "! Use Only If Trained !";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNDelete.Location = new System.Drawing.Point(279, 503);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(103, 29);
            this.BTNDelete.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNDelete.TabIndex = 48;
            this.BTNDelete.Text = "Delete Entry";
            this.BTNDelete.UseSelectable = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNRefreshDrives
            // 
            this.BTNRefreshDrives.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNRefreshDrives.Location = new System.Drawing.Point(594, 505);
            this.BTNRefreshDrives.Name = "BTNRefreshDrives";
            this.BTNRefreshDrives.Size = new System.Drawing.Size(77, 29);
            this.BTNRefreshDrives.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNRefreshDrives.TabIndex = 47;
            this.BTNRefreshDrives.Text = "Refresh";
            this.BTNRefreshDrives.UseSelectable = true;
            this.BTNRefreshDrives.Click += new System.EventHandler(this.BTNRefreshDrives_Click);
            // 
            // BTNRestore
            // 
            this.BTNRestore.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNRestore.Location = new System.Drawing.Point(680, 296);
            this.BTNRestore.Name = "BTNRestore";
            this.BTNRestore.Size = new System.Drawing.Size(77, 29);
            this.BTNRestore.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNRestore.TabIndex = 46;
            this.BTNRestore.Text = "Restore";
            this.BTNRestore.UseSelectable = true;
            this.BTNRestore.Click += new System.EventHandler(this.BTNRestore_Click);
            // 
            // BTNBackup
            // 
            this.BTNBackup.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNBackup.Location = new System.Drawing.Point(597, 296);
            this.BTNBackup.Name = "BTNBackup";
            this.BTNBackup.Size = new System.Drawing.Size(77, 29);
            this.BTNBackup.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNBackup.TabIndex = 45;
            this.BTNBackup.Text = "Backup";
            this.BTNBackup.UseSelectable = true;
            this.BTNBackup.Click += new System.EventHandler(this.BTNBackup_Click);
            // 
            // BTNClearFile
            // 
            this.BTNClearFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNClearFile.Location = new System.Drawing.Point(597, 260);
            this.BTNClearFile.Name = "BTNClearFile";
            this.BTNClearFile.Size = new System.Drawing.Size(77, 30);
            this.BTNClearFile.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNClearFile.TabIndex = 44;
            this.BTNClearFile.Text = "Clear";
            this.BTNClearFile.UseSelectable = true;
            this.BTNClearFile.Click += new System.EventHandler(this.BTNClearFile_Click);
            // 
            // BTNReadDriveData
            // 
            this.BTNReadDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNReadDriveData.Location = new System.Drawing.Point(439, 296);
            this.BTNReadDriveData.Name = "BTNReadDriveData";
            this.BTNReadDriveData.Size = new System.Drawing.Size(150, 29);
            this.BTNReadDriveData.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNReadDriveData.TabIndex = 43;
            this.BTNReadDriveData.Text = "Read Drive Data";
            this.BTNReadDriveData.UseSelectable = true;
            this.BTNReadDriveData.Click += new System.EventHandler(this.BTNReadDriveData_Click);
            // 
            // BTNWriteDriveData
            // 
            this.BTNWriteDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNWriteDriveData.Location = new System.Drawing.Point(439, 260);
            this.BTNWriteDriveData.Name = "BTNWriteDriveData";
            this.BTNWriteDriveData.Size = new System.Drawing.Size(152, 30);
            this.BTNWriteDriveData.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNWriteDriveData.TabIndex = 42;
            this.BTNWriteDriveData.Text = "Write Drive Data";
            this.BTNWriteDriveData.UseSelectable = true;
            this.BTNWriteDriveData.Click += new System.EventHandler(this.BTNWriteDriveData_Click);
            // 
            // LBLFileData
            // 
            this.LBLFileData.AutoSize = true;
            this.LBLFileData.Location = new System.Drawing.Point(439, 86);
            this.LBLFileData.Name = "LBLFileData";
            this.LBLFileData.Size = new System.Drawing.Size(62, 20);
            this.LBLFileData.TabIndex = 41;
            this.LBLFileData.Text = "File Data";
            // 
            // BTNFindFolder
            // 
            this.BTNFindFolder.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNFindFolder.Location = new System.Drawing.Point(411, 30);
            this.BTNFindFolder.Name = "BTNFindFolder";
            this.BTNFindFolder.Size = new System.Drawing.Size(114, 38);
            this.BTNFindFolder.TabIndex = 40;
            this.BTNFindFolder.Text = "File Explorer";
            this.BTNFindFolder.UseSelectable = true;
            this.BTNFindFolder.Click += new System.EventHandler(this.BTNFindFolder_Click);
            // 
            // BTNLoadDriveData
            // 
            this.BTNLoadDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNLoadDriveData.Location = new System.Drawing.Point(259, 78);
            this.BTNLoadDriveData.Name = "BTNLoadDriveData";
            this.BTNLoadDriveData.Size = new System.Drawing.Size(123, 28);
            this.BTNLoadDriveData.TabIndex = 39;
            this.BTNLoadDriveData.Text = "Load Drive Data";
            this.BTNLoadDriveData.UseSelectable = true;
            this.BTNLoadDriveData.Click += new System.EventHandler(this.BTNLoadDriveData_Click);
            // 
            // LBLDriveView
            // 
            this.LBLDriveView.AutoSize = true;
            this.LBLDriveView.Location = new System.Drawing.Point(25, 86);
            this.LBLDriveView.Name = "LBLDriveView";
            this.LBLDriveView.Size = new System.Drawing.Size(76, 20);
            this.LBLDriveView.TabIndex = 38;
            this.LBLDriveView.Text = "Drive View";
            // 
            // LBLDrivePath
            // 
            this.LBLDrivePath.AutoSize = true;
            this.LBLDrivePath.Location = new System.Drawing.Point(25, 22);
            this.LBLDrivePath.Name = "LBLDrivePath";
            this.LBLDrivePath.Size = new System.Drawing.Size(72, 20);
            this.LBLDrivePath.TabIndex = 37;
            this.LBLDrivePath.Text = "Drive Path";
            // 
            // LBXDrives
            // 
            this.LBXDrives.FormattingEnabled = true;
            this.LBXDrives.ItemHeight = 16;
            this.LBXDrives.Location = new System.Drawing.Point(439, 382);
            this.LBXDrives.Margin = new System.Windows.Forms.Padding(4);
            this.LBXDrives.Name = "LBXDrives";
            this.LBXDrives.Size = new System.Drawing.Size(232, 116);
            this.LBXDrives.TabIndex = 35;
            // 
            // LBXFileData
            // 
            this.LBXFileData.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXFileData.FormattingEnabled = true;
            this.LBXFileData.ItemHeight = 17;
            this.LBXFileData.Location = new System.Drawing.Point(439, 112);
            this.LBXFileData.Margin = new System.Windows.Forms.Padding(4);
            this.LBXFileData.Name = "LBXFileData";
            this.LBXFileData.Size = new System.Drawing.Size(471, 106);
            this.LBXFileData.TabIndex = 34;
            // 
            // TXTDrivePath
            // 
            this.TXTDrivePath.Location = new System.Drawing.Point(25, 46);
            this.TXTDrivePath.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDrivePath.Name = "TXTDrivePath";
            this.TXTDrivePath.Size = new System.Drawing.Size(357, 22);
            this.TXTDrivePath.TabIndex = 33;
            // 
            // TVDriveView
            // 
            this.TVDriveView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TVDriveView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVDriveView.Location = new System.Drawing.Point(25, 112);
            this.TVDriveView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVDriveView.Name = "TVDriveView";
            this.TVDriveView.Size = new System.Drawing.Size(357, 386);
            this.TVDriveView.TabIndex = 32;
            this.TVDriveView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVDriveView_AfterSelect);
            // 
            // TPSearchManager
            // 
            this.TPSearchManager.BackColor = System.Drawing.SystemColors.Window;
            this.TPSearchManager.Controls.Add(this.TXTSearchData);
            this.TPSearchManager.Controls.Add(this.TXTTagSearch);
            this.TPSearchManager.Controls.Add(this.BTNSearch);
            this.TPSearchManager.Controls.Add(this.ComboBXDriveSelect);
            this.TPSearchManager.Controls.Add(this.CBXSpecifyDrive);
            this.TPSearchManager.Controls.Add(this.LBLTag);
            this.TPSearchManager.Controls.Add(this.LBLDriveSelect);
            this.TPSearchManager.Controls.Add(this.LBLSearch);
            this.TPSearchManager.Controls.Add(this.TXTSearch);
            this.TPSearchManager.Controls.Add(this.groupBox1);
            this.TPSearchManager.Controls.Add(this.CLBXTags);
            this.TPSearchManager.Controls.Add(this.GBSearchAttributes);
            this.TPSearchManager.Controls.Add(this.GBXFilter);
            this.TPSearchManager.Controls.Add(this.TVSearchView);
            this.TPSearchManager.Location = new System.Drawing.Point(4, 38);
            this.TPSearchManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPSearchManager.Name = "TPSearchManager";
            this.TPSearchManager.Size = new System.Drawing.Size(1111, 699);
            this.TPSearchManager.TabIndex = 1;
            this.TPSearchManager.Text = "  Search Database  ";
            // 
            // TXTSearchData
            // 
            // 
            // 
            // 
            this.TXTSearchData.CustomButton.Image = null;
            this.TXTSearchData.CustomButton.Location = new System.Drawing.Point(397, 1);
            this.TXTSearchData.CustomButton.Name = "";
            this.TXTSearchData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTSearchData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSearchData.CustomButton.TabIndex = 1;
            this.TXTSearchData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSearchData.CustomButton.UseSelectable = true;
            this.TXTSearchData.CustomButton.Visible = false;
            this.TXTSearchData.Enabled = false;
            this.TXTSearchData.Lines = new string[0];
            this.TXTSearchData.Location = new System.Drawing.Point(341, 666);
            this.TXTSearchData.MaxLength = 32767;
            this.TXTSearchData.Name = "TXTSearchData";
            this.TXTSearchData.PasswordChar = '\0';
            this.TXTSearchData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTSearchData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSearchData.SelectedText = "";
            this.TXTSearchData.SelectionLength = 0;
            this.TXTSearchData.SelectionStart = 0;
            this.TXTSearchData.ShortcutsEnabled = true;
            this.TXTSearchData.Size = new System.Drawing.Size(419, 23);
            this.TXTSearchData.TabIndex = 41;
            this.TXTSearchData.UseSelectable = true;
            this.TXTSearchData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTSearchData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTTagSearch
            // 
            // 
            // 
            // 
            this.TXTTagSearch.CustomButton.Image = null;
            this.TXTTagSearch.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.TXTTagSearch.CustomButton.Name = "";
            this.TXTTagSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTTagSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTTagSearch.CustomButton.TabIndex = 1;
            this.TXTTagSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTTagSearch.CustomButton.UseSelectable = true;
            this.TXTTagSearch.CustomButton.Visible = false;
            this.TXTTagSearch.Lines = new string[0];
            this.TXTTagSearch.Location = new System.Drawing.Point(865, 146);
            this.TXTTagSearch.MaxLength = 32767;
            this.TXTTagSearch.Name = "TXTTagSearch";
            this.TXTTagSearch.PasswordChar = '\0';
            this.TXTTagSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTTagSearch.SelectedText = "";
            this.TXTTagSearch.SelectionLength = 0;
            this.TXTTagSearch.SelectionStart = 0;
            this.TXTTagSearch.ShortcutsEnabled = true;
            this.TXTTagSearch.Size = new System.Drawing.Size(230, 23);
            this.TXTTagSearch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTTagSearch.TabIndex = 40;
            this.TXTTagSearch.UseSelectable = true;
            this.TXTTagSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTTagSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTNSearch
            // 
            this.BTNSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNSearch.Location = new System.Drawing.Point(477, 66);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(116, 62);
            this.BTNSearch.TabIndex = 39;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseSelectable = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // ComboBXDriveSelect
            // 
            this.ComboBXDriveSelect.FormattingEnabled = true;
            this.ComboBXDriveSelect.ItemHeight = 24;
            this.ComboBXDriveSelect.Location = new System.Drawing.Point(127, 98);
            this.ComboBXDriveSelect.Name = "ComboBXDriveSelect";
            this.ComboBXDriveSelect.Size = new System.Drawing.Size(187, 30);
            this.ComboBXDriveSelect.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ComboBXDriveSelect.TabIndex = 38;
            this.ComboBXDriveSelect.UseSelectable = true;
            // 
            // CBXSpecifyDrive
            // 
            this.CBXSpecifyDrive.AutoSize = true;
            this.CBXSpecifyDrive.Location = new System.Drawing.Point(320, 103);
            this.CBXSpecifyDrive.Name = "CBXSpecifyDrive";
            this.CBXSpecifyDrive.Size = new System.Drawing.Size(108, 17);
            this.CBXSpecifyDrive.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSpecifyDrive.TabIndex = 37;
            this.CBXSpecifyDrive.Text = "Specify Drives:";
            this.CBXSpecifyDrive.UseSelectable = true;
            this.CBXSpecifyDrive.CheckedChanged += new System.EventHandler(this.CBXSpecifyDrive_CheckedChanged);
            // 
            // LBLTag
            // 
            this.LBLTag.AutoSize = true;
            this.LBLTag.Location = new System.Drawing.Point(767, 149);
            this.LBLTag.Name = "LBLTag";
            this.LBLTag.Size = new System.Drawing.Size(79, 20);
            this.LBLTag.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLTag.TabIndex = 36;
            this.LBLTag.Text = "Tag Search:";
            // 
            // LBLDriveSelect
            // 
            this.LBLDriveSelect.AutoSize = true;
            this.LBLDriveSelect.Location = new System.Drawing.Point(12, 98);
            this.LBLDriveSelect.Name = "LBLDriveSelect";
            this.LBLDriveSelect.Size = new System.Drawing.Size(86, 20);
            this.LBLDriveSelect.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLDriveSelect.TabIndex = 35;
            this.LBLDriveSelect.Text = "Drive Select:";
            // 
            // LBLSearch
            // 
            this.LBLSearch.AutoSize = true;
            this.LBLSearch.Location = new System.Drawing.Point(31, 48);
            this.LBLSearch.Name = "LBLSearch";
            this.LBLSearch.Size = new System.Drawing.Size(54, 20);
            this.LBLSearch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLSearch.TabIndex = 34;
            this.LBLSearch.Text = "Search:";
            // 
            // TXTSearch
            // 
            // 
            // 
            // 
            this.TXTSearch.CustomButton.Image = null;
            this.TXTSearch.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.TXTSearch.CustomButton.Name = "";
            this.TXTSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSearch.CustomButton.TabIndex = 1;
            this.TXTSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSearch.CustomButton.UseSelectable = true;
            this.TXTSearch.CustomButton.Visible = false;
            this.TXTSearch.Lines = new string[0];
            this.TXTSearch.Location = new System.Drawing.Point(104, 48);
            this.TXTSearch.MaxLength = 32767;
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PasswordChar = '\0';
            this.TXTSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSearch.SelectedText = "";
            this.TXTSearch.SelectionLength = 0;
            this.TXTSearch.SelectionStart = 0;
            this.TXTSearch.ShortcutsEnabled = true;
            this.TXTSearch.Size = new System.Drawing.Size(351, 23);
            this.TXTSearch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTSearch.TabIndex = 33;
            this.TXTSearch.UseSelectable = true;
            this.TXTSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBXSize);
            this.groupBox1.Controls.Add(this.CBXAlpha);
            this.groupBox1.Controls.Add(this.CBXDate);
            this.groupBox1.Controls.Add(this.CBXDrive);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(877, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 83);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // CBXSize
            // 
            this.CBXSize.AutoSize = true;
            this.CBXSize.Location = new System.Drawing.Point(84, 52);
            this.CBXSize.Name = "CBXSize";
            this.CBXSize.Size = new System.Drawing.Size(47, 17);
            this.CBXSize.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSize.TabIndex = 32;
            this.CBXSize.Text = "Size";
            this.CBXSize.UseSelectable = true;
            // 
            // CBXAlpha
            // 
            this.CBXAlpha.AutoSize = true;
            this.CBXAlpha.Location = new System.Drawing.Point(84, 24);
            this.CBXAlpha.Name = "CBXAlpha";
            this.CBXAlpha.Size = new System.Drawing.Size(57, 17);
            this.CBXAlpha.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXAlpha.TabIndex = 31;
            this.CBXAlpha.Text = "Alpha";
            this.CBXAlpha.UseSelectable = true;
            // 
            // CBXDate
            // 
            this.CBXDate.AutoSize = true;
            this.CBXDate.Location = new System.Drawing.Point(6, 52);
            this.CBXDate.Name = "CBXDate";
            this.CBXDate.Size = new System.Drawing.Size(51, 17);
            this.CBXDate.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXDate.TabIndex = 30;
            this.CBXDate.Text = "Date";
            this.CBXDate.UseSelectable = true;
            // 
            // CBXDrive
            // 
            this.CBXDrive.AutoSize = true;
            this.CBXDrive.Checked = true;
            this.CBXDrive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBXDrive.Location = new System.Drawing.Point(6, 24);
            this.CBXDrive.Name = "CBXDrive";
            this.CBXDrive.Size = new System.Drawing.Size(54, 17);
            this.CBXDrive.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXDrive.TabIndex = 29;
            this.CBXDrive.Text = "Drive";
            this.CBXDrive.UseSelectable = true;
            // 
            // CLBXTags
            // 
            this.CLBXTags.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLBXTags.FormattingEnabled = true;
            this.CLBXTags.Location = new System.Drawing.Point(767, 198);
            this.CLBXTags.Name = "CLBXTags";
            this.CLBXTags.Size = new System.Drawing.Size(328, 344);
            this.CLBXTags.TabIndex = 32;
            // 
            // GBSearchAttributes
            // 
            this.GBSearchAttributes.Controls.Add(this.metroCheckBox1);
            this.GBSearchAttributes.Controls.Add(this.CBXExactMatch);
            this.GBSearchAttributes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSearchAttributes.Location = new System.Drawing.Point(725, 37);
            this.GBSearchAttributes.Name = "GBSearchAttributes";
            this.GBSearchAttributes.Size = new System.Drawing.Size(128, 82);
            this.GBSearchAttributes.TabIndex = 30;
            this.GBSearchAttributes.TabStop = false;
            this.GBSearchAttributes.Text = " Quantifiers:";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(6, 52);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(94, 17);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroCheckBox1.TabIndex = 28;
            this.metroCheckBox1.Text = "Exact Match";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // CBXExactMatch
            // 
            this.CBXExactMatch.AutoSize = true;
            this.CBXExactMatch.Location = new System.Drawing.Point(6, 24);
            this.CBXExactMatch.Name = "CBXExactMatch";
            this.CBXExactMatch.Size = new System.Drawing.Size(94, 17);
            this.CBXExactMatch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXExactMatch.TabIndex = 27;
            this.CBXExactMatch.Text = "Exact Match";
            this.CBXExactMatch.UseSelectable = true;
            // 
            // GBXFilter
            // 
            this.GBXFilter.Controls.Add(this.RBTNTag);
            this.GBXFilter.Controls.Add(this.RBTNName);
            this.GBXFilter.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXFilter.Location = new System.Drawing.Point(619, 36);
            this.GBXFilter.Name = "GBXFilter";
            this.GBXFilter.Size = new System.Drawing.Size(84, 83);
            this.GBXFilter.TabIndex = 29;
            this.GBXFilter.TabStop = false;
            this.GBXFilter.Text = "Filter:";
            // 
            // RBTNTag
            // 
            this.RBTNTag.AutoSize = true;
            this.RBTNTag.Location = new System.Drawing.Point(6, 53);
            this.RBTNTag.Name = "RBTNTag";
            this.RBTNTag.Size = new System.Drawing.Size(45, 17);
            this.RBTNTag.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNTag.TabIndex = 28;
            this.RBTNTag.Text = "Tag";
            this.RBTNTag.UseSelectable = true;
            // 
            // RBTNName
            // 
            this.RBTNName.AutoSize = true;
            this.RBTNName.Checked = true;
            this.RBTNName.Location = new System.Drawing.Point(6, 25);
            this.RBTNName.Name = "RBTNName";
            this.RBTNName.Size = new System.Drawing.Size(59, 17);
            this.RBTNName.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNName.TabIndex = 27;
            this.RBTNName.TabStop = true;
            this.RBTNName.Text = "Name";
            this.RBTNName.UseSelectable = true;
            // 
            // TVSearchView
            // 
            this.TVSearchView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVSearchView.Location = new System.Drawing.Point(31, 156);
            this.TVSearchView.Name = "TVSearchView";
            this.TVSearchView.Size = new System.Drawing.Size(729, 501);
            this.TVSearchView.TabIndex = 28;
            this.TVSearchView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVSearchView_AfterSelect);
            // 
            // TPStorageOptimization
            // 
            this.TPStorageOptimization.BackColor = System.Drawing.SystemColors.Window;
            this.TPStorageOptimization.Controls.Add(this.metroListView1);
            this.TPStorageOptimization.Controls.Add(this.LBLDrivePriority);
            this.TPStorageOptimization.Controls.Add(this.LBXDrivePriority);
            this.TPStorageOptimization.Location = new System.Drawing.Point(4, 38);
            this.TPStorageOptimization.Name = "TPStorageOptimization";
            this.TPStorageOptimization.Size = new System.Drawing.Size(1263, 688);
            this.TPStorageOptimization.TabIndex = 3;
            this.TPStorageOptimization.Text = "  Storage Optimization  ";
            // 
            // BTNScanSystem
            // 
            this.BTNScanSystem.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNScanSystem.Location = new System.Drawing.Point(910, 14);
            this.BTNScanSystem.Name = "BTNScanSystem";
            this.BTNScanSystem.Size = new System.Drawing.Size(108, 39);
            this.BTNScanSystem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNScanSystem.TabIndex = 5;
            this.BTNScanSystem.Text = "Scan System";
            this.BTNScanSystem.UseSelectable = true;
            this.BTNScanSystem.Click += new System.EventHandler(this.BTNScanSystem_Click);
            // 
            // PGBarScanSystem
            // 
            this.PGBarScanSystem.Location = new System.Drawing.Point(910, 59);
            this.PGBarScanSystem.Name = "PGBarScanSystem";
            this.PGBarScanSystem.Size = new System.Drawing.Size(108, 23);
            this.PGBarScanSystem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.PGBarScanSystem.TabIndex = 7;
            this.PGBarScanSystem.Visible = false;
            // 
            // LBXDrivePriority
            // 
            this.LBXDrivePriority.AllowDrop = true;
            this.LBXDrivePriority.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXDrivePriority.FormattingEnabled = true;
            this.LBXDrivePriority.ItemHeight = 17;
            this.LBXDrivePriority.Location = new System.Drawing.Point(24, 57);
            this.LBXDrivePriority.Name = "LBXDrivePriority";
            this.LBXDrivePriority.Size = new System.Drawing.Size(117, 208);
            this.LBXDrivePriority.TabIndex = 0;
            this.LBXDrivePriority.DragDrop += new System.Windows.Forms.DragEventHandler(this.LBXDrivePriority_DragDrop);
            this.LBXDrivePriority.DragOver += new System.Windows.Forms.DragEventHandler(this.LBXDrivePriority_DragOver);
            this.LBXDrivePriority.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBXDrivePriority_MouseDown);
            // 
            // LBLProgress
            // 
            this.LBLProgress.AutoSize = true;
            this.LBLProgress.Location = new System.Drawing.Point(837, 61);
            this.LBLProgress.Name = "LBLProgress";
            this.LBLProgress.Size = new System.Drawing.Size(66, 20);
            this.LBLProgress.TabIndex = 8;
            this.LBLProgress.Text = "Progress:";
            this.LBLProgress.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LBLDrivePriority
            // 
            this.LBLDrivePriority.AutoSize = true;
            this.LBLDrivePriority.Location = new System.Drawing.Point(27, 31);
            this.LBLDrivePriority.Name = "LBLDrivePriority";
            this.LBLDrivePriority.Size = new System.Drawing.Size(92, 20);
            this.LBLDrivePriority.TabIndex = 1;
            this.LBLDrivePriority.Text = "Drive Priority:";
            // 
            // LBLChangesMade
            // 
            this.LBLChangesMade.AutoSize = true;
            this.LBLChangesMade.Location = new System.Drawing.Point(33, 651);
            this.LBLChangesMade.Name = "LBLChangesMade";
            this.LBLChangesMade.Size = new System.Drawing.Size(244, 20);
            this.LBLChangesMade.TabIndex = 50;
            this.LBLChangesMade.Text = "Changes Made, Please Write Changes";
            this.LBLChangesMade.Visible = false;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Name,
            this.Col_Occurences,
            this.Col_Path,
            this.Col_Date,
            this.Col_Size});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.metroListView1.Location = new System.Drawing.Point(161, 57);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(1087, 609);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // Col_Name
            // 
            this.Col_Name.Text = "Name";
            this.Col_Name.Width = 169;
            // 
            // Col_Occurences
            // 
            this.Col_Occurences.Text = "Occurences";
            this.Col_Occurences.Width = 117;
            // 
            // Col_Path
            // 
            this.Col_Path.Text = "Path";
            this.Col_Path.Width = 273;
            // 
            // Col_Date
            // 
            this.Col_Date.Text = "Date";
            this.Col_Date.Width = 149;
            // 
            // Col_Size
            // 
            this.Col_Size.Text = "Size";
            this.Col_Size.Width = 87;
            // 
            // FRMMBDatabase
            // 
            this.AcceptButton = this.BTNSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1278, 805);
            this.Controls.Add(this.LBLProgress);
            this.Controls.Add(this.PGBarScanSystem);
            this.Controls.Add(this.BTNScanSystem);
            this.Controls.Add(this.MTABWindowSelector);
            this.Controls.Add(this.PNLSubForms);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRMMBDatabase";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Marketing Brainology Database";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.FRMMBDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMMBDatabase_KeyDown);
            this.MTABWindowSelector.ResumeLayout(false);
            this.TPWelcome.ResumeLayout(false);
            this.TPWelcome.PerformLayout();
            this.TPDriveManager.ResumeLayout(false);
            this.TPDriveManager.PerformLayout();
            this.TPSearchManager.ResumeLayout(false);
            this.TPSearchManager.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBSearchAttributes.ResumeLayout(false);
            this.GBSearchAttributes.PerformLayout();
            this.GBXFilter.ResumeLayout(false);
            this.GBXFilter.PerformLayout();
            this.TPStorageOptimization.ResumeLayout(false);
            this.TPStorageOptimization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PNLSubForms;
        private MetroFramework.Controls.MetroTabControl MTABWindowSelector;
        private System.Windows.Forms.TabPage TPWelcome;
        private System.Windows.Forms.TabPage TPSearchManager;
        private System.Windows.Forms.TabPage TPDriveManager;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BTNDelete;
        private MetroFramework.Controls.MetroButton BTNRefreshDrives;
        private MetroFramework.Controls.MetroButton BTNRestore;
        private MetroFramework.Controls.MetroButton BTNBackup;
        private MetroFramework.Controls.MetroButton BTNClearFile;
        private MetroFramework.Controls.MetroButton BTNReadDriveData;
        private MetroFramework.Controls.MetroButton BTNWriteDriveData;
        private MetroFramework.Controls.MetroLabel LBLFileData;
        private MetroFramework.Controls.MetroButton BTNFindFolder;
        private MetroFramework.Controls.MetroButton BTNLoadDriveData;
        private MetroFramework.Controls.MetroLabel LBLDriveView;
        private MetroFramework.Controls.MetroLabel LBLDrivePath;
        private System.Windows.Forms.ListBox LBXDrives;
        private System.Windows.Forms.ListBox LBXFileData;
        private System.Windows.Forms.TextBox TXTDrivePath;
        private System.Windows.Forms.TreeView TVDriveView;
        private MetroFramework.Controls.MetroTextBox TXTSearchData;
        private MetroFramework.Controls.MetroTextBox TXTTagSearch;
        private MetroFramework.Controls.MetroButton BTNSearch;
        private MetroFramework.Controls.MetroComboBox ComboBXDriveSelect;
        private MetroFramework.Controls.MetroCheckBox CBXSpecifyDrive;
        private MetroFramework.Controls.MetroLabel LBLTag;
        private MetroFramework.Controls.MetroLabel LBLDriveSelect;
        private MetroFramework.Controls.MetroLabel LBLSearch;
        private MetroFramework.Controls.MetroTextBox TXTSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox CBXSize;
        private MetroFramework.Controls.MetroCheckBox CBXAlpha;
        private MetroFramework.Controls.MetroCheckBox CBXDate;
        private MetroFramework.Controls.MetroCheckBox CBXDrive;
        private System.Windows.Forms.CheckedListBox CLBXTags;
        private System.Windows.Forms.GroupBox GBSearchAttributes;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox CBXExactMatch;
        private System.Windows.Forms.GroupBox GBXFilter;
        private MetroFramework.Controls.MetroRadioButton RBTNTag;
        private MetroFramework.Controls.MetroRadioButton RBTNName;
        private System.Windows.Forms.TreeView TVSearchView;
        private System.Windows.Forms.TabPage TPStorageOptimization;
        private MetroFramework.Controls.MetroButton BTNScanSystem;
        private MetroFramework.Controls.MetroProgressBar PGBarScanSystem;
        private System.Windows.Forms.ListBox LBXDrivePriority;
        private MetroFramework.Controls.MetroLabel LBLProgress;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MetroFramework.Controls.MetroLabel LBLDrivePriority;
        private MetroFramework.Controls.MetroLabel LBLChangesMade;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader Col_Name;
        private System.Windows.Forms.ColumnHeader Col_Occurences;
        private System.Windows.Forms.ColumnHeader Col_Path;
        private System.Windows.Forms.ColumnHeader Col_Date;
        private System.Windows.Forms.ColumnHeader Col_Size;
    }
}