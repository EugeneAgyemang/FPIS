using FPIS.Models;
using MaterialSkin.Controls;
using Reports.Datasets;
using Reports.ReportViews;
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
    public partial class UserControlProductReport : UserControl
    {
        int countProducts;
        public bool _isDataValid = true;
        public UserControlProductReport()
        {
            InitializeComponent();
            LoadProducts();
            LoadProductType();
            ProductCount(countProducts);
            materialComboBoxProductType.SelectedIndex = -1;

            labelProductTypeError.ForeColor = System.Drawing.Color.Red;

            labelProductTypeError.Text = "";
        }

        public void ValidateProductypeFilter(string productType)
        {
            if (productType.Length == 0)
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

        private void LoadProductType()
        {
            try
            {
                AppDbContext dbContext = new();
                var productType = from Product in dbContext.Products
                                   select Product.Type;
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

        void ProductCount(int totalStockItems)
        {
            if (totalStockItems == 0)
            {
                labelProductCount.Text = "No Product Added";
            }
            else
            {
                labelProductCount.Text =
                    $"{totalStockItems} Product{((totalStockItems > 1) ? "s" : "")} Added";
            }
        }

        private void LoadProducts()
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var products = from Product in dbContext.Products
                              select new
                              {
                                  name = Product.ProductName,
                                  type = Product.Type
                              };
                dataGridViewProductreport.Rows.Clear();
                foreach (var items in products)
                {
                    dataGridViewProductreport.Rows.Add(items.name, items.type);
                }
                dbContext.Dispose();
                countProducts = dataGridViewProductreport.Rows.Count;
                ProductCount(countProducts);
                //labelProductCount.Text = countProducts.ToString();
                //labelProductCount.Text =
                //    $"{countProducts} Product{((countProducts > 1) ? "s" : "")} Added";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Requested Samples: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadProductsByProductType(string productType)
        {
            ClearErrorLabels();
            ValidateProductypeFilter(productType);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            try
            {
                AppDbContext dbContext = new();
                var products = from Product in dbContext.Products
                               where Product.Type== productType
                               select new
                               {
                                   name = Product.ProductName,
                                   type = Product.Type
                               };
                dataGridViewProductreport.Rows.Clear();
                foreach (var items in products)
                {
                    dataGridViewProductreport.Rows.Add(items.name, items.type);
                }
                dbContext.Dispose();
                countProducts = dataGridViewProductreport.Rows.Count;
                labelProductCount.Text = countProducts.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Requested Samples: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }
        public void ProductsForReport()
        {
            List<Product_Report> product_Report = new List<Product_Report>();
            product_Report.Clear();
            for (int i = 0; i <= dataGridViewProductreport.Rows.Count - 1; i++)
            {
                Product_Report prodReport = new Product_Report
                {
                    ProductName = dataGridViewProductreport.Rows[i].Cells[0].Value.ToString(),
                    ProductType = dataGridViewProductreport.Rows[i].Cells[1].Value.ToString(),

                };
                product_Report.Add(prodReport);
            }
            ProductReportForm prf = new ProductReportForm(product_Report);
            prf.ShowDialog();

        }
        private void materialButtonPrintProductReport_Click(object sender, EventArgs e)
        {
            ProductsForReport();
        }

        private void materialButtonSearchProductType_Click(object sender, EventArgs e)
        {
            LoadProductsByProductType(materialComboBoxProductType.Text);
            ProductCount(countProducts);
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
