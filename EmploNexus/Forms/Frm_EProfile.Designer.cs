
namespace EmploNexus.Forms
{
    partial class Frm_EProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EProfile));
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtempDepartment = new System.Windows.Forms.TextBox();
            this.txtempPosition = new System.Windows.Forms.TextBox();
            this.txtempGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.txtempID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.DOB_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtuserUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpButtons.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(179, 116);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(171, 30);
            this.checkPass.TabIndex = 22;
            this.checkPass.Text = "Show Password";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label8.Location = new System.Drawing.Point(32, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            // 
            // txtempDepartment
            // 
            this.txtempDepartment.BackColor = System.Drawing.Color.LightCyan;
            this.txtempDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempDepartment.Location = new System.Drawing.Point(172, 218);
            this.txtempDepartment.Name = "txtempDepartment";
            this.txtempDepartment.Size = new System.Drawing.Size(230, 29);
            this.txtempDepartment.TabIndex = 39;
            // 
            // txtempPosition
            // 
            this.txtempPosition.BackColor = System.Drawing.Color.LightCyan;
            this.txtempPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempPosition.Location = new System.Drawing.Point(172, 254);
            this.txtempPosition.Name = "txtempPosition";
            this.txtempPosition.Size = new System.Drawing.Size(230, 29);
            this.txtempPosition.TabIndex = 40;
            // 
            // txtempGender
            // 
            this.txtempGender.BackColor = System.Drawing.Color.LightCyan;
            this.txtempGender.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempGender.Location = new System.Drawing.Point(172, 113);
            this.txtempGender.Name = "txtempGender";
            this.txtempGender.Size = new System.Drawing.Size(230, 29);
            this.txtempGender.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 44);
            this.label1.TabIndex = 40;
            this.label1.Text = "EmploNexus: Profile";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.LightCyan;
            this.txtPass.Location = new System.Drawing.Point(179, 77);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(217, 33);
            this.txtPass.TabIndex = 21;
            // 
            // grpButtons
            // 
            this.grpButtons.BackColor = System.Drawing.Color.Transparent;
            this.grpButtons.Controls.Add(this.txtCurrentDate);
            this.grpButtons.Controls.Add(this.btnSAVE);
            this.grpButtons.Controls.Add(this.btnEDIT);
            this.grpButtons.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpButtons.ForeColor = System.Drawing.Color.LightBlue;
            this.grpButtons.Location = new System.Drawing.Point(450, 279);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(424, 135);
            this.grpButtons.TabIndex = 43;
            this.grpButtons.TabStop = false;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentDate.Location = new System.Drawing.Point(37, 36);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(359, 33);
            this.txtCurrentDate.TabIndex = 38;
            this.txtCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnSAVE.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.LightBlue;
            this.btnSAVE.Location = new System.Drawing.Point(37, 82);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(169, 32);
            this.btnSAVE.TabIndex = 28;
            this.btnSAVE.Text = "SAVE PROFILE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnEDIT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.LightBlue;
            this.btnEDIT.Location = new System.Drawing.Point(227, 82);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(169, 32);
            this.btnEDIT.TabIndex = 29;
            this.btnEDIT.Text = "EDIT PROFILE";
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(719, 21);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 39;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpEmployee
            // 
            this.grpEmployee.BackColor = System.Drawing.Color.Transparent;
            this.grpEmployee.Controls.Add(this.txtempDepartment);
            this.grpEmployee.Controls.Add(this.txtempPosition);
            this.grpEmployee.Controls.Add(this.txtempGender);
            this.grpEmployee.Controls.Add(this.txtempID);
            this.grpEmployee.Controls.Add(this.label9);
            this.grpEmployee.Controls.Add(this.label2);
            this.grpEmployee.Controls.Add(this.txtempName);
            this.grpEmployee.Controls.Add(this.DOB_date);
            this.grpEmployee.Controls.Add(this.label3);
            this.grpEmployee.Controls.Add(this.txtempEmail);
            this.grpEmployee.Controls.Add(this.label4);
            this.grpEmployee.Controls.Add(this.label5);
            this.grpEmployee.Controls.Add(this.label6);
            this.grpEmployee.Controls.Add(this.label7);
            this.grpEmployee.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployee.ForeColor = System.Drawing.Color.LightBlue;
            this.grpEmployee.Location = new System.Drawing.Point(20, 109);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(424, 305);
            this.grpEmployee.TabIndex = 41;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee Details";
            // 
            // txtempID
            // 
            this.txtempID.BackColor = System.Drawing.Color.LightCyan;
            this.txtempID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempID.Location = new System.Drawing.Point(172, 42);
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(230, 29);
            this.txtempID.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightBlue;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label9.Location = new System.Drawing.Point(26, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "Birthdate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employee ID";
            // 
            // txtempName
            // 
            this.txtempName.BackColor = System.Drawing.Color.LightCyan;
            this.txtempName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempName.Location = new System.Drawing.Point(172, 77);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(230, 29);
            this.txtempName.TabIndex = 16;
            // 
            // DOB_date
            // 
            this.DOB_date.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.DOB_date.CustomFormat = "";
            this.DOB_date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_date.Location = new System.Drawing.Point(172, 148);
            this.DOB_date.Name = "DOB_date";
            this.DOB_date.Size = new System.Drawing.Size(230, 29);
            this.DOB_date.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // txtempEmail
            // 
            this.txtempEmail.BackColor = System.Drawing.Color.LightCyan;
            this.txtempEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempEmail.Location = new System.Drawing.Point(172, 183);
            this.txtempEmail.Name = "txtempEmail";
            this.txtempEmail.Size = new System.Drawing.Size(230, 29);
            this.txtempEmail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(26, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label6.Location = new System.Drawing.Point(26, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(26, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Job Position";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkPass);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtuserUsername);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(450, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 164);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // txtuserUsername
            // 
            this.txtuserUsername.BackColor = System.Drawing.Color.LightCyan;
            this.txtuserUsername.Location = new System.Drawing.Point(179, 37);
            this.txtuserUsername.Name = "txtuserUsername";
            this.txtuserUsername.Size = new System.Drawing.Size(217, 33);
            this.txtuserUsername.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightBlue;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label11.Location = new System.Drawing.Point(32, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "Username";
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
            this.menuStrip1.Size = new System.Drawing.Size(894, 32);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menu_File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.logoutToolStripMenuItem.Text = "Back";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.logoutToolStripMenuItem1.Text = "Salary Details";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem1.Text = "Attendance Details";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem2
            // 
            this.logOutToolStripMenuItem2.Name = "logOutToolStripMenuItem2";
            this.logOutToolStripMenuItem2.Size = new System.Drawing.Size(220, 26);
            this.logOutToolStripMenuItem2.Text = "Log out";
            this.logOutToolStripMenuItem2.Click += new System.EventHandler(this.logOutToolStripMenuItem2_Click);
            // 
            // Frm_EProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources._6765093_3429734;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 423);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_EProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Profile";
            this.Load += new System.EventHandler(this.Frm_Employee_Dashboard_Load);
            this.grpButtons.ResumeLayout(false);
            this.grpButtons.PerformLayout();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtempDepartment;
        private System.Windows.Forms.TextBox txtempPosition;
        private System.Windows.Forms.TextBox txtempGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.DateTimePicker DOB_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtuserUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem2;
    }
}