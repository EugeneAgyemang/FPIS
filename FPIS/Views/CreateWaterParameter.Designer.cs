namespace FPIS.Views
{
    partial class CreateWaterParameter
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
            this.ParameterNameControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ParameterUnitControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ParameterControlLimitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.ParameterNameErrorCaption = new System.Windows.Forms.Label();
            this.ParameterUnitErrorCaption = new System.Windows.Forms.Label();
            this.ParameterControlLimitErrorCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParameterNameControl
            // 
            this.ParameterNameControl.AnimateReadOnly = false;
            this.ParameterNameControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParameterNameControl.Depth = 0;
            this.ParameterNameControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterNameControl.Hint = "Parameter name";
            this.ParameterNameControl.LeadingIcon = null;
            this.ParameterNameControl.Location = new System.Drawing.Point(50, 125);
            this.ParameterNameControl.MaxLength = 50;
            this.ParameterNameControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterNameControl.Multiline = false;
            this.ParameterNameControl.Name = "ParameterNameControl";
            this.ParameterNameControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterNameControl.TabIndex = 0;
            this.ParameterNameControl.Text = "";
            this.ParameterNameControl.TrailingIcon = null;
            // 
            // ParameterUnitControl
            // 
            this.ParameterUnitControl.AutoResize = false;
            this.ParameterUnitControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ParameterUnitControl.Depth = 0;
            this.ParameterUnitControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ParameterUnitControl.DropDownHeight = 174;
            this.ParameterUnitControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParameterUnitControl.DropDownWidth = 121;
            this.ParameterUnitControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterUnitControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParameterUnitControl.FormattingEnabled = true;
            this.ParameterUnitControl.Hint = "Unit";
            this.ParameterUnitControl.IntegralHeight = false;
            this.ParameterUnitControl.ItemHeight = 43;
            this.ParameterUnitControl.Items.AddRange(new object[] {
            "cm",
            "inch",
            "ltr",
            "m"});
            this.ParameterUnitControl.Location = new System.Drawing.Point(50, 214);
            this.ParameterUnitControl.MaxDropDownItems = 4;
            this.ParameterUnitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterUnitControl.Name = "ParameterUnitControl";
            this.ParameterUnitControl.Size = new System.Drawing.Size(400, 49);
            this.ParameterUnitControl.Sorted = true;
            this.ParameterUnitControl.StartIndex = -1;
            this.ParameterUnitControl.TabIndex = 1;
            // 
            // ParameterControlLimitControl
            // 
            this.ParameterControlLimitControl.AnimateReadOnly = false;
            this.ParameterControlLimitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParameterControlLimitControl.Depth = 0;
            this.ParameterControlLimitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterControlLimitControl.Hint = "Control limit";
            this.ParameterControlLimitControl.LeadingIcon = null;
            this.ParameterControlLimitControl.Location = new System.Drawing.Point(50, 302);
            this.ParameterControlLimitControl.MaxLength = 50;
            this.ParameterControlLimitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterControlLimitControl.Multiline = false;
            this.ParameterControlLimitControl.Name = "ParameterControlLimitControl";
            this.ParameterControlLimitControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterControlLimitControl.TabIndex = 2;
            this.ParameterControlLimitControl.Text = "";
            this.ParameterControlLimitControl.TrailingIcon = null;
            this.ParameterControlLimitControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParameterControlLimitControl_KeyPress);
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
            this.SaveParameterControl.Location = new System.Drawing.Point(218, 420);
            this.SaveParameterControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveParameterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveParameterControl.Name = "SaveParameterControl";
            this.SaveParameterControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveParameterControl.Size = new System.Drawing.Size(64, 36);
            this.SaveParameterControl.TabIndex = 3;
            this.SaveParameterControl.Text = "Save";
            this.SaveParameterControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveParameterControl.UseAccentColor = true;
            this.SaveParameterControl.UseVisualStyleBackColor = true;
            this.SaveParameterControl.Click += new System.EventHandler(this.SaveParameterControl_Click);
            // 
            // ParameterNameErrorCaption
            // 
            this.ParameterNameErrorCaption.AutoSize = true;
            this.ParameterNameErrorCaption.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterNameErrorCaption.Location = new System.Drawing.Point(50, 178);
            this.ParameterNameErrorCaption.Name = "ParameterNameErrorCaption";
            this.ParameterNameErrorCaption.Size = new System.Drawing.Size(0, 14);
            this.ParameterNameErrorCaption.TabIndex = 18;
            // 
            // ParameterUnitErrorCaption
            // 
            this.ParameterUnitErrorCaption.AutoSize = true;
            this.ParameterUnitErrorCaption.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterUnitErrorCaption.Location = new System.Drawing.Point(50, 266);
            this.ParameterUnitErrorCaption.Name = "ParameterUnitErrorCaption";
            this.ParameterUnitErrorCaption.Size = new System.Drawing.Size(0, 14);
            this.ParameterUnitErrorCaption.TabIndex = 19;
            // 
            // ParameterControlLimitErrorCaption
            // 
            this.ParameterControlLimitErrorCaption.AutoSize = true;
            this.ParameterControlLimitErrorCaption.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterControlLimitErrorCaption.Location = new System.Drawing.Point(52, 355);
            this.ParameterControlLimitErrorCaption.Name = "ParameterControlLimitErrorCaption";
            this.ParameterControlLimitErrorCaption.Size = new System.Drawing.Size(0, 14);
            this.ParameterControlLimitErrorCaption.TabIndex = 20;
            // 
            // CreateWaterParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 490);
            this.Controls.Add(this.ParameterControlLimitErrorCaption);
            this.Controls.Add(this.ParameterUnitErrorCaption);
            this.Controls.Add(this.ParameterNameErrorCaption);
            this.Controls.Add(this.SaveParameterControl);
            this.Controls.Add(this.ParameterControlLimitControl);
            this.Controls.Add(this.ParameterUnitControl);
            this.Controls.Add(this.ParameterNameControl);
            this.Name = "CreateWaterParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Water Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox ParameterNameControl;
        private MaterialSkin.Controls.MaterialComboBox ParameterUnitControl;
        private MaterialSkin.Controls.MaterialTextBox ParameterControlLimitControl;
        private MaterialSkin.Controls.MaterialButton SaveParameterControl;
        private Label ParameterNameErrorCaption;
        private Label ParameterUnitErrorCaption;
        private Label ParameterControlLimitErrorCaption;
    }
}