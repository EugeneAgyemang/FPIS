namespace FPIS.Views
{
    partial class CreateAnalysisWater
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
            this.materialButtonAddAnalysisWater = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxWater = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialButtonAddAnalysisWater
            // 
            this.materialButtonAddAnalysisWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddAnalysisWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddAnalysisWater.Depth = 0;
            this.materialButtonAddAnalysisWater.HighEmphasis = true;
            this.materialButtonAddAnalysisWater.Icon = null;
            this.materialButtonAddAnalysisWater.Location = new System.Drawing.Point(123, 212);
            this.materialButtonAddAnalysisWater.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddAnalysisWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddAnalysisWater.Name = "materialButtonAddAnalysisWater";
            this.materialButtonAddAnalysisWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddAnalysisWater.Size = new System.Drawing.Size(176, 36);
            this.materialButtonAddAnalysisWater.TabIndex = 4;
            this.materialButtonAddAnalysisWater.Text = "Add Analysis Water";
            this.materialButtonAddAnalysisWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddAnalysisWater.UseAccentColor = false;
            this.materialButtonAddAnalysisWater.UseVisualStyleBackColor = true;
            this.materialButtonAddAnalysisWater.Click += new System.EventHandler(this.materialButtonAddAnalysisWater_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Select Water";
            // 
            // materialComboBoxWater
            // 
            this.materialComboBoxWater.AutoResize = false;
            this.materialComboBoxWater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxWater.Depth = 0;
            this.materialComboBoxWater.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxWater.DropDownHeight = 174;
            this.materialComboBoxWater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxWater.DropDownWidth = 121;
            this.materialComboBoxWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxWater.FormattingEnabled = true;
            this.materialComboBoxWater.IntegralHeight = false;
            this.materialComboBoxWater.ItemHeight = 43;
            this.materialComboBoxWater.Location = new System.Drawing.Point(15, 129);
            this.materialComboBoxWater.MaxDropDownItems = 4;
            this.materialComboBoxWater.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxWater.Name = "materialComboBoxWater";
            this.materialComboBoxWater.Size = new System.Drawing.Size(416, 49);
            this.materialComboBoxWater.StartIndex = 0;
            this.materialComboBoxWater.TabIndex = 3;
            // 
            // CreateAnalysisWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 283);
            this.Controls.Add(this.materialButtonAddAnalysisWater);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialComboBoxWater);
            this.Name = "CreateAnalysisWater";
            this.Text = "Add Analysis Water";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonAddAnalysisWater;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxWater;
    }
}