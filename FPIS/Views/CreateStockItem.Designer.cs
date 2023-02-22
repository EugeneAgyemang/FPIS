namespace FPIS.Views
{
    partial class CreateStockItem
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
            this.materialTextBoxStockItemName = new MaterialSkin.Controls.MaterialTextBox();
            this.labelStockItemName = new System.Windows.Forms.Label();
            this.materialComboBoxStockItemType = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCreateStockItem = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxUnitOfMeasurement = new MaterialSkin.Controls.MaterialComboBox();
            this.labelStockItemType = new System.Windows.Forms.Label();
            this.labelUnitOfMeasurement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialTextBoxStockItemName
            // 
            this.materialTextBoxStockItemName.AnimateReadOnly = false;
            this.materialTextBoxStockItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxStockItemName.Depth = 0;
            this.materialTextBoxStockItemName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxStockItemName.Hint = "Item Name";
            this.materialTextBoxStockItemName.LeadingIcon = null;
            this.materialTextBoxStockItemName.Location = new System.Drawing.Point(25, 124);
            this.materialTextBoxStockItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxStockItemName.MaxLength = 50;
            this.materialTextBoxStockItemName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxStockItemName.Multiline = false;
            this.materialTextBoxStockItemName.Name = "materialTextBoxStockItemName";
            this.materialTextBoxStockItemName.Size = new System.Drawing.Size(400, 50);
            this.materialTextBoxStockItemName.TabIndex = 0;
            this.materialTextBoxStockItemName.Text = "";
            this.materialTextBoxStockItemName.TrailingIcon = null;
            // 
            // labelStockItemName
            // 
            this.labelStockItemName.AutoSize = true;
            this.labelStockItemName.Location = new System.Drawing.Point(25, 176);
            this.labelStockItemName.Name = "labelStockItemName";
            this.labelStockItemName.Size = new System.Drawing.Size(117, 15);
            this.labelStockItemName.TabIndex = 4;
            this.labelStockItemName.Text = "labelStockItemName";
            // 
            // materialComboBoxStockItemType
            // 
            this.materialComboBoxStockItemType.AutoResize = false;
            this.materialComboBoxStockItemType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxStockItemType.Depth = 0;
            this.materialComboBoxStockItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxStockItemType.DropDownHeight = 174;
            this.materialComboBoxStockItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxStockItemType.DropDownWidth = 121;
            this.materialComboBoxStockItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxStockItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxStockItemType.FormattingEnabled = true;
            this.materialComboBoxStockItemType.Hint = "Select Item Type";
            this.materialComboBoxStockItemType.IntegralHeight = false;
            this.materialComboBoxStockItemType.ItemHeight = 43;
            this.materialComboBoxStockItemType.Items.AddRange(new object[] {
            "Consumable",
            "Finished Product"});
            this.materialComboBoxStockItemType.Location = new System.Drawing.Point(25, 297);
            this.materialComboBoxStockItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxStockItemType.MaxDropDownItems = 4;
            this.materialComboBoxStockItemType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxStockItemType.Name = "materialComboBoxStockItemType";
            this.materialComboBoxStockItemType.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxStockItemType.StartIndex = 0;
            this.materialComboBoxStockItemType.TabIndex = 2;
            // 
            // btnCreateStockItem
            // 
            this.btnCreateStockItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateStockItem.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnCreateStockItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateStockItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateStockItem.Depth = 0;
            this.btnCreateStockItem.HighEmphasis = true;
            this.btnCreateStockItem.Icon = null;
            this.btnCreateStockItem.Location = new System.Drawing.Point(143, 411);
            this.btnCreateStockItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateStockItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateStockItem.Name = "btnCreateStockItem";
            this.btnCreateStockItem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateStockItem.Size = new System.Drawing.Size(164, 36);
            this.btnCreateStockItem.TabIndex = 3;
            this.btnCreateStockItem.Text = "Create Stock Item";
            this.btnCreateStockItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateStockItem.UseAccentColor = true;
            this.btnCreateStockItem.UseVisualStyleBackColor = true;
            this.btnCreateStockItem.Click += new System.EventHandler(this.btnCreateStockItem_Click);
            // 
            // materialComboBoxUnitOfMeasurement
            // 
            this.materialComboBoxUnitOfMeasurement.AutoResize = false;
            this.materialComboBoxUnitOfMeasurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxUnitOfMeasurement.Depth = 0;
            this.materialComboBoxUnitOfMeasurement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxUnitOfMeasurement.DropDownHeight = 174;
            this.materialComboBoxUnitOfMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxUnitOfMeasurement.DropDownWidth = 121;
            this.materialComboBoxUnitOfMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxUnitOfMeasurement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxUnitOfMeasurement.FormattingEnabled = true;
            this.materialComboBoxUnitOfMeasurement.Hint = "Select Unit Of Measurement";
            this.materialComboBoxUnitOfMeasurement.IntegralHeight = false;
            this.materialComboBoxUnitOfMeasurement.ItemHeight = 43;
            this.materialComboBoxUnitOfMeasurement.Items.AddRange(new object[] {
            "ltrs",
            "g",
            "kg",
            "gals",
            "ml",
            "pcs",
            "packs",
            "box",
            "bag",
            "roll",
            "mm"});
            this.materialComboBoxUnitOfMeasurement.Location = new System.Drawing.Point(25, 211);
            this.materialComboBoxUnitOfMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxUnitOfMeasurement.MaxDropDownItems = 4;
            this.materialComboBoxUnitOfMeasurement.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxUnitOfMeasurement.Name = "materialComboBoxUnitOfMeasurement";
            this.materialComboBoxUnitOfMeasurement.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxUnitOfMeasurement.StartIndex = 0;
            this.materialComboBoxUnitOfMeasurement.TabIndex = 1;
            // 
            // labelStockItemType
            // 
            this.labelStockItemType.AutoSize = true;
            this.labelStockItemType.Location = new System.Drawing.Point(25, 348);
            this.labelStockItemType.Name = "labelStockItemType";
            this.labelStockItemType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStockItemType.Size = new System.Drawing.Size(109, 15);
            this.labelStockItemType.TabIndex = 8;
            this.labelStockItemType.Text = "labelStockItemType";
            // 
            // labelUnitOfMeasurement
            // 
            this.labelUnitOfMeasurement.AutoSize = true;
            this.labelUnitOfMeasurement.Location = new System.Drawing.Point(25, 262);
            this.labelUnitOfMeasurement.Name = "labelUnitOfMeasurement";
            this.labelUnitOfMeasurement.Size = new System.Drawing.Size(140, 15);
            this.labelUnitOfMeasurement.TabIndex = 6;
            this.labelUnitOfMeasurement.Text = "labelUnitOfMeasurement";
            // 
            // CreateStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 490);
            this.Controls.Add(this.materialComboBoxUnitOfMeasurement);
            this.Controls.Add(this.btnCreateStockItem);
            this.Controls.Add(this.labelStockItemType);
            this.Controls.Add(this.materialComboBoxStockItemType);
            this.Controls.Add(this.labelUnitOfMeasurement);
            this.Controls.Add(this.labelStockItemName);
            this.Controls.Add(this.materialTextBoxStockItemName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateStockItem";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Stock Item";
            this.Load += new System.EventHandler(this.CreateStockItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialTextBox materialTextBoxStockItemName;
        public Label labelStockItemName;
        public MaterialSkin.Controls.MaterialComboBox materialComboBoxStockItemType;
        private MaterialSkin.Controls.MaterialButton btnCreateStockItem;
        public MaterialSkin.Controls.MaterialComboBox materialComboBoxUnitOfMeasurement;
        public Label labelStockItemType;
        public Label labelUnitOfMeasurement;
    }
}