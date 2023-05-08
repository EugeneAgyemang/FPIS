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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialRadioButtonWaterAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButtonProductAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerToTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFromTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SamplesRequestedCaption
            // 
            this.SamplesRequestedCaption.AutoSize = true;
            this.SamplesRequestedCaption.Depth = 0;
            this.SamplesRequestedCaption.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SamplesRequestedCaption.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.SamplesRequestedCaption.Location = new System.Drawing.Point(29, 17);
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
            this.labelSampleResultsTotal.Location = new System.Drawing.Point(29, 83);
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 435);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 343);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialRadioButtonWaterAnalysis);
            this.groupBox3.Controls.Add(this.materialRadioButtonProductAnalysis);
            this.groupBox3.Location = new System.Drawing.Point(29, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 87);
            this.groupBox3.TabIndex = 62;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialButtonShowAll);
            this.groupBox1.Controls.Add(this.materialButtonSearchAnalyticalResults);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Location = new System.Drawing.Point(29, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 80);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Sample Request Date";
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(837, 27);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 44;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = true;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // materialButtonSearchAnalyticalResults
            // 
            this.materialButtonSearchAnalyticalResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchAnalyticalResults.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchAnalyticalResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchAnalyticalResults.Depth = 0;
            this.materialButtonSearchAnalyticalResults.HighEmphasis = true;
            this.materialButtonSearchAnalyticalResults.Icon = null;
            this.materialButtonSearchAnalyticalResults.Location = new System.Drawing.Point(742, 27);
            this.materialButtonSearchAnalyticalResults.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearchAnalyticalResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchAnalyticalResults.Name = "materialButtonSearchAnalyticalResults";
            this.materialButtonSearchAnalyticalResults.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchAnalyticalResults.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchAnalyticalResults.TabIndex = 41;
            this.materialButtonSearchAnalyticalResults.Text = "Search";
            this.materialButtonSearchAnalyticalResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchAnalyticalResults.UseAccentColor = true;
            this.materialButtonSearchAnalyticalResults.UseVisualStyleBackColor = true;
            this.materialButtonSearchAnalyticalResults.Click += new System.EventHandler(this.materialButtonSearchAnalyticalResults_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(401, 31);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(92, 31);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton1);
            this.groupBox2.Controls.Add(this.materialButton2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePickerToTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePickerFromTime);
            this.groupBox2.Location = new System.Drawing.Point(29, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 83);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Then by Sample Request Time";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(837, 32);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(93, 36);
            this.materialButton1.TabIndex = 44;
            this.materialButton1.Text = "Show All";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(742, 32);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(78, 36);
            this.materialButton2.TabIndex = 41;
            this.materialButton2.Text = "Search";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = true;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "To :";
            // 
            // dateTimePickerToTime
            // 
            this.dateTimePickerToTime.CustomFormat = "hh:mm tt";
            this.dateTimePickerToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToTime.Location = new System.Drawing.Point(401, 37);
            this.dateTimePickerToTime.Name = "dateTimePickerToTime";
            this.dateTimePickerToTime.ShowUpDown = true;
            this.dateTimePickerToTime.Size = new System.Drawing.Size(125, 27);
            this.dateTimePickerToTime.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "From :";
            // 
            // dateTimePickerFromTime
            // 
            this.dateTimePickerFromTime.CustomFormat = "hh:mm tt";
            this.dateTimePickerFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromTime.Location = new System.Drawing.Point(92, 33);
            this.dateTimePickerFromTime.Name = "dateTimePickerFromTime";
            this.dateTimePickerFromTime.ShowUpDown = true;
            this.dateTimePickerFromTime.Size = new System.Drawing.Size(125, 27);
            this.dateTimePickerFromTime.TabIndex = 39;
            // 
            // UserControlViewSampleResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSampleResultsTotal);
            this.Controls.Add(this.SamplesRequestedCaption);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UserControlViewSampleResults";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonWaterAnalysis;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonProductAnalysis;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchAnalyticalResults;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private Label label1;
        private DateTimePicker dateTimePickerToTime;
        private Label label2;
        private DateTimePicker dateTimePickerFromTime;
    }
}
