namespace FPIS.Views
{
    partial class UserControlViewCertificateOfAnalysis
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
            this.dataGridViewFinishedProducts = new System.Windows.Forms.DataGridView();
            this.Consignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContainerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SealNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityControlManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleResultID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButtonGenerateCertificateOfAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewAnalysisResult = new System.Windows.Forms.DataGridView();
            this.Parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelProductTypeError = new System.Windows.Forms.Label();
            this.materialComboBoxProductType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSearchProductType = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            this.SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonResetProductTypeFilter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinishedProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysisResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonResetProductTypeFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFinishedProducts
            // 
            this.dataGridViewFinishedProducts.AllowUserToAddRows = false;
            this.dataGridViewFinishedProducts.AllowUserToDeleteRows = false;
            this.dataGridViewFinishedProducts.AllowUserToOrderColumns = true;
            this.dataGridViewFinishedProducts.AllowUserToResizeColumns = false;
            this.dataGridViewFinishedProducts.AllowUserToResizeRows = false;
            this.dataGridViewFinishedProducts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFinishedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinishedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consignee,
            this.ProductType,
            this.BatchNumber,
            this.ContainerNumber,
            this.SealNumber,
            this.Quantity,
            this.Date,
            this.QualityControlManager,
            this.SampleResultID});
            this.dataGridViewFinishedProducts.Location = new System.Drawing.Point(23, 227);
            this.dataGridViewFinishedProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFinishedProducts.Name = "dataGridViewFinishedProducts";
            this.dataGridViewFinishedProducts.ReadOnly = true;
            this.dataGridViewFinishedProducts.RowHeadersWidth = 51;
            this.dataGridViewFinishedProducts.RowTemplate.Height = 29;
            this.dataGridViewFinishedProducts.Size = new System.Drawing.Size(1234, 215);
            this.dataGridViewFinishedProducts.TabIndex = 0;
            this.dataGridViewFinishedProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinishedProducts_CellClick);
            // 
            // Consignee
            // 
            this.Consignee.HeaderText = "CONSIGNEE";
            this.Consignee.MinimumWidth = 6;
            this.Consignee.Name = "Consignee";
            this.Consignee.ReadOnly = true;
            this.Consignee.Width = 169;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "PRODUCT TYPE";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 168;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "BATCH NUMBER";
            this.BatchNumber.MinimumWidth = 6;
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            this.BatchNumber.Width = 166;
            // 
            // ContainerNumber
            // 
            this.ContainerNumber.HeaderText = "CONTAINER NUMBER";
            this.ContainerNumber.MinimumWidth = 6;
            this.ContainerNumber.Name = "ContainerNumber";
            this.ContainerNumber.ReadOnly = true;
            this.ContainerNumber.Width = 170;
            // 
            // SealNumber
            // 
            this.SealNumber.HeaderText = "SEAL NUMBER";
            this.SealNumber.MinimumWidth = 6;
            this.SealNumber.Name = "SealNumber";
            this.SealNumber.ReadOnly = true;
            this.SealNumber.Width = 169;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QUANTITY";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 170;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 169;
            // 
            // QualityControlManager
            // 
            this.QualityControlManager.HeaderText = "QUALITY CONTROL MANAGER";
            this.QualityControlManager.MinimumWidth = 6;
            this.QualityControlManager.Name = "QualityControlManager";
            this.QualityControlManager.ReadOnly = true;
            this.QualityControlManager.Visible = false;
            // 
            // SampleResultID
            // 
            this.SampleResultID.HeaderText = "SAMPLE RESULT ID";
            this.SampleResultID.MinimumWidth = 6;
            this.SampleResultID.Name = "SampleResultID";
            this.SampleResultID.ReadOnly = true;
            this.SampleResultID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a Finished Product to View it\'s Analysis Results";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialButtonGenerateCertificateOfAnalysis);
            this.groupBox1.Controls.Add(this.dataGridViewAnalysisResult);
            this.groupBox1.Location = new System.Drawing.Point(23, 446);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1234, 363);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANALYSIS RESULT";
            // 
            // materialButtonGenerateCertificateOfAnalysis
            // 
            this.materialButtonGenerateCertificateOfAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGenerateCertificateOfAnalysis.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonGenerateCertificateOfAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonGenerateCertificateOfAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerateCertificateOfAnalysis.Depth = 0;
            this.materialButtonGenerateCertificateOfAnalysis.HighEmphasis = true;
            this.materialButtonGenerateCertificateOfAnalysis.Icon = null;
            this.materialButtonGenerateCertificateOfAnalysis.Location = new System.Drawing.Point(476, 307);
            this.materialButtonGenerateCertificateOfAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonGenerateCertificateOfAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGenerateCertificateOfAnalysis.Name = "materialButtonGenerateCertificateOfAnalysis";
            this.materialButtonGenerateCertificateOfAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGenerateCertificateOfAnalysis.Size = new System.Drawing.Size(283, 36);
            this.materialButtonGenerateCertificateOfAnalysis.TabIndex = 6;
            this.materialButtonGenerateCertificateOfAnalysis.Text = "Generate Certificate of Analysis";
            this.materialButtonGenerateCertificateOfAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGenerateCertificateOfAnalysis.UseAccentColor = true;
            this.materialButtonGenerateCertificateOfAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonGenerateCertificateOfAnalysis.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dataGridViewAnalysisResult
            // 
            this.dataGridViewAnalysisResult.AllowUserToAddRows = false;
            this.dataGridViewAnalysisResult.AllowUserToDeleteRows = false;
            this.dataGridViewAnalysisResult.AllowUserToResizeColumns = false;
            this.dataGridViewAnalysisResult.AllowUserToResizeRows = false;
            this.dataGridViewAnalysisResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAnalysisResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalysisResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parameters,
            this.Unit,
            this.Method,
            this.Specification,
            this.Result});
            this.dataGridViewAnalysisResult.Location = new System.Drawing.Point(195, 33);
            this.dataGridViewAnalysisResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAnalysisResult.Name = "dataGridViewAnalysisResult";
            this.dataGridViewAnalysisResult.ReadOnly = true;
            this.dataGridViewAnalysisResult.RowHeadersWidth = 51;
            this.dataGridViewAnalysisResult.RowTemplate.Height = 29;
            this.dataGridViewAnalysisResult.Size = new System.Drawing.Size(844, 268);
            this.dataGridViewAnalysisResult.TabIndex = 5;
            // 
            // Parameters
            // 
            this.Parameters.HeaderText = "PARAMETERS";
            this.Parameters.MinimumWidth = 6;
            this.Parameters.Name = "Parameters";
            this.Parameters.ReadOnly = true;
            this.Parameters.Width = 159;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "UNIT";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 158;
            // 
            // Method
            // 
            this.Method.HeaderText = "METHOD";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 159;
            // 
            // Specification
            // 
            this.Specification.HeaderText = "SPECIFICATION";
            this.Specification.MinimumWidth = 6;
            this.Specification.Name = "Specification";
            this.Specification.ReadOnly = true;
            this.Specification.Width = 158;
            // 
            // Result
            // 
            this.Result.HeaderText = "RESULT";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 157;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonResetProductTypeFilter);
            this.groupBox2.Controls.Add(this.labelProductTypeError);
            this.groupBox2.Controls.Add(this.materialComboBoxProductType);
            this.groupBox2.Controls.Add(this.materialButtonShowAll);
            this.groupBox2.Controls.Add(this.materialButtonSearchProductType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerToDate);
            this.groupBox2.Controls.Add(this.SwitchCaptionControl);
            this.groupBox2.Controls.Add(this.SwitchFilterControl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox2.Location = new System.Drawing.Point(23, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1073, 142);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Filters";
            // 
            // labelProductTypeError
            // 
            this.labelProductTypeError.AutoSize = true;
            this.labelProductTypeError.Location = new System.Drawing.Point(581, 125);
            this.labelProductTypeError.Name = "labelProductTypeError";
            this.labelProductTypeError.Size = new System.Drawing.Size(38, 15);
            this.labelProductTypeError.TabIndex = 55;
            this.labelProductTypeError.Text = "label5";
            // 
            // materialComboBoxProductType
            // 
            this.materialComboBoxProductType.AutoResize = false;
            this.materialComboBoxProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxProductType.Depth = 0;
            this.materialComboBoxProductType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxProductType.DropDownHeight = 174;
            this.materialComboBoxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxProductType.DropDownWidth = 121;
            this.materialComboBoxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxProductType.FormattingEnabled = true;
            this.materialComboBoxProductType.Hint = "Search by Product Type";
            this.materialComboBoxProductType.IntegralHeight = false;
            this.materialComboBoxProductType.ItemHeight = 43;
            this.materialComboBoxProductType.Location = new System.Drawing.Point(581, 75);
            this.materialComboBoxProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxProductType.MaxDropDownItems = 4;
            this.materialComboBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxProductType.Name = "materialComboBoxProductType";
            this.materialComboBoxProductType.Size = new System.Drawing.Size(225, 49);
            this.materialComboBoxProductType.StartIndex = 0;
            this.materialComboBoxProductType.TabIndex = 50;
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(948, 83);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 48;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = true;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // materialButtonSearchProductType
            // 
            this.materialButtonSearchProductType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchProductType.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonSearchProductType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonSearchProductType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchProductType.Depth = 0;
            this.materialButtonSearchProductType.HighEmphasis = true;
            this.materialButtonSearchProductType.Icon = null;
            this.materialButtonSearchProductType.Location = new System.Drawing.Point(862, 83);
            this.materialButtonSearchProductType.Margin = new System.Windows.Forms.Padding(4);
            this.materialButtonSearchProductType.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchProductType.Name = "materialButtonSearchProductType";
            this.materialButtonSearchProductType.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchProductType.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchProductType.TabIndex = 45;
            this.materialButtonSearchProductType.Text = "Search";
            this.materialButtonSearchProductType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchProductType.UseAccentColor = true;
            this.materialButtonSearchProductType.UseVisualStyleBackColor = true;
            this.materialButtonSearchProductType.Click += new System.EventHandler(this.materialButtonSearchProductType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(344, 92);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerToDate.TabIndex = 46;
            // 
            // SwitchCaptionControl
            // 
            this.SwitchCaptionControl.AutoSize = true;
            this.SwitchCaptionControl.Depth = 0;
            this.SwitchCaptionControl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SwitchCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.SwitchCaptionControl.Location = new System.Drawing.Point(30, 28);
            this.SwitchCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchCaptionControl.Name = "SwitchCaptionControl";
            this.SwitchCaptionControl.Size = new System.Drawing.Size(167, 17);
            this.SwitchCaptionControl.TabIndex = 53;
            this.SwitchCaptionControl.Text = "I\'m Searching by all Filters";
            // 
            // SwitchFilterControl
            // 
            this.SwitchFilterControl.AutoSize = true;
            this.SwitchFilterControl.Checked = true;
            this.SwitchFilterControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SwitchFilterControl.Depth = 0;
            this.SwitchFilterControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwitchFilterControl.Location = new System.Drawing.Point(18, 46);
            this.SwitchFilterControl.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchFilterControl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchFilterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchFilterControl.Name = "SwitchFilterControl";
            this.SwitchFilterControl.Ripple = true;
            this.SwitchFilterControl.Size = new System.Drawing.Size(421, 37);
            this.SwitchFilterControl.TabIndex = 52;
            this.SwitchFilterControl.Text = "Turn Off Date filters to search only by Product Type";
            this.SwitchFilterControl.UseVisualStyleBackColor = true;
            this.SwitchFilterControl.CheckedChanged += new System.EventHandler(this.SwitchFilterControl_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(70, 92);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(219, 23);
            this.dateTimePickerFromDate.TabIndex = 43;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(25, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(201, 24);
            this.materialLabel5.TabIndex = 64;
            this.materialLabel5.Text = "Certificate Of Analysis";
            // 
            // buttonResetProductTypeFilter
            // 
            this.buttonResetProductTypeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetProductTypeFilter.Image = global::FPIS.Properties.Resources.sync_dark;
            this.buttonResetProductTypeFilter.Location = new System.Drawing.Point(812, 88);
            this.buttonResetProductTypeFilter.Name = "buttonResetProductTypeFilter";
            this.buttonResetProductTypeFilter.Size = new System.Drawing.Size(25, 25);
            this.buttonResetProductTypeFilter.TabIndex = 58;
            this.buttonResetProductTypeFilter.TabStop = false;
            this.buttonResetProductTypeFilter.Click += new System.EventHandler(this.buttonResetProductTypeFilter_Click);
            // 
            // UserControlViewCertificateOfAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewFinishedProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlViewCertificateOfAnalysis";
            this.Size = new System.Drawing.Size(1280, 874);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinishedProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysisResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonResetProductTypeFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewFinishedProducts;
        private Label label2;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateCertificateOfAnalysis;
        private DataGridView dataGridViewAnalysisResult;
        private DataGridViewTextBoxColumn Parameters;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Method;
        private DataGridViewTextBoxColumn Specification;
        private DataGridViewTextBoxColumn Result;
        private GroupBox groupBox2;
        private Label labelProductTypeError;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxProductType;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchProductType;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private MaterialSkin.Controls.MaterialLabel SwitchCaptionControl;
        private MaterialSkin.Controls.MaterialSwitch SwitchFilterControl;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
        private DataGridViewTextBoxColumn Consignee;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn BatchNumber;
        private DataGridViewTextBoxColumn ContainerNumber;
        private DataGridViewTextBoxColumn SealNumber;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn QualityControlManager;
        private DataGridViewTextBoxColumn SampleResultID;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private PictureBox buttonResetProductTypeFilter;
    }
}
