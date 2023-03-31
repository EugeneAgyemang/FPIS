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
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 26);
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
            this.materialButtonPrintReceivedStock.Location = new System.Drawing.Point(1443, 636);
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
            this.dataGridViewReceivedStock.AllowUserToResizeColumns = false;
            this.dataGridViewReceivedStock.AllowUserToResizeRows = false;
            this.dataGridViewReceivedStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceivedStock.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewReceivedStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceivedStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemName,
            this.ReceivedDate,
            this.UnitOfMeasurement,
            this.QuantityReceived,
            this.AvailableQuantity,
            this.ExpiryDate});
            this.dataGridViewReceivedStock.Location = new System.Drawing.Point(220, 123);
            this.dataGridViewReceivedStock.Name = "dataGridViewReceivedStock";
            this.dataGridViewReceivedStock.ReadOnly = true;
            this.dataGridViewReceivedStock.RowHeadersWidth = 51;
            this.dataGridViewReceivedStock.RowTemplate.Height = 29;
            this.dataGridViewReceivedStock.Size = new System.Drawing.Size(1216, 549);
            this.dataGridViewReceivedStock.TabIndex = 15;
            // 
            // StockItemName
            // 
            this.StockItemName.HeaderText = "STOCK ITEM NAME";
            this.StockItemName.MinimumWidth = 6;
            this.StockItemName.Name = "StockItemName";
            this.StockItemName.ReadOnly = true;
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.HeaderText = "RECEIVED DATE";
            this.ReceivedDate.MinimumWidth = 6;
            this.ReceivedDate.Name = "ReceivedDate";
            this.ReceivedDate.ReadOnly = true;
            // 
            // UnitOfMeasurement
            // 
            this.UnitOfMeasurement.HeaderText = "UNIT OF MEASUREMENT";
            this.UnitOfMeasurement.MinimumWidth = 6;
            this.UnitOfMeasurement.Name = "UnitOfMeasurement";
            this.UnitOfMeasurement.ReadOnly = true;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.HeaderText = "QUANTITY RECEIVED";
            this.QuantityReceived.MinimumWidth = 6;
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.HeaderText = "AVAILABLE QUANTITY";
            this.AvailableQuantity.MinimumWidth = 6;
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "EXPIRY DATE";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // UserControlViewReceivedStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewReceivedStock);
            this.Controls.Add(this.materialButtonPrintReceivedStock);
            this.Controls.Add(this.label1);
            this.Name = "UserControlViewReceivedStocks";
            this.Size = new System.Drawing.Size(1692, 939);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintReceivedStock;
        private DataGridView dataGridViewReceivedStock;
        private DataGridViewTextBoxColumn StockItemName;
        private DataGridViewTextBoxColumn ReceivedDate;
        private DataGridViewTextBoxColumn UnitOfMeasurement;
        private DataGridViewTextBoxColumn QuantityReceived;
        private DataGridViewTextBoxColumn AvailableQuantity;
        private DataGridViewTextBoxColumn ExpiryDate;
    }
}
