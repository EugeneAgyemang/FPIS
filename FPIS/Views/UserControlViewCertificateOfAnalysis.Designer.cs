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
            this.SampleResultID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButtonGenerateCertificateOfAnalysis = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewAnalysisResult = new System.Windows.Forms.DataGridView();
            this.Parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinishedProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysisResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFinishedProducts
            // 
            this.dataGridViewFinishedProducts.AllowUserToAddRows = false;
            this.dataGridViewFinishedProducts.AllowUserToDeleteRows = false;
            this.dataGridViewFinishedProducts.AllowUserToOrderColumns = true;
            this.dataGridViewFinishedProducts.AllowUserToResizeColumns = false;
            this.dataGridViewFinishedProducts.AllowUserToResizeRows = false;
            this.dataGridViewFinishedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.SampleResultID});
            this.dataGridViewFinishedProducts.Location = new System.Drawing.Point(112, 132);
            this.dataGridViewFinishedProducts.Name = "dataGridViewFinishedProducts";
            this.dataGridViewFinishedProducts.ReadOnly = true;
            this.dataGridViewFinishedProducts.RowHeadersWidth = 51;
            this.dataGridViewFinishedProducts.RowTemplate.Height = 29;
            this.dataGridViewFinishedProducts.Size = new System.Drawing.Size(1410, 287);
            this.dataGridViewFinishedProducts.TabIndex = 0;
            this.dataGridViewFinishedProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinishedProducts_CellClick);
            // 
            // Consignee
            // 
            this.Consignee.HeaderText = "CONSIGNEE";
            this.Consignee.MinimumWidth = 6;
            this.Consignee.Name = "Consignee";
            this.Consignee.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "PRODUCT TYPE";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "BATCH NUMBER";
            this.BatchNumber.MinimumWidth = 6;
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            // 
            // ContainerNumber
            // 
            this.ContainerNumber.HeaderText = "CONTAINER NUMBER";
            this.ContainerNumber.MinimumWidth = 6;
            this.ContainerNumber.Name = "ContainerNumber";
            this.ContainerNumber.ReadOnly = true;
            // 
            // SealNumber
            // 
            this.SealNumber.HeaderText = "SEAL NUMBER";
            this.SealNumber.MinimumWidth = 6;
            this.SealNumber.Name = "SealNumber";
            this.SealNumber.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QUANTITY";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // SampleResultID
            // 
            this.SampleResultID.HeaderText = "SAMPLE RESULT ID";
            this.SampleResultID.MinimumWidth = 6;
            this.SampleResultID.Name = "SampleResultID";
            this.SampleResultID.ReadOnly = true;
            this.SampleResultID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Certificate Of Analysis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a Finished Product to View it\'s Analysis Results";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialButtonGenerateCertificateOfAnalysis);
            this.groupBox1.Controls.Add(this.dataGridViewAnalysisResult);
            this.groupBox1.Location = new System.Drawing.Point(112, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1410, 447);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANALYSIS RESULT";
            // 
            // materialButtonGenerateCertificateOfAnalysis
            // 
            this.materialButtonGenerateCertificateOfAnalysis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGenerateCertificateOfAnalysis.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerateCertificateOfAnalysis.Depth = 0;
            this.materialButtonGenerateCertificateOfAnalysis.HighEmphasis = true;
            this.materialButtonGenerateCertificateOfAnalysis.Icon = null;
            this.materialButtonGenerateCertificateOfAnalysis.Location = new System.Drawing.Point(1068, 366);
            this.materialButtonGenerateCertificateOfAnalysis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonGenerateCertificateOfAnalysis.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGenerateCertificateOfAnalysis.Name = "materialButtonGenerateCertificateOfAnalysis";
            this.materialButtonGenerateCertificateOfAnalysis.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGenerateCertificateOfAnalysis.Size = new System.Drawing.Size(283, 36);
            this.materialButtonGenerateCertificateOfAnalysis.TabIndex = 6;
            this.materialButtonGenerateCertificateOfAnalysis.Text = "GENERATE CERTIFICATE OF ANALYSIS";
            this.materialButtonGenerateCertificateOfAnalysis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGenerateCertificateOfAnalysis.UseAccentColor = false;
            this.materialButtonGenerateCertificateOfAnalysis.UseVisualStyleBackColor = true;
            this.materialButtonGenerateCertificateOfAnalysis.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dataGridViewAnalysisResult
            // 
            this.dataGridViewAnalysisResult.AllowUserToAddRows = false;
            this.dataGridViewAnalysisResult.AllowUserToDeleteRows = false;
            this.dataGridViewAnalysisResult.AllowUserToResizeColumns = false;
            this.dataGridViewAnalysisResult.AllowUserToResizeRows = false;
            this.dataGridViewAnalysisResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAnalysisResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAnalysisResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalysisResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parameters,
            this.Unit,
            this.Method,
            this.Specification,
            this.Result});
            this.dataGridViewAnalysisResult.Location = new System.Drawing.Point(60, 44);
            this.dataGridViewAnalysisResult.Name = "dataGridViewAnalysisResult";
            this.dataGridViewAnalysisResult.ReadOnly = true;
            this.dataGridViewAnalysisResult.RowHeadersWidth = 51;
            this.dataGridViewAnalysisResult.RowTemplate.Height = 29;
            this.dataGridViewAnalysisResult.Size = new System.Drawing.Size(965, 358);
            this.dataGridViewAnalysisResult.TabIndex = 5;
            // 
            // Parameters
            // 
            this.Parameters.HeaderText = "PARAMETERS";
            this.Parameters.MinimumWidth = 6;
            this.Parameters.Name = "Parameters";
            this.Parameters.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "UNIT";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Method
            // 
            this.Method.HeaderText = "METHOD";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            // 
            // Specification
            // 
            this.Specification.HeaderText = "SPECIFICATION";
            this.Specification.MinimumWidth = 6;
            this.Specification.Name = "Specification";
            this.Specification.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "RESULT";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // UserControlViewCertificateOfAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFinishedProducts);
            this.Name = "UserControlViewCertificateOfAnalysis";
            this.Size = new System.Drawing.Size(1692, 939);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinishedProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalysisResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewFinishedProducts;
        private Label label1;
        private DataGridViewTextBoxColumn Consignee;
        private DataGridViewTextBoxColumn ProductType;
        private DataGridViewTextBoxColumn BatchNumber;
        private DataGridViewTextBoxColumn ContainerNumber;
        private DataGridViewTextBoxColumn SealNumber;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn SampleResultID;
        private Label label2;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonGenerateCertificateOfAnalysis;
        private DataGridView dataGridViewAnalysisResult;
        private DataGridViewTextBoxColumn Parameters;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Method;
        private DataGridViewTextBoxColumn Specification;
        private DataGridViewTextBoxColumn Result;
    }
}
