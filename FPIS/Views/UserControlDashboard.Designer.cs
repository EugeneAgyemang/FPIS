namespace FPIS.Views
{
    partial class UserControlDashboard
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
            this.components = new System.ComponentModel.Container();
            this.ActiveUsersSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RegisteredUsersControl = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.SamplesRequestedBreakdownSection = new MaterialSkin.Controls.MaterialCard();
            this.SampleRequestedBreakdownDetailsSection = new System.Windows.Forms.Panel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.helperToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SamplesProcessedBreakdownSection = new MaterialSkin.Controls.MaterialCard();
            this.SamplesProcessedBreakdownDetailsSection = new System.Windows.Forms.Panel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.asyncLoader = new System.Windows.Forms.Timer(this.components);
            this.SectionForUser = new System.Windows.Forms.Panel();
            this.SamplesPendingSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SamplesPendingControl = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SampleResultsSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SampleResultsControl = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SamplesSection = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SamplesControl = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ActiveUsersSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SamplesRequestedBreakdownSection.SuspendLayout();
            this.SampleRequestedBreakdownDetailsSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SamplesProcessedBreakdownSection.SuspendLayout();
            this.SamplesProcessedBreakdownDetailsSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SectionForUser.SuspendLayout();
            this.SamplesPendingSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SampleResultsSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SamplesSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(87, 304);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1176, 5);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel6.Location = new System.Drawing.Point(25, 324);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(123, 17);
            this.materialLabel6.TabIndex = 16;
            this.materialLabel6.Text = "Your daily live feed";
            // 
            // SamplesRequestedBreakdownSection
            // 
            this.SamplesRequestedBreakdownSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesRequestedBreakdownSection.Controls.Add(this.SampleRequestedBreakdownDetailsSection);
            this.SamplesRequestedBreakdownSection.Controls.Add(this.pictureBox5);
            this.SamplesRequestedBreakdownSection.Controls.Add(this.materialLabel7);
            this.SamplesRequestedBreakdownSection.Depth = 0;
            this.SamplesRequestedBreakdownSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesRequestedBreakdownSection.Location = new System.Drawing.Point(87, 364);
            this.SamplesRequestedBreakdownSection.Margin = new System.Windows.Forms.Padding(14);
            this.SamplesRequestedBreakdownSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesRequestedBreakdownSection.Name = "SamplesRequestedBreakdownSection";
            this.SamplesRequestedBreakdownSection.Padding = new System.Windows.Forms.Padding(14);
            this.SamplesRequestedBreakdownSection.Size = new System.Drawing.Size(576, 320);
            this.SamplesRequestedBreakdownSection.TabIndex = 17;
            // 
            // SampleRequestedBreakdownDetailsSection
            // 
            this.SampleRequestedBreakdownDetailsSection.AutoScroll = true;
            this.SampleRequestedBreakdownDetailsSection.Controls.Add(this.materialLabel8);
            this.SampleRequestedBreakdownDetailsSection.Location = new System.Drawing.Point(17, 128);
            this.SampleRequestedBreakdownDetailsSection.Name = "SampleRequestedBreakdownDetailsSection";
            this.SampleRequestedBreakdownDetailsSection.Size = new System.Drawing.Size(542, 156);
            this.SampleRequestedBreakdownDetailsSection.TabIndex = 3;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel8.Location = new System.Drawing.Point(25, 20);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(492, 21);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "There\'s no data available";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.pictureBox5.Image = global::FPIS.Properties.Resources.sample_large;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(576, 122);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(181, 287);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(215, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Breakdown of items requested";
            // 
            // SamplesProcessedBreakdownSection
            // 
            this.SamplesProcessedBreakdownSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesProcessedBreakdownSection.Controls.Add(this.SamplesProcessedBreakdownDetailsSection);
            this.SamplesProcessedBreakdownSection.Controls.Add(this.pictureBox6);
            this.SamplesProcessedBreakdownSection.Controls.Add(this.materialLabel12);
            this.SamplesProcessedBreakdownSection.Depth = 0;
            this.SamplesProcessedBreakdownSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesProcessedBreakdownSection.Location = new System.Drawing.Point(691, 364);
            this.SamplesProcessedBreakdownSection.Margin = new System.Windows.Forms.Padding(14);
            this.SamplesProcessedBreakdownSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesProcessedBreakdownSection.Name = "SamplesProcessedBreakdownSection";
            this.SamplesProcessedBreakdownSection.Padding = new System.Windows.Forms.Padding(14);
            this.SamplesProcessedBreakdownSection.Size = new System.Drawing.Size(576, 320);
            this.SamplesProcessedBreakdownSection.TabIndex = 18;
            // 
            // SamplesProcessedBreakdownDetailsSection
            // 
            this.SamplesProcessedBreakdownDetailsSection.AutoScroll = true;
            this.SamplesProcessedBreakdownDetailsSection.Controls.Add(this.materialLabel11);
            this.SamplesProcessedBreakdownDetailsSection.Location = new System.Drawing.Point(17, 128);
            this.SamplesProcessedBreakdownDetailsSection.Name = "SamplesProcessedBreakdownDetailsSection";
            this.SamplesProcessedBreakdownDetailsSection.Size = new System.Drawing.Size(542, 156);
            this.SamplesProcessedBreakdownDetailsSection.TabIndex = 3;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel11.Location = new System.Drawing.Point(25, 20);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(492, 21);
            this.materialLabel11.TabIndex = 0;
            this.materialLabel11.Text = "There\'s no data available";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(97)))), ((int)(((byte)(46)))));
            this.pictureBox6.Image = global::FPIS.Properties.Resources.results_large;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(576, 122);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(179, 287);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(218, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Breakdown of items processed";
            // 
            // asyncLoader
            // 
            this.asyncLoader.Enabled = true;
            this.asyncLoader.Interval = 1000;
            this.asyncLoader.Tick += new System.EventHandler(this.asyncLoader_Tick);
            // 
            // SectionForUser
            // 
            this.SectionForUser.Controls.Add(this.SamplesPendingSection);
            this.SectionForUser.Controls.Add(this.SampleResultsSection);
            this.SectionForUser.Controls.Add(this.SamplesSection);
            this.SectionForUser.Location = new System.Drawing.Point(369, 48);
            this.SectionForUser.Name = "SectionForUser";
            this.SectionForUser.Size = new System.Drawing.Size(898, 222);
            this.SectionForUser.TabIndex = 19;
            // 
            // SamplesPendingSection
            // 
            this.SamplesPendingSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesPendingSection.Controls.Add(this.pictureBox4);
            this.SamplesPendingSection.Controls.Add(this.SamplesPendingControl);
            this.SamplesPendingSection.Controls.Add(this.materialLabel4);
            this.SamplesPendingSection.Depth = 0;
            this.SamplesPendingSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesPendingSection.Location = new System.Drawing.Point(614, 5);
            this.SamplesPendingSection.Margin = new System.Windows.Forms.Padding(14);
            this.SamplesPendingSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesPendingSection.Name = "SamplesPendingSection";
            this.SamplesPendingSection.Padding = new System.Windows.Forms.Padding(14);
            this.SamplesPendingSection.Size = new System.Drawing.Size(274, 212);
            this.SamplesPendingSection.TabIndex = 6;
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
            // SampleResultsSection
            // 
            this.SampleResultsSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SampleResultsSection.Controls.Add(this.pictureBox2);
            this.SampleResultsSection.Controls.Add(this.SampleResultsControl);
            this.SampleResultsSection.Controls.Add(this.materialLabel3);
            this.SampleResultsSection.Depth = 0;
            this.SampleResultsSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SampleResultsSection.Location = new System.Drawing.Point(312, 5);
            this.SampleResultsSection.Margin = new System.Windows.Forms.Padding(14);
            this.SampleResultsSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SampleResultsSection.Name = "SampleResultsSection";
            this.SampleResultsSection.Padding = new System.Windows.Forms.Padding(14);
            this.SampleResultsSection.Size = new System.Drawing.Size(274, 212);
            this.SampleResultsSection.TabIndex = 5;
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
            // SamplesSection
            // 
            this.SamplesSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SamplesSection.Controls.Add(this.pictureBox1);
            this.SamplesSection.Controls.Add(this.SamplesControl);
            this.SamplesSection.Controls.Add(this.materialLabel2);
            this.SamplesSection.Depth = 0;
            this.SamplesSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SamplesSection.Location = new System.Drawing.Point(10, 5);
            this.SamplesSection.Margin = new System.Windows.Forms.Padding(14);
            this.SamplesSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.SamplesSection.Name = "SamplesSection";
            this.SamplesSection.Padding = new System.Windows.Forms.Padding(14);
            this.SamplesSection.Size = new System.Drawing.Size(274, 212);
            this.SamplesSection.TabIndex = 4;
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
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.SectionForUser);
            this.Controls.Add(this.SamplesProcessedBreakdownSection);
            this.Controls.Add(this.SamplesRequestedBreakdownSection);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.ActiveUsersSection);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(1364, 783);
            this.ActiveUsersSection.ResumeLayout(false);
            this.ActiveUsersSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.SamplesRequestedBreakdownSection.ResumeLayout(false);
            this.SamplesRequestedBreakdownSection.PerformLayout();
            this.SampleRequestedBreakdownDetailsSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.SamplesProcessedBreakdownSection.ResumeLayout(false);
            this.SamplesProcessedBreakdownSection.PerformLayout();
            this.SamplesProcessedBreakdownDetailsSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.SectionForUser.ResumeLayout(false);
            this.SamplesPendingSection.ResumeLayout(false);
            this.SamplesPendingSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.SampleResultsSection.ResumeLayout(false);
            this.SampleResultsSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SamplesSection.ResumeLayout(false);
            this.SamplesSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard ActiveUsersSection;
        private Label RegisteredUsersControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCard SamplesRequestedBreakdownSection;
        private Panel SampleRequestedBreakdownDetailsSection;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private ToolTip helperToolTip;
        private MaterialSkin.Controls.MaterialCard SamplesProcessedBreakdownSection;
        private Panel SamplesProcessedBreakdownDetailsSection;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.Timer asyncLoader;
        private Panel SectionForUser;
        private MaterialSkin.Controls.MaterialCard SamplesPendingSection;
        private PictureBox pictureBox4;
        private Label SamplesPendingControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard SampleResultsSection;
        private PictureBox pictureBox2;
        private Label SampleResultsControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard SamplesSection;
        private PictureBox pictureBox1;
        private Label SamplesControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
