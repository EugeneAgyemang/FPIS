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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class CreateStockItem : MaterialForm
    {
        public bool _isDataValid = true;

        public CreateStockItem()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);

            labelStockItemName.ForeColor = System.Drawing.Color.Red;
            labelUnitOfMeasurement.ForeColor = System.Drawing.Color.Red;
            labelStockItemType.ForeColor = System.Drawing.Color.Red;

            labelStockItemName.Text = "";
            labelUnitOfMeasurement.Text = "";
            labelStockItemType.Text = "";
        }

        public void ClearFormFields()
        {
            materialTextBoxStockItemName.Text = "";
            materialComboBoxUnitOfMeasurement.SelectedIndex = -1;
            materialComboBoxStockItemType.SelectedIndex = -1;
        }

        public void ClearErrorLabels()
        {
            labelStockItemName.Text = "";
            labelUnitOfMeasurement.Text = "";
            labelStockItemType.Text = "";
        }

        public void ValidateStockItemName(string stockItemName)
        {
            if (stockItemName.Length == 0)
            {
                
                labelStockItemName.Text = "Stock Item Name is required!";
                _isDataValid = false;
                return;
            }
        }

        public void ValidateUnitOfMeasurement(string unitOfMeasurement)
        {
            if (unitOfMeasurement.Length == 0)
            {
                _isDataValid = false;
                labelUnitOfMeasurement.Text = "Unit of Measurement is required!";
                return;
            }
        }

        public void ValidateItemType(string itemType)
        {
            if (itemType.Length == 0)
            {
                _isDataValid = false;
                labelStockItemType.Text = "Item Type is required!";
                return;
            }
        }

        private void btnCreateStockItem_Click(object sender, EventArgs e)
        {
            string stockItemName = materialTextBoxStockItemName.Text.Trim();
            string unitOfMeasurement = materialComboBoxUnitOfMeasurement.Text.Trim();
            string itemType = materialComboBoxStockItemType.Text.Trim();

            ClearErrorLabels();

            ValidateStockItemName(stockItemName);
            ValidateUnitOfMeasurement(unitOfMeasurement);
            ValidateItemType(itemType);

            if (!_isDataValid)
            {
                MessageBox.Show(
                    "You have some invalid inputs.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                btnCreateStockItem.Enabled = true;
                _isDataValid = true; 
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Do you want to create \"{stockItemName}\" as a new Stock Item?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                btnCreateStockItem.Enabled = false;
                AppDbContext dbContext = new();

                try
                {
                    StockItemService stockItemService = new(dbContext);

                    if (stockItemService.DoesStockItemExists(stockItemName))
                    {
                        MessageBox.Show(
                            $"\"{stockItemName}\" already exists, please change it.",
                            "Product Already Exists",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                            );

                        btnCreateStockItem.Enabled = true;
                        return;
                    }

                    ;stockItemService.CreateStockItem(stockItemName,unitOfMeasurement,itemType);
                    MessageBox.Show(
                        $"Stock Item \"{stockItemName}\" is successfully created.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
                }
                catch
                {
                    MessageBox.Show(
                        "Unable to create Stock Item. Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                finally
                {
                    dbContext.Dispose();
                    btnCreateStockItem.Enabled = true;
                }
            }

        }

        private void CreateStockItem_Load(object sender, EventArgs e)
        {
            materialComboBoxUnitOfMeasurement.SelectedIndex = -1;
            materialComboBoxStockItemType.SelectedIndex = -1;
        }

    }
}
