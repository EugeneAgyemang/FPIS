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
    public partial class IssuedStockItemsReportForm : Form
    {
        List<Issued_Stocks> _issuedStockItems;
        public IssuedStockItemsReportForm(List<Issued_Stocks> dataSource)
        {
            InitializeComponent();
            _issuedStockItems= dataSource;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void IssuedStockItemsReportForm_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Issued_Stock_Dataset";
            _reportDataSource.Value = _issuedStockItems;
            this.reportViewerIsuuedStockItems.LocalReport.DataSources.Clear();
            this.reportViewerIsuuedStockItems.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerIsuuedStockItems.RefreshReport();
        }
    }
}
