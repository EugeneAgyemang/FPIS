namespace FPIS.Views
{
    partial class AddAnalysisSampleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnalysisSampleForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisSampleBindingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addAnalysisSamplesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.selectedDataGridViewCheckBoxColumn,
            this.addAnalysisSamplesQuantity});
            this.dataGridView1.DataSource = this.analysisSampleBindingItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(736, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // analysisSampleBindingItemBindingSource
            // 
            this.analysisSampleBindingItemBindingSource.DataSource = typeof(FPIS.Models.AnalysisSampleBindingItem);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // selectedDataGridViewCheckBoxColumn
            // 
            this.selectedDataGridViewCheckBoxColumn.DataPropertyName = "Selected";
            this.selectedDataGridViewCheckBoxColumn.HeaderText = "Selected";
            this.selectedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.selectedDataGridViewCheckBoxColumn.Name = "selectedDataGridViewCheckBoxColumn";
            this.selectedDataGridViewCheckBoxColumn.Width = 226;
            // 
            // addAnalysisSamplesQuantity
            // 
            this.addAnalysisSamplesQuantity.DataPropertyName = "Quantity";
            this.addAnalysisSamplesQuantity.HeaderText = "Quantity";
            this.addAnalysisSamplesQuantity.MinimumWidth = 8;
            this.addAnalysisSamplesQuantity.Name = "addAnalysisSamplesQuantity";
            this.addAnalysisSamplesQuantity.ReadOnly = true;
            this.addAnalysisSamplesQuantity.Width = 150;
            // 
            // AddAnalysisSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 533);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddAnalysisSampleForm";
            this.Padding = new System.Windows.Forms.Padding(3, 63, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Analysis Samples";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisSampleBindingItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource analysisSampleBindingItemBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn selectedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn addAnalysisSamplesQuantity;
    }
}