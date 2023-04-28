﻿namespace Reports.ReportViews
{
    partial class DailyProductionReportForm
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
            this.reportViewerDailyProductionReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerDailyProductionReport
            // 
            this.reportViewerDailyProductionReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerDailyProductionReport.LocalReport.ReportEmbeddedResource = "Reports.RDLCReports.DailyProductionReport.rdlc";
            this.reportViewerDailyProductionReport.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDailyProductionReport.Name = "reportViewerDailyProductionReport";
            this.reportViewerDailyProductionReport.ServerReport.BearerToken = null;
            this.reportViewerDailyProductionReport.Size = new System.Drawing.Size(1108, 683);
            this.reportViewerDailyProductionReport.TabIndex = 0;
            // 
            // DailyProductionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 683);
            this.Controls.Add(this.reportViewerDailyProductionReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DailyProductionReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Production Report";
            this.Load += new System.EventHandler(this.DailyProductionReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDailyProductionReport;
    }
}