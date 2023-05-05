
using FPIS.Services;
using FPIS.Models;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class CreateAnalysisProduct : MaterialForm
    {
        private readonly ProductService _productService;
        private readonly AnalysisItemService _analysisItemService;

        public CreateAnalysisProduct()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);

            AppDbContext dbContext = new();
            _productService = new(dbContext);
            _analysisItemService = new(dbContext);

            LoadProducts();
        }

        private void LoadProducts()
        {
            materialComboBoxProducts.DataSource = _productService.GetAllProducts();
            materialComboBoxProducts.DisplayMember = "ProductName";
        }

        private void materialButtonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = materialComboBoxProducts.Text;
                Product? product = _productService.GetProductByName(productName);

                if (product == null)
                {
                    Utils.Utils.ShowMessageBox(
                        $"\"{productName}\" does not exist in our database. Add it and try again.",
                        "Product Does Not Exist",
                        icon: MessageBoxIcon.Exclamation
                        );
                    return;
                }

                if (_analysisItemService.IsProductAnalysisProduct(product))
                {
                    MessageBox.Show(
                        $"\"{productName}\" is already an analysis item",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );

                    return;
                }

                DialogResult dialogResult = Utils.Utils.ShowMessageBox(
                    $"Do you want to add \"{productName}\" as a new analysis product?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                _analysisItemService.CreateAnalysisProduct(product);

                Utils.Utils.ShowMessageBox(
                    $"\"{productName}\" is successfully added as Analysis Item",
                    "Success",
                    icon: MessageBoxIcon.Information
                    );

                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ${ex}");
            }
        }

        public void ClearFormFields()
        {
            materialComboBoxProducts.Text = string.Empty;
        }
    }
}
