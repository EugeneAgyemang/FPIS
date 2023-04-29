namespace FPIS.Views
{
    partial class DashboardUserControl
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
            this.ActiveUsersSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RegisteredUsersControl = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SamplesSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SamplesControl = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SampleResultsSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SampleResultsControl = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SamplesPendingSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SamplesPendingControl = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ActiveUsersSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SamplesSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SampleResultsSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SamplesPendingSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveUsersSection
            // 
            this.ActiveUsersSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ActiveUsersSection.Controls.Add(this.pictureBox3);
            this.ActiveUsersSection.Controls.Add(this.RegisteredUsersControl);
            this.ActiveUsersSection.Controls.Add(this.materialLabel1);
            this.ActiveUsersSection.Depth = 0;
            this.ActiveUsersSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ActiveUsersSection.Location = new System.Drawing.Point(87, 54);
            this.ActiveUsersSection.Margin = new System.Windows.Forms.Padding(14);
            this.ActiveUsersSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.ActiveUsersSection.Name = "ActiveUsersSection";
            this.ActiveUsersSection.Padding = new System.Windows.Forms.Padding(14);
            this.ActiveUsersSection.Size = new System.Drawing.Size(274, 212);
            this.ActiveUsersSection.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.pictureBox3.Image = global::FPIS.Properties.Resources.users_white;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(274, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // RegisteredUsersControl
            // 
            this.RegisteredUsersControl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisteredUsersControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.RegisteredUsersControl.Location = new System.Drawing.Point(43, 128);
            this.RegisteredUsersControl.Name = "RegisteredUsersControl";
            this.RegisteredUsersControl.Size = new System.Drawing.Size(189, 45);
            this.RegisteredUsersControl.TabIndex = 1;
            this.RegisteredUsersControl.Text = "----";
            this.RegisteredUsersControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(65, 185);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Accounts Registered";
            // 
            // SamplesSection
            // 
            this.SamplesSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesSection.Controls.Add(this.pictureBox1);
            this.SamplesSection.Controls.Add(this.SamplesControl);
            this.SamplesSection.Controls.Add(this.materialLabel2);
            this.SamplesSection.Depth = 0;
            this.SamplesSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesSection.Location = new System.Drawing.Point(389, 54);
            this.SamplesSection.Margin = new System.Windows.Forms.Padding(14);
            this.SamplesSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesSection.Name = "SamplesSection";
            this.SamplesSection.Padding = new System.Windows.Forms.Padding(14);
            this.SamplesSection.Size = new System.Drawing.Size(274, 212);
            this.SamplesSection.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = global::FPIS.Properties.Resources.sample_large;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SamplesControl
            // 
            this.SamplesControl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SamplesControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.SamplesControl.Location = new System.Drawing.Point(43, 128);
            this.SamplesControl.Name = "SamplesControl";
            this.SamplesControl.Size = new System.Drawing.Size(189, 45);
            this.SamplesControl.TabIndex = 1;
            this.SamplesControl.Text = "----";
            this.SamplesControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(46, 185);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(182, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Total Samples Requested";
            // 
            // SampleResultsSection
            // 
            this.SampleResultsSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SampleResultsSection.Controls.Add(this.pictureBox2);
            this.SampleResultsSection.Controls.Add(this.SampleResultsControl);
            this.SampleResultsSection.Controls.Add(this.materialLabel3);
            this.SampleResultsSection.Depth = 0;
            this.SampleResultsSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SampleResultsSection.Location = new System.Drawing.Point(87, 294);
            this.SampleResultsSection.Margin = new System.Windows.Forms.Padding(14);
            this.SampleResultsSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SampleResultsSection.Name = "SampleResultsSection";
            this.SampleResultsSection.Padding = new System.Windows.Forms.Padding(14);
            this.SampleResultsSection.Size = new System.Drawing.Size(274, 212);
            this.SampleResultsSection.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.pictureBox2.Image = global::FPIS.Properties.Resources.results_large;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // SampleResultsControl
            // 
            this.SampleResultsControl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SampleResultsControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.SampleResultsControl.Location = new System.Drawing.Point(43, 128);
            this.SampleResultsControl.Name = "SampleResultsControl";
            this.SampleResultsControl.Size = new System.Drawing.Size(189, 45);
            this.SampleResultsControl.TabIndex = 1;
            this.SampleResultsControl.Text = "----";
            this.SampleResultsControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(61, 185);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Total Sample Results";
            // 
            // SamplesPendingSection
            // 
            this.SamplesPendingSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesPendingSection.Controls.Add(this.pictureBox4);
            this.SamplesPendingSection.Controls.Add(this.SamplesPendingControl);
            this.SamplesPendingSection.Controls.Add(this.materialLabel4);
            this.SamplesPendingSection.Depth = 0;
            this.SamplesPendingSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesPendingSection.Location = new System.Drawing.Point(389, 294);
            this.SamplesPendingSection.Margin = new System.Windows.Forms.Padding(14);
            this.SamplesPendingSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesPendingSection.Name = "SamplesPendingSection";
            this.SamplesPendingSection.Padding = new System.Windows.Forms.Padding(14);
            this.SamplesPendingSection.Size = new System.Drawing.Size(274, 212);
            this.SamplesPendingSection.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.pictureBox4.Image = global::FPIS.Properties.Resources.sample_large;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(274, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // SamplesPendingControl
            // 
            this.SamplesPendingControl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SamplesPendingControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.SamplesPendingControl.Location = new System.Drawing.Point(43, 128);
            this.SamplesPendingControl.Name = "SamplesPendingControl";
            this.SamplesPendingControl.Size = new System.Drawing.Size(189, 45);
            this.SamplesPendingControl.TabIndex = 1;
            this.SamplesPendingControl.Text = "----";
            this.SamplesPendingControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(54, 185);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(166, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Total Samples Pending";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(25, 13);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(97, 24);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Dashboard";
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.SamplesPendingSection);
            this.Controls.Add(this.SampleResultsSection);
            this.Controls.Add(this.SamplesSection);
            this.Controls.Add(this.ActiveUsersSection);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(750, 600);
            this.ActiveUsersSection.ResumeLayout(false);
            this.ActiveUsersSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.SamplesSection.ResumeLayout(false);
            this.SamplesSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SampleResultsSection.ResumeLayout(false);
            this.SampleResultsSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SamplesPendingSection.ResumeLayout(false);
            this.SamplesPendingSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard ActiveUsersSection;
        private Label RegisteredUsersControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard SamplesSection;
        private Label SamplesControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard SampleResultsSection;
        private Label SampleResultsControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialCard SamplesPendingSection;
        private PictureBox pictureBox4;
        private Label SamplesPendingControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}
