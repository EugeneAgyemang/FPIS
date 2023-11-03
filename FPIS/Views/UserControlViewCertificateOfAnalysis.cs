using FPIS.Models;
using Reporting;
using Reporting.Datasets;
using Reporting.ReportViews;
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
        public bool _isDataValid = true;
        public UserControlViewCertificateOfAnalysis()
        {
            InitializeComponent();
            LoadFinishedProductsForToday(DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")), DateOnly.Parse(DateTime.Now.ToString("MM/dd/yyyy")));
            LoadProductType();
            Align_Some_DataGridView_Content_ToCenter();
            materialButtonGenerateCertificateOfAnalysis.Enabled = false;

            materialComboBoxProductType.SelectedIndex = -1;

            labelProductTypeError.ForeColor = System.Drawing.Color.Red;

            labelProductTypeError.Text = "";
        }

        public void ValidateCategoryFilter(string itemCategory)
        {
            if (itemCategory.Length == 0)
            {
                labelProductTypeError.Text = "Select a Product Type!";
                _isDataValid = false;
                return;
            }

        }

        public void ClearErrorLabels()
        {
            labelProductTypeError.Text = "";
        }

        public void ResetProductTypeFilter()
        {
            materialComboBoxProductType.SelectedIndex = -1;
            materialComboBoxProductType.Focus();
        }

        private void LoadProductType()
        {
            try
            {
                AppDbContext dbContext = new();
                var productType = from FinishedProduct in dbContext.FinishedProducts
                                  select FinishedProduct.ProductType;
                materialComboBoxProductType.DataSource = productType.Distinct().ToList();
                materialComboBoxProductType.DisplayMember = "ProductType";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Product Type: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
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
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var finishedProducts = from FinishedProduct in dbContext.FinishedProducts
                                       orderby FinishedProduct.Date

                                       from Designation in dbContext.Designations
                                       where Designation.DesignationName.ToLower().Trim() == "quality control manager"
                                       from User in dbContext.Users
                                       where User.DesignationId == Designation.Id

                                       select new
                                       {
                                           consignee = FinishedProduct.Consignee,
                                           productName = FinishedProduct.ProductType,
                                           label = FinishedProduct.Label,
                                           productType = FinishedProduct.ProductType + " " + FinishedProduct.Label,
                                           batchNumber = FinishedProduct.BatchNumber,
                                           containerNumber = FinishedProduct.ContainerNumber,
                                           sealNumber = FinishedProduct.SealNumber,
                                           quantity = FinishedProduct.Quantity,
                                           date = FinishedProduct.Date,
                                           sampleResultID = FinishedProduct.SampleResultId,
                                           managerName = User.FirstName + " " + User.MiddleName + " " + User.LastName,
                                       };
                dataGridViewFinishedProducts.Rows.Clear();
                foreach (var items in finishedProducts)
                {
                    dataGridViewFinishedProducts.Rows.Add(items.consignee, items.productName, items.label, items.productType, items.batchNumber, items.containerNumber, items.sealNumber, items.quantity, items.date, items.managerName, items.sampleResultID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadFinishedProductsByProductType(string productType)
        {
            ClearErrorLabels();
            ValidateCategoryFilter(productType);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            try
            {
                AppDbContext dbContext = new();
                var finishedProducts = from FinishedProduct in dbContext.FinishedProducts
                                       where FinishedProduct.ProductType == productType
                                       orderby FinishedProduct.Date
                                       from Designation in dbContext.Designations
                                       where Designation.DesignationName.ToLower().Trim() == "quality control manager"
                                       from User in dbContext.Users
                                       where User.DesignationId == Designation.Id
                                       select new
                                       {
                                           consignee = FinishedProduct.Consignee,
                                           productName = FinishedProduct.ProductType,
                                           label = FinishedProduct.Label,
                                           productType = FinishedProduct.ProductType + " " + FinishedProduct.Label,
                                           batchNumber = FinishedProduct.BatchNumber,
                                           containerNumber = FinishedProduct.ContainerNumber,
                                           sealNumber = FinishedProduct.SealNumber,
                                           quantity = FinishedProduct.Quantity,
                                           date = FinishedProduct.Date,
                                           sampleResultID = FinishedProduct.SampleResultId,
                                           managerName = User.FirstName + " " + User.MiddleName + " " + User.LastName,
                                       };
                dataGridViewFinishedProducts.Rows.Clear();
                foreach (var items in finishedProducts)
                {
                    dataGridViewFinishedProducts.Rows.Add(items.consignee, items.productName, items.label, items.productType, items.batchNumber, items.containerNumber, items.sealNumber, items.quantity, items.date, items.managerName, items.sampleResultID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }


        private void LoadFinishedProductsForToday(DateOnly fromDate, DateOnly toDate)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var finishedProducts = from FinishedProduct in dbContext.FinishedProducts
                                       where FinishedProduct.Date >= fromDate && FinishedProduct.Date <= toDate
                                       orderby FinishedProduct.Date
                                       from Designation in dbContext.Designations
                                       where Designation.DesignationName.ToLower().Trim() == "quality control manager"
                                       from User in dbContext.Users
                                       where User.DesignationId == Designation.Id
                                       select new
                                       {
                                           consignee = FinishedProduct.Consignee,
                                           productName = FinishedProduct.ProductType,
                                           label = FinishedProduct.Label,
                                           productType = FinishedProduct.ProductType + " " + FinishedProduct.Label,
                                           batchNumber = FinishedProduct.BatchNumber,
                                           containerNumber = FinishedProduct.ContainerNumber,
                                           sealNumber = FinishedProduct.SealNumber,
                                           quantity = FinishedProduct.Quantity,
                                           date = FinishedProduct.Date,
                                           sampleResultID = FinishedProduct.SampleResultId,
                                           managerName = User.FirstName + " " + User.MiddleName + " " + User.LastName,
                                       };
                dataGridViewFinishedProducts.Rows.Clear();
                foreach (var items in finishedProducts)
                {
                    dataGridViewFinishedProducts.Rows.Add(items.consignee, items.productName, items.label, items.productType, items.batchNumber, items.containerNumber, items.sealNumber, items.quantity, items.date, items.managerName, items.sampleResultID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadFinishedProductsByDate(DateOnly fromDate, DateOnly toDate)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var finishedProducts = from FinishedProduct in dbContext.FinishedProducts
                                       where FinishedProduct.Date >= fromDate && FinishedProduct.Date <= toDate
                                       orderby FinishedProduct.Date
                                       from Designation in dbContext.Designations
                                       where Designation.DesignationName.ToLower().Trim() == "quality control manager"
                                       from User in dbContext.Users
                                       where User.DesignationId == Designation.Id
                                       select new
                                       {
                                           consignee = FinishedProduct.Consignee,
                                           productName = FinishedProduct.ProductType,
                                           label = FinishedProduct.Label,
                                           productType = FinishedProduct.ProductType + " " + FinishedProduct.Label,
                                           batchNumber = FinishedProduct.BatchNumber,
                                           containerNumber = FinishedProduct.ContainerNumber,
                                           sealNumber = FinishedProduct.SealNumber,
                                           quantity = FinishedProduct.Quantity,
                                           date = FinishedProduct.Date,
                                           sampleResultID = FinishedProduct.SampleResultId,
                                           managerName = User.FirstName + " " + User.MiddleName + " " + User.LastName,
                                       };
                dataGridViewFinishedProducts.Rows.Clear();
                foreach (var items in finishedProducts)
                {
                    dataGridViewFinishedProducts.Rows.Add(items.consignee, items.productName, items.label, items.productType, items.batchNumber, items.containerNumber, items.sealNumber, items.quantity, items.date, items.managerName, items.sampleResultID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadFinishedProductsByDateAndProductType(DateOnly fromDate, DateOnly toDate, string productType)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var finishedProducts = from FinishedProduct in dbContext.FinishedProducts
                                       where FinishedProduct.Date >= fromDate && FinishedProduct.Date <= toDate && FinishedProduct.ProductType == productType
                                       orderby FinishedProduct.Date
                                       from Designation in dbContext.Designations
                                       where Designation.DesignationName.ToLower().Trim() == "quality control manager"
                                       from User in dbContext.Users
                                       where User.DesignationId == Designation.Id
                                       select new
                                       {
                                           consignee = FinishedProduct.Consignee,
                                           productName = FinishedProduct.ProductType,
                                           label = FinishedProduct.Label,
                                           productType = FinishedProduct.ProductType + " " + FinishedProduct.Label,
                                           batchNumber = FinishedProduct.BatchNumber,
                                           containerNumber = FinishedProduct.ContainerNumber,
                                           sealNumber = FinishedProduct.SealNumber,
                                           quantity = FinishedProduct.Quantity,
                                           date = FinishedProduct.Date,
                                           sampleResultID = FinishedProduct.SampleResultId,
                                           managerName = User.FirstName + " " + User.MiddleName + " " + User.LastName,
                                       };
                dataGridViewFinishedProducts.Rows.Clear();
                foreach (var items in finishedProducts)
                {
                    dataGridViewFinishedProducts.Rows.Add(items.consignee, items.productName, items.label, items.productType, items.batchNumber, items.containerNumber, items.sealNumber, items.quantity, items.date, items.managerName, items.sampleResultID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Products: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void ToggleSwitchDate(bool isCalledElsedWhere = false)
        {
            string[] captions = { "Turn Off Date filters to search only by Product Type", "Turn On Date filters to search with all Filters" };
            string[] switchDateCaptions = { "I'm Searching by all Filters", "I'm searching only by Product Type" };
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
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadMultipleProductAnalyticalResult()
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
                                     //where Product.ProductName == _productType
                                     //from AnalysisProduct in dbContext.AnalysisProducts
                                     //where AnalysisProduct.ProductId == Product.Id
                                     //from SampleDetail in dbContext.SampleDetails
                                     //    //where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId && SampleDetail.Label == _sampleDetailLabel
                                     //where SampleDetail.Id == _sampleDetailID
                                     //from Sample in dbContext.Samples
                                     //where Sample.Id == SampleDetail.SampleId

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
                                         unit = ProductParameter.Unit,
                                         method = ProductParameter.Method,
                                         specification = ProductParameter.Specification,
                                         result = SampleResultsDetailsWithParameter.Value
                                     };
                dataGridViewAnalysisResult.Rows.Clear();
                foreach (var items in analysisResult.Distinct())
                {
                    dataGridViewAnalysisResult.Rows.Add(items.parameter, items.unit, items.method, items.specification, items.result);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Finished Product Analytical Results: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void getSampleResultDetailsID()
        {
            try
            {
                AppDbContext dbContext = new();
                var sampleResiltDeatilsID = from SampleResultDetail in dbContext.SampleResultDetails
                                            where SampleResultDetail.SampleResultId == _sampleResultID && SampleResultDetail.Label == _label
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

        Guid _sampleResultID = new Guid();
        string _productType;
        string _consignee;
        string _batchNumber;
        string _containerNumber;
        string _sealNumber;
        string _quantity;
        Guid _sampleResultDetailsId;
        string _qualityControlManager;
        string _label;
        private void dataGridViewFinishedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewFinishedProducts.CurrentRow.Selected = true;
                _productType = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                _consignee = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["Consignee"].FormattedValue.ToString();
                _batchNumber = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["BatchNumber"].FormattedValue.ToString();
                _containerNumber = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["ContainerNumber"].FormattedValue.ToString();
                _sealNumber = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["SealNumber"].FormattedValue.ToString();
                _quantity = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                _sampleResultID = Guid.Parse(dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["SampleResultID"].FormattedValue.ToString());
                _qualityControlManager = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["QualityControlManager"].FormattedValue.ToString();
                _label = dataGridViewFinishedProducts.Rows[e.RowIndex].Cells["Label"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {

            }
            if (_label != "")
            {
                getSampleResultDetailsID();
                LoadMultipleProductAnalyticalResult();
            }
            else
            {
                LoadAnalyticalResult();
                //LoadProductAnalyticalResult();
            }

            materialButtonGenerateCertificateOfAnalysis.Enabled = true;
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
            CertificateOfAnalysis coa = new CertificateOfAnalysis(cert_Analysis, DateOnly.FromDateTime(DateTime.UtcNow.Date).ToShortDateString(), _consignee, _productType, _batchNumber, _containerNumber, _sealNumber, _quantity, _qualityControlManager);
            coa.ShowDialog();

        }

        private void SwitchFilterControl_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitchDate();
        }

        private void materialButtonSearchProductType_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Enabled == false && dateTimePickerToDate.Enabled == false)
            {
                LoadFinishedProductsByProductType(materialComboBoxProductType.Text);
            }
            else if (materialComboBoxProductType.Text == "")
            {
                LoadFinishedProductsByDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));
            }
            else
            {
                LoadFinishedProductsByDateAndProductType(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxProductType.Text);
            }
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadFinishedProducts();
        }

        private void buttonResetProductTypeFilter_Click(object sender, EventArgs e)
        {
            ResetProductTypeFilter();
        }
    }
}
