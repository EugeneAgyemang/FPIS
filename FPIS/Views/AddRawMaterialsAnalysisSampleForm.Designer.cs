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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdAsStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialProcuredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AnalysisStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRawMaterialsSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.IdAsStr,
            this.MaterialProcuredId,
            this.Id,
            this.DateAdded,
            this.Warehouse,
            this.Supplier,
            this.TruckNumber,
            this.QuantityReceived,
            this.QuantityLeft,
            this.Remarks,
            this.selectedDataGridViewCheckBoxColumn,
            this.AnalysisStatus,
            this.Lot});
            this.dataGridView1.DataSource = this.analysisRawMaterialsSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IdAsStr
            // 
            this.IdAsStr.DataPropertyName = "IdAsStr";
            this.IdAsStr.HeaderText = "Id";
            this.IdAsStr.MinimumWidth = 6;
            this.IdAsStr.Name = "IdAsStr";
            this.IdAsStr.ReadOnly = true;
            this.IdAsStr.Visible = false;
            // 
            // MaterialProcuredId
            // 
            this.MaterialProcuredId.DataPropertyName = "MaterialProcuredId";
            this.MaterialProcuredId.HeaderText = "Material Procured Id";
            this.MaterialProcuredId.MinimumWidth = 6;
            this.MaterialProcuredId.Name = "MaterialProcuredId";
            this.MaterialProcuredId.ReadOnly = true;
            this.MaterialProcuredId.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DateAdded
            // 
            this.DateAdded.DataPropertyName = "DateAdded";
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.MinimumWidth = 6;
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            this.DateAdded.Width = 114;
            // 
            // Warehouse
            // 
            this.Warehouse.DataPropertyName = "Warehouse";
            this.Warehouse.HeaderText = "Warehouse Stored";
            this.Warehouse.MinimumWidth = 6;
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            this.Warehouse.Width = 113;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 114;
            // 
            // TruckNumber
            // 
            this.TruckNumber.DataPropertyName = "TruckNumber";
            this.TruckNumber.HeaderText = "Truck Number";
            this.TruckNumber.MinimumWidth = 6;
            this.TruckNumber.Name = "TruckNumber";
            this.TruckNumber.ReadOnly = true;
            this.TruckNumber.Width = 113;
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
            this.QuantityLeft.HeaderText = "Quantity Left";
            this.QuantityLeft.MinimumWidth = 6;
            this.QuantityLeft.Name = "QuantityLeft";
            this.QuantityLeft.ReadOnly = true;
            this.QuantityLeft.Width = 114;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 113;
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
            // AnalysisStatus
            // 
            this.AnalysisStatus.DataPropertyName = "AnalysisStatus";
            this.AnalysisStatus.HeaderText = "Analysis Status";
            this.AnalysisStatus.MinimumWidth = 6;
            this.AnalysisStatus.Name = "AnalysisStatus";
            this.AnalysisStatus.ReadOnly = true;
            this.AnalysisStatus.Width = 113;
            // 
            // Lot
            // 
            this.Lot.DataPropertyName = "Lot";
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            this.Lot.Width = 114;
            // 
            // analysisRawMaterialsSampleBindingItemBindingSource
            // 
            this.analysisRawMaterialsSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisRawMaterialsSampleBindingItem);
            // 
            // analysisSampleBindingItemBindingSource
            // 
            this.analysisSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleBindingItem);
            // 
            // AddRawMaterialsAnalysisSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 350);
            this.Controls.Add(this.dataGridView1);
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
        private DataGridViewTextBoxColumn MaterialProcuredId;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewTextBoxColumn Warehouse;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn TruckNumber;
        private DataGridViewTextBoxColumn QuantityReceived;
        private DataGridViewTextBoxColumn QuantityLeft;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn AnalysisStatus;
        private DataGridViewTextBoxColumn Lot;
    }
}