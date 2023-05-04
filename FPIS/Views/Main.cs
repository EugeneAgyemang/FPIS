using FPIS.Services;
using MaterialSkin.Controls;
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
        int[] panelHeights = new int[9];
        int indexOfNavigationButtonClicked = -1;
        Login login;

        public static string LOGGED_USER_ID;

        public Main(Login login)
        {
            this.login = login;
            InitializeComponent();
            LoadUIForUserRole(login.userRole);
            ResetNavigationItemTags(login.userRole);
            CachePanelState();
            CollapseNavigationDrawer();
            LoadUsername();
        }
        private void LoadUsername()
        {
            TitleBarCaptionControl.Text += new UserService(new()).GetFullName(Guid.Parse(LOGGED_USER_ID));
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
                    if (navigationButton.TabIndex == 0)
                    {
                        navigationButton.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        navigationButton.ImageAlign = ContentAlignment.MiddleRight;
                    }
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
                    if (navigationButton.TabIndex == 0)
                    {
                        navigationButton.ImageAlign = ContentAlignment.MiddleLeft;
                    }
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
            {
                MainContainerControl.Controls.Clear();
                MainContainerControl.Controls.Add(new UserControlDashboard());
                return;
            }
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
            int yAxis = (navigationMenuClicked * 50) + 11 + navigationMenuClicked;
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
                AddUserControlToMainContainerControl(new CreateAnalysisRequestFormUserControl(), (Button)sender);
            }
        }

        private void ProcurementSection_ReceiveMaterialsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new ProcurementReceiveMaterialsUserControl(), (Button)sender);
        }
        /// <summary>
        /// Add the given user control to the MainContainerControl
        /// </summary>
        /// <param name="userControl">An instance of the user control to be added. Instance has to be static.</param>
        private void AddUserControlToMainContainerControl(UserControl userControl,Button button)
        {
            ResetButtonsBackColor();
            button.BackColor = Color.FromArgb(126, 230, 73);
            ClearControlsFromMainContainerControl();
            MainContainerControl.Controls.Add(userControl);
        }
        /// <summary>
        /// Open the given form after clearing all open instances in the MainContainerControl
        /// </summary>
        /// <param name="form">An instance of the form to be opened</param>
        private void OpenModal(Form form, Button button)
        {
            ResetButtonsBackColor();
            button.BackColor = Color.FromArgb(126, 230, 73);
            ClearControlsFromMainContainerControl();
            form.ShowDialog();
        }
        private void ClearControlsFromMainContainerControl()
        {
            MainContainerControl.Controls.Clear();
        }

        private void ProcurementSection_IssueMaterialsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new ProcurementIssueMaterials(), (Button)sender);
        }
        private void ConsumbalesSection_AddIssuedStockControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new userControlIssueStock(), (Button)sender);
        }
        private void ConsumbalesSection_ReceiveNewStockControl_Click(object sender, EventArgs e)
        {
            OpenModal(new ReceiveStock(), (Button)sender);
        }

        private void ProcurementSection_ViewRequestsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new ViewSamplesRequestedUserControl(ViewSamplesRequestedUserControl.Source.PROCUREMENT, Utils.Form.PROCUREMENT_ISSUE), (Button)sender);
        }

        private void ProductionSection_AddProductControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateProductForm(), (Button)sender);
        }

        private void ProductionSection_CreateProductParameterControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateProductParameter(), (Button)sender);
        }

        private void ProductionSection_CreateAnalysisProductControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateAnalysisProduct(), (Button)sender);
        }

        private void ProductionSection_ViewSampleControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new ViewSamplesRequestedUserControl(ViewSamplesRequestedUserControl.Source.PRODUCTION, Utils.Form.PRODUCTION), (Button)sender);
        }

        private void LogoutControl_Click(object sender, EventArgs e)
        {
            string fullname = new UserService(new()).GetFullName(Guid.Parse(LOGGED_USER_ID));
            DialogResult userOption = Utils.Utils.ShowMessageBox($"{fullname}, do you wish to proceed with logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (userOption == DialogResult.Yes)
            {
                login.Show();
                Close();
            }
        }

        private void QualityControl_AddSampleResultControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new ViewSamplesRequestedUserControl(ViewSamplesRequestedUserControl.Source.ALL, Utils.Form.QUALITY_CONTROL), (Button)sender);
        }

        private void QualityControl_AddWaterParameterControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateWaterParameter(), (Button)sender);
        }

        private void QualityControl_AddWaterControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateWaterForm(), (Button)sender);
        }

        private void FinishedProducts_AddFinishedProductControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlAddFinishedProduct(), (Button)sender);
        }

        private void FinishedProducts_ViewCertificateOfAnalysisControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewCertificateOfAnalysis(), (Button)sender);
        }

        private void ConsumbalesSection_AddStockItemControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateStockItem(), (Button)sender);
        }

        private void ConsumbalesSection_ReceiveNewStockControl_Click_1(object sender, EventArgs e)
        {
            OpenModal(new ReceiveStock(), (Button)sender);
        }

        private void ConsumbalesSection_AddIssuedStockControl_Click_1(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new userControlIssueStock(), (Button)sender);
        }

        private void ConsumbalesSection_ViewStockItemControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewStockItems(), (Button)sender);
        }

        private void ConsumbalesSection_ViewReceivedStockControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewReceivedStocks(), (Button)sender);
        }

        private void ProductionSection_CheckAnalyticalResultsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlCheckAnalyticalResults(), (Button)sender);
        }
        
        private void LoadUIForUserRole(Login.Role userRole)
        {
            string tagsAssociatedToUser = userRole.tags.ToString();
            int numberOfNavItems = NavigationDrawerControl.Controls.Count;
            for (int panelIndex = 0; panelIndex < numberOfNavItems; panelIndex++)
            {
                string tag = (string)NavigationDrawerControl.Controls[panelIndex].Tag;
                string name = NavigationDrawerControl.Controls[panelIndex].Name;
                if (tag == "-1")
                {
                    continue;
                }
                if (!(tagsAssociatedToUser.Contains(tag)))
                {
                    NavigationDrawerControl.Controls.Remove(NavigationDrawerControl.Controls[panelIndex--]);
                    numberOfNavItems = NavigationDrawerControl.Controls.Count;
                }
            }
        }
        private void ResetNavigationItemTags(Login.Role userRole)
        {
            string tags = userRole.tags.ToString();
            List<string> tagsAsTokens = tags.Split(" ").ToList();
            tagsAsTokens.Sort();
            int newTag = 1;
            int navIndex = 0;
            int settingsIndex = 0, reportsIndex = 0;
            for (int index = 1; index < tagsAsTokens.Count; index++)
            {
                if (NavigationDrawerControl.Controls[navIndex].Tag == "-1" ||
                    NavigationDrawerControl.Controls[navIndex].Tag == "0")
                {
                    index--;
                    navIndex++;
                    continue;
                }
                if (NavigationDrawerControl.Controls[navIndex].Name == "ReportsSectionControl")
                {
                    reportsIndex = index;
                    navIndex++;
                    continue;
                }
                if (NavigationDrawerControl.Controls[navIndex].Name == "SettingsSectionControl")
                {
                    settingsIndex = index;
                    navIndex++;
                    continue;
                }

                tagsAsTokens[index] = $"{newTag}";
                NavigationDrawerControl.Controls[navIndex].Tag = tagsAsTokens[index];
                navIndex++;
                newTag++;
            }
            NavigationDrawerControl.Controls[reportsIndex].Tag = $"{newTag++}";
            NavigationDrawerControl.Controls[settingsIndex].Tag = $"{newTag}";
        }
        



        
        private void QualityControl_CreateAnalysisWaterControl_Click(object sender, EventArgs e)
        {
            OpenModal(new CreateAnalysisWater(), (Button)sender);
        }

        private void ProductionSection_AddProductionRemarkControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlDailyProductionReport(), (Button)sender);
        }

        private void ConsumbalesSection_ViewIssuedStockControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewIssuedStock(), (Button)sender);
        }

        private void QualityControl_OpenAnalysisCalculatorControl_Click(object sender, EventArgs e)
        {
            AnalysisCalculatorForm acf = new AnalysisCalculatorForm();
            acf.Show();
        }

        private void ReportsSection_OpenStockReportControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewReceivedStocks(), (Button)sender);
        }

        private void ReportsSection_OpenAnalyticalResultsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlCheckAnalyticalResults(), (Button)sender);
        }

        private void ReportsSection_OpenSampleReportControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new userControlSampleReport(), (Button)sender);
        }

        private void ReportsSection_OpenProductsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlProductReport(), (Button)sender);
        }

        private void ProductionSection_ViewProductsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlProductReport(), (Button)sender);
        }

        private void QualityControl_ViewSampleResultsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlCheckAnalyticalResults(), (Button)sender);
        }

        private void QualityControl_AddWaterAnalysisControl_Click(object sender, EventArgs e)
        {
            SelectAnalysisTypeForm selectAnalysisTypeForm = new();
            DialogResult dialogResult = selectAnalysisTypeForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                AddUserControlToMainContainerControl(new CreateAnalysisRequestFormUserControl(), (Button)sender);
            }
        }

        private void QualityControl_ViewWaterAnalysisControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new ViewSamplesRequestedUserControl(ViewSamplesRequestedUserControl.Source.ALL, Utils.Form.QUALITY_CONTROL), (Button)sender);
        }

        private void ProductionSection_ViewProductionRemarkControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewAnalysisRemarks(), (Button)sender);
        }

        private void QualityControl_ViewProductionRemarksControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewAnalysisRemarks(), (Button)sender);
        }
        
        private void QualityControl_UpdateSampleResultsControl_Click(object sender, EventArgs e)
        {
            AddUserControlToMainContainerControl(new UserControlViewSampleResults(), (Button)sender);
        }

        private void AdminPanelSection_AddUsers_Click(object sender, EventArgs e)
        {
            OpenModal(new Register(), (Button)sender);
        }

        private void AdminPanelSection_AddDepartment_Click(object sender, EventArgs e)
        {
            OpenModal(new AddDepartment(), (Button)sender);
        }

        private void AdminPanelSection_AddDesignation_Click(object sender, EventArgs e)
        {
            OpenModal(new AddDesignation(), (Button)sender);
        }

        private void ResetButtonsBackColor()
        {
            foreach (Panel panel in NavigationDrawerControl.Controls)
            {
                if (panel.Name == "SettingsSectionControl")
                {
                    continue;
                }
                foreach (Control item in panel.Controls)
                {
                    if (item is Button)
                    {
                        item.BackColor = Color.FromArgb(98, 178, 57);
                    }
                }
            }
        }
    }
}
