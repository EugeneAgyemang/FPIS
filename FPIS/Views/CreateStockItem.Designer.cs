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
            this.labelUnitOfMeasurement = new System.Windows.Forms.Label();
            this.materialTextBoxUnitOfMeasurement = new MaterialSkin.Controls.MaterialTextBox();
            this.labelStockItemType = new System.Windows.Forms.Label();
            this.materialComboBoxStockItemType = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCreateStockItem = new MaterialSkin.Controls.MaterialButton();
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
            this.materialTextBoxStockItemName.Location = new System.Drawing.Point(18, 98);
            this.materialTextBoxStockItemName.MaxLength = 50;
            this.materialTextBoxStockItemName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxStockItemName.Multiline = false;
            this.materialTextBoxStockItemName.Name = "materialTextBoxStockItemName";
            this.materialTextBoxStockItemName.Size = new System.Drawing.Size(397, 50);
            this.materialTextBoxStockItemName.TabIndex = 2;
            this.materialTextBoxStockItemName.Text = "";
            this.materialTextBoxStockItemName.TrailingIcon = null;
            // 
            // labelStockItemName
            // 
            this.labelStockItemName.AutoSize = true;
            this.labelStockItemName.Location = new System.Drawing.Point(21, 159);
            this.labelStockItemName.Name = "labelStockItemName";
            this.labelStockItemName.Size = new System.Drawing.Size(148, 20);
            this.labelStockItemName.TabIndex = 4;
            this.labelStockItemName.Text = "labelStockItemName";
            // 
            // labelUnitOfMeasurement
            // 
            this.labelUnitOfMeasurement.AutoSize = true;
            this.labelUnitOfMeasurement.Location = new System.Drawing.Point(21, 270);
            this.labelUnitOfMeasurement.Name = "labelUnitOfMeasurement";
            this.labelUnitOfMeasurement.Size = new System.Drawing.Size(175, 20);
            this.labelUnitOfMeasurement.TabIndex = 6;
            this.labelUnitOfMeasurement.Text = "labelUnitOfMeasurement";
            // 
            // materialTextBoxUnitOfMeasurement
            // 
            this.materialTextBoxUnitOfMeasurement.AnimateReadOnly = false;
            this.materialTextBoxUnitOfMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxUnitOfMeasurement.Depth = 0;
            this.materialTextBoxUnitOfMeasurement.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxUnitOfMeasurement.Hint = "Unit of Measurement";
            this.materialTextBoxUnitOfMeasurement.LeadingIcon = null;
            this.materialTextBoxUnitOfMeasurement.Location = new System.Drawing.Point(18, 209);
            this.materialTextBoxUnitOfMeasurement.MaxLength = 50;
            this.materialTextBoxUnitOfMeasurement.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxUnitOfMeasurement.Multiline = false;
            this.materialTextBoxUnitOfMeasurement.Name = "materialTextBoxUnitOfMeasurement";
            this.materialTextBoxUnitOfMeasurement.Size = new System.Drawing.Size(397, 50);
            this.materialTextBoxUnitOfMeasurement.TabIndex = 5;
            this.materialTextBoxUnitOfMeasurement.Text = "";
            this.materialTextBoxUnitOfMeasurement.TrailingIcon = null;
            // 
            // labelStockItemType
            // 
            this.labelStockItemType.AutoSize = true;
            this.labelStockItemType.Location = new System.Drawing.Point(20, 382);
            this.labelStockItemType.Name = "labelStockItemType";
            this.labelStockItemType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStockItemType.Size = new System.Drawing.Size(139, 20);
            this.labelStockItemType.TabIndex = 8;
            this.labelStockItemType.Text = "labelStockItemType";
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
            this.materialComboBoxStockItemType.Location = new System.Drawing.Point(18, 325);
            this.materialComboBoxStockItemType.MaxDropDownItems = 4;
            this.materialComboBoxStockItemType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxStockItemType.Name = "materialComboBoxStockItemType";
            this.materialComboBoxStockItemType.Size = new System.Drawing.Size(397, 49);
            this.materialComboBoxStockItemType.StartIndex = 0;
            this.materialComboBoxStockItemType.TabIndex = 7;
            // 
            // btnCreateStockItem
            // 
            this.btnCreateStockItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateStockItem.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnCreateStockItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateStockItem.Depth = 0;
            this.btnCreateStockItem.HighEmphasis = true;
            this.btnCreateStockItem.Icon = null;
            this.btnCreateStockItem.Location = new System.Drawing.Point(142, 448);
            this.btnCreateStockItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateStockItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateStockItem.Name = "btnCreateStockItem";
            this.btnCreateStockItem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateStockItem.Size = new System.Drawing.Size(164, 36);
            this.btnCreateStockItem.TabIndex = 9;
            this.btnCreateStockItem.Text = "Create Stock Item";
            this.btnCreateStockItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateStockItem.UseAccentColor = false;
            this.btnCreateStockItem.UseVisualStyleBackColor = true;
            this.btnCreateStockItem.Click += new System.EventHandler(this.btnCreateStockItem_Click);
            // 
            // CreateStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 513);
            this.Controls.Add(this.btnCreateStockItem);
            this.Controls.Add(this.labelStockItemType);
            this.Controls.Add(this.materialComboBoxStockItemType);
            this.Controls.Add(this.labelUnitOfMeasurement);
            this.Controls.Add(this.materialTextBoxUnitOfMeasurement);
            this.Controls.Add(this.labelStockItemName);
            this.Controls.Add(this.materialTextBoxStockItemName);
            this.Name = "CreateStockItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Stock Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialTextBox materialTextBoxStockItemName;
        public Label labelStockItemName;
        public Label labelUnitOfMeasurement;
        public MaterialSkin.Controls.MaterialTextBox materialTextBoxUnitOfMeasurement;
        public Label labelStockItemType;
        public MaterialSkin.Controls.MaterialComboBox materialComboBoxStockItemType;
        private MaterialSkin.Controls.MaterialButton btnCreateStockItem;
    }
}