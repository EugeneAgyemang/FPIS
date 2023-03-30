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
            this.ParameterControlLimitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.ParameterNameErrorCaption = new System.Windows.Forms.Label();
            this.ParameterUnitErrorCaption = new System.Windows.Forms.Label();
            this.ParameterControlLimitErrorCaption = new System.Windows.Forms.Label();
            this.ParameterWaterControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ParameterWaterErrorCaption = new System.Windows.Forms.Label();
            this.ParameterUnitControl = new MaterialSkin.Controls.MaterialTextBox();
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
            this.SaveParameterControl.Location = new System.Drawing.Point(218, 508);
            this.SaveParameterControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveParameterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveParameterControl.Name = "SaveParameterControl";
            this.SaveParameterControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveParameterControl.Size = new System.Drawing.Size(64, 36);
            this.SaveParameterControl.TabIndex = 4;
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
            // ParameterWaterControl
            // 
            this.ParameterWaterControl.AutoResize = false;
            this.ParameterWaterControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ParameterWaterControl.Depth = 0;
            this.ParameterWaterControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ParameterWaterControl.DropDownHeight = 174;
            this.ParameterWaterControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParameterWaterControl.DropDownWidth = 121;
            this.ParameterWaterControl.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterWaterControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParameterWaterControl.FormattingEnabled = true;
            this.ParameterWaterControl.Hint = "Water";
            this.ParameterWaterControl.IntegralHeight = false;
            this.ParameterWaterControl.ItemHeight = 43;
            this.ParameterWaterControl.Location = new System.Drawing.Point(50, 391);
            this.ParameterWaterControl.MaxDropDownItems = 4;
            this.ParameterWaterControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterWaterControl.Name = "ParameterWaterControl";
            this.ParameterWaterControl.Size = new System.Drawing.Size(400, 49);
            this.ParameterWaterControl.StartIndex = -1;
            this.ParameterWaterControl.TabIndex = 3;
            // 
            // ParameterWaterErrorCaption
            // 
            this.ParameterWaterErrorCaption.AutoSize = true;
            this.ParameterWaterErrorCaption.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterWaterErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ParameterWaterErrorCaption.Location = new System.Drawing.Point(52, 443);
            this.ParameterWaterErrorCaption.Name = "ParameterWaterErrorCaption";
            this.ParameterWaterErrorCaption.Size = new System.Drawing.Size(0, 14);
            this.ParameterWaterErrorCaption.TabIndex = 29;
            // 
            // ParameterUnitControl
            // 
            this.ParameterUnitControl.AnimateReadOnly = false;
            this.ParameterUnitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParameterUnitControl.Depth = 0;
            this.ParameterUnitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterUnitControl.Hint = "Unit";
            this.ParameterUnitControl.LeadingIcon = null;
            this.ParameterUnitControl.Location = new System.Drawing.Point(50, 214);
            this.ParameterUnitControl.MaxLength = 50;
            this.ParameterUnitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterUnitControl.Multiline = false;
            this.ParameterUnitControl.Name = "ParameterUnitControl";
            this.ParameterUnitControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterUnitControl.TabIndex = 1;
            this.ParameterUnitControl.Text = "";
            this.ParameterUnitControl.TrailingIcon = null;
            // 
            // CreateWaterParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 560);
            this.Controls.Add(this.ParameterUnitControl);
            this.Controls.Add(this.ParameterWaterErrorCaption);
            this.Controls.Add(this.ParameterWaterControl);
            this.Controls.Add(this.ParameterControlLimitErrorCaption);
            this.Controls.Add(this.ParameterUnitErrorCaption);
            this.Controls.Add(this.ParameterNameErrorCaption);
            this.Controls.Add(this.SaveParameterControl);
            this.Controls.Add(this.ParameterControlLimitControl);
            this.Controls.Add(this.ParameterNameControl);
            this.Name = "CreateWaterParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Water Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox ParameterNameControl;
        private MaterialSkin.Controls.MaterialTextBox ParameterControlLimitControl;
        private MaterialSkin.Controls.MaterialButton SaveParameterControl;
        private Label ParameterNameErrorCaption;
        private Label ParameterUnitErrorCaption;
        private Label ParameterControlLimitErrorCaption;
        private MaterialSkin.Controls.MaterialComboBox ParameterWaterControl;
        private Label ParameterWaterErrorCaption;
        private MaterialSkin.Controls.MaterialTextBox ParameterUnitControl;
    }
}