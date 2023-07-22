namespace FPIS.Views
{
    partial class UserControlViewSampleReport
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
            groupBox3 = new GroupBox();
            materialRadioButtonWaterAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButtonProductAnalysis = new MaterialSkin.Controls.MaterialRadioButton();
            SamplesRequestedOverviewControl = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            dateTimePickerToDate = new DateTimePicker();
            label4 = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            dataGridViewSampleResults = new DataGridView();
            Parameters = new DataGridViewTextBoxColumn();
            Units = new DataGridViewTextBoxColumn();
            Specification = new DataGridViewTextBoxColumn();
            AnalysisResults = new DataGridViewTextBoxColumn();
            AnalysisRequestDate = new DataGridViewTextBoxColumn();
            AnalysisResultDate = new DataGridViewTextBoxColumn();
            SampleDetailID = new DataGridViewTextBoxColumn();
            SampleResultID = new DataGridViewTextBoxColumn();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSampleResults).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(materialRadioButtonWaterAnalysis);
            groupBox3.Controls.Add(materialRadioButtonProductAnalysis);
            groupBox3.Location = new Point(25, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 87);
            groupBox3.TabIndex = 65;
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
            SamplesRequestedOverviewControl.TabIndex = 63;
            SamplesRequestedOverviewControl.Text = "-----";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(29, 17);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(139, 24);
            materialLabel1.TabIndex = 62;
            materialLabel1.Text = "Sample Results";
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
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Filters";
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
            // dataGridViewSampleResults
            // 
            dataGridViewSampleResults.BackgroundColor = SystemColors.Window;
            dataGridViewSampleResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSampleResults.Columns.AddRange(new DataGridViewColumn[] { Parameters, Units, Specification, AnalysisResults, AnalysisRequestDate, AnalysisResultDate, SampleDetailID, SampleResultID });
            dataGridViewSampleResults.Location = new Point(25, 250);
            dataGridViewSampleResults.Name = "dataGridViewSampleResults";
            dataGridViewSampleResults.RowHeadersWidth = 51;
            dataGridViewSampleResults.RowTemplate.Height = 29;
            dataGridViewSampleResults.Size = new Size(1203, 540);
            dataGridViewSampleResults.TabIndex = 66;
            // 
            // Parameters
            // 
            Parameters.HeaderText = "Parameters";
            Parameters.MinimumWidth = 6;
            Parameters.Name = "Parameters";
            Parameters.Width = 125;
            // 
            // Units
            // 
            Units.HeaderText = "Units";
            Units.MinimumWidth = 6;
            Units.Name = "Units";
            Units.Width = 125;
            // 
            // Specification
            // 
            Specification.HeaderText = "Specification / Control Limit";
            Specification.MinimumWidth = 6;
            Specification.Name = "Specification";
            Specification.Width = 250;
            // 
            // AnalysisResults
            // 
            AnalysisResults.HeaderText = "Analysis Results";
            AnalysisResults.MinimumWidth = 6;
            AnalysisResults.Name = "AnalysisResults";
            AnalysisResults.Width = 125;
            // 
            // AnalysisRequestDate
            // 
            AnalysisRequestDate.HeaderText = "Analysis Request Date";
            AnalysisRequestDate.MinimumWidth = 6;
            AnalysisRequestDate.Name = "AnalysisRequestDate";
            AnalysisRequestDate.Width = 180;
            // 
            // AnalysisResultDate
            // 
            AnalysisResultDate.HeaderText = "Analysis Result Date";
            AnalysisResultDate.MinimumWidth = 6;
            AnalysisResultDate.Name = "AnalysisResultDate";
            AnalysisResultDate.Width = 180;
            // 
            // SampleDetailID
            // 
            SampleDetailID.HeaderText = "Sample Detail ID";
            SampleDetailID.MinimumWidth = 6;
            SampleDetailID.Name = "SampleDetailID";
            SampleDetailID.Width = 125;
            // 
            // SampleResultID
            // 
            SampleResultID.HeaderText = "Sample Result ID";
            SampleResultID.MinimumWidth = 6;
            SampleResultID.Name = "SampleResultID";
            SampleResultID.Width = 125;
            // 
            // UserControlViewSampleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewSampleResults);
            Controls.Add(groupBox3);
            Controls.Add(SamplesRequestedOverviewControl);
            Controls.Add(materialLabel1);
            Controls.Add(groupBox1);
            Name = "UserControlViewSampleReport";
            Size = new Size(1365, 912);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSampleResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonWaterAnalysis;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButtonProductAnalysis;
        private MaterialSkin.Controls.MaterialLabel SamplesRequestedOverviewControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchAnalyticalResults;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private DataGridView dataGridViewSampleResults;
        private DataGridViewTextBoxColumn Parameters;
        private DataGridViewTextBoxColumn Units;
        private DataGridViewTextBoxColumn Specification;
        private DataGridViewTextBoxColumn AnalysisResults;
        private DataGridViewTextBoxColumn AnalysisRequestDate;
        private DataGridViewTextBoxColumn AnalysisResultDate;
        private DataGridViewTextBoxColumn SampleDetailID;
        private DataGridViewTextBoxColumn SampleResultID;
    }
}
