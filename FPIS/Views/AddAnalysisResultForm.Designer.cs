namespace FPIS.Views
{
    partial class AddAnalysisResultForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnalysisResultForm));
            this.labelAnalysisType = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisResultSampleDetailBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelEngineer2 = new System.Windows.Forms.Label();
            this.labelEngineer1 = new System.Windows.Forms.Label();
            this.ProductionEngineerTwoCaptionControl = new System.Windows.Forms.Label();
            this.ProductionEngineerOneCaptionControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterValuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButtonGenerateResult = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterValuesDataGridViewColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productOrWaterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisResultSampleDetailBindingItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAnalysisType
            // 
            this.labelAnalysisType.AutoSize = true;
            this.labelAnalysisType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnalysisType.Location = new System.Drawing.Point(6, 68);
            this.labelAnalysisType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAnalysisType.Name = "labelAnalysisType";
            this.labelAnalysisType.Size = new System.Drawing.Size(53, 25);
            this.labelAnalysisType.TabIndex = 1;
            this.labelAnalysisType.Text = "Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.Label,
            this.sampleIdDataGridViewTextBoxColumn1,
            this.analysisItemIdDataGridViewTextBoxColumn,
            this.parameterValuesDataGridViewColumn,
            this.productOrWaterIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.analysisResultSampleDetailBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 262);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // analysisResultSampleDetailBindingItemBindingSource
            // 
            this.analysisResultSampleDetailBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisResultSampleDetailBindingItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labelEngineer2);
            this.groupBox1.Controls.Add(this.labelEngineer1);
            this.groupBox1.Controls.Add(this.ProductionEngineerTwoCaptionControl);
            this.groupBox1.Controls.Add(this.ProductionEngineerOneCaptionControl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelAnalysisType);
            this.groupBox1.Location = new System.Drawing.Point(47, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.groupBox1.Size = new System.Drawing.Size(1021, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(249, 68);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(65, 25);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // labelEngineer2
            // 
            this.labelEngineer2.AutoSize = true;
            this.labelEngineer2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEngineer2.Location = new System.Drawing.Point(741, 68);
            this.labelEngineer2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEngineer2.Name = "labelEngineer2";
            this.labelEngineer2.Size = new System.Drawing.Size(102, 25);
            this.labelEngineer2.TabIndex = 6;
            this.labelEngineer2.Text = "Engineer 2";
            // 
            // labelEngineer1
            // 
            this.labelEngineer1.AutoSize = true;
            this.labelEngineer1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEngineer1.Location = new System.Drawing.Point(429, 68);
            this.labelEngineer1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEngineer1.Name = "labelEngineer1";
            this.labelEngineer1.Size = new System.Drawing.Size(102, 25);
            this.labelEngineer1.TabIndex = 5;
            this.labelEngineer1.Text = "Engineer 1";
            // 
            // ProductionEngineerTwoCaptionControl
            // 
            this.ProductionEngineerTwoCaptionControl.AutoSize = true;
            this.ProductionEngineerTwoCaptionControl.Location = new System.Drawing.Point(741, 33);
            this.ProductionEngineerTwoCaptionControl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProductionEngineerTwoCaptionControl.Name = "ProductionEngineerTwoCaptionControl";
            this.ProductionEngineerTwoCaptionControl.Size = new System.Drawing.Size(187, 25);
            this.ProductionEngineerTwoCaptionControl.TabIndex = 4;
            this.ProductionEngineerTwoCaptionControl.Text = "Production Engineer 2";
            // 
            // ProductionEngineerOneCaptionControl
            // 
            this.ProductionEngineerOneCaptionControl.AutoSize = true;
            this.ProductionEngineerOneCaptionControl.Location = new System.Drawing.Point(429, 33);
            this.ProductionEngineerOneCaptionControl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ProductionEngineerOneCaptionControl.Name = "ProductionEngineerOneCaptionControl";
            this.ProductionEngineerOneCaptionControl.Size = new System.Drawing.Size(187, 25);
            this.ProductionEngineerOneCaptionControl.TabIndex = 3;
            this.ProductionEngineerOneCaptionControl.Text = "Production Engineer 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // parameterValuesDataGridViewTextBoxColumn
            // 
            this.parameterValuesDataGridViewTextBoxColumn.DataPropertyName = "ParameterValues";
            this.parameterValuesDataGridViewTextBoxColumn.HeaderText = "Parameter";
            this.parameterValuesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parameterValuesDataGridViewTextBoxColumn.Name = "parameterValuesDataGridViewTextBoxColumn";
            this.parameterValuesDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialButtonGenerateResult
            // 
            this.materialButtonGenerateResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGenerateResult.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonGenerateResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonGenerateResult.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerateResult.Depth = 0;
            this.materialButtonGenerateResult.HighEmphasis = true;
            this.materialButtonGenerateResult.Icon = null;
            this.materialButtonGenerateResult.Location = new System.Drawing.Point(749, 270);
            this.materialButtonGenerateResult.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.materialButtonGenerateResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGenerateResult.Name = "materialButtonGenerateResult";
            this.materialButtonGenerateResult.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGenerateResult.Size = new System.Drawing.Size(224, 36);
            this.materialButtonGenerateResult.TabIndex = 4;
            this.materialButtonGenerateResult.Text = "Generate Analysis Result";
            this.materialButtonGenerateResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGenerateResult.UseAccentColor = true;
            this.materialButtonGenerateResult.UseVisualStyleBackColor = true;
            this.materialButtonGenerateResult.Click += new System.EventHandler(this.materialButtonGenerateResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Click on any cell in the parameter results column to add results";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 325;
            // 
            // Label
            // 
            this.Label.DataPropertyName = "Label";
            this.Label.HeaderText = "Label";
            this.Label.MinimumWidth = 8;
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            this.Label.Width = 150;
            // 
            // sampleIdDataGridViewTextBoxColumn1
            // 
            this.sampleIdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.sampleIdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.sampleIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sampleIdDataGridViewTextBoxColumn1.Name = "sampleIdDataGridViewTextBoxColumn1";
            this.sampleIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sampleIdDataGridViewTextBoxColumn1.Visible = false;
            this.sampleIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // analysisItemIdDataGridViewTextBoxColumn
            // 
            this.analysisItemIdDataGridViewTextBoxColumn.DataPropertyName = "AnalysisItemId";
            this.analysisItemIdDataGridViewTextBoxColumn.HeaderText = "AnalysisItemId";
            this.analysisItemIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.analysisItemIdDataGridViewTextBoxColumn.Name = "analysisItemIdDataGridViewTextBoxColumn";
            this.analysisItemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisItemIdDataGridViewTextBoxColumn.Visible = false;
            this.analysisItemIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // parameterValuesDataGridViewColumn
            // 
            this.parameterValuesDataGridViewColumn.DataPropertyName = "ParameterValues";
            this.parameterValuesDataGridViewColumn.HeaderText = "Parameter Results";
            this.parameterValuesDataGridViewColumn.MinimumWidth = 8;
            this.parameterValuesDataGridViewColumn.Name = "parameterValuesDataGridViewColumn";
            this.parameterValuesDataGridViewColumn.ReadOnly = true;
            this.parameterValuesDataGridViewColumn.Width = 326;
            // 
            // productOrWaterIdDataGridViewTextBoxColumn
            // 
            this.productOrWaterIdDataGridViewTextBoxColumn.DataPropertyName = "ProductOrWaterId";
            this.productOrWaterIdDataGridViewTextBoxColumn.HeaderText = "ProductOrWaterId";
            this.productOrWaterIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productOrWaterIdDataGridViewTextBoxColumn.Name = "productOrWaterIdDataGridViewTextBoxColumn";
            this.productOrWaterIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productOrWaterIdDataGridViewTextBoxColumn.Visible = false;
            this.productOrWaterIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // AddAnalysisResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialButtonGenerateResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "AddAnalysisResultForm";
            this.Padding = new System.Windows.Forms.Padding(4, 107, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Analysis Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisResultSampleDetailBindingItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelAnalysisType;
        private DataGridView dataGridView1;
        private BindingSource analysisResultSampleDetailBindingItemBindingSource;
        private GroupBox groupBox1;
        private Label labelEngineer2;
        private Label labelEngineer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label labelStatus;
        private DataGridViewTextBoxColumn parameterAndValueDictionaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn Button;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parameterValuesDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateResult;
        private Label label4;
        private Label ProductionEngineerTwoCaptionControl;
        private Label ProductionEngineerOneCaptionControl;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Label;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn analysisItemIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parameterValuesDataGridViewColumn;
        private DataGridViewTextBoxColumn productOrWaterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sampleIdDataGridViewTextBoxColumn1;
    }
}