using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Reports.Datasets;
using Reports.ReportViews;
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
    public partial class userControlSampleReport : UserControl
    {
        int countSamples;
        public bool _isDataValid = true;
        public userControlSampleReport()
        {
            InitializeComponent();
            LoadRequestedSamples();
            samplesCount(countSamples);
            LoadRequestType();
            materialComboBoxRequestType.SelectedIndex = -1;

            labelItemCategoryError.ForeColor = System.Drawing.Color.Red;

            labelItemCategoryError.Text = "";
        }

        public void ValidateCategoryFilter(string itemCategory)
        {
            if (itemCategory.Length == 0)
            {
                labelItemCategoryError.Text = "Select a Request Type!";
                _isDataValid = false;
                return;
            }

        }

        public void ClearErrorLabels()
        {
            labelItemCategoryError.Text = "";
        }

        public void ResetRequestTypeFilter()
        {
            materialComboBoxRequestType.SelectedIndex = -1;
            materialComboBoxRequestType.Focus();
        }

        void samplesCount(int totalStockItems)
        {
            if (totalStockItems == 0)
            {
                labelRequestedSampleCount.Text = "No Sample Requested yet";
            }
            else
            {
                labelRequestedSampleCount.Text =
                    $"{totalStockItems} Sample{((totalStockItems > 1) ? "s" : "")} Requested";
            }
        }

        private void LoadRequestType()
        {
            try
            {
                AppDbContext dbContext = new();
                var requestType = from Sample in dbContext.Samples
                                  select Sample.TypeForFiltering;
                materialComboBoxRequestType.DataSource = requestType.Distinct().ToList();
                materialComboBoxRequestType.DisplayMember = "TypeForFiltering";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading RequestType: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private string LoadUserFullName(string id)
        {
            return new UserService(new()).GetFullNameByID(id);
        }

        private void LoadRequestedSamples()
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var samples = from Sample in dbContext.Samples
                              orderby Sample.Date
                              select new
                              {
                                  date = Sample.Date,
                                  time = Sample.Time,
                                  status = Sample.Status,
                                  type = Sample.TypeForFiltering,
                                  employee1 = Sample.Employee1,
                                  employee2 = Sample.Employee2
                              };
                dataGridViewRequestedSamples.Rows.Clear();
                foreach (var items in samples)
                {
                    dataGridViewRequestedSamples.Rows.Add(items.date, items.time,
                        items.status, items.type, LoadUserFullName(items.employee1), LoadUserFullName(items.employee2));
                }
                dbContext.Dispose();
                countSamples = dataGridViewRequestedSamples.Rows.Count;
                labelRequestedSampleCount.Text = countSamples.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Requested Samples: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadRequestedSamplesPerDate(DateOnly fromDate, DateOnly toDate)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var samples = from Sample in dbContext.Samples
                              where Sample.Date >= fromDate && Sample.Date <= toDate
                              orderby Sample.Date
                              select new
                              {
                                  date = Sample.Date,
                                  time = Sample.Time,
                                  status = Sample.Status,
                                  type = Sample.TypeForFiltering,
                                  employee1 = Sample.Employee1,
                                  employee2 = Sample.Employee2
                              };
                dataGridViewRequestedSamples.Rows.Clear();
                foreach (var items in samples)
                {
                    dataGridViewRequestedSamples.Rows.Add(items.date, items.time,
                        items.status, items.type, LoadUserFullName(items.employee1), LoadUserFullName(items.employee2));
                }
                dbContext.Dispose();
                countSamples = dataGridViewRequestedSamples.Rows.Count;
                labelRequestedSampleCount.Text = countSamples.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Requested Samples: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadRequestedSamplesByRequestType(string requestType)
        {
            ClearErrorLabels();
            ValidateCategoryFilter(requestType);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            try
            {
                AppDbContext dbContext = new();
                var samples = from Sample in dbContext.Samples
                              where Sample.TypeForFiltering == requestType
                              orderby Sample.Date
                              select new
                              {
                                  date = Sample.Date,
                                  time = Sample.Time,
                                  status = Sample.Status,
                                  type = Sample.TypeForFiltering,
                                  employee1 = Sample.Employee1,
                                  employee2 = Sample.Employee2
                              };
                dataGridViewRequestedSamples.Rows.Clear();
                foreach (var items in samples)
                {
                    dataGridViewRequestedSamples.Rows.Add(items.date, items.time,
                        items.status, items.type, LoadUserFullName(items.employee1), LoadUserFullName(items.employee2));
                }
                dbContext.Dispose();
                countSamples = dataGridViewRequestedSamples.Rows.Count;
                labelRequestedSampleCount.Text = countSamples.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Requested Samples: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadRequestedSamplesPerDateAndType(DateOnly fromDate, DateOnly toDate,string requestType)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var samples = from Sample in dbContext.Samples
                              where Sample.Date >= fromDate && Sample.Date <= toDate && Sample.TypeForFiltering == requestType
                              orderby Sample.Date
                              select new
                              {
                                  date = Sample.Date,
                                  time = Sample.Time,
                                  status = Sample.Status,
                                  type = Sample.TypeForFiltering,
                                  employee1 = Sample.Employee1,
                                  employee2 = Sample.Employee2
                              };
                dataGridViewRequestedSamples.Rows.Clear();
                foreach (var items in samples)
                {
                    dataGridViewRequestedSamples.Rows.Add(items.date, items.time,
                        items.status, items.type, LoadUserFullName(items.employee1), LoadUserFullName(items.employee2));
                }
                dbContext.Dispose();
                countSamples = dataGridViewRequestedSamples.Rows.Count;
                labelRequestedSampleCount.Text = countSamples.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Requested Samples: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void ToggleSwitchDate(bool isCalledElsedWhere = false)
        {
            string[] captions = { "Turn Off Date filters to search only by Request Type", "Turn On Date filters to search with all Filters" };
            string[] switchDateCaptions = { "I'm Searching by all Filters", "I'm searching only by Request Type" };
            string captionOfSwitchDateControl = SwitchFilterControl.Text;
            if (captionOfSwitchDateControl == captions[1] || isCalledElsedWhere)
            {
                SwitchFilterControl.Text = captions[0];
                SwitchCaptionControl.Text = switchDateCaptions[0];
                dateTimePickerFromDate.Enabled = true;
                dateTimePickerToDate.Enabled = true;
                return;
            }
            SwitchFilterControl.Text = captions[1];
            SwitchCaptionControl.Text = switchDateCaptions[1];
            dateTimePickerFromDate.Enabled = false;
            dateTimePickerToDate.Enabled = false;
        }

        private void materialButtonSearchRequestedSample_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Enabled == false && dateTimePickerToDate.Enabled == false)
            {
                LoadRequestedSamplesByRequestType(materialComboBoxRequestType.Text);
            }
            else if (materialComboBoxRequestType.Text == "")
            {
                LoadRequestedSamplesPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text)); 
            }
            else
            {
                LoadRequestedSamplesPerDateAndType(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxRequestType.Text);   
            }
            samplesCount(countSamples);
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadRequestedSamples();
            samplesCount(countSamples);
        }

        public void RequestedSamplesForReport()
        {
            List<Requested_Samples> requested_Samples = new List<Requested_Samples>();
            requested_Samples.Clear();
            for (int i = 0; i <= dataGridViewRequestedSamples.Rows.Count - 1; i++)
            {
                Requested_Samples reqSamples = new Requested_Samples
                {
                    RequestDate = dataGridViewRequestedSamples.Rows[i].Cells[0].Value.ToString(),
                    RequestTime = dataGridViewRequestedSamples.Rows[i].Cells[1].Value.ToString(),
                    Status = dataGridViewRequestedSamples.Rows[i].Cells[2].Value.ToString(),
                    RequestType = dataGridViewRequestedSamples.Rows[i].Cells[3].Value.ToString(),
                    Employee1 = dataGridViewRequestedSamples.Rows[i].Cells[4].Value.ToString(),
                    Employee2 = dataGridViewRequestedSamples.Rows[i].Cells[5].Value.ToString(),

                };
                requested_Samples.Add(reqSamples);
            }
            RequestedSamples rs = new RequestedSamples(requested_Samples);
            rs.ShowDialog();

        }

        private void materialButtonPrintRequestedSamples_Click(object sender, EventArgs e)
        {
            RequestedSamplesForReport();
        }

        private void SwitchFilterControl_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitchDate();
        }

        private void buttonResetRequestTypeFilter_Click(object sender, EventArgs e)
        {
            ResetRequestTypeFilter();
        }
    }
}
