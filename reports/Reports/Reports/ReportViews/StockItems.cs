using FPISReports.Datasets;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPISReports.ReportViews
{
    public partial class StockItems : Form
    {
        List<StockItemsReport> _stockItemReport;
        public StockItems(List<StockItemsReport> dataSource)
        {
            InitializeComponent();
            _stockItemReport = dataSource;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void StockItems_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Stock_Items_Dataset";
            _reportDataSource.Value = _stockItemReport;
            this.reportViewerStockItems.LocalReport.DataSources.Clear();
            this.reportViewerStockItems.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerStockItems.RefreshReport();
            this.reportViewerStockItems.RefreshReport();
        }
    }
}
