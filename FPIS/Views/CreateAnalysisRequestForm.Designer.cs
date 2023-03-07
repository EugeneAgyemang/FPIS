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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonAddSample = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialButtonRequestAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxEmployee1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBoxEmployee2 = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Analysis Request";
            // 
            // materialButtonAddSample
            // 
            this.materialButtonAddSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAddSample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddSample.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddSample.Depth = 0;
            this.materialButtonAddSample.HighEmphasis = true;
            this.materialButtonAddSample.Icon = null;
            this.materialButtonAddSample.Location = new System.Drawing.Point(733, 135);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(832, 317);
            this.dataGridView1.TabIndex = 3;
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
            this.materialButtonRequestAnalysis.Location = new System.Drawing.Point(687, 506);
            this.materialButtonRequestAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRequestAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRequestAnalysis.Name = "materialButtonRequestAnalysis";
            this.materialButtonRequestAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRequestAnalysis.Size = new System.Drawing.Size(157, 36);
            this.materialButtonRequestAnalysis.TabIndex = 5;
            this.materialButtonRequestAnalysis.Text = "REQUEST ANALYSIS";
            this.materialButtonRequestAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRequestAnalysis.UseAccentColor = false;
            this.materialButtonRequestAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonRequestAnalysis.Click += new System.EventHandler(this.materialButtonRequestAnalysis_Click);
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
            this.materialComboBoxEmployee1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxEmployee1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxEmployee1.FormattingEnabled = true;
            this.materialComboBoxEmployee1.IntegralHeight = false;
            this.materialComboBoxEmployee1.ItemHeight = 43;
            this.materialComboBoxEmployee1.Location = new System.Drawing.Point(12, 55);
            this.materialComboBoxEmployee1.MaxDropDownItems = 4;
            this.materialComboBoxEmployee1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployee1.Name = "materialComboBoxEmployee1";
            this.materialComboBoxEmployee1.Size = new System.Drawing.Size(353, 49);
            this.materialComboBoxEmployee1.StartIndex = 0;
            this.materialComboBoxEmployee1.TabIndex = 6;
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
            this.materialComboBoxEmployee2.Location = new System.Drawing.Point(396, 55);
            this.materialComboBoxEmployee2.MaxDropDownItems = 4;
            this.materialComboBoxEmployee2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxEmployee2.Name = "materialComboBoxEmployee2";
            this.materialComboBoxEmployee2.Size = new System.Drawing.Size(353, 49);
            this.materialComboBoxEmployee2.StartIndex = 0;
            this.materialComboBoxEmployee2.TabIndex = 7;
            // 
            // CreateAnalysisRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 601);
            this.Controls.Add(this.materialComboBoxEmployee2);
            this.Controls.Add(this.materialComboBoxEmployee1);
            this.Controls.Add(this.materialButtonRequestAnalysis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialButtonAddSample);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CreateAnalysisRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButtonAddSample;
        private DataGridView dataGridView1;
        private BindingSource analysisSampleBindingItemBindingSource;
        private MaterialSkin.Controls.MaterialButton materialButtonRequestAnalysis;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee2;
    }
}