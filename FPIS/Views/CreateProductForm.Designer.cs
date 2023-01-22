namespace FPIS.Views
{
    partial class CreateProductForm
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
            this.materialTextBoxProductName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonCreateProduct = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelProductNameError = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialTextBoxProductName
            // 
            this.materialTextBoxProductName.AnimateReadOnly = false;
            this.materialTextBoxProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxProductName.Depth = 0;
            this.materialTextBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxProductName.HideSelection = true;
            this.materialTextBoxProductName.Hint = "Name";
            this.materialTextBoxProductName.LeadingIcon = null;
            this.materialTextBoxProductName.Location = new System.Drawing.Point(18, 110);
            this.materialTextBoxProductName.MaxLength = 32767;
            this.materialTextBoxProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxProductName.Name = "materialTextBoxProductName";
            this.materialTextBoxProductName.PasswordChar = '\0';
            this.materialTextBoxProductName.PrefixSuffixText = null;
            this.materialTextBoxProductName.ReadOnly = false;
            this.materialTextBoxProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxProductName.SelectedText = "";
            this.materialTextBoxProductName.SelectionLength = 0;
            this.materialTextBoxProductName.SelectionStart = 0;
            this.materialTextBoxProductName.ShortcutsEnabled = true;
            this.materialTextBoxProductName.Size = new System.Drawing.Size(325, 48);
            this.materialTextBoxProductName.TabIndex = 0;
            this.materialTextBoxProductName.TabStop = false;
            this.materialTextBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxProductName.TrailingIcon = null;
            this.materialTextBoxProductName.UseSystemPasswordChar = false;
            // 
            // materialButtonCreateProduct
            // 
            this.materialButtonCreateProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCreateProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCreateProduct.Depth = 0;
            this.materialButtonCreateProduct.HighEmphasis = true;
            this.materialButtonCreateProduct.Icon = null;
            this.materialButtonCreateProduct.Location = new System.Drawing.Point(142, 202);
            this.materialButtonCreateProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCreateProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCreateProduct.Name = "materialButtonCreateProduct";
            this.materialButtonCreateProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCreateProduct.Size = new System.Drawing.Size(146, 36);
            this.materialButtonCreateProduct.TabIndex = 1;
            this.materialButtonCreateProduct.Text = "Create Product";
            this.materialButtonCreateProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCreateProduct.UseAccentColor = false;
            this.materialButtonCreateProduct.UseVisualStyleBackColor = true;
            this.materialButtonCreateProduct.Click += new System.EventHandler(this.materialButtonCreateProduct_Click);
            // 
            // materialLabelProductNameError
            // 
            this.materialLabelProductNameError.AutoSize = true;
            this.materialLabelProductNameError.Depth = 0;
            this.materialLabelProductNameError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelProductNameError.ForeColor = System.Drawing.Color.Red;
            this.materialLabelProductNameError.Location = new System.Drawing.Point(18, 161);
            this.materialLabelProductNameError.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelProductNameError.Name = "materialLabelProductNameError";
            this.materialLabelProductNameError.Size = new System.Drawing.Size(1, 0);
            this.materialLabelProductNameError.TabIndex = 0;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 267);
            this.Controls.Add(this.materialLabelProductNameError);
            this.Controls.Add(this.materialButtonCreateProduct);
            this.Controls.Add(this.materialTextBoxProductName);
            this.Name = "CreateProductForm";
            this.Text = "Create Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialTextBox2 materialTextBoxProductName;
        private MaterialSkin.Controls.MaterialButton materialButtonCreateProduct;
        public MaterialSkin.Controls.MaterialLabel materialLabelProductNameError;
    }
}