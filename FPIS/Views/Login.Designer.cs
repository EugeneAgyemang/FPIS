namespace FPIS
{
    partial class Login
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
            this.txtEmpId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.EmployeeIdErrorControl = new System.Windows.Forms.Label();
            this.PasswordErrorControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmpId
            // 
            this.txtEmpId.AnimateReadOnly = false;
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpId.Depth = 0;
            this.txtEmpId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpId.Hint = "Employee ID";
            this.txtEmpId.LeadingIcon = null;
            this.txtEmpId.Location = new System.Drawing.Point(23, 125);
            this.txtEmpId.MaxLength = 50;
            this.txtEmpId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpId.Multiline = false;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEmpId.Size = new System.Drawing.Size(400, 50);
            this.txtEmpId.TabIndex = 0;
            this.txtEmpId.Text = "";
            this.txtEmpId.TrailingIcon = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(22, 214);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(401, 50);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = global::FPIS.Properties.Resources.show_password;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(193, 332);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(64, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = true;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // EmployeeIdErrorControl
            // 
            this.EmployeeIdErrorControl.AutoSize = true;
            this.EmployeeIdErrorControl.ForeColor = System.Drawing.Color.Red;
            this.EmployeeIdErrorControl.Location = new System.Drawing.Point(23, 178);
            this.EmployeeIdErrorControl.Name = "EmployeeIdErrorControl";
            this.EmployeeIdErrorControl.Size = new System.Drawing.Size(0, 15);
            this.EmployeeIdErrorControl.TabIndex = 3;
            // 
            // PasswordErrorControl
            // 
            this.PasswordErrorControl.AutoSize = true;
            this.PasswordErrorControl.ForeColor = System.Drawing.Color.Red;
            this.PasswordErrorControl.Location = new System.Drawing.Point(23, 267);
            this.PasswordErrorControl.Name = "PasswordErrorControl";
            this.PasswordErrorControl.Size = new System.Drawing.Size(0, 15);
            this.PasswordErrorControl.TabIndex = 4;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 410);
            this.Controls.Add(this.PasswordErrorControl);
            this.Controls.Add(this.EmployeeIdErrorControl);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmpId);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtEmpId;
        public MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private Label EmployeeIdErrorControl;
        private Label PasswordErrorControl;
    }
}