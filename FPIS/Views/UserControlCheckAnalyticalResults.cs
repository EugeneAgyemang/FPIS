using FPIS.Models;
using FPIS.Services;
using FPISReports.Datasets;
using FPISReports.ReportViews;
using MaterialSkin.Controls;
using Reports.Datasets;
using Reports.ReportViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPIS.Views
{
    public partial class UserControlCheckAnalyticalResults : UserControl
    {
        public bool _isDataValid = true;
        public BindingList<CheckAnalyticalResultsBindingItem> sampleDetailsList = new BindingList<CheckAnalyticalResultsBindingItem>();
        public BindingList<CheckAnalyticalParameterResultsBindingItem> parameterResultList = new BindingList<CheckAnalyticalParameterResultsBindingItem>();
        public UserControlCheckAnalyticalResults()
        {
            InitializeComponent();
            dataGridView_Finished_Products_With_Results.DataSource = sampleDetailsList;
            dataGridView1.DataSource = parameterResultList;
            LoadAnalyticalResults();
            LoadAnalysisType();
            materialComboBoxAnalysisType.SelectedIndex = -1;

            labelItemCategoryError.ForeColor = System.Drawing.Color.Red;
            labelAnalysisRemarkError.ForeColor = System.Drawing.Color.Red;

            labelItemCategoryError.Text = "";
            materialButtonSaveAnalysisRemark.Enabled= false;
            materialButtonPrintAnalyticalResult.Enabled= false; 
            textBoxAnalyticalRemark.Enabled= false;
            labelAnalysisRemarkError.Text = "";
        }

        public void ValidateCategoryFilter(string itemCategory)
        {
            if (itemCategory.Length == 0)
            {
                labelItemCategoryError.Text = "Select an Analysis Type!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateAnalysisRemark(string analysisRemark)
        {
            if (analysisRemark.Length == 0)
            {
                labelAnalysisRemarkError.Text = "Analysis Remark is required!";
                _isDataValid = false;
                return;
            }

        }

        public void ClearFormFields()
        {
            textBoxAnalyticalRemark.Text = "";
        }

        public void ClearErrorLabels()
        {
            labelItemCategoryError.Text = "";
            labelAnalysisRemarkError.Text = "";
        }

        public void ResetAnalysisTypeFilter()
        {
            materialComboBoxAnalysisType.SelectedIndex = -1;
            materialComboBoxAnalysisType.Focus();
        }

        private void LoadAnalysisType()
        {
            try
            {
                AppDbContext dbContext = new();
                var requestType = from Sample in dbContext.Samples
                                  select Sample.TypeForFiltering;
                materialComboBoxAnalysisType.DataSource = requestType.Distinct().ToList();
                materialComboBoxAnalysisType.DisplayMember = "TypeForFiltering";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading AnalysisType: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }
        private void LoadAnalyticalResults()
        {
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResults(null);
            sampleDetailsList.Clear();
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                sampleDetailItem.ProductName = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                sampleDetailItem.AnalysisType = sampleDetail.Sample.TypeForFiltering;
                sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();
                //sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                sampleDetailItem.AnalysisResultDate = sampleDetail.Sample.SampleResults.FirstOrDefault().Date.ToLongDateString();
                //sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                sampleDetailItem.AnalysisResultTime = sampleDetail.Sample.SampleResults.FirstOrDefault().Time.ToLongTimeString();
                //sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                //sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                sampleDetailItem.SampleDetailsId = sampleDetail.Id.ToString();
                sampleDetailItem.SampleResultDetailsId= sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                totalNumberOfRequests++;
                sampleDetailsList.Add(sampleDetailItem);
            }
            CountAnalysisRequests(totalNumberOfRequests);
        }

        private void LoadAnalyticalResultsPerDate()
        {
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
            sampleDetailsList.Clear();
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                sampleDetailItem.ProductName = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                sampleDetailItem.AnalysisType = sampleDetail.Sample.TypeForFiltering;
                sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();
                sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                //sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                sampleDetailItem.SampleDetailsId = sampleDetail.Id.ToString();
                totalNumberOfRequests++;
                sampleDetailsList.Add(sampleDetailItem);
            }
            CountAnalysisRequests(totalNumberOfRequests);
        }

        private void LoadAnalyticalResultsByAnalysisType()
        {
            ClearErrorLabels();
            ValidateCategoryFilter(materialComboBoxAnalysisType.Text);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            int totalNumberOfRequests = 0;
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsByAnalysisType(materialComboBoxAnalysisType.Text);
            sampleDetailsList.Clear();
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                sampleDetailItem.ProductName = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                sampleDetailItem.AnalysisType = sampleDetail.Sample.TypeForFiltering;
                sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();
                sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                //sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                sampleDetailItem.SampleDetailsId = sampleDetail.Id.ToString();
                totalNumberOfRequests++;
                sampleDetailsList.Add(sampleDetailItem);
            }
            CountAnalysisRequests(totalNumberOfRequests);
        }


        private void LoadAnalyticalResultsByDateAndAnalysisType()
        {
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsPerDateAndAnalysisType(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxAnalysisType.Text);
            sampleDetailsList.Clear();
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                sampleDetailItem.ProductName = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                sampleDetailItem.AnalysisType = sampleDetail.Sample.TypeForFiltering;
                sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();
                sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                //sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                sampleDetailItem.SampleDetailsId = sampleDetail.Id.ToString();
                
                totalNumberOfRequests++;
                sampleDetailsList.Add(sampleDetailItem);
            }
            CountAnalysisRequests(totalNumberOfRequests);
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


        string _analysisItemName;
        string _analysisRequestDate;
        string _analysisRequestTime;
        string _analysisResultDate;
        string _analysisResultTime;
        string _sampleDetailID;
        string _sampleResultDetailID;
        private void dataGridView_Finished_Products_With_Results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            parameterResultList.Clear();
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            //string sampleResultId;
            Guid sampleResultId = Guid.Parse(dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleDetailsId"].Value.ToString());
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResults(sampleResultId);
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                foreach (ProductParameter param in sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters)
                {
                    CheckAnalyticalParameterResultsBindingItem parameterResult = new CheckAnalyticalParameterResultsBindingItem();
                    parameterResult.ParameterName = param.ParameterName;
                    parameterResult.Expected = param.Specification;
                    parameterResult.Actual = param.ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().Value;
                    parameterResult.Variance = (float)Math.Round((parameterResult.Expected - parameterResult.Actual), 2);
                    parameterResult.Indicator = (float)Math.Round((parameterResult.Expected - parameterResult.Actual), 2);

                    parameterResultList.Add(parameterResult);
                }
            }

            try
            {
                dataGridView_Finished_Products_With_Results.CurrentRow.Selected = true;
                _analysisItemName = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["productNameDataGridViewTextBoxColumn"].FormattedValue.ToString();
                _analysisRequestDate = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["analysisRequestDateDataGridViewTextBoxColumn"].FormattedValue.ToString();
                _analysisRequestTime = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["analysisRequestTimeDataGridViewTextBoxColumn"].FormattedValue.ToString();
                _analysisResultDate = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["analysisResultDateDataGridViewTextBoxColumn"].FormattedValue.ToString();
                _analysisResultTime = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["analysisResultTimeDataGridViewTextBoxColumn"].FormattedValue.ToString();
                _sampleDetailID = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleDetailsId"].FormattedValue.ToString();
                _sampleResultDetailID = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleResultDetailsId"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {

            }
            materialButtonSaveAnalysisRemark.Enabled = true;
            materialButtonPrintAnalyticalResult.Enabled = true;
            textBoxAnalyticalRemark.Enabled = true;
        }

        private void AddAnalysisRemark()
        {
            string analysisRemark = textBoxAnalyticalRemark.Text;
            DateOnly remarkDate = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly remarkTime = TimeOnly.FromDateTime(DateTime.UtcNow);

            ClearErrorLabels();
            ValidateAnalysisRemark(analysisRemark);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            AppDbContext dbContext = new();
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                $"Do you want to add an Analysis Remark?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    AnalysisRemarkService analysisRemarkService = new(dbContext);
                     analysisRemarkService.AddAnalysisRemark(analysisRemark, remarkDate, new Guid(_sampleDetailID), new Guid(_sampleResultDetailID), new Guid(Main.LOGGED_USER_ID), remarkTime, _analysisItemName);
                     MessageBox.Show(
                       $"Analysis Remark added successfully for \"{_analysisItemName}\"",
                      "Success",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                      );
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add an Analysys Remark. Please Try again." + ex,
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
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs args)
        {
            int value;
            if (args.ColumnIndex != 4)
            {
                return;
            }
            int.TryParse(args.Value.ToString(), out value);
            if (value < 0)
            {
                args.CellStyle.BackColor = Color.Red;
                args.CellStyle.ForeColor = Color.White;
                args.FormattingApplied = true;
            }
            else
            {
                args.CellStyle.BackColor = Color.Green;
                args.CellStyle.ForeColor = Color.White;
                args.FormattingApplied = true;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs args)
        {
            args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            args.CellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            if (args.RowIndex < 1 || args.ColumnIndex < 0)
            {
                return;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception) { }
        }
        private void CountAnalysisRequests(int count)
        {
            if (count == 0)
            {
                SamplesRequestedOverviewControl.Text = "No analysis results available at the moment";
            }
            SamplesRequestedOverviewControl.Text = $"{count} analysis result{((count > 1) ? "s" : "")} available";
        }

        public void DataForReport()
        {
            List<Analytical_Results> analytical_Result = new List<Analytical_Results>();
            analytical_Result.Clear();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                Analytical_Results analyticalRes = new Analytical_Results
                {
                    ParameterName = dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Specification = float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
                    Actual = float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()),
                    Variance = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())

                };
                analytical_Result.Add(analyticalRes);
            }
            AnalyticalResults ar = new AnalyticalResults(analytical_Result, _analysisItemName, _analysisRequestDate, _analysisRequestTime, _analysisResultDate, _analysisResultTime);
            ar.ShowDialog();

        }

        private void materialButtonPrintAnalyticalResult_Click(object sender, EventArgs e)
        {
            DataForReport();
        }

        private void materialButtonSearchAnalyticalResults_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Enabled == false && dateTimePickerToDate.Enabled == false)
            {
                LoadAnalyticalResultsByAnalysisType();
            }
            else if (materialComboBoxAnalysisType.Text == "")
            {
                LoadAnalyticalResultsPerDate();
            }
            else
            {
                LoadAnalyticalResultsByDateAndAnalysisType();
            }
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadAnalyticalResults();
        }

        private void SwitchFilterControl_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitchDate();
        }

        private void buttonResetRequestTypeFilter_Click(object sender, EventArgs e)
        {
            ResetAnalysisTypeFilter();
        }

        private void materialButtonSaveAnalysisRemark_Click(object sender, EventArgs e)
        {
            AddAnalysisRemark();
        }
    }
}
