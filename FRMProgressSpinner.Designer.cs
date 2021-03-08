
namespace BrainologyDatabaseManager
{
    partial class FRMProgressSpinner
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
            this.LBLProgressSpinner = new MetroFramework.Controls.MetroLabel();
            this.ProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // LBLProgressSpinner
            // 
            this.LBLProgressSpinner.AutoSize = true;
            this.LBLProgressSpinner.Enabled = false;
            this.LBLProgressSpinner.Location = new System.Drawing.Point(12, 55);
            this.LBLProgressSpinner.Name = "LBLProgressSpinner";
            this.LBLProgressSpinner.Size = new System.Drawing.Size(65, 19);
            this.LBLProgressSpinner.Style = MetroFramework.MetroColorStyle.Magenta;
            this.LBLProgressSpinner.TabIndex = 16;
            this.LBLProgressSpinner.Text = "Loading...";
            // 
            // ProgressSpinner
            // 
            this.ProgressSpinner.Location = new System.Drawing.Point(23, 12);
            this.ProgressSpinner.Maximum = 100;
            this.ProgressSpinner.Name = "ProgressSpinner";
            this.ProgressSpinner.Size = new System.Drawing.Size(40, 40);
            this.ProgressSpinner.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ProgressSpinner.TabIndex = 15;
            this.ProgressSpinner.UseSelectable = true;
            this.ProgressSpinner.Value = 80;
            // 
            // FRMProgressSpinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(93, 93);
            this.Controls.Add(this.LBLProgressSpinner);
            this.Controls.Add(this.ProgressSpinner);
            this.Name = "FRMProgressSpinner";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Load += new System.EventHandler(this.FRMProgressSpinner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LBLProgressSpinner;
        private MetroFramework.Controls.MetroProgressSpinner ProgressSpinner;
    }
}