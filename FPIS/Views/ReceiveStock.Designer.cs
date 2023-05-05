namespace FPIS.Views
{
    partial class ReceiveStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiveStock));
            this.materialComboBoxStockItem = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxQuantityReceived = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddReceivedStock = new MaterialSkin.Controls.MaterialButton();
            this.labelStockItemToReceive = new System.Windows.Forms.Label();
            this.labelQuantityReceived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialComboBoxStockItem
            // 
            this.materialComboBoxStockItem.AutoResize = false;
            this.materialComboBoxStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxStockItem.Depth = 0;
            this.materialComboBoxStockItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxStockItem.DropDownHeight = 174;
            this.materialComboBoxStockItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxStockItem.DropDownWidth = 121;
            this.materialComboBoxStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxStockItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxStockItem.FormattingEnabled = true;
            this.materialComboBoxStockItem.Hint = "Select Stock Item to Receive";
            this.materialComboBoxStockItem.IntegralHeight = false;
            this.materialComboBoxStockItem.ItemHeight = 43;
            this.materialComboBoxStockItem.Location = new System.Drawing.Point(25, 124);
            this.materialComboBoxStockItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxStockItem.MaxDropDownItems = 4;
            this.materialComboBoxStockItem.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxStockItem.Name = "materialComboBoxStockItem";
            this.materialComboBoxStockItem.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxStockItem.StartIndex = 0;
            this.materialComboBoxStockItem.TabIndex = 11;
            // 
            // materialTextBoxQuantityReceived
            // 
            this.materialTextBoxQuantityReceived.AnimateReadOnly = false;
            this.materialTextBoxQuantityReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxQuantityReceived.Depth = 0;
            this.materialTextBoxQuantityReceived.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxQuantityReceived.Hint = "Quantity Received";
            this.materialTextBoxQuantityReceived.LeadingIcon = null;
            this.materialTextBoxQuantityReceived.Location = new System.Drawing.Point(25, 210);
            this.materialTextBoxQuantityReceived.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxQuantityReceived.MaxLength = 50;
            this.materialTextBoxQuantityReceived.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxQuantityReceived.Multiline = false;
            this.materialTextBoxQuantityReceived.Name = "materialTextBoxQuantityReceived";
            this.materialTextBoxQuantityReceived.Size = new System.Drawing.Size(400, 50);
            this.materialTextBoxQuantityReceived.TabIndex = 14;
            this.materialTextBoxQuantityReceived.Text = "";
            this.materialTextBoxQuantityReceived.TrailingIcon = null;
            this.materialTextBoxQuantityReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxQuantityReceived_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Expiry Date";
            // 
            // dateTimePickerExpiryDate
            // 
            this.dateTimePickerExpiryDate.Location = new System.Drawing.Point(25, 312);
            this.dateTimePickerExpiryDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            this.dateTimePickerExpiryDate.Size = new System.Drawing.Size(400, 23);
            this.dateTimePickerExpiryDate.TabIndex = 15;
            // 
            // btnAddReceivedStock
            // 
            this.btnAddReceivedStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddReceivedStock.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnAddReceivedStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddReceivedStock.Depth = 0;
            this.btnAddReceivedStock.HighEmphasis = true;
            this.btnAddReceivedStock.Icon = null;
            this.btnAddReceivedStock.Location = new System.Drawing.Point(139, 400);
            this.btnAddReceivedStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReceivedStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddReceivedStock.Name = "btnAddReceivedStock";
            this.btnAddReceivedStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddReceivedStock.Size = new System.Drawing.Size(172, 36);
            this.btnAddReceivedStock.TabIndex = 17;
            this.btnAddReceivedStock.Text = "Add Received Stock";
            this.btnAddReceivedStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddReceivedStock.UseAccentColor = true;
            this.btnAddReceivedStock.UseVisualStyleBackColor = true;
            this.btnAddReceivedStock.Click += new System.EventHandler(this.btnCreateStockItem_Click);
            // 
            // labelStockItemToReceive
            // 
            this.labelStockItemToReceive.AutoSize = true;
            this.labelStockItemToReceive.Location = new System.Drawing.Point(25, 175);
            this.labelStockItemToReceive.Name = "labelStockItemToReceive";
            this.labelStockItemToReceive.Size = new System.Drawing.Size(137, 15);
            this.labelStockItemToReceive.TabIndex = 18;
            this.labelStockItemToReceive.Text = "labelStockItemToReceive";
            // 
            // labelQuantityReceived
            // 
            this.labelQuantityReceived.AutoSize = true;
            this.labelQuantityReceived.Location = new System.Drawing.Point(25, 262);
            this.labelQuantityReceived.Name = "labelQuantityReceived";
            this.labelQuantityReceived.Size = new System.Drawing.Size(125, 15);
            this.labelQuantityReceived.TabIndex = 19;
            this.labelQuantityReceived.Text = "labelQuantityReceived";
            // 
            // ReceiveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.labelQuantityReceived);
            this.Controls.Add(this.labelStockItemToReceive);
            this.Controls.Add(this.btnAddReceivedStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerExpiryDate);
            this.Controls.Add(this.materialTextBoxQuantityReceived);
            this.Controls.Add(this.materialComboBoxStockItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReceiveStock";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive New Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialComboBox materialComboBoxStockItem;
        public MaterialSkin.Controls.MaterialTextBox materialTextBoxQuantityReceived;
        private Label label2;
        private DateTimePicker dateTimePickerExpiryDate;
        private MaterialSkin.Controls.MaterialButton btnAddReceivedStock;
        private Label labelStockItemToReceive;
        private Label labelQuantityReceived;
    }
}