namespace FPIS.Views
{
    partial class CreateWaterForm
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
            this.materialLabelWaterNameError = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonCreateWater = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxWaterName = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // materialLabelWaterNameError
            // 
            this.materialLabelWaterNameError.AutoSize = true;
            this.materialLabelWaterNameError.Depth = 0;
            this.materialLabelWaterNameError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelWaterNameError.ForeColor = System.Drawing.Color.Red;
            this.materialLabelWaterNameError.Location = new System.Drawing.Point(21, 150);
            this.materialLabelWaterNameError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabelWaterNameError.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelWaterNameError.Name = "materialLabelWaterNameError";
            this.materialLabelWaterNameError.Size = new System.Drawing.Size(1, 0);
            this.materialLabelWaterNameError.TabIndex = 2;
            // 
            // materialButtonCreateWater
            // 
            this.materialButtonCreateWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCreateWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCreateWater.Depth = 0;
            this.materialButtonCreateWater.HighEmphasis = true;
            this.materialButtonCreateWater.Icon = null;
            this.materialButtonCreateWater.Location = new System.Drawing.Point(175, 212);
            this.materialButtonCreateWater.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.materialButtonCreateWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCreateWater.Name = "materialButtonCreateWater";
            this.materialButtonCreateWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCreateWater.Size = new System.Drawing.Size(128, 36);
            this.materialButtonCreateWater.TabIndex = 4;
            this.materialButtonCreateWater.Text = "Create Water";
            this.materialButtonCreateWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCreateWater.UseAccentColor = false;
            this.materialButtonCreateWater.UseVisualStyleBackColor = true;
            this.materialButtonCreateWater.Click += new System.EventHandler(this.materialButtonCreateWater_Click);
            // 
            // materialTextBoxWaterName
            // 
            this.materialTextBoxWaterName.AnimateReadOnly = false;
            this.materialTextBoxWaterName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxWaterName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxWaterName.Depth = 0;
            this.materialTextBoxWaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxWaterName.HideSelection = true;
            this.materialTextBoxWaterName.Hint = "Name";
            this.materialTextBoxWaterName.LeadingIcon = null;
            this.materialTextBoxWaterName.Location = new System.Drawing.Point(21, 97);
            this.materialTextBoxWaterName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTextBoxWaterName.MaxLength = 32767;
            this.materialTextBoxWaterName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxWaterName.Name = "materialTextBoxWaterName";
            this.materialTextBoxWaterName.PasswordChar = '\0';
            this.materialTextBoxWaterName.PrefixSuffixText = null;
            this.materialTextBoxWaterName.ReadOnly = false;
            this.materialTextBoxWaterName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxWaterName.SelectedText = "";
            this.materialTextBoxWaterName.SelectionLength = 0;
            this.materialTextBoxWaterName.SelectionStart = 0;
            this.materialTextBoxWaterName.ShortcutsEnabled = true;
            this.materialTextBoxWaterName.Size = new System.Drawing.Size(449, 48);
            this.materialTextBoxWaterName.TabIndex = 3;
            this.materialTextBoxWaterName.TabStop = false;
            this.materialTextBoxWaterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxWaterName.TrailingIcon = null;
            this.materialTextBoxWaterName.UseSystemPasswordChar = false;
            // 
            // CreateWaterForm
            // 
            this.AcceptButton = this.materialButtonCreateWater;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.materialLabelWaterNameError);
            this.Controls.Add(this.materialButtonCreateWater);
            this.Controls.Add(this.materialTextBoxWaterName);
            this.Name = "CreateWaterForm";
            this.Text = "Create New Water";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialLabel materialLabelWaterNameError;
        private MaterialSkin.Controls.MaterialButton materialButtonCreateWater;
        public MaterialSkin.Controls.MaterialTextBox2 materialTextBoxWaterName;
    }
}