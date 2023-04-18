namespace FPIS.Views
{
    partial class userControlSampleReport
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
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonSearchRequestedSample = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelRequestedSampleCount = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRequestedSamples = new System.Windows.Forms.DataGridView();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonPrintRequestedSamples = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxRequestType = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestedSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(1215, 138);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 48;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = false;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(564, 145);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 46;
            // 
            // materialButtonSearchRequestedSample
            // 
            this.materialButtonSearchRequestedSample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchRequestedSample.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchRequestedSample.Depth = 0;
            this.materialButtonSearchRequestedSample.HighEmphasis = true;
            this.materialButtonSearchRequestedSample.Icon = null;
            this.materialButtonSearchRequestedSample.Location = new System.Drawing.Point(1124, 138);
            this.materialButtonSearchRequestedSample.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearchRequestedSample.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchRequestedSample.Name = "materialButtonSearchRequestedSample";
            this.materialButtonSearchRequestedSample.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchRequestedSample.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchRequestedSample.TabIndex = 45;
            this.materialButtonSearchRequestedSample.Text = "Search";
            this.materialButtonSearchRequestedSample.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchRequestedSample.UseAccentColor = false;
            this.materialButtonSearchRequestedSample.UseVisualStyleBackColor = true;
            this.materialButtonSearchRequestedSample.Click += new System.EventHandler(this.materialButtonSearchRequestedSample_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(251, 145);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 43;
            // 
            // labelRequestedSampleCount
            // 
            this.labelRequestedSampleCount.AutoSize = true;
            this.labelRequestedSampleCount.Depth = 0;
            this.labelRequestedSampleCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRequestedSampleCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelRequestedSampleCount.HighEmphasis = true;
            this.labelRequestedSampleCount.Location = new System.Drawing.Point(90, 85);
            this.labelRequestedSampleCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRequestedSampleCount.Name = "labelRequestedSampleCount";
            this.labelRequestedSampleCount.Size = new System.Drawing.Size(26, 17);
            this.labelRequestedSampleCount.TabIndex = 42;
            this.labelRequestedSampleCount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(637, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "List of Requested Samples";
            // 
            // dataGridViewRequestedSamples
            // 
            this.dataGridViewRequestedSamples.AllowUserToAddRows = false;
            this.dataGridViewRequestedSamples.AllowUserToDeleteRows = false;
            this.dataGridViewRequestedSamples.AllowUserToResizeColumns = false;
            this.dataGridViewRequestedSamples.AllowUserToResizeRows = false;
            this.dataGridViewRequestedSamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequestedSamples.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewRequestedSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestedSamples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestDate,
            this.RequestTime,
            this.Status,
            this.RequestType,
            this.Employee1,
            this.Employee2});
            this.dataGridViewRequestedSamples.Location = new System.Drawing.Point(195, 268);
            this.dataGridViewRequestedSamples.Name = "dataGridViewRequestedSamples";
            this.dataGridViewRequestedSamples.ReadOnly = true;
            this.dataGridViewRequestedSamples.RowHeadersWidth = 51;
            this.dataGridViewRequestedSamples.RowTemplate.Height = 29;
            this.dataGridViewRequestedSamples.Size = new System.Drawing.Size(1121, 619);
            this.dataGridViewRequestedSamples.TabIndex = 40;
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "REQUEST DATE";
            this.RequestDate.MinimumWidth = 6;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            // 
            // RequestTime
            // 
            this.RequestTime.HeaderText = "REQUEST TIME";
            this.RequestTime.MinimumWidth = 6;
            this.RequestTime.Name = "RequestTime";
            this.RequestTime.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // RequestType
            // 
            this.RequestType.HeaderText = "REQUEST TYPE";
            this.RequestType.MinimumWidth = 6;
            this.RequestType.Name = "RequestType";
            this.RequestType.ReadOnly = true;
            // 
            // Employee1
            // 
            this.Employee1.HeaderText = "REQUESTED BY";
            this.Employee1.MinimumWidth = 6;
            this.Employee1.Name = "Employee1";
            this.Employee1.ReadOnly = true;
            // 
            // Employee2
            // 
            this.Employee2.HeaderText = "REQUESTED BY";
            this.Employee2.MinimumWidth = 6;
            this.Employee2.Name = "Employee2";
            this.Employee2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 46);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sample Report";
            // 
            // materialButtonPrintRequestedSamples
            // 
            this.materialButtonPrintRequestedSamples.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintRequestedSamples.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintRequestedSamples.Depth = 0;
            this.materialButtonPrintRequestedSamples.HighEmphasis = true;
            this.materialButtonPrintRequestedSamples.Icon = null;
            this.materialButtonPrintRequestedSamples.Location = new System.Drawing.Point(1332, 851);
            this.materialButtonPrintRequestedSamples.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPrintRequestedSamples.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintRequestedSamples.Name = "materialButtonPrintRequestedSamples";
            this.materialButtonPrintRequestedSamples.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintRequestedSamples.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintRequestedSamples.TabIndex = 49;
            this.materialButtonPrintRequestedSamples.Text = "Print";
            this.materialButtonPrintRequestedSamples.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintRequestedSamples.UseAccentColor = false;
            this.materialButtonPrintRequestedSamples.UseVisualStyleBackColor = true;
            this.materialButtonPrintRequestedSamples.Click += new System.EventHandler(this.materialButtonPrintRequestedSamples_Click);
            // 
            // materialComboBoxRequestType
            // 
            this.materialComboBoxRequestType.AutoResize = false;
            this.materialComboBoxRequestType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxRequestType.Depth = 0;
            this.materialComboBoxRequestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxRequestType.DropDownHeight = 174;
            this.materialComboBoxRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxRequestType.DropDownWidth = 121;
            this.materialComboBoxRequestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxRequestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxRequestType.FormattingEnabled = true;
            this.materialComboBoxRequestType.Hint = "Search by Request Type";
            this.materialComboBoxRequestType.IntegralHeight = false;
            this.materialComboBoxRequestType.ItemHeight = 43;
            this.materialComboBoxRequestType.Location = new System.Drawing.Point(845, 133);
            this.materialComboBoxRequestType.MaxDropDownItems = 4;
            this.materialComboBoxRequestType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxRequestType.Name = "materialComboBoxRequestType";
            this.materialComboBoxRequestType.Size = new System.Drawing.Size(257, 49);
            this.materialComboBoxRequestType.StartIndex = 0;
            this.materialComboBoxRequestType.TabIndex = 50;
            // 
            // userControlSampleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialComboBoxRequestType);
            this.Controls.Add(this.materialButtonPrintRequestedSamples);
            this.Controls.Add(this.materialButtonShowAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.materialButtonSearchRequestedSample);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelRequestedSampleCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRequestedSamples);
            this.Controls.Add(this.label1);
            this.Name = "userControlSampleReport";
            this.Size = new System.Drawing.Size(1444, 924);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestedSamples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchRequestedSample;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private MaterialSkin.Controls.MaterialLabel labelRequestedSampleCount;
        private Label label2;
        private DataGridView dataGridViewRequestedSamples;
        private Label label1;
        private DataGridViewTextBoxColumn RequestDate;
        private DataGridViewTextBoxColumn RequestTime;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn RequestType;
        private DataGridViewTextBoxColumn Employee1;
        private DataGridViewTextBoxColumn Employee2;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintRequestedSamples;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxRequestType;
    }
}
