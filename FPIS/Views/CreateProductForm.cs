using FPIS.Models;
using FPIS.Views;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class CreateProductForm : MaterialForm
    {
        bool _isDataValid = true;

        public CreateProductForm()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);
        }

        public void ClearFormFields()
        {
            materialTextBoxProductName.Text = "";
        }

        public void ValidateProductName(string productName)
        {
            if (productName.Length == 0)
            {
                _isDataValid = false;
                materialLabelProductNameError.Text = "Name is required!";
            }
        }

        public static bool DoesProductExists(string productName, AppDbContext dbContext)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.ProductName.ToLower() == productName.ToLower());

            if (product != null)
            {
                return true;
            }

            return false;
        }

        private void CreateProduct(string productName, AppDbContext dbContext)
        {
            try
            {
                var analysisItem = dbContext.AnalysisItems.Add(
                        new()
                        {
                            ItemType = "Product"
                        }
                    ).Entity;

                var newProduct = dbContext.Products.Add(
                    new()
                    {
                        ProductName = productName
                    }
                 ).Entity;

                dbContext.AnalysisProducts.Add(
                        new()
                        {
                            ProductId = newProduct.Id,
                            AnalysisItemId = analysisItem.Id
                        }
                    );

                dbContext.SaveChanges();

                MaterialMessageBox.Show(
                    $"\"{productName}\" is successfully created.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch
            {
                MaterialMessageBox.Show(
                    "Unable to create product. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void materialButtonCreateProduct_Click(object sender, EventArgs e)
        {
            string productName = materialTextBoxProductName.Text.Trim();
            materialLabelProductNameError.Text = "";

            ValidateProductName(productName);

            if (!_isDataValid)
            {
                MaterialMessageBox.Show(
                    "You have some invalid inputs.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                materialButtonCreateProduct.Enabled = true;
                _isDataValid = true; // reset this else it can no longer be true.
                return;
            }

            DialogResult dialogResult = MaterialMessageBox.Show(
                $"Do you want to create \"{productName}\" as a new product?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                materialButtonCreateProduct.Enabled = false;

                AppDbContext dbContext = new();

                if (DoesProductExists(productName, dbContext))
                {
                    MaterialMessageBox.Show(
                        $"\"{productName}\" already exists, please change it.",
                        "Product Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );

                    materialButtonCreateProduct.Enabled = true;
                    return;
                }

                CreateProduct(productName, dbContext);

                dbContext.Dispose();
                ClearFormFields();
                materialButtonCreateProduct.Enabled = true;
            }
        }
    }
}
