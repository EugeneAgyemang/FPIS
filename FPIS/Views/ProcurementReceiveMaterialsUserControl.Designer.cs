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
            this.MaterialProcurementFirstSection = new System.Windows.Forms.Panel();
            this.IncomingDetailsControl = new MaterialSkin.Controls.MaterialLabel();
            this.ViewPendingMaterials = new MaterialSkin.Controls.MaterialComboBox();
            this.SyncControl = new System.Windows.Forms.PictureBox();
            this.ReceivingSectionControl = new System.Windows.Forms.Panel();
            this.UnitsControl = new MaterialSkin.Controls.MaterialTextBox();
            this.UnitsErrorCaption = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.NetWeightErrorControl = new System.Windows.Forms.Label();
            this.GrossWeightErrorControl = new System.Windows.Forms.Label();
            this.GrossWeightControl = new MaterialSkin.Controls.MaterialTextBox();
            this.NetWeightControl = new MaterialSkin.Controls.MaterialTextBox();
            this.MaterialProcurementDividerControl = new System.Windows.Forms.Panel();
            this.SaveProcurementRecords = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaterialProcurementLastSection = new System.Windows.Forms.Panel();
            this.MaterialProcurementFirstSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncControl)).BeginInit();
            this.ReceivingSectionControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MaterialProcurementLastSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaterialProcurementFirstSection
            // 
            this.MaterialProcurementFirstSection.Controls.Add(this.IncomingDetailsControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.ViewPendingMaterials);
            this.MaterialProcurementFirstSection.Controls.Add(this.SyncControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.ReceivingSectionControl);
            this.MaterialProcurementFirstSection.Controls.Add(this.materialLabel1);
            this.MaterialProcurementFirstSection.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaterialProcurementFirstSection.Location = new System.Drawing.Point(0, 0);
            this.MaterialProcurementFirstSection.Name = "MaterialProcurementFirstSection";
            this.MaterialProcurementFirstSection.Size = new System.Drawing.Size(500, 320);
            this.MaterialProcurementFirstSection.TabIndex = 1;
            // 
            // IncomingDetailsControl
            // 
            this.IncomingDetailsControl.AutoSize = true;
            this.IncomingDetailsControl.Depth = 0;
            this.IncomingDetailsControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.IncomingDetailsControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.IncomingDetailsControl.ForeColor = System.Drawing.Color.Black;
            this.IncomingDetailsControl.Location = new System.Drawing.Point(25, 51);
            this.IncomingDetailsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.IncomingDetailsControl.Name = "IncomingDetailsControl";
            this.IncomingDetailsControl.Size = new System.Drawing.Size(1, 0);
            this.IncomingDetailsControl.TabIndex = 28;
            this.IncomingDetailsControl.UseAccent = true;
            // 
            // ViewPendingMaterials
            // 
            this.ViewPendingMaterials.AutoResize = false;
            this.ViewPendingMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ViewPendingMaterials.Depth = 0;
            this.ViewPendingMaterials.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ViewPendingMaterials.DropDownHeight = 174;
            this.ViewPendingMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewPendingMaterials.DropDownWidth = 121;
            this.ViewPendingMaterials.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ViewPendingMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewPendingMaterials.FormattingEnabled = true;
            this.ViewPendingMaterials.IntegralHeight = false;
            this.ViewPendingMaterials.ItemHeight = 43;
            this.ViewPendingMaterials.Location = new System.Drawing.Point(25, 82);
            this.ViewPendingMaterials.MaxDropDownItems = 4;
            this.ViewPendingMaterials.MouseState = MaterialSkin.MouseState.OUT;
            this.ViewPendingMaterials.Name = "ViewPendingMaterials";
            this.ViewPendingMaterials.Size = new System.Drawing.Size(400, 49);
            this.ViewPendingMaterials.StartIndex = -1;
            this.ViewPendingMaterials.TabIndex = 27;
            this.ViewPendingMaterials.SelectedIndexChanged += new System.EventHandler(this.ViewPendingMaterials_SelectedIndexChanged);
            // 
            // SyncControl
            // 
            this.SyncControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SyncControl.Image = global::FPIS.Properties.Resources.sync_dark;
            this.SyncControl.Location = new System.Drawing.Point(431, 96);
            this.SyncControl.Name = "SyncControl";
            this.SyncControl.Size = new System.Drawing.Size(25, 25);
            this.SyncControl.TabIndex = 26;
            this.SyncControl.TabStop = false;
            this.SyncControl.Click += new System.EventHandler(this.SyncControl_Click);
            // 
            // ReceivingSectionControl
            // 
            this.ReceivingSectionControl.Controls.Add(this.UnitsControl);
            this.ReceivingSectionControl.Controls.Add(this.UnitsErrorCaption);
            this.ReceivingSectionControl.Enabled = false;
            this.ReceivingSectionControl.Location = new System.Drawing.Point(25, 150);
            this.ReceivingSectionControl.Name = "ReceivingSectionControl";
            this.ReceivingSectionControl.Size = new System.Drawing.Size(451, 126);
            this.ReceivingSectionControl.TabIndex = 0;
            // 
            // UnitsControl
            // 
            this.UnitsControl.AnimateReadOnly = false;
            this.UnitsControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitsControl.Depth = 0;
            this.UnitsControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UnitsControl.Hint = "Unit";
            this.UnitsControl.LeadingIcon = null;
            this.UnitsControl.Location = new System.Drawing.Point(0, 28);
            this.UnitsControl.MaxLength = 50;
            this.UnitsControl.MouseState = MaterialSkin.MouseState.OUT;
            this.UnitsControl.Multiline = false;
            this.UnitsControl.Name = "UnitsControl";
            this.UnitsControl.Size = new System.Drawing.Size(400, 50);
            this.UnitsControl.TabIndex = 3;
            this.UnitsControl.Text = "";
            this.UnitsControl.TrailingIcon = null;
            // 
            // UnitsErrorCaption
            // 
            this.UnitsErrorCaption.AutoSize = true;
            this.UnitsErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.UnitsErrorCaption.Location = new System.Drawing.Point(3, 81);
            this.UnitsErrorCaption.Name = "UnitsErrorCaption";
            this.UnitsErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.UnitsErrorCaption.TabIndex = 16;
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
            // NetWeightErrorControl
            // 
            this.NetWeightErrorControl.AutoSize = true;
            this.NetWeightErrorControl.ForeColor = System.Drawing.Color.Red;
            this.NetWeightErrorControl.Location = new System.Drawing.Point(54, 196);
            this.NetWeightErrorControl.Name = "NetWeightErrorControl";
            this.NetWeightErrorControl.Size = new System.Drawing.Size(0, 15);
            this.NetWeightErrorControl.TabIndex = 23;
            // 
            // GrossWeightErrorControl
            // 
            this.GrossWeightErrorControl.AutoSize = true;
            this.GrossWeightErrorControl.ForeColor = System.Drawing.Color.Red;
            this.GrossWeightErrorControl.Location = new System.Drawing.Point(54, 102);
            this.GrossWeightErrorControl.Name = "GrossWeightErrorControl";
            this.GrossWeightErrorControl.Size = new System.Drawing.Size(0, 15);
            this.GrossWeightErrorControl.TabIndex = 22;
            // 
            // GrossWeightControl
            // 
            this.GrossWeightControl.AnimateReadOnly = false;
            this.GrossWeightControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrossWeightControl.Depth = 0;
            this.GrossWeightControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrossWeightControl.Hint = "Gross Weight (kg)";
            this.GrossWeightControl.LeadingIcon = null;
            this.GrossWeightControl.Location = new System.Drawing.Point(51, 82);
            this.GrossWeightControl.MaxLength = 50;
            this.GrossWeightControl.MouseState = MaterialSkin.MouseState.OUT;
            this.GrossWeightControl.Multiline = false;
            this.GrossWeightControl.Name = "GrossWeightControl";
            this.GrossWeightControl.Size = new System.Drawing.Size(400, 50);
            this.GrossWeightControl.TabIndex = 20;
            this.GrossWeightControl.Text = "";
            this.GrossWeightControl.TrailingIcon = null;
            this.GrossWeightControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
            // 
            // NetWeightControl
            // 
            this.NetWeightControl.AnimateReadOnly = false;
            this.NetWeightControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetWeightControl.Depth = 0;
            this.NetWeightControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NetWeightControl.Hint = "Net Weight (kg)";
            this.NetWeightControl.LeadingIcon = null;
            this.NetWeightControl.Location = new System.Drawing.Point(51, 172);
            this.NetWeightControl.MaxLength = 50;
            this.NetWeightControl.MouseState = MaterialSkin.MouseState.OUT;
            this.NetWeightControl.Multiline = false;
            this.NetWeightControl.Name = "NetWeightControl";
            this.NetWeightControl.Size = new System.Drawing.Size(400, 50);
            this.NetWeightControl.TabIndex = 21;
            this.NetWeightControl.Text = "";
            this.NetWeightControl.TrailingIcon = null;
            this.NetWeightControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityControl_KeyPress);
            // 
            // MaterialProcurementDividerControl
            // 
            this.MaterialProcurementDividerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaterialProcurementDividerControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaterialProcurementDividerControl.Location = new System.Drawing.Point(500, 0);
            this.MaterialProcurementDividerControl.Name = "MaterialProcurementDividerControl";
            this.MaterialProcurementDividerControl.Size = new System.Drawing.Size(2, 320);
            this.MaterialProcurementDividerControl.TabIndex = 11;
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
            this.SaveProcurementRecords.Location = new System.Drawing.Point(395, 7);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveProcurementRecords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(502, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 51);
            this.panel1.TabIndex = 0;
            // 
            // MaterialProcurementLastSection
            // 
            this.MaterialProcurementLastSection.Controls.Add(this.NetWeightErrorControl);
            this.MaterialProcurementLastSection.Controls.Add(this.GrossWeightErrorControl);
            this.MaterialProcurementLastSection.Controls.Add(this.GrossWeightControl);
            this.MaterialProcurementLastSection.Controls.Add(this.NetWeightControl);
            this.MaterialProcurementLastSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialProcurementLastSection.Enabled = false;
            this.MaterialProcurementLastSection.Location = new System.Drawing.Point(502, 0);
            this.MaterialProcurementLastSection.Name = "MaterialProcurementLastSection";
            this.MaterialProcurementLastSection.Size = new System.Drawing.Size(498, 269);
            this.MaterialProcurementLastSection.TabIndex = 12;
            // 
            // ProcurementReceiveMaterialsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaterialProcurementLastSection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MaterialProcurementDividerControl);
            this.Controls.Add(this.MaterialProcurementFirstSection);
            this.Name = "ProcurementReceiveMaterialsUserControl";
            this.Size = new System.Drawing.Size(1000, 320);
            this.MaterialProcurementFirstSection.ResumeLayout(false);
            this.MaterialProcurementFirstSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncControl)).EndInit();
            this.ReceivingSectionControl.ResumeLayout(false);
            this.ReceivingSectionControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MaterialProcurementLastSection.ResumeLayout(false);
            this.MaterialProcurementLastSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox SuplierControl;
        private Panel MaterialProcurementFirstSection;
        private Panel MaterialProcurementDividerControl;
        private MaterialSkin.Controls.MaterialButton SaveProcurementRecords;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label UnitsErrorCaption;
        private MaterialSkin.Controls.MaterialTextBox UnitsControl;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private Panel ReceivingSetionControl;
        private Panel ReceivingSectionControl;
        private PictureBox SyncControl;
        private Panel LocationSection;
        private MaterialSkin.Controls.MaterialTextBox NetWeightControl;
        private MaterialSkin.Controls.MaterialTextBox GrossWeightControl;
        private Label NetWeightErrorControl;
        private Label GrossWeightErrorControl;
        private Panel panel1;
        private Panel MaterialProcurementLastSection;
        private MaterialSkin.Controls.MaterialComboBox ViewPendingMaterials;
        private MaterialSkin.Controls.MaterialLabel IncomingDetailsControl;
    }
}
