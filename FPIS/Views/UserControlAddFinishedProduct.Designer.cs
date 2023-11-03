namespace FPIS.Views
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
            groupBox1 = new GroupBox();
            materialTextBoxProductType = new MaterialSkin.Controls.MaterialTextBox();
            labelQuantityError = new Label();
            labelSealNumberError = new Label();
            labelContainerNumberError = new Label();
            labelBatchNumberError = new Label();
            labelCosigneeError = new Label();
            materialButtonAddFinishedProduct = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxSealNumber = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxContainerNumber = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxBatchNumber = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxCosignee = new MaterialSkin.Controls.MaterialTextBox();
            dataGridView_Finished_Products_With_Results = new DataGridView();
            SampleDetailsID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductType = new DataGridViewTextBoxColumn();
            Label = new DataGridViewTextBoxColumn();
            AnalysisRequestDate = new DataGridViewTextBoxColumn();
            AnalysisRequestTime = new DataGridViewTextBoxColumn();
            AnalysisResultDate = new DataGridViewTextBoxColumn();
            AnalysisResultTime = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialComboBoxFinishedProduct = new MaterialSkin.Controls.MaterialComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            dateTimePickerToDate = new DateTimePicker();
            label4 = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Finished_Products_With_Results).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialTextBoxProductType);
            groupBox1.Controls.Add(labelQuantityError);
            groupBox1.Controls.Add(labelSealNumberError);
            groupBox1.Controls.Add(labelContainerNumberError);
            groupBox1.Controls.Add(labelBatchNumberError);
            groupBox1.Controls.Add(labelCosigneeError);
            groupBox1.Controls.Add(materialButtonAddFinishedProduct);
            groupBox1.Controls.Add(materialTextBoxQuantity);
            groupBox1.Controls.Add(materialTextBoxSealNumber);
            groupBox1.Controls.Add(materialTextBoxContainerNumber);
            groupBox1.Controls.Add(materialTextBoxBatchNumber);
            groupBox1.Controls.Add(materialTextBoxCosignee);
            groupBox1.Location = new Point(1034, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 441);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add a Finished Product";
            // 
            // materialTextBoxProductType
            // 
            materialTextBoxProductType.AnimateReadOnly = false;
            materialTextBoxProductType.BorderStyle = BorderStyle.None;
            materialTextBoxProductType.Depth = 0;
            materialTextBoxProductType.Enabled = false;
            materialTextBoxProductType.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxProductType.Hint = "Product Type";
            materialTextBoxProductType.LeadingIcon = null;
            materialTextBoxProductType.Location = new Point(54, 51);
            materialTextBoxProductType.MaxLength = 50;
            materialTextBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxProductType.Multiline = false;
            materialTextBoxProductType.Name = "materialTextBoxProductType";
            materialTextBoxProductType.Size = new Size(232, 50);
            materialTextBoxProductType.TabIndex = 31;
            materialTextBoxProductType.Text = "";
            materialTextBoxProductType.TrailingIcon = null;
            // 
            // labelQuantityError
            // 
            labelQuantityError.AutoSize = true;
            labelQuantityError.Location = new Point(344, 355);
            labelQuantityError.Name = "labelQuantityError";
            labelQuantityError.Size = new Size(130, 20);
            labelQuantityError.TabIndex = 30;
            labelQuantityError.Text = "labelQuantityError";
            // 
            // labelSealNumberError
            // 
            labelSealNumberError.AutoSize = true;
            labelSealNumberError.Location = new Point(344, 233);
            labelSealNumberError.Name = "labelSealNumberError";
            labelSealNumberError.Size = new Size(156, 20);
            labelSealNumberError.TabIndex = 29;
            labelSealNumberError.Text = "labelSealNumberError";
            // 
            // labelContainerNumberError
            // 
            labelContainerNumberError.AutoSize = true;
            labelContainerNumberError.Location = new Point(344, 120);
            labelContainerNumberError.Name = "labelContainerNumberError";
            labelContainerNumberError.Size = new Size(192, 20);
            labelContainerNumberError.TabIndex = 28;
            labelContainerNumberError.Text = "labelContainerNumberError";
            // 
            // labelBatchNumberError
            // 
            labelBatchNumberError.AutoSize = true;
            labelBatchNumberError.Location = new Point(54, 355);
            labelBatchNumberError.Name = "labelBatchNumberError";
            labelBatchNumberError.Size = new Size(165, 20);
            labelBatchNumberError.TabIndex = 27;
            labelBatchNumberError.Text = "labelBatchNumberError";
            // 
            // labelCosigneeError
            // 
            labelCosigneeError.AutoSize = true;
            labelCosigneeError.Location = new Point(54, 233);
            labelCosigneeError.Name = "labelCosigneeError";
            labelCosigneeError.Size = new Size(135, 20);
            labelCosigneeError.TabIndex = 25;
            labelCosigneeError.Text = "labelCosigneeError";
            // 
            // materialButtonAddFinishedProduct
            // 
            materialButtonAddFinishedProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonAddFinishedProduct.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonAddFinishedProduct.Cursor = Cursors.Hand;
            materialButtonAddFinishedProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddFinishedProduct.Depth = 0;
            materialButtonAddFinishedProduct.HighEmphasis = true;
            materialButtonAddFinishedProduct.Icon = null;
            materialButtonAddFinishedProduct.Location = new Point(221, 385);
            materialButtonAddFinishedProduct.Margin = new Padding(5);
            materialButtonAddFinishedProduct.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddFinishedProduct.Name = "materialButtonAddFinishedProduct";
            materialButtonAddFinishedProduct.NoAccentTextColor = Color.Empty;
            materialButtonAddFinishedProduct.Size = new Size(189, 36);
            materialButtonAddFinishedProduct.TabIndex = 23;
            materialButtonAddFinishedProduct.Text = "Add Finished Product";
            materialButtonAddFinishedProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAddFinishedProduct.UseAccentColor = true;
            materialButtonAddFinishedProduct.UseVisualStyleBackColor = true;
            materialButtonAddFinishedProduct.Click += materialButtonAddFinishedProduct_Click;
            // 
            // materialTextBoxQuantity
            // 
            materialTextBoxQuantity.AnimateReadOnly = false;
            materialTextBoxQuantity.BorderStyle = BorderStyle.None;
            materialTextBoxQuantity.Depth = 0;
            materialTextBoxQuantity.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxQuantity.Hint = "Quantity";
            materialTextBoxQuantity.LeadingIcon = null;
            materialTextBoxQuantity.Location = new Point(344, 285);
            materialTextBoxQuantity.MaxLength = 50;
            materialTextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxQuantity.Multiline = false;
            materialTextBoxQuantity.Name = "materialTextBoxQuantity";
            materialTextBoxQuantity.Size = new Size(232, 50);
            materialTextBoxQuantity.TabIndex = 22;
            materialTextBoxQuantity.Text = "";
            materialTextBoxQuantity.TrailingIcon = null;
            // 
            // materialTextBoxSealNumber
            // 
            materialTextBoxSealNumber.AnimateReadOnly = false;
            materialTextBoxSealNumber.BorderStyle = BorderStyle.None;
            materialTextBoxSealNumber.Depth = 0;
            materialTextBoxSealNumber.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxSealNumber.Hint = "Seal Number";
            materialTextBoxSealNumber.LeadingIcon = null;
            materialTextBoxSealNumber.Location = new Point(344, 164);
            materialTextBoxSealNumber.MaxLength = 50;
            materialTextBoxSealNumber.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxSealNumber.Multiline = false;
            materialTextBoxSealNumber.Name = "materialTextBoxSealNumber";
            materialTextBoxSealNumber.Size = new Size(232, 50);
            materialTextBoxSealNumber.TabIndex = 21;
            materialTextBoxSealNumber.Text = "";
            materialTextBoxSealNumber.TrailingIcon = null;
            // 
            // materialTextBoxContainerNumber
            // 
            materialTextBoxContainerNumber.AnimateReadOnly = false;
            materialTextBoxContainerNumber.BorderStyle = BorderStyle.None;
            materialTextBoxContainerNumber.Depth = 0;
            materialTextBoxContainerNumber.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxContainerNumber.Hint = "Container Number";
            materialTextBoxContainerNumber.LeadingIcon = null;
            materialTextBoxContainerNumber.Location = new Point(344, 51);
            materialTextBoxContainerNumber.MaxLength = 50;
            materialTextBoxContainerNumber.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxContainerNumber.Multiline = false;
            materialTextBoxContainerNumber.Name = "materialTextBoxContainerNumber";
            materialTextBoxContainerNumber.Size = new Size(232, 50);
            materialTextBoxContainerNumber.TabIndex = 20;
            materialTextBoxContainerNumber.Text = "";
            materialTextBoxContainerNumber.TrailingIcon = null;
            // 
            // materialTextBoxBatchNumber
            // 
            materialTextBoxBatchNumber.AnimateReadOnly = false;
            materialTextBoxBatchNumber.BorderStyle = BorderStyle.None;
            materialTextBoxBatchNumber.Depth = 0;
            materialTextBoxBatchNumber.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxBatchNumber.Hint = "Batch Number";
            materialTextBoxBatchNumber.LeadingIcon = null;
            materialTextBoxBatchNumber.Location = new Point(54, 285);
            materialTextBoxBatchNumber.MaxLength = 50;
            materialTextBoxBatchNumber.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxBatchNumber.Multiline = false;
            materialTextBoxBatchNumber.Name = "materialTextBoxBatchNumber";
            materialTextBoxBatchNumber.Size = new Size(232, 50);
            materialTextBoxBatchNumber.TabIndex = 19;
            materialTextBoxBatchNumber.Text = "";
            materialTextBoxBatchNumber.TrailingIcon = null;
            // 
            // materialTextBoxCosignee
            // 
            materialTextBoxCosignee.AnimateReadOnly = false;
            materialTextBoxCosignee.BorderStyle = BorderStyle.None;
            materialTextBoxCosignee.Depth = 0;
            materialTextBoxCosignee.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxCosignee.Hint = "Consignee";
            materialTextBoxCosignee.LeadingIcon = null;
            materialTextBoxCosignee.Location = new Point(54, 164);
            materialTextBoxCosignee.MaxLength = 50;
            materialTextBoxCosignee.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxCosignee.Multiline = false;
            materialTextBoxCosignee.Name = "materialTextBoxCosignee";
            materialTextBoxCosignee.Size = new Size(232, 50);
            materialTextBoxCosignee.TabIndex = 18;
            materialTextBoxCosignee.Text = "";
            materialTextBoxCosignee.TrailingIcon = null;
            // 
            // dataGridView_Finished_Products_With_Results
            // 
            dataGridView_Finished_Products_With_Results.AllowUserToAddRows = false;
            dataGridView_Finished_Products_With_Results.AllowUserToDeleteRows = false;
            dataGridView_Finished_Products_With_Results.AllowUserToResizeColumns = false;
            dataGridView_Finished_Products_With_Results.AllowUserToResizeRows = false;
            dataGridView_Finished_Products_With_Results.BackgroundColor = SystemColors.Window;
            dataGridView_Finished_Products_With_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Finished_Products_With_Results.Columns.AddRange(new DataGridViewColumn[] { SampleDetailsID, ProductName, ProductType, Label, AnalysisRequestDate, AnalysisRequestTime, AnalysisResultDate, AnalysisResultTime });
            dataGridView_Finished_Products_With_Results.Location = new Point(34, 245);
            dataGridView_Finished_Products_With_Results.MultiSelect = false;
            dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            dataGridView_Finished_Products_With_Results.ReadOnly = true;
            dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            dataGridView_Finished_Products_With_Results.Size = new Size(993, 435);
            dataGridView_Finished_Products_With_Results.TabIndex = 11;
            dataGridView_Finished_Products_With_Results.CellClick += dataGridView_Finished_Products_With_Results_CellClick;
            // 
            // SampleDetailsID
            // 
            SampleDetailsID.HeaderText = "Sample Details ID";
            SampleDetailsID.MinimumWidth = 6;
            SampleDetailsID.Name = "SampleDetailsID";
            SampleDetailsID.ReadOnly = true;
            SampleDetailsID.Visible = false;
            SampleDetailsID.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 200;
            // 
            // ProductType
            // 
            ProductType.HeaderText = "Product Type";
            ProductType.MinimumWidth = 6;
            ProductType.Name = "ProductType";
            ProductType.ReadOnly = true;
            ProductType.Visible = false;
            ProductType.Width = 125;
            // 
            // Label
            // 
            Label.HeaderText = "Label";
            Label.MinimumWidth = 6;
            Label.Name = "Label";
            Label.ReadOnly = true;
            Label.Visible = false;
            Label.Width = 125;
            // 
            // AnalysisRequestDate
            // 
            AnalysisRequestDate.HeaderText = "Analysis Request Date";
            AnalysisRequestDate.MinimumWidth = 6;
            AnalysisRequestDate.Name = "AnalysisRequestDate";
            AnalysisRequestDate.ReadOnly = true;
            AnalysisRequestDate.Width = 163;
            // 
            // AnalysisRequestTime
            // 
            AnalysisRequestTime.HeaderText = "Analysis Request Time";
            AnalysisRequestTime.MinimumWidth = 6;
            AnalysisRequestTime.Name = "AnalysisRequestTime";
            AnalysisRequestTime.ReadOnly = true;
            AnalysisRequestTime.Width = 164;
            // 
            // AnalysisResultDate
            // 
            AnalysisResultDate.HeaderText = "Analysis Result Date";
            AnalysisResultDate.MinimumWidth = 6;
            AnalysisResultDate.Name = "AnalysisResultDate";
            AnalysisResultDate.ReadOnly = true;
            AnalysisResultDate.Width = 163;
            // 
            // AnalysisResultTime
            // 
            AnalysisResultTime.HeaderText = "Analysis Result Time";
            AnalysisResultTime.MinimumWidth = 6;
            AnalysisResultTime.Name = "AnalysisResultTime";
            AnalysisResultTime.ReadOnly = true;
            AnalysisResultTime.Width = 162;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialButton1);
            groupBox2.Controls.Add(materialComboBoxFinishedProduct);
            groupBox2.Location = new Point(29, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 125);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Finished Product";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = Color.FromArgb(0, 192, 0);
            materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(526, 45);
            materialButton1.Margin = new Padding(5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(105, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Show Data";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = true;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialComboBoxFinishedProduct
            // 
            materialComboBoxFinishedProduct.AutoResize = false;
            materialComboBoxFinishedProduct.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxFinishedProduct.Depth = 0;
            materialComboBoxFinishedProduct.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxFinishedProduct.DropDownHeight = 174;
            materialComboBoxFinishedProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxFinishedProduct.DropDownWidth = 121;
            materialComboBoxFinishedProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxFinishedProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxFinishedProduct.FormattingEnabled = true;
            materialComboBoxFinishedProduct.Hint = "Select a Finished Product";
            materialComboBoxFinishedProduct.IntegralHeight = false;
            materialComboBoxFinishedProduct.ItemHeight = 43;
            materialComboBoxFinishedProduct.Items.AddRange(new object[] { "Crude Shea Olein", "Crude Shea Stearin" });
            materialComboBoxFinishedProduct.Location = new Point(41, 37);
            materialComboBoxFinishedProduct.MaxDropDownItems = 4;
            materialComboBoxFinishedProduct.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxFinishedProduct.Name = "materialComboBoxFinishedProduct";
            materialComboBoxFinishedProduct.Size = new Size(452, 49);
            materialComboBoxFinishedProduct.StartIndex = 0;
            materialComboBoxFinishedProduct.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(382, 211);
            label2.Name = "label2";
            label2.Size = new Size(296, 28);
            label2.TabIndex = 13;
            label2.Text = "Select a Finished Product to Add";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(materialButtonShowAll);
            groupBox3.Controls.Add(materialButtonSearchAnalyticalResults);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePickerToDate);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dateTimePickerFromDate);
            groupBox3.Location = new Point(728, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(891, 125);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search by Analysis Result Date";
            // 
            // materialButtonShowAll
            // 
            materialButtonShowAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonShowAll.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonShowAll.Cursor = Cursors.Hand;
            materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonShowAll.Depth = 0;
            materialButtonShowAll.HighEmphasis = true;
            materialButtonShowAll.Icon = null;
            materialButtonShowAll.Location = new Point(762, 36);
            materialButtonShowAll.Margin = new Padding(5);
            materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonShowAll.Name = "materialButtonShowAll";
            materialButtonShowAll.NoAccentTextColor = Color.Empty;
            materialButtonShowAll.Size = new Size(93, 36);
            materialButtonShowAll.TabIndex = 49;
            materialButtonShowAll.Text = "Show All";
            materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonShowAll.UseAccentColor = true;
            materialButtonShowAll.UseVisualStyleBackColor = true;
            materialButtonShowAll.Click += materialButtonShowAll_Click;
            // 
            // materialButtonSearchAnalyticalResults
            // 
            materialButtonSearchAnalyticalResults.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSearchAnalyticalResults.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSearchAnalyticalResults.Cursor = Cursors.Hand;
            materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSearchAnalyticalResults.Depth = 0;
            materialButtonSearchAnalyticalResults.HighEmphasis = true;
            materialButtonSearchAnalyticalResults.Icon = null;
            materialButtonSearchAnalyticalResults.Location = new Point(665, 36);
            materialButtonSearchAnalyticalResults.Margin = new Padding(5);
            materialButtonSearchAnalyticalResults.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSearchAnalyticalResults.Name = "materialButtonSearchAnalyticalResults";
            materialButtonSearchAnalyticalResults.NoAccentTextColor = Color.Empty;
            materialButtonSearchAnalyticalResults.Size = new Size(78, 36);
            materialButtonSearchAnalyticalResults.TabIndex = 46;
            materialButtonSearchAnalyticalResults.Text = "Search";
            materialButtonSearchAnalyticalResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSearchAnalyticalResults.UseAccentColor = true;
            materialButtonSearchAnalyticalResults.UseVisualStyleBackColor = true;
            materialButtonSearchAnalyticalResults.Click += materialButtonSearchAnalyticalResults_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 51);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 48;
            label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(389, 47);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(250, 27);
            dateTimePickerToDate.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 51);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 45;
            label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(73, 47);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(250, 27);
            dateTimePickerFromDate.TabIndex = 44;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(29, 17);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(191, 24);
            materialLabel1.TabIndex = 15;
            materialLabel1.Text = "Add Finished Product";
            // 
            // UserControlAddFinishedProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel1);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView_Finished_Products_With_Results);
            Controls.Add(groupBox1);
            Name = "UserControlAddFinishedProduct";
            Size = new Size(1691, 739);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Finished_Products_With_Results).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxProductType;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchAnalyticalResults;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DataGridViewTextBoxColumn SampleDetailsID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn Label;
        private DataGridViewTextBoxColumn AnalysisRequestDate;
        private DataGridViewTextBoxColumn AnalysisRequestTime;
        private DataGridViewTextBoxColumn AnalysisResultDate;
        private DataGridViewTextBoxColumn AnalysisResultTime;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
    }
}
