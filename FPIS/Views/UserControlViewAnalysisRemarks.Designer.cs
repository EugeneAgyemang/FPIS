namespace FPIS.Views
{
    partial class UserControlViewAnalysisRemarks
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
            this.buttonResetCatrgotyFilter = new System.Windows.Forms.PictureBox();
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSearchIssuedStock = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxAnalysisItemType = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonPrintAnalysisRemark = new MaterialSkin.Controls.MaterialButton();
            this.labelStockItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAnalysisRemarks = new System.Windows.Forms.DataGridView();
            this.AnalysisItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisRemarkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisRemarkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonResetCatrgotyFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysisRemarks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonResetCatrgotyFilter);
            this.groupBox1.Controls.Add(this.labelItemCategoryError);
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialButtonSearchIssuedStock);
            this.groupBox1.Controls.Add(this.materialComboBoxAnalysisItemType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.SwitchCaptionControl);
            this.groupBox1.Controls.Add(this.SwitchFilterControl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Location = new System.Drawing.Point(25, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1073, 142);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // buttonResetCatrgotyFilter
            // 
            this.buttonResetCatrgotyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetCatrgotyFilter.Image = global::FPIS.Properties.Resources.sync_dark;
            this.buttonResetCatrgotyFilter.Location = new System.Drawing.Point(821, 86);
            this.buttonResetCatrgotyFilter.Name = "buttonResetCatrgotyFilter";
            this.buttonResetCatrgotyFilter.Size = new System.Drawing.Size(25, 25);
            this.buttonResetCatrgotyFilter.TabIndex = 57;
            this.buttonResetCatrgotyFilter.TabStop = false;
            this.buttonResetCatrgotyFilter.Click += new System.EventHandler(this.buttonResetCatrgotyFilter_Click);
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
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(950, 79);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 38;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = true;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // materialButtonSearchIssuedStock
            // 
            this.materialButtonSearchIssuedStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchIssuedStock.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchIssuedStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchIssuedStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchIssuedStock.Depth = 0;
            this.materialButtonSearchIssuedStock.HighEmphasis = true;
            this.materialButtonSearchIssuedStock.Icon = null;
            this.materialButtonSearchIssuedStock.Location = new System.Drawing.Point(864, 79);
            this.materialButtonSearchIssuedStock.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonSearchIssuedStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchIssuedStock.Name = "materialButtonSearchIssuedStock";
            this.materialButtonSearchIssuedStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchIssuedStock.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchIssuedStock.TabIndex = 35;
            this.materialButtonSearchIssuedStock.Text = "Search";
            this.materialButtonSearchIssuedStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchIssuedStock.UseAccentColor = true;
            this.materialButtonSearchIssuedStock.UseVisualStyleBackColor = true;
            this.materialButtonSearchIssuedStock.Click += new System.EventHandler(this.materialButtonSearchIssuedStock_Click);
            // 
            // materialComboBoxAnalysisItemType
            // 
            this.materialComboBoxAnalysisItemType.AutoResize = false;
            this.materialComboBoxAnalysisItemType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxAnalysisItemType.Depth = 0;
            this.materialComboBoxAnalysisItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxAnalysisItemType.DropDownHeight = 174;
            this.materialComboBoxAnalysisItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxAnalysisItemType.DropDownWidth = 121;
            this.materialComboBoxAnalysisItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxAnalysisItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxAnalysisItemType.FormattingEnabled = true;
            this.materialComboBoxAnalysisItemType.Hint = "Search by Analysis Item Type";
            this.materialComboBoxAnalysisItemType.IntegralHeight = false;
            this.materialComboBoxAnalysisItemType.ItemHeight = 43;
            this.materialComboBoxAnalysisItemType.Location = new System.Drawing.Point(590, 71);
            this.materialComboBoxAnalysisItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxAnalysisItemType.MaxDropDownItems = 4;
            this.materialComboBoxAnalysisItemType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxAnalysisItemType.Name = "materialComboBoxAnalysisItemType";
            this.materialComboBoxAnalysisItemType.Size = new System.Drawing.Size(225, 49);
            this.materialComboBoxAnalysisItemType.StartIndex = 0;
            this.materialComboBoxAnalysisItemType.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(345, 88);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerToDate.TabIndex = 36;
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
            this.SwitchFilterControl.Size = new System.Drawing.Size(461, 37);
            this.SwitchFilterControl.TabIndex = 52;
            this.SwitchFilterControl.Text = "Turn Off Date filters to search only by Analysis Item Type";
            this.SwitchFilterControl.UseVisualStyleBackColor = true;
            this.SwitchFilterControl.CheckedChanged += new System.EventHandler(this.SwitchFilterControl_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(69, 89);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerFromDate.TabIndex = 33;
            // 
            // materialButtonPrintAnalysisRemark
            // 
            this.materialButtonPrintAnalysisRemark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintAnalysisRemark.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonPrintAnalysisRemark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonPrintAnalysisRemark.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintAnalysisRemark.Depth = 0;
            this.materialButtonPrintAnalysisRemark.HighEmphasis = true;
            this.materialButtonPrintAnalysisRemark.Icon = null;
            this.materialButtonPrintAnalysisRemark.Location = new System.Drawing.Point(547, 641);
            this.materialButtonPrintAnalysisRemark.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonPrintAnalysisRemark.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintAnalysisRemark.Name = "materialButtonPrintAnalysisRemark";
            this.materialButtonPrintAnalysisRemark.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintAnalysisRemark.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintAnalysisRemark.TabIndex = 61;
            this.materialButtonPrintAnalysisRemark.Text = "Print";
            this.materialButtonPrintAnalysisRemark.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintAnalysisRemark.UseAccentColor = true;
            this.materialButtonPrintAnalysisRemark.UseVisualStyleBackColor = true;
            this.materialButtonPrintAnalysisRemark.Click += new System.EventHandler(this.materialButtonPrintAnalysisRemark_Click);
            // 
            // labelStockItemCount
            // 
            this.labelStockItemCount.AutoSize = true;
            this.labelStockItemCount.Depth = 0;
            this.labelStockItemCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelStockItemCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelStockItemCount.HighEmphasis = true;
            this.labelStockItemCount.Location = new System.Drawing.Point(25, 62);
            this.labelStockItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStockItemCount.Name = "labelStockItemCount";
            this.labelStockItemCount.Size = new System.Drawing.Size(26, 17);
            this.labelStockItemCount.TabIndex = 60;
            this.labelStockItemCount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(490, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "List of Analysis Remarks";
            // 
            // dataGridViewAnalysisRemarks
            // 
            this.dataGridViewAnalysisRemarks.AllowUserToAddRows = false;
            this.dataGridViewAnalysisRemarks.AllowUserToDeleteRows = false;
            this.dataGridViewAnalysisRemarks.AllowUserToResizeRows = false;
            this.dataGridViewAnalysisRemarks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAnalysisRemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalysisRemarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnalysisItemName,
            this.AnalysisRemark,
            this.AnalysisRemarkDate,
            this.AnalysisRemarkTime,
            this.RemarkBy});
            this.dataGridViewAnalysisRemarks.Location = new System.Drawing.Point(43, 263);
            this.dataGridViewAnalysisRemarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAnalysisRemarks.Name = "dataGridViewAnalysisRemarks";
            this.dataGridViewAnalysisRemarks.ReadOnly = true;
            this.dataGridViewAnalysisRemarks.RowHeadersWidth = 51;
            this.dataGridViewAnalysisRemarks.RowTemplate.Height = 29;
            this.dataGridViewAnalysisRemarks.Size = new System.Drawing.Size(1073, 372);
            this.dataGridViewAnalysisRemarks.TabIndex = 58;
            // 
            // AnalysisItemName
            // 
            this.AnalysisItemName.HeaderText = "ANALYSIS ITEM";
            this.AnalysisItemName.MinimumWidth = 6;
            this.AnalysisItemName.Name = "AnalysisItemName";
            this.AnalysisItemName.ReadOnly = true;
            this.AnalysisItemName.Width = 205;
            // 
            // AnalysisRemark
            // 
            this.AnalysisRemark.HeaderText = "ANALYSIS REMARK";
            this.AnalysisRemark.MinimumWidth = 6;
            this.AnalysisRemark.Name = "AnalysisRemark";
            this.AnalysisRemark.ReadOnly = true;
            this.AnalysisRemark.Width = 204;
            // 
            // AnalysisRemarkDate
            // 
            this.AnalysisRemarkDate.HeaderText = "REMARK DATE";
            this.AnalysisRemarkDate.MinimumWidth = 6;
            this.AnalysisRemarkDate.Name = "AnalysisRemarkDate";
            this.AnalysisRemarkDate.ReadOnly = true;
            this.AnalysisRemarkDate.Width = 202;
            // 
            // AnalysisRemarkTime
            // 
            this.AnalysisRemarkTime.HeaderText = "REMARK TIME";
            this.AnalysisRemarkTime.MinimumWidth = 4;
            this.AnalysisRemarkTime.Name = "AnalysisRemarkTime";
            this.AnalysisRemarkTime.ReadOnly = true;
            this.AnalysisRemarkTime.Width = 205;
            // 
            // RemarkBy
            // 
            this.RemarkBy.HeaderText = "REMARK BY";
            this.RemarkBy.MinimumWidth = 6;
            this.RemarkBy.Name = "RemarkBy";
            this.RemarkBy.ReadOnly = true;
            this.RemarkBy.Width = 204;
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
            this.materialLabel5.Size = new System.Drawing.Size(230, 24);
            this.materialLabel5.TabIndex = 63;
            this.materialLabel5.Text = "View Production Remarks";
            // 
            // UserControlViewAnalysisRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButtonPrintAnalysisRemark);
            this.Controls.Add(this.labelStockItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAnalysisRemarks);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlViewAnalysisRemarks";
            this.Size = new System.Drawing.Size(1158, 688);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonResetCatrgotyFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysisRemarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label labelItemCategoryError;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchIssuedStock;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxAnalysisItemType;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintAnalysisRemark;
        private MaterialSkin.Controls.MaterialLabel labelStockItemCount;
        private Label label2;
        private DataGridView dataGridViewAnalysisRemarks;
        private DataGridViewTextBoxColumn AnalysisItemName;
        private DataGridViewTextBoxColumn AnalysisRemark;
        private DataGridViewTextBoxColumn AnalysisRemarkDate;
        private DataGridViewTextBoxColumn AnalysisRemarkTime;
        private DataGridViewTextBoxColumn RemarkBy;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private PictureBox buttonResetCatrgotyFilter;
    }
}
