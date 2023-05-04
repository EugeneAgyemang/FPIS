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
            this.SamplesRequestedOverviewControl = new MaterialSkin.Controls.MaterialLabel();
            this.SampleIdAsString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleIdAsStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerOneFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineerTwoFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.sampleIdAsStringDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.Time,
            this.Status,
            this.Type,
            this.EngineerOneFullName,
            this.EngineerTwoFullName});
            this.dataGridView1.DataSource = this.viewSampleRequestsMadeBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(914, 270);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SamplesRequestedOverviewControl
            // 
            this.SamplesRequestedOverviewControl.AutoSize = true;
            this.SamplesRequestedOverviewControl.Depth = 0;
            this.SamplesRequestedOverviewControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SamplesRequestedOverviewControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SamplesRequestedOverviewControl.HighEmphasis = true;
            this.SamplesRequestedOverviewControl.Location = new System.Drawing.Point(25, 62);
            this.SamplesRequestedOverviewControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesRequestedOverviewControl.Name = "SamplesRequestedOverviewControl";
            this.SamplesRequestedOverviewControl.Size = new System.Drawing.Size(26, 17);
            this.SamplesRequestedOverviewControl.TabIndex = 25;
            this.SamplesRequestedOverviewControl.Text = "-----";
            // 
            // SampleIdAsString
            // 
            this.SampleIdAsString.DataPropertyName = "SampleIdAsString";
            this.SampleIdAsString.HeaderText = "Sample Id";
            this.SampleIdAsString.Name = "SampleIdAsString";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date Requested";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 145;
            // 
            // sampleIdAsStringDataGridViewTextBoxColumn
            // 
            this.sampleIdAsStringDataGridViewTextBoxColumn.DataPropertyName = "SampleIdAsString";
            this.sampleIdAsStringDataGridViewTextBoxColumn.HeaderText = "Sample ID";
            this.sampleIdAsStringDataGridViewTextBoxColumn.Name = "sampleIdAsStringDataGridViewTextBoxColumn";
            this.sampleIdAsStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleIdAsStringDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SampleId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hidden";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time Requested";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 145;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Request Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 146;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeForFiltering";
            this.Type.HeaderText = "Request Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 145;
            // 
            // EngineerOneFullName
            // 
            this.EngineerOneFullName.DataPropertyName = "EngineerOneFullName";
            this.EngineerOneFullName.HeaderText = "Engineer One";
            this.EngineerOneFullName.Name = "EngineerOneFullName";
            this.EngineerOneFullName.ReadOnly = true;
            this.EngineerOneFullName.Width = 145;
            // 
            // EngineerTwoFullName
            // 
            this.EngineerTwoFullName.DataPropertyName = "EngineerTwoFullName";
            this.EngineerTwoFullName.HeaderText = "Engineer Two";
            this.EngineerTwoFullName.Name = "EngineerTwoFullName";
            this.EngineerTwoFullName.ReadOnly = true;
            this.EngineerTwoFullName.Width = 145;
            // 
            // ViewSamplesRequestedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SamplesRequestedOverviewControl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SamplesRequestedCaption);
            this.Name = "ViewSamplesRequestedUserControl";
            this.Size = new System.Drawing.Size(1000, 400);
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
        private DataGridViewTextBoxColumn SampleId;
        private DataGridViewTextBoxColumn SampleDetailId;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn AnalysisItemId;
        private DataGridViewTextBoxColumn AnalysisProductId;
        private DataGridViewTextBoxColumn EngineerOne;
        private DataGridViewTextBoxColumn EngineerTwo;
        private DataGridViewTextBoxColumn EngineerOneEmpId;
        private DataGridViewTextBoxColumn EngineerTwoEmpId;
        private Button button1;
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn SampleIdAsString;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn sampleIdAsStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn EngineerOneFullName;
        private DataGridViewTextBoxColumn EngineerTwoFullName;
    }
}
