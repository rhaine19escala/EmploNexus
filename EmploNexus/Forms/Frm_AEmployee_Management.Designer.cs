namespace EmploNexus.Forms
{
    partial class Frm_AEmployee_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AEmployee_Management));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBox_empPosition = new System.Windows.Forms.ComboBox();
            this.cmbBox_empDepartment = new System.Windows.Forms.ComboBox();
            this.cmbBox_empGender = new System.Windows.Forms.ComboBox();
            this.btnempClear = new System.Windows.Forms.Button();
            this.btnempDelete = new System.Windows.Forms.Button();
            this.btnempUpdate = new System.Windows.Forms.Button();
            this.btnempAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtempSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtempEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtempSearch = new System.Windows.Forms.TextBox();
            this.dgv_AllEmployeesWdetails = new System.Windows.Forms.DataGridView();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllEmployeesWdetails)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmploNexus: Employee Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbBox_empPosition);
            this.panel1.Controls.Add(this.cmbBox_empDepartment);
            this.panel1.Controls.Add(this.cmbBox_empGender);
            this.panel1.Controls.Add(this.btnempClear);
            this.panel1.Controls.Add(this.btnempDelete);
            this.panel1.Controls.Add(this.btnempUpdate);
            this.panel1.Controls.Add(this.btnempAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtempSalary);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtempEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtempName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtempID);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtempSearch);
            this.panel1.Controls.Add(this.dgv_AllEmployeesWdetails);
            this.panel1.Location = new System.Drawing.Point(20, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 367);
            this.panel1.TabIndex = 12;
            // 
            // cmbBox_empPosition
            // 
            this.cmbBox_empPosition.FormattingEnabled = true;
            this.cmbBox_empPosition.Location = new System.Drawing.Point(165, 235);
            this.cmbBox_empPosition.Name = "cmbBox_empPosition";
            this.cmbBox_empPosition.Size = new System.Drawing.Size(230, 30);
            this.cmbBox_empPosition.TabIndex = 34;
            // 
            // cmbBox_empDepartment
            // 
            this.cmbBox_empDepartment.FormattingEnabled = true;
            this.cmbBox_empDepartment.Location = new System.Drawing.Point(165, 199);
            this.cmbBox_empDepartment.Name = "cmbBox_empDepartment";
            this.cmbBox_empDepartment.Size = new System.Drawing.Size(230, 30);
            this.cmbBox_empDepartment.TabIndex = 33;
            // 
            // cmbBox_empGender
            // 
            this.cmbBox_empGender.FormattingEnabled = true;
            this.cmbBox_empGender.Location = new System.Drawing.Point(165, 163);
            this.cmbBox_empGender.Name = "cmbBox_empGender";
            this.cmbBox_empGender.Size = new System.Drawing.Size(230, 30);
            this.cmbBox_empGender.TabIndex = 32;
            // 
            // btnempClear
            // 
            this.btnempClear.Location = new System.Drawing.Point(307, 315);
            this.btnempClear.Name = "btnempClear";
            this.btnempClear.Size = new System.Drawing.Size(92, 32);
            this.btnempClear.TabIndex = 31;
            this.btnempClear.Text = "CLEAR";
            this.btnempClear.UseVisualStyleBackColor = true;
            this.btnempClear.Click += new System.EventHandler(this.btnempClear_Click);
            // 
            // btnempDelete
            // 
            this.btnempDelete.Location = new System.Drawing.Point(209, 315);
            this.btnempDelete.Name = "btnempDelete";
            this.btnempDelete.Size = new System.Drawing.Size(92, 32);
            this.btnempDelete.TabIndex = 30;
            this.btnempDelete.Text = "DELETE";
            this.btnempDelete.UseVisualStyleBackColor = true;
            this.btnempDelete.Click += new System.EventHandler(this.btnempDelete_Click);
            // 
            // btnempUpdate
            // 
            this.btnempUpdate.Location = new System.Drawing.Point(111, 315);
            this.btnempUpdate.Name = "btnempUpdate";
            this.btnempUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnempUpdate.TabIndex = 29;
            this.btnempUpdate.Text = "UPDATE";
            this.btnempUpdate.UseVisualStyleBackColor = true;
            this.btnempUpdate.Click += new System.EventHandler(this.btnempUpdate_Click);
            // 
            // btnempAdd
            // 
            this.btnempAdd.Location = new System.Drawing.Point(13, 315);
            this.btnempAdd.Name = "btnempAdd";
            this.btnempAdd.Size = new System.Drawing.Size(92, 32);
            this.btnempAdd.TabIndex = 28;
            this.btnempAdd.Text = "ADD";
            this.btnempAdd.UseVisualStyleBackColor = true;
            this.btnempAdd.Click += new System.EventHandler(this.btnempAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label8.Location = new System.Drawing.Point(13, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Salary";
            // 
            // txtempSalary
            // 
            this.txtempSalary.Location = new System.Drawing.Point(165, 271);
            this.txtempSalary.Name = "txtempSalary";
            this.txtempSalary.Size = new System.Drawing.Size(230, 29);
            this.txtempSalary.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(13, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Job Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label6.Location = new System.Drawing.Point(13, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "E-mail";
            // 
            // txtempEmail
            // 
            this.txtempEmail.Location = new System.Drawing.Point(165, 128);
            this.txtempEmail.Name = "txtempEmail";
            this.txtempEmail.Size = new System.Drawing.Size(230, 29);
            this.txtempEmail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name";
            // 
            // txtempName
            // 
            this.txtempName.Location = new System.Drawing.Point(165, 93);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(230, 29);
            this.txtempName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employee ID";
            // 
            // txtempID
            // 
            this.txtempID.Location = new System.Drawing.Point(165, 58);
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(230, 29);
            this.txtempID.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 32);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Employee Details :";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.LightBlue;
            this.lblSearch.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.lblSearch.Location = new System.Drawing.Point(413, 13);
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
            this.btnSearch.Location = new System.Drawing.Point(813, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtempSearch
            // 
            this.txtempSearch.Location = new System.Drawing.Point(504, 12);
            this.txtempSearch.Name = "txtempSearch";
            this.txtempSearch.Size = new System.Drawing.Size(302, 29);
            this.txtempSearch.TabIndex = 10;
            // 
            // dgv_AllEmployeesWdetails
            // 
            this.dgv_AllEmployeesWdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllEmployeesWdetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_AllEmployeesWdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllEmployeesWdetails.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_AllEmployeesWdetails.Location = new System.Drawing.Point(412, 49);
            this.dgv_AllEmployeesWdetails.Name = "dgv_AllEmployeesWdetails";
            this.dgv_AllEmployeesWdetails.Size = new System.Drawing.Size(430, 298);
            this.dgv_AllEmployeesWdetails.TabIndex = 9;
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(725, 12);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 9;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.menuStrip2.Size = new System.Drawing.Size(900, 32);
            this.menuStrip2.TabIndex = 15;
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
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem4.Text = "User Account Management";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(280, 26);
            this.toolStripMenuItem5.Text = "Employee Management";
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
            // Frm_AEmployee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources.alexandr_podvalny_n_Jb_d8O43Q_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_AEmployee_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus : Employee Management";
            this.Load += new System.EventHandler(this.Frm_Employee_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllEmployeesWdetails)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_AllEmployeesWdetails;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.TextBox txtempSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtempSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtempEmail;
        private System.Windows.Forms.Button btnempDelete;
        private System.Windows.Forms.Button btnempUpdate;
        private System.Windows.Forms.Button btnempAdd;
        private System.Windows.Forms.Button btnempClear;
        private System.Windows.Forms.ComboBox cmbBox_empPosition;
        private System.Windows.Forms.ComboBox cmbBox_empDepartment;
        private System.Windows.Forms.ComboBox cmbBox_empGender;
    }
}