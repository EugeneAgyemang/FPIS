namespace FPIS.Views
{
    partial class UserControlViewStockItems
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
            this.dataGridViewStockItems = new System.Windows.Forms.DataGridView();
            this.StockItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStockItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonPrintStockItems = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxItemCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonSearchItemCategory = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            this.SamplesRequestedCaption = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStockItems
            // 
            this.dataGridViewStockItems.AllowUserToAddRows = false;
            this.dataGridViewStockItems.AllowUserToDeleteRows = false;
            this.dataGridViewStockItems.AllowUserToResizeColumns = false;
            this.dataGridViewStockItems.AllowUserToResizeRows = false;
            this.dataGridViewStockItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemName,
            this.UnitOfMeasurement,
            this.StockItemType});
            this.dataGridViewStockItems.Location = new System.Drawing.Point(48, 172);
            this.dataGridViewStockItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStockItems.Name = "dataGridViewStockItems";
            this.dataGridViewStockItems.ReadOnly = true;
            this.dataGridViewStockItems.RowHeadersWidth = 51;
            this.dataGridViewStockItems.RowTemplate.Height = 29;
            this.dataGridViewStockItems.Size = new System.Drawing.Size(754, 402);
            this.dataGridViewStockItems.TabIndex = 12;
            // 
            // StockItemName
            // 
            this.StockItemName.HeaderText = "STOCK ITEM NAME";
            this.StockItemName.MinimumWidth = 6;
            this.StockItemName.Name = "StockItemName";
            this.StockItemName.ReadOnly = true;
            this.StockItemName.Width = 233;
            // 
            // UnitOfMeasurement
            // 
            this.UnitOfMeasurement.HeaderText = "UNIT OF MEASUREMENT";
            this.UnitOfMeasurement.MinimumWidth = 6;
            this.UnitOfMeasurement.Name = "UnitOfMeasurement";
            this.UnitOfMeasurement.ReadOnly = true;
            this.UnitOfMeasurement.Width = 234;
            // 
            // StockItemType
            // 
            this.StockItemType.HeaderText = "STOCK ITEM CATEGORY";
            this.StockItemType.MinimumWidth = 6;
            this.StockItemType.Name = "StockItemType";
            this.StockItemType.ReadOnly = true;
            this.StockItemType.Width = 234;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(358, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "List of Stock Items";
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
            this.labelStockItemCount.TabIndex = 26;
            this.labelStockItemCount.Text = "-----";
            // 
            // materialButtonPrintStockItems
            // 
            this.materialButtonPrintStockItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintStockItems.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonPrintStockItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonPrintStockItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintStockItems.Depth = 0;
            this.materialButtonPrintStockItems.HighEmphasis = true;
            this.materialButtonPrintStockItems.Icon = null;
            this.materialButtonPrintStockItems.Location = new System.Drawing.Point(393, 580);
            this.materialButtonPrintStockItems.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonPrintStockItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintStockItems.Name = "materialButtonPrintStockItems";
            this.materialButtonPrintStockItems.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintStockItems.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintStockItems.TabIndex = 27;
            this.materialButtonPrintStockItems.Text = "Print";
            this.materialButtonPrintStockItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintStockItems.UseAccentColor = true;
            this.materialButtonPrintStockItems.UseVisualStyleBackColor = true;
            this.materialButtonPrintStockItems.Click += new System.EventHandler(this.materialButtonPrintStockItems_Click);
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
            this.materialComboBoxItemCategory.Location = new System.Drawing.Point(211, 81);
            this.materialComboBoxItemCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxItemCategory.MaxDropDownItems = 4;
            this.materialComboBoxItemCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxItemCategory.Name = "materialComboBoxItemCategory";
            this.materialComboBoxItemCategory.Size = new System.Drawing.Size(225, 49);
            this.materialComboBoxItemCategory.StartIndex = 0;
            this.materialComboBoxItemCategory.TabIndex = 54;
            // 
            // materialButtonSearchItemCategory
            // 
            this.materialButtonSearchItemCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchItemCategory.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchItemCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchItemCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchItemCategory.Depth = 0;
            this.materialButtonSearchItemCategory.HighEmphasis = true;
            this.materialButtonSearchItemCategory.Icon = null;
            this.materialButtonSearchItemCategory.Location = new System.Drawing.Point(460, 88);
            this.materialButtonSearchItemCategory.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonSearchItemCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchItemCategory.Name = "materialButtonSearchItemCategory";
            this.materialButtonSearchItemCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchItemCategory.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchItemCategory.TabIndex = 52;
            this.materialButtonSearchItemCategory.Text = "Search";
            this.materialButtonSearchItemCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchItemCategory.UseAccentColor = true;
            this.materialButtonSearchItemCategory.UseVisualStyleBackColor = true;
            this.materialButtonSearchItemCategory.Click += new System.EventHandler(this.materialButtonSearchDailyReport_Click);
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
            this.materialButtonShowAll.Location = new System.Drawing.Point(546, 88);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 53;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = true;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click_1);
            // 
            // labelItemCategoryError
            // 
            this.labelItemCategoryError.AutoSize = true;
            this.labelItemCategoryError.Location = new System.Drawing.Point(211, 132);
            this.labelItemCategoryError.Name = "labelItemCategoryError";
            this.labelItemCategoryError.Size = new System.Drawing.Size(38, 15);
            this.labelItemCategoryError.TabIndex = 55;
            this.labelItemCategoryError.Text = "label3";
            // 
            // SamplesRequestedCaption
            // 
            this.SamplesRequestedCaption.AutoSize = true;
            this.SamplesRequestedCaption.Depth = 0;
            this.SamplesRequestedCaption.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SamplesRequestedCaption.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.SamplesRequestedCaption.Location = new System.Drawing.Point(25, 13);
            this.SamplesRequestedCaption.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesRequestedCaption.Name = "SamplesRequestedCaption";
            this.SamplesRequestedCaption.Size = new System.Drawing.Size(156, 24);
            this.SamplesRequestedCaption.TabIndex = 56;
            this.SamplesRequestedCaption.Text = "View Stock Items";
            // 
            // UserControlViewStockItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SamplesRequestedCaption);
            this.Controls.Add(this.labelItemCategoryError);
            this.Controls.Add(this.materialComboBoxItemCategory);
            this.Controls.Add(this.materialButtonSearchItemCategory);
            this.Controls.Add(this.materialButtonShowAll);
            this.Controls.Add(this.materialButtonPrintStockItems);
            this.Controls.Add(this.labelStockItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewStockItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlViewStockItems";
            this.Size = new System.Drawing.Size(850, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridViewStockItems;
        private Label label2;
        private MaterialSkin.Controls.MaterialLabel labelStockItemCount;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintStockItems;
        private DataGridViewTextBoxColumn StockItemName;
        private DataGridViewTextBoxColumn UnitOfMeasurement;
        private DataGridViewTextBoxColumn StockItemType;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxItemCategory;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchItemCategory;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private Label labelItemCategoryError;
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedCaption;
    }
}
