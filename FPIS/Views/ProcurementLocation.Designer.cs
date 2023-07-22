namespace FPIS.Views
{
    partial class ProcurementLocation
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
            this.helper = new System.Windows.Forms.ToolTip(this.components);
            this.AddLocationDetailsControl = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.KeepWarehouseOneControl = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProceedControl = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LocationOneControl = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NewLocationsSection = new System.Windows.Forms.Panel();
            this.QuantityOneControl = new MaterialSkin.Controls.MaterialTextBox();
            this.LotOneControl = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NewLocationsSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddLocationDetailsControl
            // 
            this.AddLocationDetailsControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddLocationDetailsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddLocationDetailsControl.Depth = 0;
            this.AddLocationDetailsControl.Icon = global::FPIS.Properties.Resources.add_white;
            this.AddLocationDetailsControl.Location = new System.Drawing.Point(407, 57);
            this.AddLocationDetailsControl.Mini = true;
            this.AddLocationDetailsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddLocationDetailsControl.Name = "AddLocationDetailsControl";
            this.AddLocationDetailsControl.Size = new System.Drawing.Size(40, 40);
            this.AddLocationDetailsControl.TabIndex = 37;
            this.AddLocationDetailsControl.Text = "materialFloatingActionButton1";
            this.helper.SetToolTip(this.AddLocationDetailsControl, "Add new location details");
            this.AddLocationDetailsControl.UseVisualStyleBackColor = true;
            this.AddLocationDetailsControl.Click += new System.EventHandler(this.AddLocationDetailsControl_Click);
            // 
            // KeepWarehouseOneControl
            // 
            this.KeepWarehouseOneControl.AutoSize = true;
            this.KeepWarehouseOneControl.Checked = true;
            this.KeepWarehouseOneControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeepWarehouseOneControl.Depth = 0;
            this.KeepWarehouseOneControl.Location = new System.Drawing.Point(47, 156);
            this.KeepWarehouseOneControl.Margin = new System.Windows.Forms.Padding(0);
            this.KeepWarehouseOneControl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.KeepWarehouseOneControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.KeepWarehouseOneControl.Name = "KeepWarehouseOneControl";
            this.KeepWarehouseOneControl.ReadOnly = false;
            this.KeepWarehouseOneControl.Ripple = true;
            this.KeepWarehouseOneControl.Size = new System.Drawing.Size(157, 37);
            this.KeepWarehouseOneControl.TabIndex = 40;
            this.KeepWarehouseOneControl.Text = "Same warehouse";
            this.helper.SetToolTip(this.KeepWarehouseOneControl, "I\'ll be storing this material in the exactly one warehouse");
            this.KeepWarehouseOneControl.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProceedControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 48);
            this.panel1.TabIndex = 36;
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
            this.ProceedControl.Location = new System.Drawing.Point(204, 6);
            this.ProceedControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProceedControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProceedControl.Name = "ProceedControl";
            this.ProceedControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProceedControl.Size = new System.Drawing.Size(86, 36);
            this.ProceedControl.TabIndex = 7;
            this.ProceedControl.Text = "Proceed";
            this.ProceedControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProceedControl.UseAccentColor = true;
            this.ProceedControl.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KeepWarehouseOneControl);
            this.panel2.Controls.Add(this.LocationOneControl);
            this.panel2.Controls.Add(this.AddLocationDetailsControl);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 194);
            this.panel2.TabIndex = 37;
            // 
            // LocationOneControl
            // 
            this.LocationOneControl.AnimateReadOnly = false;
            this.LocationOneControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationOneControl.Depth = 0;
            this.LocationOneControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LocationOneControl.Hint = "Warehouse";
            this.LocationOneControl.LeadingIcon = null;
            this.LocationOneControl.Location = new System.Drawing.Point(47, 103);
            this.LocationOneControl.MaxLength = 50;
            this.LocationOneControl.MouseState = MaterialSkin.MouseState.OUT;
            this.LocationOneControl.Multiline = false;
            this.LocationOneControl.Name = "LocationOneControl";
            this.LocationOneControl.Size = new System.Drawing.Size(400, 50);
            this.LocationOneControl.TabIndex = 39;
            this.LocationOneControl.Text = "";
            this.LocationOneControl.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(47, 57);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(354, 46);
            this.materialLabel1.TabIndex = 36;
            this.materialLabel1.Text = "Kindly provide warehouse and lot details you\'ll be keeping the raw materials rece" +
    "ived";
            // 
            // NewLocationsSection
            // 
            this.NewLocationsSection.AutoScroll = true;
            this.NewLocationsSection.Controls.Add(this.QuantityOneControl);
            this.NewLocationsSection.Controls.Add(this.LotOneControl);
            this.NewLocationsSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewLocationsSection.Location = new System.Drawing.Point(3, 258);
            this.NewLocationsSection.Name = "NewLocationsSection";
            this.NewLocationsSection.Size = new System.Drawing.Size(494, 91);
            this.NewLocationsSection.TabIndex = 39;
            // 
            // QuantityOneControl
            // 
            this.QuantityOneControl.AnimateReadOnly = false;
            this.QuantityOneControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityOneControl.Depth = 0;
            this.QuantityOneControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityOneControl.Hint = "Quantity to store";
            this.QuantityOneControl.LeadingIcon = null;
            this.QuantityOneControl.Location = new System.Drawing.Point(257, 6);
            this.QuantityOneControl.MaxLength = 50;
            this.QuantityOneControl.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityOneControl.Multiline = false;
            this.QuantityOneControl.Name = "QuantityOneControl";
            this.QuantityOneControl.Size = new System.Drawing.Size(190, 50);
            this.QuantityOneControl.TabIndex = 44;
            this.QuantityOneControl.Text = "";
            this.QuantityOneControl.TrailingIcon = null;
            // 
            // LotOneControl
            // 
            this.LotOneControl.AnimateReadOnly = false;
            this.LotOneControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LotOneControl.Depth = 0;
            this.LotOneControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LotOneControl.Hint = "Lot for warehouse";
            this.LotOneControl.LeadingIcon = null;
            this.LotOneControl.Location = new System.Drawing.Point(47, 6);
            this.LotOneControl.MaxLength = 50;
            this.LotOneControl.MouseState = MaterialSkin.MouseState.OUT;
            this.LotOneControl.Multiline = false;
            this.LotOneControl.Name = "LotOneControl";
            this.LotOneControl.Size = new System.Drawing.Size(190, 50);
            this.LotOneControl.TabIndex = 43;
            this.LotOneControl.Text = "";
            this.LotOneControl.TrailingIcon = null;
            // 
            // ProcurementLocation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.NewLocationsSection);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProcurementLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurement Location";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.NewLocationsSection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ToolTip helper;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton ProceedControl;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialFloatingActionButton AddLocationDetailsControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private Panel NewLocationsSection;
        private MaterialSkin.Controls.MaterialCheckbox KeepWarehouseOneControl;
        private MaterialSkin.Controls.MaterialTextBox LocationOneControl;
        private MaterialSkin.Controls.MaterialTextBox QuantityOneControl;
        private MaterialSkin.Controls.MaterialTextBox LotOneControl;
    }
}