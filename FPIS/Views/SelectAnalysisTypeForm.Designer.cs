namespace FPIS.Views
{
    partial class SelectAnalysisTypeForm
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
            this.materialButtonProductionAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonWaterAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButtonProductionAnalysis
            // 
            this.materialButtonProductionAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonProductionAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonProductionAnalysis.Depth = 0;
            this.materialButtonProductionAnalysis.HighEmphasis = true;
            this.materialButtonProductionAnalysis.Icon = null;
            this.materialButtonProductionAnalysis.Location = new System.Drawing.Point(13, 79);
            this.materialButtonProductionAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonProductionAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonProductionAnalysis.Name = "materialButtonProductionAnalysis";
            this.materialButtonProductionAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonProductionAnalysis.Size = new System.Drawing.Size(185, 36);
            this.materialButtonProductionAnalysis.TabIndex = 0;
            this.materialButtonProductionAnalysis.Text = "Production Analysis";
            this.materialButtonProductionAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonProductionAnalysis.UseAccentColor = false;
            this.materialButtonProductionAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonProductionAnalysis.Click += new System.EventHandler(this.materialButtonProductionAnalysis_Click);
            // 
            // materialButtonWaterAnalysis
            // 
            this.materialButtonWaterAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonWaterAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonWaterAnalysis.Depth = 0;
            this.materialButtonWaterAnalysis.HighEmphasis = true;
            this.materialButtonWaterAnalysis.Icon = null;
            this.materialButtonWaterAnalysis.Location = new System.Drawing.Point(294, 79);
            this.materialButtonWaterAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonWaterAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonWaterAnalysis.Name = "materialButtonWaterAnalysis";
            this.materialButtonWaterAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonWaterAnalysis.Size = new System.Drawing.Size(143, 36);
            this.materialButtonWaterAnalysis.TabIndex = 1;
            this.materialButtonWaterAnalysis.Text = "Water Analysis";
            this.materialButtonWaterAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonWaterAnalysis.UseAccentColor = false;
            this.materialButtonWaterAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonWaterAnalysis.Click += new System.EventHandler(this.materialButtonWaterAnalysis_Click);
            // 
            // SelectAnalysisTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 252);
            this.Controls.Add(this.materialButtonWaterAnalysis);
            this.Controls.Add(this.materialButtonProductionAnalysis);
            this.Name = "SelectAnalysisTypeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Analysis Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonProductionAnalysis;
        private MaterialSkin.Controls.MaterialButton materialButtonWaterAnalysis;
    }
}