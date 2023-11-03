using FPIS.Models;
using FPIS.Services;
using Reporting.Datasets;
using Reporting.ReportViews;
using MaterialSkin.Controls;
using Reporting.Datasets;
using Reporting.ReportViews;
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
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

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
            // dataGridView1.DataSource = parameterResultList;
            LoadAnalyticalResultsForToday();

            //labelAnalysisRemarkError.ForeColor = System.Drawing.Color.Red;

            //materialButtonSaveAnalysisRemark.Enabled = false;
            //materialButtonPrintAnalyticalResult.Enabled = false;
            //textBoxAnalyticalRemark.Enabled = false;
            //labelAnalysisRemarkError.Text = "";

            DisableTimeFilter();
        }


        void DisableTimeFilter()
        {
            dateTimePickerFromTime.Enabled = false;
            dateTimePickerToTime.Enabled = false;
            materialButton1.Enabled = false;
            materialButton2.Enabled = false;
            groupBox4.Enabled = false;
        }

        void EnableTimeFilter()
        {
            dateTimePickerFromTime.Enabled = true;
            dateTimePickerToTime.Enabled = true;
            materialButton1.Enabled = true;
            materialButton2.Enabled = true;
            groupBox4.Enabled = true;
        }

        public void ValidateAnalysisRemark(string analysisRemark)
        {
            if (analysisRemark.Length == 0)
            {
                // labelAnalysisRemarkError.Text = "Analysis Remark is required!";
                _isDataValid = false;
                return;
            }

        }

        public void ClearFormFields()
        {
            // textBoxAnalyticalRemark.Text = "";
        }

        public void ClearErrorLabels()
        {
            // labelAnalysisRemarkError.Text = "";
        }

        private void LoadAnalyticalResults()
        {
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            if (materialRadioButtonProductAnalysis.Checked)
            {
                List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResults(null);
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {

                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName} {sampleDetail.Label}";
                    sampleDetailItem.ProductType = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.Type;
                    sampleDetailItem.AnalysisType = sampleDetail.Sample.TypeForFiltering;
                    sampleDetailItem.AnalysisRequestDate = sampleDetail.Sample.Date.ToLongDateString();
                    sampleDetailItem.AnalysisRequestTime = sampleDetail.Sample.Time.ToLongTimeString();

                    //sampleDetailItem.AnalysisResultDate = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Date.ToLongDateString();
                    sampleDetailItem.AnalysisResultDate = sampleDetail.Sample.SampleResults.FirstOrDefault()?.Date.ToLongDateString();
                    //sampleDetailItem.AnalysisResultTime = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Time.ToLongTimeString();
                    sampleDetailItem.AnalysisResultTime = sampleDetail.Sample.SampleResults.FirstOrDefault()?.Time.ToLongTimeString();
                    //sampleDetailItem.SampleResultId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.SampleResult.Id.ToString();
                    //sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleDetailsId = sampleDetail.Id.ToString();
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId =
                    sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString();
                    //sampleDetail.Sample.SampleResults.FirstOrDefault().SampleResultDetails.FirstOrDefault().Id.ToString();

                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }

            }
            else
            {
                List<SampleDetail> samplesDetails = new WaterService(new()).GetWatersWithAnalysisResults(null);
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName} {sampleDetail.Label}";
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterParameters.FirstOrDefault().WaterAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }

            CountAnalysisRequests(totalNumberOfRequests);
        }

        private void LoadAnalyticalResultsForToday()
        {
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            if (materialRadioButtonProductAnalysis.Checked)
            {
                List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsForToday(DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")), DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")));
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName} {sampleDetail.Label}";
                    sampleDetailItem.ProductType = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.Type;
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }
            else
            {
                List<SampleDetail> samplesDetails = new WaterService(new()).GetWatersWithAnalysisResultsForToday(DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")), DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")));
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName} {sampleDetail.Label}";
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterParameters.FirstOrDefault().WaterAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }
            CountAnalysisRequests(totalNumberOfRequests);
            EnableTimeFilter();
        }

        private void LoadAnalyticalResultsPerDate()
        {
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            if (materialRadioButtonProductAnalysis.Checked)
            {
                List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName} {sampleDetail.Label}";
                    sampleDetailItem.ProductType = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.Type;
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }
            else
            {
                List<SampleDetail> samplesDetails = new WaterService(new()).GetWatersWithAnalysisResultsPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName} {sampleDetail.Label}";
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterParameters.FirstOrDefault().WaterAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }
            CountAnalysisRequests(totalNumberOfRequests);
            EnableTimeFilter();
        }

        TimeOnly _initialToTime, _finalToTime;
        void setToTime()
        {
            _initialToTime = TimeOnly.Parse(dateTimePickerToTime.Text);
            int initSeconds = _initialToTime.Second;
            int finalSeconds = 59 - initSeconds;
            _finalToTime = _initialToTime.Add(TimeSpan.FromSeconds(finalSeconds));
        }
        private void LoadAnalyticalResultsPerTime()
        {
            setToTime();
            ClearErrorLabels();
            int totalNumberOfRequests = 0;
            if (materialRadioButtonProductAnalysis.Checked)
            {
                List<SampleDetail> samplesDetails = new ProductService(new()).GetProductsWithAnalysisResultsPerTime(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), TimeOnly.Parse(dateTimePickerFromTime.Text), _finalToTime);
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductName} {sampleDetail.Label}";
                    sampleDetailItem.ProductType = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.Type;
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisProducts.FirstOrDefault().Product.ProductParameters.FirstOrDefault().ProductAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }
            else
            {
                List<SampleDetail> samplesDetails = new WaterService(new()).GetWatersWithAnalysisResultsPerTime(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), TimeOnly.Parse(dateTimePickerFromTime.Text), _finalToTime);
                sampleDetailsList.Clear();
                foreach (SampleDetail sampleDetail in samplesDetails)
                {
                    CheckAnalyticalResultsBindingItem sampleDetailItem = new CheckAnalyticalResultsBindingItem();
                    sampleDetailItem.AnalysisItem = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName;
                    sampleDetailItem.SampleDetailLabel = sampleDetail.Label;
                    sampleDetailItem.SampleDetailId = sampleDetail.Id;
                    sampleDetailItem.ProductName = $"{sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterName} {sampleDetail.Label}";
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
                    sampleDetailItem.SampleResultId = sampleDetail.Sample.SampleResults.FirstOrDefault().Id.ToString();
                    sampleDetailItem.SampleResultDetailsId = sampleDetail.AnalysisItem.AnalysisWaters.FirstOrDefault().Water.WaterParameters.FirstOrDefault().WaterAnalysisParameters.FirstOrDefault().AnalysisParameter.sampleResultsDetailsWithParameters.FirstOrDefault().SampleResultDetail.Id.ToString(); ;
                    totalNumberOfRequests++;
                    sampleDetailsList.Add(sampleDetailItem);
                }
            }
            CountAnalysisRequests(totalNumberOfRequests);
            EnableTimeFilter();
        }



        private void LoadProductAnalyticalResult()
        {
            try
            {
                AppDbContext dbContext = new();
                var analysisResult = from Product in dbContext.Products
                                     where Product.ProductName == _analysisItem
                                     from AnalysisProduct in dbContext.AnalysisProducts
                                     where AnalysisProduct.ProductId == Product.Id
                                     from SampleDetail in dbContext.SampleDetails
                                         //where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId && SampleDetail.Label == _sampleDetailLabel
                                     where SampleDetail.Id == _sampleDetailID
                                     from Sample in dbContext.Samples
                                     where Sample.Id == SampleDetail.SampleId

                                     from SampleResult in dbContext.SampleResults
                                     where SampleResult.SampleId == Sample.Id
                                     where SampleResult.Id == _sampleResultID
                                     //from SampleResultDetail in dbContext.SampleResultDetails
                                     //where SampleResultDetail.SampleResultId == _sampleResultID

                                     from SampleResultDetail in dbContext.SampleResultDetails
                                     where SampleResultDetail.SampleResultId == _sampleResultID
                                     // where SampleResultDetail.Id == _sampleResultDetailsId && SampleDetail.Id == _sampleDetailID
                                     from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                     where SampleResultsDetailsWithParameter.SampleResultDetailId == SampleResultDetail.Id

                                     from ProductParameter in dbContext.ProductParameters
                                     where ProductParameter.ProductId == Product.Id

                                     from ProductAnalysisParameter in dbContext.ProductAnalysisParameters
                                     where ProductAnalysisParameter.ProductParameterId == ProductParameter.Id
                                     //from AnalysisParameter in dbContext.AnalysisParameters
                                     //where ProductAnalysisParameter.AnalysisParameterId == AnalysisParameter.Id

                                     where SampleResultsDetailsWithParameter.AnalysisParameterId == ProductAnalysisParameter.AnalysisParameterId

                                     select new
                                     {
                                         parameter = ProductParameter.ParameterName,
                                         specification_range = $"{((ProductParameter.Specification == "0")? "-" : ProductParameter.MinimumSpecification == null ? "<= " + ProductParameter.Specification : ProductParameter.MinimumSpecification + " - " + ProductParameter.Specification)}",
                                         specification = ProductParameter.Specification,
                                         result = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : SampleResultsDetailsWithParameter.Value)}",
                                         variance = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (SampleResultsDetailsWithParameter.Value == "-") ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(ProductParameter.Specification) - float.Parse(SampleResultsDetailsWithParameter.Value)), 2))}",
                                         variance2 = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (SampleResultsDetailsWithParameter.Value == "-") ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(SampleResultsDetailsWithParameter.Value) - ProductParameter.MinimumSpecification), 2))}",
                                         //indicator = "",
                                         indicator = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : "")}",
                                         remarks = $"{(SampleResultsDetailsWithParameter.Remarks == null ? "" : SampleResultsDetailsWithParameter.Remarks)}"

                                     };

                        

                dataGridView1.Rows.Clear();
                foreach (var items in analysisResult)
                {
                    dataGridView1.Rows.Add(items.parameter, items.specification_range, items.result, items.indicator, items.remarks, items.variance2, items.variance);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Product Analytical Results: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadMultipleProductAnalyticalResult()
        {
            try
            {
                AppDbContext dbContext = new();

                var analysisResult = from Product in dbContext.Products
                                     where Product.ProductName == _analysisItem
                                     from AnalysisProduct in dbContext.AnalysisProducts
                                     where AnalysisProduct.ProductId == Product.Id
                                     from SampleDetail in dbContext.SampleDetails
                                         //where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId && SampleDetail.Label == _sampleDetailLabel
                                     where SampleDetail.Id == _sampleDetailID
                                     from Sample in dbContext.Samples
                                     where Sample.Id == SampleDetail.SampleId

                                     from SampleResult in dbContext.SampleResults
                                     where SampleResult.SampleId == Sample.Id
                                     where SampleResult.Id == _sampleResultID
                                     //from SampleResultDetail in dbContext.SampleResultDetails
                                     //where SampleResultDetail.SampleResultId == _sampleResultID

                                     from SampleResultDetail in dbContext.SampleResultDetails
                                     where SampleResultDetail.SampleResultId == _sampleResultID
                                     // where SampleResultDetail.Id == _sampleResultDetailsId && SampleDetail.Id == _sampleDetailID
                                     from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                     where SampleResultsDetailsWithParameter.SampleResultDetailId == _sampleResultDetailsId

                                     from ProductParameter in dbContext.ProductParameters
                                     where ProductParameter.ProductId == Product.Id

                                     from ProductAnalysisParameter in dbContext.ProductAnalysisParameters
                                     where ProductAnalysisParameter.ProductParameterId == ProductParameter.Id
                                     //from AnalysisParameter in dbContext.AnalysisParameters
                                     //where ProductAnalysisParameter.AnalysisParameterId == AnalysisParameter.Id

                                     where SampleResultsDetailsWithParameter.AnalysisParameterId == ProductAnalysisParameter.AnalysisParameterId

                                     select new
                                     {
                                         parameter = ProductParameter.ParameterName,
                                         specification_range = $"{((ProductParameter.Specification == "0") ? "-" : ProductParameter.MinimumSpecification == null ? "<= " + ProductParameter.Specification : ProductParameter.MinimumSpecification + " - " + ProductParameter.Specification)}",
                                         specification = ProductParameter.Specification,
                                         result = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : SampleResultsDetailsWithParameter.Value)}",
                                         variance = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (SampleResultsDetailsWithParameter.Value == "-") ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(ProductParameter.Specification) - float.Parse(SampleResultsDetailsWithParameter.Value)), 2))}",
                                         variance2 = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (SampleResultsDetailsWithParameter.Value == "-") ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(SampleResultsDetailsWithParameter.Value) - ProductParameter.MinimumSpecification), 2))}",
                                         //indicator = "",
                                         indicator = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : "")}",
                                         remarks = $"{(SampleResultsDetailsWithParameter.Remarks == null ? "" : SampleResultsDetailsWithParameter.Remarks)}"

                                     };
                dataGridView1.Rows.Clear();
                foreach (var items in analysisResult.Distinct())
                {
                    dataGridView1.Rows.Add(items.parameter, items.specification_range, items.result, items.indicator, items.remarks, items.variance2, items.variance);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Product Analytical Results: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadWaterAnalyticalResult()
        {
            try
            {
                AppDbContext dbContext = new();
                var analysisResult = from Water in dbContext.Waters
                                     where Water.WaterName == _analysisItem
                                     from AnalysisWater in dbContext.AnalysisWaters
                                     where AnalysisWater.WaterId == Water.Id
                                     from SampleDetail in dbContext.SampleDetails
                                         //where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId && SampleDetail.Label == _sampleDetailLabel
                                     where SampleDetail.Id == _sampleDetailID
                                     from Sample in dbContext.Samples
                                     where Sample.Id == SampleDetail.SampleId

                                     from SampleResult in dbContext.SampleResults
                                     where SampleResult.SampleId == Sample.Id
                                     where SampleResult.Id == _sampleResultID
                                     //from SampleResultDetail in dbContext.SampleResultDetails
                                     //where SampleResultDetail.SampleResultId == _sampleResultID

                                     from SampleResultDetail in dbContext.SampleResultDetails
                                     where SampleResultDetail.SampleResultId == _sampleResultID
                                     // where SampleResultDetail.Id == _sampleResultDetailsId && SampleDetail.Id == _sampleDetailID
                                     from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                     where SampleResultsDetailsWithParameter.SampleResultDetailId == SampleResultDetail.Id

                                     from WaterParameter in dbContext.WaterParameters
                                     where WaterParameter.WaterId == Water.Id

                                     from WaterAnalysisParameter in dbContext.WaterAnalysisParameters
                                     where WaterAnalysisParameter.WaterParameterId == WaterParameter.Id
                                     //from AnalysisParameter in dbContext.AnalysisParameters
                                     //where ProductAnalysisParameter.AnalysisParameterId == AnalysisParameter.Id

                                     where SampleResultsDetailsWithParameter.AnalysisParameterId == WaterAnalysisParameter.AnalysisParameterId

                                     select new
                                     {
                                         parameter = WaterParameter.ParameterName,
                                         specification_range = $"{((WaterParameter.ControlLimit == "0") ? "-" : WaterParameter.MinimumControlLimit == null ? "<= " + WaterParameter.ControlLimit : WaterParameter.MinimumControlLimit + " - " + WaterParameter.ControlLimit)}",
                                         specification = WaterParameter.ControlLimit,
                                         result = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : SampleResultsDetailsWithParameter.Value)}",
                                         variance = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(WaterParameter.ControlLimit) - float.Parse(SampleResultsDetailsWithParameter.Value)), 2))}",
                                         variance2 = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(SampleResultsDetailsWithParameter.Value) - WaterParameter.MinimumControlLimit), 2))}",
                                         //indicator = "",
                                         indicator = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : "")}",
                                         remarks = $"{(SampleResultsDetailsWithParameter.Remarks == null ? "" : SampleResultsDetailsWithParameter.Remarks)}"
                                     };
                dataGridView1.Rows.Clear();
                foreach (var items in analysisResult)
                {
                    dataGridView1.Rows.Add(items.parameter, items.specification_range, items.result, items.indicator, items.remarks, items.variance2, items.variance);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Product Analytical Results: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }


        private void LoadMultipleWaterAnalyticalResult()
        {
            try
            {
                AppDbContext dbContext = new();
                var analysisResult = from Water in dbContext.Waters
                                     where Water.WaterName == _analysisItem
                                     from AnalysisWater in dbContext.AnalysisWaters
                                     where AnalysisWater.WaterId == Water.Id
                                     from SampleDetail in dbContext.SampleDetails
                                         //where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId && SampleDetail.Label == _sampleDetailLabel
                                     where SampleDetail.Id == _sampleDetailID
                                     from Sample in dbContext.Samples
                                     where Sample.Id == SampleDetail.SampleId

                                     from SampleResult in dbContext.SampleResults
                                     where SampleResult.SampleId == Sample.Id
                                     where SampleResult.Id == _sampleResultID
                                     //from SampleResultDetail in dbContext.SampleResultDetails
                                     //where SampleResultDetail.SampleResultId == _sampleResultID

                                     from SampleResultDetail in dbContext.SampleResultDetails
                                     where SampleResultDetail.SampleResultId == _sampleResultID
                                     // where SampleResultDetail.Id == _sampleResultDetailsId && SampleDetail.Id == _sampleDetailID
                                     from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                     where SampleResultsDetailsWithParameter.SampleResultDetailId == _sampleResultDetailsId

                                     from WaterParameter in dbContext.WaterParameters
                                     where WaterParameter.WaterId == Water.Id

                                     from WaterAnalysisParameter in dbContext.WaterAnalysisParameters
                                     where WaterAnalysisParameter.WaterParameterId == WaterParameter.Id
                                     //from AnalysisParameter in dbContext.AnalysisParameters
                                     //where ProductAnalysisParameter.AnalysisParameterId == AnalysisParameter.Id

                                     where SampleResultsDetailsWithParameter.AnalysisParameterId == WaterAnalysisParameter.AnalysisParameterId
                                     select new
                                     {
                                         parameter = WaterParameter.ParameterName,
                                         specification_range = $"{((WaterParameter.ControlLimit == "0") ? "-" : WaterParameter.MinimumControlLimit == null ? "<= " + WaterParameter.ControlLimit : WaterParameter.MinimumControlLimit + " - " + WaterParameter.ControlLimit)}",
                                         specification = WaterParameter.ControlLimit,
                                         result = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : SampleResultsDetailsWithParameter.Value)}",
                                         variance = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(WaterParameter.ControlLimit) - float.Parse(SampleResultsDetailsWithParameter.Value)), 2))}",
                                         variance2 = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : (float)Math.Round(Convert.ToDecimal(float.Parse(SampleResultsDetailsWithParameter.Value) - WaterParameter.MinimumControlLimit), 2))}",
                                         indicator = $"{(SampleResultsDetailsWithParameter.Value == null ? "-" : (SampleResultsDetailsWithParameter.Value.Length >= 5) ? "-" : "")}",
                                         remarks = $"{(SampleResultsDetailsWithParameter.Remarks == null ? "" : SampleResultsDetailsWithParameter.Remarks)}"
                                     };
                dataGridView1.Rows.Clear();
                foreach (var items in analysisResult.Distinct())
                {
                    dataGridView1.Rows.Add(items.parameter, items.specification_range, items.result, items.indicator, items.remarks, items.variance2, items.variance);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Product Analytical Results: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void getSampleResultDetailsID()
        {
            try
            {
                AppDbContext dbContext = new();
                var sampleResiltDeatilsID = from SampleResultDetail in dbContext.SampleResultDetails
                                            where SampleResultDetail.SampleResultId == _sampleResultID && SampleResultDetail.Label == _sampleDetailLabel
                                            select new
                                            {
                                                sampleResultsDetailsID = SampleResultDetail.Id
                                            };
                foreach (var items in sampleResiltDeatilsID)
                {
                    _sampleResultDetailsId = items.sampleResultsDetailsID;
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Sample Results Details ID: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        string _analysisItemName;
        string _analysisRequestDate;
        string _analysisRequestTime;
        string _analysisResultDate;
        string _analysisResultTime;
        Guid _sampleDetailID;
        Guid _sampleResultID = new Guid();
        Guid _sampleResultDetailsId;
        string _analysisType;
        string _analysisItem;
        string _sampleDetailLabel;
        string _productType;
        private void dataGridView_Finished_Products_With_Results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*  parameterResultList.Clear();
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
            */
            try
            {
                dataGridView_Finished_Products_With_Results.CurrentRow.Selected = true;
                _analysisItemName = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].FormattedValue.ToString();
                _analysisRequestDate = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn3"].FormattedValue.ToString();
                _analysisRequestTime = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].FormattedValue.ToString();
                _analysisResultDate = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].FormattedValue.ToString();
                _analysisResultTime = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn6"].FormattedValue.ToString();
                _sampleDetailID = Guid.Parse(dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].FormattedValue.ToString());
                _sampleResultID = Guid.Parse(dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleResultDetailsId"].FormattedValue.ToString());
                // _sampleResultDetailsId = Guid.Parse(dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleResultsDetailsId"].FormattedValue.ToString());
                _analysisType = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].FormattedValue.ToString();
                _analysisItem = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["AnalysisItem"].FormattedValue.ToString();
                _sampleDetailLabel = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleDetailLabel"].FormattedValue.ToString();
                _productType = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["ProductType"].FormattedValue.ToString();
                // MessageBox.Show("SD ID : " + _sampleDetailLabel);
            }
            catch (Exception ex)
            {

            }
            if (_analysisType == "Production")
            {
                if (_sampleDetailLabel != "")
                {
                    getSampleResultDetailsID();
                    LoadMultipleProductAnalyticalResult();
                }
                else
                {
                    LoadProductAnalyticalResult();
                }

            }
            else
            {
                //MessageBox.Show("Label: " + _sampleDetailLabel + " SRID: " + _sampleResultID);
                if (_sampleDetailLabel != "")
                {
                    getSampleResultDetailsID();
                    LoadMultipleWaterAnalyticalResult();
                }
                else
                {
                    LoadWaterAnalyticalResult();
                }
            }
            materialButtonPrintAnalyticalResult.Enabled = true;
            if (_productType == "Raw Materials")
            {
                //materialButtonSaveAnalysisRemark.Enabled = false;
                //textBoxAnalyticalRemark.Enabled = false;
            }
            //else if (materialRadioButtonWaterAnalysis.Checked)
            //{
            //    materialButtonSaveAnalysisRemark.Enabled = false;
            //    textBoxAnalyticalRemark.Enabled = false;
            //}
            else
            {
                //materialButtonSaveAnalysisRemark.Enabled = true;
                //textBoxAnalyticalRemark.Enabled = true;
            }

            //MessageBox.Show("Max Variance: " + value + "\nMin Variance: "+ minValue);
        }

        private void AddAnalysisRemark()
        {
            // string analysisRemark = textBoxAnalyticalRemark.Text;
            DateOnly remarkDate = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly remarkTime = TimeOnly.FromDateTime(DateTime.UtcNow);

            ClearErrorLabels();
            // ValidateAnalysisRemark(analysisRemark);
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
                    // analysisRemarkService.AddAnalysisRemark(analysisRemark, remarkDate, _sampleDetailID, _sampleResultDetailsId, new Guid(Main.LOGGED_USER_ID), remarkTime, _analysisItemName);
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
            float value, minValue;

            if (args.ColumnIndex == 6)
            {
                float.TryParse(args.Value.ToString(), out value);

                if (value >= 0)
                {
                    return;
                }
                else if (args.Value.ToString() == "-")
                {
                    //args.CellStyle.BackColor = Color.White;
                    //args.CellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.BackColor = Color.White;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.ForeColor = Color.Black;
                    args.FormattingApplied = true;
                }
                else
                {
                    //args.CellStyle.BackColor = Color.Red;
                    //args.CellStyle.ForeColor = Color.Red;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.BackColor = Color.Red;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.ForeColor = Color.Red;
                    args.FormattingApplied = true;

                }
            }
            if (args.ColumnIndex == 5)
            {
                float.TryParse(args.Value.ToString(), out minValue);
                if (minValue < 0)
                {
                    //args.CellStyle.BackColor = Color.Red;
                    //args.CellStyle.ForeColor = Color.Red;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.BackColor = Color.Red;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.ForeColor = Color.Red;
                    args.FormattingApplied = true;
                }
                else if (args.Value.ToString() == "-")
                {
                    //args.CellStyle.BackColor = Color.White;
                    //args.CellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.BackColor = Color.White;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.ForeColor = Color.Black;
                    args.FormattingApplied = true;
                }
                else
                {
                    //args.CellStyle.BackColor = Color.Green;
                    //args.CellStyle.ForeColor = Color.Green;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.BackColor = Color.Green;
                    dataGridView1.Rows[args.RowIndex].Cells[3].Style.ForeColor = Color.Green;
                    args.FormattingApplied = true;

                }
            }
            else
            {
                return;
            }






            //if(args.ColumnIndex == 5)
            //{
            //    int.TryParse(args.Value.ToString(), out minValue);
            //    if (minValue < 0)
            //    {
            //        //args.CellStyle.BackColor = Color.Red;
            //        //args.CellStyle.ForeColor = Color.Red;
            //        dataGridView1.Rows[args.RowIndex].Cells[4].Style.BackColor = Color.Red;
            //        dataGridView1.Rows[args.RowIndex].Cells[4].Style.ForeColor = Color.Red;
            //        args.FormattingApplied = true;
            //    }
            //    else if (args.Value.ToString() == "-")
            //    {
            //        //args.CellStyle.BackColor = Color.White;
            //        //args.CellStyle.ForeColor = Color.Black;
            //        dataGridView1.Rows[args.RowIndex].Cells[4].Style.BackColor = Color.White;
            //        dataGridView1.Rows[args.RowIndex].Cells[4].Style.ForeColor = Color.Black;
            //        args.FormattingApplied = true;
            //    }
            //    else
            //    {
            //        //args.CellStyle.BackColor = Color.Green;
            //        //args.CellStyle.ForeColor = Color.Green;
            //        dataGridView1.Rows[args.RowIndex].Cells[4].Style.BackColor = Color.Green;
            //        dataGridView1.Rows[args.RowIndex].Cells[4].Style.ForeColor = Color.Green;
            //        args.FormattingApplied = true;
            //    }
            //}


            //int minValue;
            //if (args.ColumnIndex != 5)
            //{
            //    return;
            //}
            //int.TryParse(args.Value.ToString(), out minValue);
            //if (minValue < 0)
            //{
            //    args.CellStyle.BackColor = Color.Red;
            //    args.CellStyle.ForeColor = Color.Red;
            //    args.FormattingApplied = true;
            //}


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
                return;
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
                    Specification = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Actual = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Variance = dataGridView1.Rows[i].Cells[6].Value.ToString()

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
            LoadAnalyticalResultsPerDate();
            //materialButtonSaveAnalysisRemark.Enabled = false;
            materialButtonPrintAnalyticalResult.Enabled = false;
            // textBoxAnalyticalRemark.Enabled = false;
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadAnalyticalResults();
            //materialButtonSaveAnalysisRemark.Enabled = false;
            materialButtonPrintAnalyticalResult.Enabled = false;
            //textBoxAnalyticalRemark.Enabled = false;
            DisableTimeFilter();
        }

        private void materialButtonSaveAnalysisRemark_Click(object sender, EventArgs e)
        {
            AddAnalysisRemark();
        }

        private void materialRadioButtonProductAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            LoadAnalyticalResultsForToday();
            dataGridView1.Rows.Clear();
            //materialButtonSaveAnalysisRemark.Enabled = false;
            materialButtonPrintAnalyticalResult.Enabled = false;
            //textBoxAnalyticalRemark.Enabled = false;
            DisableTimeFilter();
        }

        private void materialRadioButtonWaterAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            LoadAnalyticalResultsForToday();
            dataGridView1.Rows.Clear();
            //materialButtonSaveAnalysisRemark.Enabled = false;
            materialButtonPrintAnalyticalResult.Enabled = false;
            // textBoxAnalyticalRemark.Enabled = false;
            DisableTimeFilter();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoadAnalyticalResultsPerTime();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            LoadAnalyticalResultsPerDate();
            //materialButtonSaveAnalysisRemark.Enabled = false;
            materialButtonPrintAnalyticalResult.Enabled = false;
            // textBoxAnalyticalRemark.Enabled = false;
        }
    }
}
