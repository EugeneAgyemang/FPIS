using FPIS.Models;
using FPIS.Services;
using FPISReports.Datasets;
using FPISReports.ReportViews;
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
        public BindingList<CheckAnalyticalResultsBindingItem> sampleDetailsList = new BindingList<CheckAnalyticalResultsBindingItem>();
        public BindingList<CheckAnalyticalParameterResultsBindingItem> parameterResultList = new BindingList<CheckAnalyticalParameterResultsBindingItem>();
        public UserControlCheckAnalyticalResults()
        {
            InitializeComponent();
            dataGridView_Finished_Products_With_Results.DataSource = sampleDetailsList;
            dataGridView1.DataSource = parameterResultList;
            LoadAnalyticalResults();
        }
        private void LoadAnalyticalResults()
        {
            int totalNumberOfRequests = 0;
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResults();
            sampleDetailsList.Clear();
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                sampleDetailItem.ProductName = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();
                sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                totalNumberOfRequests++;
                sampleDetailsList.Add(sampleDetailItem);
            }
            CountAnalysisRequests(totalNumberOfRequests);
        }

        private void LoadAnalyticalResultsPerDate()
        {
            int totalNumberOfRequests = 0;
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
            sampleDetailsList.Clear();
            foreach (SampleDetail sampleDetail in samplesDetails)
            {
                CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                sampleDetailItem.ProductName = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();
                sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                totalNumberOfRequests++;
                sampleDetailsList.Add(sampleDetailItem);
            }
            CountAnalysisRequests(totalNumberOfRequests);
        }


        string _analysisItemName;
        string _analysisRequestDate;
        string _analysisRequestTime;
        string _analysisResultDate;
        string _analysisResultTime;
        private void dataGridView_Finished_Products_With_Results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            parameterResultList.Clear();
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            //string sampleResultId;
            string productName = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
            List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResults(productName);
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
            }
            catch (Exception ex)
            {

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
            if(count == 0)
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
            AnalyticalResults ar = new AnalyticalResults(analytical_Result,_analysisItemName,_analysisRequestDate,_analysisRequestTime,_analysisResultDate,_analysisResultTime);
            ar.ShowDialog();

        }

        private void materialButtonPrintAnalyticalResult_Click(object sender, EventArgs e)
        {
            DataForReport();
        }

        private void materialButtonSearchAnalyticalResults_Click(object sender, EventArgs e)
        {
            LoadAnalyticalResultsPerDate();
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadAnalyticalResults();
        }
    }
}
