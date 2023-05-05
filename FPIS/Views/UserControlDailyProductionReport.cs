using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Reporting.Datasets;
using Reporting.ReportViews;
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


        public UserControlDailyProductionReport()
        {
            
            InitializeComponent();
            labelDailyProductionReportError.ForeColor = System.Drawing.Color.Red;

            labelDailyProductionReportError.Text = "";
            ValidateCheckIn();
            checkButtonToDisable();
            LoadDailyProductionReport();
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

        public void checkButtonToDisable()
        {
            if (materialButtonCheckIn.Enabled == false)
            {
                materialButtonCheckOut.Enabled = true;
                textBoxDailyProductionReport.Enabled = true;
            }
            else
            {
                materialButtonCheckOut.Enabled = false;
                textBoxDailyProductionReport.Enabled = false;
            }
        }
        public void ValidateCheckIn()
        {
            try
            {
                AppDbContext dbContext = new();
                var dailyProductionReport = from ProductionDailyReport in dbContext.ProductionDailyReports
                                            where ProductionDailyReport.UserId == new Guid(Main.LOGGED_USER_ID)
                                       select new
                                       {
                                           userId = ProductionDailyReport.UserId,
                                           date = ProductionDailyReport.Date
                                       };
                foreach (var items in dailyProductionReport)
                {
                    if(items.userId == new Guid(Main.LOGGED_USER_ID) && 
                        items.date == DateOnly.FromDateTime(DateTime.UtcNow.Date))
                    {
                        materialButtonCheckIn.Enabled = false;
                        materialButtonCheckOut.Enabled = true;
                        textBoxDailyProductionReport.Enabled = true;
                    }
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        public void AddDailyProductionReport_CheckIn()
        {
            ClearErrorLabels();
            DialogResult dialogResult = MessageBox.Show(
                $"Do you want to check In?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                AppDbContext dbContext = new();
                try
                {
                    DailyProductionReportService dailyProductionReportService = new(dbContext);
                    dailyProductionReportService.AddDailyProductionReport(
                        TimeOnly.FromDateTime(DateTime.UtcNow), 
                        new Guid(Main.LOGGED_USER_ID), 
                        DateOnly.FromDateTime(DateTime.UtcNow.Date));

                    MessageBox.Show(
                        $"Checked In successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
                    materialButtonCheckIn.Enabled = false;
                    materialButtonCheckOut.Enabled = true;
                    textBoxDailyProductionReport.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to check In. Please try again." + ex,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                finally
                {
                    dbContext.Dispose();
                }
            }
        }

        private void AddDailyProductionReport_CheckOut()
        {
            string report = textBoxDailyProductionReport.Text;
            ClearErrorLabels();
            ValidateDailyProductionReport(report);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            AppDbContext dbContext = new();
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                $"Do you want to check Out?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    var dailyProdReport = dbContext.ProductionDailyReports.Where(pdr => pdr.UserId == new Guid(Main.LOGGED_USER_ID) && pdr.Date == DateOnly.FromDateTime(DateTime.UtcNow)).Single();
                    dailyProdReport.TimeOut = TimeOnly.FromDateTime(DateTime.UtcNow);
                    dailyProdReport.ProductionRemark = report;
                    dbContext.SaveChanges();
                    MessageBox.Show(
                        $"Daily Production Report Added Successfuly",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
                    materialButtonCheckOut.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to checkout. Please Try again." + ex,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                dbContext.Dispose();
            }
        }
        private string LoadUserFullName(Guid id)
        {
            return new UserService(new()).GetFullName(id);
        }

        public void LoadDailyProductionReport()
        {
            try
            {
                AppDbContext dbContext = new();
                var dailyProlductionReport = from ProductionDailyReport in dbContext.ProductionDailyReports
                                             where ProductionDailyReport.ProductionRemark != null
                                             orderby ProductionDailyReport.Date
                                             select new
                                             {
                                                 userid = ProductionDailyReport.UserId,
                                                 timein = ProductionDailyReport.TimeIn,
                                                 timeout = ProductionDailyReport.TimeOut,
                                                 productionRemark = ProductionDailyReport.ProductionRemark,
                                                 date = ProductionDailyReport.Date
                                             };
                dataGridViewDailyProductionReport.Rows.Clear();
                foreach (var items in dailyProlductionReport)
                {
                    dataGridViewDailyProductionReport.Rows.Add(LoadUserFullName(items.userid), items.date, items.timein,
                        items.timeout, items.productionRemark);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Daily Production Remarks: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }

        }

        public void LoadDailyProductionReportPerDate(DateOnly fromDate, DateOnly toDate)
        {
                try
                {
                    AppDbContext dbContext = new();
                var dailyProlductionReport = from ProductionDailyReport in dbContext.ProductionDailyReports
                                             where ProductionDailyReport.Date >= fromDate && ProductionDailyReport.Date <= toDate
                                             where ProductionDailyReport.ProductionRemark != null
                                             orderby ProductionDailyReport.Date
                                             select new
                                           {
                                               userid = ProductionDailyReport.UserId,
                                               timein = ProductionDailyReport.TimeIn,
                                               timeout = ProductionDailyReport.TimeOut,
                                               productionRemark = ProductionDailyReport.ProductionRemark,
                                               date = ProductionDailyReport.Date
                                           };
                    dataGridViewDailyProductionReport.Rows.Clear();
                    foreach (var items in dailyProlductionReport)
                    {
                        dataGridViewDailyProductionReport.Rows.Add(LoadUserFullName(items.userid), items.date, items.timein, 
                            items.timeout, items.productionRemark);
                    }
                    dbContext.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Loading Daily Production Remarks: {ex}");
                    Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
                }
        
        }


        public void DailyProductionRemarkForReport()
        {
            List<DailyProduction_Report> daily_Production_Report = new List<DailyProduction_Report>();
            daily_Production_Report.Clear();
            for (int i = 0; i <= dataGridViewDailyProductionReport.Rows.Count - 1; i++)
            {
                DailyProduction_Report report = new DailyProduction_Report
                {
                    Engineer = dataGridViewDailyProductionReport.Rows[i].Cells[0].Value.ToString(),
                    Date = dataGridViewDailyProductionReport.Rows[i].Cells[1].Value.ToString(),
                    TimeIn = dataGridViewDailyProductionReport.Rows[i].Cells[2].Value.ToString(),
                    TimeOut = dataGridViewDailyProductionReport.Rows[i].Cells[3].Value.ToString(),
                    Report = dataGridViewDailyProductionReport.Rows[i].Cells[4].Value.ToString(),

                };
                daily_Production_Report.Add(report);
            }
            DailyProductionReportForm dpr = new DailyProductionReportForm(daily_Production_Report);
            dpr.ShowDialog();

        }


        private void materialButtonCheckIn_Click(object sender, EventArgs e)
        {
            AddDailyProductionReport_CheckIn();
        }

        private void materialButtonCheckOut_Click(object sender, EventArgs e)
        {
            AddDailyProductionReport_CheckOut();
        }

        private void materialButtonSearchDailyReport_Click(object sender, EventArgs e)
        {
            LoadDailyProductionReportPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
        }

        private void materialButtonPrintDailyProductionReport_Click(object sender, EventArgs e)
        {
            DailyProductionRemarkForReport();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            LoadDailyProductionReport();
        }
    }
}
