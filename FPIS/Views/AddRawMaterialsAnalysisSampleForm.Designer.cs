namespace FPIS.Views
{
    partial class AddRawMaterialsAnalysisSampleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRawMaterialsAnalysisSampleForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisRawMaterialsSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateAdded,
            this.ProductName,
            this.ProcurementLocationId,
            this.QuantityReceived,
            this.QuantityLeft,
            this.Location,
            this.Lot,
            this.selectedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.analysisRawMaterialsSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(850, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // analysisRawMaterialsSampleBindingItemBindingSource
            // 
            this.analysisRawMaterialsSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisRawMaterialsSampleBindingItem);
            // 
            // analysisSampleBindingItemBindingSource
            // 
            this.analysisSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleBindingItem);
            // 
            // DateAdded
            // 
            this.DateAdded.DataPropertyName = "DateAdded";
            this.DateAdded.HeaderText = "Date Received";
            this.DateAdded.MinimumWidth = 6;
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            this.DateAdded.Width = 114;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProcurementLocationId
            // 
            this.ProcurementLocationId.DataPropertyName = "ProcurementLocationId";
            this.ProcurementLocationId.HeaderText = "ProcurementLocationId";
            this.ProcurementLocationId.Name = "ProcurementLocationId";
            this.ProcurementLocationId.ReadOnly = true;
            this.ProcurementLocationId.Visible = false;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.DataPropertyName = "QuantityReceived";
            this.QuantityReceived.HeaderText = "Quantity Received";
            this.QuantityReceived.MinimumWidth = 6;
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
            this.QuantityReceived.Width = 114;
            // 
            // QuantityLeft
            // 
            this.QuantityLeft.DataPropertyName = "QuantityLeft";
            this.QuantityLeft.HeaderText = "Quantity Remaining";
            this.QuantityLeft.MinimumWidth = 6;
            this.QuantityLeft.Name = "QuantityLeft";
            this.QuantityLeft.ReadOnly = true;
            this.QuantityLeft.Width = 114;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Warehouse";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Lot
            // 
            this.Lot.DataPropertyName = "Lot";
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.selectedDataGridViewCheckBoxColumn.Width = 114;
            // 
            // AddRawMaterialsAnalysisSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 350);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddRawMaterialsAnalysisSampleForm";
            this.Padding = new System.Windows.Forms.Padding(2, 38, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Analysis Samples";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource analysisSampleBindingItemBindingSource;
        private BindingSource analysisRawMaterialsSampleBindingItemBindingSource;
        private DataGridViewTextBoxColumn IdAsStr;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn TruckNumber;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn AnalysisStatus;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProcurementLocationId;
        private DataGridViewTextBoxColumn QuantityReceived;
        private DataGridViewTextBoxColumn QuantityLeft;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn Lot;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
    }
}