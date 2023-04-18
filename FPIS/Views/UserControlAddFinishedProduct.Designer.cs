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
            this.label1 = new System.Windows.Forms.Label();
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
            this.materialButtonRequestForAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(1032, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 435);
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
            this.materialTextBoxProductType.Location = new System.Drawing.Point(54, 50);
            this.materialTextBoxProductType.MaxLength = 50;
            this.materialTextBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxProductType.Multiline = false;
            this.materialTextBoxProductType.Name = "materialTextBoxProductType";
            this.materialTextBoxProductType.Size = new System.Drawing.Size(232, 50);
            this.materialTextBoxProductType.TabIndex = 31;
            this.materialTextBoxProductType.Text = "";
            this.materialTextBoxProductType.TrailingIcon = null;
            // 
            // labelQuantityError
            // 
            this.labelQuantityError.AutoSize = true;
            this.labelQuantityError.Location = new System.Drawing.Point(344, 339);
            this.labelQuantityError.Name = "labelQuantityError";
            this.labelQuantityError.Size = new System.Drawing.Size(130, 20);
            this.labelQuantityError.TabIndex = 30;
            this.labelQuantityError.Text = "labelQuantityError";
            // 
            // labelSealNumberError
            // 
            this.labelSealNumberError.AutoSize = true;
            this.labelSealNumberError.Location = new System.Drawing.Point(344, 217);
            this.labelSealNumberError.Name = "labelSealNumberError";
            this.labelSealNumberError.Size = new System.Drawing.Size(156, 20);
            this.labelSealNumberError.TabIndex = 29;
            this.labelSealNumberError.Text = "labelSealNumberError";
            // 
            // labelContainerNumberError
            // 
            this.labelContainerNumberError.AutoSize = true;
            this.labelContainerNumberError.Location = new System.Drawing.Point(344, 104);
            this.labelContainerNumberError.Name = "labelContainerNumberError";
            this.labelContainerNumberError.Size = new System.Drawing.Size(192, 20);
            this.labelContainerNumberError.TabIndex = 28;
            this.labelContainerNumberError.Text = "labelContainerNumberError";
            // 
            // labelBatchNumberError
            // 
            this.labelBatchNumberError.AutoSize = true;
            this.labelBatchNumberError.Location = new System.Drawing.Point(54, 339);
            this.labelBatchNumberError.Name = "labelBatchNumberError";
            this.labelBatchNumberError.Size = new System.Drawing.Size(165, 20);
            this.labelBatchNumberError.TabIndex = 27;
            this.labelBatchNumberError.Text = "labelBatchNumberError";
            // 
            // labelCosigneeError
            // 
            this.labelCosigneeError.AutoSize = true;
            this.labelCosigneeError.Location = new System.Drawing.Point(54, 217);
            this.labelCosigneeError.Name = "labelCosigneeError";
            this.labelCosigneeError.Size = new System.Drawing.Size(135, 20);
            this.labelCosigneeError.TabIndex = 25;
            this.labelCosigneeError.Text = "labelCosigneeError";
            // 
            // materialButtonAddFinishedProduct
            // 
            this.materialButtonAddFinishedProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddFinishedProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddFinishedProduct.Depth = 0;
            this.materialButtonAddFinishedProduct.HighEmphasis = true;
            this.materialButtonAddFinishedProduct.Icon = null;
            this.materialButtonAddFinishedProduct.Location = new System.Drawing.Point(221, 385);
            this.materialButtonAddFinishedProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddFinishedProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddFinishedProduct.Name = "materialButtonAddFinishedProduct";
            this.materialButtonAddFinishedProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddFinishedProduct.Size = new System.Drawing.Size(189, 36);
            this.materialButtonAddFinishedProduct.TabIndex = 23;
            this.materialButtonAddFinishedProduct.Text = "Add Finished Product";
            this.materialButtonAddFinishedProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddFinishedProduct.UseAccentColor = false;
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
            this.materialTextBoxQuantity.Location = new System.Drawing.Point(344, 286);
            this.materialTextBoxQuantity.MaxLength = 50;
            this.materialTextBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxQuantity.Multiline = false;
            this.materialTextBoxQuantity.Name = "materialTextBoxQuantity";
            this.materialTextBoxQuantity.Size = new System.Drawing.Size(232, 50);
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
            this.materialTextBoxSealNumber.Location = new System.Drawing.Point(344, 164);
            this.materialTextBoxSealNumber.MaxLength = 50;
            this.materialTextBoxSealNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSealNumber.Multiline = false;
            this.materialTextBoxSealNumber.Name = "materialTextBoxSealNumber";
            this.materialTextBoxSealNumber.Size = new System.Drawing.Size(232, 50);
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
            this.materialTextBoxContainerNumber.Location = new System.Drawing.Point(344, 51);
            this.materialTextBoxContainerNumber.MaxLength = 50;
            this.materialTextBoxContainerNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxContainerNumber.Multiline = false;
            this.materialTextBoxContainerNumber.Name = "materialTextBoxContainerNumber";
            this.materialTextBoxContainerNumber.Size = new System.Drawing.Size(232, 50);
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
            this.materialTextBoxBatchNumber.Location = new System.Drawing.Point(54, 286);
            this.materialTextBoxBatchNumber.MaxLength = 50;
            this.materialTextBoxBatchNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBatchNumber.Multiline = false;
            this.materialTextBoxBatchNumber.Name = "materialTextBoxBatchNumber";
            this.materialTextBoxBatchNumber.Size = new System.Drawing.Size(232, 50);
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
            this.materialTextBoxCosignee.Location = new System.Drawing.Point(54, 164);
            this.materialTextBoxCosignee.MaxLength = 50;
            this.materialTextBoxCosignee.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxCosignee.Multiline = false;
            this.materialTextBoxCosignee.Name = "materialTextBoxCosignee";
            this.materialTextBoxCosignee.Size = new System.Drawing.Size(232, 50);
            this.materialTextBoxCosignee.TabIndex = 18;
            this.materialTextBoxCosignee.Text = "";
            this.materialTextBoxCosignee.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Finished Product";
            // 
            // dataGridView_Finished_Products_With_Results
            // 
            this.dataGridView_Finished_Products_With_Results.AllowUserToAddRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeColumns = false;
            this.dataGridView_Finished_Products_With_Results.AllowUserToResizeRows = false;
            this.dataGridView_Finished_Products_With_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Finished_Products_With_Results.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Finished_Products_With_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Finished_Products_With_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleDetailsID,
            this.ProductName,
            this.AnalysisRequestDate,
            this.AnalysisRequestTime,
            this.AnalysisResultDate,
            this.AnalysisResultTime});
            this.dataGridView_Finished_Products_With_Results.Location = new System.Drawing.Point(33, 369);
            this.dataGridView_Finished_Products_With_Results.MultiSelect = false;
            this.dataGridView_Finished_Products_With_Results.Name = "dataGridView_Finished_Products_With_Results";
            this.dataGridView_Finished_Products_With_Results.ReadOnly = true;
            this.dataGridView_Finished_Products_With_Results.RowHeadersWidth = 51;
            this.dataGridView_Finished_Products_With_Results.RowTemplate.Height = 29;
            this.dataGridView_Finished_Products_With_Results.Size = new System.Drawing.Size(993, 435);
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
            // 
            // AnalysisRequestDate
            // 
            this.AnalysisRequestDate.HeaderText = "Analysis Request Date";
            this.AnalysisRequestDate.MinimumWidth = 6;
            this.AnalysisRequestDate.Name = "AnalysisRequestDate";
            this.AnalysisRequestDate.ReadOnly = true;
            // 
            // AnalysisRequestTime
            // 
            this.AnalysisRequestTime.HeaderText = "Analysis Request Time";
            this.AnalysisRequestTime.MinimumWidth = 6;
            this.AnalysisRequestTime.Name = "AnalysisRequestTime";
            this.AnalysisRequestTime.ReadOnly = true;
            // 
            // AnalysisResultDate
            // 
            this.AnalysisResultDate.HeaderText = "Analysis Result Date";
            this.AnalysisResultDate.MinimumWidth = 6;
            this.AnalysisResultDate.Name = "AnalysisResultDate";
            this.AnalysisResultDate.ReadOnly = true;
            // 
            // AnalysisResultTime
            // 
            this.AnalysisResultTime.HeaderText = "Analysis Result Time";
            this.AnalysisResultTime.MinimumWidth = 6;
            this.AnalysisResultTime.Name = "AnalysisResultTime";
            this.AnalysisResultTime.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton1);
            this.groupBox2.Controls.Add(this.materialComboBoxFinishedProduct);
            this.groupBox2.Location = new System.Drawing.Point(33, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 125);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finished Product";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(526, 45);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(105, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Show Data";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
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
            this.materialComboBoxFinishedProduct.Location = new System.Drawing.Point(41, 37);
            this.materialComboBoxFinishedProduct.MaxDropDownItems = 4;
            this.materialComboBoxFinishedProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxFinishedProduct.Name = "materialComboBoxFinishedProduct";
            this.materialComboBoxFinishedProduct.Size = new System.Drawing.Size(452, 49);
            this.materialComboBoxFinishedProduct.StartIndex = 0;
            this.materialComboBoxFinishedProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select a Finished Product to Add";
            // 
            // materialButtonRequestForAnalysis
            // 
            this.materialButtonRequestForAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonRequestForAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonRequestForAnalysis.Depth = 0;
            this.materialButtonRequestForAnalysis.HighEmphasis = true;
            this.materialButtonRequestForAnalysis.Icon = null;
            this.materialButtonRequestForAnalysis.Location = new System.Drawing.Point(795, 167);
            this.materialButtonRequestForAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonRequestForAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonRequestForAnalysis.Name = "materialButtonRequestForAnalysis";
            this.materialButtonRequestForAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonRequestForAnalysis.Size = new System.Drawing.Size(188, 36);
            this.materialButtonRequestForAnalysis.TabIndex = 24;
            this.materialButtonRequestForAnalysis.Text = "Request For Analysis";
            this.materialButtonRequestForAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonRequestForAnalysis.UseAccentColor = false;
            this.materialButtonRequestForAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonRequestForAnalysis.Click += new System.EventHandler(this.materialButtonRequestForAnalysis_Click);
            // 
            // UserControlAddFinishedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButtonRequestForAnalysis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_Finished_Products_With_Results);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddFinishedProduct";
            this.Size = new System.Drawing.Size(1692, 939);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Finished_Products_With_Results)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private Label label1;
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
        private MaterialSkin.Controls.MaterialButton materialButtonRequestForAnalysis;
    }
}
