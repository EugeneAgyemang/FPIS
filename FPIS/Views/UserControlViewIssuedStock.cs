using FPIS.Models;
using FPIS.Services;
using Reporting.Datasets;
using Reporting.ReportViews;
using MaterialSkin.Controls;
using Reporting.Datasets;
using Reporting.ReportViews;
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
    public partial class UserControlViewIssuedStock : UserControl
    {
        int stocks;
        public bool _isDataValid = true;
        public UserControlViewIssuedStock()
        {
            InitializeComponent();
            LoadIssuedStocks();
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

        public void ResetCategoryFilter()
        {
            materialComboBoxItemCategory.SelectedIndex = -1;
            materialComboBoxItemCategory.Focus();
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

        void stockItemCount(int totalStockItems)
        {
            if (totalStockItems == 0)
            {
                labelStockItemCount.Text = "No Stock Item Issued yet";
            }
            else
            {
                labelStockItemCount.Text =
                    $"{totalStockItems} Stock Item{((totalStockItems > 1) ? "s" : "")} Issued";
            }
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

        private void LoadIssuedStocks()
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var issuedStocks = from IssuedStock in dbContext.IssuedStocks
                                   orderby IssuedStock.IssuedDate
                                 select new
                                 {
                                     stockItemId = IssuedStock.StockItemId,
                                     issuedDate = IssuedStock.IssuedDate,
                                     quantityIssued = IssuedStock.QuantityIssued,
                                     userId = IssuedStock.UserId
                                 };
                dataGridViewIssuedStockItems.Rows.Clear();
                foreach (var items in issuedStocks)
                {
                    dataGridViewIssuedStockItems.Rows.Add(LoadStockItemName(items.stockItemId),LoadStockItemType(items.stockItemId), 
                        items.issuedDate, items.quantityIssued,LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                stocks = dataGridViewIssuedStockItems.Rows.Count;
                labelStockItemCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadIssuedStocksByCategory(string itemCategory)
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
                var issuedStocks = from StockItem in dbContext.StockItems
                                   from IssuedStock in dbContext.IssuedStocks
                                   where StockItem.Id == IssuedStock.StockItemId
                                   where StockItem.StockItemType == itemCategory
                                   orderby IssuedStock.IssuedDate
                                   select new
                                   {
                                       stockItemId = IssuedStock.StockItemId,
                                       issuedDate = IssuedStock.IssuedDate,
                                       quantityIssued = IssuedStock.QuantityIssued,
                                       userId = IssuedStock.UserId
                                   };
                dataGridViewIssuedStockItems.Rows.Clear();
                foreach (var items in issuedStocks)
                {
                    dataGridViewIssuedStockItems.Rows.Add(LoadStockItemName(items.stockItemId), LoadStockItemType(items.stockItemId),
                        items.issuedDate, items.quantityIssued, LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                stocks = dataGridViewIssuedStockItems.Rows.Count;
                labelStockItemCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadIssuedStocksPerDate(DateOnly fromDate, DateOnly toDate)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var issuedStocks = from IssuedStock in dbContext.IssuedStocks
                                   where IssuedStock.IssuedDate >= fromDate && IssuedStock.IssuedDate <= toDate
                                   orderby IssuedStock.IssuedDate
                                   select new
                                   {
                                       stockItemId = IssuedStock.StockItemId,
                                       issuedDate = IssuedStock.IssuedDate,
                                       quantityIssued = IssuedStock.QuantityIssued,
                                       userId = IssuedStock.UserId
                                   };
                dataGridViewIssuedStockItems.Rows.Clear();
                foreach (var items in issuedStocks)
                {
                    dataGridViewIssuedStockItems.Rows.Add(LoadStockItemName(items.stockItemId), LoadStockItemType(items.stockItemId),
                        items.issuedDate, items.quantityIssued, LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                stocks = dataGridViewIssuedStockItems.Rows.Count;
                labelStockItemCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        private void LoadIssuedStocksPerDateAndCategory(DateOnly fromDate, DateOnly toDate, string itemCategory)
        {
            ClearErrorLabels();
            try
            {
                AppDbContext dbContext = new();
                var issuedStocks = from StockItem in dbContext.StockItems
                                   from IssuedStock in dbContext.IssuedStocks
                                   where StockItem.Id == IssuedStock.StockItemId
                                   where IssuedStock.IssuedDate >= fromDate && IssuedStock.IssuedDate <= toDate && StockItem.StockItemType == itemCategory
                                   orderby IssuedStock.IssuedDate
                                   select new
                                   {
                                       stockItemId = IssuedStock.StockItemId,
                                       issuedDate = IssuedStock.IssuedDate,
                                       quantityIssued = IssuedStock.QuantityIssued,
                                       userId = IssuedStock.UserId
                                   };
                dataGridViewIssuedStockItems.Rows.Clear();
                foreach (var items in issuedStocks)
                {
                    dataGridViewIssuedStockItems.Rows.Add(LoadStockItemName(items.stockItemId), LoadStockItemType(items.stockItemId),
                        items.issuedDate, items.quantityIssued, LoadUserFullName(items.userId));
                }
                dbContext.Dispose();
                stocks = dataGridViewIssuedStockItems.Rows.Count;
                labelStockItemCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Issued Stock Items: {ex}");
                Utils.Utils.ShowMessageBox(ex.ToString(), "Error Occured");
            }
        }

        public void IssuedStockItemForReport()
        {
            List<Issued_Stocks> issuedStock_Items = new List<Issued_Stocks>();
            issuedStock_Items.Clear();
            for (int i = 0; i <= dataGridViewIssuedStockItems.Rows.Count - 1; i++)
            {
                Issued_Stocks issuedStock = new Issued_Stocks
                {
                    ItemName = dataGridViewIssuedStockItems.Rows[i].Cells[0].Value.ToString(),
                    ItemCategory = dataGridViewIssuedStockItems.Rows[i].Cells[1].Value.ToString(),
                    IssuedDate = dataGridViewIssuedStockItems.Rows[i].Cells[2].Value.ToString(),
                    QuantityIssued = int.Parse(dataGridViewIssuedStockItems.Rows[i].Cells[3].Value.ToString()),
                    IssuedBy = dataGridViewIssuedStockItems.Rows[i].Cells[4].Value.ToString(),

                };
                issuedStock_Items.Add(issuedStock);
            }
            IssuedStockItemsReportForm st = new IssuedStockItemsReportForm(issuedStock_Items);
            st.ShowDialog();

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

        private void materialButtonPrintIssuedStockItems_Click(object sender, EventArgs e)
        {
            IssuedStockItemForReport();
        }

        private void materialButtonSearchIssuedStock_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Enabled == false && dateTimePickerToDate.Enabled == false)
            {
                LoadIssuedStocksByCategory(materialComboBoxItemCategory.Text);
            }
            else if (materialComboBoxItemCategory.Text == "")
            {
                LoadIssuedStocksPerDate(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text));

            }
            else
            {
                LoadIssuedStocksPerDateAndCategory(DateOnly.Parse(dateTimePickerFromDate.Text), DateOnly.Parse(dateTimePickerToDate.Text), materialComboBoxItemCategory.Text);

            }
            stockItemCount(stocks);
        }

        private void materialButtonShowAll_Click(object sender, EventArgs e)
        {
            LoadIssuedStocks();
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
    }
}
