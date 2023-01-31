
using FPIS.Services;
using FPIS.Models;
using MaterialSkin.Controls;
using FPIS.Utils;

namespace FPIS.Views
{
    public partial class CreateAnalysisProduct : Form
    {
        private readonly ProductService _productService;
        private readonly AnalysisItemService _analysisItemService;

        public CreateAnalysisProduct()
        {
            InitializeComponent();

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

                _analysisItemService.CreateAnalysisProduct(product);
                MessageBox.Show(
                    $"\"{productName}\" is successfully added as Analysis Item",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ${ex}");
            }
        }
    }
}
