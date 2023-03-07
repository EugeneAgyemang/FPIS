namespace FPIS.Views
{
    partial class CreateAnalysisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.materialButtonRequestAnalysis = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(40, 95);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(16, 0, 3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Samples";
            // 
            // materialButtonAddSample
            // 
            this.materialButtonAddSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAddSample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddSample.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddSample.Depth = 0;
            this.materialButtonAddSample.HighEmphasis = true;
            this.materialButtonAddSample.Icon = null;
            this.materialButtonAddSample.Location = new System.Drawing.Point(841, 86);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(832, 225);
            this.dataGridView1.TabIndex = 3;
            // 
            // analysisSampleBindingItemBindingSource
            // 
            this.analysisSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleBindingItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.materialButtonRequestAnalysis.Size = new System.Drawing.Size(158, 36);
            this.materialButtonRequestAnalysis.TabIndex = 5;
            this.materialButtonRequestAnalysis.Text = "REQUEST ANALYSIS";
            this.materialButtonRequestAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRequestAnalysis.UseAccentColor = false;
            this.materialButtonRequestAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonRequestAnalysis.Click += new System.EventHandler(this.materialButtonRequestAnalysis_Click);
            // 
            // CreateAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 601);
            this.Controls.Add(this.materialButtonRequestAnalysis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButtonAddSample);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CreateAnalysisForm";
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
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource analysisSampleBindingItemBindingSource;
        private Button button1;
        private MaterialSkin.Controls.MaterialButton materialButtonRequestAnalysis;
    }
}