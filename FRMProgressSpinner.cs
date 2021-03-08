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
    public partial class FRMProgressSpinner : MetroFramework.Forms.MetroForm
    {
        public FRMProgressSpinner()
        {
            InitializeComponent();
        }

        private void FRMProgressSpinner_Load(object sender, EventArgs e)
        {
            LoadProgressSpinner(false);
        }

        private int LoadingCounter = 0;

        public void LoadProgressSpinner(bool enable, string message = "Loading...")
        {


            // Adds 1 to the counter if enabled, subtracts 1 if not
            if (enable)
            {
                LoadingCounter++;
            }
            else
            {
                LoadingCounter--;
            }

            // Always can change the text
            LBLProgressSpinner.Text = message;
            // If some method is still loading, keep the spinner running
            // Prevents the stopping and starting of the spinner
            if (!enable && LoadingCounter > 0)
                return;
            
            ProgressSpinner.Spinning = enable;
            this.Enabled = enable;
            this.Visible = enable;

        }

       
    }
}
