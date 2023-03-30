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
            this.materialButtonCreateProduct = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxProductType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabelProductNameError = new System.Windows.Forms.Label();
            this.labelProductTypeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialButtonCreateProduct
            // 
            this.materialButtonCreateProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonCreateProduct.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonCreateProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonCreateProduct.Depth = 0;
            this.materialButtonCreateProduct.HighEmphasis = true;
            this.materialButtonCreateProduct.Icon = null;
            this.materialButtonCreateProduct.Location = new System.Drawing.Point(152, 329);
            this.materialButtonCreateProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonCreateProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonCreateProduct.Name = "materialButtonCreateProduct";
            this.materialButtonCreateProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonCreateProduct.Size = new System.Drawing.Size(146, 36);
            this.materialButtonCreateProduct.TabIndex = 1;
            this.materialButtonCreateProduct.Text = "Create Product";
            this.materialButtonCreateProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonCreateProduct.UseAccentColor = true;
            this.materialButtonCreateProduct.UseVisualStyleBackColor = true;
            this.materialButtonCreateProduct.Click += new System.EventHandler(this.materialButtonCreateProduct_Click);
            // 
            // materialComboBoxProductType
            // 
            this.materialComboBoxProductType.AutoResize = false;
            this.materialComboBoxProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxProductType.Depth = 0;
            this.materialComboBoxProductType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxProductType.DropDownHeight = 174;
            this.materialComboBoxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxProductType.DropDownWidth = 121;
            this.materialComboBoxProductType.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialComboBoxProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxProductType.FormattingEnabled = true;
            this.materialComboBoxProductType.Hint = "Type";
            this.materialComboBoxProductType.IntegralHeight = false;
            this.materialComboBoxProductType.ItemHeight = 43;
            this.materialComboBoxProductType.Items.AddRange(new object[] {
            "Raw Materials",
            "Finished Products",
            "Work In Progress"});
            this.materialComboBoxProductType.Location = new System.Drawing.Point(24, 212);
            this.materialComboBoxProductType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.materialComboBoxProductType.MaxDropDownItems = 4;
            this.materialComboBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxProductType.Name = "materialComboBoxProductType";
            this.materialComboBoxProductType.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxProductType.StartIndex = -1;
            this.materialComboBoxProductType.TabIndex = 26;
            // 
            // materialTextBoxProductName
            // 
            this.materialTextBoxProductName.AnimateReadOnly = false;
            this.materialTextBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxProductName.Depth = 0;
            this.materialTextBoxProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxProductName.Hint = "Name";
            this.materialTextBoxProductName.LeadingIcon = null;
            this.materialTextBoxProductName.Location = new System.Drawing.Point(24, 124);
            this.materialTextBoxProductName.MaxLength = 50;
            this.materialTextBoxProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxProductName.Multiline = false;
            this.materialTextBoxProductName.Name = "materialTextBoxProductName";
            this.materialTextBoxProductName.Size = new System.Drawing.Size(400, 50);
            this.materialTextBoxProductName.TabIndex = 28;
            this.materialTextBoxProductName.Text = "";
            this.materialTextBoxProductName.TrailingIcon = null;
            // 
            // materialLabelProductNameError
            // 
            this.materialLabelProductNameError.AutoSize = true;
            this.materialLabelProductNameError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabelProductNameError.ForeColor = System.Drawing.Color.Red;
            this.materialLabelProductNameError.Location = new System.Drawing.Point(24, 177);
            this.materialLabelProductNameError.Name = "materialLabelProductNameError";
            this.materialLabelProductNameError.Size = new System.Drawing.Size(0, 13);
            this.materialLabelProductNameError.TabIndex = 29;
            // 
            // labelProductTypeError
            // 
            this.labelProductTypeError.AutoSize = true;
            this.labelProductTypeError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductTypeError.ForeColor = System.Drawing.Color.Red;
            this.labelProductTypeError.Location = new System.Drawing.Point(24, 264);
            this.labelProductTypeError.Name = "labelProductTypeError";
            this.labelProductTypeError.Size = new System.Drawing.Size(0, 13);
            this.labelProductTypeError.TabIndex = 30;
            // 
            // CreateProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 410);
            this.Controls.Add(this.labelProductTypeError);
            this.Controls.Add(this.materialLabelProductNameError);
            this.Controls.Add(this.materialTextBoxProductName);
            this.Controls.Add(this.materialComboBoxProductType);
            this.Controls.Add(this.materialButtonCreateProduct);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateProductForm";
            this.Padding = new System.Windows.Forms.Padding(4, 64, 4, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButtonCreateProduct;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxProductType;
        public MaterialSkin.Controls.MaterialTextBox materialTextBoxProductName;
        public Label materialLabelProductNameError;
        public Label labelProductTypeError;
    }
}