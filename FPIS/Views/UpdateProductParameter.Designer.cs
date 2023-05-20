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
            this.maximumSpecificationControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductControl = new MaterialSkin.Controls.MaterialComboBox();
            this.SaveParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.minimumSpecificationControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ProductParameterControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ProductErrorCaption = new System.Windows.Forms.Label();
            this.ParameterErrorControl = new System.Windows.Forms.Label();
            this.PreviousSpecificationErrorControl = new System.Windows.Forms.Label();
            this.NewSpecificationErrorControl = new System.Windows.Forms.Label();
            this.unitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.methodControl = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // maximumSpecificationControl
            // 
            this.maximumSpecificationControl.AnimateReadOnly = false;
            this.maximumSpecificationControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maximumSpecificationControl.Depth = 0;
            this.maximumSpecificationControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maximumSpecificationControl.Hint = "Maximum Specification";
            this.maximumSpecificationControl.LeadingIcon = null;
            this.maximumSpecificationControl.Location = new System.Drawing.Point(29, 746);
            this.maximumSpecificationControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximumSpecificationControl.MaxLength = 50;
            this.maximumSpecificationControl.MouseState = MaterialSkin.MouseState.OUT;
            this.maximumSpecificationControl.Multiline = false;
            this.maximumSpecificationControl.Name = "maximumSpecificationControl";
            this.maximumSpecificationControl.Size = new System.Drawing.Size(457, 50);
            this.maximumSpecificationControl.TabIndex = 8;
            this.maximumSpecificationControl.Text = "";
            this.maximumSpecificationControl.TrailingIcon = null;
            this.maximumSpecificationControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewSpecificationControl_KeyPress);
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
            this.ProductControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProductControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductControl.FormattingEnabled = true;
            this.ProductControl.Hint = "Product";
            this.ProductControl.IntegralHeight = false;
            this.ProductControl.ItemHeight = 43;
            this.ProductControl.Location = new System.Drawing.Point(29, 167);
            this.ProductControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductControl.MaxDropDownItems = 4;
            this.ProductControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductControl.Name = "ProductControl";
            this.ProductControl.Size = new System.Drawing.Size(457, 49);
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
            this.SaveParameterControl.Location = new System.Drawing.Point(221, 873);
            this.SaveParameterControl.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
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
            // minimumSpecificationControl
            // 
            this.minimumSpecificationControl.AnimateReadOnly = false;
            this.minimumSpecificationControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minimumSpecificationControl.Depth = 0;
            this.minimumSpecificationControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.minimumSpecificationControl.Hint = "Minimum Specification";
            this.minimumSpecificationControl.LeadingIcon = null;
            this.minimumSpecificationControl.Location = new System.Drawing.Point(29, 627);
            this.minimumSpecificationControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimumSpecificationControl.MaxLength = 50;
            this.minimumSpecificationControl.MouseState = MaterialSkin.MouseState.OUT;
            this.minimumSpecificationControl.Multiline = false;
            this.minimumSpecificationControl.Name = "minimumSpecificationControl";
            this.minimumSpecificationControl.Size = new System.Drawing.Size(457, 50);
            this.minimumSpecificationControl.TabIndex = 7;
            this.minimumSpecificationControl.Text = "";
            this.minimumSpecificationControl.TrailingIcon = null;
            this.minimumSpecificationControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minimumSpecificationControl_KeyPress);
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
            this.ProductParameterControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ProductParameterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProductParameterControl.FormattingEnabled = true;
            this.ProductParameterControl.Hint = "Parameter";
            this.ProductParameterControl.IntegralHeight = false;
            this.ProductParameterControl.ItemHeight = 43;
            this.ProductParameterControl.Location = new System.Drawing.Point(29, 284);
            this.ProductParameterControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductParameterControl.MaxDropDownItems = 4;
            this.ProductParameterControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ProductParameterControl.Name = "ProductParameterControl";
            this.ProductParameterControl.Size = new System.Drawing.Size(457, 49);
            this.ProductParameterControl.StartIndex = -1;
            this.ProductParameterControl.TabIndex = 14;
            this.ProductParameterControl.SelectedIndexChanged += new System.EventHandler(this.ProductParameterControl_SelectedIndexChanged);
            // 
            // ProductErrorCaption
            // 
            this.ProductErrorCaption.AutoSize = true;
            this.ProductErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ProductErrorCaption.Location = new System.Drawing.Point(29, 223);
            this.ProductErrorCaption.Name = "ProductErrorCaption";
            this.ProductErrorCaption.Size = new System.Drawing.Size(0, 16);
            this.ProductErrorCaption.TabIndex = 20;
            // 
            // ParameterErrorControl
            // 
            this.ParameterErrorControl.AutoSize = true;
            this.ParameterErrorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterErrorControl.ForeColor = System.Drawing.Color.Red;
            this.ParameterErrorControl.Location = new System.Drawing.Point(29, 339);
            this.ParameterErrorControl.Name = "ParameterErrorControl";
            this.ParameterErrorControl.Size = new System.Drawing.Size(0, 16);
            this.ParameterErrorControl.TabIndex = 21;
            // 
            // PreviousSpecificationErrorControl
            // 
            this.PreviousSpecificationErrorControl.AutoSize = true;
            this.PreviousSpecificationErrorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreviousSpecificationErrorControl.ForeColor = System.Drawing.Color.Red;
            this.PreviousSpecificationErrorControl.Location = new System.Drawing.Point(32, 683);
            this.PreviousSpecificationErrorControl.Name = "PreviousSpecificationErrorControl";
            this.PreviousSpecificationErrorControl.Size = new System.Drawing.Size(0, 16);
            this.PreviousSpecificationErrorControl.TabIndex = 22;
            // 
            // NewSpecificationErrorControl
            // 
            this.NewSpecificationErrorControl.AutoSize = true;
            this.NewSpecificationErrorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewSpecificationErrorControl.ForeColor = System.Drawing.Color.Red;
            this.NewSpecificationErrorControl.Location = new System.Drawing.Point(29, 802);
            this.NewSpecificationErrorControl.Name = "NewSpecificationErrorControl";
            this.NewSpecificationErrorControl.Size = new System.Drawing.Size(0, 16);
            this.NewSpecificationErrorControl.TabIndex = 23;
            // 
            // unitControl
            // 
            this.unitControl.AnimateReadOnly = false;
            this.unitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitControl.Depth = 0;
            this.unitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.unitControl.Hint = "Unit";
            this.unitControl.LeadingIcon = null;
            this.unitControl.Location = new System.Drawing.Point(29, 510);
            this.unitControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitControl.MaxLength = 50;
            this.unitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.unitControl.Multiline = false;
            this.unitControl.Name = "unitControl";
            this.unitControl.Size = new System.Drawing.Size(457, 50);
            this.unitControl.TabIndex = 25;
            this.unitControl.Text = "";
            this.unitControl.TrailingIcon = null;
            // 
            // methodControl
            // 
            this.methodControl.AnimateReadOnly = false;
            this.methodControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.methodControl.Depth = 0;
            this.methodControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.methodControl.Hint = "Method";
            this.methodControl.LeadingIcon = null;
            this.methodControl.Location = new System.Drawing.Point(29, 396);
            this.methodControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.methodControl.MaxLength = 50;
            this.methodControl.MouseState = MaterialSkin.MouseState.OUT;
            this.methodControl.Multiline = false;
            this.methodControl.Name = "methodControl";
            this.methodControl.Size = new System.Drawing.Size(457, 50);
            this.methodControl.TabIndex = 24;
            this.methodControl.Text = "";
            this.methodControl.TrailingIcon = null;
            // 
            // UpdateProductParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 960);
            this.Controls.Add(this.unitControl);
            this.Controls.Add(this.methodControl);
            this.Controls.Add(this.NewSpecificationErrorControl);
            this.Controls.Add(this.PreviousSpecificationErrorControl);
            this.Controls.Add(this.ParameterErrorControl);
            this.Controls.Add(this.ProductErrorCaption);
            this.Controls.Add(this.ProductParameterControl);
            this.Controls.Add(this.maximumSpecificationControl);
            this.Controls.Add(this.ProductControl);
            this.Controls.Add(this.SaveParameterControl);
            this.Controls.Add(this.minimumSpecificationControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateProductParameter";
            this.Padding = new System.Windows.Forms.Padding(3, 85, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox maximumSpecificationControl;
        private MaterialSkin.Controls.MaterialComboBox ProductControl;
        private MaterialSkin.Controls.MaterialButton SaveParameterControl;
        private MaterialSkin.Controls.MaterialTextBox minimumSpecificationControl;
        private MaterialSkin.Controls.MaterialComboBox ProductParameterControl;
        private Label ProductErrorCaption;
        private Label ParameterErrorControl;
        private Label PreviousSpecificationErrorControl;
        private Label NewSpecificationErrorControl;
        private MaterialSkin.Controls.MaterialTextBox unitControl;
        private MaterialSkin.Controls.MaterialTextBox methodControl;
    }
}