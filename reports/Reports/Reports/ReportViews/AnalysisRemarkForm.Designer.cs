namespace Reports.ReportViews
{
    partial class AnalysisRemarkForm
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
            this.reportViewerAnalysisRemark = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerAnalysisRemark
            // 
            this.reportViewerAnalysisRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerAnalysisRemark.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.AnalysisRemark.rdlc";
            this.reportViewerAnalysisRemark.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAnalysisRemark.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.reportViewerAnalysisRemark.Name = "reportViewerAnalysisRemark";
            this.reportViewerAnalysisRemark.ServerReport.BearerToken = null;
            this.reportViewerAnalysisRemark.Size = new System.Drawing.Size(991, 596);
            this.reportViewerAnalysisRemark.TabIndex = 0;
            // 
            // AnalysisRemarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 596);
            this.Controls.Add(this.reportViewerAnalysisRemark);
            this.MaximizeBox = false;
            this.Name = "AnalysisRemarkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Remark";
            this.Load += new System.EventHandler(this.AnalysisRemarkForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnalysisRemark;
    }
}