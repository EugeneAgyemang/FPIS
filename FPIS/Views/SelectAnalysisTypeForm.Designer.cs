namespace FPIS.Views
{
    partial class SelectAnalysisTypeForm
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
            this.materialComboBoxAnalysisType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonContinue = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialComboBoxAnalysisType
            // 
            this.materialComboBoxAnalysisType.AutoResize = false;
            this.materialComboBoxAnalysisType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxAnalysisType.Depth = 0;
            this.materialComboBoxAnalysisType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxAnalysisType.DropDownHeight = 174;
            this.materialComboBoxAnalysisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxAnalysisType.DropDownWidth = 121;
            this.materialComboBoxAnalysisType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxAnalysisType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxAnalysisType.FormattingEnabled = true;
            this.materialComboBoxAnalysisType.IntegralHeight = false;
            this.materialComboBoxAnalysisType.ItemHeight = 43;
            this.materialComboBoxAnalysisType.Location = new System.Drawing.Point(12, 104);
            this.materialComboBoxAnalysisType.MaxDropDownItems = 4;
            this.materialComboBoxAnalysisType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxAnalysisType.Name = "materialComboBoxAnalysisType";
            this.materialComboBoxAnalysisType.Size = new System.Drawing.Size(463, 49);
            this.materialComboBoxAnalysisType.StartIndex = 0;
            this.materialComboBoxAnalysisType.TabIndex = 2;
            // 
            // materialButtonContinue
            // 
            this.materialButtonContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonContinue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonContinue.Depth = 0;
            this.materialButtonContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialButtonContinue.HighEmphasis = true;
            this.materialButtonContinue.Icon = null;
            this.materialButtonContinue.Location = new System.Drawing.Point(493, 117);
            this.materialButtonContinue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonContinue.Name = "materialButtonContinue";
            this.materialButtonContinue.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonContinue.Size = new System.Drawing.Size(93, 36);
            this.materialButtonContinue.TabIndex = 3;
            this.materialButtonContinue.Text = "Continue";
            this.materialButtonContinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonContinue.UseAccentColor = false;
            this.materialButtonContinue.UseVisualStyleBackColor = true;
            this.materialButtonContinue.Click += new System.EventHandler(this.materialButtonContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Analysis Type";
            // 
            // SelectAnalysisTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButtonContinue);
            this.Controls.Add(this.materialComboBoxAnalysisType);
            this.Name = "SelectAnalysisTypeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Analysis Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxAnalysisType;
        private MaterialSkin.Controls.MaterialButton materialButtonContinue;
        private Label label1;
    }
}