using BrainologyDatabaseManager.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainologyDatabaseManager
{
    public partial class FRMLoadingPanel : MetroFramework.Forms.MetroForm
    {
        public FRMLoadingPanel()
        {
            InitializeComponent();
            this.Icon = BrainologyDatabaseManager.Properties.Resources.marketingbrainologylogo_icon;
        }

        DriveDB db;

        public void LoadMainForm()
        {
            Console.WriteLine("Loading Main Form");
            this.Hide();
            FRMMBDatabase MainForm = new FRMMBDatabase(db);

            MainForm.ShowDialog();
            this.Close();
            
        }

        private void FRMLoadingPanel_Load(object sender, EventArgs e)
        {
            DataManager.versionNumber = ProductVersion;
            db = new DriveDB(this);
        }
    }

}
