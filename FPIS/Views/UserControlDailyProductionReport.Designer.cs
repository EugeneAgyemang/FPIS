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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDailyProductionReportError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDailyProductionReport = new System.Windows.Forms.TextBox();
            this.materialButtonCheckOut = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonCheckIn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonPrintDailyProductionReport = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewDailyProductionReport = new System.Windows.Forms.DataGridView();
            this.ProductionEngineer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButtonSearchDailyReport = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyProductionReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDailyProductionReportError);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDailyProductionReport);
            this.groupBox1.Controls.Add(this.materialButtonCheckOut);
            this.groupBox1.Controls.Add(this.materialButtonCheckIn);
            this.groupBox1.Location = new System.Drawing.Point(26, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1219, 185);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a New Production Report";
            // 
            // labelDailyProductionReportError
            // 
            this.labelDailyProductionReportError.AutoSize = true;
            this.labelDailyProductionReportError.Location = new System.Drawing.Point(521, 119);
            this.labelDailyProductionReportError.Name = "labelDailyProductionReportError";
            this.labelDailyProductionReportError.Size = new System.Drawing.Size(177, 15);
            this.labelDailyProductionReportError.TabIndex = 5;
            this.labelDailyProductionReportError.Text = "labelDailyProductionReportError";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Production Report";
            // 
            // textBoxDailyProductionReport
            // 
            this.textBoxDailyProductionReport.Location = new System.Drawing.Point(399, 36);
            this.textBoxDailyProductionReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDailyProductionReport.Multiline = true;
            this.textBoxDailyProductionReport.Name = "textBoxDailyProductionReport";
            this.textBoxDailyProductionReport.Size = new System.Drawing.Size(421, 82);
            this.textBoxDailyProductionReport.TabIndex = 2;
            // 
            // materialButtonCheckOut
            // 
            this.materialButtonCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCheckOut.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCheckOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCheckOut.Depth = 0;
            this.materialButtonCheckOut.HighEmphasis = true;
            this.materialButtonCheckOut.Icon = null;
            this.materialButtonCheckOut.Location = new System.Drawing.Point(612, 139);
            this.materialButtonCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonCheckOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCheckOut.Name = "materialButtonCheckOut";
            this.materialButtonCheckOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCheckOut.Size = new System.Drawing.Size(101, 36);
            this.materialButtonCheckOut.TabIndex = 1;
            this.materialButtonCheckOut.Text = "Check Out";
            this.materialButtonCheckOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCheckOut.UseAccentColor = true;
            this.materialButtonCheckOut.UseVisualStyleBackColor = true;
            this.materialButtonCheckOut.Click += new System.EventHandler(this.materialButtonCheckOut_Click);
            // 
            // materialButtonCheckIn
            // 
            this.materialButtonCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCheckIn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCheckIn.Depth = 0;
            this.materialButtonCheckIn.HighEmphasis = true;
            this.materialButtonCheckIn.Icon = null;
            this.materialButtonCheckIn.Location = new System.Drawing.Point(506, 139);
            this.materialButtonCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCheckIn.Name = "materialButtonCheckIn";
            this.materialButtonCheckIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCheckIn.Size = new System.Drawing.Size(98, 36);
            this.materialButtonCheckIn.TabIndex = 0;
            this.materialButtonCheckIn.Text = "   Check In   ";
            this.materialButtonCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCheckIn.UseAccentColor = true;
            this.materialButtonCheckIn.UseVisualStyleBackColor = true;
            this.materialButtonCheckIn.Click += new System.EventHandler(this.materialButtonCheckIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePickerToDate);
            this.groupBox2.Controls.Add(this.materialButtonPrintDailyProductionReport);
            this.groupBox2.Controls.Add(this.dataGridViewDailyProductionReport);
            this.groupBox2.Controls.Add(this.materialButtonSearchDailyReport);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox2.Location = new System.Drawing.Point(26, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1219, 386);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daily Production Report";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(934, 16);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(93, 36);
            this.materialButton1.TabIndex = 11;
            this.materialButton1.Text = "Show All";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(601, 23);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerToDate.TabIndex = 9;
            // 
            // materialButtonPrintDailyProductionReport
            // 
            this.materialButtonPrintDailyProductionReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintDailyProductionReport.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonPrintDailyProductionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonPrintDailyProductionReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintDailyProductionReport.Depth = 0;
            this.materialButtonPrintDailyProductionReport.HighEmphasis = true;
            this.materialButtonPrintDailyProductionReport.Icon = null;
            this.materialButtonPrintDailyProductionReport.Location = new System.Drawing.Point(577, 344);
            this.materialButtonPrintDailyProductionReport.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonPrintDailyProductionReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintDailyProductionReport.Name = "materialButtonPrintDailyProductionReport";
            this.materialButtonPrintDailyProductionReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintDailyProductionReport.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintDailyProductionReport.TabIndex = 8;
            this.materialButtonPrintDailyProductionReport.Text = "Print";
            this.materialButtonPrintDailyProductionReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintDailyProductionReport.UseAccentColor = true;
            this.materialButtonPrintDailyProductionReport.UseVisualStyleBackColor = true;
            this.materialButtonPrintDailyProductionReport.Click += new System.EventHandler(this.materialButtonPrintDailyProductionReport_Click);
            // 
            // dataGridViewDailyProductionReport
            // 
            this.dataGridViewDailyProductionReport.AllowUserToAddRows = false;
            this.dataGridViewDailyProductionReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDailyProductionReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyProductionReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductionEngineer,
            this.Date,
            this.TimeIn,
            this.TimeOut,
            this.ProductionReport});
            this.dataGridViewDailyProductionReport.Location = new System.Drawing.Point(44, 62);
            this.dataGridViewDailyProductionReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDailyProductionReport.Name = "dataGridViewDailyProductionReport";
            this.dataGridViewDailyProductionReport.ReadOnly = true;
            this.dataGridViewDailyProductionReport.RowHeadersWidth = 51;
            this.dataGridViewDailyProductionReport.RowTemplate.Height = 29;
            this.dataGridViewDailyProductionReport.Size = new System.Drawing.Size(1131, 275);
            this.dataGridViewDailyProductionReport.TabIndex = 7;
            // 
            // ProductionEngineer
            // 
            this.ProductionEngineer.FillWeight = 88.68444F;
            this.ProductionEngineer.HeaderText = "Production Engineer";
            this.ProductionEngineer.MinimumWidth = 6;
            this.ProductionEngineer.Name = "ProductionEngineer";
            this.ProductionEngineer.ReadOnly = true;
            this.ProductionEngineer.Width = 190;
            // 
            // Date
            // 
            this.Date.FillWeight = 70.59215F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 152;
            // 
            // TimeIn
            // 
            this.TimeIn.FillWeight = 73.73498F;
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.MinimumWidth = 6;
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            this.TimeIn.Width = 159;
            // 
            // TimeOut
            // 
            this.TimeOut.FillWeight = 53.47594F;
            this.TimeOut.HeaderText = "Time Out";
            this.TimeOut.MinimumWidth = 6;
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.Width = 114;
            // 
            // ProductionReport
            // 
            this.ProductionReport.FillWeight = 213.5125F;
            this.ProductionReport.HeaderText = "Production Report";
            this.ProductionReport.MinimumWidth = 6;
            this.ProductionReport.Name = "ProductionReport";
            this.ProductionReport.ReadOnly = true;
            this.ProductionReport.Width = 463;
            // 
            // materialButtonSearchDailyReport
            // 
            this.materialButtonSearchDailyReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchDailyReport.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchDailyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchDailyReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchDailyReport.Depth = 0;
            this.materialButtonSearchDailyReport.HighEmphasis = true;
            this.materialButtonSearchDailyReport.Icon = null;
            this.materialButtonSearchDailyReport.Location = new System.Drawing.Point(847, 16);
            this.materialButtonSearchDailyReport.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonSearchDailyReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchDailyReport.Name = "materialButtonSearchDailyReport";
            this.materialButtonSearchDailyReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchDailyReport.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchDailyReport.TabIndex = 6;
            this.materialButtonSearchDailyReport.Text = "Search";
            this.materialButtonSearchDailyReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchDailyReport.UseAccentColor = true;
            this.materialButtonSearchDailyReport.UseVisualStyleBackColor = true;
            this.materialButtonSearchDailyReport.Click += new System.EventHandler(this.materialButtonSearchDailyReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(247, 23);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerFromDate.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(25, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(211, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Daily Production Report";
            // 
            // UserControlDailyProductionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDailyProductionReport";
            this.Size = new System.Drawing.Size(1480, 704);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyProductionReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxDailyProductionReport;
        private MaterialSkin.Controls.MaterialButton materialButtonCheckOut;
        private MaterialSkin.Controls.MaterialButton materialButtonCheckIn;
        private Label label2;
        private Label labelDailyProductionReportError;
        private DataGridView dataGridViewDailyProductionReport;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchDailyReport;
        private Label label3;
        private DateTimePicker dateTimePickerFromDate;
        private DataGridViewTextBoxColumn ProductionEngineer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn TimeIn;
        private DataGridViewTextBoxColumn TimeOut;
        private DataGridViewTextBoxColumn ProductionReport;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintDailyProductionReport;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label4;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}
