namespace FPISReports.ReportViews
{
    partial class CertificateOfAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewerCertificateOfAnalysis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCertificateOfAnalysis
            // 
            this.reportViewerCertificateOfAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerCertificateOfAnalysis.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.CertificateOfAnalysis.rdlc";
            this.reportViewerCertificateOfAnalysis.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCertificateOfAnalysis.Name = "reportViewerCertificateOfAnalysis";
            this.reportViewerCertificateOfAnalysis.ServerReport.BearerToken = null;
            this.reportViewerCertificateOfAnalysis.Size = new System.Drawing.Size(991, 693);
            this.reportViewerCertificateOfAnalysis.TabIndex = 0;
            // 
            // CertificateOfAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 693);
            this.Controls.Add(this.reportViewerCertificateOfAnalysis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CertificateOfAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Of Analysis";
            this.Load += new System.EventHandler(this.CertificateOfAnalysis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCertificateOfAnalysis;
    }
}