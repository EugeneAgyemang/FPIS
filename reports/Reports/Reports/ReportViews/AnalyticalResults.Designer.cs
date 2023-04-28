namespace Reports.ReportViews
{
    partial class AnalyticalResults
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
            this.reportViewerAnalyticalResult = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerAnalyticalResult
            // 
            this.reportViewerAnalyticalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerAnalyticalResult.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.AnalyticalResults.rdlc";
            this.reportViewerAnalyticalResult.Location = new System.Drawing.Point(0, 0);
            this.reportViewerAnalyticalResult.Name = "reportViewerAnalyticalResult";
            this.reportViewerAnalyticalResult.ServerReport.BearerToken = null;
            this.reportViewerAnalyticalResult.Size = new System.Drawing.Size(803, 696);
            this.reportViewerAnalyticalResult.TabIndex = 0;
            // 
            // AnalyticalResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 696);
            this.Controls.Add(this.reportViewerAnalyticalResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnalyticalResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytical Results ";
            this.Load += new System.EventHandler(this.AnalyticalResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnalyticalResult;
    }
}