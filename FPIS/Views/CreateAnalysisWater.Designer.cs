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
            this.materialComboBoxWater = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialButtonAddAnalysisWater
            // 
            this.materialButtonAddAnalysisWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddAnalysisWater.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonAddAnalysisWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAddAnalysisWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddAnalysisWater.Depth = 0;
            this.materialButtonAddAnalysisWater.HighEmphasis = true;
            this.materialButtonAddAnalysisWater.Icon = null;
            this.materialButtonAddAnalysisWater.Location = new System.Drawing.Point(137, 212);
            this.materialButtonAddAnalysisWater.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButtonAddAnalysisWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddAnalysisWater.Name = "materialButtonAddAnalysisWater";
            this.materialButtonAddAnalysisWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddAnalysisWater.Size = new System.Drawing.Size(176, 36);
            this.materialButtonAddAnalysisWater.TabIndex = 1;
            this.materialButtonAddAnalysisWater.Text = "Add Analysis Water";
            this.materialButtonAddAnalysisWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddAnalysisWater.UseAccentColor = true;
            this.materialButtonAddAnalysisWater.UseVisualStyleBackColor = true;
            this.materialButtonAddAnalysisWater.Click += new System.EventHandler(this.materialButtonAddAnalysisWater_Click);
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
            this.materialComboBoxWater.Location = new System.Drawing.Point(25, 124);
            this.materialComboBoxWater.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBoxWater.MaxDropDownItems = 4;
            this.materialComboBoxWater.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxWater.Name = "materialComboBoxWater";
            this.materialComboBoxWater.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxWater.StartIndex = 0;
            this.materialComboBoxWater.TabIndex = 0;
            // 
            // CreateAnalysisWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.materialButtonAddAnalysisWater);
            this.Controls.Add(this.materialComboBoxWater);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateAnalysisWater";
            this.Padding = new System.Windows.Forms.Padding(2, 38, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Analysis Water";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButtonAddAnalysisWater;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxWater;
    }
}