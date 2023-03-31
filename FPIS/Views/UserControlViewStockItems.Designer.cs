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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStockItems = new System.Windows.Forms.DataGridView();
            this.StockItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStockItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonPrintStockItems = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "View Stock Items";
            // 
            // dataGridViewStockItems
            // 
            this.dataGridViewStockItems.AllowUserToAddRows = false;
            this.dataGridViewStockItems.AllowUserToDeleteRows = false;
            this.dataGridViewStockItems.AllowUserToResizeColumns = false;
            this.dataGridViewStockItems.AllowUserToResizeRows = false;
            this.dataGridViewStockItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStockItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewStockItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemName,
            this.UnitOfMeasurement,
            this.StockItemType});
            this.dataGridViewStockItems.Location = new System.Drawing.Point(363, 189);
            this.dataGridViewStockItems.Name = "dataGridViewStockItems";
            this.dataGridViewStockItems.ReadOnly = true;
            this.dataGridViewStockItems.RowHeadersWidth = 51;
            this.dataGridViewStockItems.RowTemplate.Height = 29;
            this.dataGridViewStockItems.Size = new System.Drawing.Size(862, 536);
            this.dataGridViewStockItems.TabIndex = 12;
            // 
            // StockItemName
            // 
            this.StockItemName.HeaderText = "STOCK ITEM NAME";
            this.StockItemName.MinimumWidth = 6;
            this.StockItemName.Name = "StockItemName";
            this.StockItemName.ReadOnly = true;
            // 
            // UnitOfMeasurement
            // 
            this.UnitOfMeasurement.HeaderText = "UNIT OF MEASUREMENT";
            this.UnitOfMeasurement.MinimumWidth = 6;
            this.UnitOfMeasurement.Name = "UnitOfMeasurement";
            this.UnitOfMeasurement.ReadOnly = true;
            // 
            // StockItemType
            // 
            this.StockItemType.HeaderText = "STOCK ITEM TYPE";
            this.StockItemType.MinimumWidth = 6;
            this.StockItemType.Name = "StockItemType";
            this.StockItemType.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(691, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
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
            this.labelStockItemCount.Location = new System.Drawing.Point(73, 82);
            this.labelStockItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStockItemCount.Name = "labelStockItemCount";
            this.labelStockItemCount.Size = new System.Drawing.Size(26, 17);
            this.labelStockItemCount.TabIndex = 26;
            this.labelStockItemCount.Text = "-----";
            // 
            // materialButtonPrintStockItems
            // 
            this.materialButtonPrintStockItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintStockItems.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintStockItems.Depth = 0;
            this.materialButtonPrintStockItems.HighEmphasis = true;
            this.materialButtonPrintStockItems.Icon = null;
            this.materialButtonPrintStockItems.Location = new System.Drawing.Point(1247, 689);
            this.materialButtonPrintStockItems.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPrintStockItems.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintStockItems.Name = "materialButtonPrintStockItems";
            this.materialButtonPrintStockItems.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintStockItems.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintStockItems.TabIndex = 27;
            this.materialButtonPrintStockItems.Text = "Print";
            this.materialButtonPrintStockItems.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintStockItems.UseAccentColor = false;
            this.materialButtonPrintStockItems.UseVisualStyleBackColor = true;
            this.materialButtonPrintStockItems.Click += new System.EventHandler(this.materialButtonPrintStockItems_Click);
            // 
            // UserControlViewStockItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButtonPrintStockItems);
            this.Controls.Add(this.labelStockItemCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewStockItems);
            this.Controls.Add(this.label1);
            this.Name = "UserControlViewStockItems";
            this.Size = new System.Drawing.Size(1692, 939);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewStockItems;
        private DataGridViewTextBoxColumn StockItemName;
        private DataGridViewTextBoxColumn UnitOfMeasurement;
        private DataGridViewTextBoxColumn StockItemType;
        private Label label2;
        private MaterialSkin.Controls.MaterialLabel labelStockItemCount;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintStockItems;
    }
}
