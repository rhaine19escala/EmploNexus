
namespace EmploNexus.Forms
{
    partial class Frm_Employee_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Employee_Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.grpBox_Menus = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBox_Date = new System.Windows.Forms.GroupBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.grpBox_Name = new System.Windows.Forms.GroupBox();
            this.txtName_User = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBox_Menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox_Date.SuspendLayout();
            this.grpBox_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(678, 32);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menu_File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.logOutToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.logoutToolStripMenuItem.Text = "Profile";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.logoutToolStripMenuItem1.Text = "View Salary";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem2
            // 
            this.logOutToolStripMenuItem2.Name = "logOutToolStripMenuItem2";
            this.logOutToolStripMenuItem2.Size = new System.Drawing.Size(170, 26);
            this.logOutToolStripMenuItem2.Text = "Log out";
            this.logOutToolStripMenuItem2.Click += new System.EventHandler(this.logOutToolStripMenuItem2_Click);
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(503, 12);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 12;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBox_Menus
            // 
            this.grpBox_Menus.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Menus.Controls.Add(this.pictureBox4);
            this.grpBox_Menus.Controls.Add(this.pictureBox2);
            this.grpBox_Menus.Controls.Add(this.btnSalary);
            this.grpBox_Menus.Controls.Add(this.btnProfile);
            this.grpBox_Menus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Menus.ForeColor = System.Drawing.Color.LightBlue;
            this.grpBox_Menus.Location = new System.Drawing.Point(239, 109);
            this.grpBox_Menus.Name = "grpBox_Menus";
            this.grpBox_Menus.Size = new System.Drawing.Size(427, 248);
            this.grpBox_Menus.TabIndex = 14;
            this.grpBox_Menus.TabStop = false;
            this.grpBox_Menus.Text = "MENU";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::EmploNexus.Properties.Resources.compensation;
            this.pictureBox4.Location = new System.Drawing.Point(233, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EmploNexus.Properties.Resources.gearwheel;
            this.pictureBox2.Location = new System.Drawing.Point(61, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalary.BackgroundImage")));
            this.btnSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalary.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalary.Location = new System.Drawing.Point(233, 166);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(120, 53);
            this.btnSalary.TabIndex = 11;
            this.btnSalary.Text = "VIEW SALARY";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.LightBlue;
            this.btnProfile.BackgroundImage = global::EmploNexus.Properties.Resources.BACKIEGROUND;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnProfile.Location = new System.Drawing.Point(61, 166);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 53);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.sidePanel.BackgroundImage = global::EmploNexus.Properties.Resources.BACKIEGROUND;
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.grpBox_Date);
            this.sidePanel.Controls.Add(this.grpBox_Name);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 32);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(224, 337);
            this.sidePanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::EmploNexus.Properties.Resources._6765093_3429734;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // grpBox_Date
            // 
            this.grpBox_Date.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Date.Controls.Add(this.txtCurrentDate);
            this.grpBox_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Date.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grpBox_Date.Location = new System.Drawing.Point(10, 204);
            this.grpBox_Date.Name = "grpBox_Date";
            this.grpBox_Date.Size = new System.Drawing.Size(197, 64);
            this.grpBox_Date.TabIndex = 13;
            this.grpBox_Date.TabStop = false;
            this.grpBox_Date.Text = "Date";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentDate.Location = new System.Drawing.Point(18, 24);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentDate.TabIndex = 4;
            this.txtCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBox_Name
            // 
            this.grpBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Name.Controls.Add(this.txtName_User);
            this.grpBox_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Name.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grpBox_Name.Location = new System.Drawing.Point(10, 131);
            this.grpBox_Name.Name = "grpBox_Name";
            this.grpBox_Name.Size = new System.Drawing.Size(197, 64);
            this.grpBox_Name.TabIndex = 12;
            this.grpBox_Name.TabStop = false;
            this.grpBox_Name.Text = "Name";
            // 
            // txtName_User
            // 
            this.txtName_User.BackColor = System.Drawing.Color.LightCyan;
            this.txtName_User.Location = new System.Drawing.Point(18, 24);
            this.txtName_User.Name = "txtName_User";
            this.txtName_User.ReadOnly = true;
            this.txtName_User.Size = new System.Drawing.Size(163, 29);
            this.txtName_User.TabIndex = 4;
            this.txtName_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLogout.Location = new System.Drawing.Point(10, 289);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 34);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(230, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "EmploNexus: Dashboard";
            // 
            // Frm_Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources.alexandr_podvalny_n_Jb_d8O43Q_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.grpBox_Menus);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Employee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Employee Dashboard";
            this.Load += new System.EventHandler(this.Frm_Employee_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBox_Menus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox_Date.ResumeLayout(false);
            this.grpBox_Date.PerformLayout();
            this.grpBox_Name.ResumeLayout(false);
            this.grpBox_Name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem2;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.GroupBox grpBox_Menus;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBox_Date;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.GroupBox grpBox_Name;
        private System.Windows.Forms.TextBox txtName_User;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}