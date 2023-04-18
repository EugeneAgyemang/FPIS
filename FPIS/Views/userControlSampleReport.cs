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
        public userControlSampleReport()
        {
            InitializeComponent();
            LoadRequestedSamples();
            samplesCount(countSamples);
            LoadRequestType();
            materialComboBoxRequestType.SelectedIndex = -1;
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
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private string LoadUserFullName(string id)
        {
            return new UserService(new()).GetFullNameByID(id);
        }

        private void LoadRequestedSamples()
        {
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
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void LoadRequestedSamplesPerDate(DateOnly fromDate, DateOnly toDate)
        {
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
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void LoadRequestedSamplesPerDateAndType(DateOnly fromDate, DateOnly toDate,string requestType)
        {
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
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void materialButtonSearchRequestedSample_Click(object sender, EventArgs e)
        {
            if (materialComboBoxRequestType.Text == "")
            {
                LoadRequestedSamplesPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
                samplesCount(countSamples);
            }
            else
            {
                LoadRequestedSamplesPerDateAndType(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxRequestType.Text);
                samplesCount(countSamples);
            }
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
    }
}
