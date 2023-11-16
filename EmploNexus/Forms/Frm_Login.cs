using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private BackgroundWorker loginWorker;

        public Frm_Login()
        {
            InitializeComponent();
            //
            userRepo = new UserRepository();

            // Initialize BackgroundWorker
            loginWorker = new BackgroundWorker();
            loginWorker.WorkerReportsProgress = true;
            loginWorker.DoWork += LoginWorker_DoWork;
            loginWorker.ProgressChanged += LoginWorker_ProgressChanged;
            loginWorker.RunWorkerCompleted += LoginWorker_RunWorkerCompleted;
        }

        private void LoginWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simulate a time-consuming task (e.g., database validation)
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50); // Simulate work being done
                loginWorker.ReportProgress(i);
            }
        }

        private void LoginWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgBar_loading.Value = e.ProgressPercentage;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //EDIT THIS ONE(NEEDED TO BE PASS ONTO ANOTHER FORM
            user_Name = txtusername.Text;
        }

        private void linklbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Instantiate new object of class Frm_Register
            Frm_Registration frm = new Frm_Registration();
            frm.ShowDialog();

            txtusername.Text = frm.username;
        }

        private void LoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnLogin.Enabled = true;

            var userLogged = userRepo.GetUserByUsername(txtusername.Text);

            if (userLogged != null)
            {
                if (userLogged.password.Equals(txtpassword.Text))
                {
                    UserLogged.GetInstance().UserAccounts = userLogged;

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
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(txtusername.Text))
            {
                errorProvider1.SetError(txtusername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.SetError(txtpassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(txtusername.Text);

            if (userLogged != null)
            {
                if (userLogged.password.Equals(txtpassword.Text))
                {
                    // Start the background worker only if the credentials are valid
                    loginWorker.RunWorkerAsync();
                    btnLogin.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
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
