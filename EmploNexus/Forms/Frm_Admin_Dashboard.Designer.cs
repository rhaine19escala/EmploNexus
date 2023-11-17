﻿
namespace EmploNexus.Forms
{
    partial class Frm_Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.lblsystemName = new System.Windows.Forms.Label();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.grpBox_Menus = new System.Windows.Forms.GroupBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.grpBox_Name = new System.Windows.Forms.GroupBox();
            this.txtName_User = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grpBox_Menus.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBox_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(678, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menu_File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.logOutToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem1.Text = "Dashboard";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.profileToolStripMenuItem.Text = "User Account Management";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.logoutToolStripMenuItem.Text = "Employee Management";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(280, 26);
            this.logoutToolStripMenuItem1.Text = "Payroll Management";
            // 
            // logOutToolStripMenuItem2
            // 
            this.logOutToolStripMenuItem2.Name = "logOutToolStripMenuItem2";
            this.logOutToolStripMenuItem2.Size = new System.Drawing.Size(280, 26);
            this.logOutToolStripMenuItem2.Text = "Log out";
            this.logOutToolStripMenuItem2.Click += new System.EventHandler(this.logOutToolStripMenuItem2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "USER ACCOUNT MANAGEMENT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Location = new System.Drawing.Point(72, 203);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(306, 31);
            this.btnSalary.TabIndex = 11;
            this.btnSalary.Text = "SALARY MANAGEMENT";
            this.btnSalary.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.LightBlue;
            this.btnEmployee.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(72, 166);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(306, 31);
            this.btnEmployee.TabIndex = 10;
            this.btnEmployee.Text = "EMPLOYEE MANAGEMENT";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // lblsystemName
            // 
            this.lblsystemName.AutoSize = true;
            this.lblsystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblsystemName.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsystemName.ForeColor = System.Drawing.Color.LightBlue;
            this.lblsystemName.Location = new System.Drawing.Point(327, 46);
            this.lblsystemName.Name = "lblsystemName";
            this.lblsystemName.Size = new System.Drawing.Size(268, 50);
            this.lblsystemName.TabIndex = 7;
            this.lblsystemName.Text = "EmploNexus";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(503, 12);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 8;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBox_Menus
            // 
            this.grpBox_Menus.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Menus.Controls.Add(this.btnSalary);
            this.grpBox_Menus.Controls.Add(this.btnEmployee);
            this.grpBox_Menus.Controls.Add(this.button1);
            this.grpBox_Menus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Menus.Location = new System.Drawing.Point(239, 105);
            this.grpBox_Menus.Name = "grpBox_Menus";
            this.grpBox_Menus.Size = new System.Drawing.Size(427, 252);
            this.grpBox_Menus.TabIndex = 13;
            this.grpBox_Menus.TabStop = false;
            this.grpBox_Menus.Text = "MENU";
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::EmploNexus.Properties.Resources._34377504_v894_kul_13_a;
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.groupBox1);
            this.sidePanel.Controls.Add(this.grpBox_Name);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 32);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(224, 337);
            this.sidePanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EmploNexus.Properties.Resources.employee_account_business_time_clock_icon_124657;
            this.pictureBox2.Location = new System.Drawing.Point(239, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCurrentDate);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Login";
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
            this.btnLogout.Location = new System.Drawing.Point(28, 289);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 34);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EmploNexus.Properties.Resources._6765093_3429734;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 369);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpBox_Menus);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.lblsystemName);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Administrator Dashboard";
            this.Load += new System.EventHandler(this.Frm_Admin_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBox_Menus.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox_Name.ResumeLayout(false);
            this.grpBox_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtName_User;
        private System.Windows.Forms.Label lblsystemName;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem2;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpBox_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpBox_Menus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}