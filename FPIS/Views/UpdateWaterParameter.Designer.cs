namespace FPIS.Views
{
    partial class UpdateWaterParameter
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
            this.WaterParameterControl = new MaterialSkin.Controls.MaterialComboBox();
            this.minimumControlLimitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.WaterControl = new MaterialSkin.Controls.MaterialComboBox();
            this.UpdateParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.unitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.WaterErrorCaption = new System.Windows.Forms.Label();
            this.ParameterErrorControl = new System.Windows.Forms.Label();
            this.maximumControlLimitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // WaterParameterControl
            // 
            this.WaterParameterControl.AutoResize = false;
            this.WaterParameterControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WaterParameterControl.Depth = 0;
            this.WaterParameterControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WaterParameterControl.DropDownHeight = 174;
            this.WaterParameterControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WaterParameterControl.DropDownWidth = 121;
            this.WaterParameterControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WaterParameterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaterParameterControl.FormattingEnabled = true;
            this.WaterParameterControl.Hint = "Parameter";
            this.WaterParameterControl.IntegralHeight = false;
            this.WaterParameterControl.ItemHeight = 43;
            this.WaterParameterControl.Location = new System.Drawing.Point(25, 188);
            this.WaterParameterControl.MaxDropDownItems = 4;
            this.WaterParameterControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WaterParameterControl.Name = "WaterParameterControl";
            this.WaterParameterControl.Size = new System.Drawing.Size(400, 49);
            this.WaterParameterControl.StartIndex = -1;
            this.WaterParameterControl.TabIndex = 19;
            this.WaterParameterControl.SelectedIndexChanged += new System.EventHandler(this.WaterParameterControl_SelectedIndexChanged);
            // 
            // minimumControlLimitControl
            // 
            this.minimumControlLimitControl.AnimateReadOnly = false;
            this.minimumControlLimitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minimumControlLimitControl.Depth = 0;
            this.minimumControlLimitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.minimumControlLimitControl.Hint = "Minimum Control Limit";
            this.minimumControlLimitControl.LeadingIcon = null;
            this.minimumControlLimitControl.Location = new System.Drawing.Point(25, 365);
            this.minimumControlLimitControl.MaxLength = 50;
            this.minimumControlLimitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.minimumControlLimitControl.Multiline = false;
            this.minimumControlLimitControl.Name = "minimumControlLimitControl";
            this.minimumControlLimitControl.Size = new System.Drawing.Size(400, 50);
            this.minimumControlLimitControl.TabIndex = 16;
            this.minimumControlLimitControl.Text = "";
            this.minimumControlLimitControl.TrailingIcon = null;
            this.minimumControlLimitControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewSpecificationControl_KeyPress);
            // 
            // WaterControl
            // 
            this.WaterControl.AutoResize = false;
            this.WaterControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WaterControl.Depth = 0;
            this.WaterControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WaterControl.DropDownHeight = 174;
            this.WaterControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WaterControl.DropDownWidth = 121;
            this.WaterControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WaterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaterControl.FormattingEnabled = true;
            this.WaterControl.Hint = "Water";
            this.WaterControl.IntegralHeight = false;
            this.WaterControl.ItemHeight = 43;
            this.WaterControl.Location = new System.Drawing.Point(25, 100);
            this.WaterControl.MaxDropDownItems = 4;
            this.WaterControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WaterControl.Name = "WaterControl";
            this.WaterControl.Size = new System.Drawing.Size(400, 49);
            this.WaterControl.StartIndex = -1;
            this.WaterControl.TabIndex = 17;
            this.WaterControl.SelectedIndexChanged += new System.EventHandler(this.WaterControl_SelectedIndexChanged);
            // 
            // UpdateParameterControl
            // 
            this.UpdateParameterControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateParameterControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.UpdateParameterControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateParameterControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateParameterControl.Depth = 0;
            this.UpdateParameterControl.HighEmphasis = true;
            this.UpdateParameterControl.Icon = null;
            this.UpdateParameterControl.Location = new System.Drawing.Point(193, 519);
            this.UpdateParameterControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateParameterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateParameterControl.Name = "UpdateParameterControl";
            this.UpdateParameterControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateParameterControl.Size = new System.Drawing.Size(77, 36);
            this.UpdateParameterControl.TabIndex = 18;
            this.UpdateParameterControl.Text = "Update";
            this.UpdateParameterControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateParameterControl.UseAccentColor = true;
            this.UpdateParameterControl.UseVisualStyleBackColor = true;
            this.UpdateParameterControl.Click += new System.EventHandler(this.SaveParameterControl_Click);
            // 
            // unitControl
            // 
            this.unitControl.AnimateReadOnly = false;
            this.unitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitControl.Depth = 0;
            this.unitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.unitControl.Hint = "Unit";
            this.unitControl.LeadingIcon = null;
            this.unitControl.Location = new System.Drawing.Point(25, 276);
            this.unitControl.MaxLength = 50;
            this.unitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.unitControl.Multiline = false;
            this.unitControl.Name = "unitControl";
            this.unitControl.Size = new System.Drawing.Size(400, 50);
            this.unitControl.TabIndex = 15;
            this.unitControl.Text = "";
            this.unitControl.TrailingIcon = null;
            // 
            // WaterErrorCaption
            // 
            this.WaterErrorCaption.AutoSize = true;
            this.WaterErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WaterErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.WaterErrorCaption.Location = new System.Drawing.Point(25, 152);
            this.WaterErrorCaption.Name = "WaterErrorCaption";
            this.WaterErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.WaterErrorCaption.TabIndex = 21;
            // 
            // ParameterErrorControl
            // 
            this.ParameterErrorControl.AutoSize = true;
            this.ParameterErrorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterErrorControl.ForeColor = System.Drawing.Color.Red;
            this.ParameterErrorControl.Location = new System.Drawing.Point(25, 240);
            this.ParameterErrorControl.Name = "ParameterErrorControl";
            this.ParameterErrorControl.Size = new System.Drawing.Size(0, 15);
            this.ParameterErrorControl.TabIndex = 22;
            // 
            // maximumControlLimitControl
            // 
            this.maximumControlLimitControl.AnimateReadOnly = false;
            this.maximumControlLimitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maximumControlLimitControl.Depth = 0;
            this.maximumControlLimitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maximumControlLimitControl.Hint = "Maximum Control Limit";
            this.maximumControlLimitControl.LeadingIcon = null;
            this.maximumControlLimitControl.Location = new System.Drawing.Point(25, 453);
            this.maximumControlLimitControl.MaxLength = 50;
            this.maximumControlLimitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.maximumControlLimitControl.Multiline = false;
            this.maximumControlLimitControl.Name = "maximumControlLimitControl";
            this.maximumControlLimitControl.Size = new System.Drawing.Size(400, 50);
            this.maximumControlLimitControl.TabIndex = 25;
            this.maximumControlLimitControl.Text = "";
            this.maximumControlLimitControl.TrailingIcon = null;
            this.maximumControlLimitControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maximumControlLimitControl_KeyPress);
            // 
            // UpdateWaterParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 580);
            this.Controls.Add(this.maximumControlLimitControl);
            this.Controls.Add(this.ParameterErrorControl);
            this.Controls.Add(this.WaterErrorCaption);
            this.Controls.Add(this.WaterParameterControl);
            this.Controls.Add(this.minimumControlLimitControl);
            this.Controls.Add(this.WaterControl);
            this.Controls.Add(this.UpdateParameterControl);
            this.Controls.Add(this.unitControl);
            this.Name = "UpdateWaterParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Water Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox WaterParameterControl;
        private MaterialSkin.Controls.MaterialTextBox minimumControlLimitControl;
        private MaterialSkin.Controls.MaterialComboBox WaterControl;
        private MaterialSkin.Controls.MaterialButton UpdateParameterControl;
        private MaterialSkin.Controls.MaterialTextBox unitControl;
        private Label WaterErrorCaption;
        private Label ParameterErrorControl;
        private MaterialSkin.Controls.MaterialTextBox maximumControlLimitControl;
    }
}