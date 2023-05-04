namespace FPIS.Views
{
    partial class UserControlViewIssuedStock
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
            this.materialButtonPrintIssuedStockItems = new MaterialSkin.Controls.MaterialButton();
            this.labelStockItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewIssuedStockItems = new System.Windows.Forms.DataGridView();
            this.StockItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonSearchIssuedStock = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            this.materialComboBoxItemCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonResetCatrgotyFilter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedStockItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonResetCatrgotyFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // materialButtonPrintIssuedStockItems
            // 
            this.materialButtonPrintIssuedStockItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintIssuedStockItems.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonPrintIssuedStockItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonPrintIssuedStockItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintIssuedStockItems.Depth = 0;
            this.materialButtonPrintIssuedStockItems.HighEmphasis = true;
            this.materialButtonPrintIssuedStockItems.Icon = null;
            this.materialButtonPrintIssuedStockItems.Location = new System.Drawing.Point(518, 672);
            this.materialButtonPrintIssuedStockItems.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonPrintIssuedStockItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintIssuedStockItems.Name = "materialButtonPrintIssuedStockItems";
            this.materialButtonPrintIssuedStockItems.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintIssuedStockItems.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintIssuedStockItems.TabIndex = 32;
            this.materialButtonPrintIssuedStockItems.Text = "Print";
            this.materialButtonPrintIssuedStockItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintIssuedStockItems.UseAccentColor = true;
            this.materialButtonPrintIssuedStockItems.UseVisualStyleBackColor = true;
            this.materialButtonPrintIssuedStockItems.Click += new System.EventHandler(this.materialButtonPrintIssuedStockItems_Click);
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
            this.labelStockItemCount.TabIndex = 31;
            this.labelStockItemCount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(459, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "List of Issued Stock Items";
            // 
            // dataGridViewIssuedStockItems
            // 
            this.dataGridViewIssuedStockItems.AllowUserToAddRows = false;
            this.dataGridViewIssuedStockItems.AllowUserToDeleteRows = false;
            this.dataGridViewIssuedStockItems.AllowUserToResizeRows = false;
            this.dataGridViewIssuedStockItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewIssuedStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuedStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemName,
            this.StockItemCategory,
            this.IssuedDate,
            this.QuantityIssued,
            this.IssuedBy});
            this.dataGridViewIssuedStockItems.Location = new System.Drawing.Point(14, 264);
            this.dataGridViewIssuedStockItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewIssuedStockItems.Name = "dataGridViewIssuedStockItems";
            this.dataGridViewIssuedStockItems.ReadOnly = true;
            this.dataGridViewIssuedStockItems.RowHeadersWidth = 51;
            this.dataGridViewIssuedStockItems.RowTemplate.Height = 29;
            this.dataGridViewIssuedStockItems.Size = new System.Drawing.Size(1073, 402);
            this.dataGridViewIssuedStockItems.TabIndex = 29;
            // 
            // StockItemName
            // 
            this.StockItemName.HeaderText = "STOCK ITEM NAME";
            this.StockItemName.MinimumWidth = 6;
            this.StockItemName.Name = "StockItemName";
            this.StockItemName.ReadOnly = true;
            this.StockItemName.Width = 205;
            // 
            // StockItemCategory
            // 
            this.StockItemCategory.HeaderText = "STOCK ITEM CATEGORY";
            this.StockItemCategory.MinimumWidth = 6;
            this.StockItemCategory.Name = "StockItemCategory";
            this.StockItemCategory.ReadOnly = true;
            this.StockItemCategory.Width = 204;
            // 
            // IssuedDate
            // 
            this.IssuedDate.HeaderText = "ISSUED DATE";
            this.IssuedDate.MinimumWidth = 6;
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            this.IssuedDate.Width = 202;
            // 
            // QuantityIssued
            // 
            this.QuantityIssued.HeaderText = "QUANTITY ISSUED";
            this.QuantityIssued.MinimumWidth = 4;
            this.QuantityIssued.Name = "QuantityIssued";
            this.QuantityIssued.ReadOnly = true;
            this.QuantityIssued.Width = 205;
            // 
            // IssuedBy
            // 
            this.IssuedBy.HeaderText = "ISSUED BY";
            this.IssuedBy.MinimumWidth = 6;
            this.IssuedBy.Name = "IssuedBy";
            this.IssuedBy.ReadOnly = true;
            this.IssuedBy.Width = 204;
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
            this.materialButtonShowAll.Location = new System.Drawing.Point(933, 79);
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
            // materialButtonSearchIssuedStock
            // 
            this.materialButtonSearchIssuedStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchIssuedStock.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchIssuedStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchIssuedStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchIssuedStock.Depth = 0;
            this.materialButtonSearchIssuedStock.HighEmphasis = true;
            this.materialButtonSearchIssuedStock.Icon = null;
            this.materialButtonSearchIssuedStock.Location = new System.Drawing.Point(847, 79);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonResetCatrgotyFilter);
            this.groupBox1.Controls.Add(this.labelItemCategoryError);
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialButtonSearchIssuedStock);
            this.groupBox1.Controls.Add(this.materialComboBoxItemCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.SwitchCaptionControl);
            this.groupBox1.Controls.Add(this.SwitchFilterControl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Location = new System.Drawing.Point(14, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1073, 142);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // labelItemCategoryError
            // 
            this.labelItemCategoryError.AutoSize = true;
            this.labelItemCategoryError.Location = new System.Drawing.Point(570, 122);
            this.labelItemCategoryError.Name = "labelItemCategoryError";
            this.labelItemCategoryError.Size = new System.Drawing.Size(38, 15);
            this.labelItemCategoryError.TabIndex = 55;
            this.labelItemCategoryError.Text = "label5";
            // 
            // materialComboBoxItemCategory
            // 
            this.materialComboBoxItemCategory.AutoResize = false;
            this.materialComboBoxItemCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxItemCategory.Depth = 0;
            this.materialComboBoxItemCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxItemCategory.DropDownHeight = 174;
            this.materialComboBoxItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxItemCategory.DropDownWidth = 121;
            this.materialComboBoxItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxItemCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxItemCategory.FormattingEnabled = true;
            this.materialComboBoxItemCategory.Hint = "Search by Item Category";
            this.materialComboBoxItemCategory.IntegralHeight = false;
            this.materialComboBoxItemCategory.ItemHeight = 43;
            this.materialComboBoxItemCategory.Location = new System.Drawing.Point(570, 71);
            this.materialComboBoxItemCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxItemCategory.MaxDropDownItems = 4;
            this.materialComboBoxItemCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxItemCategory.Name = "materialComboBoxItemCategory";
            this.materialComboBoxItemCategory.Size = new System.Drawing.Size(225, 49);
            this.materialComboBoxItemCategory.StartIndex = 0;
            this.materialComboBoxItemCategory.TabIndex = 51;
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
            this.SwitchFilterControl.Size = new System.Drawing.Size(425, 37);
            this.SwitchFilterControl.TabIndex = 52;
            this.SwitchFilterControl.Text = "Turn Off Date filters to search only by Item Category";
            this.SwitchFilterControl.UseVisualStyleBackColor = true;
            this.SwitchFilterControl.CheckedChanged += new System.EventHandler(this.SwitchFilterControl_CheckedChanged);
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
            this.materialLabel5.Size = new System.Drawing.Size(220, 24);
            this.materialLabel5.TabIndex = 65;
            this.materialLabel5.Text = "View Issued Stock Items";
            // 
            // buttonResetCatrgotyFilter
            // 
            this.buttonResetCatrgotyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetCatrgotyFilter.Image = global::FPIS.Properties.Resources.sync_dark;
            this.buttonResetCatrgotyFilter.Location = new System.Drawing.Point(801, 86);
            this.buttonResetCatrgotyFilter.Name = "buttonResetCatrgotyFilter";
            this.buttonResetCatrgotyFilter.Size = new System.Drawing.Size(25, 25);
            this.buttonResetCatrgotyFilter.TabIndex = 59;
            this.buttonResetCatrgotyFilter.TabStop = false;
            this.buttonResetCatrgotyFilter.Click += new System.EventHandler(this.buttonResetCatrgotyFilter_Click);
            // 
            // UserControlViewIssuedStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButtonPrintIssuedStockItems);
            this.Controls.Add(this.labelStockItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewIssuedStockItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlViewIssuedStock";
            this.Size = new System.Drawing.Size(1100, 724);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedStockItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonResetCatrgotyFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonPrintIssuedStockItems;
        private MaterialSkin.Controls.MaterialLabel labelStockItemCount;
        private Label label2;
        private DataGridView dataGridViewIssuedStockItems;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchIssuedStock;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private DataGridViewTextBoxColumn StockItemName;
        private DataGridViewTextBoxColumn StockItemCategory;
        private DataGridViewTextBoxColumn IssuedDate;
        private DataGridViewTextBoxColumn QuantityIssued;
        private DataGridViewTextBoxColumn IssuedBy;
        private GroupBox groupBox1;
        private Label labelItemCategoryError;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxItemCategory;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private PictureBox buttonResetCatrgotyFilter;
    }
}
