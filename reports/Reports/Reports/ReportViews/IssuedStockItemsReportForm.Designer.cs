namespace Reports.ReportViews
{
    partial class IssuedStockItemsReportForm
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
            this.reportViewerIsuuedStockItems = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerIsuuedStockItems
            // 
            this.reportViewerIsuuedStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerIsuuedStockItems.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.IssuedStockReport.rdlc";
            this.reportViewerIsuuedStockItems.Location = new System.Drawing.Point(0, 0);
            this.reportViewerIsuuedStockItems.Name = "reportViewerIsuuedStockItems";
            this.reportViewerIsuuedStockItems.ServerReport.BearerToken = null;
            this.reportViewerIsuuedStockItems.Size = new System.Drawing.Size(1078, 712);
            this.reportViewerIsuuedStockItems.TabIndex = 0;
            // 
            // IssuedStockItemsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 712);
            this.Controls.Add(this.reportViewerIsuuedStockItems);
            this.MaximizeBox = false;
            this.Name = "IssuedStockItemsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issued Stock Items Report ";
            this.Load += new System.EventHandler(this.IssuedStockItemsReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerIsuuedStockItems;
    }
}