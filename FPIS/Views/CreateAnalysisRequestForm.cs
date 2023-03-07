using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FPIS.Views
{
    public partial class CreateAnalysisRequestForm : Form
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

        public CreateAnalysisRequestForm()
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(analysisType))
            {
                SelectAnalysisTypeForm selectAnalysisTypeForm = new();
                DialogResult result = selectAnalysisTypeForm.ShowDialog();

                if (analysisType.Equals(""))
                {
                    Close();
                }

                Text = $"New {analysisType} Analysis";
            }

            AppDbContext context = new();

            dataGridView1.DataSource = analysisItemList;
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

                DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                    "Successfully sent analysis request. Do you want to send a new request?",
                    "Success",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (dialogResult != DialogResult.Yes)
                {
                    Close();
                }

                analysisItemList.Clear();
                materialComboBoxEmployee1.SelectedItem = null;
                materialComboBoxEmployee2.SelectedItem = null;

                materialButtonAddSample.Enabled = true;
                materialButtonRequestAnalysis.Enabled = true;
            } catch (Exception ex)
            {
                Utils.Utils.ShowMessageBox(
                    $"We were unable to create the Analysis Request. Please try again.{ex}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
