namespace FPIS.Views
{
    partial class CreateAnalysisRequestForm
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
            this.materialButtonAddSample = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialButtonRequestAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialComboBoxEmployee2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxEmployee1 = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialButtonAddSample
            // 
            this.materialButtonAddSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAddSample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddSample.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddSample.Depth = 0;
            this.materialButtonAddSample.HighEmphasis = true;
            this.materialButtonAddSample.Icon = null;
            this.materialButtonAddSample.Location = new System.Drawing.Point(733, 222);
            this.materialButtonAddSample.Margin = new System.Windows.Forms.Padding(16, 6, 4, 6);
            this.materialButtonAddSample.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddSample.Name = "materialButtonAddSample";
            this.materialButtonAddSample.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddSample.Size = new System.Drawing.Size(111, 36);
            this.materialButtonAddSample.TabIndex = 1;
            this.materialButtonAddSample.Text = "ADD SAMPLE";
            this.materialButtonAddSample.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddSample.UseAccentColor = false;
            this.materialButtonAddSample.UseVisualStyleBackColor = true;
            this.materialButtonAddSample.Click += new System.EventHandler(this.materialButtonAddSample_Click);
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
            this.selectedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.analysisSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(832, 317);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 767;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.selectedDataGridViewCheckBoxColumn.Visible = false;
            this.selectedDataGridViewCheckBoxColumn.Width = 150;
            // 
            // analysisSampleBindingItemBindingSource
            // 
            this.analysisSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleBindingItem);
            // 
            // materialButtonRequestAnalysis
            // 
            this.materialButtonRequestAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonRequestAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonRequestAnalysis.Depth = 0;
            this.materialButtonRequestAnalysis.HighEmphasis = true;
            this.materialButtonRequestAnalysis.Icon = null;
            this.materialButtonRequestAnalysis.Location = new System.Drawing.Point(656, 610);
            this.materialButtonRequestAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRequestAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRequestAnalysis.Name = "materialButtonRequestAnalysis";
            this.materialButtonRequestAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRequestAnalysis.Size = new System.Drawing.Size(188, 36);
            this.materialButtonRequestAnalysis.TabIndex = 5;
            this.materialButtonRequestAnalysis.Text = "REQUEST For ANALYSIS";
            this.materialButtonRequestAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRequestAnalysis.UseAccentColor = false;
            this.materialButtonRequestAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonRequestAnalysis.Click += new System.EventHandler(this.materialButtonRequestAnalysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selected Samples";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Analysis Request";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialComboBoxEmployee2);
            this.groupBox1.Controls.Add(this.materialComboBoxEmployee1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production Engineer 1 and 2";
            // 
            // materialComboBoxEmployee2
            // 
            this.materialComboBoxEmployee2.AutoResize = false;
            this.materialComboBoxEmployee2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxEmployee2.Depth = 0;
            this.materialComboBoxEmployee2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxEmployee2.DropDownHeight = 174;
            this.materialComboBoxEmployee2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxEmployee2.DropDownWidth = 121;
            this.materialComboBoxEmployee2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxEmployee2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxEmployee2.FormattingEnabled = true;
            this.materialComboBoxEmployee2.IntegralHeight = false;
            this.materialComboBoxEmployee2.ItemHeight = 43;
            this.materialComboBoxEmployee2.Location = new System.Drawing.Point(427, 38);
            this.materialComboBoxEmployee2.MaxDropDownItems = 4;
            this.materialComboBoxEmployee2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployee2.Name = "materialComboBoxEmployee2";
            this.materialComboBoxEmployee2.Size = new System.Drawing.Size(386, 49);
            this.materialComboBoxEmployee2.StartIndex = 0;
            this.materialComboBoxEmployee2.TabIndex = 9;
            // 
            // materialComboBoxEmployee1
            // 
            this.materialComboBoxEmployee1.AutoResize = false;
            this.materialComboBoxEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxEmployee1.Depth = 0;
            this.materialComboBoxEmployee1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxEmployee1.DropDownHeight = 174;
            this.materialComboBoxEmployee1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxEmployee1.DropDownWidth = 121;
            this.materialComboBoxEmployee1.Enabled = false;
            this.materialComboBoxEmployee1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxEmployee1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxEmployee1.FormattingEnabled = true;
            this.materialComboBoxEmployee1.IntegralHeight = false;
            this.materialComboBoxEmployee1.ItemHeight = 43;
            this.materialComboBoxEmployee1.Location = new System.Drawing.Point(17, 39);
            this.materialComboBoxEmployee1.MaxDropDownItems = 4;
            this.materialComboBoxEmployee1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployee1.Name = "materialComboBoxEmployee1";
            this.materialComboBoxEmployee1.Size = new System.Drawing.Size(387, 49);
            this.materialComboBoxEmployee1.StartIndex = 0;
            this.materialComboBoxEmployee1.TabIndex = 8;
            // 
            // CreateAnalysisRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButtonRequestAnalysis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialButtonAddSample);
            this.Name = "CreateAnalysisRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonAddSample;
        private DataGridView dataGridView1;
        private BindingSource analysisSampleBindingItemBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButtonRequestAnalysis;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee1;
    }
}