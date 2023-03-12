using FPIS.Models;
using FPIS.Services;
using System.ComponentModel;
using System.Data;

namespace FPIS.Views
{
    public partial class CreateAnalysisRequestFormUserControl : UserControl
    {
        private readonly UserService _userService;
        private readonly AnalysisService _analysisService;

        public static string analysisType = "";
        public static BindingList<AnalysisSampleBindingItem> analysisItemList = new();

        private class UserForDropDown
        {
            public Guid Id { get; set; }
            public string Name { get; set; }

            public string EmpID { get; set; }
        }

        public CreateAnalysisRequestFormUserControl()
        {
            InitializeComponent();

            labelAnalysisRequestTitle.Text = $"New {analysisType} Analysis Request";

            dataGridView1.DataSource = analysisItemList;

            AppDbContext context = new();
            _analysisService = new(context);
            _userService = new(context);

            LoadProductionEngineer1();
            LoadEmployee2();
        }

        private void LoadProductionEngineer1()
        {
            User? user = _userService.GetUserById(Main.LOGGED_USER_ID);

            if (user != null)
            {
                UserForDropDown userForDropDown = new()
                {
                    Id = user.Id,
                    EmpID = user.EmpID,
                    Name = $"{user.FirstName} {user.MiddleName} {user.LastName}"
                };

                List<UserForDropDown> engineerOne = new();
                engineerOne.Add(userForDropDown);

                materialComboBoxEmployee1.DataSource = engineerOne;
                materialComboBoxEmployee1.DisplayMember = "Name";
            }
        }

        private void LoadEmployee2()
        {
            materialComboBoxEmployee2.DataSource = _userService.GetAllUsersWithoutId(new Guid(Main.LOGGED_USER_ID))
                .Select(u => new UserForDropDown()
                {
                    Id = u.Id,
                    EmpID = u.EmpID,
                    Name = $"{u.FirstName} {u.MiddleName} {u.LastName}"
                })
                .ToList();

            materialComboBoxEmployee2.DisplayMember = "Name";
        }

        private void materialButtonAddSample_Click(object sender, EventArgs e)
        {
            AddAnalysisSampleForm addAnalysisSampleForm = new()
            {
                AnalysisType = analysisType
            };
            addAnalysisSampleForm.ShowDialog();
        }

        private void materialButtonRequestAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                UserForDropDown? employee1 = materialComboBoxEmployee1.SelectedItem as UserForDropDown;
                UserForDropDown? employee2 = materialComboBoxEmployee2.SelectedItem as UserForDropDown;

                if (employee1 == null || employee2 == null)
                {
                    Utils.Utils.ShowMessageBox(
                        $"Please ensure that Employee 1 and Employee 2 are selected before you continue.",
                        "Select Employees",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                    return;
                }

                if (employee1.Id.Equals(employee2.Id))
                {
                    Utils.Utils.ShowMessageBox(
                        $"Employee 1 and Employee 2 cannot be the same person ({employee1.Name})!",
                        "Equal Employees",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                    return;
                }

                if (analysisItemList.Count == 0)
                {
                    Utils.Utils.ShowMessageBox(
                        $"Please add a sample for the analysis.",
                        "Invalid Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                    return;
                }

                DialogResult confirmDialogResult = Utils.Utils.ShowMessageBox(
                    "Are you sure you want to create this analysis request?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmDialogResult != DialogResult.Yes)
                {
                    return;
                }

                materialButtonAddSample.Enabled = false;
                materialButtonRequestAnalysis.Enabled = false;

                _analysisService.CreateSample(
                    new Guid(Main.LOGGED_USER_ID),
                    employee1.EmpID,
                    employee2.EmpID,
                    DateOnly.FromDateTime(DateTime.UtcNow.Date),
                    TimeOnly.FromDateTime(DateTime.UtcNow),
                    analysisType,
                    analysisItemList.ToList()
                );

                analysisItemList.Clear();

                materialButtonAddSample.Enabled = true;
                materialButtonRequestAnalysis.Enabled = true;

                Utils.Utils.ShowMessageBox(
                    "Successfully sent analysis request. You can send a new request if you want?",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                Utils.Utils.ShowMessageBox(
                    $"We were unable to create the Analysis Request. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
