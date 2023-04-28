namespace FPIS.Views
{
    partial class UserControlCheckAnalyticalResults
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
            this.SamplesRequestedOverviewControl = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView_Finished_Products_With_Results = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRequestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRequestTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisResultDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisResultTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAnalyticalResultsBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkAnalyticalParameterResultsBindingItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkAnalyticalParameterResultsBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parameterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varianceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalResultsBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource)).BeginInit();
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
            this.materialLabel1.Size = new System.Drawing.Size(160, 24);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Analytical Results";
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
            this.SamplesRequestedOverviewControl.TabIndex = 26;
            this.SamplesRequestedOverviewControl.Text = "-----";
            // 
            // dataGridView_Finished_Products_With_Results
            // 
            this.dataGridView_Finished_Products_With_Results.AllowUserToAddRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeColumns = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeRows = false;
            this.dataGridView_Finished_Products_With_Results.AutoGenerateColumns = false;
            this.dataGridView_Finished_Products_With_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Finished_Products_With_Results.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Finished_Products_With_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Finished_Products_With_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.analysisRequestDateDataGridViewTextBoxColumn,
            this.analysisRequestTimeDataGridViewTextBoxColumn,
            this.analysisResultDateDataGridViewTextBoxColumn,
            this.analysisResultTimeDataGridViewTextBoxColumn});
            this.dataGridView_Finished_Products_With_Results.DataSource = this.checkAnalyticalResultsBindingItemBindingSource;
            this.dataGridView_Finished_Products_With_Results.Location = new System.Drawing.Point(26, 110);
            this.dataGridView_Finished_Products_With_Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Finished_Products_With_Results.MultiSelect = false;
            this.dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            this.dataGridView_Finished_Products_With_Results.ReadOnly = true;
            this.dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            this.dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            this.dataGridView_Finished_Products_With_Results.Size = new System.Drawing.Size(869, 241);
            this.dataGridView_Finished_Products_With_Results.TabIndex = 28;
            this.dataGridView_Finished_Products_With_Results.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Finished_Products_With_Results_CellClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analysisRequestDateDataGridViewTextBoxColumn
            // 
            this.analysisRequestDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestDate";
            this.analysisRequestDateDataGridViewTextBoxColumn.HeaderText = "Analysis Request Date";
            this.analysisRequestDateDataGridViewTextBoxColumn.Name = "analysisRequestDateDataGridViewTextBoxColumn";
            this.analysisRequestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analysisRequestTimeDataGridViewTextBoxColumn
            // 
            this.analysisRequestTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestTime";
            this.analysisRequestTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Request Time";
            this.analysisRequestTimeDataGridViewTextBoxColumn.Name = "analysisRequestTimeDataGridViewTextBoxColumn";
            this.analysisRequestTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analysisResultDateDataGridViewTextBoxColumn
            // 
            this.analysisResultDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultDate";
            this.analysisResultDateDataGridViewTextBoxColumn.HeaderText = "Analysis Result Date";
            this.analysisResultDateDataGridViewTextBoxColumn.Name = "analysisResultDateDataGridViewTextBoxColumn";
            this.analysisResultDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analysisResultTimeDataGridViewTextBoxColumn
            // 
            this.analysisResultTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultTime";
            this.analysisResultTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Result Time";
            this.analysisResultTimeDataGridViewTextBoxColumn.Name = "analysisResultTimeDataGridViewTextBoxColumn";
            this.analysisResultTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkAnalyticalResultsBindingItemBindingSource
            // 
            this.checkAnalyticalResultsBindingItemBindingSource.DataSource = typeof(FPIS.Models.CheckAnalyticalResultsBindingItem);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterNameDataGridViewTextBoxColumn,
            this.expectedDataGridViewTextBoxColumn,
            this.actualDataGridViewTextBoxColumn,
            this.varianceDataGridViewTextBoxColumn,
            this.Indicator});
            this.dataGridView1.DataSource = this.checkAnalyticalParameterResultsBindingItemBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(101, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(718, 150);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // checkAnalyticalParameterResultsBindingItemBindingSource1
            // 
            this.checkAnalyticalParameterResultsBindingItemBindingSource1.DataSource = typeof(FPIS.Models.CheckAnalyticalParameterResultsBindingItem);
            // 
            // checkAnalyticalParameterResultsBindingItemBindingSource
            // 
            this.checkAnalyticalParameterResultsBindingItemBindingSource.DataSource = typeof(FPIS.Models.CheckAnalyticalParameterResultsBindingItem);
            // 
            // parameterNameDataGridViewTextBoxColumn
            // 
            this.parameterNameDataGridViewTextBoxColumn.DataPropertyName = "ParameterName";
            this.parameterNameDataGridViewTextBoxColumn.HeaderText = "Parameter Name";
            this.parameterNameDataGridViewTextBoxColumn.Name = "parameterNameDataGridViewTextBoxColumn";
            // 
            // expectedDataGridViewTextBoxColumn
            // 
            this.expectedDataGridViewTextBoxColumn.DataPropertyName = "Expected";
            this.expectedDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.expectedDataGridViewTextBoxColumn.Name = "expectedDataGridViewTextBoxColumn";
            // 
            // actualDataGridViewTextBoxColumn
            // 
            this.actualDataGridViewTextBoxColumn.DataPropertyName = "Actual";
            this.actualDataGridViewTextBoxColumn.HeaderText = "Actual";
            this.actualDataGridViewTextBoxColumn.Name = "actualDataGridViewTextBoxColumn";
            // 
            // varianceDataGridViewTextBoxColumn
            // 
            this.varianceDataGridViewTextBoxColumn.DataPropertyName = "Variance";
            this.varianceDataGridViewTextBoxColumn.HeaderText = "Variance";
            this.varianceDataGridViewTextBoxColumn.Name = "varianceDataGridViewTextBoxColumn";
            // 
            // Indicator
            // 
            this.Indicator.DataPropertyName = "Indicator";
            this.Indicator.HeaderText = "Indicator";
            this.Indicator.Name = "Indicator";
            // 
            // UserControlCheckAnalyticalResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView_Finished_Products_With_Results);
            this.Controls.Add(this.SamplesRequestedOverviewControl);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UserControlCheckAnalyticalResults";
            this.Size = new System.Drawing.Size(920, 546);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalResultsBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
        private DataGridView dataGridView_Finished_Products_With_Results;
        private DataGridView dataGridView1;
        private BindingSource checkAnalyticalResultsBindingItemBindingSource;
        private BindingSource checkAnalyticalParameterResultsBindingItemBindingSource;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisRequestDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisRequestTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultTimeDataGridViewTextBoxColumn;
        private BindingSource checkAnalyticalParameterResultsBindingItemBindingSource1;
        private DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expectedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn varianceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Indicator;
    }
}
