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
    public partial class UserControlViewAnalysisRemarks : UserControl
    {
        int remarks;
        public bool _isDataValid = true;
        public UserControlViewAnalysisRemarks()
        {
            InitializeComponent();
            LoadAnalysisRemark();
            LoadAnalysisItemType();
            analysisRemarkCount(remarks);
            materialComboBoxAnalysisItemType.SelectedIndex = -1;

            labelItemCategoryError.ForeColor = System.Drawing.Color.Red;

            labelItemCategoryError.Text = "";
        }

        public void ValidateItemTypeFilter(string itemType)
        {
            if (itemType.Length == 0)
            {
                labelItemCategoryError.Text = "Select an Analysis Item Type!";
                _isDataValid = false;
                return;
            }

        }

        public void ClearErrorLabels()
        {
            labelItemCategoryError.Text = "";
        }

        public void ResetCategoryFilter()
        {
            materialComboBoxAnalysisItemType.SelectedIndex = -1;
            materialComboBoxAnalysisItemType.Focus();
        }

        private void LoadAnalysisItemType()
        {
            try
            {
                AppDbContext dbContext = new();
                var requestType = from Sample in dbContext.Samples
                                  select Sample.TypeForFiltering;
                materialComboBoxAnalysisItemType.DataSource = requestType.Distinct().ToList();
                materialComboBoxAnalysisItemType.DisplayMember = "TypeForFiltering";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Analysis Item Type: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        void analysisRemarkCount(int totalAnalysisType)
        {
            if (totalAnalysisType == 0)
            {
                labelStockItemCount.Text = "No Production Remark yet";
            }
            else
            {
                labelStockItemCount.Text =
                    $"{totalAnalysisType} Production Remark{((totalAnalysisType > 1) ? "s" : "")}";
            }
        }

        private string LoadUserFullName(Guid id)
        {
            return new UserService(new()).GetFullName(id);
        }

        private void LoadAnalysisRemark()
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var analysisRemarks = from AnalysisRemark in dbContext.AnalysisRemarks
                                   orderby AnalysisRemark.Time descending
                                   select new
                                   {
                                       analysisItem = AnalysisRemark.AnalysisItem,
                                       remark = AnalysisRemark.Remark,
                                       remarkDate = AnalysisRemark.Date,
                                       remarkTime = AnalysisRemark.Time,
                                       userId = AnalysisRemark.UserId
                                   };
                dataGridViewAnalysisRemarks.Rows.Clear();
                foreach (var items in analysisRemarks)
                {
                    dataGridViewAnalysisRemarks.Rows.Add(items.analysisItem,items.remark,items.remarkDate,items.remarkTime,LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                remarks = dataGridViewAnalysisRemarks.Rows.Count;
                labelStockItemCount.Text = remarks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadAnalysisRemarkByDate(DateOnly fromDate, DateOnly toDate)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var analysisRemarks = from AnalysisRemark in dbContext.AnalysisRemarks
                                      where AnalysisRemark.Date >= fromDate && AnalysisRemark.Date <= toDate
                                      orderby AnalysisRemark.Time descending
                                      select new
                                      {
                                          analysisItem = AnalysisRemark.AnalysisItem,
                                          remark = AnalysisRemark.Remark,
                                          remarkDate = AnalysisRemark.Date,
                                          remarkTime = AnalysisRemark.Time,
                                          userId = AnalysisRemark.UserId
                                      };
                dataGridViewAnalysisRemarks.Rows.Clear();
                foreach (var items in analysisRemarks)
                {
                    dataGridViewAnalysisRemarks.Rows.Add(items.analysisItem, items.remark, items.remarkDate, items.remarkTime, LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                remarks = dataGridViewAnalysisRemarks.Rows.Count;
                labelStockItemCount.Text = remarks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadAnalysisRemarkByDateAndAnalysisType(DateOnly fromDate, DateOnly toDate, string analysisType)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var analysisRemarks = from AnalysisRemark in dbContext.AnalysisRemarks
                                      from SampleDetail in dbContext.SampleDetails
                                      where AnalysisRemark.SampleDetailId == SampleDetail.Id
                                      from Sample in dbContext.Samples
                                      where Sample.Id == SampleDetail.SampleId && Sample.TypeForFiltering == analysisType && AnalysisRemark.Date >= fromDate && AnalysisRemark.Date <= toDate
                                      orderby AnalysisRemark.Time descending
                                      select new
                                      {
                                          analysisItem = AnalysisRemark.AnalysisItem,
                                          remark = AnalysisRemark.Remark,
                                          remarkDate = AnalysisRemark.Date,
                                          remarkTime = AnalysisRemark.Time,
                                          userId = AnalysisRemark.UserId
                                      };
                dataGridViewAnalysisRemarks.Rows.Clear();
                foreach (var items in analysisRemarks)
                {
                    dataGridViewAnalysisRemarks.Rows.Add(items.analysisItem, items.remark, items.remarkDate, items.remarkTime, LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                remarks = dataGridViewAnalysisRemarks.Rows.Count;
                labelStockItemCount.Text = remarks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }
        private void LoadAnalysisRemarkByAnalysisType(string analysisType)
        {
            ClearErrorLabels();
            ValidateItemTypeFilter(analysisType);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            try
            {
                AppDbContext dbContext = new();
                var analysisRemarks = from AnalysisRemark in dbContext.AnalysisRemarks
                                      from SampleDetail in dbContext.SampleDetails
                                      where AnalysisRemark.SampleDetailId == SampleDetail.Id
                                      from Sample in dbContext.Samples
                                      where Sample.Id == SampleDetail.SampleId && Sample.TypeForFiltering == analysisType
                                      orderby AnalysisRemark.Time descending
                                      select new
                                      {
                                          analysisItem = AnalysisRemark.AnalysisItem,
                                          remark = AnalysisRemark.Remark,
                                          remarkDate = AnalysisRemark.Date,
                                          remarkTime = AnalysisRemark.Time,
                                          userId = AnalysisRemark.UserId
                                      };
                dataGridViewAnalysisRemarks.Rows.Clear();
                foreach (var items in analysisRemarks)
                {
                    dataGridViewAnalysisRemarks.Rows.Add(items.analysisItem, items.remark, items.remarkDate, items.remarkTime, LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                remarks = dataGridViewAnalysisRemarks.Rows.Count;
                labelStockItemCount.Text = remarks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void ToggleSwitchDate(bool isCalledElsedWhere = false)
        {
            string[] captions = { "Turn Off Date filters to search only by Analysis Type", "Turn On Date filters to search with all Filters" };
            string[] switchDateCaptions = { "I'm Searching by all Filters", "I'm searching only by Analysis Type" };
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

        private void materialButtonSearchIssuedStock_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Enabled == false && dateTimePickerToDate.Enabled == false)
            {
                LoadAnalysisRemarkByAnalysisType(materialComboBoxAnalysisItemType.Text);
            }
            else if (materialComboBoxAnalysisItemType.Text == "")
            {
                LoadAnalysisRemarkByDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
            }
            else
            {
                LoadAnalysisRemarkByDateAndAnalysisType(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxAnalysisItemType.Text);
            }
            analysisRemarkCount(remarks);
        }

        public void AnalysisRemarkForReport()
        {
            List<Analysis_Remark> analysis_Remark = new List<Analysis_Remark>();
            analysis_Remark.Clear();
            for (int i = 0; i <= dataGridViewAnalysisRemarks.Rows.Count - 1; i++)
            {
                Analysis_Remark analysisRemark = new Analysis_Remark
                {
                    AnalysisItemName = dataGridViewAnalysisRemarks.Rows[i].Cells[0].Value.ToString(),
                    Remark = dataGridViewAnalysisRemarks.Rows[i].Cells[1].Value.ToString(),
                    RemarkDate = dataGridViewAnalysisRemarks.Rows[i].Cells[2].Value.ToString(),
                    RemarkTime = dataGridViewAnalysisRemarks.Rows[i].Cells[3].Value.ToString(),
                    RemarkBy = dataGridViewAnalysisRemarks.Rows[i].Cells[4].Value.ToString(),

                };
                analysis_Remark.Add(analysisRemark);
            }
            AnalysisRemarkForm arf = new AnalysisRemarkForm(analysis_Remark);
            arf.ShowDialog();

        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadAnalysisRemark();
        }

        private void SwitchFilterControl_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitchDate();
        }

        private void materialButtonPrintAnalysisRemark_Click(object sender, EventArgs e)
        {
            AnalysisRemarkForReport();
        }
        public void ResetProductTypeFilter()
        {
            materialComboBoxAnalysisItemType.SelectedIndex = -1;
            materialComboBoxAnalysisItemType.Focus();
        }

        private void buttonResetCatrgotyFilter_Click(object sender, EventArgs e)
        {
            ResetCategoryFilter();
        }
    }
}
