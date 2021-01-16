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
    public partial class FRMDebug : MetroFramework.Forms.MetroForm
    {

        FRMMBDatabase MainForm;
        public FRMDebug(FRMMBDatabase MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        private void DisplayDebugMessages()
        {
            foreach (string message in DataManager.DebugMessages)
            {
                LBXDebugLog.Items.Add(message);
            }
            DataManager.DebugMessages.Clear();
        }

        private void BTNClearDebug_Click(object sender, EventArgs e)
        {
            DeleteDebugMessages();
        }

        private void DeleteDebugMessages()
        {
            LBXDebugLog.Items.Clear();
        }

        private void FRMDebug_Enter(object sender, EventArgs e)
        {
            DisplayDebugMessages();
        }

        private void FRMDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.DebugFormShowing = false;
        }

        private void FRMDebug_MouseEnter(object sender, EventArgs e)
        {
            DisplayDebugMessages();
        }
    }
}
