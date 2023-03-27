namespace FPIS.Views
{
    partial class ProcurementViewRequestsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.viewSampleRequestsMadeBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisRawMaterialsSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SampleIdAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisProductIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeForFilteringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerOneEmpIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerTwoEmpIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerOneFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineerTwoFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewSampleRequestsMadeBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(25, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(189, 24);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "View Requests Made";
            // 
            // viewSampleRequestsMadeBindingItemBindingSource
            // 
            this.viewSampleRequestsMadeBindingItemBindingSource.DataSource = typeof(FPIS.Models.ViewSampleRequestsMadeBindingItem);
            // 
            // analysisRawMaterialsSampleBindingItemBindingSource
            // 
            this.analysisRawMaterialsSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisRawMaterialsSampleBindingItem);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(820, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 135);
            this.button4.TabIndex = 22;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleIdAsString,
            this.sampleIdDataGridViewTextBoxColumn,
            this.sampleDetailIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.analysisItemIdDataGridViewTextBoxColumn,
            this.analysisProductIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeForFilteringDataGridViewTextBoxColumn,
            this.engineerOneDataGridViewTextBoxColumn,
            this.engineerTwoDataGridViewTextBoxColumn,
            this.engineerOneEmpIdDataGridViewTextBoxColumn,
            this.engineerTwoEmpIdDataGridViewTextBoxColumn,
            this.engineerOneFullNameDataGridViewTextBoxColumn,
            this.engineerTwoFullNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewSampleRequestsMadeBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(914, 229);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SampleIdAsString
            // 
            this.SampleIdAsString.DataPropertyName = "SampleIdAsString";
            this.SampleIdAsString.HeaderText = "Sample Id";
            this.SampleIdAsString.Name = "SampleIdAsString";
            this.SampleIdAsString.ReadOnly = true;
            // 
            // sampleIdDataGridViewTextBoxColumn
            // 
            this.sampleIdDataGridViewTextBoxColumn.DataPropertyName = "SampleId";
            this.sampleIdDataGridViewTextBoxColumn.HeaderText = "SampleId";
            this.sampleIdDataGridViewTextBoxColumn.Name = "sampleIdDataGridViewTextBoxColumn";
            this.sampleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sampleDetailIdDataGridViewTextBoxColumn
            // 
            this.sampleDetailIdDataGridViewTextBoxColumn.DataPropertyName = "SampleDetailId";
            this.sampleDetailIdDataGridViewTextBoxColumn.HeaderText = "SampleDetailId";
            this.sampleDetailIdDataGridViewTextBoxColumn.Name = "sampleDetailIdDataGridViewTextBoxColumn";
            this.sampleDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleDetailIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // analysisItemIdDataGridViewTextBoxColumn
            // 
            this.analysisItemIdDataGridViewTextBoxColumn.DataPropertyName = "AnalysisItemId";
            this.analysisItemIdDataGridViewTextBoxColumn.HeaderText = "AnalysisItemId";
            this.analysisItemIdDataGridViewTextBoxColumn.Name = "analysisItemIdDataGridViewTextBoxColumn";
            this.analysisItemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisItemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // analysisProductIdDataGridViewTextBoxColumn
            // 
            this.analysisProductIdDataGridViewTextBoxColumn.DataPropertyName = "AnalysisProductId";
            this.analysisProductIdDataGridViewTextBoxColumn.HeaderText = "AnalysisProductId";
            this.analysisProductIdDataGridViewTextBoxColumn.Name = "analysisProductIdDataGridViewTextBoxColumn";
            this.analysisProductIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisProductIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date Requested";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time Requested";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeForFilteringDataGridViewTextBoxColumn
            // 
            this.typeForFilteringDataGridViewTextBoxColumn.DataPropertyName = "TypeForFiltering";
            this.typeForFilteringDataGridViewTextBoxColumn.HeaderText = "TypeForFiltering";
            this.typeForFilteringDataGridViewTextBoxColumn.Name = "typeForFilteringDataGridViewTextBoxColumn";
            this.typeForFilteringDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeForFilteringDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineerOneDataGridViewTextBoxColumn
            // 
            this.engineerOneDataGridViewTextBoxColumn.DataPropertyName = "EngineerOne";
            this.engineerOneDataGridViewTextBoxColumn.HeaderText = "EngineerOne";
            this.engineerOneDataGridViewTextBoxColumn.Name = "engineerOneDataGridViewTextBoxColumn";
            this.engineerOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineerOneDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineerTwoDataGridViewTextBoxColumn
            // 
            this.engineerTwoDataGridViewTextBoxColumn.DataPropertyName = "EngineerTwo";
            this.engineerTwoDataGridViewTextBoxColumn.HeaderText = "EngineerTwo";
            this.engineerTwoDataGridViewTextBoxColumn.Name = "engineerTwoDataGridViewTextBoxColumn";
            this.engineerTwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineerTwoDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineerOneEmpIdDataGridViewTextBoxColumn
            // 
            this.engineerOneEmpIdDataGridViewTextBoxColumn.DataPropertyName = "EngineerOneEmpId";
            this.engineerOneEmpIdDataGridViewTextBoxColumn.HeaderText = "EngineerOneEmpId";
            this.engineerOneEmpIdDataGridViewTextBoxColumn.Name = "engineerOneEmpIdDataGridViewTextBoxColumn";
            this.engineerOneEmpIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineerOneEmpIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineerTwoEmpIdDataGridViewTextBoxColumn
            // 
            this.engineerTwoEmpIdDataGridViewTextBoxColumn.DataPropertyName = "EngineerTwoEmpId";
            this.engineerTwoEmpIdDataGridViewTextBoxColumn.HeaderText = "EngineerTwoEmpId";
            this.engineerTwoEmpIdDataGridViewTextBoxColumn.Name = "engineerTwoEmpIdDataGridViewTextBoxColumn";
            this.engineerTwoEmpIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.engineerTwoEmpIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // engineerOneFullNameDataGridViewTextBoxColumn
            // 
            this.engineerOneFullNameDataGridViewTextBoxColumn.DataPropertyName = "EngineerOneFullName";
            this.engineerOneFullNameDataGridViewTextBoxColumn.HeaderText = "Engineer One";
            this.engineerOneFullNameDataGridViewTextBoxColumn.Name = "engineerOneFullNameDataGridViewTextBoxColumn";
            this.engineerOneFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineerTwoFullNameDataGridViewTextBoxColumn
            // 
            this.engineerTwoFullNameDataGridViewTextBoxColumn.DataPropertyName = "EngineerTwoFullName";
            this.engineerTwoFullNameDataGridViewTextBoxColumn.HeaderText = "Engineer Two";
            this.engineerTwoFullNameDataGridViewTextBoxColumn.Name = "engineerTwoFullNameDataGridViewTextBoxColumn";
            this.engineerTwoFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProcurementViewRequestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ProcurementViewRequestsUserControl";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.viewSampleRequestsMadeBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button button4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialProcuredIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAsStrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn truckNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityReceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityLeftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn analysisStatusDataGridViewTextBoxColumn;
        private BindingSource analysisRawMaterialsSampleBindingItemBindingSource;
        private BindingSource viewSampleRequestsMadeBindingItemBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SampleDetailsIdAsString;
        private DataGridViewTextBoxColumn SampleIdAsString;
        private DataGridViewTextBoxColumn sampleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sampleDetailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisItemIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisProductIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeForFilteringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineerOneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineerTwoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineerOneEmpIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineerTwoEmpIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineerOneFullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineerTwoFullNameDataGridViewTextBoxColumn;
    }
}
