
namespace BrainologyDatabaseManager
{
    partial class FRMDebug
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
            this.BTNClearDebug = new MetroFramework.Controls.MetroButton();
            this.LBXDebugLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNClearDebug
            // 
            this.BTNClearDebug.Location = new System.Drawing.Point(256, 28);
            this.BTNClearDebug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNClearDebug.Name = "BTNClearDebug";
            this.BTNClearDebug.Size = new System.Drawing.Size(100, 31);
            this.BTNClearDebug.TabIndex = 3;
            this.BTNClearDebug.Text = "Clear";
            this.BTNClearDebug.UseSelectable = true;
            this.BTNClearDebug.Click += new System.EventHandler(this.BTNClearDebug_Click);
            // 
            // LBXDebugLog
            // 
            this.LBXDebugLog.FormattingEnabled = true;
            this.LBXDebugLog.ItemHeight = 16;
            this.LBXDebugLog.Location = new System.Drawing.Point(16, 66);
            this.LBXDebugLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBXDebugLog.Name = "LBXDebugLog";
            this.LBXDebugLog.ScrollAlwaysVisible = true;
            this.LBXDebugLog.Size = new System.Drawing.Size(1033, 468);
            this.LBXDebugLog.TabIndex = 2;
            // 
            // FRMDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BTNClearDebug);
            this.Controls.Add(this.LBXDebugLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMDebug";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Debug Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMDebug_FormClosing);
            this.Load += new System.EventHandler(this.FRMDebug_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTNClearDebug;
        private System.Windows.Forms.ListBox LBXDebugLog;
    }
}