namespace FPIS.Views
{
    partial class UpdateProductParameter
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
            this.NewSpecificationControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductControl = new MaterialSkin.Controls.MaterialComboBox();
            this.SaveParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.PreviousSpecificationControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductParameterControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ProductErrorCaption = new System.Windows.Forms.Label();
            this.ParameterErrorControl = new System.Windows.Forms.Label();
            this.PreviousSpecificationErrorControl = new System.Windows.Forms.Label();
            this.NewSpecificationErrorControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewSpecificationControl
            // 
            this.NewSpecificationControl.AnimateReadOnly = false;
            this.NewSpecificationControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewSpecificationControl.Depth = 0;
            this.NewSpecificationControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewSpecificationControl.Hint = "New Specification";
            this.NewSpecificationControl.LeadingIcon = null;
            this.NewSpecificationControl.Location = new System.Drawing.Point(25, 390);
            this.NewSpecificationControl.MaxLength = 50;
            this.NewSpecificationControl.MouseState = MaterialSkin.MouseState.OUT;
            this.NewSpecificationControl.Multiline = false;
            this.NewSpecificationControl.Name = "NewSpecificationControl";
            this.NewSpecificationControl.Size = new System.Drawing.Size(400, 50);
            this.NewSpecificationControl.TabIndex = 8;
            this.NewSpecificationControl.Text = "";
            this.NewSpecificationControl.TrailingIcon = null;
            this.NewSpecificationControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewSpecificationControl_KeyPress);
            // 
            // ProductControl
            // 
            this.ProductControl.AutoResize = false;
            this.ProductControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductControl.Depth = 0;
            this.ProductControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProductControl.DropDownHeight = 174;
            this.ProductControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductControl.DropDownWidth = 121;
            this.ProductControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProductControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductControl.FormattingEnabled = true;
            this.ProductControl.Hint = "Product";
            this.ProductControl.IntegralHeight = false;
            this.ProductControl.ItemHeight = 43;
            this.ProductControl.Location = new System.Drawing.Point(25, 125);
            this.ProductControl.MaxDropDownItems = 4;
            this.ProductControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductControl.Name = "ProductControl";
            this.ProductControl.Size = new System.Drawing.Size(400, 49);
            this.ProductControl.StartIndex = -1;
            this.ProductControl.TabIndex = 10;
            this.ProductControl.SelectedIndexChanged += new System.EventHandler(this.ProductControl_SelectedIndexChanged);
            // 
            // SaveParameterControl
            // 
            this.SaveParameterControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveParameterControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.SaveParameterControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveParameterControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveParameterControl.Depth = 0;
            this.SaveParameterControl.HighEmphasis = true;
            this.SaveParameterControl.Icon = null;
            this.SaveParameterControl.Location = new System.Drawing.Point(193, 508);
            this.SaveParameterControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveParameterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveParameterControl.Name = "SaveParameterControl";
            this.SaveParameterControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveParameterControl.Size = new System.Drawing.Size(77, 36);
            this.SaveParameterControl.TabIndex = 11;
            this.SaveParameterControl.Text = "Update";
            this.SaveParameterControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveParameterControl.UseAccentColor = true;
            this.SaveParameterControl.UseVisualStyleBackColor = true;
            this.SaveParameterControl.Click += new System.EventHandler(this.SaveParameterControl_Click);
            // 
            // PreviousSpecificationControl
            // 
            this.PreviousSpecificationControl.AnimateReadOnly = false;
            this.PreviousSpecificationControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousSpecificationControl.Depth = 0;
            this.PreviousSpecificationControl.Enabled = false;
            this.PreviousSpecificationControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreviousSpecificationControl.Hint = "Previous Specification";
            this.PreviousSpecificationControl.LeadingIcon = null;
            this.PreviousSpecificationControl.Location = new System.Drawing.Point(25, 301);
            this.PreviousSpecificationControl.MaxLength = 50;
            this.PreviousSpecificationControl.MouseState = MaterialSkin.MouseState.OUT;
            this.PreviousSpecificationControl.Multiline = false;
            this.PreviousSpecificationControl.Name = "PreviousSpecificationControl";
            this.PreviousSpecificationControl.Size = new System.Drawing.Size(400, 50);
            this.PreviousSpecificationControl.TabIndex = 7;
            this.PreviousSpecificationControl.Text = "";
            this.PreviousSpecificationControl.TrailingIcon = null;
            // 
            // ProductParameterControl
            // 
            this.ProductParameterControl.AutoResize = false;
            this.ProductParameterControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductParameterControl.Depth = 0;
            this.ProductParameterControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ProductParameterControl.DropDownHeight = 174;
            this.ProductParameterControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductParameterControl.DropDownWidth = 121;
            this.ProductParameterControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProductParameterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductParameterControl.FormattingEnabled = true;
            this.ProductParameterControl.Hint = "Parameter";
            this.ProductParameterControl.IntegralHeight = false;
            this.ProductParameterControl.ItemHeight = 43;
            this.ProductParameterControl.Location = new System.Drawing.Point(25, 213);
            this.ProductParameterControl.MaxDropDownItems = 4;
            this.ProductParameterControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductParameterControl.Name = "ProductParameterControl";
            this.ProductParameterControl.Size = new System.Drawing.Size(400, 49);
            this.ProductParameterControl.StartIndex = -1;
            this.ProductParameterControl.TabIndex = 14;
            this.ProductParameterControl.SelectedIndexChanged += new System.EventHandler(this.ProductParameterControl_SelectedIndexChanged);
            // 
            // ProductErrorCaption
            // 
            this.ProductErrorCaption.AutoSize = true;
            this.ProductErrorCaption.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ProductErrorCaption.Location = new System.Drawing.Point(25, 177);
            this.ProductErrorCaption.Name = "ProductErrorCaption";
            this.ProductErrorCaption.Size = new System.Drawing.Size(0, 14);
            this.ProductErrorCaption.TabIndex = 20;
            // 
            // ParameterErrorControl
            // 
            this.ParameterErrorControl.AutoSize = true;
            this.ParameterErrorControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterErrorControl.ForeColor = System.Drawing.Color.Red;
            this.ParameterErrorControl.Location = new System.Drawing.Point(25, 265);
            this.ParameterErrorControl.Name = "ParameterErrorControl";
            this.ParameterErrorControl.Size = new System.Drawing.Size(0, 14);
            this.ParameterErrorControl.TabIndex = 21;
            // 
            // PreviousSpecificationErrorControl
            // 
            this.PreviousSpecificationErrorControl.AutoSize = true;
            this.PreviousSpecificationErrorControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreviousSpecificationErrorControl.ForeColor = System.Drawing.Color.Red;
            this.PreviousSpecificationErrorControl.Location = new System.Drawing.Point(25, 354);
            this.PreviousSpecificationErrorControl.Name = "PreviousSpecificationErrorControl";
            this.PreviousSpecificationErrorControl.Size = new System.Drawing.Size(0, 14);
            this.PreviousSpecificationErrorControl.TabIndex = 22;
            // 
            // NewSpecificationErrorControl
            // 
            this.NewSpecificationErrorControl.AutoSize = true;
            this.NewSpecificationErrorControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewSpecificationErrorControl.ForeColor = System.Drawing.Color.Red;
            this.NewSpecificationErrorControl.Location = new System.Drawing.Point(25, 443);
            this.NewSpecificationErrorControl.Name = "NewSpecificationErrorControl";
            this.NewSpecificationErrorControl.Size = new System.Drawing.Size(0, 14);
            this.NewSpecificationErrorControl.TabIndex = 23;
            // 
            // UpdateProductParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 570);
            this.Controls.Add(this.NewSpecificationErrorControl);
            this.Controls.Add(this.PreviousSpecificationErrorControl);
            this.Controls.Add(this.ParameterErrorControl);
            this.Controls.Add(this.ProductErrorCaption);
            this.Controls.Add(this.ProductParameterControl);
            this.Controls.Add(this.NewSpecificationControl);
            this.Controls.Add(this.ProductControl);
            this.Controls.Add(this.SaveParameterControl);
            this.Controls.Add(this.PreviousSpecificationControl);
            this.Name = "UpdateProductParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox NewSpecificationControl;
        private MaterialSkin.Controls.MaterialComboBox ProductControl;
        private MaterialSkin.Controls.MaterialButton SaveParameterControl;
        private MaterialSkin.Controls.MaterialTextBox PreviousSpecificationControl;
        private MaterialSkin.Controls.MaterialComboBox ProductParameterControl;
        private Label ProductErrorCaption;
        private Label ParameterErrorControl;
        private Label PreviousSpecificationErrorControl;
        private Label NewSpecificationErrorControl;
    }
}