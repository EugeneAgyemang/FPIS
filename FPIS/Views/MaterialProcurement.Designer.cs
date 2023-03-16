namespace FPIS.Views
{
    partial class MaterialProcurement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SupplierControl = new MaterialSkin.Controls.MaterialTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TruckNumberControl = new MaterialSkin.Controls.MaterialTextBox();
            this.QuantityControl = new MaterialSkin.Controls.MaterialTextBox();
            this.UnitsControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ReceivingSetionControl = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.MaterialProcurementDividerControl = new System.Windows.Forms.Panel();
            this.MaterialProcurementSection = new System.Windows.Forms.Panel();
            this.RemarksCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.RemarksControl = new System.Windows.Forms.TextBox();
            this.SwitchDateCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SaveProcurementRecords = new MaterialSkin.Controls.MaterialButton();
            this.ProductControl = new MaterialSkin.Controls.MaterialComboBox();
            this.PickDateControl = new System.Windows.Forms.DateTimePicker();
            this.SelectedDateControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchDateControl = new MaterialSkin.Controls.MaterialSwitch();
            this.WarehouseControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ReceivingSetionControl.SuspendLayout();
            this.MaterialProcurementSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplierControl
            // 
            this.SupplierControl.AnimateReadOnly = false;
            this.SupplierControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierControl.Depth = 0;
            this.SupplierControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SupplierControl.Hint = "Supplier";
            this.SupplierControl.LeadingIcon = null;
            this.SupplierControl.Location = new System.Drawing.Point(25, 45);
            this.SupplierControl.MaxLength = 50;
            this.SupplierControl.MouseState = MaterialSkin.MouseState.OUT;
            this.SupplierControl.Multiline = false;
            this.SupplierControl.Name = "SupplierControl";
            this.SupplierControl.Size = new System.Drawing.Size(400, 50);
            this.SupplierControl.TabIndex = 0;
            this.SupplierControl.Text = "";
            this.SupplierControl.TrailingIcon = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TruckNumberControl
            // 
            this.TruckNumberControl.AnimateReadOnly = false;
            this.TruckNumberControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TruckNumberControl.Depth = 0;
            this.TruckNumberControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TruckNumberControl.Hint = "Truck Number";
            this.TruckNumberControl.LeadingIcon = null;
            this.TruckNumberControl.Location = new System.Drawing.Point(25, 134);
            this.TruckNumberControl.MaxLength = 50;
            this.TruckNumberControl.MouseState = MaterialSkin.MouseState.OUT;
            this.TruckNumberControl.Multiline = false;
            this.TruckNumberControl.Name = "TruckNumberControl";
            this.TruckNumberControl.Size = new System.Drawing.Size(400, 50);
            this.TruckNumberControl.TabIndex = 5;
            this.TruckNumberControl.Text = "";
            this.TruckNumberControl.TrailingIcon = null;
            // 
            // QuantityControl
            // 
            this.QuantityControl.AnimateReadOnly = false;
            this.QuantityControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityControl.Depth = 0;
            this.QuantityControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityControl.Hint = "Quantity";
            this.QuantityControl.LeadingIcon = null;
            this.QuantityControl.Location = new System.Drawing.Point(25, 223);
            this.QuantityControl.MaxLength = 50;
            this.QuantityControl.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityControl.Multiline = false;
            this.QuantityControl.Name = "QuantityControl";
            this.QuantityControl.Size = new System.Drawing.Size(400, 50);
            this.QuantityControl.TabIndex = 6;
            this.QuantityControl.Text = "";
            this.QuantityControl.TrailingIcon = null;
            this.QuantityControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
            // 
            // UnitsControl
            // 
            this.UnitsControl.AutoResize = false;
            this.UnitsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UnitsControl.Depth = 0;
            this.UnitsControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UnitsControl.DropDownHeight = 174;
            this.UnitsControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsControl.DropDownWidth = 121;
            this.UnitsControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UnitsControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnitsControl.FormattingEnabled = true;
            this.UnitsControl.Hint = "Units";
            this.UnitsControl.IntegralHeight = false;
            this.UnitsControl.ItemHeight = 43;
            this.UnitsControl.Items.AddRange(new object[] {
            "grams",
            "bags",
            "kb"});
            this.UnitsControl.Location = new System.Drawing.Point(25, 312);
            this.UnitsControl.MaxDropDownItems = 4;
            this.UnitsControl.MouseState = MaterialSkin.MouseState.OUT;
            this.UnitsControl.Name = "UnitsControl";
            this.UnitsControl.Size = new System.Drawing.Size(400, 49);
            this.UnitsControl.StartIndex = 0;
            this.UnitsControl.TabIndex = 8;
            // 
            // ReceivingSetionControl
            // 
            this.ReceivingSetionControl.Controls.Add(this.button2);
            this.ReceivingSetionControl.Controls.Add(this.SupplierControl);
            this.ReceivingSetionControl.Controls.Add(this.TruckNumberControl);
            this.ReceivingSetionControl.Controls.Add(this.UnitsControl);
            this.ReceivingSetionControl.Controls.Add(this.QuantityControl);
            this.ReceivingSetionControl.Controls.Add(this.button1);
            this.ReceivingSetionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReceivingSetionControl.Location = new System.Drawing.Point(0, 0);
            this.ReceivingSetionControl.Name = "ReceivingSetionControl";
            this.ReceivingSetionControl.Size = new System.Drawing.Size(500, 600);
            this.ReceivingSetionControl.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MaterialProcurementDividerControl
            // 
            this.MaterialProcurementDividerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaterialProcurementDividerControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaterialProcurementDividerControl.Location = new System.Drawing.Point(500, 0);
            this.MaterialProcurementDividerControl.Name = "MaterialProcurementDividerControl";
            this.MaterialProcurementDividerControl.Size = new System.Drawing.Size(2, 600);
            this.MaterialProcurementDividerControl.TabIndex = 11;
            // 
            // MaterialProcurementSection
            // 
            this.MaterialProcurementSection.Controls.Add(this.RemarksCaptionControl);
            this.MaterialProcurementSection.Controls.Add(this.RemarksControl);
            this.MaterialProcurementSection.Controls.Add(this.SwitchDateCaptionControl);
            this.MaterialProcurementSection.Controls.Add(this.SaveProcurementRecords);
            this.MaterialProcurementSection.Controls.Add(this.ProductControl);
            this.MaterialProcurementSection.Controls.Add(this.PickDateControl);
            this.MaterialProcurementSection.Controls.Add(this.SelectedDateControl);
            this.MaterialProcurementSection.Controls.Add(this.SwitchDateControl);
            this.MaterialProcurementSection.Controls.Add(this.WarehouseControl);
            this.MaterialProcurementSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaterialProcurementSection.Location = new System.Drawing.Point(550, 0);
            this.MaterialProcurementSection.Name = "MaterialProcurementSection";
            this.MaterialProcurementSection.Size = new System.Drawing.Size(450, 600);
            this.MaterialProcurementSection.TabIndex = 12;
            // 
            // RemarksCaptionControl
            // 
            this.RemarksCaptionControl.AutoSize = true;
            this.RemarksCaptionControl.Depth = 0;
            this.RemarksCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RemarksCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.RemarksCaptionControl.Location = new System.Drawing.Point(25, 367);
            this.RemarksCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemarksCaptionControl.Name = "RemarksCaptionControl";
            this.RemarksCaptionControl.Size = new System.Drawing.Size(165, 17);
            this.RemarksCaptionControl.TabIndex = 17;
            this.RemarksCaptionControl.Text = "Remarks (500 characters)";
            // 
            // RemarksControl
            // 
            this.RemarksControl.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemarksControl.Location = new System.Drawing.Point(25, 387);
            this.RemarksControl.Multiline = true;
            this.RemarksControl.Name = "RemarksControl";
            this.RemarksControl.Size = new System.Drawing.Size(400, 113);
            this.RemarksControl.TabIndex = 12;
            this.RemarksControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemarksControl_KeyUp);
            // 
            // SwitchDateCaptionControl
            // 
            this.SwitchDateCaptionControl.AutoSize = true;
            this.SwitchDateCaptionControl.Depth = 0;
            this.SwitchDateCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchDateCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchDateCaptionControl.Location = new System.Drawing.Point(25, 206);
            this.SwitchDateCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchDateCaptionControl.Name = "SwitchDateCaptionControl";
            this.SwitchDateCaptionControl.Size = new System.Drawing.Size(162, 17);
            this.SwitchDateCaptionControl.TabIndex = 16;
            this.SwitchDateCaptionControl.Text = "I\'m using the current date";
            // 
            // SaveProcurementRecords
            // 
            this.SaveProcurementRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveProcurementRecords.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.SaveProcurementRecords.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveProcurementRecords.Depth = 0;
            this.SaveProcurementRecords.HighEmphasis = true;
            this.SaveProcurementRecords.Icon = null;
            this.SaveProcurementRecords.Location = new System.Drawing.Point(361, 539);
            this.SaveProcurementRecords.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveProcurementRecords.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveProcurementRecords.Name = "SaveProcurementRecords";
            this.SaveProcurementRecords.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveProcurementRecords.Size = new System.Drawing.Size(64, 36);
            this.SaveProcurementRecords.TabIndex = 15;
            this.SaveProcurementRecords.Text = "Save";
            this.SaveProcurementRecords.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveProcurementRecords.UseAccentColor = true;
            this.SaveProcurementRecords.UseVisualStyleBackColor = true;
            this.SaveProcurementRecords.Click += new System.EventHandler(this.SaveProcurementRecords_Click);
            // 
            // ProductControl
            // 
            this.ProductControl.AutoResize = false;
            this.ProductControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductControl.Depth = 0;
            this.ProductControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProductControl.DropDownHeight = 174;
            this.ProductControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductControl.DropDownWidth = 121;
            this.ProductControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProductControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductControl.FormattingEnabled = true;
            this.ProductControl.Hint = "Material Procured";
            this.ProductControl.IntegralHeight = false;
            this.ProductControl.ItemHeight = 43;
            this.ProductControl.Location = new System.Drawing.Point(25, 44);
            this.ProductControl.MaxDropDownItems = 4;
            this.ProductControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductControl.Name = "ProductControl";
            this.ProductControl.Size = new System.Drawing.Size(400, 49);
            this.ProductControl.StartIndex = 0;
            this.ProductControl.TabIndex = 13;
            // 
            // PickDateControl
            // 
            this.PickDateControl.Enabled = false;
            this.PickDateControl.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickDateControl.Location = new System.Drawing.Point(25, 296);
            this.PickDateControl.Name = "PickDateControl";
            this.PickDateControl.Size = new System.Drawing.Size(400, 30);
            this.PickDateControl.TabIndex = 12;
            this.PickDateControl.ValueChanged += new System.EventHandler(this.PickDateControl_ValueChanged);
            // 
            // SelectedDateControl
            // 
            this.SelectedDateControl.BackColor = System.Drawing.Color.Red;
            this.SelectedDateControl.Depth = 0;
            this.SelectedDateControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectedDateControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SelectedDateControl.Location = new System.Drawing.Point(212, 229);
            this.SelectedDateControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectedDateControl.Name = "SelectedDateControl";
            this.SelectedDateControl.Size = new System.Drawing.Size(213, 23);
            this.SelectedDateControl.TabIndex = 11;
            this.SelectedDateControl.Text = "materialLabel1";
            this.SelectedDateControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SwitchDateControl
            // 
            this.SwitchDateControl.AutoSize = true;
            this.SwitchDateControl.Checked = true;
            this.SwitchDateControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchDateControl.Depth = 0;
            this.SwitchDateControl.Location = new System.Drawing.Point(25, 223);
            this.SwitchDateControl.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchDateControl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchDateControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchDateControl.Name = "SwitchDateControl";
            this.SwitchDateControl.Ripple = true;
            this.SwitchDateControl.Size = new System.Drawing.Size(165, 37);
            this.SwitchDateControl.TabIndex = 10;
            this.SwitchDateControl.Text = "Use a new date";
            this.SwitchDateControl.UseVisualStyleBackColor = true;
            this.SwitchDateControl.CheckedChanged += new System.EventHandler(this.SwitchDateControl_CheckedChanged);
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
            this.WarehouseControl.Items.AddRange(new object[] {
            "Warehouse A",
            "Warehouse B",
            "Warehouse C"});
            this.WarehouseControl.Location = new System.Drawing.Point(25, 134);
            this.WarehouseControl.MaxDropDownItems = 4;
            this.WarehouseControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WarehouseControl.Name = "WarehouseControl";
            this.WarehouseControl.Size = new System.Drawing.Size(400, 49);
            this.WarehouseControl.StartIndex = 0;
            this.WarehouseControl.TabIndex = 9;
            // 
            // MaterialProcurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaterialProcurementSection);
            this.Controls.Add(this.MaterialProcurementDividerControl);
            this.Controls.Add(this.ReceivingSetionControl);
            this.Name = "MaterialProcurement";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ReceivingSetionControl.ResumeLayout(false);
            this.MaterialProcurementSection.ResumeLayout(false);
            this.MaterialProcurementSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox SuplierControl;
        private Button button1;
        private MaterialSkin.Controls.MaterialTextBox TruckNumberControl;
        private MaterialSkin.Controls.MaterialTextBox QuantityControl;
        private MaterialSkin.Controls.MaterialComboBox UnitsControl;
        private Panel ReceivingSetionControl;
        private Button button2;
        private Panel MaterialProcurementDividerControl;
        private Panel MaterialProcurementSection;
        private MaterialSkin.Controls.MaterialComboBox ProductControl;
        private DateTimePicker PickDateControl;
        private MaterialSkin.Controls.MaterialLabel SelectedDateControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchDateControl;
        private MaterialSkin.Controls.MaterialComboBox WarehouseControl;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton SaveProcurementRecords;
        private MaterialSkin.Controls.MaterialTextBox SupplierControl;
        private MaterialSkin.Controls.MaterialLabel SwitchDateCaptionControl;
        private MaterialSkin.Controls.MaterialLabel RemarksCaptionControl;
        private TextBox RemarksControl;
    }
}
