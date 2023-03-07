using FPIS.Models;
using FPIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FPIS.Views
{
    public partial class CreateAnalysisRequestForm : Form
    {
        private Guid employee1Id;
        private Guid employee2Id;
        private UserService _userService;
        private AnalysisService _analysisService;

        public static string analysisType = "";
        public static string selecteds = "";
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

                if (result == DialogResult.Cancel)
                {
                    // this.Close();
                }
                this.Text = $"New {analysisType} Analysis";
            }

            AppDbContext context = new();

            dataGridView1.DataSource = analysisItemList;
            _analysisService = new(context);
            _userService = new(context);

            LoadEmployee1();
            LoadEmployee2();
        }

        private void LoadEmployee1() 
        {
            materialComboBoxEmployee1.DataSource = _userService.GetAllUsers()
                .Select(u => new UserForDropDown() {
                    Id = u.Id, Name = $"{u.FirstName} {u.MiddleName} {u.LastName}"
                })
                .ToList();
            materialComboBoxEmployee1.DisplayMember = "Name";
        }

        private void LoadEmployee2()
        {
            materialComboBoxEmployee2.DataSource = _userService.GetAllUsers()
                .Select(u => new UserForDropDown()
                {
                    Id = u.Id,
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
            addAnalysisSampleForm.Show();
        }

        private void materialButtonRequestAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                UserForDropDown employee1 = materialComboBoxEmployee1.SelectedItem as UserForDropDown;
                UserForDropDown employee2 = materialComboBoxEmployee2.SelectedItem as UserForDropDown;

                if (employee1.Id.Equals(employee2.Id))
                {
                    Utils.Utils.ShowMessageBox(
                        "Employee 1 and Employee2 cannot be the same person!",
                        "Invalid Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return;
                }

                _analysisService.CreateSample(
                    new Guid("c6cfd03d-b708-434a-aa01-b9089bd0d027"),
                    employee1.EmpID,
                    employee2.EmpID,
                    DateOnly.FromDateTime(DateTime.UtcNow.Date),
                    TimeOnly.FromDateTime(DateTime.UtcNow),
                    analysisType,
                    analysisItemList.ToList()
                );

                Utils.Utils.ShowMessageBox("Successfully created a sample", "Success");
            } catch (Exception ex)
            {
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error");
            }
        }
    }
}
