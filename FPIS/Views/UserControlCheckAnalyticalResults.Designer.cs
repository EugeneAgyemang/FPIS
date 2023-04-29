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
            this.dataGridView_Finished_Products_With_Results = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRequestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRequestTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisResultDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisResultTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleResultDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAnalyticalResultsBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parameterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varianceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelItemCategoryError = new System.Windows.Forms.Label();
            this.materialComboBoxAnalysisType = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonResetRequestTypeFilter = new System.Windows.Forms.Button();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAnalysisRemarkError = new System.Windows.Forms.Label();
            this.textBoxAnalyticalRemark = new System.Windows.Forms.TextBox();
            this.materialButtonSaveAnalysisRemark = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalResultsBindingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // dataGridView_Finished_Products_With_Results
            // 
            this.dataGridView_Finished_Products_With_Results.AllowUserToAddRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeColumns = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeRows = false;
            this.dataGridView_Finished_Products_With_Results.AutoGenerateColumns = false;
            this.dataGridView_Finished_Products_With_Results.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Finished_Products_With_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Finished_Products_With_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.AnalysisType,
            this.analysisRequestDateDataGridViewTextBoxColumn,
            this.analysisRequestTimeDataGridViewTextBoxColumn,
            this.analysisResultDateDataGridViewTextBoxColumn,
            this.analysisResultTimeDataGridViewTextBoxColumn,
            this.SampleDetailsId,
            this.SampleResultDetailsId});
            this.dataGridView_Finished_Products_With_Results.DataSource = this.checkAnalyticalResultsBindingItemBindingSource;
            this.dataGridView_Finished_Products_With_Results.Location = new System.Drawing.Point(74, 322);
            this.dataGridView_Finished_Products_With_Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Finished_Products_With_Results.MultiSelect = false;
            this.dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            this.dataGridView_Finished_Products_With_Results.ReadOnly = true;
            this.dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            this.dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            this.dataGridView_Finished_Products_With_Results.Size = new System.Drawing.Size(1398, 241);
            this.dataGridView_Finished_Products_With_Results.TabIndex = 28;
            this.dataGridView_Finished_Products_With_Results.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Finished_Products_With_Results_CellClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Analysis Item Name";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 168;
            // 
            // AnalysisType
            // 
            this.AnalysisType.DataPropertyName = "AnalysisType";
            this.AnalysisType.HeaderText = "AnalysisType";
            this.AnalysisType.MinimumWidth = 6;
            this.AnalysisType.Name = "AnalysisType";
            this.AnalysisType.ReadOnly = true;
            this.AnalysisType.Width = 168;
            // 
            // analysisRequestDateDataGridViewTextBoxColumn
            // 
            this.analysisRequestDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestDate";
            this.analysisRequestDateDataGridViewTextBoxColumn.HeaderText = "Analysis Request Date";
            this.analysisRequestDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisRequestDateDataGridViewTextBoxColumn.Name = "analysisRequestDateDataGridViewTextBoxColumn";
            this.analysisRequestDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisRequestDateDataGridViewTextBoxColumn.Width = 168;
            // 
            // analysisRequestTimeDataGridViewTextBoxColumn
            // 
            this.analysisRequestTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestTime";
            this.analysisRequestTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Request Time";
            this.analysisRequestTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisRequestTimeDataGridViewTextBoxColumn.Name = "analysisRequestTimeDataGridViewTextBoxColumn";
            this.analysisRequestTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisRequestTimeDataGridViewTextBoxColumn.Width = 169;
            // 
            // analysisResultDateDataGridViewTextBoxColumn
            // 
            this.analysisResultDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultDate";
            this.analysisResultDateDataGridViewTextBoxColumn.HeaderText = "Analysis Result Date";
            this.analysisResultDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisResultDateDataGridViewTextBoxColumn.Name = "analysisResultDateDataGridViewTextBoxColumn";
            this.analysisResultDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisResultDateDataGridViewTextBoxColumn.Width = 168;
            // 
            // analysisResultTimeDataGridViewTextBoxColumn
            // 
            this.analysisResultTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultTime";
            this.analysisResultTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Result Time";
            this.analysisResultTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisResultTimeDataGridViewTextBoxColumn.Name = "analysisResultTimeDataGridViewTextBoxColumn";
            this.analysisResultTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisResultTimeDataGridViewTextBoxColumn.Width = 168;
            // 
            // SampleDetailsId
            // 
            this.SampleDetailsId.DataPropertyName = "SampleDetailsId";
            this.SampleDetailsId.HeaderText = "SampleDetailsId";
            this.SampleDetailsId.MinimumWidth = 6;
            this.SampleDetailsId.Name = "SampleDetailsId";
            this.SampleDetailsId.ReadOnly = true;
            this.SampleDetailsId.Width = 168;
            // 
            // SampleResultDetailsId
            // 
            this.SampleResultDetailsId.DataPropertyName = "SampleResultDetailsId";
            this.SampleResultDetailsId.HeaderText = "Sample Result Details Id";
            this.SampleResultDetailsId.MinimumWidth = 6;
            this.SampleResultDetailsId.Name = "SampleResultDetailsId";
            this.SampleResultDetailsId.ReadOnly = true;
            this.SampleResultDetailsId.Width = 168;
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
            this.dataGridView1.Location = new System.Drawing.Point(83, 601);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(718, 345);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // parameterNameDataGridViewTextBoxColumn
            // 
            this.parameterNameDataGridViewTextBoxColumn.DataPropertyName = "ParameterName";
            this.parameterNameDataGridViewTextBoxColumn.HeaderText = "Parameter Name";
            this.parameterNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parameterNameDataGridViewTextBoxColumn.Name = "parameterNameDataGridViewTextBoxColumn";
            // 
            // expectedDataGridViewTextBoxColumn
            // 
            this.expectedDataGridViewTextBoxColumn.DataPropertyName = "Expected";
            this.expectedDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.expectedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expectedDataGridViewTextBoxColumn.Name = "expectedDataGridViewTextBoxColumn";
            // 
            // actualDataGridViewTextBoxColumn
            // 
            this.actualDataGridViewTextBoxColumn.DataPropertyName = "Actual";
            this.actualDataGridViewTextBoxColumn.HeaderText = "Actual";
            this.actualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actualDataGridViewTextBoxColumn.Name = "actualDataGridViewTextBoxColumn";
            // 
            // varianceDataGridViewTextBoxColumn
            // 
            this.varianceDataGridViewTextBoxColumn.DataPropertyName = "Variance";
            this.varianceDataGridViewTextBoxColumn.HeaderText = "Variance";
            this.varianceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varianceDataGridViewTextBoxColumn.Name = "varianceDataGridViewTextBoxColumn";
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
            this.materialButtonPrintAnalyticalResult.Location = new System.Drawing.Point(385, 961);
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
            this.materialButtonShowAll.Location = new System.Drawing.Point(1108, 117);
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
            this.label3.Location = new System.Drawing.Point(355, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(393, 120);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 23);
            this.dateTimePickerToDate.TabIndex = 42;
            // 
            // materialButtonSearchAnalyticalResults
            // 
            this.materialButtonSearchAnalyticalResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchAnalyticalResults.Depth = 0;
            this.materialButtonSearchAnalyticalResults.HighEmphasis = true;
            this.materialButtonSearchAnalyticalResults.Icon = null;
            this.materialButtonSearchAnalyticalResults.Location = new System.Drawing.Point(1013, 117);
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
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(81, 120);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 23);
            this.dateTimePickerFromDate.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelItemCategoryError);
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialComboBoxAnalysisType);
            this.groupBox1.Controls.Add(this.materialButtonSearchAnalyticalResults);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonResetRequestTypeFilter);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Controls.Add(this.SwitchCaptionControl);
            this.groupBox1.Controls.Add(this.SwitchFilterControl);
            this.groupBox1.Location = new System.Drawing.Point(74, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 190);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Filters";
            // 
            // labelItemCategoryError
            // 
            this.labelItemCategoryError.AutoSize = true;
            this.labelItemCategoryError.Location = new System.Drawing.Point(674, 162);
            this.labelItemCategoryError.Name = "labelItemCategoryError";
            this.labelItemCategoryError.Size = new System.Drawing.Size(38, 15);
            this.labelItemCategoryError.TabIndex = 55;
            this.labelItemCategoryError.Text = "label5";
            // 
            // materialComboBoxAnalysisType
            // 
            this.materialComboBoxAnalysisType.AutoResize = false;
            this.materialComboBoxAnalysisType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxAnalysisType.Depth = 0;
            this.materialComboBoxAnalysisType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxAnalysisType.DropDownHeight = 174;
            this.materialComboBoxAnalysisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxAnalysisType.DropDownWidth = 121;
            this.materialComboBoxAnalysisType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxAnalysisType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxAnalysisType.FormattingEnabled = true;
            this.materialComboBoxAnalysisType.Hint = "Search by Analysis Type";
            this.materialComboBoxAnalysisType.IntegralHeight = false;
            this.materialComboBoxAnalysisType.ItemHeight = 43;
            this.materialComboBoxAnalysisType.Location = new System.Drawing.Point(674, 110);
            this.materialComboBoxAnalysisType.MaxDropDownItems = 4;
            this.materialComboBoxAnalysisType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxAnalysisType.Name = "materialComboBoxAnalysisType";
            this.materialComboBoxAnalysisType.Size = new System.Drawing.Size(257, 49);
            this.materialComboBoxAnalysisType.StartIndex = 0;
            this.materialComboBoxAnalysisType.TabIndex = 50;
            // 
            // buttonResetRequestTypeFilter
            // 
            this.buttonResetRequestTypeFilter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonResetRequestTypeFilter.Image = global::FPIS.Properties.Resources.reset_icon1;
            this.buttonResetRequestTypeFilter.Location = new System.Drawing.Point(931, 111);
            this.buttonResetRequestTypeFilter.Name = "buttonResetRequestTypeFilter";
            this.buttonResetRequestTypeFilter.Size = new System.Drawing.Size(49, 49);
            this.buttonResetRequestTypeFilter.TabIndex = 54;
            this.buttonResetRequestTypeFilter.UseVisualStyleBackColor = false;
            this.buttonResetRequestTypeFilter.Click += new System.EventHandler(this.buttonResetRequestTypeFilter_Click);
            // 
            // SwitchCaptionControl
            // 
            this.SwitchCaptionControl.AutoSize = true;
            this.SwitchCaptionControl.Depth = 0;
            this.SwitchCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchCaptionControl.Location = new System.Drawing.Point(34, 37);
            this.SwitchCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchCaptionControl.Name = "SwitchCaptionControl";
            this.SwitchCaptionControl.Size = new System.Drawing.Size(167, 17);
            this.SwitchCaptionControl.TabIndex = 53;
            this.SwitchCaptionControl.Text = "I\'m Searching by all Filters";
            // 
            // SwitchFilterControl
            // 
            this.SwitchFilterControl.AutoSize = true;
            this.SwitchFilterControl.Checked = true;
            this.SwitchFilterControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchFilterControl.Depth = 0;
            this.SwitchFilterControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwitchFilterControl.Location = new System.Drawing.Point(21, 62);
            this.SwitchFilterControl.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchFilterControl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchFilterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchFilterControl.Name = "SwitchFilterControl";
            this.SwitchFilterControl.Ripple = true;
            this.SwitchFilterControl.Size = new System.Drawing.Size(426, 37);
            this.SwitchFilterControl.TabIndex = 52;
            this.SwitchFilterControl.Text = "Turn Off Date filters to search only by Analysis Type";
            this.SwitchFilterControl.UseVisualStyleBackColor = true;
            this.SwitchFilterControl.CheckedChanged += new System.EventHandler(this.SwitchFilterControl_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAnalysisRemarkError);
            this.groupBox2.Controls.Add(this.textBoxAnalyticalRemark);
            this.groupBox2.Controls.Add(this.materialButtonSaveAnalysisRemark);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(823, 594);
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
            this.labelAnalysisRemarkError.Size = new System.Drawing.Size(140, 15);
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
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter your Remark";
            // 
            // UserControlCheckAnalyticalResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialButtonPrintAnalyticalResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView_Finished_Products_With_Results);
            this.Controls.Add(this.SamplesRequestedOverviewControl);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UserControlCheckAnalyticalResults";
            this.Size = new System.Drawing.Size(1565, 1312);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalResultsBindingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnalyticalParameterResultsBindingItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
        private DataGridView dataGridView_Finished_Products_With_Results;
        private DataGridView dataGridView1;
        private BindingSource checkAnalyticalResultsBindingItemBindingSource;
        private BindingSource checkAnalyticalParameterResultsBindingItemBindingSource;
        private BindingSource checkAnalyticalParameterResultsBindingItemBindingSource1;
        private DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expectedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn varianceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Indicator;
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
        private Label labelItemCategoryError;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxAnalysisType;
        private Button buttonResetRequestTypeFilter;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
        private GroupBox groupBox2;
        private Label labelAnalysisRemarkError;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveAnalysisRemark;
        private Label label1;
        private TextBox textBoxAnalyticalRemark;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AnalysisType;
        private DataGridViewTextBoxColumn analysisRequestDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisRequestTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SampleDetailsId;
        private DataGridViewTextBoxColumn SampleResultDetailsId;
    }
}
