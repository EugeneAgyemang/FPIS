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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAnalysisTypeForm));
            this.materialComboBoxAnalysisType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonContinue = new MaterialSkin.Controls.MaterialButton();
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
            this.materialComboBoxAnalysisType.Hint = "Choose an option";
            this.materialComboBoxAnalysisType.IntegralHeight = false;
            this.materialComboBoxAnalysisType.ItemHeight = 43;
            this.materialComboBoxAnalysisType.Location = new System.Drawing.Point(34, 88);
            this.materialComboBoxAnalysisType.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBoxAnalysisType.MaxDropDownItems = 4;
            this.materialComboBoxAnalysisType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxAnalysisType.Name = "materialComboBoxAnalysisType";
            this.materialComboBoxAnalysisType.Size = new System.Drawing.Size(325, 49);
            this.materialComboBoxAnalysisType.StartIndex = 0;
            this.materialComboBoxAnalysisType.TabIndex = 2;
            // 
            // materialButtonContinue
            // 
            this.materialButtonContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonContinue.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonContinue.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonContinue.Depth = 0;
            this.materialButtonContinue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialButtonContinue.HighEmphasis = true;
            this.materialButtonContinue.Icon = null;
            this.materialButtonContinue.Location = new System.Drawing.Point(373, 95);
            this.materialButtonContinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButtonContinue.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonContinue.Name = "materialButtonContinue";
            this.materialButtonContinue.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonContinue.Size = new System.Drawing.Size(93, 36);
            this.materialButtonContinue.TabIndex = 3;
            this.materialButtonContinue.Text = "Continue";
            this.materialButtonContinue.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonContinue.UseAccentColor = true;
            this.materialButtonContinue.UseVisualStyleBackColor = true;
            this.materialButtonContinue.Click += new System.EventHandler(this.materialButtonContinue_Click);
            // 
            // SelectAnalysisTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 180);
            this.Controls.Add(this.materialButtonContinue);
            this.Controls.Add(this.materialComboBoxAnalysisType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectAnalysisTypeForm";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
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
    }
}