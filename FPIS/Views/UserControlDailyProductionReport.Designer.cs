namespace FPIS.Views
{
    partial class UserControlDailyProductionReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButtonAddReport = new MaterialSkin.Controls.MaterialButton();
            this.textBoxDailyProductionReport = new System.Windows.Forms.TextBox();
            this.materialButtonCheckOut = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCheckIn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDailyProductionReportError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Daily Production Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDailyProductionReportError);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.materialButtonAddReport);
            this.groupBox1.Controls.Add(this.textBoxDailyProductionReport);
            this.groupBox1.Controls.Add(this.materialButtonCheckOut);
            this.groupBox1.Controls.Add(this.materialButtonCheckIn);
            this.groupBox1.Location = new System.Drawing.Point(64, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1540, 247);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a New Production Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Production Report";
            // 
            // materialButtonAddReport
            // 
            this.materialButtonAddReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddReport.Depth = 0;
            this.materialButtonAddReport.HighEmphasis = true;
            this.materialButtonAddReport.Icon = null;
            this.materialButtonAddReport.Location = new System.Drawing.Point(1089, 142);
            this.materialButtonAddReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddReport.Name = "materialButtonAddReport";
            this.materialButtonAddReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddReport.Size = new System.Drawing.Size(109, 36);
            this.materialButtonAddReport.TabIndex = 3;
            this.materialButtonAddReport.Text = "Add Report";
            this.materialButtonAddReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddReport.UseAccentColor = false;
            this.materialButtonAddReport.UseVisualStyleBackColor = true;
            // 
            // textBoxDailyProductionReport
            // 
            this.textBoxDailyProductionReport.Location = new System.Drawing.Point(563, 70);
            this.textBoxDailyProductionReport.Multiline = true;
            this.textBoxDailyProductionReport.Name = "textBoxDailyProductionReport";
            this.textBoxDailyProductionReport.Size = new System.Drawing.Size(481, 108);
            this.textBoxDailyProductionReport.TabIndex = 2;
            // 
            // materialButtonCheckOut
            // 
            this.materialButtonCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCheckOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCheckOut.Depth = 0;
            this.materialButtonCheckOut.HighEmphasis = true;
            this.materialButtonCheckOut.Icon = null;
            this.materialButtonCheckOut.Location = new System.Drawing.Point(404, 134);
            this.materialButtonCheckOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCheckOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCheckOut.Name = "materialButtonCheckOut";
            this.materialButtonCheckOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCheckOut.Size = new System.Drawing.Size(101, 36);
            this.materialButtonCheckOut.TabIndex = 1;
            this.materialButtonCheckOut.Text = "Check Out";
            this.materialButtonCheckOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCheckOut.UseAccentColor = false;
            this.materialButtonCheckOut.UseVisualStyleBackColor = true;
            // 
            // materialButtonCheckIn
            // 
            this.materialButtonCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCheckIn.Depth = 0;
            this.materialButtonCheckIn.HighEmphasis = true;
            this.materialButtonCheckIn.Icon = null;
            this.materialButtonCheckIn.Location = new System.Drawing.Point(404, 72);
            this.materialButtonCheckIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCheckIn.Name = "materialButtonCheckIn";
            this.materialButtonCheckIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCheckIn.Size = new System.Drawing.Size(98, 36);
            this.materialButtonCheckIn.TabIndex = 0;
            this.materialButtonCheckIn.Text = "   Check In   ";
            this.materialButtonCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCheckIn.UseAccentColor = false;
            this.materialButtonCheckIn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(64, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1540, 481);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daily Production Report";
            // 
            // labelDailyProductionReportError
            // 
            this.labelDailyProductionReportError.AutoSize = true;
            this.labelDailyProductionReportError.Location = new System.Drawing.Point(563, 181);
            this.labelDailyProductionReportError.Name = "labelDailyProductionReportError";
            this.labelDailyProductionReportError.Size = new System.Drawing.Size(225, 20);
            this.labelDailyProductionReportError.TabIndex = 5;
            this.labelDailyProductionReportError.Text = "labelDailyProductionReportError";
            // 
            // UserControlDailyProductionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlDailyProductionReport";
            this.Size = new System.Drawing.Size(1692, 939);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButtonAddReport;
        private TextBox textBoxDailyProductionReport;
        private MaterialSkin.Controls.MaterialButton materialButtonCheckOut;
        private MaterialSkin.Controls.MaterialButton materialButtonCheckIn;
        private Label label2;
        private Label labelDailyProductionReportError;
    }
}
