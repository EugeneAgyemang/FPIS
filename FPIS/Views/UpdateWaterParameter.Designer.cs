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
            this.NewControlLimitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.WaterControl = new MaterialSkin.Controls.MaterialComboBox();
            this.UpdateParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.PreviousControlLimitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.WaterErrorCaption = new System.Windows.Forms.Label();
            this.ParameterErrorControl = new System.Windows.Forms.Label();
            this.NewControlLimitErrorControl = new System.Windows.Forms.Label();
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
            this.WaterParameterControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WaterParameterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaterParameterControl.FormattingEnabled = true;
            this.WaterParameterControl.Hint = "Parameter";
            this.WaterParameterControl.IntegralHeight = false;
            this.WaterParameterControl.ItemHeight = 43;
            this.WaterParameterControl.Location = new System.Drawing.Point(25, 213);
            this.WaterParameterControl.MaxDropDownItems = 4;
            this.WaterParameterControl.MouseState = MaterialSkin.MouseState.OUT;
            this.WaterParameterControl.Name = "WaterParameterControl";
            this.WaterParameterControl.Size = new System.Drawing.Size(400, 49);
            this.WaterParameterControl.StartIndex = -1;
            this.WaterParameterControl.TabIndex = 19;
            this.WaterParameterControl.SelectedIndexChanged += new System.EventHandler(this.WaterParameterControl_SelectedIndexChanged);
            // 
            // NewControlLimitControl
            // 
            this.NewControlLimitControl.AnimateReadOnly = false;
            this.NewControlLimitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewControlLimitControl.Depth = 0;
            this.NewControlLimitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewControlLimitControl.Hint = "New Control Limit";
            this.NewControlLimitControl.LeadingIcon = null;
            this.NewControlLimitControl.Location = new System.Drawing.Point(25, 390);
            this.NewControlLimitControl.MaxLength = 50;
            this.NewControlLimitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.NewControlLimitControl.Multiline = false;
            this.NewControlLimitControl.Name = "NewControlLimitControl";
            this.NewControlLimitControl.Size = new System.Drawing.Size(400, 50);
            this.NewControlLimitControl.TabIndex = 16;
            this.NewControlLimitControl.Text = "";
            this.NewControlLimitControl.TrailingIcon = null;
            this.NewControlLimitControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewSpecificationControl_KeyPress);
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
            this.WaterControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WaterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaterControl.FormattingEnabled = true;
            this.WaterControl.Hint = "Water";
            this.WaterControl.IntegralHeight = false;
            this.WaterControl.ItemHeight = 43;
            this.WaterControl.Location = new System.Drawing.Point(25, 125);
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
            this.UpdateParameterControl.Location = new System.Drawing.Point(193, 508);
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
            // PreviousControlLimitControl
            // 
            this.PreviousControlLimitControl.AnimateReadOnly = false;
            this.PreviousControlLimitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousControlLimitControl.Depth = 0;
            this.PreviousControlLimitControl.Enabled = false;
            this.PreviousControlLimitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreviousControlLimitControl.Hint = "Previous Control Limit";
            this.PreviousControlLimitControl.LeadingIcon = null;
            this.PreviousControlLimitControl.Location = new System.Drawing.Point(25, 301);
            this.PreviousControlLimitControl.MaxLength = 50;
            this.PreviousControlLimitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.PreviousControlLimitControl.Multiline = false;
            this.PreviousControlLimitControl.Name = "PreviousControlLimitControl";
            this.PreviousControlLimitControl.Size = new System.Drawing.Size(400, 50);
            this.PreviousControlLimitControl.TabIndex = 15;
            this.PreviousControlLimitControl.Text = "";
            this.PreviousControlLimitControl.TrailingIcon = null;
            // 
            // WaterErrorCaption
            // 
            this.WaterErrorCaption.AutoSize = true;
            this.WaterErrorCaption.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.WaterErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.WaterErrorCaption.Location = new System.Drawing.Point(25, 177);
            this.WaterErrorCaption.Name = "WaterErrorCaption";
            this.WaterErrorCaption.Size = new System.Drawing.Size(0, 14);
            this.WaterErrorCaption.TabIndex = 21;
            // 
            // ParameterErrorControl
            // 
            this.ParameterErrorControl.AutoSize = true;
            this.ParameterErrorControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterErrorControl.ForeColor = System.Drawing.Color.Red;
            this.ParameterErrorControl.Location = new System.Drawing.Point(25, 265);
            this.ParameterErrorControl.Name = "ParameterErrorControl";
            this.ParameterErrorControl.Size = new System.Drawing.Size(0, 14);
            this.ParameterErrorControl.TabIndex = 22;
            // 
            // NewControlLimitErrorControl
            // 
            this.NewControlLimitErrorControl.AutoSize = true;
            this.NewControlLimitErrorControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewControlLimitErrorControl.ForeColor = System.Drawing.Color.Red;
            this.NewControlLimitErrorControl.Location = new System.Drawing.Point(25, 443);
            this.NewControlLimitErrorControl.Name = "NewControlLimitErrorControl";
            this.NewControlLimitErrorControl.Size = new System.Drawing.Size(0, 14);
            this.NewControlLimitErrorControl.TabIndex = 24;
            // 
            // UpdateWaterParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 570);
            this.Controls.Add(this.NewControlLimitErrorControl);
            this.Controls.Add(this.ParameterErrorControl);
            this.Controls.Add(this.WaterErrorCaption);
            this.Controls.Add(this.WaterParameterControl);
            this.Controls.Add(this.NewControlLimitControl);
            this.Controls.Add(this.WaterControl);
            this.Controls.Add(this.UpdateParameterControl);
            this.Controls.Add(this.PreviousControlLimitControl);
            this.Name = "UpdateWaterParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Water Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox WaterParameterControl;
        private MaterialSkin.Controls.MaterialTextBox NewControlLimitControl;
        private MaterialSkin.Controls.MaterialComboBox WaterControl;
        private MaterialSkin.Controls.MaterialButton UpdateParameterControl;
        private MaterialSkin.Controls.MaterialTextBox PreviousControlLimitControl;
        private Label WaterErrorCaption;
        private Label ParameterErrorControl;
        private Label NewControlLimitErrorControl;
    }
}