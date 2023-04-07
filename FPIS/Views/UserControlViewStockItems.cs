﻿using FPIS.Models;
using FPISReports.Datasets;
using FPISReports.ReportViews;
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

namespace FPIS.Views
{
    public partial class UserControlViewStockItems : UserControl
    {
        int stocks;
        public UserControlViewStockItems()
        {
            InitializeComponent();
            LoadStockItems();
            stockItemCount(stocks);
            
        }


        void stockItemCount(int totalStockItems)
        {
            if (totalStockItems == 0)
            {
                labelStockItemCount.Text = "No Stock Item yet";
            }
            else
            {
                labelStockItemCount.Text =
                    $"{totalStockItems} Stock Item{((totalStockItems > 1) ? "s" : "")} added";
            }
        }

        private void LoadStockItems()
        {
            try
            {
                AppDbContext dbContext = new();
                var stockItems = from StockItem in dbContext.StockItems
                                       select new
                                       {
                                           itemName = StockItem.StockItemName,
                                           unit = StockItem.Unit,
                                           itemType = StockItem.StockItemType
                                       };
                dataGridViewStockItems.Rows.Clear();
                foreach (var items in stockItems)
                {
                    dataGridViewStockItems.Rows.Add(items.itemName, items.unit, items.itemType);
                }
                dbContext.Dispose();
                stocks = dataGridViewStockItems.Rows.Count;
                labelStockItemCount.Text = stocks.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Loading Stock Items: {ex}");
                MaterialMessageBox.Show(ex.ToString());
            }
        }

        private void materialButtonPrintStockItems_Click(object sender, EventArgs e)
        {
            StockItemForReport();
        }

        public void StockItemForReport()
        {
            List<StockItemsReport> stock_Items = new List<StockItemsReport>();
            stock_Items.Clear();
            for (int i = 0; i <= dataGridViewStockItems.Rows.Count - 1; i++)
            {
                StockItemsReport stock = new StockItemsReport
                {
                    StockItemName = dataGridViewStockItems.Rows[i].Cells[0].Value.ToString(),
                    Unit = dataGridViewStockItems.Rows[i].Cells[1].Value.ToString(),
                    StockItemType = dataGridViewStockItems.Rows[i].Cells[2].Value.ToString(),

                };
                stock_Items.Add(stock);
            }
            StockItems st = new StockItems(stock_Items);
            st.ShowDialog();

        }
    }
}