
namespace EmploNexus
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblsystemName = new System.Windows.Forms.Label();
            this.grpbox_login = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linklbl_register = new System.Windows.Forms.LinkLabel();
            this.chckbox_showpass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbox_welcome = new System.Windows.Forms.GroupBox();
            this.prgBar_loading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpbox_login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpbox_welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.LightCyan;
            this.txtusername.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(109, 37);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(183, 29);
            this.txtusername.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblusername.Location = new System.Drawing.Point(10, 38);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(93, 24);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblpassword.Location = new System.Drawing.Point(14, 73);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(89, 24);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtpassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(109, 72);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(183, 29);
            this.txtpassword.TabIndex = 2;
            // 
            // lblsystemName
            // 
            this.lblsystemName.AutoSize = true;
            this.lblsystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblsystemName.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsystemName.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblsystemName.Location = new System.Drawing.Point(20, 14);
            this.lblsystemName.Name = "lblsystemName";
            this.lblsystemName.Size = new System.Drawing.Size(296, 54);
            this.lblsystemName.TabIndex = 4;
            this.lblsystemName.Text = "EmploNexus";
            // 
            // grpbox_login
            // 
            this.grpbox_login.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_login.Controls.Add(this.btnLogin);
            this.grpbox_login.Controls.Add(this.linklbl_register);
            this.grpbox_login.Controls.Add(this.chckbox_showpass);
            this.grpbox_login.Controls.Add(this.txtpassword);
            this.grpbox_login.Controls.Add(this.txtusername);
            this.grpbox_login.Controls.Add(this.lblpassword);
            this.grpbox_login.Controls.Add(this.lblusername);
            this.grpbox_login.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_login.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grpbox_login.Location = new System.Drawing.Point(21, 92);
            this.grpbox_login.Name = "grpbox_login";
            this.grpbox_login.Size = new System.Drawing.Size(314, 229);
            this.grpbox_login.TabIndex = 5;
            this.grpbox_login.TabStop = false;
            this.grpbox_login.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Location = new System.Drawing.Point(109, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linklbl_register
            // 
            this.linklbl_register.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linklbl_register.AutoSize = true;
            this.linklbl_register.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_register.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_register.ForeColor = System.Drawing.Color.Aqua;
            this.linklbl_register.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linklbl_register.Location = new System.Drawing.Point(110, 194);
            this.linklbl_register.Name = "linklbl_register";
            this.linklbl_register.Size = new System.Drawing.Size(177, 18);
            this.linklbl_register.TabIndex = 6;
            this.linklbl_register.TabStop = true;
            this.linklbl_register.Text = "No Account? Register now";
            this.linklbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_register_LinkClicked);
            // 
            // chckbox_showpass
            // 
            this.chckbox_showpass.AutoSize = true;
            this.chckbox_showpass.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_showpass.Location = new System.Drawing.Point(109, 107);
            this.chckbox_showpass.Name = "chckbox_showpass";
            this.chckbox_showpass.Size = new System.Drawing.Size(126, 22);
            this.chckbox_showpass.TabIndex = 4;
            this.chckbox_showpass.Text = "Show Password";
            this.chckbox_showpass.UseVisualStyleBackColor = true;
            this.chckbox_showpass.CheckedChanged += new System.EventHandler(this.chckbox_showpass_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EmploNexus.Properties.Resources._34377504_v894_kul_13_a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblsystemName);
            this.panel1.Controls.Add(this.grpbox_login);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 346);
            this.panel1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(27, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "EmploNexus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(82, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(99)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(192, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // grpbox_welcome
            // 
            this.grpbox_welcome.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpbox_welcome.Controls.Add(this.label3);
            this.grpbox_welcome.Controls.Add(this.label1);
            this.grpbox_welcome.Controls.Add(this.label2);
            this.grpbox_welcome.Location = new System.Drawing.Point(374, 0);
            this.grpbox_welcome.Name = "grpbox_welcome";
            this.grpbox_welcome.Size = new System.Drawing.Size(260, 323);
            this.grpbox_welcome.TabIndex = 10;
            this.grpbox_welcome.TabStop = false;
            // 
            // prgBar_loading
            // 
            this.prgBar_loading.Location = new System.Drawing.Point(0, 332);
            this.prgBar_loading.Name = "prgBar_loading";
            this.prgBar_loading.Size = new System.Drawing.Size(647, 34);
            this.prgBar_loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar_loading.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::EmploNexus.Properties.Resources.conference_room_with_desk_wall_windows_that_says_office;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 366);
            this.Controls.Add(this.prgBar_loading);
            this.Controls.Add(this.grpbox_welcome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grpbox_login.ResumeLayout(false);
            this.grpbox_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpbox_welcome.ResumeLayout(false);
            this.grpbox_welcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblsystemName;
        private System.Windows.Forms.GroupBox grpbox_login;
        private System.Windows.Forms.CheckBox chckbox_showpass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbl_register;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbox_welcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgBar_loading;
        private System.Windows.Forms.Timer timer1;
    }
}

