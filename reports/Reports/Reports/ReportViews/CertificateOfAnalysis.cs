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
    public partial class CertificateOfAnalysis : Form
    {
        string _date, _consignee, _productType, _batchNumber, _containerNumber, _sealNumber, _quantity;
        List<Certificate_Of_Analysis> _certificates;
        public CertificateOfAnalysis(List<Certificate_Of_Analysis> dataSource,string date, string consignee, string productType, string batchNumber, string containerNumber, string sealNumber, string quantity)
        {
            InitializeComponent();
            _certificates = dataSource;
            _date = date;
            _consignee = consignee;
            _productType = productType;
            _batchNumber = batchNumber;
            _containerNumber = containerNumber;
            _sealNumber = sealNumber;
            _quantity = quantity;
        }

        ReportDataSource _reportDataSource = new ReportDataSource();
        private void CertificateOfAnalysis_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date),
                new Microsoft.Reporting.WinForms.ReportParameter("pConsignee",_consignee),
                new Microsoft.Reporting.WinForms.ReportParameter("pProductType",_productType),
                new Microsoft.Reporting.WinForms.ReportParameter("pBatchNumber",_batchNumber),
                new Microsoft.Reporting.WinForms.ReportParameter("pContainerNumber",_containerNumber),
                new Microsoft.Reporting.WinForms.ReportParameter("pSealNumber",_sealNumber),
                new Microsoft.Reporting.WinForms.ReportParameter("pQuantity",_quantity)
            };
            reportViewerCertificateOfAnalysis.LocalReport.SetParameters(para);
            _reportDataSource.Name = "Analysis_Result_Dataset";
            _reportDataSource.Value = _certificates;
            this.reportViewerCertificateOfAnalysis.LocalReport.DataSources.Clear();
            this.reportViewerCertificateOfAnalysis.LocalReport.DataSources.Add(_reportDataSource);
            this.reportViewerCertificateOfAnalysis.RefreshReport();
            this.reportViewerCertificateOfAnalysis.RefreshReport();
        }
    }
}