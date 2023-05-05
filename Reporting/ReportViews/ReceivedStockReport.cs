using Reporting.Datasets;
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
using static System.Windows.Forms.AxHost;

namespace Reporting.ReportViews
{
    public partial class ReceivedStockReport : Form
    {
        List<Received_Stock_Items> _receivedStockReport;
        public ReceivedStockReport(List<Received_Stock_Items> dataSource)
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
