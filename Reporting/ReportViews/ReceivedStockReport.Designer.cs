namespace Reporting.ReportViews
{
    partial class ReceivedStockReport
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
            this.reportViewerReceivedStock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerReceivedStock
            // 
            this.reportViewerReceivedStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerReceivedStock.LocalReport.ReportEmbeddedResource = "Reporting.RDLCReports.ReceivedStocks.rdlc";
            this.reportViewerReceivedStock.Location = new System.Drawing.Point(0, 0);
            this.reportViewerReceivedStock.Name = "reportViewerReceivedStock";
            this.reportViewerReceivedStock.ServerReport.BearerToken = null;
            this.reportViewerReceivedStock.Size = new System.Drawing.Size(991, 654);
            this.reportViewerReceivedStock.TabIndex = 0;
            // 
            // ReceivedStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 654);
            this.Controls.Add(this.reportViewerReceivedStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceivedStockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Received Stock Report";
            this.Load += new System.EventHandler(this.ReceivedStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReceivedStock;
    }
}