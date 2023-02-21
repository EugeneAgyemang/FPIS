namespace FPIS.Views
{
    partial class TestUserControls
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
            this.SidePanelControl = new System.Windows.Forms.Panel();
            this.MainPanelControl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SidePanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanelControl
            // 
            this.SidePanelControl.Controls.Add(this.button2);
            this.SidePanelControl.Controls.Add(this.button1);
            this.SidePanelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelControl.Location = new System.Drawing.Point(0, 0);
            this.SidePanelControl.Name = "SidePanelControl";
            this.SidePanelControl.Size = new System.Drawing.Size(200, 450);
            this.SidePanelControl.TabIndex = 0;
            // 
            // MainPanelControl
            // 
            this.MainPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelControl.Location = new System.Drawing.Point(200, 0);
            this.MainPanelControl.Name = "MainPanelControl";
            this.MainPanelControl.Size = new System.Drawing.Size(600, 450);
            this.MainPanelControl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Right Pattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Wrong Pattern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanelControl);
            this.Controls.Add(this.SidePanelControl);
            this.Name = "TestUserControls";
            this.Text = "TestUserControls";
            this.SidePanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SidePanelControl;
        private Button button2;
        private Button button1;
        private Panel MainPanelControl;
    }
}