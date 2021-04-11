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
        Timer timer;
        FRMMBDatabase MainForm;
        public FRMDebug(FRMMBDatabase MainForm)
        {
            this.MainForm = MainForm;
            InitializeComponent();
        }

        private void FRMDebug_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += new EventHandler(TimerEvent);
            DisplayDebugMessages();
            timer.Interval = 1000;
            timer.Start();
        }

        private void TimerEvent(object myObject,EventArgs myEventArgs)
        {
            // Timer ticked, try to grab new Messages
            DisplayDebugMessages();
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

        private void FRMDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            MainForm.DebugFormShowing = false;
        }
    }
}
