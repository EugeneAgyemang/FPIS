namespace FPIS.Views
{
    partial class LotRequest
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
            this.ProceedControl = new MaterialSkin.Controls.MaterialButton();
            this.LotsCountControl = new MaterialSkin.Controls.MaterialTextBox();
            this.WarehouseControl = new MaterialSkin.Controls.MaterialComboBox();
            this.WarehouseErrorControl = new System.Windows.Forms.Label();
            this.LotsCountErrorControl = new System.Windows.Forms.Label();
            this.helper = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
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
            this.ProceedControl.Location = new System.Drawing.Point(182, 299);
            this.ProceedControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProceedControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProceedControl.Name = "ProceedControl";
            this.ProceedControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProceedControl.Size = new System.Drawing.Size(86, 36);
            this.ProceedControl.TabIndex = 2;
            this.ProceedControl.Text = "Proceed";
            this.ProceedControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProceedControl.UseAccentColor = true;
            this.ProceedControl.UseVisualStyleBackColor = true;
            this.ProceedControl.Click += new System.EventHandler(this.ProceedControl_Click);
            // 
            // LotsCountControl
            // 
            this.LotsCountControl.AnimateReadOnly = false;
            this.LotsCountControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LotsCountControl.Depth = 0;
            this.LotsCountControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LotsCountControl.Hint = "Number of Lot(s)";
            this.LotsCountControl.LeadingIcon = null;
            this.LotsCountControl.Location = new System.Drawing.Point(25, 211);
            this.LotsCountControl.MaxLength = 50;
            this.LotsCountControl.MouseState = MaterialSkin.MouseState.OUT;
            this.LotsCountControl.Multiline = false;
            this.LotsCountControl.Name = "LotsCountControl";
            this.LotsCountControl.Size = new System.Drawing.Size(400, 50);
            this.LotsCountControl.TabIndex = 1;
            this.LotsCountControl.Text = "";
            this.helper.SetToolTip(this.LotsCountControl, "I need the number of lots you wish to keep the received materials in the warehous" +
        "e");
            this.LotsCountControl.TrailingIcon = null;
            this.LotsCountControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
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
            this.helper.SetToolTip(this.WarehouseControl, "I need the warehouse so I can easily link up the lots");
            // 
            // WarehouseErrorControl
            // 
            this.WarehouseErrorControl.AutoSize = true;
            this.WarehouseErrorControl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarehouseErrorControl.ForeColor = System.Drawing.Color.Red;
            this.WarehouseErrorControl.Location = new System.Drawing.Point(25, 176);
            this.WarehouseErrorControl.Name = "WarehouseErrorControl";
            this.WarehouseErrorControl.Size = new System.Drawing.Size(0, 13);
            this.WarehouseErrorControl.TabIndex = 16;
            // 
            // LotsCountErrorControl
            // 
            this.LotsCountErrorControl.AutoSize = true;
            this.LotsCountErrorControl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LotsCountErrorControl.ForeColor = System.Drawing.Color.Red;
            this.LotsCountErrorControl.Location = new System.Drawing.Point(25, 264);
            this.LotsCountErrorControl.Name = "LotsCountErrorControl";
            this.LotsCountErrorControl.Size = new System.Drawing.Size(0, 13);
            this.LotsCountErrorControl.TabIndex = 17;
            // 
            // LotRequest
            // 
            this.AcceptButton = this.ProceedControl;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.LotsCountErrorControl);
            this.Controls.Add(this.WarehouseErrorControl);
            this.Controls.Add(this.WarehouseControl);
            this.Controls.Add(this.LotsCountControl);
            this.Controls.Add(this.ProceedControl);
            this.Name = "LotRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lot Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ProceedControl;
        private MaterialSkin.Controls.MaterialTextBox LotsCountControl;
        private MaterialSkin.Controls.MaterialComboBox WarehouseControl;
        private Label WarehouseErrorControl;
        private Label LotsCountErrorControl;
        private ToolTip helper;
    }
}