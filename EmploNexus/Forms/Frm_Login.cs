using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus.AppData;
using EmploNexus.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmploNexus
{
    public partial class Frm_Login : Form
    {
        public String user_Name = String.Empty;
        UserRepository userRepo;

        public Frm_Login()
        {
            InitializeComponent();
            //
            userRepo = new UserRepository();
          }

        private void Login_Load(object sender, EventArgs e)
        {
            //EDIT THIS ONE(NEEDED TO BE PASS ONTO ANOTHER FORM (ASAP!!)
            user_Name = txtusername.Text;
        }

        private void linklbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Registration frm = new Frm_Registration();
            frm.ShowDialog();

            txtusername.Text = frm.username;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(txtusername.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtusername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(txtusername.Text);

            btnLogin.Enabled = false; // Disable the button during the login process

            if (userLogged != null)
            {
                if (userLogged.password.Equals(txtpassword.Text))
                {
                    UserLogged.GetInstance().UserAccounts = userLogged;
                    timer1.Start();
                    await Task.Delay(15000);
                    timer1.Stop();

                    switch ((Role)userLogged.roleId)
                    {
                        case Role.Employee:
                            new Frm_Employee_Dashboard().Show();
                            this.Hide();
                            break;
                        case Role.Manager:
                            new Frm_Manager_Dashboard().Show();
                            this.Hide();
                            break;
                        case Role.Admin:
                            new Frm_Admin_Dashboard().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User Entered has no role!. Please try Again.", "EmploNexus: Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password. Please try Again.", "EmploNexus: Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Username Entered not Found! Please try Again.", "EmploNexus: Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Clear();
                txtpassword.Clear();
            }
            btnLogin.Enabled = true; 
        }




        private void chckbox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_showpass.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBar_loading.Increment(1);   
        }
    }
}
