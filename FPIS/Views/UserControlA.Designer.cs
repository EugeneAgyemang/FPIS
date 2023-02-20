namespace FPIS.Views
{
    partial class UserControlA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TypeSomethingControl = new MaterialSkin.Controls.MaterialTextBox();
            this.ActionButtonControl = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(83, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(235, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "User Control A - Proposed Pattern";
            // 
            // TypeSomethingControl
            // 
            this.TypeSomethingControl.AnimateReadOnly = false;
            this.TypeSomethingControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeSomethingControl.Depth = 0;
            this.TypeSomethingControl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TypeSomethingControl.Hint = "Type Something";
            this.TypeSomethingControl.LeadingIcon = null;
            this.TypeSomethingControl.Location = new System.Drawing.Point(51, 136);
            this.TypeSomethingControl.MaxLength = 50;
            this.TypeSomethingControl.MouseState = MaterialSkin.MouseState.OUT;
            this.TypeSomethingControl.Multiline = false;
            this.TypeSomethingControl.Name = "TypeSomethingControl";
            this.TypeSomethingControl.Size = new System.Drawing.Size(299, 50);
            this.TypeSomethingControl.TabIndex = 1;
            this.TypeSomethingControl.Text = "";
            this.TypeSomethingControl.TrailingIcon = null;
            // 
            // ActionButtonControl
            // 
            this.ActionButtonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActionButtonControl.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.ActionButtonControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActionButtonControl.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ActionButtonControl.Depth = 0;
            this.ActionButtonControl.HighEmphasis = true;
            this.ActionButtonControl.Icon = null;
            this.ActionButtonControl.Location = new System.Drawing.Point(162, 275);
            this.ActionButtonControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ActionButtonControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActionButtonControl.Name = "ActionButtonControl";
            this.ActionButtonControl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ActionButtonControl.Size = new System.Drawing.Size(74, 36);
            this.ActionButtonControl.TabIndex = 2;
            this.ActionButtonControl.Text = "Action";
            this.ActionButtonControl.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ActionButtonControl.UseAccentColor = false;
            this.ActionButtonControl.UseVisualStyleBackColor = true;
            this.ActionButtonControl.Click += new System.EventHandler(this.ActionButtonControl_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(141, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "add other stuff...";
            // 
            // UserControlA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.ActionButtonControl);
            this.Controls.Add(this.TypeSomethingControl);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlA";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TypeSomethingControl;
        private MaterialSkin.Controls.MaterialButton ActionButtonControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
