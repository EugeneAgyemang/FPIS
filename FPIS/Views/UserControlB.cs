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
    public partial class UserControlB : UserControl
    {
        public UserControlB()
        {
            InitializeComponent();
        }

        private void ActionButtonControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TypeSomethingControl.Text, "The Wrong Pattern Right?", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
