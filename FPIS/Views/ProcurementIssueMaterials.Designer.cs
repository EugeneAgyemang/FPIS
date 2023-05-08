namespace FPIS.Views
{
    partial class ProcurementIssueMaterials
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.RequestForAnalysisControl = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAsStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialProcuredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialProcuredIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityLeftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.analysisStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisRawMaterialsSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.OpenAddMaterialsControl = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.SamplesRequestedControl = new MaterialSkin.Controls.MaterialComboBox();
            this.SampleRequestedDetailsControl = new MaterialSkin.Controls.MaterialLabel();
            this.IssueSectionControl = new System.Windows.Forms.Panel();
            this.WeightErrorControl = new System.Windows.Forms.Label();
            this.WeightRemarkControl = new MaterialSkin.Controls.MaterialLabel();
            this.RemarksCaptionControl = new System.Windows.Forms.Label();
            this.PreviousNetWeightControl = new MaterialSkin.Controls.MaterialTextBox();
            this.WeightControl = new MaterialSkin.Controls.MaterialTextBox();
            this.RemarksControl = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.QuantityErrorCaption = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoteControl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.IssueQuantityControl = new MaterialSkin.Controls.MaterialTextBox();
            this.IssueMaterialsControl = new MaterialSkin.Controls.MaterialButton();
            this.helper = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).BeginInit();
            this.IssueSectionControl.SuspendLayout();
            this.SuspendLayout();
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
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Issue Materials Procured";
            // 
            // RequestForAnalysisControl
            // 
            this.RequestForAnalysisControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RequestForAnalysisControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.RequestForAnalysisControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestForAnalysisControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RequestForAnalysisControl.Depth = 0;
            this.RequestForAnalysisControl.HighEmphasis = true;
            this.RequestForAnalysisControl.Icon = null;
            this.RequestForAnalysisControl.Location = new System.Drawing.Point(43, 339);
            this.RequestForAnalysisControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RequestForAnalysisControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RequestForAnalysisControl.Name = "RequestForAnalysisControl";
            this.RequestForAnalysisControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RequestForAnalysisControl.Size = new System.Drawing.Size(192, 36);
            this.RequestForAnalysisControl.TabIndex = 16;
            this.RequestForAnalysisControl.Text = " Request for Analysis ";
            this.RequestForAnalysisControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RequestForAnalysisControl.UseAccentColor = true;
            this.RequestForAnalysisControl.UseVisualStyleBackColor = true;
            this.RequestForAnalysisControl.Click += new System.EventHandler(this.RequestForAnalysisControl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAddedDataGridViewTextBoxColumn,
            this.idAsStrDataGridViewTextBoxColumn,
            this.MaterialProcuredId,
            this.idDataGridViewTextBoxColumn,
            this.materialProcuredIdDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.truckNumberDataGridViewTextBoxColumn,
            this.quantityReceivedDataGridViewTextBoxColumn,
            this.quantityLeftDataGridViewTextBoxColumn,
            this.NetWeight,
            this.remarksDataGridViewTextBoxColumn,
            this.selectedDataGridViewCheckBoxColumn,
            this.analysisStatusDataGridViewTextBoxColumn,
            this.Lot});
            this.dataGridView1.DataSource = this.analysisRawMaterialsSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(914, 246);
            this.dataGridView1.TabIndex = 17;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAddedDataGridViewTextBoxColumn.Width = 86;
            // 
            // idAsStrDataGridViewTextBoxColumn
            // 
            this.idAsStrDataGridViewTextBoxColumn.DataPropertyName = "IdAsStr";
            this.idAsStrDataGridViewTextBoxColumn.HeaderText = "Material Procurement ID";
            this.idAsStrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAsStrDataGridViewTextBoxColumn.Name = "idAsStrDataGridViewTextBoxColumn";
            this.idAsStrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsStrDataGridViewTextBoxColumn.Visible = false;
            // 
            // MaterialProcuredId
            // 
            this.MaterialProcuredId.DataPropertyName = "MaterialProcuredId";
            this.MaterialProcuredId.HeaderText = "Material Procured Id";
            this.MaterialProcuredId.MinimumWidth = 6;
            this.MaterialProcuredId.Name = "MaterialProcuredId";
            this.MaterialProcuredId.ReadOnly = true;
            this.MaterialProcuredId.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialProcuredIdDataGridViewTextBoxColumn
            // 
            this.materialProcuredIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialProcuredId";
            this.materialProcuredIdDataGridViewTextBoxColumn.HeaderText = "MaterialProcuredId";
            this.materialProcuredIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialProcuredIdDataGridViewTextBoxColumn.Name = "materialProcuredIdDataGridViewTextBoxColumn";
            this.materialProcuredIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialProcuredIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseDataGridViewTextBoxColumn.Width = 86;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierDataGridViewTextBoxColumn.Width = 86;
            // 
            // truckNumberDataGridViewTextBoxColumn
            // 
            this.truckNumberDataGridViewTextBoxColumn.DataPropertyName = "TruckNumber";
            this.truckNumberDataGridViewTextBoxColumn.HeaderText = "TruckNumber";
            this.truckNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.truckNumberDataGridViewTextBoxColumn.Name = "truckNumberDataGridViewTextBoxColumn";
            this.truckNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.truckNumberDataGridViewTextBoxColumn.Width = 86;
            // 
            // quantityReceivedDataGridViewTextBoxColumn
            // 
            this.quantityReceivedDataGridViewTextBoxColumn.DataPropertyName = "QuantityReceived";
            this.quantityReceivedDataGridViewTextBoxColumn.HeaderText = "QuantityReceived";
            this.quantityReceivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityReceivedDataGridViewTextBoxColumn.Name = "quantityReceivedDataGridViewTextBoxColumn";
            this.quantityReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityReceivedDataGridViewTextBoxColumn.Width = 86;
            // 
            // quantityLeftDataGridViewTextBoxColumn
            // 
            this.quantityLeftDataGridViewTextBoxColumn.DataPropertyName = "QuantityLeft";
            this.quantityLeftDataGridViewTextBoxColumn.HeaderText = "QuantityLeft";
            this.quantityLeftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityLeftDataGridViewTextBoxColumn.Name = "quantityLeftDataGridViewTextBoxColumn";
            this.quantityLeftDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityLeftDataGridViewTextBoxColumn.Width = 87;
            // 
            // NetWeight
            // 
            this.NetWeight.DataPropertyName = "NetWeight";
            this.NetWeight.HeaderText = "NetWeight";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 86;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.selectedDataGridViewCheckBoxColumn.Width = 86;
            // 
            // analysisStatusDataGridViewTextBoxColumn
            // 
            this.analysisStatusDataGridViewTextBoxColumn.DataPropertyName = "AnalysisStatus";
            this.analysisStatusDataGridViewTextBoxColumn.HeaderText = "AnalysisStatus";
            this.analysisStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.analysisStatusDataGridViewTextBoxColumn.Name = "analysisStatusDataGridViewTextBoxColumn";
            this.analysisStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.analysisStatusDataGridViewTextBoxColumn.Width = 86;
            // 
            // Lot
            // 
            this.Lot.DataPropertyName = "Lot";
            this.Lot.HeaderText = "Lot";
            this.Lot.MinimumWidth = 6;
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            this.Lot.Width = 86;
            // 
            // analysisRawMaterialsSampleBindingItemBindingSource
            // 
            this.analysisRawMaterialsSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisRawMaterialsSampleBindingItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Selected Samples";
            // 
            // OpenAddMaterialsControl
            // 
            this.OpenAddMaterialsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAddMaterialsControl.Depth = 0;
            this.OpenAddMaterialsControl.Icon = global::FPIS.Properties.Resources.add_white;
            this.OpenAddMaterialsControl.Location = new System.Drawing.Point(917, 336);
            this.OpenAddMaterialsControl.Mini = true;
            this.OpenAddMaterialsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenAddMaterialsControl.Name = "OpenAddMaterialsControl";
            this.OpenAddMaterialsControl.Size = new System.Drawing.Size(40, 40);
            this.OpenAddMaterialsControl.TabIndex = 21;
            this.OpenAddMaterialsControl.Text = "materialFloatingActionButton1";
            this.OpenAddMaterialsControl.UseVisualStyleBackColor = true;
            this.OpenAddMaterialsControl.Click += new System.EventHandler(this.OpenAddMaterialsControl_Click);
            // 
            // SamplesRequestedControl
            // 
            this.SamplesRequestedControl.AutoResize = false;
            this.SamplesRequestedControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesRequestedControl.Depth = 0;
            this.SamplesRequestedControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SamplesRequestedControl.DropDownHeight = 174;
            this.SamplesRequestedControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SamplesRequestedControl.DropDownWidth = 121;
            this.SamplesRequestedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SamplesRequestedControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesRequestedControl.FormattingEnabled = true;
            this.SamplesRequestedControl.Hint = "Choose a sample you requested";
            this.SamplesRequestedControl.IntegralHeight = false;
            this.SamplesRequestedControl.ItemHeight = 43;
            this.SamplesRequestedControl.Location = new System.Drawing.Point(43, 384);
            this.SamplesRequestedControl.MaxDropDownItems = 4;
            this.SamplesRequestedControl.MouseState = MaterialSkin.MouseState.OUT;
            this.SamplesRequestedControl.Name = "SamplesRequestedControl";
            this.SamplesRequestedControl.Size = new System.Drawing.Size(300, 49);
            this.SamplesRequestedControl.StartIndex = 0;
            this.SamplesRequestedControl.TabIndex = 22;
            this.SamplesRequestedControl.SelectedIndexChanged += new System.EventHandler(this.SamplesRequestedControl_SelectedIndexChanged);
            // 
            // SampleRequestedDetailsControl
            // 
            this.SampleRequestedDetailsControl.AutoSize = true;
            this.SampleRequestedDetailsControl.Depth = 0;
            this.SampleRequestedDetailsControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SampleRequestedDetailsControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SampleRequestedDetailsControl.HighEmphasis = true;
            this.SampleRequestedDetailsControl.Location = new System.Drawing.Point(43, 462);
            this.SampleRequestedDetailsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SampleRequestedDetailsControl.Name = "SampleRequestedDetailsControl";
            this.SampleRequestedDetailsControl.Size = new System.Drawing.Size(1, 0);
            this.SampleRequestedDetailsControl.TabIndex = 23;
            this.SampleRequestedDetailsControl.UseAccent = true;
            // 
            // IssueSectionControl
            // 
            this.IssueSectionControl.Controls.Add(this.WeightErrorControl);
            this.IssueSectionControl.Controls.Add(this.WeightRemarkControl);
            this.IssueSectionControl.Controls.Add(this.RemarksCaptionControl);
            this.IssueSectionControl.Controls.Add(this.PreviousNetWeightControl);
            this.IssueSectionControl.Controls.Add(this.WeightControl);
            this.IssueSectionControl.Controls.Add(this.RemarksControl);
            this.IssueSectionControl.Controls.Add(this.QuantityErrorCaption);
            this.IssueSectionControl.Controls.Add(this.panel1);
            this.IssueSectionControl.Controls.Add(this.NoteControl);
            this.IssueSectionControl.Controls.Add(this.materialLabel2);
            this.IssueSectionControl.Controls.Add(this.IssueQuantityControl);
            this.IssueSectionControl.Controls.Add(this.IssueMaterialsControl);
            this.IssueSectionControl.Location = new System.Drawing.Point(43, 439);
            this.IssueSectionControl.Name = "IssueSectionControl";
            this.IssueSectionControl.Size = new System.Drawing.Size(914, 281);
            this.IssueSectionControl.TabIndex = 27;
            this.IssueSectionControl.Visible = false;
            // 
            // WeightErrorControl
            // 
            this.WeightErrorControl.AutoSize = true;
            this.WeightErrorControl.ForeColor = System.Drawing.Color.Red;
            this.WeightErrorControl.Location = new System.Drawing.Point(425, 70);
            this.WeightErrorControl.Name = "WeightErrorControl";
            this.WeightErrorControl.Size = new System.Drawing.Size(0, 15);
            this.WeightErrorControl.TabIndex = 35;
            this.WeightErrorControl.Tag = "";
            // 
            // WeightRemarkControl
            // 
            this.WeightRemarkControl.Depth = 0;
            this.WeightRemarkControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WeightRemarkControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.WeightRemarkControl.Location = new System.Drawing.Point(425, 91);
            this.WeightRemarkControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.WeightRemarkControl.Name = "WeightRemarkControl";
            this.WeightRemarkControl.Size = new System.Drawing.Size(489, 23);
            this.WeightRemarkControl.TabIndex = 34;
            this.WeightRemarkControl.Text = "-----";
            this.WeightRemarkControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helper.SetToolTip(this.WeightRemarkControl, "Remark on the wieght");
            this.WeightRemarkControl.UseAccent = true;
            // 
            // RemarksCaptionControl
            // 
            this.RemarksCaptionControl.AutoSize = true;
            this.RemarksCaptionControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemarksCaptionControl.Location = new System.Drawing.Point(425, 129);
            this.RemarksCaptionControl.Name = "RemarksCaptionControl";
            this.RemarksCaptionControl.Size = new System.Drawing.Size(173, 17);
            this.RemarksCaptionControl.TabIndex = 28;
            this.RemarksCaptionControl.Text = "Remarks (500 characters)";
            // 
            // PreviousNetWeightControl
            // 
            this.PreviousNetWeightControl.AnimateReadOnly = false;
            this.PreviousNetWeightControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousNetWeightControl.Depth = 0;
            this.PreviousNetWeightControl.Enabled = false;
            this.PreviousNetWeightControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreviousNetWeightControl.LeadingIcon = null;
            this.PreviousNetWeightControl.Location = new System.Drawing.Point(631, 17);
            this.PreviousNetWeightControl.MaxLength = 50;
            this.PreviousNetWeightControl.MouseState = MaterialSkin.MouseState.OUT;
            this.PreviousNetWeightControl.Multiline = false;
            this.PreviousNetWeightControl.Name = "PreviousNetWeightControl";
            this.PreviousNetWeightControl.Size = new System.Drawing.Size(280, 50);
            this.PreviousNetWeightControl.TabIndex = 33;
            this.PreviousNetWeightControl.Text = "";
            this.PreviousNetWeightControl.TrailingIcon = null;
            // 
            // WeightControl
            // 
            this.WeightControl.AnimateReadOnly = false;
            this.WeightControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightControl.Depth = 0;
            this.WeightControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WeightControl.Hint = "Weight (kg)";
            this.WeightControl.LeadingIcon = null;
            this.WeightControl.Location = new System.Drawing.Point(425, 17);
            this.WeightControl.MaxLength = 50;
            this.WeightControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WeightControl.Multiline = false;
            this.WeightControl.Name = "WeightControl";
            this.WeightControl.Size = new System.Drawing.Size(200, 50);
            this.WeightControl.TabIndex = 32;
            this.WeightControl.Text = "";
            this.WeightControl.TrailingIcon = null;
            this.WeightControl.TextChanged += new System.EventHandler(this.WeightControl_TextChanged);
            this.WeightControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IssueQuantityControl_KeyPress);
            // 
            // RemarksControl
            // 
            this.RemarksControl.AnimateReadOnly = false;
            this.RemarksControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemarksControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RemarksControl.Depth = 0;
            this.RemarksControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemarksControl.HideSelection = true;
            this.RemarksControl.Location = new System.Drawing.Point(425, 152);
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
            this.RemarksControl.TabIndex = 30;
            this.RemarksControl.TabStop = false;
            this.RemarksControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemarksControl.UseSystemPasswordChar = false;
            this.RemarksControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemarksControl_KeyUp);
            // 
            // QuantityErrorCaption
            // 
            this.QuantityErrorCaption.AutoSize = true;
            this.QuantityErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.QuantityErrorCaption.Location = new System.Drawing.Point(17, 70);
            this.QuantityErrorCaption.Name = "QuantityErrorCaption";
            this.QuantityErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.QuantityErrorCaption.TabIndex = 28;
            this.QuantityErrorCaption.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(17, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 2);
            this.panel1.TabIndex = 28;
            // 
            // NoteControl
            // 
            this.NoteControl.Depth = 0;
            this.NoteControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.NoteControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.NoteControl.Location = new System.Drawing.Point(17, 165);
            this.NoteControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.NoteControl.Name = "NoteControl";
            this.NoteControl.Size = new System.Drawing.Size(402, 109);
            this.NoteControl.TabIndex = 29;
            this.NoteControl.UseAccent = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(17, 138);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(36, 17);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Note:";
            this.materialLabel2.UseAccent = true;
            // 
            // IssueQuantityControl
            // 
            this.IssueQuantityControl.AnimateReadOnly = false;
            this.IssueQuantityControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IssueQuantityControl.Depth = 0;
            this.IssueQuantityControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.IssueQuantityControl.Hint = "Quantity to issue";
            this.IssueQuantityControl.LeadingIcon = null;
            this.IssueQuantityControl.Location = new System.Drawing.Point(17, 17);
            this.IssueQuantityControl.MaxLength = 50;
            this.IssueQuantityControl.MouseState = MaterialSkin.MouseState.OUT;
            this.IssueQuantityControl.Multiline = false;
            this.IssueQuantityControl.Name = "IssueQuantityControl";
            this.IssueQuantityControl.Size = new System.Drawing.Size(358, 50);
            this.IssueQuantityControl.TabIndex = 26;
            this.IssueQuantityControl.Text = "";
            this.IssueQuantityControl.TrailingIcon = null;
            this.IssueQuantityControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IssueQuantityControl_KeyPress);
            // 
            // IssueMaterialsControl
            // 
            this.IssueMaterialsControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IssueMaterialsControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.IssueMaterialsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IssueMaterialsControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.IssueMaterialsControl.Depth = 0;
            this.IssueMaterialsControl.HighEmphasis = true;
            this.IssueMaterialsControl.Icon = null;
            this.IssueMaterialsControl.Location = new System.Drawing.Point(17, 91);
            this.IssueMaterialsControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IssueMaterialsControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.IssueMaterialsControl.Name = "IssueMaterialsControl";
            this.IssueMaterialsControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.IssueMaterialsControl.Size = new System.Drawing.Size(65, 36);
            this.IssueMaterialsControl.TabIndex = 27;
            this.IssueMaterialsControl.Text = " Issue";
            this.IssueMaterialsControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.IssueMaterialsControl.UseAccentColor = true;
            this.IssueMaterialsControl.UseVisualStyleBackColor = true;
            this.IssueMaterialsControl.Click += new System.EventHandler(this.IssueMaterialsControl_Click);
            // 
            // ProcurementIssueMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IssueSectionControl);
            this.Controls.Add(this.SampleRequestedDetailsControl);
            this.Controls.Add(this.SamplesRequestedControl);
            this.Controls.Add(this.OpenAddMaterialsControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RequestForAnalysisControl);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ProcurementIssueMaterials";
            this.Size = new System.Drawing.Size(1000, 794);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisRawMaterialsSampleBindingItemBindingSource)).EndInit();
            this.IssueSectionControl.ResumeLayout(false);
            this.IssueSectionControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton RequestForAnalysisControl;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFloatingActionButton OpenAddMaterialsControl;
        private BindingSource analysisRawMaterialsSampleBindingItemBindingSource;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxEmployee1;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox SamplesRequestedControl;
        private MaterialSkin.Controls.MaterialLabel SampleRequestedDetailsControl;
        private Panel IssueSectionControl;
        private MaterialSkin.Controls.MaterialTextBox IssueQuantityControl;
        private MaterialSkin.Controls.MaterialButton IssueMaterialsControl;
        private MaterialSkin.Controls.MaterialLabel NoteControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Panel panel1;
        private Label QuantityErrorCaption;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 RemarksControl;
        private DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAsStrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MaterialProcuredId;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialProcuredIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn truckNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityReceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityLeftDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NetWeight;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn analysisStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Lot;
        private MaterialSkin.Controls.MaterialTextBox PreviousNetWeightControl;
        private MaterialSkin.Controls.MaterialTextBox WeightControl;
        private ToolTip helper;
        private MaterialSkin.Controls.MaterialLabel WeightRemarkControl;
        private Label RemarksCaptionControl;
        private Label WeightErrorControl;
    }
}
