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
    public partial class UserControlA : UserControl
    {
        static UserControlA instance;
        private UserControlA()
        {
            InitializeComponent();
        }

        public static UserControlA Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UserControlA();
                }
                return instance;
            }
        }

        private void ActionButtonControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TypeSomethingControl.Text, "The Right Pattern Right?", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
