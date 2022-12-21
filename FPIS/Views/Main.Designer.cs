namespace FPIS.Views
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.itemOne = new System.Windows.Forms.TabPage();
            this.itemTwo = new System.Windows.Forms.TabPage();
            this.itemThree = new System.Windows.Forms.TabPage();
            this.drawerImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.dashboard);
            this.mainTabs.Controls.Add(this.itemOne);
            this.mainTabs.Controls.Add(this.itemTwo);
            this.mainTabs.Controls.Add(this.itemThree);
            this.mainTabs.Depth = 0;
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.ImageList = this.drawerImageList;
            this.mainTabs.Location = new System.Drawing.Point(3, 80);
            this.mainTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabs.Multiline = true;
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.Padding = new System.Drawing.Point(20, 3);
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.ShowToolTips = true;
            this.mainTabs.Size = new System.Drawing.Size(954, 567);
            this.mainTabs.TabIndex = 2;
            // 
            // dashboard
            // 
            this.dashboard.ImageKey = "dashboard.png";
            this.dashboard.Location = new System.Drawing.Point(4, 39);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(946, 524);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "Dashboard";
            this.dashboard.ToolTipText = "View your dashboard for insights";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // itemOne
            // 
            this.itemOne.AllowDrop = true;
            this.itemOne.ImageKey = "delete-me.png";
            this.itemOne.Location = new System.Drawing.Point(4, 39);
            this.itemOne.Name = "itemOne";
            this.itemOne.Padding = new System.Windows.Forms.Padding(3);
            this.itemOne.Size = new System.Drawing.Size(946, 524);
            this.itemOne.TabIndex = 0;
            this.itemOne.Text = "Item One";
            this.itemOne.ToolTipText = "Chek out first item";
            this.itemOne.UseVisualStyleBackColor = true;
            // 
            // itemTwo
            // 
            this.itemTwo.AllowDrop = true;
            this.itemTwo.ImageKey = "delete-me-2.png";
            this.itemTwo.Location = new System.Drawing.Point(4, 39);
            this.itemTwo.Name = "itemTwo";
            this.itemTwo.Padding = new System.Windows.Forms.Padding(3);
            this.itemTwo.Size = new System.Drawing.Size(946, 524);
            this.itemTwo.TabIndex = 1;
            this.itemTwo.Text = "Item Two";
            this.itemTwo.ToolTipText = "Check out second item";
            this.itemTwo.UseVisualStyleBackColor = true;
            // 
            // itemThree
            // 
            this.itemThree.ImageKey = "delete-me-3.png";
            this.itemThree.Location = new System.Drawing.Point(4, 39);
            this.itemThree.Name = "itemThree";
            this.itemThree.Size = new System.Drawing.Size(946, 524);
            this.itemThree.TabIndex = 2;
            this.itemThree.Text = "Item Three";
            this.itemThree.ToolTipText = "Check out third item";
            this.itemThree.UseVisualStyleBackColor = true;
            // 
            // drawerImageList
            // 
            this.drawerImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.drawerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drawerImageList.ImageStream")));
            this.drawerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.drawerImageList.Images.SetKeyName(0, "dashboard.png");
            this.drawerImageList.Images.SetKeyName(1, "delete-me.png");
            this.drawerImageList.Images.SetKeyName(2, "delete-me-2.png");
            this.drawerImageList.Images.SetKeyName(3, "delete-me-3.png");
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.mainTabs);
            this.DrawerIndicatorWidth = 2;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabs;
            this.DrawerWidth = 250;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_56;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabs;
        private TabPage itemOne;
        private TabPage itemTwo;
        private TabPage itemThree;
        private ImageList drawerImageList;
        private TabPage dashboard;
    }
}