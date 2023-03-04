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
        int[] panelHeights = new int[7];
        int indexOfNavigationButtonClicked = -1;
        public Main()
        {
            InitializeComponent();
            CachePanelState();
            CollapseNavigationDrawer();
        }
        private void HamburgerControl_Click(object sender, EventArgs e)
        {
            ToggleNavigation();
        }
        public void ToggleNavigation()
        {
            int perfectSizeForHidingNavigation = 130;
            if (isNavigationOpen)
            {
                HideNavigation(perfectSizeForHidingNavigation);
                isNavigationOpen = false;
                return;
            }
            ShowNavigation(perfectSizeForHidingNavigation);
            isNavigationOpen = true;
        }
        public void HideNavigation(int perfectSizeForHidingNavigation)
        {
            NavigationDrawerControl.Width -= perfectSizeForHidingNavigation;
            foreach (Panel section in NavigationDrawerControl.Controls)
            {
                foreach (Control item in section.Controls)
                {
                    Button navigationButton = (Button)item;
                    string value = item.Text;
                    navigationButton.Text = string.Empty;
                    navigationButton.Width -= perfectSizeForHidingNavigation;
                    navigationButtonsContents.Append(value);
                    navigationButtonsContents.Append(',');
                    if (navigationButton.Image == null)
                    {
                        navigationButton.Visible = false;
                    }
                }
            }
        }
        public void ShowNavigation(int perfectSizeForHidingNavigation)
        {
            NavigationDrawerControl.Width += perfectSizeForHidingNavigation;
            int navigationButtonContentIndex = 0;
            string[] contents = navigationButtonsContents.ToString().Split(",");
            foreach (Panel section in NavigationDrawerControl.Controls)
            {
                foreach (Control item in section.Controls)
                {
                    Button navigationButton = (Button)item;
                    string navigationButtonContent = contents[navigationButtonContentIndex];
                    navigationButton.Text = navigationButtonContent;
                    navigationButton.Width += perfectSizeForHidingNavigation;
                    navigationButtonsContents.Remove(0, navigationButtonContent.Length + 1);
                    navigationButtonContentIndex++;
                    if (!navigationButton.Visible)
                    {
                        navigationButton.Visible = true;
                    }
                }
            }
        }
        private void CollapseNavigationDrawer()
        {
            foreach (Panel panel in NavigationDrawerControl.Controls)
            {
                // Hide sub menu buttons
                panel.Height = 50;
                // Find the initial panel's start position
                int top = 1;
                // Find the position for the panel. Every panel's position is stored as it's tag#: 0, 1 and so on
                int tag = int.Parse((string)panel.Tag);
                // Add extra line of spacing between panels
                top = top * tag + 1;
                // Find y-axis for the panel. Tag # is simply it's position away from the top. Ergo Tag#0 -> 1, Tag#1 -> 51
                int panelYAxis = (tag * panel.Height) + top;
                panel.Location = new Point(6, panelYAxis);

            }
        }
        private void ShowNavigationSubmenu(object sender, EventArgs e)
        {
            // Don't expand when the navigation is hidden
            if (!isNavigationOpen)
                return;
            CollapseNavigationDrawer();
            Button navigationButton = (Button)sender;
            // Obtain the parent's position using the tag# of the parent panel
            int tag = int.Parse((string)navigationButton.Parent.Tag);
            if (indexOfNavigationButtonClicked == tag)
            {
                indexOfNavigationButtonClicked = -1;
                return;
            }

            indexOfNavigationButtonClicked = tag;
            foreach (Panel panel in NavigationDrawerControl.Controls)
            {
                int currentPanelTag = int.Parse((string)panel.Tag);
                if (tag == currentPanelTag)
                {
                    panel.Height = panelHeights[tag];
                    break;
                }
            }
            RepositionNavigation(tag);
        }
        private void RepositionNavigation(int previousTag)
        {
            foreach (Panel panel in NavigationDrawerControl.Controls)
            {
                int currentTag = int.Parse((string)panel.Tag);
                if (currentTag <= previousTag)
                    continue;

                int top = panelHeights[previousTag];
                int tag = int.Parse((string)panel.Tag) - 1;
                //if (tag > 0)
                top = (50 * tag + top) + 1;
                int panelYAxis = top;
                panel.Location = new Point(6, panelYAxis);
            }
        }
        private void CachePanelState()
        {
            foreach (Panel panel in NavigationDrawerControl.Controls)
            {
                // The index for each panel
                int tag = int.Parse((string)panel.Tag);
                panelHeights[tag] = panel.Height;
            }
        }
        private void CloseWindowControl_Click(object sender, EventArgs e)
        {
            DialogResult userWantsToCloseForm =
                MessageBox.Show("Do you wish to close the application?",
                "Confirm Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (userWantsToCloseForm == DialogResult.Yes)
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
