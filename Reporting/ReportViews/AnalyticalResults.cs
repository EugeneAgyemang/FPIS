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
    public partial class AnalyticalResults : Form
    {
        string _analysisItemName, _analysisRequestDate, _analysisRequestTime, _analysisResultDate, _analysisResultTime;
        List<Analytical_Results> _analyticalResult;
        public AnalyticalResults(List<Analytical_Results> dataSource, string analysisItemName, string analysisRequestDate, string analysisRequestTime, string analysisResultDate, string analysisResultTime)
        {
            InitializeComponent();
            _analyticalResult = dataSource;
            _analysisItemName = analysisItemName;
            _analysisRequestDate = analysisRequestDate;
            _analysisRequestTime = analysisRequestTime;
            _analysisResultDate = analysisResultDate;
            _analysisResultTime = analysisResultTime;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void AnalyticalResults_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("AnalysisItemName",_analysisItemName),
                new Microsoft.Reporting.WinForms.ReportParameter("AnalysisRequestDate",_analysisRequestDate),
                new Microsoft.Reporting.WinForms.ReportParameter("AnalysisRequestTime",_analysisRequestTime),
                new Microsoft.Reporting.WinForms.ReportParameter("AnalysisResultDate",_analysisResultDate),
                new Microsoft.Reporting.WinForms.ReportParameter("AnalysisResultTime",_analysisResultTime)
            };
            reportViewerAnalyticalResult.LocalReport.SetParameters(para);
            _reportDataSource.Name = "Analytical_Result_Dataset";
            _reportDataSource.Value = _analyticalResult;
            this.reportViewerAnalyticalResult.LocalReport.DataSources.Clear();
            this.reportViewerAnalyticalResult.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerAnalyticalResult.RefreshReport();
        }
    }
}
