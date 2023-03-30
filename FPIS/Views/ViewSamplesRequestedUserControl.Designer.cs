namespace FPIS.Views
{
    partial class ViewSamplesRequestedUserControl
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
            this.SamplesRequestedCaption = new MaterialSkin.Controls.MaterialLabel();
            this.viewSampleRequestsMadeBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisRawMaterialsSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SampleIdAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeForFiltering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerOneEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerTwoEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerOneFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerTwoFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engineer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SamplesRequestedOverviewControl = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.viewSampleRequestsMadeBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.SamplesRequestedCaption.Size = new System.Drawing.Size(189, 24);
            this.SamplesRequestedCaption.TabIndex = 14;
            this.SamplesRequestedCaption.Text = "View Requests Made";
            // 
            // viewSampleRequestsMadeBindingItemBindingSource
            // 
            this.viewSampleRequestsMadeBindingItemBindingSource.DataSource = typeof(FPIS.Models.ViewSampleRequestsMadeBindingItem);
            // 
            // analysisRawMaterialsSampleBindingItemBindingSource
            // 
            this.analysisRawMaterialsSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisRawMaterialsSampleBindingItem);
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
            this.SampleId,
            this.SampleDetailId,
            this.ProductId,
            this.AnalysisItemId,
            this.AnalysisProductId,
            this.Date,
            this.Time,
            this.Status,
            this.TypeForFiltering,
            this.EngineerOne,
            this.EngineerTwo,
            this.EngineerOneEmpId,
            this.EngineerTwoEmpId,
            this.EngineerOneFullName,
            this.EngineerTwoFullName,
            this.Engineer});
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
            // SampleId
            // 
            this.SampleId.DataPropertyName = "SampleId";
            this.SampleId.HeaderText = "SampleId";
            this.SampleId.Name = "SampleId";
            this.SampleId.ReadOnly = true;
            this.SampleId.Visible = false;
            // 
            // SampleDetailId
            // 
            this.SampleDetailId.DataPropertyName = "SampleDetailId";
            this.SampleDetailId.HeaderText = "SampleDetailId";
            this.SampleDetailId.Name = "SampleDetailId";
            this.SampleDetailId.ReadOnly = true;
            this.SampleDetailId.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // AnalysisItemId
            // 
            this.AnalysisItemId.DataPropertyName = "AnalysisItemId";
            this.AnalysisItemId.HeaderText = "AnalysisItemId";
            this.AnalysisItemId.Name = "AnalysisItemId";
            this.AnalysisItemId.ReadOnly = true;
            this.AnalysisItemId.Visible = false;
            // 
            // AnalysisProductId
            // 
            this.AnalysisProductId.DataPropertyName = "AnalysisProductId";
            this.AnalysisProductId.HeaderText = "AnalysisProductId";
            this.AnalysisProductId.Name = "AnalysisProductId";
            this.AnalysisProductId.ReadOnly = true;
            this.AnalysisProductId.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date Requested";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time Requested";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TypeForFiltering
            // 
            this.TypeForFiltering.DataPropertyName = "TypeForFiltering";
            this.TypeForFiltering.HeaderText = "Type Of Sample";
            this.TypeForFiltering.Name = "TypeForFiltering";
            this.TypeForFiltering.ReadOnly = true;
            this.TypeForFiltering.Visible = false;
            // 
            // EngineerOne
            // 
            this.EngineerOne.DataPropertyName = "EngineerOne";
            this.EngineerOne.HeaderText = "EngineerOne";
            this.EngineerOne.Name = "EngineerOne";
            this.EngineerOne.ReadOnly = true;
            this.EngineerOne.Visible = false;
            // 
            // EngineerTwo
            // 
            this.EngineerTwo.DataPropertyName = "EngineerTwo";
            this.EngineerTwo.HeaderText = "EngineerTwo";
            this.EngineerTwo.Name = "EngineerTwo";
            this.EngineerTwo.ReadOnly = true;
            this.EngineerTwo.Visible = false;
            // 
            // EngineerOneEmpId
            // 
            this.EngineerOneEmpId.DataPropertyName = "EngineerOneEmpId";
            this.EngineerOneEmpId.HeaderText = "EngineerOneEmpId";
            this.EngineerOneEmpId.Name = "EngineerOneEmpId";
            this.EngineerOneEmpId.ReadOnly = true;
            this.EngineerOneEmpId.Visible = false;
            // 
            // EngineerTwoEmpId
            // 
            this.EngineerTwoEmpId.DataPropertyName = "EngineerTwoEmpId";
            this.EngineerTwoEmpId.HeaderText = "EngineerTwoEmpId";
            this.EngineerTwoEmpId.Name = "EngineerTwoEmpId";
            this.EngineerTwoEmpId.ReadOnly = true;
            this.EngineerTwoEmpId.Visible = false;
            // 
            // EngineerOneFullName
            // 
            this.EngineerOneFullName.DataPropertyName = "EngineerOneFullName";
            this.EngineerOneFullName.HeaderText = "Engineer One";
            this.EngineerOneFullName.Name = "EngineerOneFullName";
            this.EngineerOneFullName.ReadOnly = true;
            // 
            // EngineerTwoFullName
            // 
            this.EngineerTwoFullName.DataPropertyName = "EngineerTwoFullName";
            this.EngineerTwoFullName.HeaderText = "Engineer Two";
            this.EngineerTwoFullName.Name = "EngineerTwoFullName";
            this.EngineerTwoFullName.ReadOnly = true;
            // 
            // Engineer
            // 
            this.Engineer.DataPropertyName = "Engineer";
            this.Engineer.HeaderText = "Engineer";
            this.Engineer.Name = "Engineer";
            this.Engineer.ReadOnly = true;
            this.Engineer.Visible = false;
            // 
            // SamplesRequestedOverviewControl
            // 
            this.SamplesRequestedOverviewControl.AutoSize = true;
            this.SamplesRequestedOverviewControl.Depth = 0;
            this.SamplesRequestedOverviewControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SamplesRequestedOverviewControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SamplesRequestedOverviewControl.HighEmphasis = true;
            this.SamplesRequestedOverviewControl.Location = new System.Drawing.Point(25, 53);
            this.SamplesRequestedOverviewControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesRequestedOverviewControl.Name = "SamplesRequestedOverviewControl";
            this.SamplesRequestedOverviewControl.Size = new System.Drawing.Size(26, 17);
            this.SamplesRequestedOverviewControl.TabIndex = 25;
            this.SamplesRequestedOverviewControl.Text = "-----";
            // 
            // ViewSamplesRequestedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SamplesRequestedOverviewControl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SamplesRequestedCaption);
            this.Name = "ViewSamplesRequestedUserControl";
            this.Size = new System.Drawing.Size(1000, 500);
            ((System.ComponentModel.ISupportInitialize)(this.viewSampleRequestsMadeBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel SamplesRequestedCaption;
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
        private DataGridViewTextBoxColumn SampleIdAsString;
        private DataGridViewTextBoxColumn SampleId;
        private DataGridViewTextBoxColumn SampleDetailId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn AnalysisItemId;
        private DataGridViewTextBoxColumn AnalysisProductId;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn TypeForFiltering;
        private DataGridViewTextBoxColumn EngineerOne;
        private DataGridViewTextBoxColumn EngineerTwo;
        private DataGridViewTextBoxColumn EngineerOneEmpId;
        private DataGridViewTextBoxColumn EngineerTwoEmpId;
        private DataGridViewTextBoxColumn EngineerOneFullName;
        private DataGridViewTextBoxColumn EngineerTwoFullName;
        private DataGridViewTextBoxColumn Engineer;
        private Button button1;
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
    }
}
