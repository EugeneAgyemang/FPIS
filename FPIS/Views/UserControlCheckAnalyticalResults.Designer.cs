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
            this.SamplesRequestedOverviewControl = new MaterialSkin.Controls.MaterialLabel();
            this.checkAnalyticalResultsBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAnalyticalParameterResultsBindingItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkAnalyticalParameterResultsBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialButtonPrintAnalyticalResult = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAnalysisRemarkError = new System.Windows.Forms.Label();
            this.textBoxAnalyticalRemark = new System.Windows.Forms.TextBox();
            this.materialButtonSaveAnalysisRemark = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialRadioButtonProductAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialRadioButtonWaterAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRequestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRequestTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisResultDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisResultTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Finished_Products_With_Results = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleResultDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleResultsDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalResultsBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).BeginInit();
            this.SuspendLayout();
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
            // checkAnalyticalResultsBindingItemBindingSource
            // 
            this.checkAnalyticalResultsBindingItemBindingSource.DataSource = typeof(FPIS.Models.CheckAnalyticalResultsBindingItem);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterName,
            this.ExpectedResult,
            this.ActualResult,
            this.Variance,
            this.Indicator});
            this.dataGridView1.Location = new System.Drawing.Point(81, 667);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(718, 345);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // ParameterName
            // 
            this.ParameterName.HeaderText = "Parameter Name";
            this.ParameterName.MinimumWidth = 6;
            this.ParameterName.Name = "ParameterName";
            // 
            // ExpectedResult
            // 
            this.ExpectedResult.HeaderText = "Expected Result";
            this.ExpectedResult.MinimumWidth = 6;
            this.ExpectedResult.Name = "ExpectedResult";
            // 
            // ActualResult
            // 
            this.ActualResult.HeaderText = "Actual Result";
            this.ActualResult.MinimumWidth = 6;
            this.ActualResult.Name = "ActualResult";
            // 
            // Variance
            // 
            this.Variance.HeaderText = "Variance";
            this.Variance.MinimumWidth = 6;
            this.Variance.Name = "Variance";
            // 
            // Indicator
            // 
            this.Indicator.DataPropertyName = "Indicator";
            this.Indicator.HeaderText = "Indicator";
            this.Indicator.MinimumWidth = 6;
            this.Indicator.Name = "Indicator";
            // 
            // checkAnalyticalParameterResultsBindingItemBindingSource1
            // 
            this.checkAnalyticalParameterResultsBindingItemBindingSource1.DataSource = typeof(FPIS.Models.CheckAnalyticalParameterResultsBindingItem);
            // 
            // checkAnalyticalParameterResultsBindingItemBindingSource
            // 
            this.checkAnalyticalParameterResultsBindingItemBindingSource.DataSource = typeof(FPIS.Models.CheckAnalyticalParameterResultsBindingItem);
            // 
            // materialButtonPrintAnalyticalResult
            // 
            this.materialButtonPrintAnalyticalResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintAnalyticalResult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintAnalyticalResult.Depth = 0;
            this.materialButtonPrintAnalyticalResult.HighEmphasis = true;
            this.materialButtonPrintAnalyticalResult.Icon = null;
            this.materialButtonPrintAnalyticalResult.Location = new System.Drawing.Point(383, 1027);
            this.materialButtonPrintAnalyticalResult.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonPrintAnalyticalResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintAnalyticalResult.Name = "materialButtonPrintAnalyticalResult";
            this.materialButtonPrintAnalyticalResult.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintAnalyticalResult.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintAnalyticalResult.TabIndex = 33;
            this.materialButtonPrintAnalyticalResult.Text = "Print";
            this.materialButtonPrintAnalyticalResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintAnalyticalResult.UseAccentColor = false;
            this.materialButtonPrintAnalyticalResult.UseVisualStyleBackColor = true;
            this.materialButtonPrintAnalyticalResult.Click += new System.EventHandler(this.materialButtonPrintAnalyticalResult_Click);
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
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(993, 49);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 44;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = false;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(548, 52);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 42;
            // 
            // materialButtonSearchAnalyticalResults
            // 
            this.materialButtonSearchAnalyticalResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchAnalyticalResults.Depth = 0;
            this.materialButtonSearchAnalyticalResults.HighEmphasis = true;
            this.materialButtonSearchAnalyticalResults.Icon = null;
            this.materialButtonSearchAnalyticalResults.Location = new System.Drawing.Point(898, 49);
            this.materialButtonSearchAnalyticalResults.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearchAnalyticalResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchAnalyticalResults.Name = "materialButtonSearchAnalyticalResults";
            this.materialButtonSearchAnalyticalResults.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchAnalyticalResults.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchAnalyticalResults.TabIndex = 41;
            this.materialButtonSearchAnalyticalResults.Text = "Search";
            this.materialButtonSearchAnalyticalResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchAnalyticalResults.UseAccentColor = false;
            this.materialButtonSearchAnalyticalResults.UseVisualStyleBackColor = true;
            this.materialButtonSearchAnalyticalResults.Click += new System.EventHandler(this.materialButtonSearchAnalyticalResults_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(155, 52);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialButtonSearchAnalyticalResults);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Location = new System.Drawing.Point(72, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1203, 128);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAnalysisRemarkError);
            this.groupBox2.Controls.Add(this.textBoxAnalyticalRemark);
            this.groupBox2.Controls.Add(this.materialButtonSaveAnalysisRemark);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(821, 660);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 352);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Analytical Remark";
            // 
            // labelAnalysisRemarkError
            // 
            this.labelAnalysisRemarkError.AutoSize = true;
            this.labelAnalysisRemarkError.BackColor = System.Drawing.SystemColors.Control;
            this.labelAnalysisRemarkError.Location = new System.Drawing.Point(32, 232);
            this.labelAnalysisRemarkError.Name = "labelAnalysisRemarkError";
            this.labelAnalysisRemarkError.Size = new System.Drawing.Size(177, 20);
            this.labelAnalysisRemarkError.TabIndex = 13;
            this.labelAnalysisRemarkError.Text = "labelAnalysisRemarkError";
            // 
            // textBoxAnalyticalRemark
            // 
            this.textBoxAnalyticalRemark.Location = new System.Drawing.Point(35, 109);
            this.textBoxAnalyticalRemark.Multiline = true;
            this.textBoxAnalyticalRemark.Name = "textBoxAnalyticalRemark";
            this.textBoxAnalyticalRemark.Size = new System.Drawing.Size(481, 108);
            this.textBoxAnalyticalRemark.TabIndex = 60;
            // 
            // materialButtonSaveAnalysisRemark
            // 
            this.materialButtonSaveAnalysisRemark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSaveAnalysisRemark.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSaveAnalysisRemark.Depth = 0;
            this.materialButtonSaveAnalysisRemark.HighEmphasis = true;
            this.materialButtonSaveAnalysisRemark.Icon = null;
            this.materialButtonSaveAnalysisRemark.Location = new System.Drawing.Point(247, 279);
            this.materialButtonSaveAnalysisRemark.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSaveAnalysisRemark.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSaveAnalysisRemark.Name = "materialButtonSaveAnalysisRemark";
            this.materialButtonSaveAnalysisRemark.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSaveAnalysisRemark.Size = new System.Drawing.Size(64, 36);
            this.materialButtonSaveAnalysisRemark.TabIndex = 12;
            this.materialButtonSaveAnalysisRemark.Text = "Save";
            this.materialButtonSaveAnalysisRemark.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSaveAnalysisRemark.UseAccentColor = false;
            this.materialButtonSaveAnalysisRemark.UseVisualStyleBackColor = true;
            this.materialButtonSaveAnalysisRemark.Click += new System.EventHandler(this.materialButtonSaveAnalysisRemark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter your Remark";
            // 
            // materialRadioButtonProductAnalysis
            // 
            this.materialRadioButtonProductAnalysis.AutoSize = true;
            this.materialRadioButtonProductAnalysis.Checked = true;
            this.materialRadioButtonProductAnalysis.Depth = 0;
            this.materialRadioButtonProductAnalysis.Location = new System.Drawing.Point(36, 33);
            this.materialRadioButtonProductAnalysis.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonProductAnalysis.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonProductAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonProductAnalysis.Name = "materialRadioButtonProductAnalysis";
            this.materialRadioButtonProductAnalysis.Ripple = true;
            this.materialRadioButtonProductAnalysis.Size = new System.Drawing.Size(181, 37);
            this.materialRadioButtonProductAnalysis.TabIndex = 60;
            this.materialRadioButtonProductAnalysis.TabStop = true;
            this.materialRadioButtonProductAnalysis.Text = "For Product Analysis";
            this.materialRadioButtonProductAnalysis.UseVisualStyleBackColor = true;
            this.materialRadioButtonProductAnalysis.CheckedChanged += new System.EventHandler(this.materialRadioButtonProductAnalysis_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialRadioButtonWaterAnalysis);
            this.groupBox3.Controls.Add(this.materialRadioButtonProductAnalysis);
            this.groupBox3.Location = new System.Drawing.Point(517, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 87);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Analysis Type";
            // 
            // materialRadioButtonWaterAnalysis
            // 
            this.materialRadioButtonWaterAnalysis.AutoSize = true;
            this.materialRadioButtonWaterAnalysis.Depth = 0;
            this.materialRadioButtonWaterAnalysis.Location = new System.Drawing.Point(294, 33);
            this.materialRadioButtonWaterAnalysis.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButtonWaterAnalysis.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButtonWaterAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButtonWaterAnalysis.Name = "materialRadioButtonWaterAnalysis";
            this.materialRadioButtonWaterAnalysis.Ripple = true;
            this.materialRadioButtonWaterAnalysis.Size = new System.Drawing.Size(167, 37);
            this.materialRadioButtonWaterAnalysis.TabIndex = 61;
            this.materialRadioButtonWaterAnalysis.TabStop = true;
            this.materialRadioButtonWaterAnalysis.Text = "For Water Analysis";
            this.materialRadioButtonWaterAnalysis.UseVisualStyleBackColor = true;
            this.materialRadioButtonWaterAnalysis.CheckedChanged += new System.EventHandler(this.materialRadioButtonWaterAnalysis_CheckedChanged);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Analysis Item Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 168;
            // 
            // AnalysisType
            // 
            this.AnalysisType.DataPropertyName = "AnalysisType";
            this.AnalysisType.HeaderText = "AnalysisType";
            this.AnalysisType.MinimumWidth = 6;
            this.AnalysisType.Name = "AnalysisType";
            this.AnalysisType.Width = 168;
            // 
            // analysisRequestDateDataGridViewTextBoxColumn
            // 
            this.analysisRequestDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestDate";
            this.analysisRequestDateDataGridViewTextBoxColumn.HeaderText = "Analysis Request Date";
            this.analysisRequestDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisRequestDateDataGridViewTextBoxColumn.Name = "analysisRequestDateDataGridViewTextBoxColumn";
            this.analysisRequestDateDataGridViewTextBoxColumn.Width = 168;
            // 
            // analysisRequestTimeDataGridViewTextBoxColumn
            // 
            this.analysisRequestTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestTime";
            this.analysisRequestTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Request Time";
            this.analysisRequestTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisRequestTimeDataGridViewTextBoxColumn.Name = "analysisRequestTimeDataGridViewTextBoxColumn";
            this.analysisRequestTimeDataGridViewTextBoxColumn.Width = 169;
            // 
            // analysisResultDateDataGridViewTextBoxColumn
            // 
            this.analysisResultDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultDate";
            this.analysisResultDateDataGridViewTextBoxColumn.HeaderText = "Analysis Result Date";
            this.analysisResultDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisResultDateDataGridViewTextBoxColumn.Name = "analysisResultDateDataGridViewTextBoxColumn";
            this.analysisResultDateDataGridViewTextBoxColumn.Width = 168;
            // 
            // analysisResultTimeDataGridViewTextBoxColumn
            // 
            this.analysisResultTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultTime";
            this.analysisResultTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Result Time";
            this.analysisResultTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisResultTimeDataGridViewTextBoxColumn.Name = "analysisResultTimeDataGridViewTextBoxColumn";
            this.analysisResultTimeDataGridViewTextBoxColumn.Width = 168;
            // 
            // SampleDetailsId
            // 
            this.SampleDetailsId.DataPropertyName = "SampleDetailsId";
            this.SampleDetailsId.HeaderText = "SampleDetailsId";
            this.SampleDetailsId.MinimumWidth = 6;
            this.SampleDetailsId.Name = "SampleDetailsId";
            this.SampleDetailsId.Width = 168;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.SampleResultDetailsId,
            this.SampleResultsDetailsId});
            this.dataGridView_Finished_Products_With_Results.DataSource = this.checkAnalyticalResultsBindingItemBindingSource;
            this.dataGridView_Finished_Products_With_Results.Location = new System.Drawing.Point(72, 380);
            this.dataGridView_Finished_Products_With_Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Finished_Products_With_Results.MultiSelect = false;
            this.dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            this.dataGridView_Finished_Products_With_Results.ReadOnly = true;
            this.dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            this.dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            this.dataGridView_Finished_Products_With_Results.Size = new System.Drawing.Size(1398, 241);
            this.dataGridView_Finished_Products_With_Results.TabIndex = 62;
            this.dataGridView_Finished_Products_With_Results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Finished_Products_With_Results_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Analysis Item Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnalysisType";
            this.dataGridViewTextBoxColumn2.HeaderText = "AnalysisType";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnalysisRequestDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Analysis Request Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnalysisRequestTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "Analysis Request Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnalysisResultDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Analysis Result Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AnalysisResultTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "Analysis Result Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SampleDetailsId";
            this.dataGridViewTextBoxColumn7.HeaderText = "SampleDetailsId";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // SampleResultDetailsId
            // 
            this.SampleResultDetailsId.DataPropertyName = "SampleResultId";
            this.SampleResultDetailsId.HeaderText = "Sample Result Id";
            this.SampleResultDetailsId.MinimumWidth = 6;
            this.SampleResultDetailsId.Name = "SampleResultDetailsId";
            this.SampleResultDetailsId.ReadOnly = true;
            this.SampleResultDetailsId.Visible = false;
            // 
            // SampleResultsDetailsId
            // 
            this.SampleResultsDetailsId.DataPropertyName = "SampleResultDetailsId";
            this.SampleResultsDetailsId.HeaderText = "SampleResultDetailsId";
            this.SampleResultsDetailsId.MinimumWidth = 6;
            this.SampleResultsDetailsId.Name = "SampleResultsDetailsId";
            this.SampleResultsDetailsId.ReadOnly = true;
            this.SampleResultsDetailsId.Visible = false;
            // 
            // UserControlCheckAnalyticalResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridView_Finished_Products_With_Results);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButtonPrintAnalyticalResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SamplesRequestedOverviewControl);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UserControlCheckAnalyticalResults";
            this.Size = new System.Drawing.Size(1565, 1312);
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalResultsBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
        private DataGridView dataGridView1;
        private BindingSource checkAnalyticalResultsBindingItemBindingSource;
        private BindingSource checkAnalyticalParameterResultsBindingItemBindingSource;
        private BindingSource checkAnalyticalParameterResultsBindingItemBindingSource1;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintAnalyticalResult;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchAnalyticalResults;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private DataGridViewTextBoxColumn SampleResultId;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelAnalysisRemarkError;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveAnalysisRemark;
        private Label label1;
        private TextBox textBoxAnalyticalRemark;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonProductAnalysis;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonWaterAnalysis;
        private DataGridViewTextBoxColumn ParameterName;
        private DataGridViewTextBoxColumn ExpectedResult;
        private DataGridViewTextBoxColumn ActualResult;
        private DataGridViewTextBoxColumn Variance;
        private DataGridViewTextBoxColumn Indicator;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AnalysisType;
        private DataGridViewTextBoxColumn analysisRequestDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisRequestTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SampleDetailsId;
        private DataGridView dataGridView_Finished_Products_With_Results;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn SampleResultDetailsId;
        private DataGridViewTextBoxColumn SampleResultsDetailsId;
    }
}
