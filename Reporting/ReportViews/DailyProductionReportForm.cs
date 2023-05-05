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
    public partial class DailyProductionReportForm : Form
    {
        List<DailyProduction_Report> _dailyProductionReport;
        public DailyProductionReportForm(List<DailyProduction_Report> dataSource)
        {
            InitializeComponent();
            _dailyProductionReport = dataSource;
           
            
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void DailyProductionReportForm_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Daily_Production_Dataset";
            _reportDataSource.Value = _dailyProductionReport;
            this.reportViewerDailyProductionReport.LocalReport.DataSources.Clear();
            this.reportViewerDailyProductionReport.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerDailyProductionReport.RefreshReport();
        }
    }
}
