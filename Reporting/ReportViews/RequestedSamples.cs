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
    public partial class RequestedSamples : Form
    {
        List<Requested_Samples> _requestedSamples;
        public RequestedSamples(List<Requested_Samples> dataSource)
        {
            InitializeComponent();
            _requestedSamples = dataSource;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void RequestedSamples_Load(object sender, EventArgs e)
        {
            _reportDataSource.Name = "Requested_Samples_Dataset";
            _reportDataSource.Value = _requestedSamples;
            this.reportViewerRequestedSamples.LocalReport.DataSources.Clear();
            this.reportViewerRequestedSamples.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerRequestedSamples.RefreshReport();
        }
    }
}
