using FPIS.Models;
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
        public UserControlViewReceivedStocks()
        {
            InitializeComponent();
            LoadStockData();
        }

        private void LoadStockData()
        {
            try
            {
                AppDbContext dbContext = new();
                var itemsToIssue = from StockItem in dbContext.StockItems
                                   from ReceivedStock in dbContext.ReceivedStocks
                                   where StockItem.Id == ReceivedStock.StockItemId
                                   where ReceivedStock.QuantityAvailable > 0
                                   select new
                                   {
                                       itemName = StockItem.StockItemName,
                                       receivedDate = ReceivedStock.ReceivedDate,
                                       unit = StockItem.Unit,
                                       quantityReceived = ReceivedStock.Quantity,
                                       availableQuantity = ReceivedStock.QuantityAvailable,
                                       expiryDate = ReceivedStock.ExpiryDate,
                                       receivedStockID = ReceivedStock.Id
                                   };
                dataGridViewReceivedStock.Rows.Clear();
                foreach (var items in itemsToIssue)
                {
                    dataGridViewReceivedStock.Rows.Add(items.itemName, items.receivedDate, items.unit, items.quantityReceived, items.availableQuantity, items.expiryDate, items.receivedStockID);
                }
                dbContext.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Received Stocks: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void materialButtonPrintReceivedStock_Click(object sender, EventArgs e)
        {
            ReceivedStockForReport();
        }

        public void ReceivedStockForReport()
        {
            List<Received_Stock> received_Stocks = new List<Received_Stock>();
            received_Stocks.Clear();
            for (int i = 0; i <= dataGridViewReceivedStock.Rows.Count - 1; i++)
            {
                Received_Stock rstock = new Received_Stock
                {
                    ItemName = dataGridViewReceivedStock.Rows[i].Cells[0].Value.ToString(),
                    ReceivedDate = dataGridViewReceivedStock.Rows[i].Cells[1].Value.ToString(),
                    UnitOfMeasurement = dataGridViewReceivedStock.Rows[i].Cells[2].Value.ToString(),
                    QuantityReceived = int.Parse(dataGridViewReceivedStock.Rows[i].Cells[3].Value.ToString()),
                    AvailableQuantity = int.Parse(dataGridViewReceivedStock.Rows[i].Cells[4].Value.ToString()),
                    ExpiryDate = dataGridViewReceivedStock.Rows[i].Cells[5].Value.ToString(),
                };
                received_Stocks.Add(rstock);
            }
            ReceivedStockReport rst = new ReceivedStockReport(received_Stocks);
            rst.ShowDialog();

        }
    }
}
