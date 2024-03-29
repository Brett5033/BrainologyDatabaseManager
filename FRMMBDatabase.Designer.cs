﻿namespace BrainologyDatabaseManager
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
            this.PNLGithub = new MetroFramework.Controls.MetroPanel();
            this.LNKGithub = new System.Windows.Forms.LinkLabel();
            this.LBLGitHub = new MetroFramework.Controls.MetroLabel();
            this.PNLUserGuide = new MetroFramework.Controls.MetroPanel();
            this.LNKUserGuide = new System.Windows.Forms.LinkLabel();
            this.LBLUserGuide = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.TPSearchManager = new System.Windows.Forms.TabPage();
            this.PNLTags = new System.Windows.Forms.Panel();
            this.CLBXTags = new System.Windows.Forms.CheckedListBox();
            this.LBLTag = new MetroFramework.Controls.MetroLabel();
            this.BTNRemoveAllTags = new MetroFramework.Controls.MetroButton();
            this.TXTTagSearch = new MetroFramework.Controls.MetroTextBox();
            this.BTNClearSelectedTags = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.BTNDeleteTag = new MetroFramework.Controls.MetroButton();
            this.LBLTagWizardCreate = new MetroFramework.Controls.MetroLabel();
            this.BTNTagCreate = new MetroFramework.Controls.MetroButton();
            this.TXTTagWizardName = new MetroFramework.Controls.MetroTextBox();
            this.BTNRemoveSelectedTags = new MetroFramework.Controls.MetroButton();
            this.BTNApplyTags = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.BTNNewTagPreset = new MetroFramework.Controls.MetroButton();
            this.LBLNewPresetName = new MetroFramework.Controls.MetroLabel();
            this.TXTTagPresetName = new MetroFramework.Controls.MetroTextBox();
            this.BTNTagPresetRemove = new MetroFramework.Controls.MetroButton();
            this.LBLTagPresetWizard = new MetroFramework.Controls.MetroLabel();
            this.BTNTagPresetAdd = new MetroFramework.Controls.MetroButton();
            this.BTNApplyTagPreset = new MetroFramework.Controls.MetroButton();
            this.LBXTagPresets = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BTNShowTag = new MetroFramework.Controls.MetroButton();
            this.TXTSearchData = new MetroFramework.Controls.MetroTextBox();
            this.BTNSearch = new MetroFramework.Controls.MetroButton();
            this.ComboBXDriveSelect = new MetroFramework.Controls.MetroComboBox();
            this.CBXSpecifyDrive = new MetroFramework.Controls.MetroCheckBox();
            this.LBLDriveSelect = new MetroFramework.Controls.MetroLabel();
            this.LBLSearch = new MetroFramework.Controls.MetroLabel();
            this.TXTSearch = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBXSize = new MetroFramework.Controls.MetroCheckBox();
            this.CBXAlpha = new MetroFramework.Controls.MetroCheckBox();
            this.CBXDate = new MetroFramework.Controls.MetroCheckBox();
            this.CBXDrive = new MetroFramework.Controls.MetroCheckBox();
            this.GBSearchAttributes = new System.Windows.Forms.GroupBox();
            this.CBXExactMatch = new MetroFramework.Controls.MetroCheckBox();
            this.GBXFilter = new System.Windows.Forms.GroupBox();
            this.RBTNTag = new MetroFramework.Controls.MetroRadioButton();
            this.RBTNName = new MetroFramework.Controls.MetroRadioButton();
            this.TVSearchView = new System.Windows.Forms.TreeView();
            this.TPDriveManager = new System.Windows.Forms.TabPage();
            this.BTNShowSubs = new MetroFramework.Controls.MetroButton();
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
            this.LBLMegaBytes = new MetroFramework.Controls.MetroLabel();
            this.LBLMinimunSize = new MetroFramework.Controls.MetroLabel();
            this.TXTMinimumSize = new MetroFramework.Controls.MetroTextBox();
            this.CBXSaveToExcel = new MetroFramework.Controls.MetroCheckBox();
            this.CBXConsolidateResults = new MetroFramework.Controls.MetroCheckBox();
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
            this.LBLUploadProgress = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLFormClosing = new MetroFramework.Controls.MetroLabel();
            this.TTMain = new MetroFramework.Components.MetroToolTip();
            this.LBLUserLog = new MetroFramework.Controls.MetroLabel();
            this.LBLProgressSpinner = new MetroFramework.Controls.MetroLabel();
            this.PBXLoadingLogo = new System.Windows.Forms.PictureBox();
            this.LBLVersionNumber = new MetroFramework.Controls.MetroLabel();
            this.MTABWindowSelector.SuspendLayout();
            this.TPWelcome.SuspendLayout();
            this.PNLGithub.SuspendLayout();
            this.PNLUserGuide.SuspendLayout();
            this.TPSearchManager.SuspendLayout();
            this.PNLTags.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBSearchAttributes.SuspendLayout();
            this.GBXFilter.SuspendLayout();
            this.TPDriveManager.SuspendLayout();
            this.TPStorageOptimization.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXLoadingLogo)).BeginInit();
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
            this.MTABWindowSelector.Location = new System.Drawing.Point(4, 107);
            this.MTABWindowSelector.Margin = new System.Windows.Forms.Padding(4);
            this.MTABWindowSelector.Name = "MTABWindowSelector";
            this.MTABWindowSelector.SelectedIndex = 0;
            this.MTABWindowSelector.Size = new System.Drawing.Size(1349, 748);
            this.MTABWindowSelector.Style = MetroFramework.MetroColorStyle.Magenta;
            this.MTABWindowSelector.TabIndex = 4;
            this.MTABWindowSelector.UseSelectable = true;
            this.MTABWindowSelector.Selected += new System.Windows.Forms.TabControlEventHandler(this.MTABWindowSelector_Selected);
            this.MTABWindowSelector.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MTABWindowSelector_Deselecting);
            // 
            // TPWelcome
            // 
            this.TPWelcome.BackColor = System.Drawing.SystemColors.Window;
            this.TPWelcome.Controls.Add(this.PNLGithub);
            this.TPWelcome.Controls.Add(this.PNLUserGuide);
            this.TPWelcome.Controls.Add(this.metroLabel1);
            this.TPWelcome.Controls.Add(this.label2);
            this.TPWelcome.Location = new System.Drawing.Point(4, 38);
            this.TPWelcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPWelcome.Name = "TPWelcome";
            this.TPWelcome.Size = new System.Drawing.Size(1341, 706);
            this.TPWelcome.TabIndex = 0;
            this.TPWelcome.Text = "  Welcome  ";
            this.TPWelcome.ToolTipText = "Basic Info";
            // 
            // PNLGithub
            // 
            this.PNLGithub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLGithub.Controls.Add(this.LNKGithub);
            this.PNLGithub.Controls.Add(this.LBLGitHub);
            this.PNLGithub.HorizontalScrollbarBarColor = true;
            this.PNLGithub.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLGithub.HorizontalScrollbarSize = 12;
            this.PNLGithub.Location = new System.Drawing.Point(37, 346);
            this.PNLGithub.Margin = new System.Windows.Forms.Padding(4);
            this.PNLGithub.Name = "PNLGithub";
            this.PNLGithub.Size = new System.Drawing.Size(863, 123);
            this.PNLGithub.TabIndex = 6;
            this.PNLGithub.VerticalScrollbarBarColor = true;
            this.PNLGithub.VerticalScrollbarHighlightOnWheel = false;
            this.PNLGithub.VerticalScrollbarSize = 13;
            // 
            // LNKGithub
            // 
            this.LNKGithub.AutoSize = true;
            this.LNKGithub.Location = new System.Drawing.Point(24, 57);
            this.LNKGithub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNKGithub.Name = "LNKGithub";
            this.LNKGithub.Size = new System.Drawing.Size(374, 17);
            this.LNKGithub.TabIndex = 3;
            this.LNKGithub.TabStop = true;
            this.LNKGithub.Text = "https://github.com/Brett5033/BrainologyDatabaseManager";
            this.TTMain.SetToolTip(this.LNKGithub, "Report any Bugs, Quirks, or Enhancment Ideas under issues");
            this.LNKGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNKGithub_LinkClicked);
            // 
            // LBLGitHub
            // 
            this.LBLGitHub.AutoSize = true;
            this.LBLGitHub.Location = new System.Drawing.Point(28, 18);
            this.LBLGitHub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLGitHub.Name = "LBLGitHub";
            this.LBLGitHub.Size = new System.Drawing.Size(153, 20);
            this.LBLGitHub.TabIndex = 2;
            this.LBLGitHub.Text = "GitHub To Report Bugs:";
            // 
            // PNLUserGuide
            // 
            this.PNLUserGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLUserGuide.Controls.Add(this.LNKUserGuide);
            this.PNLUserGuide.Controls.Add(this.LBLUserGuide);
            this.PNLUserGuide.HorizontalScrollbarBarColor = true;
            this.PNLUserGuide.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLUserGuide.HorizontalScrollbarSize = 12;
            this.PNLUserGuide.Location = new System.Drawing.Point(37, 196);
            this.PNLUserGuide.Margin = new System.Windows.Forms.Padding(4);
            this.PNLUserGuide.Name = "PNLUserGuide";
            this.PNLUserGuide.Size = new System.Drawing.Size(863, 124);
            this.PNLUserGuide.TabIndex = 5;
            this.PNLUserGuide.VerticalScrollbarBarColor = true;
            this.PNLUserGuide.VerticalScrollbarHighlightOnWheel = false;
            this.PNLUserGuide.VerticalScrollbarSize = 13;
            // 
            // LNKUserGuide
            // 
            this.LNKUserGuide.AutoSize = true;
            this.LNKUserGuide.Location = new System.Drawing.Point(13, 52);
            this.LNKUserGuide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNKUserGuide.Name = "LNKUserGuide";
            this.LNKUserGuide.Size = new System.Drawing.Size(682, 17);
            this.LNKUserGuide.TabIndex = 6;
            this.LNKUserGuide.TabStop = true;
            this.LNKUserGuide.Text = "https://docs.google.com/document/d/1-_55qFkDXY5pfsM403MFEtjdXk6aa1vialnIvEXgIDU/e" +
    "dit?usp=sharing";
            this.TTMain.SetToolTip(this.LNKUserGuide, "In-Depth Guide to the Software");
            this.LNKUserGuide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNKUserGuide_LinkClicked);
            // 
            // LBLUserGuide
            // 
            this.LBLUserGuide.AutoSize = true;
            this.LBLUserGuide.Location = new System.Drawing.Point(17, 16);
            this.LBLUserGuide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLUserGuide.Name = "LBLUserGuide";
            this.LBLUserGuide.Size = new System.Drawing.Size(166, 20);
            this.LBLUserGuide.TabIndex = 4;
            this.LBLUserGuide.Text = "Google Docs User Guide:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(40, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(442, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Welcome, Database Software is still a Work In Progress";
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
            // TPSearchManager
            // 
            this.TPSearchManager.BackColor = System.Drawing.SystemColors.Window;
            this.TPSearchManager.Controls.Add(this.PNLTags);
            this.TPSearchManager.Controls.Add(this.BTNShowTag);
            this.TPSearchManager.Controls.Add(this.TXTSearchData);
            this.TPSearchManager.Controls.Add(this.BTNSearch);
            this.TPSearchManager.Controls.Add(this.ComboBXDriveSelect);
            this.TPSearchManager.Controls.Add(this.CBXSpecifyDrive);
            this.TPSearchManager.Controls.Add(this.LBLDriveSelect);
            this.TPSearchManager.Controls.Add(this.LBLSearch);
            this.TPSearchManager.Controls.Add(this.TXTSearch);
            this.TPSearchManager.Controls.Add(this.groupBox1);
            this.TPSearchManager.Controls.Add(this.GBSearchAttributes);
            this.TPSearchManager.Controls.Add(this.GBXFilter);
            this.TPSearchManager.Controls.Add(this.TVSearchView);
            this.TPSearchManager.Location = new System.Drawing.Point(4, 38);
            this.TPSearchManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPSearchManager.Name = "TPSearchManager";
            this.TPSearchManager.Size = new System.Drawing.Size(1341, 706);
            this.TPSearchManager.TabIndex = 1;
            this.TPSearchManager.Text = "  Search Database  ";
            this.TPSearchManager.ToolTipText = "Search Database with Filters and Tags";
            // 
            // PNLTags
            // 
            this.PNLTags.Controls.Add(this.CLBXTags);
            this.PNLTags.Controls.Add(this.LBLTag);
            this.PNLTags.Controls.Add(this.BTNRemoveAllTags);
            this.PNLTags.Controls.Add(this.TXTTagSearch);
            this.PNLTags.Controls.Add(this.BTNClearSelectedTags);
            this.PNLTags.Controls.Add(this.metroPanel2);
            this.PNLTags.Controls.Add(this.BTNRemoveSelectedTags);
            this.PNLTags.Controls.Add(this.BTNApplyTags);
            this.PNLTags.Controls.Add(this.metroPanel3);
            this.PNLTags.Enabled = false;
            this.PNLTags.Location = new System.Drawing.Point(789, 156);
            this.PNLTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PNLTags.Name = "PNLTags";
            this.PNLTags.Size = new System.Drawing.Size(508, 502);
            this.PNLTags.TabIndex = 49;
            this.PNLTags.Visible = false;
            // 
            // CLBXTags
            // 
            this.CLBXTags.CheckOnClick = true;
            this.CLBXTags.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLBXTags.FormattingEnabled = true;
            this.CLBXTags.Location = new System.Drawing.Point(0, 42);
            this.CLBXTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLBXTags.Name = "CLBXTags";
            this.CLBXTags.Size = new System.Drawing.Size(221, 224);
            this.CLBXTags.Sorted = true;
            this.CLBXTags.TabIndex = 32;
            this.TTMain.SetToolTip(this.CLBXTags, "List of Tags, Only checked tags will apply/remove");
            // 
            // LBLTag
            // 
            this.LBLTag.AutoSize = true;
            this.LBLTag.Location = new System.Drawing.Point(0, 2);
            this.LBLTag.Name = "LBLTag";
            this.LBLTag.Size = new System.Drawing.Size(79, 20);
            this.LBLTag.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLTag.TabIndex = 36;
            this.LBLTag.Text = "Tag Search:";
            // 
            // BTNRemoveAllTags
            // 
            this.BTNRemoveAllTags.Location = new System.Drawing.Point(115, 351);
            this.BTNRemoveAllTags.Margin = new System.Windows.Forms.Padding(4);
            this.BTNRemoveAllTags.Name = "BTNRemoveAllTags";
            this.BTNRemoveAllTags.Size = new System.Drawing.Size(108, 28);
            this.BTNRemoveAllTags.TabIndex = 47;
            this.BTNRemoveAllTags.Text = "Remove All";
            this.TTMain.SetToolTip(this.BTNRemoveAllTags, "Removes all tags from the selected Item");
            this.BTNRemoveAllTags.UseSelectable = true;
            this.BTNRemoveAllTags.Click += new System.EventHandler(this.BTNRemoveAllTags_Click);
            // 
            // TXTTagSearch
            // 
            // 
            // 
            // 
            this.TXTTagSearch.CustomButton.Image = null;
            this.TXTTagSearch.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.TXTTagSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTTagSearch.CustomButton.Name = "";
            this.TXTTagSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTTagSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTTagSearch.CustomButton.TabIndex = 1;
            this.TXTTagSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTTagSearch.CustomButton.UseSelectable = true;
            this.TXTTagSearch.CustomButton.Visible = false;
            this.TXTTagSearch.Lines = new string[0];
            this.TXTTagSearch.Location = new System.Drawing.Point(99, 2);
            this.TXTTagSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTTagSearch.MaxLength = 32767;
            this.TXTTagSearch.Name = "TXTTagSearch";
            this.TXTTagSearch.PasswordChar = '\0';
            this.TXTTagSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTTagSearch.SelectedText = "";
            this.TXTTagSearch.SelectionLength = 0;
            this.TXTTagSearch.SelectionStart = 0;
            this.TXTTagSearch.ShortcutsEnabled = true;
            this.TXTTagSearch.Size = new System.Drawing.Size(269, 23);
            this.TXTTagSearch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTTagSearch.TabIndex = 40;
            this.TTMain.SetToolTip(this.TXTTagSearch, "Filter Tags by phrase");
            this.TXTTagSearch.UseSelectable = true;
            this.TXTTagSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTTagSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTTagSearch.TextChanged += new System.EventHandler(this.TXTTagSearch_TextChanged);
            // 
            // BTNClearSelectedTags
            // 
            this.BTNClearSelectedTags.Location = new System.Drawing.Point(0, 351);
            this.BTNClearSelectedTags.Margin = new System.Windows.Forms.Padding(4);
            this.BTNClearSelectedTags.Name = "BTNClearSelectedTags";
            this.BTNClearSelectedTags.Size = new System.Drawing.Size(109, 28);
            this.BTNClearSelectedTags.TabIndex = 46;
            this.BTNClearSelectedTags.Text = "Clear Selected";
            this.TTMain.SetToolTip(this.BTNClearSelectedTags, "Unchecks all tags");
            this.BTNClearSelectedTags.UseSelectable = true;
            this.BTNClearSelectedTags.Click += new System.EventHandler(this.BTNClearSelectedTags_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.BTNDeleteTag);
            this.metroPanel2.Controls.Add(this.LBLTagWizardCreate);
            this.metroPanel2.Controls.Add(this.BTNTagCreate);
            this.metroPanel2.Controls.Add(this.TXTTagWizardName);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(0, 388);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(222, 114);
            this.metroPanel2.TabIndex = 42;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // BTNDeleteTag
            // 
            this.BTNDeleteTag.Location = new System.Drawing.Point(115, 74);
            this.BTNDeleteTag.Margin = new System.Windows.Forms.Padding(4);
            this.BTNDeleteTag.Name = "BTNDeleteTag";
            this.BTNDeleteTag.Size = new System.Drawing.Size(96, 28);
            this.BTNDeleteTag.TabIndex = 5;
            this.BTNDeleteTag.Text = "Delete Tag";
            this.TTMain.SetToolTip(this.BTNDeleteTag, "!Caution! Deletes a Tag from all Items/Presets");
            this.BTNDeleteTag.UseSelectable = true;
            this.BTNDeleteTag.Click += new System.EventHandler(this.BTNDeleteTag_Click);
            // 
            // LBLTagWizardCreate
            // 
            this.LBLTagWizardCreate.AutoSize = true;
            this.LBLTagWizardCreate.Location = new System.Drawing.Point(4, 9);
            this.LBLTagWizardCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTagWizardCreate.Name = "LBLTagWizardCreate";
            this.LBLTagWizardCreate.Size = new System.Drawing.Size(108, 20);
            this.LBLTagWizardCreate.TabIndex = 4;
            this.LBLTagWizardCreate.Text = "New Tag Name:";
            // 
            // BTNTagCreate
            // 
            this.BTNTagCreate.Location = new System.Drawing.Point(8, 74);
            this.BTNTagCreate.Margin = new System.Windows.Forms.Padding(4);
            this.BTNTagCreate.Name = "BTNTagCreate";
            this.BTNTagCreate.Size = new System.Drawing.Size(95, 28);
            this.BTNTagCreate.TabIndex = 3;
            this.BTNTagCreate.Text = "Create Tag";
            this.TTMain.SetToolTip(this.BTNTagCreate, "Create a tag (Duplicates cannot be made)");
            this.BTNTagCreate.UseSelectable = true;
            this.BTNTagCreate.Click += new System.EventHandler(this.BTNTagCreate_Click);
            // 
            // TXTTagWizardName
            // 
            // 
            // 
            // 
            this.TXTTagWizardName.CustomButton.Image = null;
            this.TXTTagWizardName.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.TXTTagWizardName.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTTagWizardName.CustomButton.Name = "";
            this.TXTTagWizardName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTTagWizardName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTTagWizardName.CustomButton.TabIndex = 1;
            this.TXTTagWizardName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTTagWizardName.CustomButton.UseSelectable = true;
            this.TXTTagWizardName.CustomButton.Visible = false;
            this.TXTTagWizardName.Lines = new string[0];
            this.TXTTagWizardName.Location = new System.Drawing.Point(4, 38);
            this.TXTTagWizardName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTTagWizardName.MaxLength = 32767;
            this.TXTTagWizardName.Name = "TXTTagWizardName";
            this.TXTTagWizardName.PasswordChar = '\0';
            this.TXTTagWizardName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTTagWizardName.SelectedText = "";
            this.TXTTagWizardName.SelectionLength = 0;
            this.TXTTagWizardName.SelectionStart = 0;
            this.TXTTagWizardName.ShortcutsEnabled = true;
            this.TXTTagWizardName.Size = new System.Drawing.Size(207, 28);
            this.TXTTagWizardName.TabIndex = 2;
            this.TTMain.SetToolTip(this.TXTTagWizardName, "Name to both create or delete a tag");
            this.TXTTagWizardName.UseSelectable = true;
            this.TXTTagWizardName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTTagWizardName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTNRemoveSelectedTags
            // 
            this.BTNRemoveSelectedTags.Location = new System.Drawing.Point(116, 313);
            this.BTNRemoveSelectedTags.Margin = new System.Windows.Forms.Padding(4);
            this.BTNRemoveSelectedTags.Name = "BTNRemoveSelectedTags";
            this.BTNRemoveSelectedTags.Size = new System.Drawing.Size(107, 31);
            this.BTNRemoveSelectedTags.TabIndex = 45;
            this.BTNRemoveSelectedTags.Text = "Remove Tags";
            this.TTMain.SetToolTip(this.BTNRemoveSelectedTags, "Removes the checked tags from the selected Item");
            this.BTNRemoveSelectedTags.UseSelectable = true;
            this.BTNRemoveSelectedTags.Click += new System.EventHandler(this.BTNRemoveSelectedTags_Click);
            // 
            // BTNApplyTags
            // 
            this.BTNApplyTags.Location = new System.Drawing.Point(0, 313);
            this.BTNApplyTags.Margin = new System.Windows.Forms.Padding(4);
            this.BTNApplyTags.Name = "BTNApplyTags";
            this.BTNApplyTags.Size = new System.Drawing.Size(108, 31);
            this.BTNApplyTags.TabIndex = 43;
            this.BTNApplyTags.Text = "Apply Tags";
            this.TTMain.SetToolTip(this.BTNApplyTags, "Adds the checked tags to the selected Item");
            this.BTNApplyTags.UseSelectable = true;
            this.BTNApplyTags.Click += new System.EventHandler(this.BTNApplyTag_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.BTNNewTagPreset);
            this.metroPanel3.Controls.Add(this.LBLNewPresetName);
            this.metroPanel3.Controls.Add(this.TXTTagPresetName);
            this.metroPanel3.Controls.Add(this.BTNTagPresetRemove);
            this.metroPanel3.Controls.Add(this.LBLTagPresetWizard);
            this.metroPanel3.Controls.Add(this.BTNTagPresetAdd);
            this.metroPanel3.Controls.Add(this.BTNApplyTagPreset);
            this.metroPanel3.Controls.Add(this.LBXTagPresets);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(229, 43);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(277, 459);
            this.metroPanel3.TabIndex = 44;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // BTNNewTagPreset
            // 
            this.BTNNewTagPreset.Location = new System.Drawing.Point(19, 415);
            this.BTNNewTagPreset.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNewTagPreset.Name = "BTNNewTagPreset";
            this.BTNNewTagPreset.Size = new System.Drawing.Size(239, 32);
            this.BTNNewTagPreset.TabIndex = 10;
            this.BTNNewTagPreset.Text = "Create New Preset";
            this.TTMain.SetToolTip(this.BTNNewTagPreset, "Creates Preset from Name and Checked Tags");
            this.BTNNewTagPreset.UseSelectable = true;
            this.BTNNewTagPreset.Click += new System.EventHandler(this.BTNNewTagPreset_Click);
            // 
            // LBLNewPresetName
            // 
            this.LBLNewPresetName.AutoSize = true;
            this.LBLNewPresetName.Location = new System.Drawing.Point(19, 346);
            this.LBLNewPresetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNewPresetName.Name = "LBLNewPresetName";
            this.LBLNewPresetName.Size = new System.Drawing.Size(126, 20);
            this.LBLNewPresetName.TabIndex = 9;
            this.LBLNewPresetName.Text = "New Preset Name:";
            // 
            // TXTTagPresetName
            // 
            // 
            // 
            // 
            this.TXTTagPresetName.CustomButton.Image = null;
            this.TXTTagPresetName.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.TXTTagPresetName.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTTagPresetName.CustomButton.Name = "";
            this.TXTTagPresetName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTTagPresetName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTTagPresetName.CustomButton.TabIndex = 1;
            this.TXTTagPresetName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTTagPresetName.CustomButton.UseSelectable = true;
            this.TXTTagPresetName.CustomButton.Visible = false;
            this.TXTTagPresetName.Lines = new string[0];
            this.TXTTagPresetName.Location = new System.Drawing.Point(19, 377);
            this.TXTTagPresetName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTTagPresetName.MaxLength = 32767;
            this.TXTTagPresetName.Name = "TXTTagPresetName";
            this.TXTTagPresetName.PasswordChar = '\0';
            this.TXTTagPresetName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTTagPresetName.SelectedText = "";
            this.TXTTagPresetName.SelectionLength = 0;
            this.TXTTagPresetName.SelectionStart = 0;
            this.TXTTagPresetName.ShortcutsEnabled = true;
            this.TXTTagPresetName.Size = new System.Drawing.Size(239, 28);
            this.TXTTagPresetName.TabIndex = 8;
            this.TTMain.SetToolTip(this.TXTTagPresetName, "Name for new Preset");
            this.TXTTagPresetName.UseSelectable = true;
            this.TXTTagPresetName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTTagPresetName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTNTagPresetRemove
            // 
            this.BTNTagPresetRemove.Location = new System.Drawing.Point(144, 308);
            this.BTNTagPresetRemove.Margin = new System.Windows.Forms.Padding(4);
            this.BTNTagPresetRemove.Name = "BTNTagPresetRemove";
            this.BTNTagPresetRemove.Size = new System.Drawing.Size(113, 28);
            this.BTNTagPresetRemove.TabIndex = 7;
            this.BTNTagPresetRemove.Text = "Remove Tags";
            this.TTMain.SetToolTip(this.BTNTagPresetRemove, "Remove checked tags from selected preset");
            this.BTNTagPresetRemove.UseSelectable = true;
            this.BTNTagPresetRemove.Click += new System.EventHandler(this.BTNTagPresetRemove_Click);
            // 
            // LBLTagPresetWizard
            // 
            this.LBLTagPresetWizard.AutoSize = true;
            this.LBLTagPresetWizard.Location = new System.Drawing.Point(19, 268);
            this.LBLTagPresetWizard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTagPresetWizard.Name = "LBLTagPresetWizard";
            this.LBLTagPresetWizard.Size = new System.Drawing.Size(123, 20);
            this.LBLTagPresetWizard.TabIndex = 6;
            this.LBLTagPresetWizard.Text = "Tag Preset Wizard:";
            // 
            // BTNTagPresetAdd
            // 
            this.BTNTagPresetAdd.Location = new System.Drawing.Point(19, 308);
            this.BTNTagPresetAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BTNTagPresetAdd.Name = "BTNTagPresetAdd";
            this.BTNTagPresetAdd.Size = new System.Drawing.Size(117, 28);
            this.BTNTagPresetAdd.TabIndex = 5;
            this.BTNTagPresetAdd.Text = "Add Tags";
            this.TTMain.SetToolTip(this.BTNTagPresetAdd, "Add checked tags to selected preset");
            this.BTNTagPresetAdd.UseSelectable = true;
            this.BTNTagPresetAdd.Click += new System.EventHandler(this.BTNTagPresetAdd_Click);
            // 
            // BTNApplyTagPreset
            // 
            this.BTNApplyTagPreset.Location = new System.Drawing.Point(19, 220);
            this.BTNApplyTagPreset.Margin = new System.Windows.Forms.Padding(4);
            this.BTNApplyTagPreset.Name = "BTNApplyTagPreset";
            this.BTNApplyTagPreset.Size = new System.Drawing.Size(239, 28);
            this.BTNApplyTagPreset.TabIndex = 4;
            this.BTNApplyTagPreset.Text = "Apply Preset";
            this.TTMain.SetToolTip(this.BTNApplyTagPreset, "Checks all tags within the preset, unchecks others");
            this.BTNApplyTagPreset.UseSelectable = true;
            this.BTNApplyTagPreset.Click += new System.EventHandler(this.BTNApplyTagPreset_Click);
            // 
            // LBXTagPresets
            // 
            this.LBXTagPresets.FormattingEnabled = true;
            this.LBXTagPresets.ItemHeight = 16;
            this.LBXTagPresets.Location = new System.Drawing.Point(19, 55);
            this.LBXTagPresets.Margin = new System.Windows.Forms.Padding(4);
            this.LBXTagPresets.Name = "LBXTagPresets";
            this.LBXTagPresets.Size = new System.Drawing.Size(237, 148);
            this.LBXTagPresets.Sorted = true;
            this.LBXTagPresets.TabIndex = 3;
            this.TTMain.SetToolTip(this.LBXTagPresets, "List of Tag Presets");
            this.LBXTagPresets.SelectedIndexChanged += new System.EventHandler(this.LBXTagPresets_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 11);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tag Presets:";
            // 
            // BTNShowTag
            // 
            this.BTNShowTag.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNShowTag.Location = new System.Drawing.Point(1085, 48);
            this.BTNShowTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNShowTag.Name = "BTNShowTag";
            this.BTNShowTag.Size = new System.Drawing.Size(85, 30);
            this.BTNShowTag.TabIndex = 48;
            this.BTNShowTag.Text = "Show Tags";
            this.TTMain.SetToolTip(this.BTNShowTag, "Shows/Hides tab menus");
            this.BTNShowTag.UseSelectable = true;
            this.BTNShowTag.Click += new System.EventHandler(this.BTNShowTag_Click);
            // 
            // TXTSearchData
            // 
            // 
            // 
            // 
            this.TXTSearchData.CustomButton.Image = null;
            this.TXTSearchData.CustomButton.Location = new System.Drawing.Point(399, 1);
            this.TXTSearchData.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTSearchData.CustomButton.Name = "";
            this.TXTSearchData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTSearchData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSearchData.CustomButton.TabIndex = 1;
            this.TXTSearchData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSearchData.CustomButton.UseSelectable = true;
            this.TXTSearchData.CustomButton.Visible = false;
            this.TXTSearchData.Enabled = false;
            this.TXTSearchData.Lines = new string[0];
            this.TXTSearchData.Location = new System.Drawing.Point(31, 666);
            this.TXTSearchData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSearchData.MaxLength = 32767;
            this.TXTSearchData.Name = "TXTSearchData";
            this.TXTSearchData.PasswordChar = '\0';
            this.TXTSearchData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTSearchData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSearchData.SelectedText = "";
            this.TXTSearchData.SelectionLength = 0;
            this.TXTSearchData.SelectionStart = 0;
            this.TXTSearchData.ShortcutsEnabled = true;
            this.TXTSearchData.Size = new System.Drawing.Size(421, 23);
            this.TXTSearchData.TabIndex = 41;
            this.TXTSearchData.UseSelectable = true;
            this.TXTSearchData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTSearchData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTNSearch
            // 
            this.BTNSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNSearch.Location = new System.Drawing.Point(477, 66);
            this.BTNSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(116, 62);
            this.BTNSearch.TabIndex = 39;
            this.BTNSearch.Text = "Search";
            this.TTMain.SetToolTip(this.BTNSearch, "Applies search filters and displays matching entries below");
            this.BTNSearch.UseSelectable = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // ComboBXDriveSelect
            // 
            this.ComboBXDriveSelect.FormattingEnabled = true;
            this.ComboBXDriveSelect.ItemHeight = 24;
            this.ComboBXDriveSelect.Location = new System.Drawing.Point(127, 98);
            this.ComboBXDriveSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBXDriveSelect.Name = "ComboBXDriveSelect";
            this.ComboBXDriveSelect.Size = new System.Drawing.Size(187, 30);
            this.ComboBXDriveSelect.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ComboBXDriveSelect.TabIndex = 38;
            this.TTMain.SetToolTip(this.ComboBXDriveSelect, "Drive to Search");
            this.ComboBXDriveSelect.UseSelectable = true;
            // 
            // CBXSpecifyDrive
            // 
            this.CBXSpecifyDrive.AutoSize = true;
            this.CBXSpecifyDrive.Location = new System.Drawing.Point(320, 103);
            this.CBXSpecifyDrive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBXSpecifyDrive.Name = "CBXSpecifyDrive";
            this.CBXSpecifyDrive.Size = new System.Drawing.Size(108, 17);
            this.CBXSpecifyDrive.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSpecifyDrive.TabIndex = 37;
            this.CBXSpecifyDrive.Text = "Specify Drives:";
            this.TTMain.SetToolTip(this.CBXSpecifyDrive, "Limits search to a specific drive");
            this.CBXSpecifyDrive.UseSelectable = true;
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
            this.TXTSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTSearch.CustomButton.Name = "";
            this.TXTSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSearch.CustomButton.TabIndex = 1;
            this.TXTSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSearch.CustomButton.UseSelectable = true;
            this.TXTSearch.CustomButton.Visible = false;
            this.TXTSearch.Lines = new string[0];
            this.TXTSearch.Location = new System.Drawing.Point(104, 48);
            this.TXTSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.TTMain.SetToolTip(this.TXTSearch, "Searches for entries that contain the phrase (ie. Apple contains ap)");
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(171, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By:";
            this.TTMain.SetToolTip(this.groupBox1, "How the display sorts the matching items (Multiple can be Applied)");
            // 
            // CBXSize
            // 
            this.CBXSize.AutoSize = true;
            this.CBXSize.Location = new System.Drawing.Point(84, 52);
            this.CBXSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBXSize.Name = "CBXSize";
            this.CBXSize.Size = new System.Drawing.Size(47, 17);
            this.CBXSize.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSize.TabIndex = 32;
            this.CBXSize.Text = "Size";
            this.TTMain.SetToolTip(this.CBXSize, "Sort by file size, Largest at the top");
            this.CBXSize.UseSelectable = true;
            // 
            // CBXAlpha
            // 
            this.CBXAlpha.AutoSize = true;
            this.CBXAlpha.Location = new System.Drawing.Point(84, 25);
            this.CBXAlpha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBXAlpha.Name = "CBXAlpha";
            this.CBXAlpha.Size = new System.Drawing.Size(57, 17);
            this.CBXAlpha.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXAlpha.TabIndex = 31;
            this.CBXAlpha.Text = "Alpha";
            this.TTMain.SetToolTip(this.CBXAlpha, "Alphabetical Sorting");
            this.CBXAlpha.UseSelectable = true;
            // 
            // CBXDate
            // 
            this.CBXDate.AutoSize = true;
            this.CBXDate.Location = new System.Drawing.Point(5, 52);
            this.CBXDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBXDate.Name = "CBXDate";
            this.CBXDate.Size = new System.Drawing.Size(51, 17);
            this.CBXDate.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXDate.TabIndex = 30;
            this.CBXDate.Text = "Date";
            this.TTMain.SetToolTip(this.CBXDate, "Sort by date modified, Earlier at the top");
            this.CBXDate.UseSelectable = true;
            // 
            // CBXDrive
            // 
            this.CBXDrive.AutoSize = true;
            this.CBXDrive.Checked = true;
            this.CBXDrive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBXDrive.Location = new System.Drawing.Point(5, 25);
            this.CBXDrive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBXDrive.Name = "CBXDrive";
            this.CBXDrive.Size = new System.Drawing.Size(54, 17);
            this.CBXDrive.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXDrive.TabIndex = 29;
            this.CBXDrive.Text = "Drive";
            this.TTMain.SetToolTip(this.CBXDrive, "Groups items by their respective root drive (ie Drive 10)");
            this.CBXDrive.UseSelectable = true;
            // 
            // GBSearchAttributes
            // 
            this.GBSearchAttributes.Controls.Add(this.CBXExactMatch);
            this.GBSearchAttributes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSearchAttributes.Location = new System.Drawing.Point(725, 37);
            this.GBSearchAttributes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSearchAttributes.Name = "GBSearchAttributes";
            this.GBSearchAttributes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBSearchAttributes.Size = new System.Drawing.Size(128, 82);
            this.GBSearchAttributes.TabIndex = 30;
            this.GBSearchAttributes.TabStop = false;
            this.GBSearchAttributes.Text = " Quantifiers:";
            // 
            // CBXExactMatch
            // 
            this.CBXExactMatch.AutoSize = true;
            this.CBXExactMatch.Location = new System.Drawing.Point(5, 25);
            this.CBXExactMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBXExactMatch.Name = "CBXExactMatch";
            this.CBXExactMatch.Size = new System.Drawing.Size(94, 17);
            this.CBXExactMatch.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXExactMatch.TabIndex = 27;
            this.CBXExactMatch.Text = "Exact Match";
            this.TTMain.SetToolTip(this.CBXExactMatch, "Makes the search case-sensitive (ie. A does not equal a)");
            this.CBXExactMatch.UseSelectable = true;
            // 
            // GBXFilter
            // 
            this.GBXFilter.Controls.Add(this.RBTNTag);
            this.GBXFilter.Controls.Add(this.RBTNName);
            this.GBXFilter.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXFilter.Location = new System.Drawing.Point(619, 36);
            this.GBXFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBXFilter.Name = "GBXFilter";
            this.GBXFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBXFilter.Size = new System.Drawing.Size(84, 82);
            this.GBXFilter.TabIndex = 29;
            this.GBXFilter.TabStop = false;
            this.GBXFilter.Text = "Filter:";
            this.TTMain.SetToolTip(this.GBXFilter, "Determines what items are found");
            // 
            // RBTNTag
            // 
            this.RBTNTag.AutoSize = true;
            this.RBTNTag.Location = new System.Drawing.Point(5, 53);
            this.RBTNTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBTNTag.Name = "RBTNTag";
            this.RBTNTag.Size = new System.Drawing.Size(45, 17);
            this.RBTNTag.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNTag.TabIndex = 28;
            this.RBTNTag.Text = "Tag";
            this.TTMain.SetToolTip(this.RBTNTag, "Searches by if any of a items tags contain the phrase");
            this.RBTNTag.UseSelectable = true;
            // 
            // RBTNName
            // 
            this.RBTNName.AutoSize = true;
            this.RBTNName.Checked = true;
            this.RBTNName.Location = new System.Drawing.Point(5, 25);
            this.RBTNName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBTNName.Name = "RBTNName";
            this.RBTNName.Size = new System.Drawing.Size(59, 17);
            this.RBTNName.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNName.TabIndex = 27;
            this.RBTNName.TabStop = true;
            this.RBTNName.Text = "Name";
            this.TTMain.SetToolTip(this.RBTNName, "Searches by name");
            this.RBTNName.UseSelectable = true;
            // 
            // TVSearchView
            // 
            this.TVSearchView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVSearchView.Location = new System.Drawing.Point(31, 156);
            this.TVSearchView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVSearchView.MaximumSize = new System.Drawing.Size(1265, 501);
            this.TVSearchView.Name = "TVSearchView";
            this.TVSearchView.Size = new System.Drawing.Size(1265, 501);
            this.TVSearchView.TabIndex = 28;
            this.TTMain.SetToolTip(this.TVSearchView, "Hit (+) to open a item, click to select");
            this.TVSearchView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVSearchView_AfterSelect);
            // 
            // TPDriveManager
            // 
            this.TPDriveManager.BackColor = System.Drawing.SystemColors.Window;
            this.TPDriveManager.Controls.Add(this.BTNShowSubs);
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
            this.TPDriveManager.Margin = new System.Windows.Forms.Padding(4);
            this.TPDriveManager.Name = "TPDriveManager";
            this.TPDriveManager.Padding = new System.Windows.Forms.Padding(31, 33, 31, 33);
            this.TPDriveManager.Size = new System.Drawing.Size(1341, 706);
            this.TPDriveManager.TabIndex = 2;
            this.TPDriveManager.Text = "  Drive Manager  ";
            this.TPDriveManager.ToolTipText = "Manually edit data and view data layout";
            // 
            // BTNShowSubs
            // 
            this.BTNShowSubs.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNShowSubs.Location = new System.Drawing.Point(25, 539);
            this.BTNShowSubs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNShowSubs.Name = "BTNShowSubs";
            this.BTNShowSubs.Size = new System.Drawing.Size(176, 30);
            this.BTNShowSubs.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNShowSubs.TabIndex = 56;
            this.BTNShowSubs.Text = "Show Sub Directories";
            this.TTMain.SetToolTip(this.BTNShowSubs, "Shows/Hides all sub folders/files");
            this.BTNShowSubs.UseSelectable = true;
            this.BTNShowSubs.Click += new System.EventHandler(this.BTNShowSubs_Click);
            // 
            // BTNUploadXML
            // 
            this.BTNUploadXML.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNUploadXML.Location = new System.Drawing.Point(793, 295);
            this.BTNUploadXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNUploadXML.Name = "BTNUploadXML";
            this.BTNUploadXML.Size = new System.Drawing.Size(113, 30);
            this.BTNUploadXML.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNUploadXML.TabIndex = 55;
            this.BTNUploadXML.Text = "Upload XML";
            this.TTMain.SetToolTip(this.BTNUploadXML, "Uploads Data to Google Drive");
            this.BTNUploadXML.UseSelectable = true;
            this.BTNUploadXML.Click += new System.EventHandler(this.BTNUploadXML_Click);
            // 
            // BTNDownloadXML
            // 
            this.BTNDownloadXML.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNDownloadXML.Location = new System.Drawing.Point(793, 260);
            this.BTNDownloadXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDownloadXML.Name = "BTNDownloadXML";
            this.BTNDownloadXML.Size = new System.Drawing.Size(113, 30);
            this.BTNDownloadXML.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNDownloadXML.TabIndex = 54;
            this.BTNDownloadXML.Text = "Download XML";
            this.TTMain.SetToolTip(this.BTNDownloadXML, "Downloads Data from Google Drive");
            this.BTNDownloadXML.UseSelectable = true;
            this.BTNDownloadXML.Click += new System.EventHandler(this.BTNDownloadXML_Click);
            // 
            // TXTDrivePath
            // 
            // 
            // 
            // 
            this.TXTDrivePath.CustomButton.Image = null;
            this.TXTDrivePath.CustomButton.Location = new System.Drawing.Point(327, 2);
            this.TXTDrivePath.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTDrivePath.CustomButton.Name = "";
            this.TXTDrivePath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTDrivePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTDrivePath.CustomButton.TabIndex = 1;
            this.TXTDrivePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTDrivePath.CustomButton.UseSelectable = true;
            this.TXTDrivePath.CustomButton.Visible = false;
            this.TXTDrivePath.Lines = new string[0];
            this.TXTDrivePath.Location = new System.Drawing.Point(31, 46);
            this.TXTDrivePath.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDrivePath.MaxLength = 32767;
            this.TXTDrivePath.Name = "TXTDrivePath";
            this.TXTDrivePath.PasswordChar = '\0';
            this.TXTDrivePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTDrivePath.SelectedText = "";
            this.TXTDrivePath.SelectionLength = 0;
            this.TXTDrivePath.SelectionStart = 0;
            this.TXTDrivePath.ShortcutsEnabled = true;
            this.TXTDrivePath.Size = new System.Drawing.Size(353, 28);
            this.TXTDrivePath.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTDrivePath.TabIndex = 53;
            this.TTMain.SetToolTip(this.TXTDrivePath, "Folder Path to scan");
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
            this.TXTNickname.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.TXTNickname.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTNickname.CustomButton.Name = "";
            this.TXTNickname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTNickname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNickname.CustomButton.TabIndex = 1;
            this.TXTNickname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNickname.CustomButton.UseSelectable = true;
            this.TXTNickname.CustomButton.Visible = false;
            this.TXTNickname.Lines = new string[0];
            this.TXTNickname.Location = new System.Drawing.Point(175, 79);
            this.TXTNickname.Margin = new System.Windows.Forms.Padding(4);
            this.TXTNickname.MaxLength = 32767;
            this.TXTNickname.Name = "TXTNickname";
            this.TXTNickname.PasswordChar = '\0';
            this.TXTNickname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNickname.SelectedText = "";
            this.TXTNickname.SelectionLength = 0;
            this.TXTNickname.SelectionStart = 0;
            this.TXTNickname.ShortcutsEnabled = true;
            this.TXTNickname.Size = new System.Drawing.Size(209, 28);
            this.TXTNickname.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTNickname.TabIndex = 52;
            this.TTMain.SetToolTip(this.TXTNickname, "Replaces the folder name (ie. D:// to \"Drive 10\")");
            this.TXTNickname.UseSelectable = true;
            this.TXTNickname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTNickname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LBLNickname
            // 
            this.LBLNickname.AutoSize = true;
            this.LBLNickname.Location = new System.Drawing.Point(25, 81);
            this.LBLNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNickname.Name = "LBLNickname";
            this.LBLNickname.Size = new System.Drawing.Size(112, 20);
            this.LBLNickname.TabIndex = 51;
            this.LBLNickname.Text = "Drive Nickname:";
            // 
            // LBLChangesMade
            // 
            this.LBLChangesMade.AutoSize = true;
            this.LBLChangesMade.Location = new System.Drawing.Point(33, 651);
            this.LBLChangesMade.Name = "LBLChangesMade";
            this.LBLChangesMade.Size = new System.Drawing.Size(244, 20);
            this.LBLChangesMade.TabIndex = 50;
            this.LBLChangesMade.Text = "Changes Made, Please Write Changes";
            this.TTMain.SetToolTip(this.LBLChangesMade, "Hit the Write Drive Data Button");
            this.LBLChangesMade.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroLabel2.Location = new System.Drawing.Point(611, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 20);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "! Use Only If Trained !";
            this.TTMain.SetToolTip(this.metroLabel2, "!Caution! This menu has powerful manual control");
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNDelete.Location = new System.Drawing.Point(279, 538);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(103, 30);
            this.BTNDelete.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNDelete.TabIndex = 48;
            this.BTNDelete.Text = "Delete Entry";
            this.TTMain.SetToolTip(this.BTNDelete, "Delete the selected item");
            this.BTNDelete.UseSelectable = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNRefreshDrives
            // 
            this.BTNRefreshDrives.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNRefreshDrives.Location = new System.Drawing.Point(595, 505);
            this.BTNRefreshDrives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRefreshDrives.Name = "BTNRefreshDrives";
            this.BTNRefreshDrives.Size = new System.Drawing.Size(77, 30);
            this.BTNRefreshDrives.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNRefreshDrives.TabIndex = 47;
            this.BTNRefreshDrives.Text = "Refresh";
            this.TTMain.SetToolTip(this.BTNRefreshDrives, "Refresh Local Drives");
            this.BTNRefreshDrives.UseSelectable = true;
            this.BTNRefreshDrives.Click += new System.EventHandler(this.BTNRefreshDrives_Click);
            // 
            // BTNRestore
            // 
            this.BTNRestore.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNRestore.Location = new System.Drawing.Point(680, 295);
            this.BTNRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRestore.Name = "BTNRestore";
            this.BTNRestore.Size = new System.Drawing.Size(77, 30);
            this.BTNRestore.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNRestore.TabIndex = 46;
            this.BTNRestore.Text = "Restore";
            this.TTMain.SetToolTip(this.BTNRestore, "Restores backup from a local copy");
            this.BTNRestore.UseSelectable = true;
            this.BTNRestore.Click += new System.EventHandler(this.BTNRestore_Click);
            // 
            // BTNBackup
            // 
            this.BTNBackup.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNBackup.Location = new System.Drawing.Point(597, 295);
            this.BTNBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNBackup.Name = "BTNBackup";
            this.BTNBackup.Size = new System.Drawing.Size(77, 30);
            this.BTNBackup.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNBackup.TabIndex = 45;
            this.BTNBackup.Text = "Backup";
            this.TTMain.SetToolTip(this.BTNBackup, "Backups data to a local copy");
            this.BTNBackup.UseSelectable = true;
            this.BTNBackup.Click += new System.EventHandler(this.BTNBackup_Click);
            // 
            // BTNClearFile
            // 
            this.BTNClearFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNClearFile.Location = new System.Drawing.Point(597, 260);
            this.BTNClearFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNClearFile.Name = "BTNClearFile";
            this.BTNClearFile.Size = new System.Drawing.Size(77, 30);
            this.BTNClearFile.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNClearFile.TabIndex = 44;
            this.BTNClearFile.Text = "Clear";
            this.TTMain.SetToolTip(this.BTNClearFile, "!Caution! Deletes all data from the Local System");
            this.BTNClearFile.UseSelectable = true;
            this.BTNClearFile.Click += new System.EventHandler(this.BTNClearFile_Click);
            // 
            // BTNReadDriveData
            // 
            this.BTNReadDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNReadDriveData.Location = new System.Drawing.Point(439, 295);
            this.BTNReadDriveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNReadDriveData.Name = "BTNReadDriveData";
            this.BTNReadDriveData.Size = new System.Drawing.Size(149, 30);
            this.BTNReadDriveData.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNReadDriveData.TabIndex = 43;
            this.BTNReadDriveData.Text = "Read Drive Data";
            this.TTMain.SetToolTip(this.BTNReadDriveData, "Updates data from the Local System");
            this.BTNReadDriveData.UseSelectable = true;
            this.BTNReadDriveData.Click += new System.EventHandler(this.BTNReadDriveData_Click);
            // 
            // BTNWriteDriveData
            // 
            this.BTNWriteDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNWriteDriveData.Location = new System.Drawing.Point(439, 260);
            this.BTNWriteDriveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNWriteDriveData.Name = "BTNWriteDriveData";
            this.BTNWriteDriveData.Size = new System.Drawing.Size(152, 30);
            this.BTNWriteDriveData.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNWriteDriveData.TabIndex = 42;
            this.BTNWriteDriveData.Text = "Write Drive Data";
            this.TTMain.SetToolTip(this.BTNWriteDriveData, "Saves data to the Local System");
            this.BTNWriteDriveData.UseSelectable = true;
            this.BTNWriteDriveData.Click += new System.EventHandler(this.BTNWriteDriveData_Click);
            // 
            // LBLFileData
            // 
            this.LBLFileData.AutoSize = true;
            this.LBLFileData.Location = new System.Drawing.Point(439, 123);
            this.LBLFileData.Name = "LBLFileData";
            this.LBLFileData.Size = new System.Drawing.Size(62, 20);
            this.LBLFileData.TabIndex = 41;
            this.LBLFileData.Text = "File Data";
            // 
            // BTNFindFolder
            // 
            this.BTNFindFolder.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNFindFolder.Location = new System.Drawing.Point(437, 46);
            this.BTNFindFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNFindFolder.Name = "BTNFindFolder";
            this.BTNFindFolder.Size = new System.Drawing.Size(115, 38);
            this.BTNFindFolder.TabIndex = 40;
            this.BTNFindFolder.Text = "File Explorer";
            this.TTMain.SetToolTip(this.BTNFindFolder, "Choose a folder to scan");
            this.BTNFindFolder.UseSelectable = true;
            this.BTNFindFolder.Click += new System.EventHandler(this.BTNFindFolder_Click);
            // 
            // BTNLoadDriveData
            // 
            this.BTNLoadDriveData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNLoadDriveData.Location = new System.Drawing.Point(259, 112);
            this.BTNLoadDriveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLoadDriveData.Name = "BTNLoadDriveData";
            this.BTNLoadDriveData.Size = new System.Drawing.Size(123, 28);
            this.BTNLoadDriveData.TabIndex = 39;
            this.BTNLoadDriveData.Text = "Load Drive Data";
            this.TTMain.SetToolTip(this.BTNLoadDriveData, "Scans the path, adding the respective item");
            this.BTNLoadDriveData.UseSelectable = true;
            this.BTNLoadDriveData.Click += new System.EventHandler(this.BTNLoadDriveData_Click);
            // 
            // LBLDriveView
            // 
            this.LBLDriveView.AutoSize = true;
            this.LBLDriveView.Location = new System.Drawing.Point(25, 121);
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
            this.TTMain.SetToolTip(this.LBXDrives, "Lists all Root Drives on the Local System");
            // 
            // LBXFileData
            // 
            this.LBXFileData.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXFileData.FormattingEnabled = true;
            this.LBXFileData.ItemHeight = 17;
            this.LBXFileData.Location = new System.Drawing.Point(439, 149);
            this.LBXFileData.Margin = new System.Windows.Forms.Padding(4);
            this.LBXFileData.Name = "LBXFileData";
            this.LBXFileData.Size = new System.Drawing.Size(471, 72);
            this.LBXFileData.TabIndex = 34;
            this.TTMain.SetToolTip(this.LBXFileData, "Metadata of the selected item");
            // 
            // TVDriveView
            // 
            this.TVDriveView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TVDriveView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVDriveView.Location = new System.Drawing.Point(25, 146);
            this.TVDriveView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVDriveView.Name = "TVDriveView";
            this.TVDriveView.Size = new System.Drawing.Size(357, 386);
            this.TVDriveView.TabIndex = 32;
            this.TTMain.SetToolTip(this.TVDriveView, "Shows the relation between all loaded items");
            this.TVDriveView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVDriveView_AfterSelect);
            // 
            // TPStorageOptimization
            // 
            this.TPStorageOptimization.BackColor = System.Drawing.SystemColors.Window;
            this.TPStorageOptimization.Controls.Add(this.LBLMegaBytes);
            this.TPStorageOptimization.Controls.Add(this.LBLMinimunSize);
            this.TPStorageOptimization.Controls.Add(this.TXTMinimumSize);
            this.TPStorageOptimization.Controls.Add(this.CBXSaveToExcel);
            this.TPStorageOptimization.Controls.Add(this.CBXConsolidateResults);
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
            this.TPStorageOptimization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TPStorageOptimization.Name = "TPStorageOptimization";
            this.TPStorageOptimization.Size = new System.Drawing.Size(1341, 706);
            this.TPStorageOptimization.TabIndex = 3;
            this.TPStorageOptimization.Text = "  Storage Optimization  ";
            this.TPStorageOptimization.ToolTipText = "Generate report for clearing drive storage safely";
            // 
            // LBLMegaBytes
            // 
            this.LBLMegaBytes.AutoSize = true;
            this.LBLMegaBytes.Location = new System.Drawing.Point(1211, 23);
            this.LBLMegaBytes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLMegaBytes.Name = "LBLMegaBytes";
            this.LBLMegaBytes.Size = new System.Drawing.Size(29, 20);
            this.LBLMegaBytes.TabIndex = 13;
            this.LBLMegaBytes.Text = "mb";
            // 
            // LBLMinimunSize
            // 
            this.LBLMinimunSize.AutoSize = true;
            this.LBLMinimunSize.Location = new System.Drawing.Point(973, 23);
            this.LBLMinimunSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLMinimunSize.Name = "LBLMinimunSize";
            this.LBLMinimunSize.Size = new System.Drawing.Size(99, 20);
            this.LBLMinimunSize.TabIndex = 12;
            this.LBLMinimunSize.Text = "Minimum Size:";
            // 
            // TXTMinimumSize
            // 
            // 
            // 
            // 
            this.TXTMinimumSize.CustomButton.Image = null;
            this.TXTMinimumSize.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.TXTMinimumSize.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTMinimumSize.CustomButton.Name = "";
            this.TXTMinimumSize.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTMinimumSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTMinimumSize.CustomButton.TabIndex = 1;
            this.TXTMinimumSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTMinimumSize.CustomButton.UseSelectable = true;
            this.TXTMinimumSize.CustomButton.Visible = false;
            this.TXTMinimumSize.Lines = new string[] {
        "1"};
            this.TXTMinimumSize.Location = new System.Drawing.Point(1104, 22);
            this.TXTMinimumSize.Margin = new System.Windows.Forms.Padding(4);
            this.TXTMinimumSize.MaxLength = 32767;
            this.TXTMinimumSize.Name = "TXTMinimumSize";
            this.TXTMinimumSize.PasswordChar = '\0';
            this.TXTMinimumSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTMinimumSize.SelectedText = "";
            this.TXTMinimumSize.SelectionLength = 0;
            this.TXTMinimumSize.SelectionStart = 0;
            this.TXTMinimumSize.ShortcutsEnabled = true;
            this.TXTMinimumSize.Size = new System.Drawing.Size(108, 28);
            this.TXTMinimumSize.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTMinimumSize.TabIndex = 11;
            this.TXTMinimumSize.Text = "1";
            this.TTMain.SetToolTip(this.TXTMinimumSize, "Minimum file/folder size to show");
            this.TXTMinimumSize.UseSelectable = true;
            this.TXTMinimumSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTMinimumSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CBXSaveToExcel
            // 
            this.CBXSaveToExcel.AutoSize = true;
            this.CBXSaveToExcel.Checked = true;
            this.CBXSaveToExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBXSaveToExcel.Location = new System.Drawing.Point(11, 443);
            this.CBXSaveToExcel.Margin = new System.Windows.Forms.Padding(4);
            this.CBXSaveToExcel.Name = "CBXSaveToExcel";
            this.CBXSaveToExcel.Size = new System.Drawing.Size(148, 17);
            this.CBXSaveToExcel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXSaveToExcel.TabIndex = 10;
            this.CBXSaveToExcel.Text = "Save To Excel Instead";
            this.TTMain.SetToolTip(this.CBXSaveToExcel, "(Recommended) Saves data to Excel Sheet");
            this.CBXSaveToExcel.UseSelectable = true;
            // 
            // CBXConsolidateResults
            // 
            this.CBXConsolidateResults.AutoSize = true;
            this.CBXConsolidateResults.Checked = true;
            this.CBXConsolidateResults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBXConsolidateResults.Location = new System.Drawing.Point(11, 410);
            this.CBXConsolidateResults.Margin = new System.Windows.Forms.Padding(4);
            this.CBXConsolidateResults.Name = "CBXConsolidateResults";
            this.CBXConsolidateResults.Size = new System.Drawing.Size(138, 17);
            this.CBXConsolidateResults.Style = MetroFramework.MetroColorStyle.Magenta;
            this.CBXConsolidateResults.TabIndex = 9;
            this.CBXConsolidateResults.Text = "Consolidate Results";
            this.TTMain.SetToolTip(this.CBXConsolidateResults, "(Recommended) Shows highest folder that can be deleted");
            this.CBXConsolidateResults.UseSelectable = true;
            // 
            // LBLOptiNumCopies
            // 
            this.LBLOptiNumCopies.AutoSize = true;
            this.LBLOptiNumCopies.Location = new System.Drawing.Point(695, 22);
            this.LBLOptiNumCopies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLOptiNumCopies.Name = "LBLOptiNumCopies";
            this.LBLOptiNumCopies.Size = new System.Drawing.Size(146, 20);
            this.LBLOptiNumCopies.TabIndex = 8;
            this.LBLOptiNumCopies.Text = "# of Copies Preferred:";
            // 
            // TXTOptiNumCopies
            // 
            // 
            // 
            // 
            this.TXTOptiNumCopies.CustomButton.Image = null;
            this.TXTOptiNumCopies.CustomButton.Location = new System.Drawing.Point(3, 2);
            this.TXTOptiNumCopies.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTOptiNumCopies.CustomButton.Name = "";
            this.TXTOptiNumCopies.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTOptiNumCopies.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTOptiNumCopies.CustomButton.TabIndex = 1;
            this.TXTOptiNumCopies.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTOptiNumCopies.CustomButton.UseSelectable = true;
            this.TXTOptiNumCopies.CustomButton.Visible = false;
            this.TXTOptiNumCopies.Lines = new string[] {
        "2"};
            this.TXTOptiNumCopies.Location = new System.Drawing.Point(889, 22);
            this.TXTOptiNumCopies.Margin = new System.Windows.Forms.Padding(4);
            this.TXTOptiNumCopies.MaxLength = 32767;
            this.TXTOptiNumCopies.Name = "TXTOptiNumCopies";
            this.TXTOptiNumCopies.PasswordChar = '\0';
            this.TXTOptiNumCopies.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTOptiNumCopies.SelectedText = "";
            this.TXTOptiNumCopies.SelectionLength = 0;
            this.TXTOptiNumCopies.SelectionStart = 0;
            this.TXTOptiNumCopies.ShortcutsEnabled = true;
            this.TXTOptiNumCopies.Size = new System.Drawing.Size(29, 28);
            this.TXTOptiNumCopies.Style = MetroFramework.MetroColorStyle.Magenta;
            this.TXTOptiNumCopies.TabIndex = 7;
            this.TXTOptiNumCopies.Text = "2";
            this.TTMain.SetToolTip(this.TXTOptiNumCopies, "Only shows files that occur more than the # of Copies");
            this.TXTOptiNumCopies.UseSelectable = true;
            this.TXTOptiNumCopies.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTOptiNumCopies.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LBLOptiFilter
            // 
            this.LBLOptiFilter.AutoSize = true;
            this.LBLOptiFilter.Location = new System.Drawing.Point(191, 20);
            this.LBLOptiFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLOptiFilter.Name = "LBLOptiFilter";
            this.LBLOptiFilter.Size = new System.Drawing.Size(61, 20);
            this.LBLOptiFilter.TabIndex = 6;
            this.LBLOptiFilter.Text = "Filter By:";
            // 
            // TXTOptiFilter
            // 
            // 
            // 
            // 
            this.TXTOptiFilter.CustomButton.Image = null;
            this.TXTOptiFilter.CustomButton.Location = new System.Drawing.Point(370, 2);
            this.TXTOptiFilter.CustomButton.Margin = new System.Windows.Forms.Padding(5);
            this.TXTOptiFilter.CustomButton.Name = "";
            this.TXTOptiFilter.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TXTOptiFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTOptiFilter.CustomButton.TabIndex = 1;
            this.TXTOptiFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTOptiFilter.CustomButton.UseSelectable = true;
            this.TXTOptiFilter.CustomButton.Visible = false;
            this.TXTOptiFilter.Lines = new string[0];
            this.TXTOptiFilter.Location = new System.Drawing.Point(277, 20);
            this.TXTOptiFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TXTOptiFilter.MaxLength = 32767;
            this.TXTOptiFilter.Name = "TXTOptiFilter";
            this.TXTOptiFilter.PasswordChar = '\0';
            this.TXTOptiFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTOptiFilter.SelectedText = "";
            this.TXTOptiFilter.SelectionLength = 0;
            this.TXTOptiFilter.SelectionStart = 0;
            this.TXTOptiFilter.ShortcutsEnabled = true;
            this.TXTOptiFilter.Size = new System.Drawing.Size(396, 28);
            this.TXTOptiFilter.TabIndex = 5;
            this.TTMain.SetToolTip(this.TXTOptiFilter, "Filter by items that contain the phrase");
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
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(24, 310);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(157, 82);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // RBTNOptiBoth
            // 
            this.RBTNOptiBoth.AutoSize = true;
            this.RBTNOptiBoth.Checked = true;
            this.RBTNOptiBoth.Location = new System.Drawing.Point(4, 57);
            this.RBTNOptiBoth.Margin = new System.Windows.Forms.Padding(4);
            this.RBTNOptiBoth.Name = "RBTNOptiBoth";
            this.RBTNOptiBoth.Size = new System.Drawing.Size(50, 17);
            this.RBTNOptiBoth.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNOptiBoth.TabIndex = 4;
            this.RBTNOptiBoth.TabStop = true;
            this.RBTNOptiBoth.Text = "Both";
            this.RBTNOptiBoth.UseSelectable = true;
            // 
            // RBTNOptiFilesOnly
            // 
            this.RBTNOptiFilesOnly.AutoSize = true;
            this.RBTNOptiFilesOnly.Location = new System.Drawing.Point(4, 31);
            this.RBTNOptiFilesOnly.Margin = new System.Windows.Forms.Padding(4);
            this.RBTNOptiFilesOnly.Name = "RBTNOptiFilesOnly";
            this.RBTNOptiFilesOnly.Size = new System.Drawing.Size(79, 17);
            this.RBTNOptiFilesOnly.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNOptiFilesOnly.TabIndex = 3;
            this.RBTNOptiFilesOnly.Text = "Files Only";
            this.TTMain.SetToolTip(this.RBTNOptiFilesOnly, "Show only Files");
            this.RBTNOptiFilesOnly.UseSelectable = true;
            // 
            // RBTNOptFoldersOnly
            // 
            this.RBTNOptFoldersOnly.AutoSize = true;
            this.RBTNOptFoldersOnly.Location = new System.Drawing.Point(5, 5);
            this.RBTNOptFoldersOnly.Margin = new System.Windows.Forms.Padding(4);
            this.RBTNOptFoldersOnly.Name = "RBTNOptFoldersOnly";
            this.RBTNOptFoldersOnly.Size = new System.Drawing.Size(97, 17);
            this.RBTNOptFoldersOnly.Style = MetroFramework.MetroColorStyle.Magenta;
            this.RBTNOptFoldersOnly.TabIndex = 2;
            this.RBTNOptFoldersOnly.Text = "Folders Only";
            this.TTMain.SetToolTip(this.RBTNOptFoldersOnly, "Show only folders");
            this.RBTNOptFoldersOnly.UseSelectable = true;
            // 
            // BTNProcessOptimization
            // 
            this.BTNProcessOptimization.Location = new System.Drawing.Point(24, 267);
            this.BTNProcessOptimization.Margin = new System.Windows.Forms.Padding(4);
            this.BTNProcessOptimization.Name = "BTNProcessOptimization";
            this.BTNProcessOptimization.Size = new System.Drawing.Size(157, 28);
            this.BTNProcessOptimization.TabIndex = 3;
            this.BTNProcessOptimization.Text = "Process";
            this.TTMain.SetToolTip(this.BTNProcessOptimization, "Begin the Optimization Algorithm");
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
            this.LVOptimizationResults.Location = new System.Drawing.Point(188, 57);
            this.LVOptimizationResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LVOptimizationResults.Name = "LVOptimizationResults";
            this.LVOptimizationResults.OwnerDraw = true;
            this.LVOptimizationResults.Size = new System.Drawing.Size(1060, 610);
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
            this.LBLDrivePriority.Location = new System.Drawing.Point(27, 31);
            this.LBLDrivePriority.Name = "LBLDrivePriority";
            this.LBLDrivePriority.Size = new System.Drawing.Size(92, 20);
            this.LBLDrivePriority.TabIndex = 1;
            this.LBLDrivePriority.Text = "Drive Priority:";
            // 
            // LBXDrivePriority
            // 
            this.LBXDrivePriority.AllowDrop = true;
            this.LBXDrivePriority.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBXDrivePriority.FormattingEnabled = true;
            this.LBXDrivePriority.ItemHeight = 17;
            this.LBXDrivePriority.Location = new System.Drawing.Point(24, 57);
            this.LBXDrivePriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBXDrivePriority.Name = "LBXDrivePriority";
            this.LBXDrivePriority.Size = new System.Drawing.Size(157, 174);
            this.LBXDrivePriority.TabIndex = 0;
            this.TTMain.SetToolTip(this.LBXDrivePriority, "Drag and drop drives to order (Top = Highest Priority)");
            this.LBXDrivePriority.DragDrop += new System.Windows.Forms.DragEventHandler(this.LBXDrivePriority_DragDrop);
            this.LBXDrivePriority.DragOver += new System.Windows.Forms.DragEventHandler(this.LBXDrivePriority_DragOver);
            this.LBXDrivePriority.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBXDrivePriority_MouseDown);
            // 
            // BTNScanSystem
            // 
            this.BTNScanSystem.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.BTNScanSystem.Location = new System.Drawing.Point(891, 17);
            this.BTNScanSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNScanSystem.Name = "BTNScanSystem";
            this.BTNScanSystem.Size = new System.Drawing.Size(108, 39);
            this.BTNScanSystem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.BTNScanSystem.TabIndex = 5;
            this.BTNScanSystem.Text = "Scan System";
            this.TTMain.SetToolTip(this.BTNScanSystem, "Scans, Loads, Updates, and Saves all Root Drives");
            this.BTNScanSystem.UseSelectable = true;
            this.BTNScanSystem.Click += new System.EventHandler(this.BTNScanSystem_Click);
            // 
            // PGBarScanSystem
            // 
            this.PGBarScanSystem.Location = new System.Drawing.Point(891, 63);
            this.PGBarScanSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PGBarScanSystem.Name = "PGBarScanSystem";
            this.PGBarScanSystem.Size = new System.Drawing.Size(108, 23);
            this.PGBarScanSystem.Style = MetroFramework.MetroColorStyle.Magenta;
            this.PGBarScanSystem.TabIndex = 7;
            this.TTMain.SetToolTip(this.PGBarScanSystem, "Loading In Progress. May take a few seconds");
            this.PGBarScanSystem.Visible = false;
            // 
            // LBLProgress
            // 
            this.LBLProgress.AutoSize = true;
            this.LBLProgress.Location = new System.Drawing.Point(801, 63);
            this.LBLProgress.Name = "LBLProgress";
            this.LBLProgress.Size = new System.Drawing.Size(66, 20);
            this.LBLProgress.TabIndex = 8;
            this.LBLProgress.Text = "Progress:";
            this.LBLProgress.Visible = false;
            // 
            // LBLUploadProgress
            // 
            this.LBLUploadProgress.AutoSize = true;
            this.LBLUploadProgress.Location = new System.Drawing.Point(644, 14);
            this.LBLUploadProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLUploadProgress.Name = "LBLUploadProgress";
            this.LBLUploadProgress.Size = new System.Drawing.Size(0, 0);
            this.LBLUploadProgress.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::BrainologyDatabaseManager.Properties.Resources.MarketingBrainologyLogoWebsiteNewS;
            this.pictureBox1.Location = new System.Drawing.Point(488, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 85);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LBLFormClosing
            // 
            this.LBLFormClosing.AutoSize = true;
            this.LBLFormClosing.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LBLFormClosing.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LBLFormClosing.Location = new System.Drawing.Point(1043, 17);
            this.LBLFormClosing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFormClosing.Name = "LBLFormClosing";
            this.LBLFormClosing.Size = new System.Drawing.Size(177, 25);
            this.LBLFormClosing.TabIndex = 11;
            this.LBLFormClosing.Text = "Program Closing...";
            this.LBLFormClosing.Visible = false;
            // 
            // TTMain
            // 
            this.TTMain.AutoPopDelay = 10000;
            this.TTMain.InitialDelay = 500;
            this.TTMain.ReshowDelay = 100;
            this.TTMain.Style = MetroFramework.MetroColorStyle.Blue;
            this.TTMain.StyleManager = null;
            this.TTMain.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // LBLUserLog
            // 
            this.LBLUserLog.AutoSize = true;
            this.LBLUserLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBLUserLog.Location = new System.Drawing.Point(20, 864);
            this.LBLUserLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLUserLog.Name = "LBLUserLog";
            this.LBLUserLog.Size = new System.Drawing.Size(0, 0);
            this.LBLUserLog.TabIndex = 12;
            this.LBLUserLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBLProgressSpinner
            // 
            this.LBLProgressSpinner.AutoSize = true;
            this.LBLProgressSpinner.Enabled = false;
            this.LBLProgressSpinner.Location = new System.Drawing.Point(1152, 119);
            this.LBLProgressSpinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLProgressSpinner.Name = "LBLProgressSpinner";
            this.LBLProgressSpinner.Size = new System.Drawing.Size(67, 20);
            this.LBLProgressSpinner.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLProgressSpinner.TabIndex = 18;
            this.LBLProgressSpinner.Text = "Loading...";
            this.LBLProgressSpinner.Visible = false;
            // 
            // PBXLoadingLogo
            // 
            this.PBXLoadingLogo.Image = global::BrainologyDatabaseManager.Properties.Resources.MarketingBrainologyLogo;
            this.PBXLoadingLogo.InitialImage = global::BrainologyDatabaseManager.Properties.Resources.MarketingBrainologyLogo;
            this.PBXLoadingLogo.Location = new System.Drawing.Point(1152, 17);
            this.PBXLoadingLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PBXLoadingLogo.Name = "PBXLoadingLogo";
            this.PBXLoadingLogo.Size = new System.Drawing.Size(107, 98);
            this.PBXLoadingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXLoadingLogo.TabIndex = 19;
            this.PBXLoadingLogo.TabStop = false;
            this.PBXLoadingLogo.Visible = false;
            // 
            // LBLVersionNumber
            // 
            this.LBLVersionNumber.AutoSize = true;
            this.LBLVersionNumber.Location = new System.Drawing.Point(23, 74);
            this.LBLVersionNumber.Name = "LBLVersionNumber";
            this.LBLVersionNumber.Size = new System.Drawing.Size(0, 0);
            this.LBLVersionNumber.TabIndex = 20;
            // 
            // FRMMBDatabase
            // 
            this.AcceptButton = this.BTNSearch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1359, 884);
            this.Controls.Add(this.LBLVersionNumber);
            this.Controls.Add(this.PBXLoadingLogo);
            this.Controls.Add(this.LBLProgressSpinner);
            this.Controls.Add(this.LBLUserLog);
            this.Controls.Add(this.LBLFormClosing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBLUploadProgress);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMMBDatabase_FormClosing);
            this.Load += new System.EventHandler(this.FRMMBDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMMBDatabase_KeyDown);
            this.MTABWindowSelector.ResumeLayout(false);
            this.TPWelcome.ResumeLayout(false);
            this.TPWelcome.PerformLayout();
            this.PNLGithub.ResumeLayout(false);
            this.PNLGithub.PerformLayout();
            this.PNLUserGuide.ResumeLayout(false);
            this.PNLUserGuide.PerformLayout();
            this.TPSearchManager.ResumeLayout(false);
            this.TPSearchManager.PerformLayout();
            this.PNLTags.ResumeLayout(false);
            this.PNLTags.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXLoadingLogo)).EndInit();
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
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BTNApplyTags;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel LBLTagWizardCreate;
        private MetroFramework.Controls.MetroButton BTNTagCreate;
        private MetroFramework.Controls.MetroTextBox TXTTagWizardName;
        private MetroFramework.Controls.MetroLabel LBLTagPresetWizard;
        private MetroFramework.Controls.MetroButton BTNTagPresetAdd;
        private MetroFramework.Controls.MetroButton BTNApplyTagPreset;
        private System.Windows.Forms.ListBox LBXTagPresets;
        private MetroFramework.Controls.MetroButton BTNTagPresetRemove;
        private MetroFramework.Controls.MetroButton BTNNewTagPreset;
        private MetroFramework.Controls.MetroLabel LBLNewPresetName;
        private MetroFramework.Controls.MetroTextBox TXTTagPresetName;
        private MetroFramework.Controls.MetroButton BTNRemoveAllTags;
        private MetroFramework.Controls.MetroButton BTNClearSelectedTags;
        private MetroFramework.Controls.MetroButton BTNRemoveSelectedTags;
        private MetroFramework.Controls.MetroButton BTNDeleteTag;
        private MetroFramework.Controls.MetroLabel LBLFormClosing;
        private MetroFramework.Components.MetroToolTip TTMain;
        private MetroFramework.Controls.MetroCheckBox CBXConsolidateResults;
        private MetroFramework.Controls.MetroCheckBox CBXSaveToExcel;
        private MetroFramework.Controls.MetroLabel LBLMegaBytes;
        private MetroFramework.Controls.MetroLabel LBLMinimunSize;
        private MetroFramework.Controls.MetroTextBox TXTMinimumSize;
        private MetroFramework.Controls.MetroLabel LBLUserGuide;
        private MetroFramework.Controls.MetroPanel PNLUserGuide;
        private MetroFramework.Controls.MetroPanel PNLGithub;
        private MetroFramework.Controls.MetroLabel LBLGitHub;
        private System.Windows.Forms.LinkLabel LNKGithub;
        private System.Windows.Forms.LinkLabel LNKUserGuide;
        private MetroFramework.Controls.MetroLabel LBLUserLog;
        private MetroFramework.Controls.MetroButton BTNShowTag;
        private System.Windows.Forms.Panel PNLTags;
        private MetroFramework.Controls.MetroLabel LBLProgressSpinner;
        private System.Windows.Forms.PictureBox PBXLoadingLogo;
        private MetroFramework.Controls.MetroButton BTNShowSubs;
        private MetroFramework.Controls.MetroLabel LBLVersionNumber;
    }
}