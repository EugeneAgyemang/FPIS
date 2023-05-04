namespace FPIS.Views
{
    partial class CreateAnalysisProduct
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
            this.materialComboBoxProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialComboBoxProducts
            // 
            this.materialComboBoxProducts.AutoResize = false;
            this.materialComboBoxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxProducts.Depth = 0;
            this.materialComboBoxProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxProducts.DropDownHeight = 174;
            this.materialComboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxProducts.DropDownWidth = 121;
            this.materialComboBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxProducts.FormattingEnabled = true;
            this.materialComboBoxProducts.Hint = "Choose a product";
            this.materialComboBoxProducts.IntegralHeight = false;
            this.materialComboBoxProducts.ItemHeight = 43;
            this.materialComboBoxProducts.Location = new System.Drawing.Point(25, 124);
            this.materialComboBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBoxProducts.MaxDropDownItems = 4;
            this.materialComboBoxProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxProducts.Name = "materialComboBoxProducts";
            this.materialComboBoxProducts.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxProducts.StartIndex = -1;
            this.materialComboBoxProducts.TabIndex = 0;
            // 
            // materialButtonAddProduct
            // 
            this.materialButtonAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddProduct.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddProduct.Depth = 0;
            this.materialButtonAddProduct.HighEmphasis = true;
            this.materialButtonAddProduct.Icon = null;
            this.materialButtonAddProduct.Location = new System.Drawing.Point(129, 238);
            this.materialButtonAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButtonAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddProduct.Name = "materialButtonAddProduct";
            this.materialButtonAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddProduct.Size = new System.Drawing.Size(193, 36);
            this.materialButtonAddProduct.TabIndex = 1;
            this.materialButtonAddProduct.Text = "Add Analysis Product";
            this.materialButtonAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddProduct.UseAccentColor = true;
            this.materialButtonAddProduct.UseVisualStyleBackColor = true;
            this.materialButtonAddProduct.Click += new System.EventHandler(this.materialButtonAddProduct_Click);
            // 
            // CreateAnalysisProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.materialButtonAddProduct);
            this.Controls.Add(this.materialComboBoxProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateAnalysisProduct";
            this.Padding = new System.Windows.Forms.Padding(2, 38, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Analysis Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxProducts;
        private MaterialSkin.Controls.MaterialButton materialButtonAddProduct;
    }
}