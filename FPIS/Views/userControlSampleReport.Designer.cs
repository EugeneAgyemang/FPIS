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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            this.buttonResetRequestTypeFilter = new System.Windows.Forms.Button();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestedSamples)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(965, 88);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4);
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
            this.label3.Location = new System.Drawing.Point(311, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(344, 92);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerToDate.TabIndex = 46;
            // 
            // materialButtonSearchRequestedSample
            // 
            this.materialButtonSearchRequestedSample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchRequestedSample.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchRequestedSample.Depth = 0;
            this.materialButtonSearchRequestedSample.HighEmphasis = true;
            this.materialButtonSearchRequestedSample.Icon = null;
            this.materialButtonSearchRequestedSample.Location = new System.Drawing.Point(886, 88);
            this.materialButtonSearchRequestedSample.Margin = new System.Windows.Forms.Padding(4);
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
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(70, 92);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerFromDate.TabIndex = 43;
            // 
            // labelRequestedSampleCount
            // 
            this.labelRequestedSampleCount.AutoSize = true;
            this.labelRequestedSampleCount.Depth = 0;
            this.labelRequestedSampleCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRequestedSampleCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelRequestedSampleCount.HighEmphasis = true;
            this.labelRequestedSampleCount.Location = new System.Drawing.Point(79, 64);
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
            this.label2.Location = new System.Drawing.Point(557, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "List of Requested Samples";
            // 
            // dataGridViewRequestedSamples
            // 
            this.dataGridViewRequestedSamples.AllowUserToAddRows = false;
            this.dataGridViewRequestedSamples.AllowUserToDeleteRows = false;
            this.dataGridViewRequestedSamples.AllowUserToResizeColumns = false;
            this.dataGridViewRequestedSamples.AllowUserToResizeRows = false;
            this.dataGridViewRequestedSamples.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewRequestedSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestedSamples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestDate,
            this.RequestTime,
            this.Status,
            this.RequestType,
            this.Employee1,
            this.Employee2});
            this.dataGridViewRequestedSamples.Location = new System.Drawing.Point(65, 298);
            this.dataGridViewRequestedSamples.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRequestedSamples.Name = "dataGridViewRequestedSamples";
            this.dataGridViewRequestedSamples.ReadOnly = true;
            this.dataGridViewRequestedSamples.RowHeadersWidth = 51;
            this.dataGridViewRequestedSamples.RowTemplate.Height = 29;
            this.dataGridViewRequestedSamples.Size = new System.Drawing.Size(1073, 464);
            this.dataGridViewRequestedSamples.TabIndex = 40;
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "REQUEST DATE";
            this.RequestDate.MinimumWidth = 6;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            this.RequestDate.Width = 169;
            // 
            // RequestTime
            // 
            this.RequestTime.HeaderText = "REQUEST TIME";
            this.RequestTime.MinimumWidth = 6;
            this.RequestTime.Name = "RequestTime";
            this.RequestTime.ReadOnly = true;
            this.RequestTime.Width = 168;
            // 
            // Status
            // 
            this.Status.HeaderText = "STATUS";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 171;
            // 
            // RequestType
            // 
            this.RequestType.HeaderText = "REQUEST TYPE";
            this.RequestType.MinimumWidth = 6;
            this.RequestType.Name = "RequestType";
            this.RequestType.ReadOnly = true;
            this.RequestType.Width = 170;
            // 
            // Employee1
            // 
            this.Employee1.HeaderText = "REQUESTED BY";
            this.Employee1.MinimumWidth = 6;
            this.Employee1.Name = "Employee1";
            this.Employee1.ReadOnly = true;
            this.Employee1.Width = 171;
            // 
            // Employee2
            // 
            this.Employee2.HeaderText = "REQUESTED BY";
            this.Employee2.MinimumWidth = 6;
            this.Employee2.Name = "Employee2";
            this.Employee2.ReadOnly = true;
            this.Employee2.Width = 171;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
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
            this.materialButtonPrintRequestedSamples.Location = new System.Drawing.Point(1166, 736);
            this.materialButtonPrintRequestedSamples.Margin = new System.Windows.Forms.Padding(4);
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
            this.materialComboBoxRequestType.Location = new System.Drawing.Point(590, 82);
            this.materialComboBoxRequestType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxRequestType.MaxDropDownItems = 4;
            this.materialComboBoxRequestType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxRequestType.Name = "materialComboBoxRequestType";
            this.materialComboBoxRequestType.Size = new System.Drawing.Size(225, 49);
            this.materialComboBoxRequestType.StartIndex = 0;
            this.materialComboBoxRequestType.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelItemCategoryError);
            this.groupBox1.Controls.Add(this.materialComboBoxRequestType);
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialButtonSearchRequestedSample);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonResetRequestTypeFilter);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.SwitchCaptionControl);
            this.groupBox1.Controls.Add(this.SwitchFilterControl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Location = new System.Drawing.Point(65, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1073, 142);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // labelItemCategoryError
            // 
            this.labelItemCategoryError.AutoSize = true;
            this.labelItemCategoryError.Location = new System.Drawing.Point(590, 122);
            this.labelItemCategoryError.Name = "labelItemCategoryError";
            this.labelItemCategoryError.Size = new System.Drawing.Size(38, 15);
            this.labelItemCategoryError.TabIndex = 55;
            this.labelItemCategoryError.Text = "label5";
            // 
            // buttonResetRequestTypeFilter
            // 
            this.buttonResetRequestTypeFilter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonResetRequestTypeFilter.Image = global::FPIS.Properties.Resources.sync_dark;
            this.buttonResetRequestTypeFilter.Location = new System.Drawing.Point(815, 83);
            this.buttonResetRequestTypeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonResetRequestTypeFilter.Name = "buttonResetRequestTypeFilter";
            this.buttonResetRequestTypeFilter.Size = new System.Drawing.Size(43, 37);
            this.buttonResetRequestTypeFilter.TabIndex = 54;
            this.buttonResetRequestTypeFilter.UseVisualStyleBackColor = false;
            this.buttonResetRequestTypeFilter.Click += new System.EventHandler(this.buttonResetRequestTypeFilter_Click);
            // 
            // SwitchCaptionControl
            // 
            this.SwitchCaptionControl.AutoSize = true;
            this.SwitchCaptionControl.Depth = 0;
            this.SwitchCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchCaptionControl.Location = new System.Drawing.Point(30, 28);
            this.SwitchCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchCaptionControl.Name = "SwitchCaptionControl";
            this.SwitchCaptionControl.Size = new System.Drawing.Size(167, 17);
            this.SwitchCaptionControl.TabIndex = 53;
            this.SwitchCaptionControl.Text = "I\'m Searching by all Filters";
            // 
            // SwitchFilterControl
            // 
            this.SwitchFilterControl.AutoSize = true;
            this.SwitchFilterControl.Checked = true;
            this.SwitchFilterControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchFilterControl.Depth = 0;
            this.SwitchFilterControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwitchFilterControl.Location = new System.Drawing.Point(18, 46);
            this.SwitchFilterControl.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchFilterControl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchFilterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchFilterControl.Name = "SwitchFilterControl";
            this.SwitchFilterControl.Ripple = true;
            this.SwitchFilterControl.Size = new System.Drawing.Size(423, 37);
            this.SwitchFilterControl.TabIndex = 52;
            this.SwitchFilterControl.Text = "Turn Off Date filters to search only by Request Type";
            this.SwitchFilterControl.UseVisualStyleBackColor = true;
            this.SwitchFilterControl.CheckedChanged += new System.EventHandler(this.SwitchFilterControl_CheckedChanged);
            // 
            // userControlSampleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButtonPrintRequestedSamples);
            this.Controls.Add(this.labelRequestedSampleCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRequestedSamples);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "userControlSampleReport";
            this.Size = new System.Drawing.Size(1264, 818);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestedSamples)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label labelItemCategoryError;
        private Button buttonResetRequestTypeFilter;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
    }
}
