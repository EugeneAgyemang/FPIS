namespace FPIS.Views
{
    partial class CreateProductParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductParameter));
            this.ParameterNameControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ParameterMethodControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ParameterSpecificationControl = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveParameterControl = new MaterialSkin.Controls.MaterialButton();
            this.ParameterNameErrorCaption = new System.Windows.Forms.Label();
            this.ParameterMethodErrorCaption = new System.Windows.Forms.Label();
            this.ParameterUnitErrorCaption = new System.Windows.Forms.Label();
            this.ParameterSpecificationErrorCaption = new System.Windows.Forms.Label();
            this.ParameterProductControl = new MaterialSkin.Controls.MaterialComboBox();
            this.ParameterProductErrorCaption = new System.Windows.Forms.Label();
            this.ParameterUnitControl = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxMinimumSpecification = new MaterialSkin.Controls.MaterialTextBox();
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
            this.ParameterNameControl.Location = new System.Drawing.Point(25, 125);
            this.ParameterNameControl.MaxLength = 50;
            this.ParameterNameControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterNameControl.Multiline = false;
            this.ParameterNameControl.Name = "ParameterNameControl";
            this.ParameterNameControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterNameControl.TabIndex = 0;
            this.ParameterNameControl.Text = "";
            this.ParameterNameControl.TrailingIcon = null;
            // 
            // ParameterMethodControl
            // 
            this.ParameterMethodControl.AnimateReadOnly = false;
            this.ParameterMethodControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParameterMethodControl.Depth = 0;
            this.ParameterMethodControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterMethodControl.Hint = "Method";
            this.ParameterMethodControl.LeadingIcon = null;
            this.ParameterMethodControl.Location = new System.Drawing.Point(25, 214);
            this.ParameterMethodControl.MaxLength = 50;
            this.ParameterMethodControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterMethodControl.Multiline = false;
            this.ParameterMethodControl.Name = "ParameterMethodControl";
            this.ParameterMethodControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterMethodControl.TabIndex = 1;
            this.ParameterMethodControl.Text = "";
            this.ParameterMethodControl.TrailingIcon = null;
            // 
            // ParameterSpecificationControl
            // 
            this.ParameterSpecificationControl.AnimateReadOnly = false;
            this.ParameterSpecificationControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParameterSpecificationControl.Depth = 0;
            this.ParameterSpecificationControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterSpecificationControl.Hint = "Maximum Specification";
            this.ParameterSpecificationControl.LeadingIcon = null;
            this.ParameterSpecificationControl.Location = new System.Drawing.Point(25, 478);
            this.ParameterSpecificationControl.MaxLength = 50;
            this.ParameterSpecificationControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterSpecificationControl.Multiline = false;
            this.ParameterSpecificationControl.Name = "ParameterSpecificationControl";
            this.ParameterSpecificationControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterSpecificationControl.TabIndex = 3;
            this.ParameterSpecificationControl.Text = "";
            this.ParameterSpecificationControl.TrailingIcon = null;
            this.ParameterSpecificationControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParameterSpecificationControl_KeyPress);
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
            this.SaveParameterControl.Location = new System.Drawing.Point(193, 643);
            this.SaveParameterControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveParameterControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveParameterControl.Name = "SaveParameterControl";
            this.SaveParameterControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveParameterControl.Size = new System.Drawing.Size(64, 36);
            this.SaveParameterControl.TabIndex = 5;
            this.SaveParameterControl.Text = "Save";
            this.SaveParameterControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveParameterControl.UseAccentColor = true;
            this.SaveParameterControl.UseVisualStyleBackColor = true;
            this.SaveParameterControl.Click += new System.EventHandler(this.SaveParameterControl_Click);
            // 
            // ParameterNameErrorCaption
            // 
            this.ParameterNameErrorCaption.AutoSize = true;
            this.ParameterNameErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterNameErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ParameterNameErrorCaption.Location = new System.Drawing.Point(25, 178);
            this.ParameterNameErrorCaption.Name = "ParameterNameErrorCaption";
            this.ParameterNameErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ParameterNameErrorCaption.TabIndex = 19;
            // 
            // ParameterMethodErrorCaption
            // 
            this.ParameterMethodErrorCaption.AutoSize = true;
            this.ParameterMethodErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterMethodErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ParameterMethodErrorCaption.Location = new System.Drawing.Point(25, 267);
            this.ParameterMethodErrorCaption.Name = "ParameterMethodErrorCaption";
            this.ParameterMethodErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ParameterMethodErrorCaption.TabIndex = 20;
            // 
            // ParameterUnitErrorCaption
            // 
            this.ParameterUnitErrorCaption.AutoSize = true;
            this.ParameterUnitErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterUnitErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ParameterUnitErrorCaption.Location = new System.Drawing.Point(25, 355);
            this.ParameterUnitErrorCaption.Name = "ParameterUnitErrorCaption";
            this.ParameterUnitErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ParameterUnitErrorCaption.TabIndex = 21;
            // 
            // ParameterSpecificationErrorCaption
            // 
            this.ParameterSpecificationErrorCaption.AutoSize = true;
            this.ParameterSpecificationErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterSpecificationErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ParameterSpecificationErrorCaption.Location = new System.Drawing.Point(25, 532);
            this.ParameterSpecificationErrorCaption.Name = "ParameterSpecificationErrorCaption";
            this.ParameterSpecificationErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ParameterSpecificationErrorCaption.TabIndex = 22;
            // 
            // ParameterProductControl
            // 
            this.ParameterProductControl.AutoResize = false;
            this.ParameterProductControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ParameterProductControl.Depth = 0;
            this.ParameterProductControl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ParameterProductControl.DropDownHeight = 174;
            this.ParameterProductControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParameterProductControl.DropDownWidth = 121;
            this.ParameterProductControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterProductControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParameterProductControl.FormattingEnabled = true;
            this.ParameterProductControl.Hint = "Product";
            this.ParameterProductControl.IntegralHeight = false;
            this.ParameterProductControl.ItemHeight = 43;
            this.ParameterProductControl.Location = new System.Drawing.Point(25, 567);
            this.ParameterProductControl.MaxDropDownItems = 4;
            this.ParameterProductControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterProductControl.Name = "ParameterProductControl";
            this.ParameterProductControl.Size = new System.Drawing.Size(400, 49);
            this.ParameterProductControl.StartIndex = -1;
            this.ParameterProductControl.TabIndex = 4;
            // 
            // ParameterProductErrorCaption
            // 
            this.ParameterProductErrorCaption.AutoSize = true;
            this.ParameterProductErrorCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterProductErrorCaption.ForeColor = System.Drawing.Color.Red;
            this.ParameterProductErrorCaption.Location = new System.Drawing.Point(25, 622);
            this.ParameterProductErrorCaption.Name = "ParameterProductErrorCaption";
            this.ParameterProductErrorCaption.Size = new System.Drawing.Size(0, 15);
            this.ParameterProductErrorCaption.TabIndex = 25;
            // 
            // ParameterUnitControl
            // 
            this.ParameterUnitControl.AnimateReadOnly = false;
            this.ParameterUnitControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParameterUnitControl.Depth = 0;
            this.ParameterUnitControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParameterUnitControl.Hint = "Unit";
            this.ParameterUnitControl.LeadingIcon = null;
            this.ParameterUnitControl.Location = new System.Drawing.Point(25, 303);
            this.ParameterUnitControl.MaxLength = 50;
            this.ParameterUnitControl.MouseState = MaterialSkin.MouseState.OUT;
            this.ParameterUnitControl.Multiline = false;
            this.ParameterUnitControl.Name = "ParameterUnitControl";
            this.ParameterUnitControl.Size = new System.Drawing.Size(400, 50);
            this.ParameterUnitControl.TabIndex = 2;
            this.ParameterUnitControl.Text = "";
            this.ParameterUnitControl.TrailingIcon = null;
            // 
            // materialTextBoxMinimumSpecification
            // 
            this.materialTextBoxMinimumSpecification.AnimateReadOnly = false;
            this.materialTextBoxMinimumSpecification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxMinimumSpecification.Depth = 0;
            this.materialTextBoxMinimumSpecification.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxMinimumSpecification.Hint = "Minimum Specification (Optional)";
            this.materialTextBoxMinimumSpecification.LeadingIcon = null;
            this.materialTextBoxMinimumSpecification.Location = new System.Drawing.Point(25, 390);
            this.materialTextBoxMinimumSpecification.MaxLength = 50;
            this.materialTextBoxMinimumSpecification.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxMinimumSpecification.Multiline = false;
            this.materialTextBoxMinimumSpecification.Name = "materialTextBoxMinimumSpecification";
            this.materialTextBoxMinimumSpecification.Size = new System.Drawing.Size(400, 50);
            this.materialTextBoxMinimumSpecification.TabIndex = 26;
            this.materialTextBoxMinimumSpecification.Text = "";
            this.materialTextBoxMinimumSpecification.TrailingIcon = null;
            this.materialTextBoxMinimumSpecification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxMinimumSpecification_KeyPress);
            // 
            // CreateProductParameter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.materialTextBoxMinimumSpecification);
            this.Controls.Add(this.ParameterUnitControl);
            this.Controls.Add(this.ParameterProductErrorCaption);
            this.Controls.Add(this.ParameterProductControl);
            this.Controls.Add(this.ParameterSpecificationErrorCaption);
            this.Controls.Add(this.ParameterUnitErrorCaption);
            this.Controls.Add(this.ParameterMethodErrorCaption);
            this.Controls.Add(this.ParameterNameErrorCaption);
            this.Controls.Add(this.SaveParameterControl);
            this.Controls.Add(this.ParameterSpecificationControl);
            this.Controls.Add(this.ParameterMethodControl);
            this.Controls.Add(this.ParameterNameControl);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateProductParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Product Parameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox ParameterNameControl;
        private MaterialSkin.Controls.MaterialTextBox ParameterMethodControl;
        private MaterialSkin.Controls.MaterialTextBox ParameterSpecificationControl;
        private MaterialSkin.Controls.MaterialButton SaveParameterControl;
        private Label ParameterNameErrorCaption;
        private Label ParameterMethodErrorCaption;
        private Label ParameterUnitErrorCaption;
        private Label ParameterSpecificationErrorCaption;
        private MaterialSkin.Controls.MaterialComboBox ParameterProductControl;
        private Label ParameterProductErrorCaption;
        private MaterialSkin.Controls.MaterialTextBox ParameterUnitControl;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxMinimumSpecification;
    }
}