namespace FPIS.Views
{
    partial class ProcurementReceiveMaterialsUserControl
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
            this.TruckNumberControl = new MaterialSkin.Controls.MaterialTextBox();
            this.QuantityControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ReceivingSetionControl = new System.Windows.Forms.Panel();
            this.LotErrorCaption = new System.Windows.Forms.Label();
            this.WarehouseControl = new MaterialSkin.Controls.MaterialTextBox();
            this.DateProcuredSection = new System.Windows.Forms.Panel();
            this.SwitchDateCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SelectedDateControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchDateControl = new MaterialSkin.Controls.MaterialSwitch();
            this.LotControl = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.WarehouseErrorCaption = new System.Windows.Forms.Label();
            this.ProductErrorCaption = new System.Windows.Forms.Label();
            this.ProductControl = new MaterialSkin.Controls.MaterialComboBox();
            this.PickDateControl = new System.Windows.Forms.DateTimePicker();
            this.QuantityErrorCaption = new System.Windows.Forms.Label();
            this.UnitsErrorCaption = new System.Windows.Forms.Label();
            this.MaterialProcurementDividerControl = new System.Windows.Forms.Panel();
            this.MaterialProcurementSection = new System.Windows.Forms.Panel();
            this.UnitsControl = new MaterialSkin.Controls.MaterialTextBox();
            this.TruckNumberErrorCaption = new System.Windows.Forms.Label();
            this.SupplierErrorCaption = new System.Windows.Forms.Label();
            this.RemarksCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.RemarksControl = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.SaveProcurementRecords = new MaterialSkin.Controls.MaterialButton();
            this.ReceivingSetionControl.SuspendLayout();
            this.DateProcuredSection.SuspendLayout();
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
            this.SupplierControl.Location = new System.Drawing.Point(25, 44);
            this.SupplierControl.MaxLength = 50;
            this.SupplierControl.MouseState = MaterialSkin.MouseState.OUT;
            this.SupplierControl.Multiline = false;
            this.SupplierControl.Name = "SupplierControl";
            this.SupplierControl.Size = new System.Drawing.Size(400, 50);
            this.SupplierControl.TabIndex = 0;
            this.SupplierControl.Text = "";
            this.SupplierControl.TrailingIcon = null;
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
            this.TruckNumberControl.TabIndex = 2;
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
            this.QuantityControl.Location = new System.Drawing.Point(25, 224);
            this.QuantityControl.MaxLength = 50;
            this.QuantityControl.MouseState = MaterialSkin.MouseState.OUT;
            this.QuantityControl.Multiline = false;
            this.QuantityControl.Name = "QuantityControl";
            this.QuantityControl.Size = new System.Drawing.Size(400, 50);
            this.QuantityControl.TabIndex = 3;
            this.QuantityControl.Text = "";
            this.QuantityControl.TrailingIcon = null;
            this.QuantityControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
            // 
            // ReceivingSetionControl
            // 
            this.ReceivingSetionControl.Controls.Add(this.LotErrorCaption);
            this.ReceivingSetionControl.Controls.Add(this.WarehouseControl);
            this.ReceivingSetionControl.Controls.Add(this.DateProcuredSection);
            this.ReceivingSetionControl.Controls.Add(this.LotControl);
            this.ReceivingSetionControl.Controls.Add(this.materialLabel1);
            this.ReceivingSetionControl.Controls.Add(this.WarehouseErrorCaption);
            this.ReceivingSetionControl.Controls.Add(this.ProductErrorCaption);
            this.ReceivingSetionControl.Controls.Add(this.ProductControl);
            this.ReceivingSetionControl.Controls.Add(this.PickDateControl);
            this.ReceivingSetionControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReceivingSetionControl.Location = new System.Drawing.Point(0, 0);
            this.ReceivingSetionControl.Name = "ReceivingSetionControl";
            this.ReceivingSetionControl.Size = new System.Drawing.Size(500, 600);
            this.ReceivingSetionControl.TabIndex = 1;
            // 
            // LotErrorCaption
            // 
            this.LotErrorCaption.AutoSize = true;
            this.LotErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.LotErrorCaption.Location = new System.Drawing.Point(25, 317);
            this.LotErrorCaption.Name = "LotErrorCaption";
            this.LotErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.LotErrorCaption.TabIndex = 22;
            this.LotErrorCaption.Tag = "";
            // 
            // WarehouseControl
            // 
            this.WarehouseControl.AnimateReadOnly = false;
            this.WarehouseControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehouseControl.Depth = 0;
            this.WarehouseControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WarehouseControl.Hint = "Warehouse";
            this.WarehouseControl.LeadingIcon = null;
            this.WarehouseControl.Location = new System.Drawing.Point(25, 174);
            this.WarehouseControl.MaxLength = 50;
            this.WarehouseControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WarehouseControl.Multiline = false;
            this.WarehouseControl.Name = "WarehouseControl";
            this.WarehouseControl.Size = new System.Drawing.Size(400, 50);
            this.WarehouseControl.TabIndex = 1;
            this.WarehouseControl.Text = "";
            this.WarehouseControl.TrailingIcon = null;
            // 
            // DateProcuredSection
            // 
            this.DateProcuredSection.Controls.Add(this.SwitchDateCaptionControl);
            this.DateProcuredSection.Controls.Add(this.SelectedDateControl);
            this.DateProcuredSection.Controls.Add(this.SwitchDateControl);
            this.DateProcuredSection.Location = new System.Drawing.Point(25, 356);
            this.DateProcuredSection.Name = "DateProcuredSection";
            this.DateProcuredSection.Size = new System.Drawing.Size(456, 100);
            this.DateProcuredSection.TabIndex = 3;
            // 
            // SwitchDateCaptionControl
            // 
            this.SwitchDateCaptionControl.AutoSize = true;
            this.SwitchDateCaptionControl.Depth = 0;
            this.SwitchDateCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchDateCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchDateCaptionControl.Location = new System.Drawing.Point(0, 16);
            this.SwitchDateCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchDateCaptionControl.Name = "SwitchDateCaptionControl";
            this.SwitchDateCaptionControl.Size = new System.Drawing.Size(162, 17);
            this.SwitchDateCaptionControl.TabIndex = 20;
            this.SwitchDateCaptionControl.Text = "I\'m using the current date";
            // 
            // SelectedDateControl
            // 
            this.SelectedDateControl.BackColor = System.Drawing.Color.Red;
            this.SelectedDateControl.Depth = 0;
            this.SelectedDateControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectedDateControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SelectedDateControl.Location = new System.Drawing.Point(187, 39);
            this.SelectedDateControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectedDateControl.Name = "SelectedDateControl";
            this.SelectedDateControl.Size = new System.Drawing.Size(213, 23);
            this.SelectedDateControl.TabIndex = 18;
            this.SelectedDateControl.Text = "materialLabel1";
            this.SelectedDateControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SwitchDateControl
            // 
            this.SwitchDateControl.AutoSize = true;
            this.SwitchDateControl.Checked = true;
            this.SwitchDateControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchDateControl.Depth = 0;
            this.SwitchDateControl.Location = new System.Drawing.Point(0, 33);
            this.SwitchDateControl.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchDateControl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchDateControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchDateControl.Name = "SwitchDateControl";
            this.SwitchDateControl.Ripple = true;
            this.SwitchDateControl.Size = new System.Drawing.Size(165, 37);
            this.SwitchDateControl.TabIndex = 0;
            this.SwitchDateControl.Text = "Use a new date";
            this.SwitchDateControl.UseVisualStyleBackColor = true;
            this.SwitchDateControl.CheckedChanged += new System.EventHandler(this.SwitchDateControl_CheckedChanged);
            // 
            // LotControl
            // 
            this.LotControl.AnimateReadOnly = false;
            this.LotControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LotControl.Depth = 0;
            this.LotControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LotControl.Hint = "Lot";
            this.LotControl.LeadingIcon = null;
            this.LotControl.Location = new System.Drawing.Point(25, 264);
            this.LotControl.MaxLength = 50;
            this.LotControl.MouseState = MaterialSkin.MouseState.OUT;
            this.LotControl.Multiline = false;
            this.LotControl.Name = "LotControl";
            this.LotControl.Size = new System.Drawing.Size(400, 50);
            this.LotControl.TabIndex = 2;
            this.LotControl.Text = "";
            this.LotControl.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(25, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(225, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Store Materials Procured";
            // 
            // WarehouseErrorCaption
            // 
            this.WarehouseErrorCaption.AutoSize = true;
            this.WarehouseErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.WarehouseErrorCaption.Location = new System.Drawing.Point(25, 226);
            this.WarehouseErrorCaption.Name = "WarehouseErrorCaption";
            this.WarehouseErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.WarehouseErrorCaption.TabIndex = 13;
            // 
            // ProductErrorCaption
            // 
            this.ProductErrorCaption.AutoSize = true;
            this.ProductErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ProductErrorCaption.Location = new System.Drawing.Point(25, 134);
            this.ProductErrorCaption.Name = "ProductErrorCaption";
            this.ProductErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ProductErrorCaption.TabIndex = 12;
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
            this.ProductControl.Location = new System.Drawing.Point(25, 82);
            this.ProductControl.MaxDropDownItems = 4;
            this.ProductControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductControl.Name = "ProductControl";
            this.ProductControl.Size = new System.Drawing.Size(400, 49);
            this.ProductControl.StartIndex = 0;
            this.ProductControl.TabIndex = 0;
            // 
            // PickDateControl
            // 
            this.PickDateControl.Enabled = false;
            this.PickDateControl.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickDateControl.Location = new System.Drawing.Point(25, 498);
            this.PickDateControl.Name = "PickDateControl";
            this.PickDateControl.Size = new System.Drawing.Size(400, 30);
            this.PickDateControl.TabIndex = 4;
            this.PickDateControl.ValueChanged += new System.EventHandler(this.PickDateControl_ValueChanged);
            // 
            // QuantityErrorCaption
            // 
            this.QuantityErrorCaption.AutoSize = true;
            this.QuantityErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.QuantityErrorCaption.Location = new System.Drawing.Point(25, 277);
            this.QuantityErrorCaption.Name = "QuantityErrorCaption";
            this.QuantityErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.QuantityErrorCaption.TabIndex = 19;
            this.QuantityErrorCaption.Tag = "";
            // 
            // UnitsErrorCaption
            // 
            this.UnitsErrorCaption.AutoSize = true;
            this.UnitsErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.UnitsErrorCaption.Location = new System.Drawing.Point(25, 366);
            this.UnitsErrorCaption.Name = "UnitsErrorCaption";
            this.UnitsErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.UnitsErrorCaption.TabIndex = 16;
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
            this.MaterialProcurementSection.Controls.Add(this.UnitsControl);
            this.MaterialProcurementSection.Controls.Add(this.QuantityErrorCaption);
            this.MaterialProcurementSection.Controls.Add(this.TruckNumberErrorCaption);
            this.MaterialProcurementSection.Controls.Add(this.SupplierErrorCaption);
            this.MaterialProcurementSection.Controls.Add(this.UnitsErrorCaption);
            this.MaterialProcurementSection.Controls.Add(this.RemarksCaptionControl);
            this.MaterialProcurementSection.Controls.Add(this.RemarksControl);
            this.MaterialProcurementSection.Controls.Add(this.SupplierControl);
            this.MaterialProcurementSection.Controls.Add(this.TruckNumberControl);
            this.MaterialProcurementSection.Controls.Add(this.SaveProcurementRecords);
            this.MaterialProcurementSection.Controls.Add(this.QuantityControl);
            this.MaterialProcurementSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaterialProcurementSection.Location = new System.Drawing.Point(550, 0);
            this.MaterialProcurementSection.Name = "MaterialProcurementSection";
            this.MaterialProcurementSection.Size = new System.Drawing.Size(450, 600);
            this.MaterialProcurementSection.TabIndex = 2;
            // 
            // UnitsControl
            // 
            this.UnitsControl.AnimateReadOnly = false;
            this.UnitsControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitsControl.Depth = 0;
            this.UnitsControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UnitsControl.Hint = "Unit";
            this.UnitsControl.LeadingIcon = null;
            this.UnitsControl.Location = new System.Drawing.Point(25, 314);
            this.UnitsControl.MaxLength = 50;
            this.UnitsControl.MouseState = MaterialSkin.MouseState.OUT;
            this.UnitsControl.Multiline = false;
            this.UnitsControl.Name = "UnitsControl";
            this.UnitsControl.Size = new System.Drawing.Size(400, 50);
            this.UnitsControl.TabIndex = 4;
            this.UnitsControl.Text = "";
            this.UnitsControl.TrailingIcon = null;
            // 
            // TruckNumberErrorCaption
            // 
            this.TruckNumberErrorCaption.AutoSize = true;
            this.TruckNumberErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.TruckNumberErrorCaption.Location = new System.Drawing.Point(25, 186);
            this.TruckNumberErrorCaption.Name = "TruckNumberErrorCaption";
            this.TruckNumberErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.TruckNumberErrorCaption.TabIndex = 18;
            // 
            // SupplierErrorCaption
            // 
            this.SupplierErrorCaption.AutoSize = true;
            this.SupplierErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.SupplierErrorCaption.Location = new System.Drawing.Point(25, 96);
            this.SupplierErrorCaption.Name = "SupplierErrorCaption";
            this.SupplierErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.SupplierErrorCaption.TabIndex = 15;
            // 
            // RemarksCaptionControl
            // 
            this.RemarksCaptionControl.AutoSize = true;
            this.RemarksCaptionControl.Depth = 0;
            this.RemarksCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RemarksCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.RemarksCaptionControl.Location = new System.Drawing.Point(25, 400);
            this.RemarksCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemarksCaptionControl.Name = "RemarksCaptionControl";
            this.RemarksCaptionControl.Size = new System.Drawing.Size(165, 17);
            this.RemarksCaptionControl.TabIndex = 17;
            this.RemarksCaptionControl.Text = "Remarks (500 characters)";
            // 
            // RemarksControl
            // 
            this.RemarksControl.AnimateReadOnly = false;
            this.RemarksControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemarksControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RemarksControl.Depth = 0;
            this.RemarksControl.Font = new System.Drawing.Font("Roboto Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemarksControl.HideSelection = true;
            this.RemarksControl.Location = new System.Drawing.Point(25, 420);
            this.RemarksControl.MaxLength = 32767;
            this.RemarksControl.MouseState = MaterialSkin.MouseState.OUT;
            this.RemarksControl.Name = "RemarksControl";
            this.RemarksControl.PasswordChar = '\0';
            this.RemarksControl.ReadOnly = false;
            this.RemarksControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RemarksControl.SelectedText = "";
            this.RemarksControl.SelectionLength = 0;
            this.RemarksControl.SelectionStart = 0;
            this.RemarksControl.ShortcutsEnabled = true;
            this.RemarksControl.Size = new System.Drawing.Size(400, 113);
            this.RemarksControl.TabIndex = 5;
            this.RemarksControl.TabStop = false;
            this.RemarksControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemarksControl.UseSystemPasswordChar = false;
            this.RemarksControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemarksControl_KeyUp);
            // 
            // SaveProcurementRecords
            // 
            this.SaveProcurementRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveProcurementRecords.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.SaveProcurementRecords.TabIndex = 1;
            this.SaveProcurementRecords.Text = " Save ";
            this.SaveProcurementRecords.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveProcurementRecords.UseAccentColor = true;
            this.SaveProcurementRecords.UseVisualStyleBackColor = true;
            this.SaveProcurementRecords.Click += new System.EventHandler(this.SaveProcurementRecords_Click);
            // 
            // ProcurementReceiveMaterialsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaterialProcurementSection);
            this.Controls.Add(this.MaterialProcurementDividerControl);
            this.Controls.Add(this.ReceivingSetionControl);
            this.Name = "ProcurementReceiveMaterialsUserControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ReceivingSetionControl.ResumeLayout(false);
            this.ReceivingSetionControl.PerformLayout();
            this.DateProcuredSection.ResumeLayout(false);
            this.DateProcuredSection.PerformLayout();
            this.MaterialProcurementSection.ResumeLayout(false);
            this.MaterialProcurementSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox SuplierControl;
        private MaterialSkin.Controls.MaterialTextBox TruckNumberControl;
        private MaterialSkin.Controls.MaterialTextBox QuantityControl;
        private Panel ReceivingSetionControl;
        private Panel MaterialProcurementDividerControl;
        private Panel MaterialProcurementSection;
        private MaterialSkin.Controls.MaterialComboBox ProductControl;
        private DateTimePicker PickDateControl;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton SaveProcurementRecords;
        private MaterialSkin.Controls.MaterialTextBox SupplierControl;
        private MaterialSkin.Controls.MaterialLabel RemarksCaptionControl;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 RemarksControl;
        private Label SupplierErrorCaption;
        private Label WarehouseErrorCaption;
        private Label ProductErrorCaption;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label UnitsErrorCaption;
        private Label TruckNumberErrorCaption;
        private Panel DateProcuredSection;
        private Label QuantityErrorCaption;
        private MaterialSkin.Controls.MaterialLabel SwitchDateCaptionControl;
        private MaterialSkin.Controls.MaterialLabel SelectedDateControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchDateControl;
        private MaterialSkin.Controls.MaterialTextBox LotControl;
        private MaterialSkin.Controls.MaterialTextBox WarehouseControl;
        private Label LotErrorCaption;
        private MaterialSkin.Controls.MaterialTextBox UnitsControl;
    }
}
