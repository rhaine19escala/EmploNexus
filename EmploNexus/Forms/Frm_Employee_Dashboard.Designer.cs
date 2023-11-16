
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName_User = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.grpBox_empInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbBox_position = new System.Windows.Forms.ComboBox();
            this.cmbBox_department = new System.Windows.Forms.ComboBox();
            this.dateTime_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmbBox_gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsystemName = new System.Windows.Forms.Label();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBox_empInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(767, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu_File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.profileToolStripMenuItem.Text = "Personal Information";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.logoutToolStripMenuItem.Text = "Salary Information";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.logoutToolStripMenuItem1.Text = "Log out";
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::EmploNexus.Properties.Resources._34377504_v894_kul_13_a;
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.txtName_User);
            this.sidePanel.Controls.Add(this.btnRequest);
            this.sidePanel.Controls.Add(this.btnSalary);
            this.sidePanel.Controls.Add(this.btnProfile);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 26);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(248, 473);
            this.sidePanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.LightBlue;
            this.btnLogout.Location = new System.Drawing.Point(30, 408);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(181, 42);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::EmploNexus.Properties.Resources._6765093_3429734;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtName_User
            // 
            this.txtName_User.BackColor = System.Drawing.Color.LightCyan;
            this.txtName_User.Location = new System.Drawing.Point(30, 180);
            this.txtName_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName_User.Name = "txtName_User";
            this.txtName_User.ReadOnly = true;
            this.txtName_User.Size = new System.Drawing.Size(181, 29);
            this.txtName_User.TabIndex = 4;
            this.txtName_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.LightBlue;
            this.btnRequest.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(30, 335);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(181, 42);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "REQUEST";
            this.btnRequest.UseVisualStyleBackColor = false;
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Location = new System.Drawing.Point(30, 286);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(181, 42);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "SALARY";
            this.btnSalary.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.LightBlue;
            this.btnProfile.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(30, 237);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(181, 42);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // grpBox_empInfo
            // 
            this.grpBox_empInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_empInfo.Controls.Add(this.txtEmail);
            this.grpBox_empInfo.Controls.Add(this.txtName);
            this.grpBox_empInfo.Controls.Add(this.cmbBox_position);
            this.grpBox_empInfo.Controls.Add(this.cmbBox_department);
            this.grpBox_empInfo.Controls.Add(this.dateTime_DOB);
            this.grpBox_empInfo.Controls.Add(this.cmbBox_gender);
            this.grpBox_empInfo.Controls.Add(this.label7);
            this.grpBox_empInfo.Controls.Add(this.label6);
            this.grpBox_empInfo.Controls.Add(this.label5);
            this.grpBox_empInfo.Controls.Add(this.label4);
            this.grpBox_empInfo.Controls.Add(this.txtIDnumber);
            this.grpBox_empInfo.Controls.Add(this.label3);
            this.grpBox_empInfo.Controls.Add(this.label2);
            this.grpBox_empInfo.Controls.Add(this.label1);
            this.grpBox_empInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpBox_empInfo.Location = new System.Drawing.Point(377, 139);
            this.grpBox_empInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBox_empInfo.Name = "grpBox_empInfo";
            this.grpBox_empInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBox_empInfo.Size = new System.Drawing.Size(377, 345);
            this.grpBox_empInfo.TabIndex = 7;
            this.grpBox_empInfo.TabStop = false;
            this.grpBox_empInfo.Text = "Employee Information";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmail.Location = new System.Drawing.Point(133, 216);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 31);
            this.txtEmail.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Location = new System.Drawing.Point(133, 99);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 31);
            this.txtName.TabIndex = 19;
            // 
            // cmbBox_position
            // 
            this.cmbBox_position.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBox_position.FormattingEnabled = true;
            this.cmbBox_position.Items.AddRange(new object[] {
            "HR Manager",
            "Recruiter",
            "Training and Development Specialist",
            "IT Manager",
            "Network Administrator",
            "Software Developer",
            "Chief Financial Officer (CFO)",
            "Accountant",
            "Financial Analyst"});
            this.cmbBox_position.Location = new System.Drawing.Point(133, 295);
            this.cmbBox_position.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBox_position.Name = "cmbBox_position";
            this.cmbBox_position.Size = new System.Drawing.Size(222, 30);
            this.cmbBox_position.TabIndex = 18;
            // 
            // cmbBox_department
            // 
            this.cmbBox_department.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBox_department.FormattingEnabled = true;
            this.cmbBox_department.Items.AddRange(new object[] {
            "Human Resources Department",
            "Information Technology Department",
            "Finance Department"});
            this.cmbBox_department.Location = new System.Drawing.Point(133, 255);
            this.cmbBox_department.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBox_department.Name = "cmbBox_department";
            this.cmbBox_department.Size = new System.Drawing.Size(222, 30);
            this.cmbBox_department.TabIndex = 17;
            // 
            // dateTime_DOB
            // 
            this.dateTime_DOB.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.dateTime_DOB.CustomFormat = " 11/12/2023";
            this.dateTime_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_DOB.Location = new System.Drawing.Point(133, 139);
            this.dateTime_DOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTime_DOB.Name = "dateTime_DOB";
            this.dateTime_DOB.Size = new System.Drawing.Size(222, 29);
            this.dateTime_DOB.TabIndex = 16;
            // 
            // cmbBox_gender
            // 
            this.cmbBox_gender.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBox_gender.FormattingEnabled = true;
            this.cmbBox_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbBox_gender.Location = new System.Drawing.Point(133, 177);
            this.cmbBox_gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBox_gender.Name = "cmbBox_gender";
            this.cmbBox_gender.Size = new System.Drawing.Size(222, 30);
            this.cmbBox_gender.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Job Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gender";
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.BackColor = System.Drawing.Color.LightCyan;
            this.txtIDnumber.Location = new System.Drawing.Point(133, 57);
            this.txtIDnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDnumber.Multiline = true;
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.Size = new System.Drawing.Size(222, 31);
            this.txtIDnumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Number";
            // 
            // lblsystemName
            // 
            this.lblsystemName.AutoSize = true;
            this.lblsystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblsystemName.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsystemName.ForeColor = System.Drawing.Color.LightBlue;
            this.lblsystemName.Location = new System.Drawing.Point(256, 49);
            this.lblsystemName.Name = "lblsystemName";
            this.lblsystemName.Size = new System.Drawing.Size(268, 50);
            this.lblsystemName.TabIndex = 6;
            this.lblsystemName.Text = "EmploNexus";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(572, 15);
            this.txtCurrentTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(181, 29);
            this.txtCurrentTime.TabIndex = 9;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources.antoine_rault_IhWRrZx4_kk_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 499);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.grpBox_empInfo);
            this.Controls.Add(this.lblsystemName);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Employee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Employee Dashboard";
            this.Load += new System.EventHandler(this.Frm_Employee_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBox_empInfo.ResumeLayout(false);
            this.grpBox_empInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.GroupBox grpBox_empInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbBox_position;
        private System.Windows.Forms.ComboBox cmbBox_department;
        private System.Windows.Forms.DateTimePicker dateTime_DOB;
        private System.Windows.Forms.ComboBox cmbBox_gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtName_User;
        private System.Windows.Forms.Label lblsystemName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtCurrentTime;
    }
}