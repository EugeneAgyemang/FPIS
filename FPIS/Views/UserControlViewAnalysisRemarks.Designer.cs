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
            groupBox1 = new GroupBox();
            buttonResetCatrgotyFilter = new PictureBox();
            labelItemCategoryError = new Label();
            materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            materialButtonSearchIssuedStock = new MaterialSkin.Controls.MaterialButton();
            materialComboBoxAnalysisItemType = new MaterialSkin.Controls.MaterialComboBox();
            label3 = new Label();
            dateTimePickerToDate = new DateTimePicker();
            SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            label4 = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            materialButtonPrintAnalysisRemark = new MaterialSkin.Controls.MaterialButton();
            labelStockItemCount = new MaterialSkin.Controls.MaterialLabel();
            label2 = new Label();
            dataGridViewAnalysisRemarks = new DataGridView();
            AnalysisItemName = new DataGridViewTextBoxColumn();
            AnalysisRemark = new DataGridViewTextBoxColumn();
            AnalysisRemarkDate = new DataGridViewTextBoxColumn();
            AnalysisRemarkTime = new DataGridViewTextBoxColumn();
            RemarkBy = new DataGridViewTextBoxColumn();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonResetCatrgotyFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalysisRemarks).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonResetCatrgotyFilter);
            groupBox1.Controls.Add(labelItemCategoryError);
            groupBox1.Controls.Add(materialButtonShowAll);
            groupBox1.Controls.Add(materialButtonSearchIssuedStock);
            groupBox1.Controls.Add(materialComboBoxAnalysisItemType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePickerToDate);
            groupBox1.Controls.Add(SwitchCaptionControl);
            groupBox1.Controls.Add(SwitchFilterControl);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerFromDate);
            groupBox1.Location = new Point(29, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1226, 189);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Filters";
            // 
            // buttonResetCatrgotyFilter
            // 
            buttonResetCatrgotyFilter.Cursor = Cursors.Hand;
            buttonResetCatrgotyFilter.Image = Properties.Resources.sync_dark;
            buttonResetCatrgotyFilter.Location = new Point(959, 105);
            buttonResetCatrgotyFilter.Margin = new Padding(3, 4, 3, 4);
            buttonResetCatrgotyFilter.Name = "buttonResetCatrgotyFilter";
            buttonResetCatrgotyFilter.Size = new Size(29, 33);
            buttonResetCatrgotyFilter.TabIndex = 57;
            buttonResetCatrgotyFilter.TabStop = false;
            buttonResetCatrgotyFilter.Click += buttonResetCatrgotyFilter_Click;
            // 
            // labelItemCategoryError
            // 
            labelItemCategoryError.AutoSize = true;
            labelItemCategoryError.Location = new Point(674, 163);
            labelItemCategoryError.Name = "labelItemCategoryError";
            labelItemCategoryError.Size = new Size(50, 20);
            labelItemCategoryError.TabIndex = 55;
            labelItemCategoryError.Text = "label5";
            // 
            // materialButtonShowAll
            // 
            materialButtonShowAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonShowAll.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonShowAll.Cursor = Cursors.Hand;
            materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonShowAll.Depth = 0;
            materialButtonShowAll.HighEmphasis = true;
            materialButtonShowAll.Icon = null;
            materialButtonShowAll.Location = new Point(1108, 105);
            materialButtonShowAll.Margin = new Padding(5, 5, 5, 5);
            materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonShowAll.Name = "materialButtonShowAll";
            materialButtonShowAll.NoAccentTextColor = Color.Empty;
            materialButtonShowAll.Size = new Size(93, 36);
            materialButtonShowAll.TabIndex = 38;
            materialButtonShowAll.Text = "Show All";
            materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonShowAll.UseAccentColor = true;
            materialButtonShowAll.UseVisualStyleBackColor = true;
            materialButtonShowAll.Click += materialButtonShowAll_Click;
            // 
            // materialButtonSearchIssuedStock
            // 
            materialButtonSearchIssuedStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSearchIssuedStock.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSearchIssuedStock.Cursor = Cursors.Hand;
            materialButtonSearchIssuedStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSearchIssuedStock.Depth = 0;
            materialButtonSearchIssuedStock.HighEmphasis = true;
            materialButtonSearchIssuedStock.Icon = null;
            materialButtonSearchIssuedStock.Location = new Point(1009, 105);
            materialButtonSearchIssuedStock.Margin = new Padding(5, 5, 5, 5);
            materialButtonSearchIssuedStock.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSearchIssuedStock.Name = "materialButtonSearchIssuedStock";
            materialButtonSearchIssuedStock.NoAccentTextColor = Color.Empty;
            materialButtonSearchIssuedStock.Size = new Size(78, 36);
            materialButtonSearchIssuedStock.TabIndex = 35;
            materialButtonSearchIssuedStock.Text = "Search";
            materialButtonSearchIssuedStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSearchIssuedStock.UseAccentColor = true;
            materialButtonSearchIssuedStock.UseVisualStyleBackColor = true;
            materialButtonSearchIssuedStock.Click += materialButtonSearchIssuedStock_Click;
            // 
            // materialComboBoxAnalysisItemType
            // 
            materialComboBoxAnalysisItemType.AutoResize = false;
            materialComboBoxAnalysisItemType.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxAnalysisItemType.Depth = 0;
            materialComboBoxAnalysisItemType.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxAnalysisItemType.DropDownHeight = 174;
            materialComboBoxAnalysisItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxAnalysisItemType.DropDownWidth = 121;
            materialComboBoxAnalysisItemType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxAnalysisItemType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxAnalysisItemType.FormattingEnabled = true;
            materialComboBoxAnalysisItemType.Hint = "Search by Analysis Item Type";
            materialComboBoxAnalysisItemType.IntegralHeight = false;
            materialComboBoxAnalysisItemType.ItemHeight = 43;
            materialComboBoxAnalysisItemType.Location = new Point(674, 95);
            materialComboBoxAnalysisItemType.MaxDropDownItems = 4;
            materialComboBoxAnalysisItemType.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxAnalysisItemType.Name = "materialComboBoxAnalysisItemType";
            materialComboBoxAnalysisItemType.Size = new Size(257, 49);
            materialComboBoxAnalysisItemType.StartIndex = 0;
            materialComboBoxAnalysisItemType.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 120);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 37;
            label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(394, 117);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(250, 27);
            dateTimePickerToDate.TabIndex = 36;
            // 
            // SwitchCaptionControl
            // 
            SwitchCaptionControl.AutoSize = true;
            SwitchCaptionControl.Depth = 0;
            SwitchCaptionControl.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            SwitchCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            SwitchCaptionControl.Location = new Point(34, 37);
            SwitchCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            SwitchCaptionControl.Name = "SwitchCaptionControl";
            SwitchCaptionControl.Size = new Size(167, 17);
            SwitchCaptionControl.TabIndex = 53;
            SwitchCaptionControl.Text = "I'm Searching by all Filters";
            // 
            // SwitchFilterControl
            // 
            SwitchFilterControl.AutoSize = true;
            SwitchFilterControl.Checked = true;
            SwitchFilterControl.CheckState = CheckState.Checked;
            SwitchFilterControl.Depth = 0;
            SwitchFilterControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SwitchFilterControl.Location = new Point(21, 61);
            SwitchFilterControl.Margin = new Padding(0);
            SwitchFilterControl.MouseLocation = new Point(-1, -1);
            SwitchFilterControl.MouseState = MaterialSkin.MouseState.HOVER;
            SwitchFilterControl.Name = "SwitchFilterControl";
            SwitchFilterControl.Ripple = true;
            SwitchFilterControl.Size = new Size(461, 37);
            SwitchFilterControl.TabIndex = 52;
            SwitchFilterControl.Text = "Turn Off Date filters to search only by Analysis Item Type";
            SwitchFilterControl.UseVisualStyleBackColor = true;
            SwitchFilterControl.CheckedChanged += SwitchFilterControl_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 123);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 34;
            label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(79, 119);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(250, 27);
            dateTimePickerFromDate.TabIndex = 33;
            // 
            // materialButtonPrintAnalysisRemark
            // 
            materialButtonPrintAnalysisRemark.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonPrintAnalysisRemark.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonPrintAnalysisRemark.Cursor = Cursors.Hand;
            materialButtonPrintAnalysisRemark.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonPrintAnalysisRemark.Depth = 0;
            materialButtonPrintAnalysisRemark.HighEmphasis = true;
            materialButtonPrintAnalysisRemark.Icon = null;
            materialButtonPrintAnalysisRemark.Location = new Point(625, 855);
            materialButtonPrintAnalysisRemark.Margin = new Padding(5, 5, 5, 5);
            materialButtonPrintAnalysisRemark.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonPrintAnalysisRemark.Name = "materialButtonPrintAnalysisRemark";
            materialButtonPrintAnalysisRemark.NoAccentTextColor = Color.Empty;
            materialButtonPrintAnalysisRemark.Size = new Size(64, 36);
            materialButtonPrintAnalysisRemark.TabIndex = 61;
            materialButtonPrintAnalysisRemark.Text = "Print";
            materialButtonPrintAnalysisRemark.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonPrintAnalysisRemark.UseAccentColor = true;
            materialButtonPrintAnalysisRemark.UseVisualStyleBackColor = true;
            materialButtonPrintAnalysisRemark.Click += materialButtonPrintAnalysisRemark_Click;
            // 
            // labelStockItemCount
            // 
            labelStockItemCount.AutoSize = true;
            labelStockItemCount.Depth = 0;
            labelStockItemCount.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelStockItemCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            labelStockItemCount.HighEmphasis = true;
            labelStockItemCount.Location = new Point(29, 83);
            labelStockItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            labelStockItemCount.Name = "labelStockItemCount";
            labelStockItemCount.Size = new Size(26, 17);
            labelStockItemCount.TabIndex = 60;
            labelStockItemCount.Text = "-----";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(560, 308);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 59;
            label2.Text = "List of Analysis Remarks";
            // 
            // dataGridViewAnalysisRemarks
            // 
            dataGridViewAnalysisRemarks.AllowUserToAddRows = false;
            dataGridViewAnalysisRemarks.AllowUserToDeleteRows = false;
            dataGridViewAnalysisRemarks.AllowUserToResizeRows = false;
            dataGridViewAnalysisRemarks.BackgroundColor = SystemColors.Window;
            dataGridViewAnalysisRemarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnalysisRemarks.Columns.AddRange(new DataGridViewColumn[] { AnalysisItemName, AnalysisRemark, AnalysisRemarkDate, AnalysisRemarkTime, RemarkBy });
            dataGridViewAnalysisRemarks.Location = new Point(49, 351);
            dataGridViewAnalysisRemarks.Name = "dataGridViewAnalysisRemarks";
            dataGridViewAnalysisRemarks.ReadOnly = true;
            dataGridViewAnalysisRemarks.RowHeadersWidth = 51;
            dataGridViewAnalysisRemarks.RowTemplate.Height = 29;
            dataGridViewAnalysisRemarks.Size = new Size(1226, 496);
            dataGridViewAnalysisRemarks.TabIndex = 58;
            // 
            // AnalysisItemName
            // 
            AnalysisItemName.HeaderText = "ANALYSIS ITEM";
            AnalysisItemName.MinimumWidth = 6;
            AnalysisItemName.Name = "AnalysisItemName";
            AnalysisItemName.ReadOnly = true;
            AnalysisItemName.Width = 205;
            // 
            // AnalysisRemark
            // 
            AnalysisRemark.HeaderText = "ANALYSIS REMARK";
            AnalysisRemark.MinimumWidth = 6;
            AnalysisRemark.Name = "AnalysisRemark";
            AnalysisRemark.ReadOnly = true;
            AnalysisRemark.Width = 204;
            // 
            // AnalysisRemarkDate
            // 
            AnalysisRemarkDate.HeaderText = "REMARK DATE";
            AnalysisRemarkDate.MinimumWidth = 6;
            AnalysisRemarkDate.Name = "AnalysisRemarkDate";
            AnalysisRemarkDate.ReadOnly = true;
            AnalysisRemarkDate.Width = 202;
            // 
            // AnalysisRemarkTime
            // 
            AnalysisRemarkTime.HeaderText = "REMARK TIME";
            AnalysisRemarkTime.MinimumWidth = 4;
            AnalysisRemarkTime.Name = "AnalysisRemarkTime";
            AnalysisRemarkTime.ReadOnly = true;
            AnalysisRemarkTime.Width = 205;
            // 
            // RemarkBy
            // 
            RemarkBy.HeaderText = "REMARK BY";
            RemarkBy.MinimumWidth = 6;
            RemarkBy.Name = "RemarkBy";
            RemarkBy.ReadOnly = true;
            RemarkBy.Width = 204;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(29, 17);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(230, 24);
            materialLabel5.TabIndex = 63;
            materialLabel5.Text = "View Production Remarks";
            // 
            // UserControlViewAnalysisRemarks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel5);
            Controls.Add(groupBox1);
            Controls.Add(materialButtonPrintAnalysisRemark);
            Controls.Add(labelStockItemCount);
            Controls.Add(label2);
            Controls.Add(dataGridViewAnalysisRemarks);
            Name = "UserControlViewAnalysisRemarks";
            Size = new Size(1323, 917);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonResetCatrgotyFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalysisRemarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
