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
            ParameterNameControl = new MaterialSkin.Controls.MaterialTextBox();
            ParameterMethodControl = new MaterialSkin.Controls.MaterialTextBox();
            ParameterSpecificationControl = new MaterialSkin.Controls.MaterialTextBox();
            SaveParameterControl = new MaterialSkin.Controls.MaterialButton();
            ParameterNameErrorCaption = new Label();
            ParameterMethodErrorCaption = new Label();
            ParameterUnitErrorCaption = new Label();
            ParameterSpecificationErrorCaption = new Label();
            ParameterProductControl = new MaterialSkin.Controls.MaterialComboBox();
            ParameterProductErrorCaption = new Label();
            ParameterUnitControl = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxMinimumSpecification = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // ParameterNameControl
            // 
            ParameterNameControl.AnimateReadOnly = false;
            ParameterNameControl.BorderStyle = BorderStyle.None;
            ParameterNameControl.Depth = 0;
            ParameterNameControl.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterNameControl.Hint = "Parameter name";
            ParameterNameControl.LeadingIcon = null;
            ParameterNameControl.Location = new Point(25, 125);
            ParameterNameControl.MaxLength = 50;
            ParameterNameControl.MouseState = MaterialSkin.MouseState.OUT;
            ParameterNameControl.Multiline = false;
            ParameterNameControl.Name = "ParameterNameControl";
            ParameterNameControl.Size = new Size(400, 50);
            ParameterNameControl.TabIndex = 0;
            ParameterNameControl.Text = "";
            ParameterNameControl.TrailingIcon = null;
            // 
            // ParameterMethodControl
            // 
            ParameterMethodControl.AnimateReadOnly = false;
            ParameterMethodControl.BorderStyle = BorderStyle.None;
            ParameterMethodControl.Depth = 0;
            ParameterMethodControl.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterMethodControl.Hint = "Method";
            ParameterMethodControl.LeadingIcon = null;
            ParameterMethodControl.Location = new Point(25, 214);
            ParameterMethodControl.MaxLength = 50;
            ParameterMethodControl.MouseState = MaterialSkin.MouseState.OUT;
            ParameterMethodControl.Multiline = false;
            ParameterMethodControl.Name = "ParameterMethodControl";
            ParameterMethodControl.Size = new Size(400, 50);
            ParameterMethodControl.TabIndex = 1;
            ParameterMethodControl.Text = "";
            ParameterMethodControl.TrailingIcon = null;
            // 
            // ParameterSpecificationControl
            // 
            ParameterSpecificationControl.AnimateReadOnly = false;
            ParameterSpecificationControl.BorderStyle = BorderStyle.None;
            ParameterSpecificationControl.Depth = 0;
            ParameterSpecificationControl.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterSpecificationControl.Hint = "Maximum Specification";
            ParameterSpecificationControl.LeadingIcon = null;
            ParameterSpecificationControl.Location = new Point(25, 478);
            ParameterSpecificationControl.MaxLength = 50;
            ParameterSpecificationControl.MouseState = MaterialSkin.MouseState.OUT;
            ParameterSpecificationControl.Multiline = false;
            ParameterSpecificationControl.Name = "ParameterSpecificationControl";
            ParameterSpecificationControl.Size = new Size(400, 50);
            ParameterSpecificationControl.TabIndex = 3;
            ParameterSpecificationControl.Text = "";
            ParameterSpecificationControl.TrailingIcon = null;
            ParameterSpecificationControl.KeyPress += ParameterSpecificationControl_KeyPress;
            // 
            // SaveParameterControl
            // 
            SaveParameterControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveParameterControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            SaveParameterControl.Cursor = Cursors.Hand;
            SaveParameterControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveParameterControl.Depth = 0;
            SaveParameterControl.HighEmphasis = true;
            SaveParameterControl.Icon = null;
            SaveParameterControl.Location = new Point(193, 643);
            SaveParameterControl.Margin = new Padding(4, 6, 4, 6);
            SaveParameterControl.MouseState = MaterialSkin.MouseState.HOVER;
            SaveParameterControl.Name = "SaveParameterControl";
            SaveParameterControl.NoAccentTextColor = Color.Empty;
            SaveParameterControl.Size = new Size(64, 36);
            SaveParameterControl.TabIndex = 5;
            SaveParameterControl.Text = "Save";
            SaveParameterControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveParameterControl.UseAccentColor = true;
            SaveParameterControl.UseVisualStyleBackColor = true;
            SaveParameterControl.Click += SaveParameterControl_Click;
            // 
            // ParameterNameErrorCaption
            // 
            ParameterNameErrorCaption.AutoSize = true;
            ParameterNameErrorCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterNameErrorCaption.ForeColor = Color.Red;
            ParameterNameErrorCaption.Location = new Point(25, 178);
            ParameterNameErrorCaption.Name = "ParameterNameErrorCaption";
            ParameterNameErrorCaption.Size = new Size(0, 16);
            ParameterNameErrorCaption.TabIndex = 19;
            // 
            // ParameterMethodErrorCaption
            // 
            ParameterMethodErrorCaption.AutoSize = true;
            ParameterMethodErrorCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterMethodErrorCaption.ForeColor = Color.Red;
            ParameterMethodErrorCaption.Location = new Point(25, 267);
            ParameterMethodErrorCaption.Name = "ParameterMethodErrorCaption";
            ParameterMethodErrorCaption.Size = new Size(0, 16);
            ParameterMethodErrorCaption.TabIndex = 20;
            // 
            // ParameterUnitErrorCaption
            // 
            ParameterUnitErrorCaption.AutoSize = true;
            ParameterUnitErrorCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterUnitErrorCaption.ForeColor = Color.Red;
            ParameterUnitErrorCaption.Location = new Point(25, 355);
            ParameterUnitErrorCaption.Name = "ParameterUnitErrorCaption";
            ParameterUnitErrorCaption.Size = new Size(0, 16);
            ParameterUnitErrorCaption.TabIndex = 21;
            // 
            // ParameterSpecificationErrorCaption
            // 
            ParameterSpecificationErrorCaption.AutoSize = true;
            ParameterSpecificationErrorCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterSpecificationErrorCaption.ForeColor = Color.Red;
            ParameterSpecificationErrorCaption.Location = new Point(25, 532);
            ParameterSpecificationErrorCaption.Name = "ParameterSpecificationErrorCaption";
            ParameterSpecificationErrorCaption.Size = new Size(0, 16);
            ParameterSpecificationErrorCaption.TabIndex = 22;
            // 
            // ParameterProductControl
            // 
            ParameterProductControl.AutoResize = false;
            ParameterProductControl.BackColor = Color.FromArgb(255, 255, 255);
            ParameterProductControl.Depth = 0;
            ParameterProductControl.DrawMode = DrawMode.OwnerDrawVariable;
            ParameterProductControl.DropDownHeight = 174;
            ParameterProductControl.DropDownStyle = ComboBoxStyle.DropDownList;
            ParameterProductControl.DropDownWidth = 121;
            ParameterProductControl.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ParameterProductControl.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ParameterProductControl.FormattingEnabled = true;
            ParameterProductControl.Hint = "Product";
            ParameterProductControl.IntegralHeight = false;
            ParameterProductControl.ItemHeight = 43;
            ParameterProductControl.Location = new Point(25, 567);
            ParameterProductControl.MaxDropDownItems = 4;
            ParameterProductControl.MouseState = MaterialSkin.MouseState.OUT;
            ParameterProductControl.Name = "ParameterProductControl";
            ParameterProductControl.Size = new Size(400, 49);
            ParameterProductControl.StartIndex = -1;
            ParameterProductControl.TabIndex = 4;
            // 
            // ParameterProductErrorCaption
            // 
            ParameterProductErrorCaption.AutoSize = true;
            ParameterProductErrorCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterProductErrorCaption.ForeColor = Color.Red;
            ParameterProductErrorCaption.Location = new Point(25, 622);
            ParameterProductErrorCaption.Name = "ParameterProductErrorCaption";
            ParameterProductErrorCaption.Size = new Size(0, 16);
            ParameterProductErrorCaption.TabIndex = 25;
            // 
            // ParameterUnitControl
            // 
            ParameterUnitControl.AnimateReadOnly = false;
            ParameterUnitControl.BorderStyle = BorderStyle.None;
            ParameterUnitControl.Depth = 0;
            ParameterUnitControl.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ParameterUnitControl.Hint = "Unit";
            ParameterUnitControl.LeadingIcon = null;
            ParameterUnitControl.Location = new Point(25, 303);
            ParameterUnitControl.MaxLength = 50;
            ParameterUnitControl.MouseState = MaterialSkin.MouseState.OUT;
            ParameterUnitControl.Multiline = false;
            ParameterUnitControl.Name = "ParameterUnitControl";
            ParameterUnitControl.Size = new Size(400, 50);
            ParameterUnitControl.TabIndex = 2;
            ParameterUnitControl.Text = "";
            ParameterUnitControl.TrailingIcon = null;
            // 
            // materialTextBoxMinimumSpecification
            // 
            materialTextBoxMinimumSpecification.AnimateReadOnly = false;
            materialTextBoxMinimumSpecification.BorderStyle = BorderStyle.None;
            materialTextBoxMinimumSpecification.Depth = 0;
            materialTextBoxMinimumSpecification.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxMinimumSpecification.Hint = "Minimum Specification (Optional)";
            materialTextBoxMinimumSpecification.LeadingIcon = null;
            materialTextBoxMinimumSpecification.Location = new Point(25, 390);
            materialTextBoxMinimumSpecification.MaxLength = 50;
            materialTextBoxMinimumSpecification.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxMinimumSpecification.Multiline = false;
            materialTextBoxMinimumSpecification.Name = "materialTextBoxMinimumSpecification";
            materialTextBoxMinimumSpecification.Size = new Size(400, 50);
            materialTextBoxMinimumSpecification.TabIndex = 26;
            materialTextBoxMinimumSpecification.Text = "";
            materialTextBoxMinimumSpecification.TrailingIcon = null;
            materialTextBoxMinimumSpecification.KeyPress += materialTextBoxMinimumSpecification_KeyPress;
            // 
            // CreateProductParameter
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(450, 700);
            Controls.Add(materialTextBoxMinimumSpecification);
            Controls.Add(ParameterUnitControl);
            Controls.Add(ParameterProductErrorCaption);
            Controls.Add(ParameterProductControl);
            Controls.Add(ParameterSpecificationErrorCaption);
            Controls.Add(ParameterUnitErrorCaption);
            Controls.Add(ParameterMethodErrorCaption);
            Controls.Add(ParameterNameErrorCaption);
            Controls.Add(SaveParameterControl);
            Controls.Add(ParameterSpecificationControl);
            Controls.Add(ParameterMethodControl);
            Controls.Add(ParameterNameControl);
            ForeColor = Color.Red;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateProductParameter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Product Parameter";
            ResumeLayout(false);
            PerformLayout();
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