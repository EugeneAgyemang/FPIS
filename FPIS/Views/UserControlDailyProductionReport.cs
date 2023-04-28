using FPIS.Models;
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
    public partial class UserControlDailyProductionReport : UserControl
    {
        public bool _isDataValid = true;
        private readonly UserService _userService;

        private class UserForReport
        {
            public Guid Id { get; set; }
            public string Name { get; set; }

            public string EmpID { get; set; }
        }


        public UserControlDailyProductionReport()
        {
            InitializeComponent();
            labelDailyProductionReportError.ForeColor = System.Drawing.Color.Red;

            labelDailyProductionReportError.Text = "";
        }

        public void ClearErrorLabels()
        {
            labelDailyProductionReportError.Text = "";
        }

        public void ClearFormFields()
        {
            textBoxDailyProductionReport.Text = "";
        }

        public void ValidateDailyProductionReport(string report)
        {
            if (report.Length == 0)
            {
                labelDailyProductionReportError.Text = "Production Report is required!";
                _isDataValid = false;
                return;
            }

        }

        private void LoadUser()
        {
            User? user = _userService.GetUserById(Main.LOGGED_USER_ID);

            if (user != null)
            {
                UserForReport userForReport = new()
                {
                    Id = user.Id,
                    EmpID = user.EmpID,
                    Name = $"{user.FirstName} {user.MiddleName} {user.LastName}"
                };

                List<UserForReport> productionEngineer = new();
                productionEngineer.Add(userForReport);

                //materialComboBoxEmployee1.DataSource = engineerOne;
                //materialComboBoxEmployee1.DisplayMember = "Name";
            }
        }

        public void AddDailyProductionReport()
        {
            //DateOnly.FromDateTime(DateTime.UtcNow.Date),
            //TimeOnly.FromDateTime(DateTime.UtcNow)

            ClearErrorLabels();
            DialogResult dialogResult = MessageBox.Show(
                $"Do you want to check In?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                materialButtonAddReport.Enabled = false;
                AppDbContext dbContext = new();
                try
                {
                    DailyProductionReportService dailyProductionReportService = new(dbContext);
                    //dailyProductionReportService.AddDailyProductionReport();

                    MessageBox.Show(
                        $"Checked In successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to issue Stock Item. Please try again." + ex,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                finally
                {
                    dbContext.Dispose();
                    materialButtonAddReport.Enabled = true;
                }
            }
        }
    }
}
