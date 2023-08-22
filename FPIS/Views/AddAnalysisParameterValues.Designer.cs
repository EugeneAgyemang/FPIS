namespace FPIS.Views
{
    partial class AddAnalysisParameterValues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnalysisParameterValues));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisSampleParameterBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonSaveAndClose = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckboxShowNewParameters = new MaterialSkin.Controls.MaterialCheckbox();
            this.parameterValueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterValueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlLimitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parameterValueRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleParameterBindingItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterValueName,
            this.parameterValueId,
            this.unitDataGridViewTextBoxColumn,
            this.methodColumn,
            this.ControlLimitColumn,
            this.specificationColumn,
            this.parameterValue,
            this.parameterValueRemarks});
            this.dataGridView1.DataSource = this.analysisSampleParameterBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 302);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // analysisSampleParameterBindingItemBindingSource
            // 
            this.analysisSampleParameterBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleParameterBindingItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.materialButtonSaveAndClose);
            this.groupBox1.Location = new System.Drawing.Point(36, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1229, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double click any cell in the \"Value\" column to add or edit a parameter\'s value";
            // 
            // materialButtonSaveAndClose
            // 
            this.materialButtonSaveAndClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSaveAndClose.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSaveAndClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSaveAndClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSaveAndClose.Depth = 0;
            this.materialButtonSaveAndClose.HighEmphasis = true;
            this.materialButtonSaveAndClose.Icon = null;
            this.materialButtonSaveAndClose.Location = new System.Drawing.Point(1023, 20);
            this.materialButtonSaveAndClose.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.materialButtonSaveAndClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSaveAndClose.Name = "materialButtonSaveAndClose";
            this.materialButtonSaveAndClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSaveAndClose.Size = new System.Drawing.Size(140, 36);
            this.materialButtonSaveAndClose.TabIndex = 3;
            this.materialButtonSaveAndClose.Text = "Save and Close";
            this.materialButtonSaveAndClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSaveAndClose.UseAccentColor = true;
            this.materialButtonSaveAndClose.UseVisualStyleBackColor = true;
            this.materialButtonSaveAndClose.Click += new System.EventHandler(this.materialButtonSaveAndClose_Click);
            // 
            // materialCheckboxShowNewParameters
            // 
            this.materialCheckboxShowNewParameters.AutoSize = true;
            this.materialCheckboxShowNewParameters.Depth = 0;
            this.materialCheckboxShowNewParameters.Location = new System.Drawing.Point(990, 225);
            this.materialCheckboxShowNewParameters.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxShowNewParameters.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxShowNewParameters.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxShowNewParameters.Name = "materialCheckboxShowNewParameters";
            this.materialCheckboxShowNewParameters.ReadOnly = false;
            this.materialCheckboxShowNewParameters.Ripple = true;
            this.materialCheckboxShowNewParameters.Size = new System.Drawing.Size(192, 37);
            this.materialCheckboxShowNewParameters.TabIndex = 4;
            this.materialCheckboxShowNewParameters.Text = "Show new parameters";
            this.materialCheckboxShowNewParameters.UseVisualStyleBackColor = true;
            this.materialCheckboxShowNewParameters.Visible = false;
            this.materialCheckboxShowNewParameters.CheckedChanged += new System.EventHandler(this.materialCheckboxShowNewParameters_CheckedChanged);
            // 
            // parameterValueName
            // 
            this.parameterValueName.DataPropertyName = "Name";
            this.parameterValueName.HeaderText = "Name";
            this.parameterValueName.MinimumWidth = 8;
            this.parameterValueName.Name = "parameterValueName";
            this.parameterValueName.Width = 150;
            // 
            // parameterValueId
            // 
            this.parameterValueId.DataPropertyName = "Id";
            this.parameterValueId.HeaderText = "Id";
            this.parameterValueId.MinimumWidth = 8;
            this.parameterValueId.Name = "parameterValueId";
            this.parameterValueId.Visible = false;
            this.parameterValueId.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 133;
            // 
            // methodColumn
            // 
            this.methodColumn.DataPropertyName = "Method";
            this.methodColumn.HeaderText = "Method";
            this.methodColumn.MinimumWidth = 8;
            this.methodColumn.Name = "methodColumn";
            this.methodColumn.Width = 134;
            // 
            // ControlLimitColumn
            // 
            this.ControlLimitColumn.DataPropertyName = "ControlLimit";
            this.ControlLimitColumn.HeaderText = "ControlLimit";
            this.ControlLimitColumn.MinimumWidth = 8;
            this.ControlLimitColumn.Name = "ControlLimitColumn";
            this.ControlLimitColumn.Width = 134;
            // 
            // specificationColumn
            // 
            this.specificationColumn.DataPropertyName = "Specification";
            this.specificationColumn.HeaderText = "Specification";
            this.specificationColumn.MinimumWidth = 8;
            this.specificationColumn.Name = "specificationColumn";
            this.specificationColumn.Width = 133;
            // 
            // parameterValue
            // 
            this.parameterValue.DataPropertyName = "Value";
            this.parameterValue.HeaderText = "Result";
            this.parameterValue.MinimumWidth = 8;
            this.parameterValue.Name = "parameterValue";
            this.parameterValue.Width = 128;
            // 
            // parameterValueRemarks
            // 
            this.parameterValueRemarks.DataPropertyName = "Remarks";
            this.parameterValueRemarks.HeaderText = "Remarks";
            this.parameterValueRemarks.MinimumWidth = 8;
            this.parameterValueRemarks.Name = "parameterValueRemarks";
            this.parameterValueRemarks.Width = 350;
            // 
            // AddAnalysisParameterValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 617);
            this.Controls.Add(this.materialCheckboxShowNewParameters);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "AddAnalysisParameterValues";
            this.Padding = new System.Windows.Forms.Padding(4, 107, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Parameter Values";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleParameterBindingItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn analysisParameterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private BindingSource analysisSampleParameterBindingItemBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private GroupBox groupBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveAndClose;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxShowNewParameters;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parameterValueId;
        private DataGridViewTextBoxColumn parameterValueName;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn methodColumn;
        private DataGridViewTextBoxColumn ControlLimitColumn;
        private DataGridViewTextBoxColumn specificationColumn;
        private DataGridViewTextBoxColumn parameterValue;
        private DataGridViewTextBoxColumn parameterValueRemarks;
    }
}