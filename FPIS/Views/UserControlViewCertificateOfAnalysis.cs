using FPIS.Models;
using FPISReports;
using FPISReports.Datasets;
using FPISReports.ReportViews;
using MaterialSkin.Controls;
//using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FPIS.Views
{
    public partial class UserControlViewCertificateOfAnalysis : UserControl
    {
        public UserControlViewCertificateOfAnalysis()
        {
            InitializeComponent();
            LoadFinishedProducts();
            Align_Some_DataGridView_Content_ToCenter();
            materialButtonGenerateCertificateOfAnalysis.Enabled = false;
        }

        private void Align_Some_DataGridView_Content_ToCenter()
        {
            dataGridViewFinishedProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFinishedProducts.Columns["BatchNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFinishedProducts.Columns["ContainerNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFinishedProducts.Columns["SealNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFinishedProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFinishedProducts.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewAnalysisResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAnalysisResult.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAnalysisResult.Columns["Specification"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAnalysisResult.Columns["Result"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadFinishedProducts()
        {
            try
            {
                AppDbContext dbContext = new();
                var finishedProducts = from FinishedProduct in dbContext.FinishedProducts
                                       select new
                                       {
                                           consignee = FinishedProduct.Consignee,
                                           productType = FinishedProduct.ProductType,
                                           batchNumber = FinishedProduct.BatchNumber,
                                           containerNumber = FinishedProduct.ContainerNumber,
                                           sealNumber = FinishedProduct.SealNumber,
                                           quantity = FinishedProduct.Quantity,
                                           date = FinishedProduct.Date,
                                           sampleResultID = FinishedProduct.SampleResultId
                                       };
                dataGridViewFinishedProducts.Rows.Clear();
                foreach (var items in finishedProducts)
                {
                    dataGridViewFinishedProducts.Rows.Add(items.consignee, items.productType, items.batchNumber, items.containerNumber, items.sealNumber, items.quantity, items.date, items.sampleResultID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void LoadAnalyticalResult()
        {
            try
            {
                AppDbContext dbContext = new();
                var analysisResult = from Product in dbContext.Products
                                     where Product.ProductName == _productType
                                     from AnalysisProduct in dbContext.AnalysisProducts
                                     where AnalysisProduct.ProductId == Product.Id
                                     from SampleDetail in dbContext.SampleDetails
                                     where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId
                                     from Sample in dbContext.Samples
                                     where Sample.Id == SampleDetail.SampleId

                                     from SampleResult in dbContext.SampleResults
                                     where SampleResult.SampleId == SampleDetail.SampleId
                                     where SampleResult.Id == _sampleResultID

                                     from ProductParameter in dbContext.ProductParameters
                                     where ProductParameter.ProductId == Product.Id
                                     from ProductAnalysisParameter in dbContext.ProductAnalysisParameters
                                     where ProductAnalysisParameter.ProductParameterId == ProductParameter.Id
                                     from AnalysisParameter in dbContext.AnalysisParameters
                                     where ProductAnalysisParameter.AnalysisParameterId == AnalysisParameter.Id


                                     from SampleResultDetail in dbContext.SampleResultDetails
                                     where SampleResultDetail.SampleResultId == SampleResult.Id
                                     from SampleResultsDetailsWithParameter in dbContext.SampleResultsDetailsWithParameters
                                     where SampleResultsDetailsWithParameter.SampleResultDetailId == SampleResultDetail.Id
                                     where SampleResultsDetailsWithParameter.AnalysisParameterId == AnalysisParameter.Id

                                     //where SampleResultsDetailsWithParameter.SampleDetailId == SampleDetail.Id
                                     select new
                                     {
                                         parameter = ProductParameter.ParameterName,
                                         unit = ProductParameter.Unit,
                                         method = ProductParameter.Method,
                                         specification = ProductParameter.Specification,
                                         result = SampleResultsDetailsWithParameter.Value
                                     };
                dataGridViewAnalysisResult.Rows.Clear();
                foreach (var items in analysisResult)
                {
                    dataGridViewAnalysisResult.Rows.Add(items.parameter, items.unit, items.method, items.specification, items.result);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        Guid _sampleResultID = new Guid();
        string _productType;
        string _consignee;
        string _batchNumber;
        string _containerNumber;
        string _sealNumber;
        string _quantity;
        private void dataGridViewFinishedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewFinishedProducts.CurrentRow.Selected = true;
                _productType = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["ProductType"].FormattedValue.ToString();
                _consignee = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["Consignee"].FormattedValue.ToString();
                _batchNumber = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["BatchNumber"].FormattedValue.ToString();
                _containerNumber = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["ContainerNumber"].FormattedValue.ToString();
                _sealNumber = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["SealNumber"].FormattedValue.ToString();
                _quantity = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                _sampleResultID = Guid.Parse(dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["SampleResultID"].FormattedValue.ToString());
            }
            catch (Exception ex)
            {

            }
            LoadAnalyticalResult();
            materialButtonGenerateCertificateOfAnalysis.Enabled= true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DataForReport();    
        }

        public void DataForReport()
        {
            List<Certificate_Of_Analysis> cert_Analysis = new List<Certificate_Of_Analysis>();
            cert_Analysis.Clear();
            for (int i = 0; i <= dataGridViewAnalysisResult.Rows.Count - 1; i++)
            {
                Certificate_Of_Analysis cert = new Certificate_Of_Analysis 
                { 
                    Parameters = dataGridViewAnalysisResult.Rows[i].Cells[0].Value.ToString(),
                    Unit = dataGridViewAnalysisResult.Rows[i].Cells[1].Value.ToString(),
                    Method = dataGridViewAnalysisResult.Rows[i].Cells[2].Value.ToString(),
                    Specification = float.Parse(dataGridViewAnalysisResult.Rows[i].Cells[3].Value.ToString()),
                    Result = float.Parse(dataGridViewAnalysisResult.Rows[i].Cells[4].Value.ToString())

                };
                cert_Analysis.Add(cert);
            }
            CertificateOfAnalysis coa = new CertificateOfAnalysis(cert_Analysis, DateOnly.FromDateTime(DateTime.UtcNow.Date).ToShortDateString(), _consignee, _productType, _batchNumber, _containerNumber, _sealNumber, _quantity);
            coa.ShowDialog();

        }
      
    }
}
