using FPIS.Services;
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
        const int PERFECTSIZEFORHIDINGNAVIGATION = 130;
        bool isNavigationOpen = true;
        StringBuilder navigationButtonsContents = new StringBuilder();
        int[] panelHeights = new int[8];
        int indexOfNavigationButtonClicked = -1;

        public static string LOGGED_USER_ID = "ba491ba1-1f50-462d-965d-cd568472bcf1";

        public Main()
        {
            InitializeComponent();
            CachePanelState();
            CollapseNavigationDrawer();
        }
        private void HamburgerControl_Click(object sender, EventArgs e)
        {
            CollapseNavigationDrawer();
            ToggleNavigation();
        }
        public void ToggleNavigation()
        {
            if (isNavigationOpen)
            {
                indexOfNavigationButtonClicked = -1;
                HideNavigation(PERFECTSIZEFORHIDINGNAVIGATION);
                isNavigationOpen = false;
                return;
            }
            ShowNavigation(PERFECTSIZEFORHIDINGNAVIGATION);
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
                if (section.Tag == "-1")
                    continue;
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
            foreach (Control panel in NavigationDrawerControl.Controls)
            {
                if (!(panel is Panel))
                    continue;
                // Find the initial panel's start position
                int top = 1;
                // Find the position for the panel. Every panel's position is stored as it's tag#: 0, 1 and so on
                int tag = GetTag(panel);
                if(tag == -1)
                {
                    continue;
                }
                // Hide sub menu buttons
                panel.Height = 50;
                // Add extra line of spacing between panels
                top = (top * tag) + 1;
                // Find y-axis for the panel. Tag # is simply it's position away from the top. Ergo Tag#0 -> 1, Tag#1 -> 51
                int panelYAxis = (tag * panel.Height) + top;
                panel.Location = new Point(6, panelYAxis);

            }
        }
        private void ShowNavigationSubmenu(object sender, EventArgs e)
        {
            // Don't expand when the navigation is hidden
            if (!isNavigationOpen)
            {
                ToggleNavigation();
            }
            CollapseNavigationDrawer();
            Button navigationButton = (Button)sender;
            // Obtain the parent's position using the tag# of the parent panel
            int tag = int.Parse((string)navigationButton.Parent.Tag);
            RepositionNavigationIndicator(tag);
            if (tag == 0)
                return;
            if (indexOfNavigationButtonClicked == tag)
            {
                indexOfNavigationButtonClicked = -1;
                return;
            }

            indexOfNavigationButtonClicked = tag;
            foreach (Control panel in NavigationDrawerControl.Controls)
            {
                if (!(panel is Panel))
                    continue;
                int currentPanelTag = GetTag(panel);
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
            foreach (Control panel in NavigationDrawerControl.Controls)
            {
                if (!(panel is Panel))
                    continue;
                int currentTag = int.Parse((string)panel.Tag);
                if (currentTag <= previousTag)
                    continue;

                int top = panelHeights[previousTag];
                int tag = GetTag(panel) - 1;
                if(tag == -1)
                {
                    continue;
                }
                top = (50 * tag + top) + 1;
                int panelYAxis = top;
                panel.Location = new Point(6, panelYAxis);
            }
        }
        private void RepositionNavigationIndicator(int navigationMenuClicked)
        {
            int yAxis = (navigationMenuClicked * 50) + 11;
            NavigationIndicatorControl.Location = new Point(3, yAxis);
        }
        private void ResetNavigationIndicator()
        {
            NavigationIndicatorControl.Location = new Point(-10, 11);
        }
        private void CachePanelState()
        {
            foreach (Control panel in NavigationDrawerControl.Controls)
            {
                if (!(panel is Panel))
                    continue;
                int tag = GetTag(panel);
                if (tag == -1)
                {
                    continue;
                }
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
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// Retrieve meta data for a panel via it's tag attribute.
        /// </summary>
        /// <param name="panel">The specified panel whose meta data needs to be retrieved</param>
        /// <returns>The tag number for the specified panel</returns>
        private int GetTag(Control panel)
        {
            // The index for each panel
            int tag = int.Parse((string)panel.Tag);
            return tag;
        }

        private void MinimizeWindowControl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void ProductionSection_AddSampleControl_Click(object sender, EventArgs e)
        {
            SelectAnalysisTypeForm selectAnalysisTypeForm = new();
            DialogResult dialogResult = selectAnalysisTypeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AddUserControlToMainContainerControl(new CreateAnalysisRequestFormUserControl());
            }
        }

        private void ProcurementSection_ReceiveMaterialsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(ProcurementReceiveMaterialsUserControl.Instance);
        }
        /// <summary>
        /// Add the given user control to the MainContainerControl
        /// </summary>
        /// <param name="userControl">An instance of the user control to be added. Instance has to be static.</param>
        private void AddUserControlToMainContainerControl(UserControl userControl)
        {
            ClearControlsFromMainContainerControl();
            MainContainerControl.Controls.Add(userControl);
        }
        private void ClearControlsFromMainContainerControl()
        {
            MainContainerControl.Controls.Clear();
        }

        private void ProcurementSection_IssueMaterialsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(ProcurementIssueMaterials.Instance);
        }
        private void ConsumbalesSection_AddIssuedStockControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new userControlIssueStock());
        }
        private void ConsumbalesSection_ReceiveNewStockControl_Click(object sender, EventArgs e)
        {
            ReceiveStock receive_Stock = new ReceiveStock();
            receive_Stock.Show();
        }

        private void ProcurementSection_ViewRequestsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(ProcurementViewRequestsUserControl.Instance);
        }
    }
}
