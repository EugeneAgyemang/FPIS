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

        private void ValidateProductName(string productName)
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

                MessageBox.Show(
                    $"\"{productName}\" is successfully created.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch
            {
                MessageBox.Show(
                    "Unable to create product. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void materialButtonCreateProduct_Click(object sender, EventArgs e)
        {
            materialButtonCreateProduct.Enabled = false;
            materialLabelProductNameError.Text = "";

            string productName = materialTextBoxProductName.Text.Trim();

            ValidateProductName(productName);

            if (!_isDataValid)
            {
                MessageBox.Show(
                    "You have some invalid inputs.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                materialButtonCreateProduct.Enabled = true;
                return;
            }

            AppDbContext dbContext = new();

            if (DoesProductExists(productName, dbContext))
            {
                MessageBox.Show(
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
            materialButtonCreateProduct.Enabled = true;
        }
    }
}
