namespace FPIS.Views
{
    partial class AcceptLot
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
            this.components = new System.ComponentModel.Container();
            this.LotControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ProceedControl = new MaterialSkin.Controls.MaterialButton();
            this.WarehouseControl = new MaterialSkin.Controls.MaterialComboBox();
            this.helper = new System.Windows.Forms.ToolTip(this.components);
            this.QuantityControl = new MaterialSkin.Controls.MaterialTextBox();
            this.LotsErrorControl = new System.Windows.Forms.Label();
            this.WarehouseErrorControl = new System.Windows.Forms.Label();
            this.QuantityErrorControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LotControl
            // 
            this.LotControl.AnimateReadOnly = false;
            this.LotControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LotControl.Depth = 0;
            this.LotControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LotControl.Hint = "Lot";
            this.LotControl.LeadingIcon = null;
            this.LotControl.Location = new System.Drawing.Point(25, 211);
            this.LotControl.MaxLength = 50;
            this.LotControl.MouseState = MaterialSkin.MouseState.OUT;
            this.LotControl.Multiline = false;
            this.LotControl.Name = "LotControl";
            this.LotControl.Size = new System.Drawing.Size(400, 50);
            this.LotControl.TabIndex = 1;
            this.LotControl.Text = "";
            this.helper.SetToolTip(this.LotControl, "The lot where the raw maaterial would be stored in a particular warehouse");
            this.LotControl.TrailingIcon = null;
            // 
            // ProceedControl
            // 
            this.ProceedControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProceedControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.ProceedControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProceedControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ProceedControl.Depth = 0;
            this.ProceedControl.HighEmphasis = true;
            this.ProceedControl.Icon = null;
            this.ProceedControl.Location = new System.Drawing.Point(182, 387);
            this.ProceedControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProceedControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProceedControl.Name = "ProceedControl";
            this.ProceedControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProceedControl.Size = new System.Drawing.Size(86, 36);
            this.ProceedControl.TabIndex = 3;
            this.ProceedControl.Text = "Proceed";
            this.ProceedControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProceedControl.UseAccentColor = true;
            this.ProceedControl.UseVisualStyleBackColor = true;
            this.ProceedControl.Click += new System.EventHandler(this.ProceedControl_Click);
            // 
            // WarehouseControl
            // 
            this.WarehouseControl.AutoResize = false;
            this.WarehouseControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WarehouseControl.Depth = 0;
            this.WarehouseControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WarehouseControl.DropDownHeight = 174;
            this.WarehouseControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WarehouseControl.DropDownWidth = 121;
            this.WarehouseControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WarehouseControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WarehouseControl.FormattingEnabled = true;
            this.WarehouseControl.Hint = "Warehouse";
            this.WarehouseControl.IntegralHeight = false;
            this.WarehouseControl.ItemHeight = 43;
            this.WarehouseControl.Location = new System.Drawing.Point(25, 124);
            this.WarehouseControl.MaxDropDownItems = 4;
            this.WarehouseControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WarehouseControl.Name = "WarehouseControl";
            this.WarehouseControl.Size = new System.Drawing.Size(400, 49);
            this.WarehouseControl.StartIndex = 0;
            this.WarehouseControl.TabIndex = 0;
            this.helper.SetToolTip(this.WarehouseControl, "The warehouse where the raw material would be stored");
            this.WarehouseControl.SelectedIndexChanged += new System.EventHandler(this.WarehouseControl_SelectedIndexChanged);
            // 
            // QuantityControl
            // 
            this.QuantityControl.AnimateReadOnly = false;
            this.QuantityControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityControl.Depth = 0;
            this.QuantityControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityControl.Hint = "Quantity";
            this.QuantityControl.LeadingIcon = null;
            this.QuantityControl.Location = new System.Drawing.Point(25, 299);
            this.QuantityControl.MaxLength = 50;
            this.QuantityControl.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityControl.Multiline = false;
            this.QuantityControl.Name = "QuantityControl";
            this.QuantityControl.Size = new System.Drawing.Size(400, 50);
            this.QuantityControl.TabIndex = 2;
            this.QuantityControl.Text = "";
            this.helper.SetToolTip(this.QuantityControl, "The quantity to be stored in each lot for a particular warehouse");
            this.QuantityControl.TrailingIcon = null;
            this.QuantityControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
            // 
            // LotsErrorControl
            // 
            this.LotsErrorControl.AutoSize = true;
            this.LotsErrorControl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LotsErrorControl.ForeColor = System.Drawing.Color.Red;
            this.LotsErrorControl.Location = new System.Drawing.Point(25, 264);
            this.LotsErrorControl.Name = "LotsErrorControl";
            this.LotsErrorControl.Size = new System.Drawing.Size(0, 13);
            this.LotsErrorControl.TabIndex = 18;
            // 
            // WarehouseErrorControl
            // 
            this.WarehouseErrorControl.AutoSize = true;
            this.WarehouseErrorControl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarehouseErrorControl.ForeColor = System.Drawing.Color.Red;
            this.WarehouseErrorControl.Location = new System.Drawing.Point(25, 176);
            this.WarehouseErrorControl.Name = "WarehouseErrorControl";
            this.WarehouseErrorControl.Size = new System.Drawing.Size(0, 13);
            this.WarehouseErrorControl.TabIndex = 19;
            // 
            // QuantityErrorControl
            // 
            this.QuantityErrorControl.AutoSize = true;
            this.QuantityErrorControl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantityErrorControl.ForeColor = System.Drawing.Color.Red;
            this.QuantityErrorControl.Location = new System.Drawing.Point(25, 352);
            this.QuantityErrorControl.Name = "QuantityErrorControl";
            this.QuantityErrorControl.Size = new System.Drawing.Size(0, 13);
            this.QuantityErrorControl.TabIndex = 23;
            // 
            // AcceptLot
            // 
            this.AcceptButton = this.ProceedControl;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 440);
            this.Controls.Add(this.QuantityErrorControl);
            this.Controls.Add(this.QuantityControl);
            this.Controls.Add(this.WarehouseErrorControl);
            this.Controls.Add(this.LotsErrorControl);
            this.Controls.Add(this.WarehouseControl);
            this.Controls.Add(this.LotControl);
            this.Controls.Add(this.ProceedControl);
            this.Name = "AcceptLot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accept Lot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox LotControl;
        private MaterialSkin.Controls.MaterialButton ProceedControl;
        private MaterialSkin.Controls.MaterialComboBox WarehouseControl;
        private ToolTip helper;
        private Label LotsErrorControl;
        private Label WarehouseErrorControl;
        private MaterialSkin.Controls.MaterialTextBox QuantityControl;
        private Label QuantityErrorControl;
    }
}