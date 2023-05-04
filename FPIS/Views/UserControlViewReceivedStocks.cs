using FPIS.Models;
using FPIS.Services;
using FPISReports.Datasets;
using FPISReports.ReportViews;
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
    public partial class UserControlViewReceivedStocks : UserControl
    {
        int stocks;
        public bool _isDataValid = true;
        public UserControlViewReceivedStocks()
        {
            InitializeComponent();
            LoadStockData();
            LoadStockItemCategory();
            stockItemCount(stocks);
            materialComboBoxItemCategory.SelectedIndex = -1;

            labelItemCategoryError.ForeColor = System.Drawing.Color.Red;

            labelItemCategoryError.Text = "";
        }

        public void ValidateCategoryFilter(string itemCategory)
        {
            if (itemCategory.Length == 0)
            {
                labelItemCategoryError.Text = "Select an Item Category!";
                _isDataValid = false;
                return;
            }

        }

        public void ClearErrorLabels()
        {
            labelItemCategoryError.Text = "";
        }

        void stockItemCount(int totalStockItems)
        {
            if (totalStockItems == 0)
            {
                labelReceivedStockCount.Text = "No Stock Item Received yet";
            }
            else
            {
                labelReceivedStockCount.Text =
                    $"{totalStockItems} Stock Item{((totalStockItems > 1) ? "s" : "")} Received";
            }
        }

        public void ResetCategoryFilter()
        {
            materialComboBoxItemCategory.SelectedIndex = -1;
            materialComboBoxItemCategory.Focus();
        }

        private string LoadUserFullName(Guid id)
        {
            return new UserService(new()).GetFullName(id);
        }

        private string LoadStockItemName(Guid id)
        {
            return new StockItemService(new()).GetStockItemName(id);
        }

        private string LoadStockItemType(Guid id)
        {
            return new StockItemService(new()).GetStockItemType(id);
        }

        private void LoadStockItemCategory()
        {
            try
            {
                AppDbContext dbContext = new();
                var itemCategory = from StockItem in dbContext.StockItems
                                  select StockItem.StockItemType;
                materialComboBoxItemCategory.DataSource = itemCategory.Distinct().ToList();
                materialComboBoxItemCategory.DisplayMember = "StockItemType";
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Stock Item Type: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadStockData()
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var itemsToIssue = from StockItem in dbContext.StockItems
                                   from ReceivedStock in dbContext.ReceivedStocks
                                   where StockItem.Id == ReceivedStock.StockItemId
                                   orderby ReceivedStock.ReceivedDate
                                   //where ReceivedStock.QuantityAvailable > 0
                                   select new
                                   {
                                       stockItemID = ReceivedStock.StockItemId,
                                       receivedDate = ReceivedStock.ReceivedDate,
                                       unit = StockItem.Unit,
                                       quantityReceived = ReceivedStock.Quantity,
                                       availableQuantity = ReceivedStock.QuantityAvailable,
                                       expiryDate = ReceivedStock.ExpiryDate,
                                       receivedStockID = ReceivedStock.Id,
                                       userid = ReceivedStock.UserId
                                   };
                dataGridViewReceivedStock.Rows.Clear();
                foreach (var items in itemsToIssue)
                {
                    dataGridViewReceivedStock.Rows.Add(LoadStockItemName(items.stockItemID), LoadStockItemType(items.stockItemID), items.receivedDate, items.unit, 
                        items.quantityReceived, items.availableQuantity, items.expiryDate, 
                        LoadUserFullName(items.userid));
                }
                dbContext.Dispose();
                stocks = dataGridViewReceivedStock.Rows.Count;
                labelReceivedStockCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Received Stocks: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadStockDataByItemCategory(string itemCategory)
        {
            ClearErrorLabels();
            ValidateCategoryFilter(itemCategory);
            if (!_isDataValid)
            {
                _isDataValid = true;
                return;
            }
            try
            {
                AppDbContext dbContext = new();
                var itemsToIssue = from StockItem in dbContext.StockItems
                                   from ReceivedStock in dbContext.ReceivedStocks
                                   where StockItem.Id == ReceivedStock.StockItemId
                                   where StockItem.StockItemType == itemCategory
                                   orderby ReceivedStock.ReceivedDate
                                   //where ReceivedStock.QuantityAvailable > 0
                                   select new
                                   {
                                       stockItemID = ReceivedStock.StockItemId,
                                       receivedDate = ReceivedStock.ReceivedDate,
                                       unit = StockItem.Unit,
                                       quantityReceived = ReceivedStock.Quantity,
                                       availableQuantity = ReceivedStock.QuantityAvailable,
                                       expiryDate = ReceivedStock.ExpiryDate,
                                       receivedStockID = ReceivedStock.Id,
                                       userid = ReceivedStock.UserId
                                   };
                dataGridViewReceivedStock.Rows.Clear();
                foreach (var items in itemsToIssue)
                {
                    dataGridViewReceivedStock.Rows.Add(LoadStockItemName(items.stockItemID), LoadStockItemType(items.stockItemID), items.receivedDate, items.unit,
                        items.quantityReceived, items.availableQuantity, items.expiryDate,
                        LoadUserFullName(items.userid));
                }
                dbContext.Dispose();
                stocks = dataGridViewReceivedStock.Rows.Count;
                labelReceivedStockCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Received Stocks: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadStockDataPerDate(DateOnly fromDate, DateOnly toDate)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var itemsToIssue = from StockItem in dbContext.StockItems
                                   from ReceivedStock in dbContext.ReceivedStocks
                                   where StockItem.Id == ReceivedStock.StockItemId
                                   where ReceivedStock.ReceivedDate >= fromDate && ReceivedStock.ReceivedDate <= toDate
                                   orderby ReceivedStock.ReceivedDate
                                   //where ReceivedStock.QuantityAvailable > 0
                                   select new
                                   {
                                       stockItemID = ReceivedStock.StockItemId,
                                       receivedDate = ReceivedStock.ReceivedDate,
                                       unit = StockItem.Unit,
                                       quantityReceived = ReceivedStock.Quantity,
                                       availableQuantity = ReceivedStock.QuantityAvailable,
                                       expiryDate = ReceivedStock.ExpiryDate,
                                       receivedStockID = ReceivedStock.Id,
                                       userid = ReceivedStock.UserId
                                   };
                dataGridViewReceivedStock.Rows.Clear();
                foreach (var items in itemsToIssue)
                {
                    dataGridViewReceivedStock.Rows.Add(LoadStockItemName(items.stockItemID), LoadStockItemType(items.stockItemID), items.receivedDate, items.unit,
                        items.quantityReceived, items.availableQuantity, items.expiryDate,
                        LoadUserFullName(items.userid));
                }
                dbContext.Dispose();
                stocks = dataGridViewReceivedStock.Rows.Count;
                labelReceivedStockCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Received Stocks: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadStockDataPerDateAndCategory(DateOnly fromDate, DateOnly toDate, string itemCategory)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var itemsToIssue = from StockItem in dbContext.StockItems
                                   from ReceivedStock in dbContext.ReceivedStocks
                                   where StockItem.Id == ReceivedStock.StockItemId
                                   where ReceivedStock.ReceivedDate >= fromDate && ReceivedStock.ReceivedDate <= toDate && StockItem.StockItemType == itemCategory   
                                   orderby ReceivedStock.ReceivedDate
                                   //where ReceivedStock.QuantityAvailable > 0
                                   select new
                                   {
                                       stockItemID = ReceivedStock.StockItemId,
                                       receivedDate = ReceivedStock.ReceivedDate,
                                       unit = StockItem.Unit,
                                       quantityReceived = ReceivedStock.Quantity,
                                       availableQuantity = ReceivedStock.QuantityAvailable,
                                       expiryDate = ReceivedStock.ExpiryDate,
                                       receivedStockID = ReceivedStock.Id,
                                       userid = ReceivedStock.UserId
                                   };
                dataGridViewReceivedStock.Rows.Clear();
                foreach (var items in itemsToIssue)
                {
                    dataGridViewReceivedStock.Rows.Add(LoadStockItemName(items.stockItemID), LoadStockItemType(items.stockItemID), items.receivedDate, items.unit,
                        items.quantityReceived, items.availableQuantity, items.expiryDate,
                        LoadUserFullName(items.userid));
                }
                dbContext.Dispose();
                stocks = dataGridViewReceivedStock.Rows.Count;
                labelReceivedStockCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Received Stocks: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void materialButtonPrintReceivedStock_Click(object sender, EventArgs e)
        {
            ReceivedStockForReport();
        }

        public void ReceivedStockForReport()
        {
            List<Received_Stock_Items> received_Stocks = new List<Received_Stock_Items>();
            received_Stocks.Clear();
            for (int i = 0; i <= dataGridViewReceivedStock.Rows.Count - 1; i++)
            {
                Received_Stock_Items rstock = new Received_Stock_Items
                {
                    ItemName = dataGridViewReceivedStock.Rows[i].Cells[0].Value.ToString(),
                    ItemCategory= dataGridViewReceivedStock.Rows[i].Cells[1].Value.ToString(),
                    ReceivedDate = dataGridViewReceivedStock.Rows[i].Cells[2].Value.ToString(),
                    UnitOfMeasurement = dataGridViewReceivedStock.Rows[i].Cells[3].Value.ToString(),
                    QuantityReceived = int.Parse(dataGridViewReceivedStock.Rows[i].Cells[4].Value.ToString()),
                    AvailableQuantity = int.Parse(dataGridViewReceivedStock.Rows[i].Cells[5].Value.ToString()),
                    ExpiryDate = dataGridViewReceivedStock.Rows[i].Cells[6].Value.ToString(),
                    ReceivedBy = dataGridViewReceivedStock.Rows[i].Cells[7].Value.ToString()
                };
                received_Stocks.Add(rstock);
            }
            ReceivedStockReport rst = new ReceivedStockReport(received_Stocks);
            rst.ShowDialog();

        }
        private void ToggleSwitchDate(bool isCalledElsedWhere = false)
        {
            string[] captions = { "Turn Off Date filters to search only by Item Category", "Turn On Date filters to search with all Filters" };
            string[] switchDateCaptions = { "I'm Searching by all Filters", "I'm searching only by Item Category" };
            string captionOfSwitchDateControl = SwitchFilterControl.Text;
            if (captionOfSwitchDateControl == captions[1] || isCalledElsedWhere)
            {
                SwitchFilterControl.Text = captions[0];
                SwitchCaptionControl.Text = switchDateCaptions[0];
                dateTimePickerFromDate.Enabled = true;
                dateTimePickerToDate.Enabled = true;
                return;
            }
            SwitchFilterControl.Text = captions[1];
            SwitchCaptionControl.Text = switchDateCaptions[1];
            dateTimePickerFromDate.Enabled = false;
            dateTimePickerToDate.Enabled = false;
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadStockData();
            stockItemCount(stocks);
        }

        private void SwitchFilterControl_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitchDate();
        }

        private void buttonResetCatrgotyFilter_Click(object sender, EventArgs e)
        {
            ResetCategoryFilter();
        }

        private void materialButtonSearchStockItems_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Enabled == false && dateTimePickerToDate.Enabled == false)
            {
                LoadStockDataByItemCategory(materialComboBoxItemCategory.Text);
            }
            else if (materialComboBoxItemCategory.Text == "")
            {
                LoadStockDataPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));

            }
            else
            {
                LoadStockDataPerDateAndCategory(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxItemCategory.Text);

            }
            stockItemCount(stocks);
        }
    }
}
