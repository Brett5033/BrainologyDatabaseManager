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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            this.PNLSubForms = new System.Windows.Forms.Panel();
            this.MTABWindowSelector = new MetroFramework.Controls.MetroTabControl();
            this.TPWelcome = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.TPDriveManager = new System.Windows.Forms.TabPage();
            this.BTNUploadXML = new MetroFramework.Controls.MetroButton();
            this.BTNDownloadXML = new MetroFramework.Controls.MetroButton();
            this.TXTDrivePath = new MetroFramework.Controls.MetroTextBox();
            this.TXTNickname = new MetroFramework.Controls.MetroTextBox();
            this.LBLNickname = new MetroFramework.Controls.MetroLabel();
            this.LBLChangesMade = new MetroFramework.Controls.MetroLabel();
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
            this.TVDriveView = new System.Windows.Forms.TreeView();
            this.TPStorageOptimization = new System.Windows.Forms.TabPage();
            this.LBLOptiNumCopies = new MetroFramework.Controls.MetroLabel();
            this.TXTOptiNumCopies = new MetroFramework.Controls.MetroTextBox();
            this.LBLOptiFilter = new MetroFramework.Controls.MetroLabel();
            this.TXTOptiFilter = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.RBTNOptiBoth = new MetroFramework.Controls.MetroRadioButton();
            this.RBTNOptiFilesOnly = new MetroFramework.Controls.MetroRadioButton();
            this.RBTNOptFoldersOnly = new MetroFramework.Controls.MetroRadioButton();
            this.BTNProcessOptimization = new MetroFramework.Controls.MetroButton();
            this.LVOptimizationResults = new MetroFramework.Controls.MetroListView();
            this.Col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBLDrivePriority = new MetroFramework.Controls.MetroLabel();
            this.LBXDrivePriority = new System.Windows.Forms.ListBox();
            this.BTNScanSystem = new MetroFramework.Controls.MetroButton();
            this.PGBarScanSystem = new MetroFramework.Controls.MetroProgressBar();
            this.LBLProgress = new MetroFramework.Controls.MetroLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.LBLUploadProgress = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MTABWindowSelector.SuspendLayout();
            this.TPWelcome.SuspendLayout();
            this.TPSearchManager.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBSearchAttributes.SuspendLayout();
            this.GBXFilter.SuspendLayout();
            this.TPDriveManager.SuspendLayout();
            this.TPStorageOptimization.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLSubForms
            // 
            this.PNLSubForms.AutoSize = true;
            this.PNLSubForms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNLSubForms.Location = new System.Drawing.Point(17, 116);
            this.PNLSubForms.Margin = new System.Windows.Forms.Padding(2);
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
            this.MTABWindowSelector.Location = new System.Drawing.Point(3, 87);
            this.MTABWindowSelector.Name = "MTABWindowSelector";
            this.MTABWindowSelector.SelectedIndex = 3;
            this.MTABWindowSelector.Size = new System.Drawing.Size(963, 599);
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
            this.TPWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.TPWelcome.Name = "TPWelcome";
            this.TPWelcome.Size = new System.Drawing.Size(955, 557);
            this.TPWelcome.TabIndex = 0;
            this.TPWelcome.Text = "  Welcome  ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(220, 17);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(394, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Welcome, Database Software is a Work In Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 1;
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
            this.TPSearchManager.Margin = new System.Windows.Forms.Padding(2);
            this.TPSearchManager.Name = "TPSearchManager";
            this.TPSearchManager.Size = new System.Drawing.Size(955, 557);
            this.TPSearchManager.TabIndex = 1;
            this.TPSearchManager.Text = "  Search Database  ";
            // 
            // TXTSearchData
            // 
            // 
            // 
            // 
            this.TXTSearchData.CustomButton.Image = null;
            this.TXTSearchData.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TXTSearchData.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSearchData.CustomButton.Name = "";
            this.TXTSearchData.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TXTSearchData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSearchData.CustomButton.TabIndex = 1;
            this.TXTSearchData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSearchData.CustomButton.UseSelectable = true;
            this.TXTSearchData.CustomButton.Visible = false;
            this.TXTSearchData.Enabled = false;
            this.TXTSearchData.Lines = new string[0];
            this.TXTSearchData.Location = new System.Drawing.Point(256, 541);
            this.TXTSearchData.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSearchData.MaxLength = 32767;
            this.TXTSearchData.Name = "TXTSearchData";
            this.TXTSearchData.PasswordChar = '\0';
            this.TXTSearchData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTSearchData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSearchData.SelectedText = "";
            this.TXTSearchData.SelectionLength = 0;
            this.TXTSearchData.SelectionStart = 0;
            this.TXTSearchData.ShortcutsEnabled = true;
            this.TXTSearchData.Size = new System.Drawing.Size(314, 19);
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
            this.TXTTagSearch.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.TXTTagSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTagSearch.CustomButton.Name = "";
            this.TXTTagSearch.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TXTTagSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTTagSearch.CustomButton.TabIndex = 1;
            this.TXTTagSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTTagSearch.CustomButton.UseSelectable = true;
            this.TXTTagSearch.CustomButton.Visible = false;
            this.TXTTagSearch.Lines = new string[0];
            this.TXTTagSearch.Location = new System.Drawing.Point(649, 119);
            this.TXTTagSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTagSearch.MaxLength = 32767;
            this.TXTTagSearch.Name = "TXTTagSearch";
            this.TXTTagSearch.PasswordChar = '\0';
            this.TXTTagSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTTagSearch.SelectedText = "";
            this.TXTTagSearch.SelectionLength = 0;
            this.TXTTagSearch.SelectionStart = 0;
            this.TXTTagSearch.ShortcutsEnabled = true;
            this.TXTTagSearch.Size = new System.Drawing.Size(172, 19);
            this.TXTTagSearch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTTagSearch.TabIndex = 40;
            this.TXTTagSearch.UseSelectable = true;
            this.TXTTagSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTTagSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTNSearch
            // 
            this.BTNSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNSearch.Location = new System.Drawing.Point(358, 54);
            this.BTNSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(87, 50);
            this.BTNSearch.TabIndex = 39;
            this.BTNSearch.Text = "Search";
            this.BTNSearch.UseSelectable = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // ComboBXDriveSelect
            // 
            this.ComboBXDriveSelect.FormattingEnabled = true;
            this.ComboBXDriveSelect.ItemHeight = 23;
            this.ComboBXDriveSelect.Location = new System.Drawing.Point(95, 80);
            this.ComboBXDriveSelect.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBXDriveSelect.Name = "ComboBXDriveSelect";
            this.ComboBXDriveSelect.Size = new System.Drawing.Size(141, 29);
            this.ComboBXDriveSelect.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ComboBXDriveSelect.TabIndex = 38;
            this.ComboBXDriveSelect.UseSelectable = true;
            // 
            // CBXSpecifyDrive
            // 
            this.CBXSpecifyDrive.AutoSize = true;
            this.CBXSpecifyDrive.Location = new System.Drawing.Point(240, 84);
            this.CBXSpecifyDrive.Margin = new System.Windows.Forms.Padding(2);
            this.CBXSpecifyDrive.Name = "CBXSpecifyDrive";
            this.CBXSpecifyDrive.Size = new System.Drawing.Size(99, 15);
            this.CBXSpecifyDrive.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSpecifyDrive.TabIndex = 37;
            this.CBXSpecifyDrive.Text = "Specify Drives:";
            this.CBXSpecifyDrive.UseSelectable = true;
            this.CBXSpecifyDrive.CheckedChanged += new System.EventHandler(this.CBXSpecifyDrive_CheckedChanged);
            // 
            // LBLTag
            // 
            this.LBLTag.AutoSize = true;
            this.LBLTag.Location = new System.Drawing.Point(575, 121);
            this.LBLTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLTag.Name = "LBLTag";
            this.LBLTag.Size = new System.Drawing.Size(75, 19);
            this.LBLTag.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLTag.TabIndex = 36;
            this.LBLTag.Text = "Tag Search:";
            // 
            // LBLDriveSelect
            // 
            this.LBLDriveSelect.AutoSize = true;
            this.LBLDriveSelect.Location = new System.Drawing.Point(9, 80);
            this.LBLDriveSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDriveSelect.Name = "LBLDriveSelect";
            this.LBLDriveSelect.Size = new System.Drawing.Size(80, 19);
            this.LBLDriveSelect.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLDriveSelect.TabIndex = 35;
            this.LBLDriveSelect.Text = "Drive Select:";
            // 
            // LBLSearch
            // 
            this.LBLSearch.AutoSize = true;
            this.LBLSearch.Location = new System.Drawing.Point(23, 39);
            this.LBLSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLSearch.Name = "LBLSearch";
            this.LBLSearch.Size = new System.Drawing.Size(51, 19);
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
            this.TXTSearch.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.TXTSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSearch.CustomButton.Name = "";
            this.TXTSearch.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TXTSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSearch.CustomButton.TabIndex = 1;
            this.TXTSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSearch.CustomButton.UseSelectable = true;
            this.TXTSearch.CustomButton.Visible = false;
            this.TXTSearch.Lines = new string[0];
            this.TXTSearch.Location = new System.Drawing.Point(78, 39);
            this.TXTSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSearch.MaxLength = 32767;
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.PasswordChar = '\0';
            this.TXTSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSearch.SelectedText = "";
            this.TXTSearch.SelectionLength = 0;
            this.TXTSearch.SelectionStart = 0;
            this.TXTSearch.ShortcutsEnabled = true;
            this.TXTSearch.Size = new System.Drawing.Size(263, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(658, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(128, 67);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            // 
            // CBXSize
            // 
            this.CBXSize.AutoSize = true;
            this.CBXSize.Location = new System.Drawing.Point(63, 42);
            this.CBXSize.Margin = new System.Windows.Forms.Padding(2);
            this.CBXSize.Name = "CBXSize";
            this.CBXSize.Size = new System.Drawing.Size(43, 15);
            this.CBXSize.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSize.TabIndex = 32;
            this.CBXSize.Text = "Size";
            this.CBXSize.UseSelectable = true;
            // 
            // CBXAlpha
            // 
            this.CBXAlpha.AutoSize = true;
            this.CBXAlpha.Location = new System.Drawing.Point(63, 20);
            this.CBXAlpha.Margin = new System.Windows.Forms.Padding(2);
            this.CBXAlpha.Name = "CBXAlpha";
            this.CBXAlpha.Size = new System.Drawing.Size(54, 15);
            this.CBXAlpha.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXAlpha.TabIndex = 31;
            this.CBXAlpha.Text = "Alpha";
            this.CBXAlpha.UseSelectable = true;
            // 
            // CBXDate
            // 
            this.CBXDate.AutoSize = true;
            this.CBXDate.Location = new System.Drawing.Point(4, 42);
            this.CBXDate.Margin = new System.Windows.Forms.Padding(2);
            this.CBXDate.Name = "CBXDate";
            this.CBXDate.Size = new System.Drawing.Size(47, 15);
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
            this.CBXDrive.Location = new System.Drawing.Point(4, 20);
            this.CBXDrive.Margin = new System.Windows.Forms.Padding(2);
            this.CBXDrive.Name = "CBXDrive";
            this.CBXDrive.Size = new System.Drawing.Size(50, 15);
            this.CBXDrive.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXDrive.TabIndex = 29;
            this.CBXDrive.Text = "Drive";
            this.CBXDrive.UseSelectable = true;
            // 
            // CLBXTags
            // 
            this.CLBXTags.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLBXTags.FormattingEnabled = true;
            this.CLBXTags.Location = new System.Drawing.Point(575, 161);
            this.CLBXTags.Margin = new System.Windows.Forms.Padding(2);
            this.CLBXTags.Name = "CLBXTags";
            this.CLBXTags.Size = new System.Drawing.Size(247, 276);
            this.CLBXTags.TabIndex = 32;
            // 
            // GBSearchAttributes
            // 
            this.GBSearchAttributes.Controls.Add(this.metroCheckBox1);
            this.GBSearchAttributes.Controls.Add(this.CBXExactMatch);
            this.GBSearchAttributes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSearchAttributes.Location = new System.Drawing.Point(544, 30);
            this.GBSearchAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.GBSearchAttributes.Name = "GBSearchAttributes";
            this.GBSearchAttributes.Padding = new System.Windows.Forms.Padding(2);
            this.GBSearchAttributes.Size = new System.Drawing.Size(96, 67);
            this.GBSearchAttributes.TabIndex = 30;
            this.GBSearchAttributes.TabStop = false;
            this.GBSearchAttributes.Text = " Quantifiers:";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(4, 42);
            this.metroCheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(88, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroCheckBox1.TabIndex = 28;
            this.metroCheckBox1.Text = "Exact Match";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // CBXExactMatch
            // 
            this.CBXExactMatch.AutoSize = true;
            this.CBXExactMatch.Location = new System.Drawing.Point(4, 20);
            this.CBXExactMatch.Margin = new System.Windows.Forms.Padding(2);
            this.CBXExactMatch.Name = "CBXExactMatch";
            this.CBXExactMatch.Size = new System.Drawing.Size(88, 15);
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
            this.GBXFilter.Location = new System.Drawing.Point(464, 29);
            this.GBXFilter.Margin = new System.Windows.Forms.Padding(2);
            this.GBXFilter.Name = "GBXFilter";
            this.GBXFilter.Padding = new System.Windows.Forms.Padding(2);
            this.GBXFilter.Size = new System.Drawing.Size(63, 67);
            this.GBXFilter.TabIndex = 29;
            this.GBXFilter.TabStop = false;
            this.GBXFilter.Text = "Filter:";
            // 
            // RBTNTag
            // 
            this.RBTNTag.AutoSize = true;
            this.RBTNTag.Location = new System.Drawing.Point(4, 43);
            this.RBTNTag.Margin = new System.Windows.Forms.Padding(2);
            this.RBTNTag.Name = "RBTNTag";
            this.RBTNTag.Size = new System.Drawing.Size(41, 15);
            this.RBTNTag.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNTag.TabIndex = 28;
            this.RBTNTag.Text = "Tag";
            this.RBTNTag.UseSelectable = true;
            // 
            // RBTNName
            // 
            this.RBTNName.AutoSize = true;
            this.RBTNName.Checked = true;
            this.RBTNName.Location = new System.Drawing.Point(4, 20);
            this.RBTNName.Margin = new System.Windows.Forms.Padding(2);
            this.RBTNName.Name = "RBTNName";
            this.RBTNName.Size = new System.Drawing.Size(55, 15);
            this.RBTNName.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNName.TabIndex = 27;
            this.RBTNName.TabStop = true;
            this.RBTNName.Text = "Name";
            this.RBTNName.UseSelectable = true;
            // 
            // TVSearchView
            // 
            this.TVSearchView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVSearchView.Location = new System.Drawing.Point(23, 127);
            this.TVSearchView.Margin = new System.Windows.Forms.Padding(2);
            this.TVSearchView.Name = "TVSearchView";
            this.TVSearchView.Size = new System.Drawing.Size(548, 408);
            this.TVSearchView.TabIndex = 28;
            this.TVSearchView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVSearchView_AfterSelect);
            // 
            // TPDriveManager
            // 
            this.TPDriveManager.BackColor = System.Drawing.SystemColors.Window;
            this.TPDriveManager.Controls.Add(this.BTNUploadXML);
            this.TPDriveManager.Controls.Add(this.BTNDownloadXML);
            this.TPDriveManager.Controls.Add(this.TXTDrivePath);
            this.TPDriveManager.Controls.Add(this.TXTNickname);
            this.TPDriveManager.Controls.Add(this.LBLNickname);
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
            this.TPDriveManager.Controls.Add(this.TVDriveView);
            this.TPDriveManager.Location = new System.Drawing.Point(4, 38);
            this.TPDriveManager.Name = "TPDriveManager";
            this.TPDriveManager.Padding = new System.Windows.Forms.Padding(23, 27, 23, 27);
            this.TPDriveManager.Size = new System.Drawing.Size(955, 557);
            this.TPDriveManager.TabIndex = 2;
            this.TPDriveManager.Text = "  Drive Manager  ";
            // 
            // BTNUploadXML
            // 
            this.BTNUploadXML.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNUploadXML.Location = new System.Drawing.Point(595, 240);
            this.BTNUploadXML.Margin = new System.Windows.Forms.Padding(2);
            this.BTNUploadXML.Name = "BTNUploadXML";
            this.BTNUploadXML.Size = new System.Drawing.Size(85, 24);
            this.BTNUploadXML.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNUploadXML.TabIndex = 55;
            this.BTNUploadXML.Text = "Upload XML";
            this.BTNUploadXML.UseSelectable = true;
            this.BTNUploadXML.Click += new System.EventHandler(this.BTNUploadXML_Click);
            // 
            // BTNDownloadXML
            // 
            this.BTNDownloadXML.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNDownloadXML.Location = new System.Drawing.Point(595, 211);
            this.BTNDownloadXML.Margin = new System.Windows.Forms.Padding(2);
            this.BTNDownloadXML.Name = "BTNDownloadXML";
            this.BTNDownloadXML.Size = new System.Drawing.Size(85, 24);
            this.BTNDownloadXML.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNDownloadXML.TabIndex = 54;
            this.BTNDownloadXML.Text = "Download XML";
            this.BTNDownloadXML.UseSelectable = true;
            this.BTNDownloadXML.Click += new System.EventHandler(this.BTNDownloadXML_Click);
            // 
            // TXTDrivePath
            // 
            // 
            // 
            // 
            this.TXTDrivePath.CustomButton.Image = null;
            this.TXTDrivePath.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.TXTDrivePath.CustomButton.Name = "";
            this.TXTDrivePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTDrivePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTDrivePath.CustomButton.TabIndex = 1;
            this.TXTDrivePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTDrivePath.CustomButton.UseSelectable = true;
            this.TXTDrivePath.CustomButton.Visible = false;
            this.TXTDrivePath.Lines = new string[0];
            this.TXTDrivePath.Location = new System.Drawing.Point(23, 37);
            this.TXTDrivePath.MaxLength = 32767;
            this.TXTDrivePath.Name = "TXTDrivePath";
            this.TXTDrivePath.PasswordChar = '\0';
            this.TXTDrivePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTDrivePath.SelectedText = "";
            this.TXTDrivePath.SelectionLength = 0;
            this.TXTDrivePath.SelectionStart = 0;
            this.TXTDrivePath.ShortcutsEnabled = true;
            this.TXTDrivePath.Size = new System.Drawing.Size(265, 23);
            this.TXTDrivePath.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTDrivePath.TabIndex = 53;
            this.TXTDrivePath.UseSelectable = true;
            this.TXTDrivePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTDrivePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTNickname
            // 
            // 
            // 
            // 
            this.TXTNickname.CustomButton.Image = null;
            this.TXTNickname.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.TXTNickname.CustomButton.Name = "";
            this.TXTNickname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTNickname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNickname.CustomButton.TabIndex = 1;
            this.TXTNickname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNickname.CustomButton.UseSelectable = true;
            this.TXTNickname.CustomButton.Visible = false;
            this.TXTNickname.Lines = new string[0];
            this.TXTNickname.Location = new System.Drawing.Point(131, 64);
            this.TXTNickname.MaxLength = 32767;
            this.TXTNickname.Name = "TXTNickname";
            this.TXTNickname.PasswordChar = '\0';
            this.TXTNickname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNickname.SelectedText = "";
            this.TXTNickname.SelectionLength = 0;
            this.TXTNickname.SelectionStart = 0;
            this.TXTNickname.ShortcutsEnabled = true;
            this.TXTNickname.Size = new System.Drawing.Size(157, 23);
            this.TXTNickname.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTNickname.TabIndex = 52;
            this.TXTNickname.UseSelectable = true;
            this.TXTNickname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTNickname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LBLNickname
            // 
            this.LBLNickname.AutoSize = true;
            this.LBLNickname.Location = new System.Drawing.Point(19, 66);
            this.LBLNickname.Name = "LBLNickname";
            this.LBLNickname.Size = new System.Drawing.Size(104, 19);
            this.LBLNickname.TabIndex = 51;
            this.LBLNickname.Text = "Drive Nickname:";
            // 
            // LBLChangesMade
            // 
            this.LBLChangesMade.AutoSize = true;
            this.LBLChangesMade.Location = new System.Drawing.Point(25, 529);
            this.LBLChangesMade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLChangesMade.Name = "LBLChangesMade";
            this.LBLChangesMade.Size = new System.Drawing.Size(231, 19);
            this.LBLChangesMade.TabIndex = 50;
            this.LBLChangesMade.Text = "Changes Made, Please Write Changes";
            this.LBLChangesMade.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(458, 27);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(134, 19);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "! Use Only If Trained !";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNDelete.Location = new System.Drawing.Point(209, 437);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(77, 24);
            this.BTNDelete.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNDelete.TabIndex = 48;
            this.BTNDelete.Text = "Delete Entry";
            this.BTNDelete.UseSelectable = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNRefreshDrives
            // 
            this.BTNRefreshDrives.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNRefreshDrives.Location = new System.Drawing.Point(446, 410);
            this.BTNRefreshDrives.Margin = new System.Windows.Forms.Padding(2);
            this.BTNRefreshDrives.Name = "BTNRefreshDrives";
            this.BTNRefreshDrives.Size = new System.Drawing.Size(58, 24);
            this.BTNRefreshDrives.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNRefreshDrives.TabIndex = 47;
            this.BTNRefreshDrives.Text = "Refresh";
            this.BTNRefreshDrives.UseSelectable = true;
            this.BTNRefreshDrives.Click += new System.EventHandler(this.BTNRefreshDrives_Click);
            // 
            // BTNRestore
            // 
            this.BTNRestore.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNRestore.Location = new System.Drawing.Point(510, 240);
            this.BTNRestore.Margin = new System.Windows.Forms.Padding(2);
            this.BTNRestore.Name = "BTNRestore";
            this.BTNRestore.Size = new System.Drawing.Size(58, 24);
            this.BTNRestore.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNRestore.TabIndex = 46;
            this.BTNRestore.Text = "Restore";
            this.BTNRestore.UseSelectable = true;
            this.BTNRestore.Click += new System.EventHandler(this.BTNRestore_Click);
            // 
            // BTNBackup
            // 
            this.BTNBackup.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNBackup.Location = new System.Drawing.Point(448, 240);
            this.BTNBackup.Margin = new System.Windows.Forms.Padding(2);
            this.BTNBackup.Name = "BTNBackup";
            this.BTNBackup.Size = new System.Drawing.Size(58, 24);
            this.BTNBackup.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNBackup.TabIndex = 45;
            this.BTNBackup.Text = "Backup";
            this.BTNBackup.UseSelectable = true;
            this.BTNBackup.Click += new System.EventHandler(this.BTNBackup_Click);
            // 
            // BTNClearFile
            // 
            this.BTNClearFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNClearFile.Location = new System.Drawing.Point(448, 211);
            this.BTNClearFile.Margin = new System.Windows.Forms.Padding(2);
            this.BTNClearFile.Name = "BTNClearFile";
            this.BTNClearFile.Size = new System.Drawing.Size(58, 24);
            this.BTNClearFile.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNClearFile.TabIndex = 44;
            this.BTNClearFile.Text = "Clear";
            this.BTNClearFile.UseSelectable = true;
            this.BTNClearFile.Click += new System.EventHandler(this.BTNClearFile_Click);
            // 
            // BTNReadDriveData
            // 
            this.BTNReadDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNReadDriveData.Location = new System.Drawing.Point(329, 240);
            this.BTNReadDriveData.Margin = new System.Windows.Forms.Padding(2);
            this.BTNReadDriveData.Name = "BTNReadDriveData";
            this.BTNReadDriveData.Size = new System.Drawing.Size(112, 24);
            this.BTNReadDriveData.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNReadDriveData.TabIndex = 43;
            this.BTNReadDriveData.Text = "Read Drive Data";
            this.BTNReadDriveData.UseSelectable = true;
            this.BTNReadDriveData.Click += new System.EventHandler(this.BTNReadDriveData_Click);
            // 
            // BTNWriteDriveData
            // 
            this.BTNWriteDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNWriteDriveData.Location = new System.Drawing.Point(329, 211);
            this.BTNWriteDriveData.Margin = new System.Windows.Forms.Padding(2);
            this.BTNWriteDriveData.Name = "BTNWriteDriveData";
            this.BTNWriteDriveData.Size = new System.Drawing.Size(114, 24);
            this.BTNWriteDriveData.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNWriteDriveData.TabIndex = 42;
            this.BTNWriteDriveData.Text = "Write Drive Data";
            this.BTNWriteDriveData.UseSelectable = true;
            this.BTNWriteDriveData.Click += new System.EventHandler(this.BTNWriteDriveData_Click);
            // 
            // LBLFileData
            // 
            this.LBLFileData.AutoSize = true;
            this.LBLFileData.Location = new System.Drawing.Point(329, 100);
            this.LBLFileData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLFileData.Name = "LBLFileData";
            this.LBLFileData.Size = new System.Drawing.Size(60, 19);
            this.LBLFileData.TabIndex = 41;
            this.LBLFileData.Text = "File Data";
            // 
            // BTNFindFolder
            // 
            this.BTNFindFolder.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNFindFolder.Location = new System.Drawing.Point(308, 24);
            this.BTNFindFolder.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFindFolder.Name = "BTNFindFolder";
            this.BTNFindFolder.Size = new System.Drawing.Size(86, 31);
            this.BTNFindFolder.TabIndex = 40;
            this.BTNFindFolder.Text = "File Explorer";
            this.BTNFindFolder.UseSelectable = true;
            this.BTNFindFolder.Click += new System.EventHandler(this.BTNFindFolder_Click);
            // 
            // BTNLoadDriveData
            // 
            this.BTNLoadDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNLoadDriveData.Location = new System.Drawing.Point(194, 91);
            this.BTNLoadDriveData.Margin = new System.Windows.Forms.Padding(2);
            this.BTNLoadDriveData.Name = "BTNLoadDriveData";
            this.BTNLoadDriveData.Size = new System.Drawing.Size(92, 23);
            this.BTNLoadDriveData.TabIndex = 39;
            this.BTNLoadDriveData.Text = "Load Drive Data";
            this.BTNLoadDriveData.UseSelectable = true;
            this.BTNLoadDriveData.Click += new System.EventHandler(this.BTNLoadDriveData_Click);
            // 
            // LBLDriveView
            // 
            this.LBLDriveView.AutoSize = true;
            this.LBLDriveView.Location = new System.Drawing.Point(19, 98);
            this.LBLDriveView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDriveView.Name = "LBLDriveView";
            this.LBLDriveView.Size = new System.Drawing.Size(70, 19);
            this.LBLDriveView.TabIndex = 38;
            this.LBLDriveView.Text = "Drive View";
            // 
            // LBLDrivePath
            // 
            this.LBLDrivePath.AutoSize = true;
            this.LBLDrivePath.Location = new System.Drawing.Point(19, 18);
            this.LBLDrivePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDrivePath.Name = "LBLDrivePath";
            this.LBLDrivePath.Size = new System.Drawing.Size(68, 19);
            this.LBLDrivePath.TabIndex = 37;
            this.LBLDrivePath.Text = "Drive Path";
            // 
            // LBXDrives
            // 
            this.LBXDrives.FormattingEnabled = true;
            this.LBXDrives.Location = new System.Drawing.Point(329, 310);
            this.LBXDrives.Name = "LBXDrives";
            this.LBXDrives.Size = new System.Drawing.Size(175, 95);
            this.LBXDrives.TabIndex = 35;
            // 
            // LBXFileData
            // 
            this.LBXFileData.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXFileData.FormattingEnabled = true;
            this.LBXFileData.ItemHeight = 12;
            this.LBXFileData.Location = new System.Drawing.Point(329, 121);
            this.LBXFileData.Name = "LBXFileData";
            this.LBXFileData.Size = new System.Drawing.Size(354, 76);
            this.LBXFileData.TabIndex = 34;
            // 
            // TVDriveView
            // 
            this.TVDriveView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TVDriveView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVDriveView.Location = new System.Drawing.Point(19, 119);
            this.TVDriveView.Margin = new System.Windows.Forms.Padding(2);
            this.TVDriveView.Name = "TVDriveView";
            this.TVDriveView.Size = new System.Drawing.Size(269, 314);
            this.TVDriveView.TabIndex = 32;
            this.TVDriveView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVDriveView_AfterSelect);
            // 
            // TPStorageOptimization
            // 
            this.TPStorageOptimization.BackColor = System.Drawing.SystemColors.Window;
            this.TPStorageOptimization.Controls.Add(this.LBLOptiNumCopies);
            this.TPStorageOptimization.Controls.Add(this.TXTOptiNumCopies);
            this.TPStorageOptimization.Controls.Add(this.LBLOptiFilter);
            this.TPStorageOptimization.Controls.Add(this.TXTOptiFilter);
            this.TPStorageOptimization.Controls.Add(this.metroPanel1);
            this.TPStorageOptimization.Controls.Add(this.BTNProcessOptimization);
            this.TPStorageOptimization.Controls.Add(this.LVOptimizationResults);
            this.TPStorageOptimization.Controls.Add(this.LBLDrivePriority);
            this.TPStorageOptimization.Controls.Add(this.LBXDrivePriority);
            this.TPStorageOptimization.Location = new System.Drawing.Point(4, 38);
            this.TPStorageOptimization.Margin = new System.Windows.Forms.Padding(2);
            this.TPStorageOptimization.Name = "TPStorageOptimization";
            this.TPStorageOptimization.Size = new System.Drawing.Size(955, 557);
            this.TPStorageOptimization.TabIndex = 3;
            this.TPStorageOptimization.Text = "  Storage Optimization  ";
            // 
            // LBLOptiNumCopies
            // 
            this.LBLOptiNumCopies.AutoSize = true;
            this.LBLOptiNumCopies.Location = new System.Drawing.Point(521, 18);
            this.LBLOptiNumCopies.Name = "LBLOptiNumCopies";
            this.LBLOptiNumCopies.Size = new System.Drawing.Size(140, 19);
            this.LBLOptiNumCopies.TabIndex = 8;
            this.LBLOptiNumCopies.Text = "# of Copies Preferred:";
            // 
            // TXTOptiNumCopies
            // 
            // 
            // 
            // 
            this.TXTOptiNumCopies.CustomButton.Image = null;
            this.TXTOptiNumCopies.CustomButton.Location = new System.Drawing.Point(0, 1);
            this.TXTOptiNumCopies.CustomButton.Name = "";
            this.TXTOptiNumCopies.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTOptiNumCopies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTOptiNumCopies.CustomButton.TabIndex = 1;
            this.TXTOptiNumCopies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTOptiNumCopies.CustomButton.UseSelectable = true;
            this.TXTOptiNumCopies.CustomButton.Visible = false;
            this.TXTOptiNumCopies.Lines = new string[] {
        "2"};
            this.TXTOptiNumCopies.Location = new System.Drawing.Point(667, 18);
            this.TXTOptiNumCopies.MaxLength = 32767;
            this.TXTOptiNumCopies.Name = "TXTOptiNumCopies";
            this.TXTOptiNumCopies.PasswordChar = '\0';
            this.TXTOptiNumCopies.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTOptiNumCopies.SelectedText = "";
            this.TXTOptiNumCopies.SelectionLength = 0;
            this.TXTOptiNumCopies.SelectionStart = 0;
            this.TXTOptiNumCopies.ShortcutsEnabled = true;
            this.TXTOptiNumCopies.Size = new System.Drawing.Size(22, 23);
            this.TXTOptiNumCopies.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTOptiNumCopies.TabIndex = 7;
            this.TXTOptiNumCopies.Text = "2";
            this.TXTOptiNumCopies.UseSelectable = true;
            this.TXTOptiNumCopies.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTOptiNumCopies.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LBLOptiFilter
            // 
            this.LBLOptiFilter.AutoSize = true;
            this.LBLOptiFilter.Location = new System.Drawing.Point(143, 16);
            this.LBLOptiFilter.Name = "LBLOptiFilter";
            this.LBLOptiFilter.Size = new System.Drawing.Size(59, 19);
            this.LBLOptiFilter.TabIndex = 6;
            this.LBLOptiFilter.Text = "Filter By:";
            // 
            // TXTOptiFilter
            // 
            // 
            // 
            // 
            this.TXTOptiFilter.CustomButton.Image = null;
            this.TXTOptiFilter.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.TXTOptiFilter.CustomButton.Name = "";
            this.TXTOptiFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTOptiFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTOptiFilter.CustomButton.TabIndex = 1;
            this.TXTOptiFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTOptiFilter.CustomButton.UseSelectable = true;
            this.TXTOptiFilter.CustomButton.Visible = false;
            this.TXTOptiFilter.Lines = new string[0];
            this.TXTOptiFilter.Location = new System.Drawing.Point(208, 16);
            this.TXTOptiFilter.MaxLength = 32767;
            this.TXTOptiFilter.Name = "TXTOptiFilter";
            this.TXTOptiFilter.PasswordChar = '\0';
            this.TXTOptiFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTOptiFilter.SelectedText = "";
            this.TXTOptiFilter.SelectionLength = 0;
            this.TXTOptiFilter.SelectionStart = 0;
            this.TXTOptiFilter.ShortcutsEnabled = true;
            this.TXTOptiFilter.Size = new System.Drawing.Size(297, 23);
            this.TXTOptiFilter.TabIndex = 5;
            this.TXTOptiFilter.UseSelectable = true;
            this.TXTOptiFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTOptiFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RBTNOptiBoth);
            this.metroPanel1.Controls.Add(this.RBTNOptiFilesOnly);
            this.metroPanel1.Controls.Add(this.RBTNOptFoldersOnly);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(18, 252);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(118, 67);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // RBTNOptiBoth
            // 
            this.RBTNOptiBoth.AutoSize = true;
            this.RBTNOptiBoth.Checked = true;
            this.RBTNOptiBoth.Location = new System.Drawing.Point(3, 46);
            this.RBTNOptiBoth.Name = "RBTNOptiBoth";
            this.RBTNOptiBoth.Size = new System.Drawing.Size(48, 15);
            this.RBTNOptiBoth.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNOptiBoth.TabIndex = 4;
            this.RBTNOptiBoth.TabStop = true;
            this.RBTNOptiBoth.Text = "Both";
            this.RBTNOptiBoth.UseSelectable = true;
            // 
            // RBTNOptiFilesOnly
            // 
            this.RBTNOptiFilesOnly.AutoSize = true;
            this.RBTNOptiFilesOnly.Location = new System.Drawing.Point(3, 25);
            this.RBTNOptiFilesOnly.Name = "RBTNOptiFilesOnly";
            this.RBTNOptiFilesOnly.Size = new System.Drawing.Size(74, 15);
            this.RBTNOptiFilesOnly.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNOptiFilesOnly.TabIndex = 3;
            this.RBTNOptiFilesOnly.Text = "Files Only";
            this.RBTNOptiFilesOnly.UseSelectable = true;
            // 
            // RBTNOptFoldersOnly
            // 
            this.RBTNOptFoldersOnly.AutoSize = true;
            this.RBTNOptFoldersOnly.Location = new System.Drawing.Point(4, 4);
            this.RBTNOptFoldersOnly.Name = "RBTNOptFoldersOnly";
            this.RBTNOptFoldersOnly.Size = new System.Drawing.Size(89, 15);
            this.RBTNOptFoldersOnly.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNOptFoldersOnly.TabIndex = 2;
            this.RBTNOptFoldersOnly.Text = "Folders Only";
            this.RBTNOptFoldersOnly.UseSelectable = true;
            // 
            // BTNProcessOptimization
            // 
            this.BTNProcessOptimization.Location = new System.Drawing.Point(18, 217);
            this.BTNProcessOptimization.Name = "BTNProcessOptimization";
            this.BTNProcessOptimization.Size = new System.Drawing.Size(118, 23);
            this.BTNProcessOptimization.TabIndex = 3;
            this.BTNProcessOptimization.Text = "Process";
            this.BTNProcessOptimization.UseSelectable = true;
            this.BTNProcessOptimization.Click += new System.EventHandler(this.BTNProcessOptimization_Click);
            // 
            // LVOptimizationResults
            // 
            this.LVOptimizationResults.AutoArrange = false;
            this.LVOptimizationResults.CheckBoxes = true;
            this.LVOptimizationResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Name,
            this.Col_Path,
            this.Col_Date,
            this.Col_Size});
            this.LVOptimizationResults.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LVOptimizationResults.FullRowSelect = true;
            this.LVOptimizationResults.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.LVOptimizationResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LVOptimizationResults.Location = new System.Drawing.Point(141, 46);
            this.LVOptimizationResults.Margin = new System.Windows.Forms.Padding(2);
            this.LVOptimizationResults.Name = "LVOptimizationResults";
            this.LVOptimizationResults.OwnerDraw = true;
            this.LVOptimizationResults.Size = new System.Drawing.Size(796, 496);
            this.LVOptimizationResults.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LVOptimizationResults.TabIndex = 2;
            this.LVOptimizationResults.UseCompatibleStateImageBehavior = false;
            this.LVOptimizationResults.UseSelectable = true;
            this.LVOptimizationResults.View = System.Windows.Forms.View.Details;
            // 
            // Col_Name
            // 
            this.Col_Name.Text = "Name";
            this.Col_Name.Width = 214;
            // 
            // Col_Path
            // 
            this.Col_Path.Text = "Path";
            this.Col_Path.Width = 378;
            // 
            // Col_Date
            // 
            this.Col_Date.Text = "Date";
            this.Col_Date.Width = 127;
            // 
            // Col_Size
            // 
            this.Col_Size.Text = "Size";
            this.Col_Size.Width = 55;
            // 
            // LBLDrivePriority
            // 
            this.LBLDrivePriority.AutoSize = true;
            this.LBLDrivePriority.Location = new System.Drawing.Point(20, 25);
            this.LBLDrivePriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDrivePriority.Name = "LBLDrivePriority";
            this.LBLDrivePriority.Size = new System.Drawing.Size(88, 19);
            this.LBLDrivePriority.TabIndex = 1;
            this.LBLDrivePriority.Text = "Drive Priority:";
            // 
            // LBXDrivePriority
            // 
            this.LBXDrivePriority.AllowDrop = true;
            this.LBXDrivePriority.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXDrivePriority.FormattingEnabled = true;
            this.LBXDrivePriority.ItemHeight = 12;
            this.LBXDrivePriority.Location = new System.Drawing.Point(18, 46);
            this.LBXDrivePriority.Margin = new System.Windows.Forms.Padding(2);
            this.LBXDrivePriority.Name = "LBXDrivePriority";
            this.LBXDrivePriority.Size = new System.Drawing.Size(119, 160);
            this.LBXDrivePriority.TabIndex = 0;
            this.LBXDrivePriority.DragDrop += new System.Windows.Forms.DragEventHandler(this.LBXDrivePriority_DragDrop);
            this.LBXDrivePriority.DragOver += new System.Windows.Forms.DragEventHandler(this.LBXDrivePriority_DragOver);
            this.LBXDrivePriority.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBXDrivePriority_MouseDown);
            // 
            // BTNScanSystem
            // 
            this.BTNScanSystem.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNScanSystem.Location = new System.Drawing.Point(668, 14);
            this.BTNScanSystem.Margin = new System.Windows.Forms.Padding(2);
            this.BTNScanSystem.Name = "BTNScanSystem";
            this.BTNScanSystem.Size = new System.Drawing.Size(81, 32);
            this.BTNScanSystem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNScanSystem.TabIndex = 5;
            this.BTNScanSystem.Text = "Scan System";
            this.BTNScanSystem.UseSelectable = true;
            this.BTNScanSystem.Click += new System.EventHandler(this.BTNScanSystem_Click);
            // 
            // PGBarScanSystem
            // 
            this.PGBarScanSystem.Location = new System.Drawing.Point(668, 51);
            this.PGBarScanSystem.Margin = new System.Windows.Forms.Padding(2);
            this.PGBarScanSystem.Name = "PGBarScanSystem";
            this.PGBarScanSystem.Size = new System.Drawing.Size(81, 19);
            this.PGBarScanSystem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.PGBarScanSystem.TabIndex = 7;
            this.PGBarScanSystem.Visible = false;
            // 
            // LBLProgress
            // 
            this.LBLProgress.AutoSize = true;
            this.LBLProgress.Location = new System.Drawing.Point(601, 51);
            this.LBLProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLProgress.Name = "LBLProgress";
            this.LBLProgress.Size = new System.Drawing.Size(63, 19);
            this.LBLProgress.TabIndex = 8;
            this.LBLProgress.Text = "Progress:";
            this.LBLProgress.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // LBLUploadProgress
            // 
            this.LBLUploadProgress.AutoSize = true;
            this.LBLUploadProgress.Location = new System.Drawing.Point(483, 11);
            this.LBLUploadProgress.Name = "LBLUploadProgress";
            this.LBLUploadProgress.Size = new System.Drawing.Size(0, 0);
            this.LBLUploadProgress.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::BrainologyDatabaseManager.Properties.Resources.MarketingBrainologyLogoWebsiteNewS;
            this.pictureBox1.Location = new System.Drawing.Point(366, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 69);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FRMMBDatabase
            // 
            this.AcceptButton = this.BTNSearch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(969, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBLUploadProgress);
            this.Controls.Add(this.LBLProgress);
            this.Controls.Add(this.PGBarScanSystem);
            this.Controls.Add(this.BTNScanSystem);
            this.Controls.Add(this.MTABWindowSelector);
            this.Controls.Add(this.PNLSubForms);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMMBDatabase";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Marketing Brainology Database";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMMBDatabase_FormClosing);
            this.Load += new System.EventHandler(this.FRMMBDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMMBDatabase_KeyDown);
            this.MTABWindowSelector.ResumeLayout(false);
            this.TPWelcome.ResumeLayout(false);
            this.TPWelcome.PerformLayout();
            this.TPSearchManager.ResumeLayout(false);
            this.TPSearchManager.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBSearchAttributes.ResumeLayout(false);
            this.GBSearchAttributes.PerformLayout();
            this.GBXFilter.ResumeLayout(false);
            this.GBXFilter.PerformLayout();
            this.TPDriveManager.ResumeLayout(false);
            this.TPDriveManager.PerformLayout();
            this.TPStorageOptimization.ResumeLayout(false);
            this.TPStorageOptimization.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroListView LVOptimizationResults;
        private System.Windows.Forms.ColumnHeader Col_Name;
        private System.Windows.Forms.ColumnHeader Col_Path;
        private System.Windows.Forms.ColumnHeader Col_Date;
        private System.Windows.Forms.ColumnHeader Col_Size;
        private MetroFramework.Controls.MetroButton BTNProcessOptimization;
        private MetroFramework.Controls.MetroLabel LBLUploadProgress;
        private MetroFramework.Controls.MetroTextBox TXTNickname;
        private MetroFramework.Controls.MetroLabel LBLNickname;
        private MetroFramework.Controls.MetroTextBox TXTDrivePath;
        private MetroFramework.Controls.MetroButton BTNUploadXML;
        private MetroFramework.Controls.MetroButton BTNDownloadXML;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton RBTNOptFoldersOnly;
        private MetroFramework.Controls.MetroRadioButton RBTNOptiFilesOnly;
        private MetroFramework.Controls.MetroRadioButton RBTNOptiBoth;
        private MetroFramework.Controls.MetroTextBox TXTOptiFilter;
        private MetroFramework.Controls.MetroLabel LBLOptiFilter;
        private MetroFramework.Controls.MetroLabel LBLOptiNumCopies;
        private MetroFramework.Controls.MetroTextBox TXTOptiNumCopies;
    }
}