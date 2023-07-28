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
            components = new System.ComponentModel.Container();
            SamplesRequestedOverviewControl = new MaterialSkin.Controls.MaterialLabel();
            checkAnalyticalResultsBindingItemBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ParameterName = new DataGridViewTextBoxColumn();
            ExpectedResult = new DataGridViewTextBoxColumn();
            ActualResult = new DataGridViewTextBoxColumn();
            Variance2 = new DataGridViewTextBoxColumn();
            Variance = new DataGridViewTextBoxColumn();
            Indicator = new DataGridViewTextBoxColumn();
            checkAnalyticalParameterResultsBindingItemBindingSource1 = new BindingSource(components);
            checkAnalyticalParameterResultsBindingItemBindingSource = new BindingSource(components);
            materialButtonPrintAnalyticalResult = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            dateTimePickerToDate = new DateTimePicker();
            materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            labelAnalysisRemarkError = new Label();
            textBoxAnalyticalRemark = new TextBox();
            materialButtonSaveAnalysisRemark = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            materialRadioButtonProductAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            groupBox3 = new GroupBox();
            materialRadioButtonWaterAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AnalysisType = new DataGridViewTextBoxColumn();
            analysisRequestDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            analysisRequestTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            analysisResultDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            analysisResultTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SampleDetailsId = new DataGridViewTextBoxColumn();
            dataGridView_Finished_Products_With_Results = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ProductType = new DataGridViewTextBoxColumn();
            SampleDetailLabel = new DataGridViewTextBoxColumn();
            AnalysisItem = new DataGridViewTextBoxColumn();
            SampleResultsDetailsId = new DataGridViewTextBoxColumn();
            SampleDetailId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            SampleResultDetailsId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)checkAnalyticalResultsBindingItemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkAnalyticalParameterResultsBindingItemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkAnalyticalParameterResultsBindingItemBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Finished_Products_With_Results).BeginInit();
            SuspendLayout();
            // 
            // SamplesRequestedOverviewControl
            // 
            SamplesRequestedOverviewControl.AutoSize = true;
            SamplesRequestedOverviewControl.Depth = 0;
            SamplesRequestedOverviewControl.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            SamplesRequestedOverviewControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            SamplesRequestedOverviewControl.HighEmphasis = true;
            SamplesRequestedOverviewControl.Location = new Point(25, 62);
            SamplesRequestedOverviewControl.MouseState = MaterialSkin.MouseState.HOVER;
            SamplesRequestedOverviewControl.Name = "SamplesRequestedOverviewControl";
            SamplesRequestedOverviewControl.Size = new Size(26, 17);
            SamplesRequestedOverviewControl.TabIndex = 26;
            SamplesRequestedOverviewControl.Text = "-----";
            // 
            // checkAnalyticalResultsBindingItemBindingSource
            // 
            checkAnalyticalResultsBindingItemBindingSource.DataSource = typeof(Models.CheckAnalyticalResultsBindingItem);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ParameterName, ExpectedResult, ActualResult, Variance2, Variance, Indicator });
            dataGridView1.Location = new Point(25, 496);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 345);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // ParameterName
            // 
            ParameterName.HeaderText = "Parameter Name";
            ParameterName.MinimumWidth = 6;
            ParameterName.Name = "ParameterName";
            ParameterName.Width = 133;
            // 
            // ExpectedResult
            // 
            ExpectedResult.HeaderText = "Expected Result";
            ExpectedResult.MinimumWidth = 6;
            ExpectedResult.Name = "ExpectedResult";
            ExpectedResult.Width = 75;
            // 
            // ActualResult
            // 
            ActualResult.HeaderText = "Actual Result";
            ActualResult.MinimumWidth = 6;
            ActualResult.Name = "ActualResult";
            ActualResult.Width = 70;
            // 
            // Variance2
            // 
            Variance2.HeaderText = "Min Variance";
            Variance2.MinimumWidth = 6;
            Variance2.Name = "Variance2";
            Variance2.Width = 125;
            // 
            // Variance
            // 
            Variance.HeaderText = "Max Variance ";
            Variance.MinimumWidth = 6;
            Variance.Name = "Variance";
            Variance.Width = 120;
            // 
            // Indicator
            // 
            Indicator.DataPropertyName = "Indicator";
            Indicator.HeaderText = "Indicator";
            Indicator.MinimumWidth = 6;
            Indicator.Name = "Indicator";
            Indicator.Width = 133;
            // 
            // checkAnalyticalParameterResultsBindingItemBindingSource1
            // 
            checkAnalyticalParameterResultsBindingItemBindingSource1.DataSource = typeof(Models.CheckAnalyticalParameterResultsBindingItem);
            // 
            // checkAnalyticalParameterResultsBindingItemBindingSource
            // 
            checkAnalyticalParameterResultsBindingItemBindingSource.DataSource = typeof(Models.CheckAnalyticalParameterResultsBindingItem);
            // 
            // materialButtonPrintAnalyticalResult
            // 
            materialButtonPrintAnalyticalResult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonPrintAnalyticalResult.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonPrintAnalyticalResult.Cursor = Cursors.Hand;
            materialButtonPrintAnalyticalResult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonPrintAnalyticalResult.Depth = 0;
            materialButtonPrintAnalyticalResult.HighEmphasis = true;
            materialButtonPrintAnalyticalResult.Icon = null;
            materialButtonPrintAnalyticalResult.Location = new Point(349, 846);
            materialButtonPrintAnalyticalResult.Margin = new Padding(4, 6, 4, 6);
            materialButtonPrintAnalyticalResult.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonPrintAnalyticalResult.Name = "materialButtonPrintAnalyticalResult";
            materialButtonPrintAnalyticalResult.NoAccentTextColor = Color.Empty;
            materialButtonPrintAnalyticalResult.Size = new Size(64, 36);
            materialButtonPrintAnalyticalResult.TabIndex = 33;
            materialButtonPrintAnalyticalResult.Text = "Print";
            materialButtonPrintAnalyticalResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonPrintAnalyticalResult.UseAccentColor = true;
            materialButtonPrintAnalyticalResult.UseVisualStyleBackColor = true;
            materialButtonPrintAnalyticalResult.Click += materialButtonPrintAnalyticalResult_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(25, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(160, 24);
            materialLabel1.TabIndex = 14;
            materialLabel1.Text = "Analytical Results";
            // 
            // materialButtonShowAll
            // 
            materialButtonShowAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonShowAll.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonShowAll.Cursor = Cursors.Hand;
            materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonShowAll.Depth = 0;
            materialButtonShowAll.HighEmphasis = true;
            materialButtonShowAll.Icon = null;
            materialButtonShowAll.Location = new Point(765, 17);
            materialButtonShowAll.Margin = new Padding(4, 6, 4, 6);
            materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonShowAll.Name = "materialButtonShowAll";
            materialButtonShowAll.NoAccentTextColor = Color.Empty;
            materialButtonShowAll.Size = new Size(93, 36);
            materialButtonShowAll.TabIndex = 44;
            materialButtonShowAll.Text = "Show All";
            materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonShowAll.UseAccentColor = true;
            materialButtonShowAll.UseVisualStyleBackColor = true;
            materialButtonShowAll.Click += materialButtonShowAll_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 27);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 43;
            label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(401, 24);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(250, 27);
            dateTimePickerToDate.TabIndex = 42;
            // 
            // materialButtonSearchAnalyticalResults
            // 
            materialButtonSearchAnalyticalResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSearchAnalyticalResults.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSearchAnalyticalResults.Cursor = Cursors.Hand;
            materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSearchAnalyticalResults.Depth = 0;
            materialButtonSearchAnalyticalResults.HighEmphasis = true;
            materialButtonSearchAnalyticalResults.Icon = null;
            materialButtonSearchAnalyticalResults.Location = new Point(670, 17);
            materialButtonSearchAnalyticalResults.Margin = new Padding(4, 6, 4, 6);
            materialButtonSearchAnalyticalResults.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSearchAnalyticalResults.Name = "materialButtonSearchAnalyticalResults";
            materialButtonSearchAnalyticalResults.NoAccentTextColor = Color.Empty;
            materialButtonSearchAnalyticalResults.Size = new Size(78, 36);
            materialButtonSearchAnalyticalResults.TabIndex = 41;
            materialButtonSearchAnalyticalResults.Text = "Search";
            materialButtonSearchAnalyticalResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSearchAnalyticalResults.UseAccentColor = true;
            materialButtonSearchAnalyticalResults.UseVisualStyleBackColor = true;
            materialButtonSearchAnalyticalResults.Click += materialButtonSearchAnalyticalResults_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 28);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 40;
            label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(92, 24);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(250, 27);
            dateTimePickerFromDate.TabIndex = 39;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialButtonShowAll);
            groupBox1.Controls.Add(materialButtonSearchAnalyticalResults);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePickerToDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerFromDate);
            groupBox1.Location = new Point(25, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1203, 70);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Filters";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelAnalysisRemarkError);
            groupBox2.Controls.Add(textBoxAnalyticalRemark);
            groupBox2.Controls.Add(materialButtonSaveAnalysisRemark);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(749, 496);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 345);
            groupBox2.TabIndex = 59;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Analytical Remark";
            // 
            // labelAnalysisRemarkError
            // 
            labelAnalysisRemarkError.AutoSize = true;
            labelAnalysisRemarkError.BackColor = SystemColors.Control;
            labelAnalysisRemarkError.Location = new Point(27, 232);
            labelAnalysisRemarkError.Name = "labelAnalysisRemarkError";
            labelAnalysisRemarkError.Size = new Size(177, 20);
            labelAnalysisRemarkError.TabIndex = 13;
            labelAnalysisRemarkError.Text = "labelAnalysisRemarkError";
            // 
            // textBoxAnalyticalRemark
            // 
            textBoxAnalyticalRemark.Location = new Point(30, 109);
            textBoxAnalyticalRemark.Multiline = true;
            textBoxAnalyticalRemark.Name = "textBoxAnalyticalRemark";
            textBoxAnalyticalRemark.Size = new Size(419, 108);
            textBoxAnalyticalRemark.TabIndex = 60;
            // 
            // materialButtonSaveAnalysisRemark
            // 
            materialButtonSaveAnalysisRemark.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveAnalysisRemark.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSaveAnalysisRemark.Cursor = Cursors.Hand;
            materialButtonSaveAnalysisRemark.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveAnalysisRemark.Depth = 0;
            materialButtonSaveAnalysisRemark.HighEmphasis = true;
            materialButtonSaveAnalysisRemark.Icon = null;
            materialButtonSaveAnalysisRemark.Location = new Point(217, 279);
            materialButtonSaveAnalysisRemark.Margin = new Padding(4, 6, 4, 6);
            materialButtonSaveAnalysisRemark.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSaveAnalysisRemark.Name = "materialButtonSaveAnalysisRemark";
            materialButtonSaveAnalysisRemark.NoAccentTextColor = Color.Empty;
            materialButtonSaveAnalysisRemark.Size = new Size(64, 36);
            materialButtonSaveAnalysisRemark.TabIndex = 12;
            materialButtonSaveAnalysisRemark.Text = "Save";
            materialButtonSaveAnalysisRemark.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSaveAnalysisRemark.UseAccentColor = true;
            materialButtonSaveAnalysisRemark.UseVisualStyleBackColor = true;
            materialButtonSaveAnalysisRemark.Click += materialButtonSaveAnalysisRemark_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 76);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 11;
            label1.Text = "Enter your Remark";
            // 
            // materialRadioButtonProductAnalysis
            // 
            materialRadioButtonProductAnalysis.AutoSize = true;
            materialRadioButtonProductAnalysis.Checked = true;
            materialRadioButtonProductAnalysis.Depth = 0;
            materialRadioButtonProductAnalysis.Location = new Point(36, 33);
            materialRadioButtonProductAnalysis.Margin = new Padding(0);
            materialRadioButtonProductAnalysis.MouseLocation = new Point(-1, -1);
            materialRadioButtonProductAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButtonProductAnalysis.Name = "materialRadioButtonProductAnalysis";
            materialRadioButtonProductAnalysis.Ripple = true;
            materialRadioButtonProductAnalysis.Size = new Size(181, 37);
            materialRadioButtonProductAnalysis.TabIndex = 60;
            materialRadioButtonProductAnalysis.TabStop = true;
            materialRadioButtonProductAnalysis.Text = "For Product Analysis";
            materialRadioButtonProductAnalysis.UseVisualStyleBackColor = true;
            materialRadioButtonProductAnalysis.CheckedChanged += materialRadioButtonProductAnalysis_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(materialRadioButtonWaterAnalysis);
            groupBox3.Controls.Add(materialRadioButtonProductAnalysis);
            groupBox3.Location = new Point(25, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 87);
            groupBox3.TabIndex = 61;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Analysis Type";
            // 
            // materialRadioButtonWaterAnalysis
            // 
            materialRadioButtonWaterAnalysis.AutoSize = true;
            materialRadioButtonWaterAnalysis.Depth = 0;
            materialRadioButtonWaterAnalysis.Location = new Point(294, 33);
            materialRadioButtonWaterAnalysis.Margin = new Padding(0);
            materialRadioButtonWaterAnalysis.MouseLocation = new Point(-1, -1);
            materialRadioButtonWaterAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButtonWaterAnalysis.Name = "materialRadioButtonWaterAnalysis";
            materialRadioButtonWaterAnalysis.Ripple = true;
            materialRadioButtonWaterAnalysis.Size = new Size(167, 37);
            materialRadioButtonWaterAnalysis.TabIndex = 61;
            materialRadioButtonWaterAnalysis.TabStop = true;
            materialRadioButtonWaterAnalysis.Text = "For Water Analysis";
            materialRadioButtonWaterAnalysis.UseVisualStyleBackColor = true;
            materialRadioButtonWaterAnalysis.CheckedChanged += materialRadioButtonWaterAnalysis_CheckedChanged;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Analysis Item Name";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 168;
            // 
            // AnalysisType
            // 
            AnalysisType.DataPropertyName = "AnalysisType";
            AnalysisType.HeaderText = "AnalysisType";
            AnalysisType.MinimumWidth = 6;
            AnalysisType.Name = "AnalysisType";
            AnalysisType.Width = 168;
            // 
            // analysisRequestDateDataGridViewTextBoxColumn
            // 
            analysisRequestDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestDate";
            analysisRequestDateDataGridViewTextBoxColumn.HeaderText = "Analysis Request Date";
            analysisRequestDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            analysisRequestDateDataGridViewTextBoxColumn.Name = "analysisRequestDateDataGridViewTextBoxColumn";
            analysisRequestDateDataGridViewTextBoxColumn.Width = 168;
            // 
            // analysisRequestTimeDataGridViewTextBoxColumn
            // 
            analysisRequestTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisRequestTime";
            analysisRequestTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Request Time";
            analysisRequestTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            analysisRequestTimeDataGridViewTextBoxColumn.Name = "analysisRequestTimeDataGridViewTextBoxColumn";
            analysisRequestTimeDataGridViewTextBoxColumn.Width = 169;
            // 
            // analysisResultDateDataGridViewTextBoxColumn
            // 
            analysisResultDateDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultDate";
            analysisResultDateDataGridViewTextBoxColumn.HeaderText = "Analysis Result Date";
            analysisResultDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            analysisResultDateDataGridViewTextBoxColumn.Name = "analysisResultDateDataGridViewTextBoxColumn";
            analysisResultDateDataGridViewTextBoxColumn.Width = 168;
            // 
            // analysisResultTimeDataGridViewTextBoxColumn
            // 
            analysisResultTimeDataGridViewTextBoxColumn.DataPropertyName = "AnalysisResultTime";
            analysisResultTimeDataGridViewTextBoxColumn.HeaderText = "Analysis Result Time";
            analysisResultTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            analysisResultTimeDataGridViewTextBoxColumn.Name = "analysisResultTimeDataGridViewTextBoxColumn";
            analysisResultTimeDataGridViewTextBoxColumn.Width = 168;
            // 
            // SampleDetailsId
            // 
            SampleDetailsId.DataPropertyName = "SampleDetailsId";
            SampleDetailsId.HeaderText = "SampleDetailsId";
            SampleDetailsId.MinimumWidth = 6;
            SampleDetailsId.Name = "SampleDetailsId";
            SampleDetailsId.Width = 168;
            // 
            // dataGridView_Finished_Products_With_Results
            // 
            dataGridView_Finished_Products_With_Results.AllowUserToAddRows = false;
            dataGridView_Finished_Products_With_Results.AllowUserToDeleteRows = false;
            dataGridView_Finished_Products_With_Results.AllowUserToResizeColumns = false;
            dataGridView_Finished_Products_With_Results.AllowUserToResizeRows = false;
            dataGridView_Finished_Products_With_Results.AutoGenerateColumns = false;
            dataGridView_Finished_Products_With_Results.BackgroundColor = SystemColors.Window;
            dataGridView_Finished_Products_With_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Finished_Products_With_Results.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ProductType, SampleDetailLabel, AnalysisItem, SampleResultsDetailsId, SampleDetailId, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, SampleResultDetailsId });
            dataGridView_Finished_Products_With_Results.DataSource = checkAnalyticalResultsBindingItemBindingSource;
            dataGridView_Finished_Products_With_Results.Location = new Point(25, 250);
            dataGridView_Finished_Products_With_Results.Margin = new Padding(3, 2, 3, 2);
            dataGridView_Finished_Products_With_Results.MultiSelect = false;
            dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            dataGridView_Finished_Products_With_Results.ReadOnly = true;
            dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            dataGridView_Finished_Products_With_Results.Size = new Size(1203, 241);
            dataGridView_Finished_Products_With_Results.TabIndex = 62;
            dataGridView_Finished_Products_With_Results.CellContentClick += dataGridView_Finished_Products_With_Results_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            dataGridViewTextBoxColumn1.HeaderText = "Analysis Item Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 224;
            // 
            // ProductType
            // 
            ProductType.DataPropertyName = "ProductType";
            ProductType.HeaderText = "ProductType";
            ProductType.MinimumWidth = 6;
            ProductType.Name = "ProductType";
            ProductType.ReadOnly = true;
            ProductType.Visible = false;
            ProductType.Width = 125;
            // 
            // SampleDetailLabel
            // 
            SampleDetailLabel.DataPropertyName = "SampleDetailLabel";
            SampleDetailLabel.HeaderText = "SampleDetailLabel";
            SampleDetailLabel.MinimumWidth = 6;
            SampleDetailLabel.Name = "SampleDetailLabel";
            SampleDetailLabel.ReadOnly = true;
            SampleDetailLabel.Visible = false;
            SampleDetailLabel.Width = 125;
            // 
            // AnalysisItem
            // 
            AnalysisItem.DataPropertyName = "AnalysisItem";
            AnalysisItem.HeaderText = "AnalysisItem";
            AnalysisItem.MinimumWidth = 6;
            AnalysisItem.Name = "AnalysisItem";
            AnalysisItem.ReadOnly = true;
            AnalysisItem.Visible = false;
            AnalysisItem.Width = 125;
            // 
            // SampleResultsDetailsId
            // 
            SampleResultsDetailsId.DataPropertyName = "SampleResultDetailsId";
            SampleResultsDetailsId.HeaderText = "SampleResultDetailsId";
            SampleResultsDetailsId.MinimumWidth = 6;
            SampleResultsDetailsId.Name = "SampleResultsDetailsId";
            SampleResultsDetailsId.ReadOnly = true;
            SampleResultsDetailsId.Visible = false;
            SampleResultsDetailsId.Width = 125;
            // 
            // SampleDetailId
            // 
            SampleDetailId.DataPropertyName = "SampleDetailId";
            SampleDetailId.HeaderText = "SampleDetailId";
            SampleDetailId.MinimumWidth = 6;
            SampleDetailId.Name = "SampleDetailId";
            SampleDetailId.ReadOnly = true;
            SampleDetailId.Visible = false;
            SampleDetailId.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "AnalysisType";
            dataGridViewTextBoxColumn2.HeaderText = "AnalysisType";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 224;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "AnalysisRequestDate";
            dataGridViewTextBoxColumn3.HeaderText = "Analysis Request Date";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "AnalysisRequestTime";
            dataGridViewTextBoxColumn4.HeaderText = "Analysis Request Time";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 224;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "AnalysisResultDate";
            dataGridViewTextBoxColumn5.HeaderText = "Analysis Result Date";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 224;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "AnalysisResultTime";
            dataGridViewTextBoxColumn6.HeaderText = "Analysis Result Time";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 224;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "SampleDetailsId";
            dataGridViewTextBoxColumn7.HeaderText = "SampleDetailsId";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Visible = false;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // SampleResultDetailsId
            // 
            SampleResultDetailsId.DataPropertyName = "SampleResultId";
            SampleResultDetailsId.HeaderText = "Sample Result Id";
            SampleResultDetailsId.MinimumWidth = 6;
            SampleResultDetailsId.Name = "SampleResultDetailsId";
            SampleResultDetailsId.ReadOnly = true;
            SampleResultDetailsId.Visible = false;
            SampleResultDetailsId.Width = 125;
            // 
            // UserControlCheckAnalyticalResults
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            Controls.Add(materialButtonPrintAnalyticalResult);
            Controls.Add(dataGridView_Finished_Products_With_Results);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(SamplesRequestedOverviewControl);
            Controls.Add(materialLabel1);
            Name = "UserControlCheckAnalyticalResults";
            Size = new Size(1365, 912);
            ((System.ComponentModel.ISupportInitialize)checkAnalyticalResultsBindingItemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkAnalyticalParameterResultsBindingItemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkAnalyticalParameterResultsBindingItemBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Finished_Products_With_Results).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn AnalysisType;
        private DataGridViewTextBoxColumn analysisRequestDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisRequestTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn analysisResultTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SampleDetailsId;
        private DataGridView dataGridView_Finished_Products_With_Results;
        private DataGridViewTextBoxColumn ParameterName;
        private DataGridViewTextBoxColumn ExpectedResult;
        private DataGridViewTextBoxColumn ActualResult;
        private DataGridViewTextBoxColumn Variance2;
        private DataGridViewTextBoxColumn Variance;
        private DataGridViewTextBoxColumn Indicator;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn SampleDetailLabel;
        private DataGridViewTextBoxColumn AnalysisItem;
        private DataGridViewTextBoxColumn SampleResultsDetailsId;
        private DataGridViewTextBoxColumn SampleDetailId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn SampleResultDetailsId;
    }
}
