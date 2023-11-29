
namespace EmploNexus.Forms
{
    partial class Frm_EViewSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EViewSalary));
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_SalaryEmp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.payrollDate = new System.Windows.Forms.DateTimePicker();
            this.txtempSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtempSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalaryEmp)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(750, 12);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 12;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "EmploNexus: Salary Information\r\n";
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
            this.menuStrip1.Size = new System.Drawing.Size(925, 32);
            this.menuStrip1.TabIndex = 18;
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Enabled = false;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.logoutToolStripMenuItem1.Text = "Salary Details";
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
            this.logOutToolStripMenuItem2.Click += new System.EventHandler(this.logOutToolStripMenuItem2_Click_1);
            // 
            // dgv_SalaryEmp
            // 
            this.dgv_SalaryEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SalaryEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_SalaryEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SalaryEmp.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_SalaryEmp.Location = new System.Drawing.Point(469, 66);
            this.dgv_SalaryEmp.Name = "dgv_SalaryEmp";
            this.dgv_SalaryEmp.ReadOnly = true;
            this.dgv_SalaryEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SalaryEmp.Size = new System.Drawing.Size(421, 222);
            this.dgv_SalaryEmp.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtempSearch);
            this.panel1.Controls.Add(this.grpEmployee);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.dgv_SalaryEmp);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 304);
            this.panel1.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 32);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Salary Information :";
            // 
            // grpEmployee
            // 
            this.grpEmployee.BackColor = System.Drawing.Color.Transparent;
            this.grpEmployee.Controls.Add(this.payrollDate);
            this.grpEmployee.Controls.Add(this.txtempSalary);
            this.grpEmployee.Controls.Add(this.label8);
            this.grpEmployee.Controls.Add(this.label2);
            this.grpEmployee.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployee.ForeColor = System.Drawing.Color.LightBlue;
            this.grpEmployee.Location = new System.Drawing.Point(18, 66);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(438, 222);
            this.grpEmployee.TabIndex = 36;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Salary Details";
            // 
            // payrollDate
            // 
            this.payrollDate.CustomFormat = "";
            this.payrollDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollDate.Location = new System.Drawing.Point(186, 82);
            this.payrollDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.payrollDate.Name = "payrollDate";
            this.payrollDate.Size = new System.Drawing.Size(230, 29);
            this.payrollDate.TabIndex = 32;
            // 
            // txtempSalary
            // 
            this.txtempSalary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempSalary.Location = new System.Drawing.Point(186, 44);
            this.txtempSalary.Name = "txtempSalary";
            this.txtempSalary.Size = new System.Drawing.Size(230, 29);
            this.txtempSalary.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label8.Location = new System.Drawing.Point(17, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Wage Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Payment Date";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnSearch.BackgroundImage = global::EmploNexus.Properties.Resources.magnifying_glass;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.Location = new System.Drawing.Point(827, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 31);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnRefresh.BackgroundImage = global::EmploNexus.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnRefresh.Location = new System.Drawing.Point(860, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 31);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SkyBlue;
            this.label10.Location = new System.Drawing.Point(469, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 28);
            this.label10.TabIndex = 47;
            this.label10.Text = "Search :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtempSearch
            // 
            this.txtempSearch.Location = new System.Drawing.Point(560, 30);
            this.txtempSearch.Name = "txtempSearch";
            this.txtempSearch.Size = new System.Drawing.Size(262, 29);
            this.txtempSearch.TabIndex = 46;
            // 
            // Frm_EViewSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_EViewSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Salary";
            this.Load += new System.EventHandler(this.Frm_Employee_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalaryEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgv_SalaryEmp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.DateTimePicker payrollDate;
        private System.Windows.Forms.TextBox txtempSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtempSearch;
    }
}