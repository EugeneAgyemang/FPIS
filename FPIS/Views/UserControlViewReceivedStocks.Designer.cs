namespace FPIS.Views
{
    partial class UserControlViewReceivedStocks
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
            this.materialButtonPrintReceivedStock = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewReceivedStock = new System.Windows.Forms.DataGridView();
            this.StockItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButtonSearchStockItems = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.labelReceivedStockCount = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.materialComboBoxItemCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.buttonResetCatrgotyFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "View Received Stock";
            // 
            // materialButtonPrintReceivedStock
            // 
            this.materialButtonPrintReceivedStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintReceivedStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintReceivedStock.Depth = 0;
            this.materialButtonPrintReceivedStock.HighEmphasis = true;
            this.materialButtonPrintReceivedStock.Icon = null;
            this.materialButtonPrintReceivedStock.Location = new System.Drawing.Point(1498, 857);
            this.materialButtonPrintReceivedStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPrintReceivedStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintReceivedStock.Name = "materialButtonPrintReceivedStock";
            this.materialButtonPrintReceivedStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintReceivedStock.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintReceivedStock.TabIndex = 14;
            this.materialButtonPrintReceivedStock.Text = "Print";
            this.materialButtonPrintReceivedStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintReceivedStock.UseAccentColor = false;
            this.materialButtonPrintReceivedStock.UseVisualStyleBackColor = true;
            this.materialButtonPrintReceivedStock.Click += new System.EventHandler(this.materialButtonPrintReceivedStock_Click);
            // 
            // dataGridViewReceivedStock
            // 
            this.dataGridViewReceivedStock.AllowUserToAddRows = false;
            this.dataGridViewReceivedStock.AllowUserToDeleteRows = false;
            this.dataGridViewReceivedStock.AllowUserToOrderColumns = true;
            this.dataGridViewReceivedStock.AllowUserToResizeRows = false;
            this.dataGridViewReceivedStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceivedStock.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewReceivedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceivedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemName,
            this.StockItemCategory,
            this.ReceivedDate,
            this.UnitOfMeasurement,
            this.QuantityReceived,
            this.AvailableQuantity,
            this.ExpiryDate,
            this.ReceivedBy});
            this.dataGridViewReceivedStock.Location = new System.Drawing.Point(69, 344);
            this.dataGridViewReceivedStock.Name = "dataGridViewReceivedStock";
            this.dataGridViewReceivedStock.ReadOnly = true;
            this.dataGridViewReceivedStock.RowHeadersWidth = 51;
            this.dataGridViewReceivedStock.RowTemplate.Height = 29;
            this.dataGridViewReceivedStock.Size = new System.Drawing.Size(1422, 549);
            this.dataGridViewReceivedStock.TabIndex = 15;
            // 
            // StockItemName
            // 
            this.StockItemName.FillWeight = 91.71123F;
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
            // ReceivedDate
            // 
            this.ReceivedDate.FillWeight = 91.71123F;
            this.ReceivedDate.HeaderText = "RECEIVED DATE";
            this.ReceivedDate.MinimumWidth = 6;
            this.ReceivedDate.Name = "ReceivedDate";
            this.ReceivedDate.ReadOnly = true;
            // 
            // UnitOfMeasurement
            // 
            this.UnitOfMeasurement.FillWeight = 91.71123F;
            this.UnitOfMeasurement.HeaderText = "UNIT OF MEASUREMENT";
            this.UnitOfMeasurement.MinimumWidth = 6;
            this.UnitOfMeasurement.Name = "UnitOfMeasurement";
            this.UnitOfMeasurement.ReadOnly = true;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.FillWeight = 91.71123F;
            this.QuantityReceived.HeaderText = "QUANTITY RECEIVED";
            this.QuantityReceived.MinimumWidth = 6;
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.FillWeight = 91.71123F;
            this.AvailableQuantity.HeaderText = "AVAILABLE QUANTITY";
            this.AvailableQuantity.MinimumWidth = 6;
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.FillWeight = 91.71123F;
            this.ExpiryDate.HeaderText = "EXPIRY DATE";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // ReceivedBy
            // 
            this.ReceivedBy.FillWeight = 149.7326F;
            this.ReceivedBy.HeaderText = "RECEIVED BY";
            this.ReceivedBy.MinimumWidth = 6;
            this.ReceivedBy.Name = "ReceivedBy";
            this.ReceivedBy.ReadOnly = true;
            // 
            // materialButtonSearchStockItems
            // 
            this.materialButtonSearchStockItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchStockItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchStockItems.Depth = 0;
            this.materialButtonSearchStockItems.HighEmphasis = true;
            this.materialButtonSearchStockItems.Icon = null;
            this.materialButtonSearchStockItems.Location = new System.Drawing.Point(1037, 112);
            this.materialButtonSearchStockItems.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearchStockItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchStockItems.Name = "materialButtonSearchStockItems";
            this.materialButtonSearchStockItems.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchStockItems.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchStockItems.TabIndex = 18;
            this.materialButtonSearchStockItems.Text = "Search";
            this.materialButtonSearchStockItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchStockItems.UseAccentColor = false;
            this.materialButtonSearchStockItems.UseVisualStyleBackColor = true;
            this.materialButtonSearchStockItems.Click += new System.EventHandler(this.materialButtonSearchStockItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(90, 119);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(410, 119);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 19;
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(1130, 112);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 21;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = false;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // labelReceivedStockCount
            // 
            this.labelReceivedStockCount.AutoSize = true;
            this.labelReceivedStockCount.Depth = 0;
            this.labelReceivedStockCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelReceivedStockCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelReceivedStockCount.HighEmphasis = true;
            this.labelReceivedStockCount.Location = new System.Drawing.Point(82, 74);
            this.labelReceivedStockCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelReceivedStockCount.Name = "labelReceivedStockCount";
            this.labelReceivedStockCount.Size = new System.Drawing.Size(26, 17);
            this.labelReceivedStockCount.TabIndex = 32;
            this.labelReceivedStockCount.Text = "-----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(608, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "List of Received Stock Items";
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
            this.materialComboBoxItemCategory.Location = new System.Drawing.Point(691, 111);
            this.materialComboBoxItemCategory.MaxDropDownItems = 4;
            this.materialComboBoxItemCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxItemCategory.Name = "materialComboBoxItemCategory";
            this.materialComboBoxItemCategory.Size = new System.Drawing.Size(257, 49);
            this.materialComboBoxItemCategory.StartIndex = 0;
            this.materialComboBoxItemCategory.TabIndex = 51;
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
            // buttonResetCatrgotyFilter
            // 
            this.buttonResetCatrgotyFilter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonResetCatrgotyFilter.Image = global::FPIS.Properties.Resources.reset_icon1;
            this.buttonResetCatrgotyFilter.Location = new System.Drawing.Point(948, 111);
            this.buttonResetCatrgotyFilter.Name = "buttonResetCatrgotyFilter";
            this.buttonResetCatrgotyFilter.Size = new System.Drawing.Size(49, 49);
            this.buttonResetCatrgotyFilter.TabIndex = 54;
            this.buttonResetCatrgotyFilter.UseVisualStyleBackColor = false;
            this.buttonResetCatrgotyFilter.Click += new System.EventHandler(this.buttonResetCatrgotyFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelItemCategoryError);
            this.groupBox1.Controls.Add(this.materialComboBoxItemCategory);
            this.groupBox1.Controls.Add(this.buttonResetCatrgotyFilter);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Controls.Add(this.SwitchCaptionControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SwitchFilterControl);
            this.groupBox1.Controls.Add(this.materialButtonSearchStockItems);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Location = new System.Drawing.Point(144, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1257, 190);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // labelItemCategoryError
            // 
            this.labelItemCategoryError.AutoSize = true;
            this.labelItemCategoryError.Location = new System.Drawing.Point(691, 162);
            this.labelItemCategoryError.Name = "labelItemCategoryError";
            this.labelItemCategoryError.Size = new System.Drawing.Size(50, 20);
            this.labelItemCategoryError.TabIndex = 55;
            this.labelItemCategoryError.Text = "label5";
            // 
            // UserControlViewReceivedStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelReceivedStockCount);
            this.Controls.Add(this.dataGridViewReceivedStock);
            this.Controls.Add(this.materialButtonPrintReceivedStock);
            this.Controls.Add(this.label1);
            this.Name = "UserControlViewReceivedStocks";
            this.Size = new System.Drawing.Size(1692, 939);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintReceivedStock;
        private DataGridView dataGridViewReceivedStock;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchStockItems;
        private Label label3;
        private DateTimePicker dateTimePickerFromDate;
        private Label label2;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private MaterialSkin.Controls.MaterialLabel labelReceivedStockCount;
        private Label label4;
        private DataGridViewTextBoxColumn StockItemName;
        private DataGridViewTextBoxColumn StockItemCategory;
        private DataGridViewTextBoxColumn ReceivedDate;
        private DataGridViewTextBoxColumn UnitOfMeasurement;
        private DataGridViewTextBoxColumn QuantityReceived;
        private DataGridViewTextBoxColumn AvailableQuantity;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewTextBoxColumn ReceivedBy;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxItemCategory;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private Button buttonResetCatrgotyFilter;
        private GroupBox groupBox1;
        private Label labelItemCategoryError;
    }
}
