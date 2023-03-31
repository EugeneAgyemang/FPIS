using FPISReports.Datasets;
using Microsoft.Reporting.WinForms;
using Reports.Datasets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.ReportViews
{
    public partial class ReceivedStockReport : Form
    {
        List<Received_Stock> _receivedStockReport;
        public ReceivedStockReport(List<Received_Stock> dataSource)
        {
            InitializeComponent();
            _receivedStockReport = dataSource;
        }
        
        ReportDataSource _reportDataSource = new ReportDataSource();
        private void ReceivedStock_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Received_Stock_Dataset";
            _reportDataSource.Value = _receivedStockReport;
            this.reportViewerReceivedStock.LocalReport.DataSources.Clear();
            this.reportViewerReceivedStock.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerReceivedStock.RefreshReport();
        }
    }
}
