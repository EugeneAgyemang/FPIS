using Microsoft.Reporting.WinForms;
using Reporting.Datasets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporting.ReportViews
{
    public partial class ProductReportForm : Form
    {
        List<Product_Report> _productReport;
        public ProductReportForm(List<Product_Report> dataSource)
        {
            InitializeComponent();
            _productReport = dataSource;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Product_Report_Dataset";
            _reportDataSource.Value = _productReport;
            this.reportViewerProductReport.LocalReport.DataSources.Clear();
            this.reportViewerProductReport.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerProductReport.RefreshReport();
        }
    }
}
