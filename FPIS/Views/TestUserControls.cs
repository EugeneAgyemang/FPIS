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
    public partial class TestUserControls : Form
    {
        public TestUserControls()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Wipe the main panel so we add just what the user needs to see
            MainPanelControl.Controls.Clear();

            // then
            UserControlB instance = new UserControlB();
            MainPanelControl.Controls.Add(instance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Would fail
            // UserControlA instance = new UserControlA();

            // Wipe the main panel so we add just what the user needs to see
            MainPanelControl.Controls.Clear();

            // then
            //UserControlAddFinishedProduct instance = UserControlAddFinishedProduct.Instance;
            //MainPanelControl.Controls.Add(instance);
            // Or MainPanelControl.Controls.Add(UserControlA.Instance);
        }
    }
}
