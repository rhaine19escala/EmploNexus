namespace EmploNexus.Forms
{
    partial class Frm_AUser_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AUser_Management));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnuserDelete = new System.Windows.Forms.Button();
            this.btnuserAdd = new System.Windows.Forms.Button();
            this.btnuserClear = new System.Windows.Forms.Button();
            this.btnuserUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuserUsername = new System.Windows.Forms.TextBox();
            this.txtuserPassword = new System.Windows.Forms.TextBox();
            this.txtuser_empID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtuserSearch = new System.Windows.Forms.TextBox();
            this.dgv_AllUserWdetails = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUserWdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1085, 32);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menu_File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 26);
            this.toolStripMenuItem2.Text = "File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem3.Text = "Back";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem4.Text = "User Account Management";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem5.Text = "Employee Management";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem6.Text = "Salary Management";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem7.Text = "Log out";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "EmploNexus: User Account Management";
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(910, 12);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 18;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtuserSearch);
            this.panel1.Controls.Add(this.dgv_AllUserWdetails);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 388);
            this.panel1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnuserDelete);
            this.groupBox2.Controls.Add(this.btnuserAdd);
            this.groupBox2.Controls.Add(this.btnuserClear);
            this.groupBox2.Controls.Add(this.btnuserUpdate);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 83);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btnuserDelete
            // 
            this.btnuserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnuserDelete.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserDelete.Location = new System.Drawing.Point(219, 32);
            this.btnuserDelete.Name = "btnuserDelete";
            this.btnuserDelete.Size = new System.Drawing.Size(92, 32);
            this.btnuserDelete.TabIndex = 30;
            this.btnuserDelete.Text = "DELETE";
            this.btnuserDelete.UseVisualStyleBackColor = false;
            // 
            // btnuserAdd
            // 
            this.btnuserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnuserAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserAdd.Location = new System.Drawing.Point(23, 32);
            this.btnuserAdd.Name = "btnuserAdd";
            this.btnuserAdd.Size = new System.Drawing.Size(92, 32);
            this.btnuserAdd.TabIndex = 28;
            this.btnuserAdd.Text = "ADD";
            this.btnuserAdd.UseVisualStyleBackColor = false;
            this.btnuserAdd.Click += new System.EventHandler(this.btnuserAdd_Click);
            // 
            // btnuserClear
            // 
            this.btnuserClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnuserClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserClear.Location = new System.Drawing.Point(317, 32);
            this.btnuserClear.Name = "btnuserClear";
            this.btnuserClear.Size = new System.Drawing.Size(92, 32);
            this.btnuserClear.TabIndex = 31;
            this.btnuserClear.Text = "CLEAR";
            this.btnuserClear.UseVisualStyleBackColor = false;
            this.btnuserClear.Click += new System.EventHandler(this.btnuserClear_Click);
            // 
            // btnuserUpdate
            // 
            this.btnuserUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnuserUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserUpdate.Location = new System.Drawing.Point(121, 32);
            this.btnuserUpdate.Name = "btnuserUpdate";
            this.btnuserUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnuserUpdate.TabIndex = 29;
            this.btnuserUpdate.Text = "UPDATE";
            this.btnuserUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbBoxRole);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtuserUsername);
            this.groupBox1.Controls.Add(this.txtuserPassword);
            this.groupBox1.Controls.Add(this.txtuser_empID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 243);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBoxRole.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Location = new System.Drawing.Point(179, 192);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(230, 34);
            this.cmbBoxRole.TabIndex = 37;
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.LightCyan;
            this.txtUserID.Location = new System.Drawing.Point(179, 36);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(230, 33);
            this.txtUserID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label6.Location = new System.Drawing.Point(27, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "Role";
            // 
            // txtuserUsername
            // 
            this.txtuserUsername.BackColor = System.Drawing.Color.LightCyan;
            this.txtuserUsername.Location = new System.Drawing.Point(179, 114);
            this.txtuserUsername.Name = "txtuserUsername";
            this.txtuserUsername.Size = new System.Drawing.Size(230, 33);
            this.txtuserUsername.TabIndex = 18;
            // 
            // txtuserPassword
            // 
            this.txtuserPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtuserPassword.Location = new System.Drawing.Point(179, 153);
            this.txtuserPassword.Name = "txtuserPassword";
            this.txtuserPassword.Size = new System.Drawing.Size(230, 33);
            this.txtuserPassword.TabIndex = 32;
            // 
            // txtuser_empID
            // 
            this.txtuser_empID.BackColor = System.Drawing.Color.LightCyan;
            this.txtuser_empID.Location = new System.Drawing.Point(179, 75);
            this.txtuser_empID.Name = "txtuser_empID";
            this.txtuser_empID.Size = new System.Drawing.Size(230, 33);
            this.txtuser_empID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(27, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 32);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "User Details :";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.LightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.lblSearch.Location = new System.Drawing.Point(457, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(82, 26);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnSearch.BackgroundImage = global::EmploNexus.Properties.Resources.magnifying_glass;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(1010, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtuserSearch
            // 
            this.txtuserSearch.BackColor = System.Drawing.Color.LightCyan;
            this.txtuserSearch.Location = new System.Drawing.Point(551, 14);
            this.txtuserSearch.Name = "txtuserSearch";
            this.txtuserSearch.Size = new System.Drawing.Size(453, 29);
            this.txtuserSearch.TabIndex = 10;
            // 
            // dgv_AllUserWdetails
            // 
            this.dgv_AllUserWdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_AllUserWdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_AllUserWdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllUserWdetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_AllUserWdetails.Location = new System.Drawing.Point(457, 51);
            this.dgv_AllUserWdetails.Name = "dgv_AllUserWdetails";
            this.dgv_AllUserWdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllUserWdetails.Size = new System.Drawing.Size(582, 324);
            this.dgv_AllUserWdetails.TabIndex = 9;
            this.dgv_AllUserWdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AllUserWdetails_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_AUser_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources.alexandr_podvalny_n_Jb_d8O43Q_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_AUser_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: User Account Management";
            this.Load += new System.EventHandler(this.Frm_AUser_Management_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllUserWdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnuserClear;
        private System.Windows.Forms.Button btnuserDelete;
        private System.Windows.Forms.Button btnuserUpdate;
        private System.Windows.Forms.Button btnuserAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtuserUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser_empID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtuserSearch;
        private System.Windows.Forms.DataGridView dgv_AllUserWdetails;
        private System.Windows.Forms.TextBox txtuserPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxRole;
    }
}