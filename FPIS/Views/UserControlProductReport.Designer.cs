namespace FPIS.Views
{
    partial class UserControlProductReport
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
            this.labelProductCount = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProductreport = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButtonPrintProductReport = new MaterialSkin.Controls.MaterialButton();
            this.labelProductTypeError = new System.Windows.Forms.Label();
            this.materialComboBoxProductType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonSearchProductType = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonShowAll = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductreport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Depth = 0;
            this.labelProductCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductCount.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.labelProductCount.HighEmphasis = true;
            this.labelProductCount.Location = new System.Drawing.Point(37, 56);
            this.labelProductCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(26, 17);
            this.labelProductCount.TabIndex = 46;
            this.labelProductCount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(578, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "List of Products";
            // 
            // dataGridViewProductreport
            // 
            this.dataGridViewProductreport.AllowUserToAddRows = false;
            this.dataGridViewProductreport.AllowUserToDeleteRows = false;
            this.dataGridViewProductreport.AllowUserToResizeColumns = false;
            this.dataGridViewProductreport.AllowUserToResizeRows = false;
            this.dataGridViewProductreport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProductreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductType});
            this.dataGridViewProductreport.Location = new System.Drawing.Point(351, 184);
            this.dataGridViewProductreport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductreport.Name = "dataGridViewProductreport";
            this.dataGridViewProductreport.ReadOnly = true;
            this.dataGridViewProductreport.RowHeadersWidth = 51;
            this.dataGridViewProductreport.RowTemplate.Height = 29;
            this.dataGridViewProductreport.Size = new System.Drawing.Size(579, 419);
            this.dataGridViewProductreport.TabIndex = 44;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "PRODUCT NAME";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 263;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "PRODUCT TYPE";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 263;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 43;
            this.label1.Text = "Product Report";
            // 
            // materialButtonPrintProductReport
            // 
            this.materialButtonPrintProductReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonPrintProductReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonPrintProductReport.Depth = 0;
            this.materialButtonPrintProductReport.HighEmphasis = true;
            this.materialButtonPrintProductReport.Icon = null;
            this.materialButtonPrintProductReport.Location = new System.Drawing.Point(936, 577);
            this.materialButtonPrintProductReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialButtonPrintProductReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonPrintProductReport.Name = "materialButtonPrintProductReport";
            this.materialButtonPrintProductReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonPrintProductReport.Size = new System.Drawing.Size(64, 36);
            this.materialButtonPrintProductReport.TabIndex = 50;
            this.materialButtonPrintProductReport.Text = "Print";
            this.materialButtonPrintProductReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonPrintProductReport.UseAccentColor = false;
            this.materialButtonPrintProductReport.UseVisualStyleBackColor = true;
            this.materialButtonPrintProductReport.Click += new System.EventHandler(this.materialButtonPrintProductReport_Click);
            // 
            // labelProductTypeError
            // 
            this.labelProductTypeError.AutoSize = true;
            this.labelProductTypeError.Location = new System.Drawing.Point(436, 104);
            this.labelProductTypeError.Name = "labelProductTypeError";
            this.labelProductTypeError.Size = new System.Drawing.Size(38, 15);
            this.labelProductTypeError.TabIndex = 59;
            this.labelProductTypeError.Text = "label3";
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
            this.materialComboBoxProductType.Location = new System.Drawing.Point(436, 64);
            this.materialComboBoxProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxProductType.MaxDropDownItems = 4;
            this.materialComboBoxProductType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxProductType.Name = "materialComboBoxProductType";
            this.materialComboBoxProductType.Size = new System.Drawing.Size(225, 49);
            this.materialComboBoxProductType.StartIndex = 0;
            this.materialComboBoxProductType.TabIndex = 58;
            // 
            // materialButtonSearchProductType
            // 
            this.materialButtonSearchProductType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchProductType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchProductType.Depth = 0;
            this.materialButtonSearchProductType.HighEmphasis = true;
            this.materialButtonSearchProductType.Icon = null;
            this.materialButtonSearchProductType.Location = new System.Drawing.Point(684, 68);
            this.materialButtonSearchProductType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialButtonSearchProductType.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchProductType.Name = "materialButtonSearchProductType";
            this.materialButtonSearchProductType.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchProductType.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchProductType.TabIndex = 56;
            this.materialButtonSearchProductType.Text = "Search";
            this.materialButtonSearchProductType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchProductType.UseAccentColor = false;
            this.materialButtonSearchProductType.UseVisualStyleBackColor = true;
            this.materialButtonSearchProductType.Click += new System.EventHandler(this.materialButtonSearchProductType_Click);
            // 
            // materialButtonShowAll
            // 
            this.materialButtonShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonShowAll.Depth = 0;
            this.materialButtonShowAll.HighEmphasis = true;
            this.materialButtonShowAll.Icon = null;
            this.materialButtonShowAll.Location = new System.Drawing.Point(766, 68);
            this.materialButtonShowAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialButtonShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonShowAll.Name = "materialButtonShowAll";
            this.materialButtonShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonShowAll.Size = new System.Drawing.Size(93, 36);
            this.materialButtonShowAll.TabIndex = 57;
            this.materialButtonShowAll.Text = "Show All";
            this.materialButtonShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonShowAll.UseAccentColor = false;
            this.materialButtonShowAll.UseVisualStyleBackColor = true;
            this.materialButtonShowAll.Click += new System.EventHandler(this.materialButtonShowAll_Click);
            // 
            // UserControlProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelProductTypeError);
            this.Controls.Add(this.materialComboBoxProductType);
            this.Controls.Add(this.materialButtonSearchProductType);
            this.Controls.Add(this.materialButtonShowAll);
            this.Controls.Add(this.materialButtonPrintProductReport);
            this.Controls.Add(this.labelProductCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProductreport);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlProductReport";
            this.Size = new System.Drawing.Size(1132, 694);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelProductCount;
        private Label label2;
        private DataGridView dataGridViewProductreport;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductType;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButtonPrintProductReport;
        private Label labelProductTypeError;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxProductType;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchProductType;
        private MaterialSkin.Controls.MaterialButton materialButtonShowAll;
    }
}
