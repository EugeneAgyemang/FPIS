using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
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
    public partial class UserControlAddFinishedProduct : UserControl
    {
        public bool _isDataValid = true;
        public UserControlAddFinishedProduct()
        {
            InitializeComponent();
  
            labelCosigneeError.ForeColor = System.Drawing.Color.Red;
            labelBatchNumberError.ForeColor = System.Drawing.Color.Red;
            labelContainerNumberError.ForeColor = System.Drawing.Color.Red;
            labelSealNumberError.ForeColor = System.Drawing.Color.Red;
            labelQuantityError.ForeColor = System.Drawing.Color.Red;

            labelCosigneeError.Text = "";
            labelBatchNumberError.Text = "";
            labelContainerNumberError.Text = "";
            labelSealNumberError.Text = "";
            labelQuantityError.Text = "";

            LoadFinishedProducts();

            materialComboBoxFinishedProduct.SelectedIndex = -1;
            materialButtonAddFinishedProduct.Enabled = false;

        }

        public void ClearErrorLabels()
        {
            labelCosigneeError.Text = "";
            labelBatchNumberError.Text = "";
            labelContainerNumberError.Text = "";
            labelSealNumberError.Text = "";
            labelQuantityError.Text = "";
        }

        public void ClearFormFields()
        {
            materialTextBoxCosignee.Text = "";
            materialTextBoxProductType.Text = "";
            materialTextBoxBatchNumber.Text = "";
            materialTextBoxContainerNumber.Text = "";
            materialTextBoxSealNumber.Text = "";
            materialTextBoxQuantity.Text = "";
        }

        public void ValidateCosignee(string cosignee)
        {
            if (cosignee.Length == 0)
            {
                labelCosigneeError.Text = "Consignee is required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateBatchNumber(string batchNumber)
        {
            if (batchNumber.Length == 0)
            {
                labelBatchNumberError.Text = "Batch Number is required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateContainerNumber(string containerNumber)
        {
            if (containerNumber.Length == 0)
            {
                labelContainerNumberError.Text = "Container Number is required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateSealNumber(string sealNumber)
        {
            if (sealNumber.Length == 0)
            {
                labelSealNumberError.Text = "Seal Number is required!";
                _isDataValid = false;
                return;
            }

        }

        public void ValidateQuantity(string quantity)
        {
            if (quantity.Length == 0)
            {
                labelQuantityError.Text = "Quantity is required!";
                _isDataValid = false;
                return;
            }

        }

        private void LoadFinishedProducts()
        {
            try
            {
                AppDbContext dbContext = new();
                var requestType = from Product in dbContext.Products
                                  where Product.Type == "Finished Products"
                                  select Product.ProductName;
               materialComboBoxFinishedProduct.DataSource = requestType.Distinct().ToList();
                materialComboBoxFinishedProduct.DisplayMember = "TypeForFiltering";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading RequestType: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void LoadFinishedProductsWithAnalysisResults()
        {
            try
            {
                AppDbContext dbContext = new();
                var finishedProduct = from Product in dbContext.Products
                                      where Product.ProductName == materialComboBoxFinishedProduct.Text.Trim()
                                      from AnalysisProduct in dbContext.AnalysisProducts
                                      where AnalysisProduct.ProductId == Product.Id
                                      from SampleDetail in dbContext.SampleDetails
                                      where SampleDetail.AnalysisItemId == AnalysisProduct.AnalysisItemId
                                      from Sample in dbContext.Samples
                                      where Sample.Id == SampleDetail.SampleId
                                      from SampleResult in dbContext.SampleResults
                                      where SampleResult.SampleId == SampleDetail.SampleId
                                      select new
                                      {
                                          sampleDetailsID = SampleDetail.Id,
                                          finishedProduct = Product.ProductName,
                                          analysisRequestDate = Sample.Date,
                                          analysisRequestTime = Sample.Time,
                                          analysisResultDate = SampleResult.Date,
                                          analysisResultTime = SampleResult.Time
                                          
                                      };
                dataGridView_Finished_Products_With_Results.Rows.Clear();
                foreach (var items in finishedProduct)
                {
                    dataGridView_Finished_Products_With_Results.Rows.Add(items.sampleDetailsID,items.finishedProduct,items.analysisRequestDate,items.analysisRequestTime,items.analysisResultDate,items.analysisResultTime);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Departments: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        String currentDate = DateTime.UtcNow.ToString("yyyy-MM-dd");
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);
        private void materialButtonAddFinishedProduct_Click(object sender, EventArgs e)
        {
            string cosignee = materialTextBoxCosignee.Text.Trim();
            string productType = materialTextBoxProductType.Text.Trim();
            string batchNumber = materialTextBoxBatchNumber.Text.Trim();
            string containerNumber = materialTextBoxContainerNumber.Text.Trim();
            string sealNumber = materialTextBoxSealNumber.Text.Trim();
            string quantity = materialTextBoxQuantity.Text.Trim();

            ClearErrorLabels();
            ValidateCosignee(cosignee);
            ValidateBatchNumber(batchNumber);
            ValidateContainerNumber(containerNumber);
            ValidateSealNumber(sealNumber);
            ValidateQuantity(quantity);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                    $"Do you want to add \"{materialTextBoxProductType.Text}\" as a Finished Product?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

            if (dialogResult == DialogResult.Yes)
            {
                AppDbContext dbContext = new();
                var finishedProduct = from SampleDetail in dbContext.SampleDetails
                                      where SampleDetail.Id == _sampleDetailsID
                                      from SampleResult in dbContext.SampleResults
                                      where SampleResult.SampleId == SampleDetail.SampleId
                                      
                                      select new
                                   {
                                      sampleResultID = SampleResult.Id           
                                   };
                Guid Id = Guid.NewGuid();
                foreach (var sampleResultID in finishedProduct)
                {
                    Id = sampleResultID.sampleResultID;
                }
                try
                {
                    FinishedProductService finishedProductService = new(dbContext);
                    finishedProductService.AddFinishedProduct(date, cosignee, productType,batchNumber,containerNumber,sealNumber,quantity,Id);
                    MessageBox.Show(
                        $"Finished Product \"{materialTextBoxProductType.Text}\" is successfully added.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to add finished product. Please try again." + ex,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                finally
                {
                    dbContext.Dispose();
                    materialButtonAddFinishedProduct.Enabled = true;
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();
            materialButtonAddFinishedProduct.Enabled = false;
            if (materialComboBoxFinishedProduct.Text.Length == 0)
            {
                MessageBox.Show(
                     "Select a Finished Product to Add",
                     "Invalid Input",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                 );
            }
            else
            {
                LoadFinishedProductsWithAnalysisResults();
                ClearFormFields();
            }
        }

        Guid _sampleDetailsID = new Guid();
        private void dataGridView_Finished_Products_With_Results_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView_Finished_Products_With_Results.CurrentRow.Selected = true;
                materialTextBoxProductType.Text = dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                _sampleDetailsID = Guid.Parse(dataGridView_Finished_Products_With_Results.Rows[e.RowIndex].Cells["SampleDetailsID"].FormattedValue.ToString());
                materialButtonAddFinishedProduct.Enabled = true;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void materialButtonRequestForAnalysis_Click(object sender, EventArgs e)
        {
            CreateAnalysisRequestFinishedProducts requestAanalysis = new CreateAnalysisRequestFinishedProducts();
            requestAanalysis.ShowDialog();
        }
    }
}
