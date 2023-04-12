namespace FPIS.Views
{
    partial class ProcurementIssueMaterials
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RequestForAnalysisControl = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAsStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialProcuredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialProcuredIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.analysisStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRawMaterialsSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenAddMaterialsControl = new MaterialSkin.Controls.MaterialFloatingActionButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).BeginInit();
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
            this.materialLabel1.Size = new System.Drawing.Size(225, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Issue Materials Procured";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RequestForAnalysisControl
            // 
            this.RequestForAnalysisControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RequestForAnalysisControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RequestForAnalysisControl.Depth = 0;
            this.RequestForAnalysisControl.HighEmphasis = true;
            this.RequestForAnalysisControl.Icon = null;
            this.RequestForAnalysisControl.Location = new System.Drawing.Point(43, 336);
            this.RequestForAnalysisControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RequestForAnalysisControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RequestForAnalysisControl.Name = "RequestForAnalysisControl";
            this.RequestForAnalysisControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RequestForAnalysisControl.Size = new System.Drawing.Size(192, 36);
            this.RequestForAnalysisControl.TabIndex = 16;
            this.RequestForAnalysisControl.Text = " Request For Analysis ";
            this.RequestForAnalysisControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RequestForAnalysisControl.UseAccentColor = true;
            this.RequestForAnalysisControl.UseVisualStyleBackColor = true;
            this.RequestForAnalysisControl.Click += new System.EventHandler(this.RequestForAnalysisControl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsStrDataGridViewTextBoxColumn,
            this.MaterialProcuredId,
            this.idDataGridViewTextBoxColumn,
            this.materialProcuredIdDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.truckNumberDataGridViewTextBoxColumn,
            this.quantityReceivedDataGridViewTextBoxColumn,
            this.quantityLeftDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.selectedDataGridViewCheckBoxColumn,
            this.analysisStatusDataGridViewTextBoxColumn,
            this.Lot});
            this.dataGridView1.DataSource = this.analysisRawMaterialsSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(914, 246);
            this.dataGridView1.TabIndex = 17;
            // 
            // idAsStrDataGridViewTextBoxColumn
            // 
            this.idAsStrDataGridViewTextBoxColumn.DataPropertyName = "IdAsStr";
            this.idAsStrDataGridViewTextBoxColumn.HeaderText = "IdAsStr";
            this.idAsStrDataGridViewTextBoxColumn.Name = "idAsStrDataGridViewTextBoxColumn";
            this.idAsStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MaterialProcuredId
            // 
            this.MaterialProcuredId.DataPropertyName = "MaterialProcuredId";
            this.MaterialProcuredId.HeaderText = "Material Procured Id";
            this.MaterialProcuredId.Name = "MaterialProcuredId";
            this.MaterialProcuredId.ReadOnly = true;
            this.MaterialProcuredId.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialProcuredIdDataGridViewTextBoxColumn
            // 
            this.materialProcuredIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialProcuredId";
            this.materialProcuredIdDataGridViewTextBoxColumn.HeaderText = "MaterialProcuredId";
            this.materialProcuredIdDataGridViewTextBoxColumn.Name = "materialProcuredIdDataGridViewTextBoxColumn";
            this.materialProcuredIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // truckNumberDataGridViewTextBoxColumn
            // 
            this.truckNumberDataGridViewTextBoxColumn.DataPropertyName = "TruckNumber";
            this.truckNumberDataGridViewTextBoxColumn.HeaderText = "TruckNumber";
            this.truckNumberDataGridViewTextBoxColumn.Name = "truckNumberDataGridViewTextBoxColumn";
            this.truckNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityReceivedDataGridViewTextBoxColumn
            // 
            this.quantityReceivedDataGridViewTextBoxColumn.DataPropertyName = "QuantityReceived";
            this.quantityReceivedDataGridViewTextBoxColumn.HeaderText = "QuantityReceived";
            this.quantityReceivedDataGridViewTextBoxColumn.Name = "quantityReceivedDataGridViewTextBoxColumn";
            this.quantityReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityLeftDataGridViewTextBoxColumn
            // 
            this.quantityLeftDataGridViewTextBoxColumn.DataPropertyName = "QuantityLeft";
            this.quantityLeftDataGridViewTextBoxColumn.HeaderText = "QuantityLeft";
            this.quantityLeftDataGridViewTextBoxColumn.Name = "quantityLeftDataGridViewTextBoxColumn";
            this.quantityLeftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // analysisStatusDataGridViewTextBoxColumn
            // 
            this.analysisStatusDataGridViewTextBoxColumn.DataPropertyName = "AnalysisStatus";
            this.analysisStatusDataGridViewTextBoxColumn.HeaderText = "AnalysisStatus";
            this.analysisStatusDataGridViewTextBoxColumn.Name = "analysisStatusDataGridViewTextBoxColumn";
            this.analysisStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Lot
            // 
            this.Lot.DataPropertyName = "Lot";
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            // 
            // analysisRawMaterialsSampleBindingItemBindingSource
            // 
            this.analysisRawMaterialsSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisRawMaterialsSampleBindingItem);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Selected Samples";
            // 
            // OpenAddMaterialsControl
            // 
            this.OpenAddMaterialsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAddMaterialsControl.Depth = 0;
            this.OpenAddMaterialsControl.Icon = global::FPIS.Properties.Resources.add_white;
            this.OpenAddMaterialsControl.Location = new System.Drawing.Point(917, 334);
            this.OpenAddMaterialsControl.Mini = true;
            this.OpenAddMaterialsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenAddMaterialsControl.Name = "OpenAddMaterialsControl";
            this.OpenAddMaterialsControl.Size = new System.Drawing.Size(40, 40);
            this.OpenAddMaterialsControl.TabIndex = 21;
            this.OpenAddMaterialsControl.Text = "materialFloatingActionButton1";
            this.OpenAddMaterialsControl.UseVisualStyleBackColor = true;
            this.OpenAddMaterialsControl.Click += new System.EventHandler(this.OpenAddMaterialsControl_Click);
            // 
            // ProcurementIssueMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenAddMaterialsControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RequestForAnalysisControl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ProcurementIssueMaterials";
            this.Size = new System.Drawing.Size(1000, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button button2;
        private Button button1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton RequestForAnalysisControl;
        private DataGridView dataGridView1;
        private Button button3;
        private MaterialSkin.Controls.MaterialFloatingActionButton OpenAddMaterialsControl;
        private BindingSource analysisRawMaterialsSampleBindingItemBindingSource;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee1;
        private Label label1;
        private DataGridViewTextBoxColumn MaterialProcuredId;
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
        private DataGridViewTextBoxColumn Lot;
    }
}
