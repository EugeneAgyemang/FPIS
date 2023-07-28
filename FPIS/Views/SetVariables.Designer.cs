namespace FPIS.Views
{
    partial class SetVariables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetVariables));
            materialTextBoxConcentrationOFNaOH = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxNormalityOfNaSO = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            label5 = new Label();
            materialButtonSetVariable = new MaterialSkin.Controls.MaterialButton();
            labelNaOHError = new Label();
            labelNaSOError = new Label();
            SuspendLayout();
            // 
            // materialTextBoxConcentrationOFNaOH
            // 
            materialTextBoxConcentrationOFNaOH.AnimateReadOnly = false;
            materialTextBoxConcentrationOFNaOH.BorderStyle = BorderStyle.None;
            materialTextBoxConcentrationOFNaOH.Depth = 0;
            materialTextBoxConcentrationOFNaOH.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxConcentrationOFNaOH.LeadingIcon = null;
            materialTextBoxConcentrationOFNaOH.Location = new Point(29, 188);
            materialTextBoxConcentrationOFNaOH.MaxLength = 50;
            materialTextBoxConcentrationOFNaOH.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxConcentrationOFNaOH.Multiline = false;
            materialTextBoxConcentrationOFNaOH.Name = "materialTextBoxConcentrationOFNaOH";
            materialTextBoxConcentrationOFNaOH.Size = new Size(457, 50);
            materialTextBoxConcentrationOFNaOH.TabIndex = 0;
            materialTextBoxConcentrationOFNaOH.Text = "";
            materialTextBoxConcentrationOFNaOH.TrailingIcon = null;
            materialTextBoxConcentrationOFNaOH.KeyPress += materialTextBoxConcentrationOFNaOH_KeyPress;
            // 
            // materialTextBoxNormalityOfNaSO
            // 
            materialTextBoxNormalityOfNaSO.AnimateReadOnly = false;
            materialTextBoxNormalityOfNaSO.BorderStyle = BorderStyle.None;
            materialTextBoxNormalityOfNaSO.Depth = 0;
            materialTextBoxNormalityOfNaSO.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxNormalityOfNaSO.LeadingIcon = null;
            materialTextBoxNormalityOfNaSO.Location = new Point(29, 325);
            materialTextBoxNormalityOfNaSO.MaxLength = 50;
            materialTextBoxNormalityOfNaSO.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxNormalityOfNaSO.Multiline = false;
            materialTextBoxNormalityOfNaSO.Name = "materialTextBoxNormalityOfNaSO";
            materialTextBoxNormalityOfNaSO.Size = new Size(457, 50);
            materialTextBoxNormalityOfNaSO.TabIndex = 1;
            materialTextBoxNormalityOfNaSO.Text = "";
            materialTextBoxNormalityOfNaSO.TrailingIcon = null;
            materialTextBoxNormalityOfNaSO.KeyPress += materialTextBoxNormalityOfNaSO_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(29, 301);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 2;
            label1.Text = "Normality of Na₂S₂O₃";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 165);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 6;
            label5.Text = "Concentration of NaOH";
            // 
            // materialButtonSetVariable
            // 
            materialButtonSetVariable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSetVariable.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            materialButtonSetVariable.Cursor = Cursors.Hand;
            materialButtonSetVariable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSetVariable.Depth = 0;
            materialButtonSetVariable.HighEmphasis = true;
            materialButtonSetVariable.Icon = null;
            materialButtonSetVariable.Location = new Point(184, 479);
            materialButtonSetVariable.Margin = new Padding(5, 5, 5, 5);
            materialButtonSetVariable.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSetVariable.Name = "materialButtonSetVariable";
            materialButtonSetVariable.NoAccentTextColor = Color.Empty;
            materialButtonSetVariable.Size = new Size(128, 36);
            materialButtonSetVariable.TabIndex = 33;
            materialButtonSetVariable.Text = "Set Variables";
            materialButtonSetVariable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSetVariable.UseAccentColor = true;
            materialButtonSetVariable.UseVisualStyleBackColor = true;
            materialButtonSetVariable.Click += materialButtonSetVariable_Click;
            // 
            // labelNaOHError
            // 
            labelNaOHError.AutoSize = true;
            labelNaOHError.Location = new Point(29, 257);
            labelNaOHError.Name = "labelNaOHError";
            labelNaOHError.Size = new Size(115, 20);
            labelNaOHError.TabIndex = 34;
            labelNaOHError.Text = "labelNaOHError";
            // 
            // labelNaSOError
            // 
            labelNaSOError.AutoSize = true;
            labelNaSOError.Location = new Point(29, 395);
            labelNaSOError.Name = "labelNaSOError";
            labelNaSOError.Size = new Size(112, 20);
            labelNaSOError.TabIndex = 35;
            labelNaSOError.Text = "labelNaSOError";
            // 
            // SetVariables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 630);
            Controls.Add(labelNaSOError);
            Controls.Add(labelNaOHError);
            Controls.Add(materialButtonSetVariable);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(materialTextBoxNormalityOfNaSO);
            Controls.Add(materialTextBoxConcentrationOFNaOH);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetVariables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Variables";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBoxConcentrationOFNaOH;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNormalityOfNaSO;
        private Label label1;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton materialButtonSetVariable;
        private Label labelNaOHError;
        private Label labelNaSOError;
    }
}