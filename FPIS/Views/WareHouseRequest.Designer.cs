namespace FPIS.Views
{
    partial class WareHouseRequest
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
            this.WarehouseCountControl = new MaterialSkin.Controls.MaterialTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.ProceedControl.Location = new System.Drawing.Point(182, 212);
            this.ProceedControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProceedControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProceedControl.Name = "ProceedControl";
            this.ProceedControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProceedControl.Size = new System.Drawing.Size(86, 36);
            this.ProceedControl.TabIndex = 1;
            this.ProceedControl.Text = "Proceed";
            this.ProceedControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProceedControl.UseAccentColor = true;
            this.ProceedControl.UseVisualStyleBackColor = true;
            this.ProceedControl.Click += new System.EventHandler(this.ProceedControl_Click);
            // 
            // WarehouseCountControl
            // 
            this.WarehouseCountControl.AnimateReadOnly = false;
            this.WarehouseCountControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehouseCountControl.Depth = 0;
            this.WarehouseCountControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WarehouseCountControl.Hint = "Number of Warehouse(s)";
            this.WarehouseCountControl.LeadingIcon = null;
            this.WarehouseCountControl.Location = new System.Drawing.Point(25, 124);
            this.WarehouseCountControl.MaxLength = 50;
            this.WarehouseCountControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WarehouseCountControl.Multiline = false;
            this.WarehouseCountControl.Name = "WarehouseCountControl";
            this.WarehouseCountControl.Size = new System.Drawing.Size(400, 50);
            this.WarehouseCountControl.TabIndex = 0;
            this.WarehouseCountControl.Text = "";
            this.toolTip1.SetToolTip(this.WarehouseCountControl, "How many warehouses would the materials be stored?");
            this.WarehouseCountControl.TrailingIcon = null;
            this.WarehouseCountControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
            // 
            // WareHouseRequest
            // 
            this.AcceptButton = this.ProceedControl;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.WarehouseCountControl);
            this.Controls.Add(this.ProceedControl);
            this.Name = "WareHouseRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ProceedControl;
        private MaterialSkin.Controls.MaterialTextBox WarehouseCountControl;
        private ToolTip toolTip1;
    }
}