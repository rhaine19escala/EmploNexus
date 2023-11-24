
namespace EmploNexus.Forms
{
    partial class Frm_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registration));
            this.lblsystemName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpBox_useraccIfno = new System.Windows.Forms.GroupBox();
            this.cmbBoxRole = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtpass_word = new System.Windows.Forms.TextBox();
            this.txtuser_name = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.cmbBoxPosition = new System.Windows.Forms.ComboBox();
            this.cmbBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBox_useraccIfno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsystemName
            // 
            this.lblsystemName.AutoSize = true;
            this.lblsystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblsystemName.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsystemName.ForeColor = System.Drawing.Color.LightBlue;
            this.lblsystemName.Location = new System.Drawing.Point(12, 9);
            this.lblsystemName.Name = "lblsystemName";
            this.lblsystemName.Size = new System.Drawing.Size(296, 54);
            this.lblsystemName.TabIndex = 5;
            this.lblsystemName.Text = "EmploNexus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Confirm Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Role";
            // 
            // grpBox_useraccIfno
            // 
            this.grpBox_useraccIfno.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_useraccIfno.Controls.Add(this.txtConfirmPassword);
            this.grpBox_useraccIfno.Controls.Add(this.txtpass_word);
            this.grpBox_useraccIfno.Controls.Add(this.txtuser_name);
            this.grpBox_useraccIfno.Controls.Add(this.label10);
            this.grpBox_useraccIfno.Controls.Add(this.label9);
            this.grpBox_useraccIfno.Controls.Add(this.label8);
            this.grpBox_useraccIfno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBox_useraccIfno.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_useraccIfno.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grpBox_useraccIfno.Location = new System.Drawing.Point(12, 309);
            this.grpBox_useraccIfno.Name = "grpBox_useraccIfno";
            this.grpBox_useraccIfno.Size = new System.Drawing.Size(471, 145);
            this.grpBox_useraccIfno.TabIndex = 7;
            this.grpBox_useraccIfno.TabStop = false;
            this.grpBox_useraccIfno.Text = "Account Registration";
            this.grpBox_useraccIfno.Enter += new System.EventHandler(this.grpBox_useraccIfno_Enter);
            // 
            // cmbBoxRole
            // 
            this.cmbBoxRole.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBoxRole.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxRole.FormattingEnabled = true;
            this.cmbBoxRole.Location = new System.Drawing.Point(218, 174);
            this.cmbBoxRole.Name = "cmbBoxRole";
            this.cmbBoxRole.Size = new System.Drawing.Size(226, 30);
            this.cmbBoxRole.TabIndex = 21;
            this.cmbBoxRole.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRole_SelectedIndexChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.Location = new System.Drawing.Point(12, 467);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(471, 36);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(218, 101);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(226, 26);
            this.txtConfirmPassword.TabIndex = 23;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtpass_word
            // 
            this.txtpass_word.BackColor = System.Drawing.Color.LightCyan;
            this.txtpass_word.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass_word.Location = new System.Drawing.Point(218, 69);
            this.txtpass_word.Multiline = true;
            this.txtpass_word.Name = "txtpass_word";
            this.txtpass_word.Size = new System.Drawing.Size(226, 26);
            this.txtpass_word.TabIndex = 22;
            this.txtpass_word.TextChanged += new System.EventHandler(this.txtpass_word_TextChanged);
            // 
            // txtuser_name
            // 
            this.txtuser_name.BackColor = System.Drawing.Color.LightCyan;
            this.txtuser_name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser_name.Location = new System.Drawing.Point(218, 37);
            this.txtuser_name.Multiline = true;
            this.txtuser_name.Name = "txtuser_name";
            this.txtuser_name.Size = new System.Drawing.Size(226, 26);
            this.txtuser_name.TabIndex = 21;
            this.txtuser_name.TextChanged += new System.EventHandler(this.txtuser_name_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.Color.LightCyan;
            this.txtCurrentTime.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTime.Location = new System.Drawing.Point(324, 12);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentTime.TabIndex = 32;
            this.txtCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Job Position";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbBoxRole);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBoxGender);
            this.groupBox1.Controls.Add(this.cmbBoxPosition);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbBoxDepartment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 237);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmployeeID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(218, 34);
            this.txtEmployeeID.Multiline = true;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(226, 26);
            this.txtEmployeeID.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "Employee ID";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBoxGender.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Location = new System.Drawing.Point(218, 66);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(226, 30);
            this.cmbBoxGender.TabIndex = 35;
            this.cmbBoxGender.SelectedIndexChanged += new System.EventHandler(this.cmbBoxGender_SelectedIndexChanged);
            // 
            // cmbBoxPosition
            // 
            this.cmbBoxPosition.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBoxPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPosition.FormattingEnabled = true;
            this.cmbBoxPosition.Location = new System.Drawing.Point(218, 138);
            this.cmbBoxPosition.Name = "cmbBoxPosition";
            this.cmbBoxPosition.Size = new System.Drawing.Size(226, 30);
            this.cmbBoxPosition.TabIndex = 34;
            this.cmbBoxPosition.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPosition_SelectedIndexChanged);
            // 
            // cmbBoxDepartment
            // 
            this.cmbBoxDepartment.BackColor = System.Drawing.Color.LightCyan;
            this.cmbBoxDepartment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxDepartment.FormattingEnabled = true;
            this.cmbBoxDepartment.Location = new System.Drawing.Point(218, 102);
            this.cmbBoxDepartment.Name = "cmbBoxDepartment";
            this.cmbBoxDepartment.Size = new System.Drawing.Size(226, 30);
            this.cmbBoxDepartment.TabIndex = 24;
            this.cmbBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Gender";
            // 
            // Frm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources._6765093_3429734;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 520);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_useraccIfno);
            this.Controls.Add(this.lblsystemName);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Registration";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            this.grpBox_useraccIfno.ResumeLayout(false);
            this.grpBox_useraccIfno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsystemName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpBox_useraccIfno;
        private System.Windows.Forms.ComboBox cmbBoxRole;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtpass_word;
        private System.Windows.Forms.TextBox txtuser_name;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxPosition;
        private System.Windows.Forms.ComboBox cmbBoxDepartment;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label3;
    }
}