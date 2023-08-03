﻿namespace FPIS.Views
{
    partial class UserControlProcurementReceiveMaterials
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
            this.MaterialProcurementLastSection = new System.Windows.Forms.Panel();
            this.TruckNumberErrorCaption = new System.Windows.Forms.Label();
            this.CountryErrorControl = new System.Windows.Forms.Label();
            this.SupplierErrorCaption = new System.Windows.Forms.Label();
            this.SupplierControl = new MaterialSkin.Controls.MaterialTextBox();
            this.CountryControl = new MaterialSkin.Controls.MaterialTextBox();
            this.TruckNumberControl = new MaterialSkin.Controls.MaterialTextBox();
            this.CityControl = new MaterialSkin.Controls.MaterialTextBox();
            this.CityErrorControl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Snackbar = new MaterialSkin.Controls.MaterialCard();
            this.OpenHelper = new System.Windows.Forms.PictureBox();
            this.AddNewRequest = new System.Windows.Forms.PictureBox();
            this.CloseSnackbarControl = new System.Windows.Forms.PictureBox();
            this.SnackbarCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SaveProcurementRecords = new MaterialSkin.Controls.MaterialButton();
            this.StartSampleRequest = new MaterialSkin.Controls.MaterialButton();
            this.AbortProcurementRecords = new MaterialSkin.Controls.MaterialButton();
            this.DoneControl = new MaterialSkin.Controls.MaterialButton();
            this.MaterialProcurementFirstSection = new System.Windows.Forms.Panel();
            this.SyncControl = new System.Windows.Forms.PictureBox();
            this.ListOfRequestedSamplesControl = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.ViewSampleRequestedControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ReceivingSectionControl = new System.Windows.Forms.Panel();
            this.DateProcuredSection = new System.Windows.Forms.Panel();
            this.SwitchDateCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SelectedDateControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchDateControl = new MaterialSkin.Controls.MaterialSwitch();
            this.PickDateControl = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ProductControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ProductErrorCaption = new System.Windows.Forms.Label();
            this.RemarksCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.RemarksControl = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.MaterialProcurementLastSection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Snackbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenHelper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSnackbarControl)).BeginInit();
            this.MaterialProcurementFirstSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncControl)).BeginInit();
            this.ListOfRequestedSamplesControl.SuspendLayout();
            this.ReceivingSectionControl.SuspendLayout();
            this.DateProcuredSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialProcurementLastSection
            // 
            this.MaterialProcurementLastSection.Controls.Add(this.TruckNumberErrorCaption);
            this.MaterialProcurementLastSection.Controls.Add(this.CountryErrorControl);
            this.MaterialProcurementLastSection.Controls.Add(this.SupplierErrorCaption);
            this.MaterialProcurementLastSection.Controls.Add(this.SupplierControl);
            this.MaterialProcurementLastSection.Controls.Add(this.CountryControl);
            this.MaterialProcurementLastSection.Controls.Add(this.TruckNumberControl);
            this.MaterialProcurementLastSection.Controls.Add(this.CityControl);
            this.MaterialProcurementLastSection.Controls.Add(this.CityErrorControl);
            this.MaterialProcurementLastSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialProcurementLastSection.Enabled = false;
            this.MaterialProcurementLastSection.Location = new System.Drawing.Point(500, 0);
            this.MaterialProcurementLastSection.Name = "MaterialProcurementLastSection";
            this.MaterialProcurementLastSection.Size = new System.Drawing.Size(500, 492);
            this.MaterialProcurementLastSection.TabIndex = 15;
            // 
            // TruckNumberErrorCaption
            // 
            this.TruckNumberErrorCaption.AutoSize = true;
            this.TruckNumberErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.TruckNumberErrorCaption.Location = new System.Drawing.Point(52, 194);
            this.TruckNumberErrorCaption.Name = "TruckNumberErrorCaption";
            this.TruckNumberErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.TruckNumberErrorCaption.TabIndex = 18;
            // 
            // CountryErrorControl
            // 
            this.CountryErrorControl.AutoSize = true;
            this.CountryErrorControl.ForeColor = System.Drawing.Color.Red;
            this.CountryErrorControl.Location = new System.Drawing.Point(52, 374);
            this.CountryErrorControl.Name = "CountryErrorControl";
            this.CountryErrorControl.Size = new System.Drawing.Size(0, 15);
            this.CountryErrorControl.TabIndex = 33;
            this.CountryErrorControl.Tag = "";
            // 
            // SupplierErrorCaption
            // 
            this.SupplierErrorCaption.AutoSize = true;
            this.SupplierErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.SupplierErrorCaption.Location = new System.Drawing.Point(52, 104);
            this.SupplierErrorCaption.Name = "SupplierErrorCaption";
            this.SupplierErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.SupplierErrorCaption.TabIndex = 15;
            // 
            // SupplierControl
            // 
            this.SupplierControl.AnimateReadOnly = false;
            this.SupplierControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierControl.Depth = 0;
            this.SupplierControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SupplierControl.Hint = "Supplier";
            this.SupplierControl.LeadingIcon = null;
            this.SupplierControl.Location = new System.Drawing.Point(49, 51);
            this.SupplierControl.MaxLength = 50;
            this.SupplierControl.MouseState = MaterialSkin.MouseState.OUT;
            this.SupplierControl.Multiline = false;
            this.SupplierControl.Name = "SupplierControl";
            this.SupplierControl.Size = new System.Drawing.Size(400, 50);
            this.SupplierControl.TabIndex = 0;
            this.SupplierControl.Text = "";
            this.SupplierControl.TrailingIcon = null;
            // 
            // CountryControl
            // 
            this.CountryControl.AnimateReadOnly = false;
            this.CountryControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountryControl.Depth = 0;
            this.CountryControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CountryControl.Hint = "Country";
            this.CountryControl.LeadingIcon = null;
            this.CountryControl.Location = new System.Drawing.Point(49, 321);
            this.CountryControl.MaxLength = 50;
            this.CountryControl.MouseState = MaterialSkin.MouseState.OUT;
            this.CountryControl.Multiline = false;
            this.CountryControl.Name = "CountryControl";
            this.CountryControl.Size = new System.Drawing.Size(400, 50);
            this.CountryControl.TabIndex = 5;
            this.CountryControl.Text = "";
            this.CountryControl.TrailingIcon = null;
            // 
            // TruckNumberControl
            // 
            this.TruckNumberControl.AnimateReadOnly = false;
            this.TruckNumberControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TruckNumberControl.Depth = 0;
            this.TruckNumberControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TruckNumberControl.Hint = "Truck Number";
            this.TruckNumberControl.LeadingIcon = null;
            this.TruckNumberControl.Location = new System.Drawing.Point(49, 141);
            this.TruckNumberControl.MaxLength = 50;
            this.TruckNumberControl.MouseState = MaterialSkin.MouseState.OUT;
            this.TruckNumberControl.Multiline = false;
            this.TruckNumberControl.Name = "TruckNumberControl";
            this.TruckNumberControl.Size = new System.Drawing.Size(400, 50);
            this.TruckNumberControl.TabIndex = 1;
            this.TruckNumberControl.Text = "";
            this.TruckNumberControl.TrailingIcon = null;
            // 
            // CityControl
            // 
            this.CityControl.AnimateReadOnly = false;
            this.CityControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CityControl.Depth = 0;
            this.CityControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CityControl.Hint = "City";
            this.CityControl.LeadingIcon = null;
            this.CityControl.Location = new System.Drawing.Point(49, 231);
            this.CityControl.MaxLength = 50;
            this.CityControl.MouseState = MaterialSkin.MouseState.OUT;
            this.CityControl.Multiline = false;
            this.CityControl.Name = "CityControl";
            this.CityControl.Size = new System.Drawing.Size(400, 50);
            this.CityControl.TabIndex = 4;
            this.CityControl.Text = "";
            this.CityControl.TrailingIcon = null;
            // 
            // CityErrorControl
            // 
            this.CityErrorControl.AutoSize = true;
            this.CityErrorControl.ForeColor = System.Drawing.Color.Red;
            this.CityErrorControl.Location = new System.Drawing.Point(52, 284);
            this.CityErrorControl.Name = "CityErrorControl";
            this.CityErrorControl.Size = new System.Drawing.Size(0, 15);
            this.CityErrorControl.TabIndex = 32;
            this.CityErrorControl.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Snackbar);
            this.panel1.Controls.Add(this.SaveProcurementRecords);
            this.panel1.Controls.Add(this.StartSampleRequest);
            this.panel1.Controls.Add(this.AbortProcurementRecords);
            this.panel1.Controls.Add(this.DoneControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(500, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 108);
            this.panel1.TabIndex = 13;
            // 
            // Snackbar
            // 
            this.Snackbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Snackbar.Controls.Add(this.OpenHelper);
            this.Snackbar.Controls.Add(this.AddNewRequest);
            this.Snackbar.Controls.Add(this.CloseSnackbarControl);
            this.Snackbar.Controls.Add(this.SnackbarCaptionControl);
            this.Snackbar.Depth = 0;
            this.Snackbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Snackbar.Location = new System.Drawing.Point(49, 10);
            this.Snackbar.Margin = new System.Windows.Forms.Padding(14);
            this.Snackbar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Snackbar.Name = "Snackbar";
            this.Snackbar.Padding = new System.Windows.Forms.Padding(14);
            this.Snackbar.Size = new System.Drawing.Size(400, 35);
            this.Snackbar.TabIndex = 3;
            // 
            // OpenHelper
            // 
            this.OpenHelper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenHelper.Image = global::FPIS.Properties.Resources.help_black;
            this.OpenHelper.Location = new System.Drawing.Point(358, 5);
            this.OpenHelper.Name = "OpenHelper";
            this.OpenHelper.Size = new System.Drawing.Size(25, 25);
            this.OpenHelper.TabIndex = 25;
            this.OpenHelper.TabStop = false;
            this.OpenHelper.Click += new System.EventHandler(this.OpenHelper_Click);
            // 
            // AddNewRequest
            // 
            this.AddNewRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewRequest.Image = global::FPIS.Properties.Resources.add_dark;
            this.AddNewRequest.Location = new System.Drawing.Point(326, 5);
            this.AddNewRequest.Name = "AddNewRequest";
            this.AddNewRequest.Size = new System.Drawing.Size(25, 25);
            this.AddNewRequest.TabIndex = 24;
            this.AddNewRequest.TabStop = false;
            this.AddNewRequest.Click += new System.EventHandler(this.AddNewRequest_Click);
            // 
            // CloseSnackbarControl
            // 
            this.CloseSnackbarControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseSnackbarControl.Image = global::FPIS.Properties.Resources.close_dark;
            this.CloseSnackbarControl.Location = new System.Drawing.Point(301, 8);
            this.CloseSnackbarControl.Name = "CloseSnackbarControl";
            this.CloseSnackbarControl.Size = new System.Drawing.Size(18, 18);
            this.CloseSnackbarControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseSnackbarControl.TabIndex = 23;
            this.CloseSnackbarControl.TabStop = false;
            this.CloseSnackbarControl.Click += new System.EventHandler(this.CloseSnackbarControl_Click);
            // 
            // SnackbarCaptionControl
            // 
            this.SnackbarCaptionControl.Depth = 0;
            this.SnackbarCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SnackbarCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SnackbarCaptionControl.Location = new System.Drawing.Point(0, 8);
            this.SnackbarCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SnackbarCaptionControl.Name = "SnackbarCaptionControl";
            this.SnackbarCaptionControl.Size = new System.Drawing.Size(295, 19);
            this.SnackbarCaptionControl.TabIndex = 0;
            this.SnackbarCaptionControl.Text = "Sample was requested successfully! 👍";
            this.SnackbarCaptionControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SnackbarCaptionControl.UseAccent = true;
            // 
            // SaveProcurementRecords
            // 
            this.SaveProcurementRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveProcurementRecords.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.SaveProcurementRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveProcurementRecords.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveProcurementRecords.Depth = 0;
            this.SaveProcurementRecords.Enabled = false;
            this.SaveProcurementRecords.HighEmphasis = true;
            this.SaveProcurementRecords.Icon = null;
            this.SaveProcurementRecords.Location = new System.Drawing.Point(395, 62);
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
            // StartSampleRequest
            // 
            this.StartSampleRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartSampleRequest.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.StartSampleRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartSampleRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartSampleRequest.Depth = 0;
            this.StartSampleRequest.HighEmphasis = true;
            this.StartSampleRequest.Icon = null;
            this.StartSampleRequest.Location = new System.Drawing.Point(40, 62);
            this.StartSampleRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartSampleRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartSampleRequest.Name = "StartSampleRequest";
            this.StartSampleRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartSampleRequest.Size = new System.Drawing.Size(123, 36);
            this.StartSampleRequest.TabIndex = 6;
            this.StartSampleRequest.Text = " Send Sample";
            this.StartSampleRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartSampleRequest.UseAccentColor = true;
            this.StartSampleRequest.UseVisualStyleBackColor = true;
            this.StartSampleRequest.Click += new System.EventHandler(this.StartSampleRequest_Click);
            // 
            // AbortProcurementRecords
            // 
            this.AbortProcurementRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AbortProcurementRecords.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.AbortProcurementRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbortProcurementRecords.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AbortProcurementRecords.Depth = 0;
            this.AbortProcurementRecords.Enabled = false;
            this.AbortProcurementRecords.HighEmphasis = true;
            this.AbortProcurementRecords.Icon = null;
            this.AbortProcurementRecords.Location = new System.Drawing.Point(310, 62);
            this.AbortProcurementRecords.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AbortProcurementRecords.MouseState = MaterialSkin.MouseState.HOVER;
            this.AbortProcurementRecords.Name = "AbortProcurementRecords";
            this.AbortProcurementRecords.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AbortProcurementRecords.Size = new System.Drawing.Size(72, 36);
            this.AbortProcurementRecords.TabIndex = 22;
            this.AbortProcurementRecords.Text = " Abort ";
            this.AbortProcurementRecords.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AbortProcurementRecords.UseAccentColor = true;
            this.AbortProcurementRecords.UseVisualStyleBackColor = true;
            this.AbortProcurementRecords.Click += new System.EventHandler(this.AbortProcurementRecords_Click);
            // 
            // DoneControl
            // 
            this.DoneControl.AutoSize = false;
            this.DoneControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DoneControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.DoneControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.DoneControl.Cursor = System.Windows.Forms.Cursors.No;
            this.DoneControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DoneControl.Depth = 0;
            this.DoneControl.FlatAppearance.BorderSize = 0;
            this.DoneControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneControl.ForeColor = System.Drawing.Color.White;
            this.DoneControl.HighEmphasis = true;
            this.DoneControl.Icon = global::FPIS.Properties.Resources.not_done_light;
            this.DoneControl.Image = global::FPIS.Properties.Resources.not_done_light;
            this.DoneControl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DoneControl.Location = new System.Drawing.Point(176, 62);
            this.DoneControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DoneControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneControl.Name = "DoneControl";
            this.DoneControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DoneControl.Size = new System.Drawing.Size(121, 36);
            this.DoneControl.TabIndex = 23;
            this.DoneControl.Text = "  Ready";
            this.DoneControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DoneControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DoneControl.UseAccentColor = true;
            this.DoneControl.UseVisualStyleBackColor = false;
            this.DoneControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcurementReceiveMaterialsUserControl_KeyDown);
            // 
            // MaterialProcurementFirstSection
            // 
            this.MaterialProcurementFirstSection.Controls.Add(this.SyncControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.ListOfRequestedSamplesControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.ReceivingSectionControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.materialLabel1);
            this.MaterialProcurementFirstSection.Controls.Add(this.ProductControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.ProductErrorCaption);
            this.MaterialProcurementFirstSection.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaterialProcurementFirstSection.Location = new System.Drawing.Point(0, 0);
            this.MaterialProcurementFirstSection.Name = "MaterialProcurementFirstSection";
            this.MaterialProcurementFirstSection.Size = new System.Drawing.Size(500, 600);
            this.MaterialProcurementFirstSection.TabIndex = 14;
            // 
            // SyncControl
            // 
            this.SyncControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SyncControl.Image = global::FPIS.Properties.Resources.sync_dark;
            this.SyncControl.Location = new System.Drawing.Point(431, 122);
            this.SyncControl.Name = "SyncControl";
            this.SyncControl.Size = new System.Drawing.Size(25, 25);
            this.SyncControl.TabIndex = 26;
            this.SyncControl.TabStop = false;
            this.SyncControl.Click += new System.EventHandler(this.SyncControl_Click);
            // 
            // ListOfRequestedSamplesControl
            // 
            this.ListOfRequestedSamplesControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListOfRequestedSamplesControl.CancelButtonText = "";
            this.ListOfRequestedSamplesControl.Collapse = true;
            this.ListOfRequestedSamplesControl.Controls.Add(this.ViewSampleRequestedControl);
            this.ListOfRequestedSamplesControl.Depth = 0;
            this.ListOfRequestedSamplesControl.Description = "";
            this.ListOfRequestedSamplesControl.ExpandHeight = 200;
            this.ListOfRequestedSamplesControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListOfRequestedSamplesControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListOfRequestedSamplesControl.Location = new System.Drawing.Point(25, 48);
            this.ListOfRequestedSamplesControl.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.ListOfRequestedSamplesControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListOfRequestedSamplesControl.Name = "ListOfRequestedSamplesControl";
            this.ListOfRequestedSamplesControl.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.ListOfRequestedSamplesControl.Size = new System.Drawing.Size(400, 48);
            this.ListOfRequestedSamplesControl.TabIndex = 23;
            this.ListOfRequestedSamplesControl.Title = "Choose a sample you requested   ";
            this.ListOfRequestedSamplesControl.UseAccentColor = true;
            this.ListOfRequestedSamplesControl.ValidationButtonEnable = true;
            this.ListOfRequestedSamplesControl.ValidationButtonText = "Load";
            this.ListOfRequestedSamplesControl.Visible = false;
            this.ListOfRequestedSamplesControl.SaveClick += new System.EventHandler(this.ListOfRequestedSamplesControl_LoadClick);
            // 
            // ViewSampleRequestedControl
            // 
            this.ViewSampleRequestedControl.AutoResize = false;
            this.ViewSampleRequestedControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ViewSampleRequestedControl.Depth = 0;
            this.ViewSampleRequestedControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ViewSampleRequestedControl.DropDownHeight = 174;
            this.ViewSampleRequestedControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewSampleRequestedControl.DropDownWidth = 121;
            this.ViewSampleRequestedControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ViewSampleRequestedControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewSampleRequestedControl.FormattingEnabled = true;
            this.ViewSampleRequestedControl.Hint = "Pick a sample";
            this.ViewSampleRequestedControl.IntegralHeight = false;
            this.ViewSampleRequestedControl.ItemHeight = 43;
            this.ViewSampleRequestedControl.Location = new System.Drawing.Point(27, 56);
            this.ViewSampleRequestedControl.MaxDropDownItems = 4;
            this.ViewSampleRequestedControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ViewSampleRequestedControl.Name = "ViewSampleRequestedControl";
            this.ViewSampleRequestedControl.Size = new System.Drawing.Size(346, 49);
            this.ViewSampleRequestedControl.StartIndex = 0;
            this.ViewSampleRequestedControl.TabIndex = 0;
            // 
            // ReceivingSectionControl
            // 
            this.ReceivingSectionControl.Controls.Add(this.RemarksCaptionControl);
            this.ReceivingSectionControl.Controls.Add(this.RemarksControl);
            this.ReceivingSectionControl.Controls.Add(this.DateProcuredSection);
            this.ReceivingSectionControl.Controls.Add(this.PickDateControl);
            this.ReceivingSectionControl.Enabled = false;
            this.ReceivingSectionControl.Location = new System.Drawing.Point(25, 176);
            this.ReceivingSectionControl.Name = "ReceivingSectionControl";
            this.ReceivingSectionControl.Size = new System.Drawing.Size(451, 361);
            this.ReceivingSectionControl.TabIndex = 0;
            // 
            // DateProcuredSection
            // 
            this.DateProcuredSection.Controls.Add(this.SwitchDateCaptionControl);
            this.DateProcuredSection.Controls.Add(this.SelectedDateControl);
            this.DateProcuredSection.Controls.Add(this.SwitchDateControl);
            this.DateProcuredSection.Location = new System.Drawing.Point(-3, 28);
            this.DateProcuredSection.Name = "DateProcuredSection";
            this.DateProcuredSection.Size = new System.Drawing.Size(456, 100);
            this.DateProcuredSection.TabIndex = 8;
            // 
            // SwitchDateCaptionControl
            // 
            this.SwitchDateCaptionControl.AutoSize = true;
            this.SwitchDateCaptionControl.Depth = 0;
            this.SwitchDateCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchDateCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchDateCaptionControl.Location = new System.Drawing.Point(3, 16);
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
            this.SwitchDateControl.Location = new System.Drawing.Point(3, 33);
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
            // PickDateControl
            // 
            this.PickDateControl.Enabled = false;
            this.PickDateControl.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickDateControl.Location = new System.Drawing.Point(-3, 134);
            this.PickDateControl.Name = "PickDateControl";
            this.PickDateControl.Size = new System.Drawing.Size(400, 30);
            this.PickDateControl.TabIndex = 2;
            this.PickDateControl.ValueChanged += new System.EventHandler(this.PickDateControl_ValueChanged);
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
            this.materialLabel1.Size = new System.Drawing.Size(315, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Store Details of Materials Procured";
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
            this.ProductControl.Location = new System.Drawing.Point(25, 108);
            this.ProductControl.MaxDropDownItems = 4;
            this.ProductControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductControl.Name = "ProductControl";
            this.ProductControl.Size = new System.Drawing.Size(400, 49);
            this.ProductControl.StartIndex = 0;
            this.ProductControl.TabIndex = 5;
            // 
            // ProductErrorCaption
            // 
            this.ProductErrorCaption.AutoSize = true;
            this.ProductErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ProductErrorCaption.Location = new System.Drawing.Point(28, 158);
            this.ProductErrorCaption.Name = "ProductErrorCaption";
            this.ProductErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ProductErrorCaption.TabIndex = 12;
            // 
            // RemarksCaptionControl
            // 
            this.RemarksCaptionControl.AutoSize = true;
            this.RemarksCaptionControl.Depth = 0;
            this.RemarksCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RemarksCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.RemarksCaptionControl.Location = new System.Drawing.Point(3, 201);
            this.RemarksCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemarksCaptionControl.Name = "RemarksCaptionControl";
            this.RemarksCaptionControl.Size = new System.Drawing.Size(165, 17);
            this.RemarksCaptionControl.TabIndex = 38;
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
            this.RemarksControl.Location = new System.Drawing.Point(3, 221);
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
            this.RemarksControl.TabIndex = 37;
            this.RemarksControl.TabStop = false;
            this.RemarksControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemarksControl.UseSystemPasswordChar = false;
            // 
            // UserControlProcurementReceiveMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaterialProcurementLastSection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MaterialProcurementFirstSection);
            this.Name = "UserControlProcurementReceiveMaterials";
            this.Size = new System.Drawing.Size(1000, 600);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcurementReceiveMaterialsUserControl_KeyDown);
            this.MaterialProcurementLastSection.ResumeLayout(false);
            this.MaterialProcurementLastSection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Snackbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenHelper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSnackbarControl)).EndInit();
            this.MaterialProcurementFirstSection.ResumeLayout(false);
            this.MaterialProcurementFirstSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncControl)).EndInit();
            this.ListOfRequestedSamplesControl.ResumeLayout(false);
            this.ListOfRequestedSamplesControl.PerformLayout();
            this.ReceivingSectionControl.ResumeLayout(false);
            this.ReceivingSectionControl.PerformLayout();
            this.DateProcuredSection.ResumeLayout(false);
            this.DateProcuredSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MaterialProcurementLastSection;
        private Label TruckNumberErrorCaption;
        private Label CountryErrorControl;
        private Label SupplierErrorCaption;
        private MaterialSkin.Controls.MaterialTextBox SupplierControl;
        private MaterialSkin.Controls.MaterialTextBox CountryControl;
        private MaterialSkin.Controls.MaterialTextBox TruckNumberControl;
        private MaterialSkin.Controls.MaterialTextBox CityControl;
        private Label CityErrorControl;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard Snackbar;
        private PictureBox OpenHelper;
        private PictureBox AddNewRequest;
        private PictureBox CloseSnackbarControl;
        private MaterialSkin.Controls.MaterialLabel SnackbarCaptionControl;
        private MaterialSkin.Controls.MaterialButton SaveProcurementRecords;
        private MaterialSkin.Controls.MaterialButton StartSampleRequest;
        private MaterialSkin.Controls.MaterialButton AbortProcurementRecords;
        private MaterialSkin.Controls.MaterialButton DoneControl;
        private Panel MaterialProcurementFirstSection;
        private PictureBox SyncControl;
        private MaterialSkin.Controls.MaterialExpansionPanel ListOfRequestedSamplesControl;
        private MaterialSkin.Controls.MaterialComboBox ViewSampleRequestedControl;
        private Panel ReceivingSectionControl;
        private Panel DateProcuredSection;
        private MaterialSkin.Controls.MaterialLabel SwitchDateCaptionControl;
        private MaterialSkin.Controls.MaterialLabel SelectedDateControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchDateControl;
        private DateTimePicker PickDateControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox ProductControl;
        private Label ProductErrorCaption;
        private MaterialSkin.Controls.MaterialLabel RemarksCaptionControl;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 RemarksControl;
    }
}