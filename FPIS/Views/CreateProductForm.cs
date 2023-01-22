using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class CreateProductForm : MaterialForm
    {
        public bool _isDataValid = true;

        public CreateProductForm()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);

            // set color to red in the #hexadecimal format
            materialLabelProductNameError.ForeColor = ColorTranslator.FromHtml("#FF0000");
        }

        public void ClearFormFields()
        {
            materialTextBoxProductName.Text = "";
        }

        public void ClearErrorLabels()
        {
            materialLabelProductNameError.Text = "";
        }

        public void ValidateProductName(string productName)
        {
            if (productName.Length == 0)
            {
                _isDataValid = false;
                materialLabelProductNameError.Text = "Name is required!";
            }
        }

        private void materialButtonCreateProduct_Click(object sender, EventArgs e)
        {

            string productName = materialTextBoxProductName.Text.Trim();
            ClearErrorLabels();

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

                try
                {
                    ProductService productService = new(dbContext);

                    if (productService.DoesProductExists(productName))
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

                    productService.CreateProduct(productName);
                    MaterialMessageBox.Show(
                        $"\"{productName}\" is successfully created.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
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
                finally
                {
                    dbContext.Dispose();
                    materialButtonCreateProduct.Enabled = true;
                }
            }
        }
    }
}
