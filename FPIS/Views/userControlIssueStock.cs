using FPIS.Models;
using FPIS.Services;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
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
    public partial class userControlIssueStock : UserControl
    {
        public bool _isDataValid = true;
        public userControlIssueStock()
        {
            InitializeComponent();
            labelQuantityToIssueError.ForeColor = System.Drawing.Color.Red;

            labelQuantityToIssueError.Text = "";
            materialButtonIssueStock.Enabled = false;
        }

        public void ClearErrorLabels()
        {
            labelQuantityToIssueError.Text = "";
        }

        public void ClearFormFields()
        {
            materialTextBoxItemName.Text = "";
            materialTextBoxAvailableQuantity.Text = "";
            materialTextBoxQuantityToIssue.Text = "";
        }

        private void LoadStockType()
        {
            try
            {
                AppDbContext dbContext = new();
                var stockType = from  StockItem in dbContext.StockItems
                                     select StockItem.StockItemType;
                materialComboBoxStockType.DataSource = stockType.Distinct().ToList();
                materialComboBoxStockType.DisplayMember = "StockType";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Departments: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        public void ValidateQuantityToIssue(string quantityToIssue)
        {
            if (quantityToIssue.Length == 0)
            {
                labelQuantityToIssueError.Text = "Quantity to Issue is required!";
                _isDataValid = false;
                return;
            }
            if (int.Parse(quantityToIssue) == 0)
            {
                labelQuantityToIssueError.Text = "Quantity must be greater than 0";
                _isDataValid = false;
                return;
            }

        }

        private void LoadStockData()
        {
            try
            {
                AppDbContext dbContext = new();
                var itemsToIssue = from StockItem in dbContext.StockItems
                                   from ReceivedStock in dbContext.ReceivedStocks
                                   where StockItem.Id == ReceivedStock.StockItemId
                                   where StockItem.StockItemType.Equals(materialComboBoxStockType.Text)
                                   where ReceivedStock.QuantityAvailable > 0
                                   select new
                                   {
                                       itemName = StockItem.StockItemName,
                                       receivedDate = ReceivedStock.ReceivedDate,
                                       unit = StockItem.Unit,
                                       quantityReceived = ReceivedStock.Quantity,
                                       availableQuantity = ReceivedStock.QuantityAvailable,
                                       expiryDate= ReceivedStock.ExpiryDate,
                                       receivedStockID = ReceivedStock.Id
                                   };
                dataGridViewIssueStock.Rows.Clear();
                foreach(var items in itemsToIssue)
                {
                    dataGridViewIssueStock.Rows.Add(items.itemName,items.receivedDate,items.unit,items.quantityReceived,items.availableQuantity,items.expiryDate,items.receivedStockID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Stocks: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void userControlIssueStock_Load(object sender, EventArgs e)
        {
            LoadStockType();
            materialComboBoxStockType.SelectedIndex = -1;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(materialComboBoxStockType.Text.Length == 0)
            {
                MessageBox.Show(
                     "Select the type of Stock Item to Issue",
                     "Invalid Input",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                 );
            }
            else
            {
                LoadStockData();
                ClearFormFields();
            }
           
        }

        string StockID;
        private void dataGridViewIssueStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewIssueStock.CurrentRow.Selected = true;
                materialTextBoxItemName.Text = dataGridViewIssueStock.Rows[e.RowIndex].Cells["ItemName"].FormattedValue.ToString();
                materialTextBoxAvailableQuantity.Text = dataGridViewIssueStock.Rows[e.RowIndex].Cells["AvailableQuantity"].FormattedValue.ToString();
                StockID = dataGridViewIssueStock.Rows[e.RowIndex].Cells["ReceivedStockID"].FormattedValue.ToString();
                materialButtonIssueStock.Enabled = true;
            }
            catch(Exception ex)
            {

            }
        }

        private void materialTextBoxQuantityToIssue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.Utils.IsCharacterPressedHandled(e.KeyChar);
        }

        private void UpdateAvailableQuantity()
        {
            AppDbContext dbContext = new();
            try
            {
                var receivedItem = dbContext.ReceivedStocks.Where(rs => rs.Id == Guid.Parse(StockID)).Single();
                int updatedQuantityAvailable = int.Parse(materialTextBoxAvailableQuantity.Text.Trim()) - int.Parse(materialTextBoxQuantityToIssue.Text.Trim());
                receivedItem.QuantityAvailable = updatedQuantityAvailable;
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update available quantity. Please try again." + ex,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                dbContext.Dispose();
            }
        }

        private void materialButtonIssueStock_Click(object sender, EventArgs e)
        {
            string quantityToIssue = materialTextBoxQuantityToIssue.Text.Trim();
            DateOnly issuedDate = DateOnly.FromDateTime(DateTime.Now);
            

            ClearErrorLabels();
            ValidateQuantityToIssue(quantityToIssue);
            if(!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            if (int.Parse(quantityToIssue) > int.Parse(materialTextBoxAvailableQuantity.Text.Trim()))
            {
                MessageBox.Show(
                    "Quantity to Issue cannot be more than Available Quantity.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                materialButtonIssueStock.Enabled = true;

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Do you want to issue \"{materialTextBoxItemName.Text}\"?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (dialogResult == DialogResult.Yes)
                {
                    materialButtonIssueStock.Enabled = false;
                    AppDbContext dbContext = new();
                    var stockItem = dbContext.StockItems.Where(st => st.StockItemName == materialTextBoxItemName.Text).Single();
                    try
                    {
                        IssueStockService issueStockService = new(dbContext);
                        ReceivedStockService receivedStockService = new(dbContext);
                        issueStockService.AddIssuedStock(int.Parse(quantityToIssue), issuedDate, stockItem.Id, new Guid(Main.LOGGED_USER_ID));
                        UpdateAvailableQuantity();
                        LoadStockData();
                        MessageBox.Show(
                            $"Stock Item \"{materialTextBoxItemName.Text}\" is successfully issued.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        ClearFormFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Unable to issue Stock Item. Please try again." + ex,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                    finally
                    {
                        dbContext.Dispose();
                        materialButtonIssueStock.Enabled = true;
                    }
                }
            }

        }
    }
}
