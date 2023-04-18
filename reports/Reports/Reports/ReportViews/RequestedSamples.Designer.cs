namespace Reports.ReportViews
{
    partial class RequestedSamples
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
            this.reportViewerRequestedSamples = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerRequestedSamples
            // 
            this.reportViewerRequestedSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerRequestedSamples.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.RequestedSamples.rdlc";
            this.reportViewerRequestedSamples.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRequestedSamples.Name = "reportViewerRequestedSamples";
            this.reportViewerRequestedSamples.ServerReport.BearerToken = null;
            this.reportViewerRequestedSamples.Size = new System.Drawing.Size(1105, 769);
            this.reportViewerRequestedSamples.TabIndex = 0;
            // 
            // RequestedSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 769);
            this.Controls.Add(this.reportViewerRequestedSamples);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RequestedSamples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requested Samples";
            this.Load += new System.EventHandler(this.RequestedSamples_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRequestedSamples;
    }
}