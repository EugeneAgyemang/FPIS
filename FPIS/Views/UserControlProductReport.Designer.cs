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
            this.labelProductCount.Location = new System.Drawing.Point(42, 75);
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
            this.label2.Location = new System.Drawing.Point(660, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "List of Products";
            // 
            // dataGridViewProductreport
            // 
            this.dataGridViewProductreport.AllowUserToAddRows = false;
            this.dataGridViewProductreport.AllowUserToDeleteRows = false;
            this.dataGridViewProductreport.AllowUserToResizeColumns = false;
            this.dataGridViewProductreport.AllowUserToResizeRows = false;
            this.dataGridViewProductreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductreport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProductreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductreport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductType});
            this.dataGridViewProductreport.Location = new System.Drawing.Point(401, 189);
            this.dataGridViewProductreport.Name = "dataGridViewProductreport";
            this.dataGridViewProductreport.ReadOnly = true;
            this.dataGridViewProductreport.RowHeadersWidth = 51;
            this.dataGridViewProductreport.RowTemplate.Height = 29;
            this.dataGridViewProductreport.Size = new System.Drawing.Size(662, 559);
            this.dataGridViewProductreport.TabIndex = 44;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "PRODUCT NAME";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "PRODUCT TYPE";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
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
            this.materialButtonPrintProductReport.Location = new System.Drawing.Point(1070, 712);
            this.materialButtonPrintProductReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // UserControlProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButtonPrintProductReport);
            this.Controls.Add(this.labelProductCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewProductreport);
            this.Controls.Add(this.label1);
            this.Name = "UserControlProductReport";
            this.Size = new System.Drawing.Size(1294, 832);
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
    }
}
