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
            dataGridViewFinishedProducts = new DataGridView();
            label2 = new Label();
            groupBox1 = new GroupBox();
            materialButtonGenerateCertificateOfAnalysis = new MaterialSkin.Controls.MaterialButton();
            dataGridViewAnalysisResult = new DataGridView();
            Parameters = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Method = new DataGridViewTextBoxColumn();
            Specification = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            buttonResetProductTypeFilter = new PictureBox();
            labelProductTypeError = new Label();
            materialComboBoxProductType = new MaterialSkin.Controls.MaterialComboBox();
            materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            materialButtonSearchProductType = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            dateTimePickerToDate = new DateTimePicker();
            SwitchCaptionControl = new MaterialSkin.Controls.MaterialLabel();
            SwitchFilterControl = new MaterialSkin.Controls.MaterialSwitch();
            label4 = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            Consignee = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Label = new DataGridViewTextBoxColumn();
            ProductType = new DataGridViewTextBoxColumn();
            BatchNumber = new DataGridViewTextBoxColumn();
            ContainerNumber = new DataGridViewTextBoxColumn();
            SealNumber = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            QualityControlManager = new DataGridViewTextBoxColumn();
            SampleResultID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinishedProducts).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalysisResult).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonResetProductTypeFilter).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFinishedProducts
            // 
            dataGridViewFinishedProducts.AllowUserToAddRows = false;
            dataGridViewFinishedProducts.AllowUserToDeleteRows = false;
            dataGridViewFinishedProducts.AllowUserToOrderColumns = true;
            dataGridViewFinishedProducts.AllowUserToResizeColumns = false;
            dataGridViewFinishedProducts.AllowUserToResizeRows = false;
            dataGridViewFinishedProducts.BackgroundColor = SystemColors.Window;
            dataGridViewFinishedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinishedProducts.Columns.AddRange(new DataGridViewColumn[] { Consignee, ProductName, Label, ProductType, BatchNumber, ContainerNumber, SealNumber, Quantity, Date, QualityControlManager, SampleResultID });
            dataGridViewFinishedProducts.Location = new Point(26, 303);
            dataGridViewFinishedProducts.Name = "dataGridViewFinishedProducts";
            dataGridViewFinishedProducts.ReadOnly = true;
            dataGridViewFinishedProducts.RowHeadersWidth = 51;
            dataGridViewFinishedProducts.RowTemplate.Height = 29;
            dataGridViewFinishedProducts.Size = new Size(1410, 287);
            dataGridViewFinishedProducts.TabIndex = 0;
            dataGridViewFinishedProducts.CellClick += dataGridViewFinishedProducts_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 275);
            label2.Name = "label2";
            label2.Size = new Size(412, 23);
            label2.TabIndex = 2;
            label2.Text = "Select a Finished Product to View it's Analysis Results";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialButtonGenerateCertificateOfAnalysis);
            groupBox1.Controls.Add(dataGridViewAnalysisResult);
            groupBox1.Location = new Point(26, 595);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1410, 484);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ANALYSIS RESULT";
            // 
            // materialButtonGenerateCertificateOfAnalysis
            // 
            materialButtonGenerateCertificateOfAnalysis.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonGenerateCertificateOfAnalysis.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonGenerateCertificateOfAnalysis.Cursor = Cursors.Hand;
            materialButtonGenerateCertificateOfAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonGenerateCertificateOfAnalysis.Depth = 0;
            materialButtonGenerateCertificateOfAnalysis.HighEmphasis = true;
            materialButtonGenerateCertificateOfAnalysis.Icon = null;
            materialButtonGenerateCertificateOfAnalysis.Location = new Point(544, 409);
            materialButtonGenerateCertificateOfAnalysis.Margin = new Padding(5);
            materialButtonGenerateCertificateOfAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonGenerateCertificateOfAnalysis.Name = "materialButtonGenerateCertificateOfAnalysis";
            materialButtonGenerateCertificateOfAnalysis.NoAccentTextColor = Color.Empty;
            materialButtonGenerateCertificateOfAnalysis.Size = new Size(283, 36);
            materialButtonGenerateCertificateOfAnalysis.TabIndex = 6;
            materialButtonGenerateCertificateOfAnalysis.Text = "Generate Certificate of Analysis";
            materialButtonGenerateCertificateOfAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonGenerateCertificateOfAnalysis.UseAccentColor = true;
            materialButtonGenerateCertificateOfAnalysis.UseVisualStyleBackColor = true;
            materialButtonGenerateCertificateOfAnalysis.Click += materialButton1_Click;
            // 
            // dataGridViewAnalysisResult
            // 
            dataGridViewAnalysisResult.AllowUserToAddRows = false;
            dataGridViewAnalysisResult.AllowUserToDeleteRows = false;
            dataGridViewAnalysisResult.AllowUserToResizeColumns = false;
            dataGridViewAnalysisResult.AllowUserToResizeRows = false;
            dataGridViewAnalysisResult.BackgroundColor = SystemColors.Window;
            dataGridViewAnalysisResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnalysisResult.Columns.AddRange(new DataGridViewColumn[] { Parameters, Unit, Method, Specification, Result });
            dataGridViewAnalysisResult.Location = new Point(223, 44);
            dataGridViewAnalysisResult.Name = "dataGridViewAnalysisResult";
            dataGridViewAnalysisResult.ReadOnly = true;
            dataGridViewAnalysisResult.RowHeadersWidth = 51;
            dataGridViewAnalysisResult.RowTemplate.Height = 29;
            dataGridViewAnalysisResult.Size = new Size(965, 357);
            dataGridViewAnalysisResult.TabIndex = 5;
            // 
            // Parameters
            // 
            Parameters.HeaderText = "PARAMETERS";
            Parameters.MinimumWidth = 6;
            Parameters.Name = "Parameters";
            Parameters.ReadOnly = true;
            Parameters.Width = 159;
            // 
            // Unit
            // 
            Unit.HeaderText = "UNIT";
            Unit.MinimumWidth = 6;
            Unit.Name = "Unit";
            Unit.ReadOnly = true;
            Unit.Width = 158;
            // 
            // Method
            // 
            Method.HeaderText = "METHOD";
            Method.MinimumWidth = 6;
            Method.Name = "Method";
            Method.ReadOnly = true;
            Method.Width = 159;
            // 
            // Specification
            // 
            Specification.HeaderText = "SPECIFICATION";
            Specification.MinimumWidth = 6;
            Specification.Name = "Specification";
            Specification.ReadOnly = true;
            Specification.Width = 158;
            // 
            // Result
            // 
            Result.HeaderText = "RESULT";
            Result.MinimumWidth = 6;
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Width = 157;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonResetProductTypeFilter);
            groupBox2.Controls.Add(labelProductTypeError);
            groupBox2.Controls.Add(materialComboBoxProductType);
            groupBox2.Controls.Add(materialButtonShowAll);
            groupBox2.Controls.Add(materialButtonSearchProductType);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePickerToDate);
            groupBox2.Controls.Add(SwitchCaptionControl);
            groupBox2.Controls.Add(SwitchFilterControl);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dateTimePickerFromDate);
            groupBox2.Location = new Point(26, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1226, 189);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search Filters";
            // 
            // buttonResetProductTypeFilter
            // 
            buttonResetProductTypeFilter.Cursor = Cursors.Hand;
            buttonResetProductTypeFilter.Image = Properties.Resources.sync_dark;
            buttonResetProductTypeFilter.Location = new Point(928, 117);
            buttonResetProductTypeFilter.Margin = new Padding(3, 4, 3, 4);
            buttonResetProductTypeFilter.Name = "buttonResetProductTypeFilter";
            buttonResetProductTypeFilter.Size = new Size(29, 33);
            buttonResetProductTypeFilter.TabIndex = 58;
            buttonResetProductTypeFilter.TabStop = false;
            buttonResetProductTypeFilter.Click += buttonResetProductTypeFilter_Click;
            // 
            // labelProductTypeError
            // 
            labelProductTypeError.AutoSize = true;
            labelProductTypeError.Location = new Point(664, 167);
            labelProductTypeError.Name = "labelProductTypeError";
            labelProductTypeError.Size = new Size(50, 20);
            labelProductTypeError.TabIndex = 55;
            labelProductTypeError.Text = "label5";
            // 
            // materialComboBoxProductType
            // 
            materialComboBoxProductType.AutoResize = false;
            materialComboBoxProductType.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxProductType.Depth = 0;
            materialComboBoxProductType.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxProductType.DropDownHeight = 174;
            materialComboBoxProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxProductType.DropDownWidth = 121;
            materialComboBoxProductType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxProductType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxProductType.FormattingEnabled = true;
            materialComboBoxProductType.Hint = "Search by Product Type";
            materialComboBoxProductType.IntegralHeight = false;
            materialComboBoxProductType.ItemHeight = 43;
            materialComboBoxProductType.Location = new Point(664, 100);
            materialComboBoxProductType.MaxDropDownItems = 4;
            materialComboBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxProductType.Name = "materialComboBoxProductType";
            materialComboBoxProductType.Size = new Size(257, 49);
            materialComboBoxProductType.StartIndex = 0;
            materialComboBoxProductType.TabIndex = 50;
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
            materialButtonShowAll.Location = new Point(1083, 111);
            materialButtonShowAll.Margin = new Padding(5);
            materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonShowAll.Name = "materialButtonShowAll";
            materialButtonShowAll.NoAccentTextColor = Color.Empty;
            materialButtonShowAll.Size = new Size(93, 36);
            materialButtonShowAll.TabIndex = 48;
            materialButtonShowAll.Text = "Show All";
            materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonShowAll.UseAccentColor = true;
            materialButtonShowAll.UseVisualStyleBackColor = true;
            materialButtonShowAll.Click += materialButtonShowAll_Click;
            // 
            // materialButtonSearchProductType
            // 
            materialButtonSearchProductType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSearchProductType.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSearchProductType.Cursor = Cursors.Hand;
            materialButtonSearchProductType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSearchProductType.Depth = 0;
            materialButtonSearchProductType.HighEmphasis = true;
            materialButtonSearchProductType.Icon = null;
            materialButtonSearchProductType.Location = new Point(985, 111);
            materialButtonSearchProductType.Margin = new Padding(5);
            materialButtonSearchProductType.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSearchProductType.Name = "materialButtonSearchProductType";
            materialButtonSearchProductType.NoAccentTextColor = Color.Empty;
            materialButtonSearchProductType.Size = new Size(78, 36);
            materialButtonSearchProductType.TabIndex = 45;
            materialButtonSearchProductType.Text = "Search";
            materialButtonSearchProductType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSearchProductType.UseAccentColor = true;
            materialButtonSearchProductType.UseVisualStyleBackColor = true;
            materialButtonSearchProductType.Click += materialButtonSearchProductType_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 125);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 47;
            label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(393, 123);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(250, 27);
            dateTimePickerToDate.TabIndex = 46;
            // 
            // SwitchCaptionControl
            // 
            SwitchCaptionControl.AutoSize = true;
            SwitchCaptionControl.Depth = 0;
            SwitchCaptionControl.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            SwitchCaptionControl.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            SwitchCaptionControl.Location = new Point(34, 37);
            SwitchCaptionControl.MouseState = MaterialSkin.MouseState.HOVER;
            SwitchCaptionControl.Name = "SwitchCaptionControl";
            SwitchCaptionControl.Size = new Size(167, 17);
            SwitchCaptionControl.TabIndex = 53;
            SwitchCaptionControl.Text = "I'm Searching by all Filters";
            // 
            // SwitchFilterControl
            // 
            SwitchFilterControl.AutoSize = true;
            SwitchFilterControl.Checked = true;
            SwitchFilterControl.CheckState = CheckState.Checked;
            SwitchFilterControl.Depth = 0;
            SwitchFilterControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SwitchFilterControl.Location = new Point(21, 61);
            SwitchFilterControl.Margin = new Padding(0);
            SwitchFilterControl.MouseLocation = new Point(-1, -1);
            SwitchFilterControl.MouseState = MaterialSkin.MouseState.HOVER;
            SwitchFilterControl.Name = "SwitchFilterControl";
            SwitchFilterControl.Ripple = true;
            SwitchFilterControl.Size = new Size(421, 37);
            SwitchFilterControl.TabIndex = 52;
            SwitchFilterControl.Text = "Turn Off Date filters to search only by Product Type";
            SwitchFilterControl.UseVisualStyleBackColor = true;
            SwitchFilterControl.CheckedChanged += SwitchFilterControl_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 125);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 44;
            label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(80, 123);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(250, 27);
            dateTimePickerFromDate.TabIndex = 43;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(29, 17);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(201, 24);
            materialLabel5.TabIndex = 64;
            materialLabel5.Text = "Certificate Of Analysis";
            // 
            // Consignee
            // 
            Consignee.HeaderText = "CONSIGNEE";
            Consignee.MinimumWidth = 6;
            Consignee.Name = "Consignee";
            Consignee.ReadOnly = true;
            Consignee.Width = 169;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Visible = false;
            ProductName.Width = 125;
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
            // ProductType
            // 
            ProductType.HeaderText = "PRODUCT TYPE";
            ProductType.MinimumWidth = 6;
            ProductType.Name = "ProductType";
            ProductType.ReadOnly = true;
            ProductType.Width = 220;
            // 
            // BatchNumber
            // 
            BatchNumber.HeaderText = "BATCH NUMBER";
            BatchNumber.MinimumWidth = 6;
            BatchNumber.Name = "BatchNumber";
            BatchNumber.ReadOnly = true;
            BatchNumber.Width = 166;
            // 
            // ContainerNumber
            // 
            ContainerNumber.HeaderText = "CONTAINER NUMBER";
            ContainerNumber.MinimumWidth = 6;
            ContainerNumber.Name = "ContainerNumber";
            ContainerNumber.ReadOnly = true;
            ContainerNumber.Width = 170;
            // 
            // SealNumber
            // 
            SealNumber.HeaderText = "SEAL NUMBER";
            SealNumber.MinimumWidth = 6;
            SealNumber.Name = "SealNumber";
            SealNumber.ReadOnly = true;
            SealNumber.Width = 169;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "QUANTITY";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 170;
            // 
            // Date
            // 
            Date.HeaderText = "DATE";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 169;
            // 
            // QualityControlManager
            // 
            QualityControlManager.HeaderText = "QUALITY CONTROL MANAGER";
            QualityControlManager.MinimumWidth = 6;
            QualityControlManager.Name = "QualityControlManager";
            QualityControlManager.ReadOnly = true;
            QualityControlManager.Visible = false;
            QualityControlManager.Width = 125;
            // 
            // SampleResultID
            // 
            SampleResultID.HeaderText = "SAMPLE RESULT ID";
            SampleResultID.MinimumWidth = 6;
            SampleResultID.Name = "SampleResultID";
            SampleResultID.ReadOnly = true;
            SampleResultID.Visible = false;
            SampleResultID.Width = 125;
            // 
            // UserControlViewCertificateOfAnalysis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dataGridViewFinishedProducts);
            Name = "UserControlViewCertificateOfAnalysis";
            Size = new Size(1463, 1165);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinishedProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalysisResult).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonResetProductTypeFilter).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private PictureBox buttonResetProductTypeFilter;
        private DataGridViewTextBoxColumn Consignee;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Label;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn BatchNumber;
        private DataGridViewTextBoxColumn ContainerNumber;
        private DataGridViewTextBoxColumn SealNumber;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn QualityControlManager;
        private DataGridViewTextBoxColumn SampleResultID;
    }
}
