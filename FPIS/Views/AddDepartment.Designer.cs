namespace FPIS.Views
{
    partial class AddDepartment
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
            this.btnAddDepartment = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxDepartmentName = new MaterialSkin.Controls.MaterialTextBox();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddDepartment.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnAddDepartment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddDepartment.Depth = 0;
            this.btnAddDepartment.HighEmphasis = true;
            this.btnAddDepartment.Icon = null;
            this.btnAddDepartment.Location = new System.Drawing.Point(137, 212);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddDepartment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddDepartment.Size = new System.Drawing.Size(150, 36);
            this.btnAddDepartment.TabIndex = 31;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddDepartment.UseAccentColor = false;
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // materialTextBoxDepartmentName
            // 
            this.materialTextBoxDepartmentName.AnimateReadOnly = false;
            this.materialTextBoxDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDepartmentName.Depth = 0;
            this.materialTextBoxDepartmentName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDepartmentName.Hint = "Department Name";
            this.materialTextBoxDepartmentName.LeadingIcon = null;
            this.materialTextBoxDepartmentName.Location = new System.Drawing.Point(23, 98);
            this.materialTextBoxDepartmentName.MaxLength = 50;
            this.materialTextBoxDepartmentName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDepartmentName.Multiline = false;
            this.materialTextBoxDepartmentName.Name = "materialTextBoxDepartmentName";
            this.materialTextBoxDepartmentName.Size = new System.Drawing.Size(404, 50);
            this.materialTextBoxDepartmentName.TabIndex = 32;
            this.materialTextBoxDepartmentName.Text = "";
            this.materialTextBoxDepartmentName.TrailingIcon = null;
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(22, 159);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(162, 20);
            this.labelDepartmentName.TabIndex = 33;
            this.labelDepartmentName.Text = "labelDepartmentName";
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 274);
            this.Controls.Add(this.labelDepartmentName);
            this.Controls.Add(this.materialTextBoxDepartmentName);
            this.Controls.Add(this.btnAddDepartment);
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnAddDepartment;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDepartmentName;
        private Label labelDepartmentName;
    }
}