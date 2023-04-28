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
using static MaterialSkin.MaterialSkinManager;

namespace FPIS.Views
{
    public partial class ReceiveStock : MaterialForm
    {
        public bool _isDataValid = true;
        public ReceiveStock()
        {
            InitializeComponent();
            Theme.FormInstance = this;
            Theme.Set(Themes.LIGHT);

            dateTimePickerExpiryDate.MinDate = DateTime.Now;

            labelStockItemToReceive.ForeColor = System.Drawing.Color.Red;
            labelQuantityReceived.ForeColor = System.Drawing.Color.Red;

            labelStockItemToReceive.Text = "";
            labelQuantityReceived.Text = "";

            LoadStockItems();

        }

        public void ClearFormFields()
        {
            materialComboBoxStockItem.SelectedIndex = -1;
            materialTextBoxQuantityReceived.Text = "";
        }

        public void ClearErrorLabels()
        {
            labelStockItemToReceive.Text = "";
            labelQuantityReceived.Text = "";

        }

        public void ValidateReceivedStockItem(string stockItemName)
        {
            if (stockItemName.Length == 0)
            {

                labelStockItemToReceive.Text = "Select a Stock Item!";
                _isDataValid = false;
                return;
            }
        }

        public void ValidateQuantityReceived(string quantity)
        {
            if (quantity.Length == 0)
            {
                _isDataValid = false;
                labelQuantityReceived.Text = "Quantity is required!";
                return;
            }

            if (int.Parse(quantity) == 0)
            {
                _isDataValid = false;
                labelQuantityReceived.Text =
                    "Quantity must be greater than 0";

                return;
            }
        }

        private void LoadStockItems()
        {
            try
            {
                AppDbContext dbContext = new();
                var item = from StockItem in dbContext.StockItems
                                     select StockItem.StockItemName;
                materialComboBoxStockItem.DataSource = item.ToList();
                materialComboBoxStockItem.DisplayMember = "StockItem";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Stock Items: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void btnCreateStockItem_Click(object sender, EventArgs e)
        {
            string stockItemName = materialComboBoxStockItem.Text.Trim();
            string quantity = materialTextBoxQuantityReceived.Text.Trim();
            string balance = quantity;
            DateOnly receivedDate = DateOnly.FromDateTime(DateTime.Now);
            DateOnly expiryDate = DateOnly.FromDateTime(dateTimePickerExpiryDate.Value);

            ClearErrorLabels();

            ValidateReceivedStockItem(stockItemName);
            ValidateQuantityReceived(quantity);

            if (!_isDataValid)
            {
                MessageBox.Show(
                    "You have some invalid inputs.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                btnAddReceivedStock.Enabled = true;
                _isDataValid = true;
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                $"Do you want to add \"{stockItemName}\" as a new Received Stock?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.Yes)
            {
                btnAddReceivedStock.Enabled = false;
                AppDbContext dbContext = new();
                var stockItem = dbContext.StockItems.Where(st => st.StockItemName == materialComboBoxStockItem.Text).Single();

                try
                {
                    ReceivedStockService receivedStockService = new(dbContext);
                    receivedStockService.AddReceivedStock(receivedDate, int.Parse(quantity), int.Parse(balance),expiryDate, stockItem.Id);
                    MessageBox.Show(
                        $"Stock Item \"{stockItemName}\" is successfully created.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    ClearFormFields();
                }
                catch(Exception ex )
                {
                    MessageBox.Show(
                        "Unable to create Stock Item. Please try again."+ex,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
                finally
                {
                    dbContext.Dispose();
                    btnAddReceivedStock.Enabled = true;
                }
            }
        }

        private void materialTextBoxQuantityReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }
    }
}
