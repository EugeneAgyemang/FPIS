namespace FPIS.Views
{
    partial class userControlIssueStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBoxStockType = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewIssueStock = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsOfMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuatityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelQuantityToIssueError = new System.Windows.Forms.Label();
            this.materialTextBoxQuantityToIssue = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxAvailableQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxItemName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButtonIssueStock = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialButtonSearchAnalyticalResults = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssueStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Stock";
            // 
            // materialComboBoxStockType
            // 
            this.materialComboBoxStockType.AutoResize = false;
            this.materialComboBoxStockType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxStockType.Depth = 0;
            this.materialComboBoxStockType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxStockType.DropDownHeight = 174;
            this.materialComboBoxStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxStockType.DropDownWidth = 121;
            this.materialComboBoxStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxStockType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxStockType.FormattingEnabled = true;
            this.materialComboBoxStockType.Hint = "Select the type of Stock to Issue";
            this.materialComboBoxStockType.IntegralHeight = false;
            this.materialComboBoxStockType.ItemHeight = 43;
            this.materialComboBoxStockType.Location = new System.Drawing.Point(41, 37);
            this.materialComboBoxStockType.MaxDropDownItems = 4;
            this.materialComboBoxStockType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxStockType.Name = "materialComboBoxStockType";
            this.materialComboBoxStockType.Size = new System.Drawing.Size(452, 49);
            this.materialComboBoxStockType.StartIndex = 0;
            this.materialComboBoxStockType.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialButton1);
            this.groupBox1.Controls.Add(this.materialComboBoxStockType);
            this.groupBox1.Location = new System.Drawing.Point(115, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Type";
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
            // dataGridViewIssueStock
            // 
            this.dataGridViewIssueStock.AllowUserToAddRows = false;
            this.dataGridViewIssueStock.AllowUserToDeleteRows = false;
            this.dataGridViewIssueStock.AllowUserToResizeColumns = false;
            this.dataGridViewIssueStock.AllowUserToResizeRows = false;
            this.dataGridViewIssueStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIssueStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssueStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ReceivedDate,
            this.UnitsOfMeasurement,
            this.QuatityReceived,
            this.AvailableQuantity,
            this.ExpiryDate,
            this.ReceivedStockID});
            this.dataGridViewIssueStock.Location = new System.Drawing.Point(113, 429);
            this.dataGridViewIssueStock.MultiSelect = false;
            this.dataGridViewIssueStock.Name = "dataGridViewIssueStock";
            this.dataGridViewIssueStock.ReadOnly = true;
            this.dataGridViewIssueStock.RowHeadersWidth = 51;
            this.dataGridViewIssueStock.RowTemplate.Height = 29;
            this.dataGridViewIssueStock.Size = new System.Drawing.Size(1057, 311);
            this.dataGridViewIssueStock.TabIndex = 3;
            this.dataGridViewIssueStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIssueStock_CellClick);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.HeaderText = "Received Date";
            this.ReceivedDate.MinimumWidth = 6;
            this.ReceivedDate.Name = "ReceivedDate";
            this.ReceivedDate.ReadOnly = true;
            // 
            // UnitsOfMeasurement
            // 
            this.UnitsOfMeasurement.HeaderText = "Units Of Measurement";
            this.UnitsOfMeasurement.MinimumWidth = 6;
            this.UnitsOfMeasurement.Name = "UnitsOfMeasurement";
            this.UnitsOfMeasurement.ReadOnly = true;
            // 
            // QuatityReceived
            // 
            this.QuatityReceived.HeaderText = "Quatity Received";
            this.QuatityReceived.MinimumWidth = 6;
            this.QuatityReceived.Name = "QuatityReceived";
            this.QuatityReceived.ReadOnly = true;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.MinimumWidth = 6;
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.HeaderText = "Expiry Date";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.ReadOnly = true;
            // 
            // ReceivedStockID
            // 
            this.ReceivedStockID.HeaderText = "Received Stock ID";
            this.ReceivedStockID.MinimumWidth = 6;
            this.ReceivedStockID.Name = "ReceivedStockID";
            this.ReceivedStockID.ReadOnly = true;
            this.ReceivedStockID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(555, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select the Item to Issue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelQuantityToIssueError);
            this.groupBox2.Controls.Add(this.materialTextBoxQuantityToIssue);
            this.groupBox2.Controls.Add(this.materialTextBoxAvailableQuantity);
            this.groupBox2.Controls.Add(this.materialTextBoxItemName);
            this.groupBox2.Controls.Add(this.materialButtonIssueStock);
            this.groupBox2.Location = new System.Drawing.Point(1234, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 375);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issue this Stock";
            // 
            // labelQuantityToIssueError
            // 
            this.labelQuantityToIssueError.AutoSize = true;
            this.labelQuantityToIssueError.Location = new System.Drawing.Point(42, 269);
            this.labelQuantityToIssueError.Name = "labelQuantityToIssueError";
            this.labelQuantityToIssueError.Size = new System.Drawing.Size(50, 20);
            this.labelQuantityToIssueError.TabIndex = 10;
            this.labelQuantityToIssueError.Text = "label3";
            // 
            // materialTextBoxQuantityToIssue
            // 
            this.materialTextBoxQuantityToIssue.AnimateReadOnly = false;
            this.materialTextBoxQuantityToIssue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxQuantityToIssue.Depth = 0;
            this.materialTextBoxQuantityToIssue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxQuantityToIssue.Hint = "Quantity to Issue";
            this.materialTextBoxQuantityToIssue.LeadingIcon = null;
            this.materialTextBoxQuantityToIssue.Location = new System.Drawing.Point(37, 215);
            this.materialTextBoxQuantityToIssue.MaxLength = 50;
            this.materialTextBoxQuantityToIssue.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxQuantityToIssue.Multiline = false;
            this.materialTextBoxQuantityToIssue.Name = "materialTextBoxQuantityToIssue";
            this.materialTextBoxQuantityToIssue.Size = new System.Drawing.Size(244, 50);
            this.materialTextBoxQuantityToIssue.TabIndex = 9;
            this.materialTextBoxQuantityToIssue.Text = "";
            this.materialTextBoxQuantityToIssue.TrailingIcon = null;
            this.materialTextBoxQuantityToIssue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxQuantityToIssue_KeyPress);
            // 
            // materialTextBoxAvailableQuantity
            // 
            this.materialTextBoxAvailableQuantity.AnimateReadOnly = false;
            this.materialTextBoxAvailableQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxAvailableQuantity.Depth = 0;
            this.materialTextBoxAvailableQuantity.Enabled = false;
            this.materialTextBoxAvailableQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxAvailableQuantity.Hint = "Available Quantity";
            this.materialTextBoxAvailableQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxAvailableQuantity.LeadingIcon = null;
            this.materialTextBoxAvailableQuantity.Location = new System.Drawing.Point(37, 129);
            this.materialTextBoxAvailableQuantity.MaxLength = 50;
            this.materialTextBoxAvailableQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxAvailableQuantity.Multiline = false;
            this.materialTextBoxAvailableQuantity.Name = "materialTextBoxAvailableQuantity";
            this.materialTextBoxAvailableQuantity.Size = new System.Drawing.Size(244, 50);
            this.materialTextBoxAvailableQuantity.TabIndex = 8;
            this.materialTextBoxAvailableQuantity.Text = "";
            this.materialTextBoxAvailableQuantity.TrailingIcon = null;
            // 
            // materialTextBoxItemName
            // 
            this.materialTextBoxItemName.AnimateReadOnly = false;
            this.materialTextBoxItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxItemName.Depth = 0;
            this.materialTextBoxItemName.Enabled = false;
            this.materialTextBoxItemName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxItemName.Hint = "Item Name";
            this.materialTextBoxItemName.LeadingIcon = null;
            this.materialTextBoxItemName.Location = new System.Drawing.Point(37, 43);
            this.materialTextBoxItemName.MaxLength = 50;
            this.materialTextBoxItemName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxItemName.Multiline = false;
            this.materialTextBoxItemName.Name = "materialTextBoxItemName";
            this.materialTextBoxItemName.Size = new System.Drawing.Size(244, 50);
            this.materialTextBoxItemName.TabIndex = 7;
            this.materialTextBoxItemName.Text = "";
            this.materialTextBoxItemName.TrailingIcon = null;
            // 
            // materialButtonIssueStock
            // 
            this.materialButtonIssueStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonIssueStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.materialButtonIssueStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonIssueStock.Depth = 0;
            this.materialButtonIssueStock.HighEmphasis = true;
            this.materialButtonIssueStock.Icon = null;
            this.materialButtonIssueStock.Location = new System.Drawing.Point(105, 313);
            this.materialButtonIssueStock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonIssueStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonIssueStock.Name = "materialButtonIssueStock";
            this.materialButtonIssueStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonIssueStock.Size = new System.Drawing.Size(112, 36);
            this.materialButtonIssueStock.TabIndex = 6;
            this.materialButtonIssueStock.Text = "Issue Stock";
            this.materialButtonIssueStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonIssueStock.UseAccentColor = false;
            this.materialButtonIssueStock.UseVisualStyleBackColor = false;
            this.materialButtonIssueStock.Click += new System.EventHandler(this.materialButtonIssueStock_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialButtonSearchAnalyticalResults);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePickerToDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox3.Location = new System.Drawing.Point(798, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 125);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search by Received Date";
            // 
            // materialButtonSearchAnalyticalResults
            // 
            this.materialButtonSearchAnalyticalResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSearchAnalyticalResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSearchAnalyticalResults.Depth = 0;
            this.materialButtonSearchAnalyticalResults.HighEmphasis = true;
            this.materialButtonSearchAnalyticalResults.Icon = null;
            this.materialButtonSearchAnalyticalResults.Location = new System.Drawing.Point(667, 44);
            this.materialButtonSearchAnalyticalResults.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSearchAnalyticalResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSearchAnalyticalResults.Name = "materialButtonSearchAnalyticalResults";
            this.materialButtonSearchAnalyticalResults.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSearchAnalyticalResults.Size = new System.Drawing.Size(78, 36);
            this.materialButtonSearchAnalyticalResults.TabIndex = 46;
            this.materialButtonSearchAnalyticalResults.Text = "Search";
            this.materialButtonSearchAnalyticalResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSearchAnalyticalResults.UseAccentColor = false;
            this.materialButtonSearchAnalyticalResults.UseVisualStyleBackColor = true;
            this.materialButtonSearchAnalyticalResults.Click += new System.EventHandler(this.materialButtonSearchAnalyticalResults_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "To :";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(388, 47);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerToDate.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "From :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(64, 47);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerFromDate.TabIndex = 44;
            // 
            // userControlIssueStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewIssueStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "userControlIssueStock";
            this.Size = new System.Drawing.Size(1692, 939);
            this.Load += new System.EventHandler(this.userControlIssueStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssueStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxStockType;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private DataGridView dataGridViewIssueStock;
        private Label label2;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton materialButtonIssueStock;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxItemName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxQuantityToIssue;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxAvailableQuantity;
        private Label labelQuantityToIssueError;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ReceivedDate;
        private DataGridViewTextBoxColumn UnitsOfMeasurement;
        private DataGridViewTextBoxColumn QuatityReceived;
        private DataGridViewTextBoxColumn AvailableQuantity;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewTextBoxColumn ReceivedStockID;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton materialButtonSearchAnalyticalResults;
        private Label label3;
        private DateTimePicker dateTimePickerToDate;
        private Label label4;
        private DateTimePicker dateTimePickerFromDate;
    }
}
