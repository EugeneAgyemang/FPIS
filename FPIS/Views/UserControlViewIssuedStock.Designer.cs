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
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonSearchIssuedStock = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            this.materialComboBoxItemCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonResetCatrgotyFilter = new System.Windows.Forms.Button();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedStockItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButtonPrintIssuedStockItems
            // 
            this.materialButtonPrintIssuedStockItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintIssuedStockItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintIssuedStockItems.Depth = 0;
            this.materialButtonPrintIssuedStockItems.HighEmphasis = true;
            this.materialButtonPrintIssuedStockItems.Icon = null;
            this.materialButtonPrintIssuedStockItems.Location = new System.Drawing.Point(1332, 852);
            this.materialButtonPrintIssuedStockItems.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPrintIssuedStockItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintIssuedStockItems.Name = "materialButtonPrintIssuedStockItems";
            this.materialButtonPrintIssuedStockItems.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintIssuedStockItems.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintIssuedStockItems.TabIndex = 32;
            this.materialButtonPrintIssuedStockItems.Text = "Print";
            this.materialButtonPrintIssuedStockItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintIssuedStockItems.UseAccentColor = false;
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
            this.labelStockItemCount.Location = new System.Drawing.Point(92, 80);
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
            this.label2.Location = new System.Drawing.Point(639, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "List of Issued Stock Items";
            // 
            // dataGridViewIssuedStockItems
            // 
            this.dataGridViewIssuedStockItems.AllowUserToAddRows = false;
            this.dataGridViewIssuedStockItems.AllowUserToDeleteRows = false;
            this.dataGridViewIssuedStockItems.AllowUserToResizeRows = false;
            this.dataGridViewIssuedStockItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIssuedStockItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewIssuedStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuedStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemName,
            this.StockItemCategory,
            this.IssuedDate,
            this.QuantityIssued,
            this.IssuedBy});
            this.dataGridViewIssuedStockItems.Location = new System.Drawing.Point(92, 352);
            this.dataGridViewIssuedStockItems.Name = "dataGridViewIssuedStockItems";
            this.dataGridViewIssuedStockItems.ReadOnly = true;
            this.dataGridViewIssuedStockItems.RowHeadersWidth = 51;
            this.dataGridViewIssuedStockItems.RowTemplate.Height = 29;
            this.dataGridViewIssuedStockItems.Size = new System.Drawing.Size(1226, 536);
            this.dataGridViewIssuedStockItems.TabIndex = 29;
            // 
            // StockItemName
            // 
            this.StockItemName.HeaderText = "STOCK ITEM NAME";
            this.StockItemName.MinimumWidth = 6;
            this.StockItemName.Name = "StockItemName";
            this.StockItemName.ReadOnly = true;
            // 
            // StockItemCategory
            // 
            this.StockItemCategory.HeaderText = "STOCK ITEM CATEGORY";
            this.StockItemCategory.MinimumWidth = 6;
            this.StockItemCategory.Name = "StockItemCategory";
            this.StockItemCategory.ReadOnly = true;
            // 
            // IssuedDate
            // 
            this.IssuedDate.HeaderText = "ISSUED DATE";
            this.IssuedDate.MinimumWidth = 6;
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            // 
            // QuantityIssued
            // 
            this.QuantityIssued.HeaderText = "QUANTITY ISSUED";
            this.QuantityIssued.MinimumWidth = 4;
            this.QuantityIssued.Name = "QuantityIssued";
            this.QuantityIssued.ReadOnly = true;
            // 
            // IssuedBy
            // 
            this.IssuedBy.HeaderText = "ISSUED BY";
            this.IssuedBy.MinimumWidth = 6;
            this.IssuedBy.Name = "IssuedBy";
            this.IssuedBy.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 46);
            this.label1.TabIndex = 28;
            this.label1.Text = "View Issued Stock Items";
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(1114, 120);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 38;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = false;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(394, 117);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 36;
            // 
            // materialButtonSearchIssuedStock
            // 
            this.materialButtonSearchIssuedStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchIssuedStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchIssuedStock.Depth = 0;
            this.materialButtonSearchIssuedStock.HighEmphasis = true;
            this.materialButtonSearchIssuedStock.Icon = null;
            this.materialButtonSearchIssuedStock.Location = new System.Drawing.Point(1019, 120);
            this.materialButtonSearchIssuedStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearchIssuedStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchIssuedStock.Name = "materialButtonSearchIssuedStock";
            this.materialButtonSearchIssuedStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchIssuedStock.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchIssuedStock.TabIndex = 35;
            this.materialButtonSearchIssuedStock.Text = "Search";
            this.materialButtonSearchIssuedStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchIssuedStock.UseAccentColor = false;
            this.materialButtonSearchIssuedStock.UseVisualStyleBackColor = true;
            this.materialButtonSearchIssuedStock.Click += new System.EventHandler(this.materialButtonSearchIssuedStock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(79, 119);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelItemCategoryError);
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialButtonSearchIssuedStock);
            this.groupBox1.Controls.Add(this.materialComboBoxItemCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonResetCatrgotyFilter);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.SwitchCaptionControl);
            this.groupBox1.Controls.Add(this.SwitchFilterControl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Location = new System.Drawing.Point(92, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 190);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // labelItemCategoryError
            // 
            this.labelItemCategoryError.AutoSize = true;
            this.labelItemCategoryError.Location = new System.Drawing.Point(674, 162);
            this.labelItemCategoryError.Name = "labelItemCategoryError";
            this.labelItemCategoryError.Size = new System.Drawing.Size(50, 20);
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
            this.materialComboBoxItemCategory.Location = new System.Drawing.Point(674, 111);
            this.materialComboBoxItemCategory.MaxDropDownItems = 4;
            this.materialComboBoxItemCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxItemCategory.Name = "materialComboBoxItemCategory";
            this.materialComboBoxItemCategory.Size = new System.Drawing.Size(257, 49);
            this.materialComboBoxItemCategory.StartIndex = 0;
            this.materialComboBoxItemCategory.TabIndex = 51;
            // 
            // buttonResetCatrgotyFilter
            // 
            this.buttonResetCatrgotyFilter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonResetCatrgotyFilter.Image = global::FPIS.Properties.Resources.reset_icon1;
            this.buttonResetCatrgotyFilter.Location = new System.Drawing.Point(931, 111);
            this.buttonResetCatrgotyFilter.Name = "buttonResetCatrgotyFilter";
            this.buttonResetCatrgotyFilter.Size = new System.Drawing.Size(49, 49);
            this.buttonResetCatrgotyFilter.TabIndex = 54;
            this.buttonResetCatrgotyFilter.UseVisualStyleBackColor = false;
            this.buttonResetCatrgotyFilter.Click += new System.EventHandler(this.buttonResetCatrgotyFilter_Click);
            // 
            // SwitchCaptionControl
            // 
            this.SwitchCaptionControl.AutoSize = true;
            this.SwitchCaptionControl.Depth = 0;
            this.SwitchCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchCaptionControl.Location = new System.Drawing.Point(34, 37);
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
            this.SwitchFilterControl.Location = new System.Drawing.Point(21, 62);
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
            // UserControlViewIssuedStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButtonPrintIssuedStockItems);
            this.Controls.Add(this.labelStockItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewIssuedStockItems);
            this.Controls.Add(this.label1);
            this.Name = "UserControlViewIssuedStock";
            this.Size = new System.Drawing.Size(1692, 939);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedStockItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonPrintIssuedStockItems;
        private MaterialSkin.Controls.MaterialLabel labelStockItemCount;
        private Label label2;
        private DataGridView dataGridViewIssuedStockItems;
        private Label label1;
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
        private Button buttonResetCatrgotyFilter;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
    }
}
