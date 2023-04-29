namespace Reports.ReportViews
{
    partial class ProductReportForm
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
            this.reportViewerProductReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerProductReport
            // 
            this.reportViewerProductReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerProductReport.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.ProductReport.rdlc";
            this.reportViewerProductReport.Location = new System.Drawing.Point(0, 0);
            this.reportViewerProductReport.Name = "reportViewerProductReport";
            this.reportViewerProductReport.ServerReport.BearerToken = null;
            this.reportViewerProductReport.Size = new System.Drawing.Size(991, 666);
            this.reportViewerProductReport.TabIndex = 0;
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 666);
            this.Controls.Add(this.reportViewerProductReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProductReport;
    }
}