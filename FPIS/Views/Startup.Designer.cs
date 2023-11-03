namespace FPIS
{
    partial class Startup
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            Caption = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 97, 46);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Caption);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(53, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 266);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(63, 97, 46);
            label3.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 0);
            label3.Name = "label3";
            label3.Size = new Size(610, 29);
            label3.TabIndex = 6;
            label3.Text = "FRACTIONATION PROCESS INTEGRATION SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(63, 97, 46);
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 248);
            label2.Name = "label2";
            label2.Size = new Size(163, 16);
            label2.TabIndex = 4;
            label2.Text = "Powered by ITS Gh. v1.0.9";
            // 
            // Caption
            // 
            Caption.BackColor = Color.FromArgb(63, 97, 46);
            Caption.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Caption.ForeColor = Color.White;
            Caption.Location = new Point(241, 39);
            Caption.Name = "Caption";
            Caption.Size = new Size(300, 26);
            Caption.TabIndex = 3;
            Caption.Text = "Loading";
            Caption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.I_T_S_GH_Logo_White;
            pictureBox1.Location = new Point(113, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Startup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(63, 97, 46);
            ClientSize = new Size(650, 400);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Startup";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label Caption;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}