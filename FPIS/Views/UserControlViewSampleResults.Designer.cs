namespace FPIS.Views
{
    partial class UserControlViewSampleResults
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
            this.labelSampleResultsTotal = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sampleResultIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.SamplesRequestedCaption.Size = new System.Drawing.Size(295, 24);
            this.SamplesRequestedCaption.TabIndex = 15;
            this.SamplesRequestedCaption.Text = "View and Update Sample Results";
            // 
            // labelSampleResultsTotal
            // 
            this.labelSampleResultsTotal.AutoSize = true;
            this.labelSampleResultsTotal.Depth = 0;
            this.labelSampleResultsTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSampleResultsTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelSampleResultsTotal.HighEmphasis = true;
            this.labelSampleResultsTotal.Location = new System.Drawing.Point(25, 62);
            this.labelSampleResultsTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSampleResultsTotal.Name = "labelSampleResultsTotal";
            this.labelSampleResultsTotal.Size = new System.Drawing.Size(26, 17);
            this.labelSampleResultsTotal.TabIndex = 26;
            this.labelSampleResultsTotal.Text = "-----";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sampleResultIdDataGridViewTextBoxColumn,
            this.analysisTypeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.resultDateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.updateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(858, 257);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sampleResultIdDataGridViewTextBoxColumn
            // 
            this.sampleResultIdDataGridViewTextBoxColumn.DataPropertyName = "SampleResultId";
            this.sampleResultIdDataGridViewTextBoxColumn.HeaderText = "SampleResultId";
            this.sampleResultIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sampleResultIdDataGridViewTextBoxColumn.Name = "sampleResultIdDataGridViewTextBoxColumn";
            this.sampleResultIdDataGridViewTextBoxColumn.Visible = false;
            this.sampleResultIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // analysisTypeDataGridViewTextBoxColumn
            // 
            this.analysisTypeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisType";
            this.analysisTypeDataGridViewTextBoxColumn.HeaderText = "Analysis Type";
            this.analysisTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.analysisTypeDataGridViewTextBoxColumn.Name = "analysisTypeDataGridViewTextBoxColumn";
            this.analysisTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lab Engineer";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // resultDateDataGridViewTextBoxColumn
            // 
            this.resultDateDataGridViewTextBoxColumn.DataPropertyName = "ResultDate";
            this.resultDateDataGridViewTextBoxColumn.HeaderText = "Result Date";
            this.resultDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.resultDateDataGridViewTextBoxColumn.Name = "resultDateDataGridViewTextBoxColumn";
            this.resultDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sample";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sample Date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductionEngineerOne";
            this.dataGridViewTextBoxColumn7.HeaderText = "Production Engineer 1";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductionEngineerTwo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Production Engineer 2";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // updateDataGridViewTextBoxColumn
            // 
            this.updateDataGridViewTextBoxColumn.DataPropertyName = "Update";
            this.updateDataGridViewTextBoxColumn.HeaderText = "Update";
            this.updateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.updateDataGridViewTextBoxColumn.Name = "updateDataGridViewTextBoxColumn";
            this.updateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.updateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(FPIS.Models.AnalysisResultDataBindingItem);
            // 
            // UserControlViewSampleResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSampleResultsTotal);
            this.Controls.Add(this.SamplesRequestedCaption);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlViewSampleResults";
            this.Size = new System.Drawing.Size(900, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel SamplesRequestedCaption;
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel SamplesResultsOverviewControl;
        private MaterialSkin.Controls.MaterialLabel labelSampleResultsTotal;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sampleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionEngineerOneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionEngineerTwoDataGridViewTextBoxColumn;
        private BindingSource analysisResultDataBindingItemBindingSource;
        private DataGridViewTextBoxColumn sampleIdTextBoxColumn;
        private DataGridViewTextBoxColumn analysisTypeTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewLinkColumn updateLinkTextBoxColumn;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn sampleResultIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn resultDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewLinkColumn updateDataGridViewTextBoxColumn;
    }
}
