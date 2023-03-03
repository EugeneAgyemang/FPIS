namespace FPIS.Views
{
    partial class AddDesignation
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
            this.materialComboBoxDepartmentName = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxDesignationName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddDesignation = new MaterialSkin.Controls.MaterialButton();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialComboBoxDepartmentName
            // 
            this.materialComboBoxDepartmentName.AutoResize = false;
            this.materialComboBoxDepartmentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxDepartmentName.Depth = 0;
            this.materialComboBoxDepartmentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxDepartmentName.DropDownHeight = 174;
            this.materialComboBoxDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxDepartmentName.DropDownWidth = 121;
            this.materialComboBoxDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxDepartmentName.FormattingEnabled = true;
            this.materialComboBoxDepartmentName.Hint = "Select Department";
            this.materialComboBoxDepartmentName.IntegralHeight = false;
            this.materialComboBoxDepartmentName.ItemHeight = 43;
            this.materialComboBoxDepartmentName.Location = new System.Drawing.Point(25, 124);
            this.materialComboBoxDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBoxDepartmentName.MaxDropDownItems = 4;
            this.materialComboBoxDepartmentName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxDepartmentName.Name = "materialComboBoxDepartmentName";
            this.materialComboBoxDepartmentName.Size = new System.Drawing.Size(400, 49);
            this.materialComboBoxDepartmentName.StartIndex = 0;
            this.materialComboBoxDepartmentName.TabIndex = 0;
            // 
            // materialTextBoxDesignationName
            // 
            this.materialTextBoxDesignationName.AnimateReadOnly = false;
            this.materialTextBoxDesignationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDesignationName.Depth = 0;
            this.materialTextBoxDesignationName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDesignationName.Hint = "Designation";
            this.materialTextBoxDesignationName.LeadingIcon = null;
            this.materialTextBoxDesignationName.Location = new System.Drawing.Point(25, 210);
            this.materialTextBoxDesignationName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBoxDesignationName.MaxLength = 50;
            this.materialTextBoxDesignationName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDesignationName.Multiline = false;
            this.materialTextBoxDesignationName.Name = "materialTextBoxDesignationName";
            this.materialTextBoxDesignationName.Size = new System.Drawing.Size(400, 50);
            this.materialTextBoxDesignationName.TabIndex = 1;
            this.materialTextBoxDesignationName.Text = "";
            this.materialTextBoxDesignationName.TrailingIcon = null;
            // 
            // btnAddDesignation
            // 
            this.btnAddDesignation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddDesignation.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnAddDesignation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDesignation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddDesignation.Depth = 0;
            this.btnAddDesignation.HighEmphasis = true;
            this.btnAddDesignation.Icon = null;
            this.btnAddDesignation.Location = new System.Drawing.Point(151, 325);
            this.btnAddDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDesignation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddDesignation.Name = "btnAddDesignation";
            this.btnAddDesignation.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddDesignation.Size = new System.Drawing.Size(149, 36);
            this.btnAddDesignation.TabIndex = 2;
            this.btnAddDesignation.Text = "Add Designation";
            this.btnAddDesignation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddDesignation.UseAccentColor = true;
            this.btnAddDesignation.UseVisualStyleBackColor = true;
            this.btnAddDesignation.Click += new System.EventHandler(this.btnAddDesignation_Click);
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(25, 175);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(127, 15);
            this.labelDepartmentName.TabIndex = 3;
            this.labelDepartmentName.Text = "labelDepartmentName";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(25, 262);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(95, 15);
            this.labelDesignation.TabIndex = 4;
            this.labelDesignation.Text = "labelDesignation";
            // 
            // AddDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.labelDepartmentName);
            this.Controls.Add(this.btnAddDesignation);
            this.Controls.Add(this.materialTextBoxDesignationName);
            this.Controls.Add(this.materialComboBoxDepartmentName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddDesignation";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Designation";
            this.Load += new System.EventHandler(this.AddDesignation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxDepartmentName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDesignationName;
        private MaterialSkin.Controls.MaterialButton btnAddDesignation;
        private Label labelDepartmentName;
        private Label labelDesignation;
    }
}