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
            this.materialButtonCreateWater = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxWaterName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabelWaterNameError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialButtonCreateWater
            // 
            this.materialButtonCreateWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCreateWater.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCreateWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCreateWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCreateWater.Depth = 0;
            this.materialButtonCreateWater.HighEmphasis = true;
            this.materialButtonCreateWater.Icon = null;
            this.materialButtonCreateWater.Location = new System.Drawing.Point(161, 241);
            this.materialButtonCreateWater.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCreateWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCreateWater.Name = "materialButtonCreateWater";
            this.materialButtonCreateWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCreateWater.Size = new System.Drawing.Size(128, 36);
            this.materialButtonCreateWater.TabIndex = 1;
            this.materialButtonCreateWater.Text = "Create Water";
            this.materialButtonCreateWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCreateWater.UseAccentColor = true;
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
            this.materialTextBoxWaterName.Location = new System.Drawing.Point(25, 125);
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
            this.materialTextBoxWaterName.Size = new System.Drawing.Size(400, 48);
            this.materialTextBoxWaterName.TabIndex = 0;
            this.materialTextBoxWaterName.TabStop = false;
            this.materialTextBoxWaterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxWaterName.TrailingIcon = null;
            this.materialTextBoxWaterName.UseSystemPasswordChar = false;
            // 
            // materialLabelWaterNameError
            // 
            this.materialLabelWaterNameError.AutoSize = true;
            this.materialLabelWaterNameError.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelWaterNameError.ForeColor = System.Drawing.Color.Red;
            this.materialLabelWaterNameError.Location = new System.Drawing.Point(25, 176);
            this.materialLabelWaterNameError.Name = "materialLabelWaterNameError";
            this.materialLabelWaterNameError.Size = new System.Drawing.Size(0, 14);
            this.materialLabelWaterNameError.TabIndex = 20;
            // 
            // CreateWaterForm
            // 
            this.AcceptButton = this.materialButtonCreateWater;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.materialLabelWaterNameError);
            this.Controls.Add(this.materialButtonCreateWater);
            this.Controls.Add(this.materialTextBoxWaterName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateWaterForm";
            this.Padding = new System.Windows.Forms.Padding(2, 38, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Water";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonCreateWater;
        public MaterialSkin.Controls.MaterialTextBox2 materialTextBoxWaterName;
        private Label materialLabelWaterNameError;
    }
}