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
            this.labelItemName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisSampleParameterBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonSaveAndClose = new MaterialSkin.Controls.MaterialButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlLimitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleParameterBindingItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItemName.Location = new System.Drawing.Point(12, 28);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(288, 32);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Add Parameter Values for:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.methodColumn,
            this.ControlLimitColumn,
            this.specificationColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.analysisSampleParameterBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 301);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double click any cell in the \"Value\" column to add or edit a parameter\'s value";
            // 
            // materialButtonSaveAndClose
            // 
            this.materialButtonSaveAndClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSaveAndClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSaveAndClose.Depth = 0;
            this.materialButtonSaveAndClose.HighEmphasis = true;
            this.materialButtonSaveAndClose.Icon = null;
            this.materialButtonSaveAndClose.Location = new System.Drawing.Point(916, 33);
            this.materialButtonSaveAndClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSaveAndClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSaveAndClose.Name = "materialButtonSaveAndClose";
            this.materialButtonSaveAndClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSaveAndClose.Size = new System.Drawing.Size(140, 36);
            this.materialButtonSaveAndClose.TabIndex = 3;
            this.materialButtonSaveAndClose.Text = "Save and Close";
            this.materialButtonSaveAndClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSaveAndClose.UseAccentColor = false;
            this.materialButtonSaveAndClose.UseVisualStyleBackColor = true;
            this.materialButtonSaveAndClose.Click += new System.EventHandler(this.materialButtonSaveAndClose_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 150;
            // 
            // methodColumn
            // 
            this.methodColumn.DataPropertyName = "Method";
            this.methodColumn.HeaderText = "Method";
            this.methodColumn.MinimumWidth = 8;
            this.methodColumn.Name = "methodColumn";
            this.methodColumn.Width = 150;
            // 
            // ControlLimitColumn
            // 
            this.ControlLimitColumn.DataPropertyName = "ControlLimit";
            this.ControlLimitColumn.HeaderText = "ControlLimit";
            this.ControlLimitColumn.MinimumWidth = 8;
            this.ControlLimitColumn.Name = "ControlLimitColumn";
            this.ControlLimitColumn.Width = 150;
            // 
            // specificationColumn
            // 
            this.specificationColumn.DataPropertyName = "Specification";
            this.specificationColumn.HeaderText = "Specification";
            this.specificationColumn.MinimumWidth = 8;
            this.specificationColumn.Name = "specificationColumn";
            this.specificationColumn.Width = 150;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Result";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 150;
            // 
            // AddAnalysisParameterValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelItemName);
            this.Name = "AddAnalysisParameterValues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Parameter Values";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleParameterBindingItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelItemName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn analysisParameterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parameterNameDataGridViewTextBoxColumn;
        private BindingSource analysisSampleParameterBindingItemBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private GroupBox groupBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveAndClose;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn methodColumn;
        private DataGridViewTextBoxColumn ControlLimitColumn;
        private DataGridViewTextBoxColumn specificationColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}