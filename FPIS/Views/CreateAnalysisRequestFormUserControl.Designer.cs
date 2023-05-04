namespace FPIS.Views
{
    partial class CreateAnalysisRequestFormUserControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialComboBoxEmployee2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxEmployee1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonRequestAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelAnalysisRequestTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonAddSample = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialComboBoxEmployee2);
            this.groupBox1.Controls.Add(this.materialComboBoxEmployee1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(34, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(583, 88);
            this.groupBox1.TabIndex = 17;
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
            this.materialComboBoxEmployee2.Location = new System.Drawing.Point(300, 22);
            this.materialComboBoxEmployee2.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBoxEmployee2.MaxDropDownItems = 4;
            this.materialComboBoxEmployee2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployee2.Name = "materialComboBoxEmployee2";
            this.materialComboBoxEmployee2.Size = new System.Drawing.Size(272, 49);
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
            this.materialComboBoxEmployee1.Location = new System.Drawing.Point(13, 23);
            this.materialComboBoxEmployee1.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBoxEmployee1.MaxDropDownItems = 4;
            this.materialComboBoxEmployee1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployee1.Name = "materialComboBoxEmployee1";
            this.materialComboBoxEmployee1.Size = new System.Drawing.Size(272, 49);
            this.materialComboBoxEmployee1.StartIndex = 0;
            this.materialComboBoxEmployee1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selected Samples";
            // 
            // materialButtonRequestAnalysis
            // 
            this.materialButtonRequestAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonRequestAnalysis.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonRequestAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonRequestAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonRequestAnalysis.Depth = 0;
            this.materialButtonRequestAnalysis.HighEmphasis = true;
            this.materialButtonRequestAnalysis.Icon = null;
            this.materialButtonRequestAnalysis.Location = new System.Drawing.Point(429, 398);
            this.materialButtonRequestAnalysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButtonRequestAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRequestAnalysis.Name = "materialButtonRequestAnalysis";
            this.materialButtonRequestAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRequestAnalysis.Size = new System.Drawing.Size(188, 36);
            this.materialButtonRequestAnalysis.TabIndex = 14;
            this.materialButtonRequestAnalysis.Text = "Request for Analysis";
            this.materialButtonRequestAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRequestAnalysis.UseAccentColor = true;
            this.materialButtonRequestAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonRequestAnalysis.Click += new System.EventHandler(this.materialButtonRequestAnalysis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.selectedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.analysisSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(583, 190);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 519;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.selectedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // analysisSampleBindingItemBindingSource
            // 
            this.analysisSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleBindingItem);
            // 
            // labelAnalysisRequestTitle
            // 
            this.labelAnalysisRequestTitle.AutoSize = true;
            this.labelAnalysisRequestTitle.Depth = 0;
            this.labelAnalysisRequestTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAnalysisRequestTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAnalysisRequestTitle.Location = new System.Drawing.Point(25, 13);
            this.labelAnalysisRequestTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAnalysisRequestTitle.Name = "labelAnalysisRequestTitle";
            this.labelAnalysisRequestTitle.Size = new System.Drawing.Size(199, 24);
            this.labelAnalysisRequestTitle.TabIndex = 18;
            this.labelAnalysisRequestTitle.Text = "New Analysis Request";
            // 
            // materialButtonAddSample
            // 
            this.materialButtonAddSample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAddSample.Depth = 0;
            this.materialButtonAddSample.Icon = global::FPIS.Properties.Resources.add_white;
            this.materialButtonAddSample.Location = new System.Drawing.Point(577, 157);
            this.materialButtonAddSample.Mini = true;
            this.materialButtonAddSample.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddSample.Name = "materialButtonAddSample";
            this.materialButtonAddSample.Size = new System.Drawing.Size(40, 40);
            this.materialButtonAddSample.TabIndex = 22;
            this.materialButtonAddSample.Text = "materialFloatingActionButton1";
            this.materialButtonAddSample.UseVisualStyleBackColor = true;
            this.materialButtonAddSample.Click += new System.EventHandler(this.materialButtonAddSample_Click);
            // 
            // CreateAnalysisRequestFormUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButtonAddSample);
            this.Controls.Add(this.labelAnalysisRequestTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButtonRequestAnalysis);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateAnalysisRequestFormUserControl";
            this.Size = new System.Drawing.Size(650, 500);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonRequestAnalysis;
        private DataGridView dataGridView1;
        private BindingSource analysisSampleBindingItemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private MaterialSkin.Controls.MaterialLabel labelAnalysisRequestTitle;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialButtonAddSample;
    }
}
