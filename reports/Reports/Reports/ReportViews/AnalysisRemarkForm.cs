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
    public partial class AnalysisRemarkForm : Form
    {
        List<Analysis_Remark> _analysisRemark;
        public AnalysisRemarkForm(List<Analysis_Remark> dataSource)
        {
            InitializeComponent();
            _analysisRemark = dataSource;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();

        private void AnalysisRemarkForm_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Analysis_Remark_Dataset";
            _reportDataSource.Value = _analysisRemark;
            this.reportViewerAnalysisRemark.LocalReport.DataSources.Clear();
            this.reportViewerAnalysisRemark.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerAnalysisRemark.RefreshReport();
        }
    }
}
