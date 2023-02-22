using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class Main : Form
    {
        bool isNavigationOpen = true;
        StringBuilder navigationButtonsContents = new StringBuilder();
        public Main()
        {
            InitializeComponent();
        }

        private void CloseWindowControl_Click(object sender, EventArgs e)
        {
            DialogResult userWantsToCloseForm = 
                MessageBox.Show("Do you wish to close the application?", 
                "Confirm Close", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if(userWantsToCloseForm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizeWindowControl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
