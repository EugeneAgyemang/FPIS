﻿namespace FPIS.Views
{
    partial class UserControlAddFinishedProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialTextBoxProductType = new MaterialSkin.Controls.MaterialTextBox();
            this.labelQuantityError = new System.Windows.Forms.Label();
            this.labelSealNumberError = new System.Windows.Forms.Label();
            this.labelContainerNumberError = new System.Windows.Forms.Label();
            this.labelBatchNumberError = new System.Windows.Forms.Label();
            this.labelCosigneeError = new System.Windows.Forms.Label();
            this.materialButtonAddFinishedProduct = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxSealNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxContainerNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxBatchNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxCosignee = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView_Finished_Products_With_Results = new System.Windows.Forms.DataGridView();
            this.SampleDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisRequestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisResultDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisResultTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxFinishedProduct = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialTextBoxProductType);
            this.groupBox1.Controls.Add(this.labelQuantityError);
            this.groupBox1.Controls.Add(this.labelSealNumberError);
            this.groupBox1.Controls.Add(this.labelContainerNumberError);
            this.groupBox1.Controls.Add(this.labelBatchNumberError);
            this.groupBox1.Controls.Add(this.labelCosigneeError);
            this.groupBox1.Controls.Add(this.materialButtonAddFinishedProduct);
            this.groupBox1.Controls.Add(this.materialTextBoxQuantity);
            this.groupBox1.Controls.Add(this.materialTextBoxSealNumber);
            this.groupBox1.Controls.Add(this.materialTextBoxContainerNumber);
            this.groupBox1.Controls.Add(this.materialTextBoxBatchNumber);
            this.groupBox1.Controls.Add(this.materialTextBoxCosignee);
            this.groupBox1.Location = new System.Drawing.Point(905, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(546, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Finished Product";
            // 
            // materialTextBoxProductType
            // 
            this.materialTextBoxProductType.AnimateReadOnly = false;
            this.materialTextBoxProductType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxProductType.Depth = 0;
            this.materialTextBoxProductType.Enabled = false;
            this.materialTextBoxProductType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxProductType.Hint = "Product Type";
            this.materialTextBoxProductType.LeadingIcon = null;
            this.materialTextBoxProductType.Location = new System.Drawing.Point(47, 38);
            this.materialTextBoxProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxProductType.MaxLength = 50;
            this.materialTextBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxProductType.Multiline = false;
            this.materialTextBoxProductType.Name = "materialTextBoxProductType";
            this.materialTextBoxProductType.Size = new System.Drawing.Size(203, 50);
            this.materialTextBoxProductType.TabIndex = 31;
            this.materialTextBoxProductType.Text = "";
            this.materialTextBoxProductType.TrailingIcon = null;
            // 
            // labelQuantityError
            // 
            this.labelQuantityError.AutoSize = true;
            this.labelQuantityError.Location = new System.Drawing.Point(301, 266);
            this.labelQuantityError.Name = "labelQuantityError";
            this.labelQuantityError.Size = new System.Drawing.Size(103, 15);
            this.labelQuantityError.TabIndex = 30;
            this.labelQuantityError.Text = "labelQuantityError";
            // 
            // labelSealNumberError
            // 
            this.labelSealNumberError.AutoSize = true;
            this.labelSealNumberError.Location = new System.Drawing.Point(301, 175);
            this.labelSealNumberError.Name = "labelSealNumberError";
            this.labelSealNumberError.Size = new System.Drawing.Size(122, 15);
            this.labelSealNumberError.TabIndex = 29;
            this.labelSealNumberError.Text = "labelSealNumberError";
            // 
            // labelContainerNumberError
            // 
            this.labelContainerNumberError.AutoSize = true;
            this.labelContainerNumberError.Location = new System.Drawing.Point(301, 90);
            this.labelContainerNumberError.Name = "labelContainerNumberError";
            this.labelContainerNumberError.Size = new System.Drawing.Size(153, 15);
            this.labelContainerNumberError.TabIndex = 28;
            this.labelContainerNumberError.Text = "labelContainerNumberError";
            // 
            // labelBatchNumberError
            // 
            this.labelBatchNumberError.AutoSize = true;
            this.labelBatchNumberError.Location = new System.Drawing.Point(47, 266);
            this.labelBatchNumberError.Name = "labelBatchNumberError";
            this.labelBatchNumberError.Size = new System.Drawing.Size(131, 15);
            this.labelBatchNumberError.TabIndex = 27;
            this.labelBatchNumberError.Text = "labelBatchNumberError";
            // 
            // labelCosigneeError
            // 
            this.labelCosigneeError.AutoSize = true;
            this.labelCosigneeError.Location = new System.Drawing.Point(47, 175);
            this.labelCosigneeError.Name = "labelCosigneeError";
            this.labelCosigneeError.Size = new System.Drawing.Size(106, 15);
            this.labelCosigneeError.TabIndex = 25;
            this.labelCosigneeError.Text = "labelCosigneeError";
            // 
            // materialButtonAddFinishedProduct
            // 
            this.materialButtonAddFinishedProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddFinishedProduct.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonAddFinishedProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonAddFinishedProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddFinishedProduct.Depth = 0;
            this.materialButtonAddFinishedProduct.HighEmphasis = true;
            this.materialButtonAddFinishedProduct.Icon = null;
            this.materialButtonAddFinishedProduct.Location = new System.Drawing.Point(193, 289);
            this.materialButtonAddFinishedProduct.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonAddFinishedProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddFinishedProduct.Name = "materialButtonAddFinishedProduct";
            this.materialButtonAddFinishedProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddFinishedProduct.Size = new System.Drawing.Size(189, 36);
            this.materialButtonAddFinishedProduct.TabIndex = 23;
            this.materialButtonAddFinishedProduct.Text = "Add Finished Product";
            this.materialButtonAddFinishedProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddFinishedProduct.UseAccentColor = true;
            this.materialButtonAddFinishedProduct.UseVisualStyleBackColor = true;
            this.materialButtonAddFinishedProduct.Click += new System.EventHandler(this.materialButtonAddFinishedProduct_Click);
            // 
            // materialTextBoxQuantity
            // 
            this.materialTextBoxQuantity.AnimateReadOnly = false;
            this.materialTextBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxQuantity.Depth = 0;
            this.materialTextBoxQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxQuantity.Hint = "Quantity";
            this.materialTextBoxQuantity.LeadingIcon = null;
            this.materialTextBoxQuantity.Location = new System.Drawing.Point(301, 214);
            this.materialTextBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxQuantity.MaxLength = 50;
            this.materialTextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxQuantity.Multiline = false;
            this.materialTextBoxQuantity.Name = "materialTextBoxQuantity";
            this.materialTextBoxQuantity.Size = new System.Drawing.Size(203, 50);
            this.materialTextBoxQuantity.TabIndex = 22;
            this.materialTextBoxQuantity.Text = "";
            this.materialTextBoxQuantity.TrailingIcon = null;
            // 
            // materialTextBoxSealNumber
            // 
            this.materialTextBoxSealNumber.AnimateReadOnly = false;
            this.materialTextBoxSealNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxSealNumber.Depth = 0;
            this.materialTextBoxSealNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxSealNumber.Hint = "Seal Number";
            this.materialTextBoxSealNumber.LeadingIcon = null;
            this.materialTextBoxSealNumber.Location = new System.Drawing.Point(301, 123);
            this.materialTextBoxSealNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxSealNumber.MaxLength = 50;
            this.materialTextBoxSealNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSealNumber.Multiline = false;
            this.materialTextBoxSealNumber.Name = "materialTextBoxSealNumber";
            this.materialTextBoxSealNumber.Size = new System.Drawing.Size(203, 50);
            this.materialTextBoxSealNumber.TabIndex = 21;
            this.materialTextBoxSealNumber.Text = "";
            this.materialTextBoxSealNumber.TrailingIcon = null;
            // 
            // materialTextBoxContainerNumber
            // 
            this.materialTextBoxContainerNumber.AnimateReadOnly = false;
            this.materialTextBoxContainerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxContainerNumber.Depth = 0;
            this.materialTextBoxContainerNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxContainerNumber.Hint = "Container Number";
            this.materialTextBoxContainerNumber.LeadingIcon = null;
            this.materialTextBoxContainerNumber.Location = new System.Drawing.Point(301, 38);
            this.materialTextBoxContainerNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxContainerNumber.MaxLength = 50;
            this.materialTextBoxContainerNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxContainerNumber.Multiline = false;
            this.materialTextBoxContainerNumber.Name = "materialTextBoxContainerNumber";
            this.materialTextBoxContainerNumber.Size = new System.Drawing.Size(203, 50);
            this.materialTextBoxContainerNumber.TabIndex = 20;
            this.materialTextBoxContainerNumber.Text = "";
            this.materialTextBoxContainerNumber.TrailingIcon = null;
            // 
            // materialTextBoxBatchNumber
            // 
            this.materialTextBoxBatchNumber.AnimateReadOnly = false;
            this.materialTextBoxBatchNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxBatchNumber.Depth = 0;
            this.materialTextBoxBatchNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxBatchNumber.Hint = "Batch Number";
            this.materialTextBoxBatchNumber.LeadingIcon = null;
            this.materialTextBoxBatchNumber.Location = new System.Drawing.Point(47, 214);
            this.materialTextBoxBatchNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxBatchNumber.MaxLength = 50;
            this.materialTextBoxBatchNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBatchNumber.Multiline = false;
            this.materialTextBoxBatchNumber.Name = "materialTextBoxBatchNumber";
            this.materialTextBoxBatchNumber.Size = new System.Drawing.Size(203, 50);
            this.materialTextBoxBatchNumber.TabIndex = 19;
            this.materialTextBoxBatchNumber.Text = "";
            this.materialTextBoxBatchNumber.TrailingIcon = null;
            // 
            // materialTextBoxCosignee
            // 
            this.materialTextBoxCosignee.AnimateReadOnly = false;
            this.materialTextBoxCosignee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxCosignee.Depth = 0;
            this.materialTextBoxCosignee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxCosignee.Hint = "Consignee";
            this.materialTextBoxCosignee.LeadingIcon = null;
            this.materialTextBoxCosignee.Location = new System.Drawing.Point(47, 123);
            this.materialTextBoxCosignee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxCosignee.MaxLength = 50;
            this.materialTextBoxCosignee.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxCosignee.Multiline = false;
            this.materialTextBoxCosignee.Name = "materialTextBoxCosignee";
            this.materialTextBoxCosignee.Size = new System.Drawing.Size(203, 50);
            this.materialTextBoxCosignee.TabIndex = 18;
            this.materialTextBoxCosignee.Text = "";
            this.materialTextBoxCosignee.TrailingIcon = null;
            // 
            // dataGridView_Finished_Products_With_Results
            // 
            this.dataGridView_Finished_Products_With_Results.AllowUserToAddRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeColumns = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeRows = false;
            this.dataGridView_Finished_Products_With_Results.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Finished_Products_With_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Finished_Products_With_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleDetailsID,
            this.ProductName,
            this.AnalysisRequestDate,
            this.AnalysisRequestTime,
            this.AnalysisResultDate,
            this.AnalysisResultTime});
            this.dataGridView_Finished_Products_With_Results.Location = new System.Drawing.Point(30, 184);
            this.dataGridView_Finished_Products_With_Results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Finished_Products_With_Results.MultiSelect = false;
            this.dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            this.dataGridView_Finished_Products_With_Results.ReadOnly = true;
            this.dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            this.dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            this.dataGridView_Finished_Products_With_Results.Size = new System.Drawing.Size(869, 326);
            this.dataGridView_Finished_Products_With_Results.TabIndex = 11;
            this.dataGridView_Finished_Products_With_Results.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Finished_Products_With_Results_CellClick);
            // 
            // SampleDetailsID
            // 
            this.SampleDetailsID.HeaderText = "Sample Details ID";
            this.SampleDetailsID.MinimumWidth = 6;
            this.SampleDetailsID.Name = "SampleDetailsID";
            this.SampleDetailsID.ReadOnly = true;
            this.SampleDetailsID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 164;
            // 
            // AnalysisRequestDate
            // 
            this.AnalysisRequestDate.HeaderText = "Analysis Request Date";
            this.AnalysisRequestDate.MinimumWidth = 6;
            this.AnalysisRequestDate.Name = "AnalysisRequestDate";
            this.AnalysisRequestDate.ReadOnly = true;
            this.AnalysisRequestDate.Width = 163;
            // 
            // AnalysisRequestTime
            // 
            this.AnalysisRequestTime.HeaderText = "Analysis Request Time";
            this.AnalysisRequestTime.MinimumWidth = 6;
            this.AnalysisRequestTime.Name = "AnalysisRequestTime";
            this.AnalysisRequestTime.ReadOnly = true;
            this.AnalysisRequestTime.Width = 164;
            // 
            // AnalysisResultDate
            // 
            this.AnalysisResultDate.HeaderText = "Analysis Result Date";
            this.AnalysisResultDate.MinimumWidth = 6;
            this.AnalysisResultDate.Name = "AnalysisResultDate";
            this.AnalysisResultDate.ReadOnly = true;
            this.AnalysisResultDate.Width = 163;
            // 
            // AnalysisResultTime
            // 
            this.AnalysisResultTime.HeaderText = "Analysis Result Time";
            this.AnalysisResultTime.MinimumWidth = 6;
            this.AnalysisResultTime.Name = "AnalysisResultTime";
            this.AnalysisResultTime.ReadOnly = true;
            this.AnalysisResultTime.Width = 162;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton1);
            this.groupBox2.Controls.Add(this.materialComboBoxFinishedProduct);
            this.groupBox2.Location = new System.Drawing.Point(25, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(592, 94);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finished Product";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(460, 34);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(105, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Show Data";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialComboBoxFinishedProduct
            // 
            this.materialComboBoxFinishedProduct.AutoResize = false;
            this.materialComboBoxFinishedProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxFinishedProduct.Depth = 0;
            this.materialComboBoxFinishedProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxFinishedProduct.DropDownHeight = 174;
            this.materialComboBoxFinishedProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxFinishedProduct.DropDownWidth = 121;
            this.materialComboBoxFinishedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxFinishedProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxFinishedProduct.FormattingEnabled = true;
            this.materialComboBoxFinishedProduct.Hint = "Select a Finished Product";
            this.materialComboBoxFinishedProduct.IntegralHeight = false;
            this.materialComboBoxFinishedProduct.ItemHeight = 43;
            this.materialComboBoxFinishedProduct.Items.AddRange(new object[] {
            "Crude Shea Olein",
            "Crude Shea Stearin"});
            this.materialComboBoxFinishedProduct.Location = new System.Drawing.Point(36, 28);
            this.materialComboBoxFinishedProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxFinishedProduct.MaxDropDownItems = 4;
            this.materialComboBoxFinishedProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxFinishedProduct.Name = "materialComboBoxFinishedProduct";
            this.materialComboBoxFinishedProduct.Size = new System.Drawing.Size(396, 49);
            this.materialComboBoxFinishedProduct.StartIndex = 0;
            this.materialComboBoxFinishedProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select a Finished Product to Add";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialButtonSearchAnalyticalResults);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePickerToDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox3.Location = new System.Drawing.Point(637, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(780, 94);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search by Analysis Result Date";
            // 
            // materialButtonSearchAnalyticalResults
            // 
            this.materialButtonSearchAnalyticalResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchAnalyticalResults.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchAnalyticalResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchAnalyticalResults.Depth = 0;
            this.materialButtonSearchAnalyticalResults.HighEmphasis = true;
            this.materialButtonSearchAnalyticalResults.Icon = null;
            this.materialButtonSearchAnalyticalResults.Location = new System.Drawing.Point(611, 27);
            this.materialButtonSearchAnalyticalResults.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonSearchAnalyticalResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchAnalyticalResults.Name = "materialButtonSearchAnalyticalResults";
            this.materialButtonSearchAnalyticalResults.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchAnalyticalResults.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchAnalyticalResults.TabIndex = 46;
            this.materialButtonSearchAnalyticalResults.Text = "Search";
            this.materialButtonSearchAnalyticalResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchAnalyticalResults.UseAccentColor = true;
            this.materialButtonSearchAnalyticalResults.UseVisualStyleBackColor = true;
            this.materialButtonSearchAnalyticalResults.Click += new System.EventHandler(this.materialButtonSearchAnalyticalResults_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(365, 35);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerToDate.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(88, 35);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerFromDate.TabIndex = 44;
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
            this.materialLabel1.Size = new System.Drawing.Size(191, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Add Finished Product";
            // 
            // UserControlAddFinishedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_Finished_Products_With_Results);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlAddFinishedProduct";
            this.Size = new System.Drawing.Size(1480, 554);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonAddFinishedProduct;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxQuantity;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSealNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxContainerNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxBatchNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCosignee;
        private Label labelQuantityError;
        private Label labelSealNumberError;
        private Label labelContainerNumberError;
        private Label labelBatchNumberError;
        private Label labelCosigneeError;
        private DataGridView dataGridView_Finished_Products_With_Results;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxFinishedProduct;
        private Label label2;
        private DataGridViewTextBoxColumn SampleDetailsID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn AnalysisRequestDate;
        private DataGridViewTextBoxColumn AnalysisRequestTime;
        private DataGridViewTextBoxColumn AnalysisResultDate;
        private DataGridViewTextBoxColumn AnalysisResultTime;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxProductType;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchAnalyticalResults;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
