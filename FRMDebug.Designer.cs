
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
            this.BTNClearDebug.Location = new System.Drawing.Point(192, 23);
            this.BTNClearDebug.Name = "BTNClearDebug";
            this.BTNClearDebug.Size = new System.Drawing.Size(75, 25);
            this.BTNClearDebug.TabIndex = 3;
            this.BTNClearDebug.Text = "Clear";
            this.BTNClearDebug.UseSelectable = true;
            this.BTNClearDebug.Click += new System.EventHandler(this.BTNClearDebug_Click);
            // 
            // LBXDebugLog
            // 
            this.LBXDebugLog.FormattingEnabled = true;
            this.LBXDebugLog.Location = new System.Drawing.Point(12, 54);
            this.LBXDebugLog.Name = "LBXDebugLog";
            this.LBXDebugLog.ScrollAlwaysVisible = true;
            this.LBXDebugLog.Size = new System.Drawing.Size(776, 381);
            this.LBXDebugLog.TabIndex = 2;
            // 
            // FRMDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNClearDebug);
            this.Controls.Add(this.LBXDebugLog);
            this.Name = "FRMDebug";
            this.Text = "Debug Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMDebug_FormClosing);
            this.Enter += new System.EventHandler(this.FRMDebug_Enter);
            this.MouseEnter += new System.EventHandler(this.FRMDebug_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTNClearDebug;
        private System.Windows.Forms.ListBox LBXDebugLog;
    }
}