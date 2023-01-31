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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            this.materialComboBoxProducts.IntegralHeight = false;
            this.materialComboBoxProducts.ItemHeight = 43;
            this.materialComboBoxProducts.Location = new System.Drawing.Point(12, 125);
            this.materialComboBoxProducts.MaxDropDownItems = 4;
            this.materialComboBoxProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxProducts.Name = "materialComboBoxProducts";
            this.materialComboBoxProducts.Size = new System.Drawing.Size(416, 49);
            this.materialComboBoxProducts.StartIndex = 0;
            this.materialComboBoxProducts.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Select Product";
            // 
            // materialButtonAddProduct
            // 
            this.materialButtonAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddProduct.Depth = 0;
            this.materialButtonAddProduct.HighEmphasis = true;
            this.materialButtonAddProduct.Icon = null;
            this.materialButtonAddProduct.Location = new System.Drawing.Point(159, 221);
            this.materialButtonAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddProduct.Name = "materialButtonAddProduct";
            this.materialButtonAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddProduct.Size = new System.Drawing.Size(121, 36);
            this.materialButtonAddProduct.TabIndex = 2;
            this.materialButtonAddProduct.Text = "Add Product";
            this.materialButtonAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddProduct.UseAccentColor = false;
            this.materialButtonAddProduct.UseVisualStyleBackColor = true;
            this.materialButtonAddProduct.Click += new System.EventHandler(this.materialButtonAddProduct_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(12, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(208, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Add Product as Analysis Item";
            // 
            // CreateAnalysisProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 319);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButtonAddProduct);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialComboBoxProducts);
            this.Name = "CreateAnalysisProduct";
            this.Text = "Add Analysis Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxProducts;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButtonAddProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}