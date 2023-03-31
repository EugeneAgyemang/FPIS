namespace FPISReports.ReportViews
{
    partial class StockItems
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
            this.reportViewerStockItems = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerStockItems
            // 
            this.reportViewerStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerStockItems.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.StockItems.rdlc";
            this.reportViewerStockItems.Location = new System.Drawing.Point(0, 0);
            this.reportViewerStockItems.Name = "reportViewerStockItems";
            this.reportViewerStockItems.ServerReport.BearerToken = null;
            this.reportViewerStockItems.Size = new System.Drawing.Size(774, 653);
            this.reportViewerStockItems.TabIndex = 0;
            // 
            // StockItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 653);
            this.Controls.Add(this.reportViewerStockItems);
            this.Name = "StockItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Items";
            this.Load += new System.EventHandler(this.StockItems_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerStockItems;
    }
}