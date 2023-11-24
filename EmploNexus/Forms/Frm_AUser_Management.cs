using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus;
using EmploNexus.AppData;

namespace EmploNexus.Forms
{
    public partial class Frm_AUser_Management : Form
    {
        UserRepository repo;
        private EmploNexusO_oEntities emploNexusEntities;

        public Frm_AUser_Management()
        {
            InitializeComponent();
            emploNexusEntities = new EmploNexusO_oEntities();

        }

        private void Frm_AUser_Management_Load(object sender, EventArgs e)
        {
            emploNexusEntities = new EmploNexusO_oEntities();
            dgv_AllUserWdetails.Refresh();
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            repo = new UserRepository();
            loadUser();
            loadCbBoxRole();
        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = emploNexusEntities.Roles.ToList();

            cmbBoxRole.ValueMember = "roleId";
            cmbBoxRole.DisplayMember = "roleName";
            cmbBoxRole.DataSource = roles;
        }

        private void loadUser()
        {
            dgv_AllUserWdetails.DataSource = repo.AllUserRole();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Frm_AEmployee_Management employee_Management = new Frm_AEmployee_Management();
            employee_Management.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Admin_Dashboard admin_Dashboard = new Frm_Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }

        private void dgv_AllUserWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtuser_empID.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtuserUsername.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[2].Value?.ToString();
                txtuserPassword.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[3].Value?.ToString();
                string role = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[4].Value?.ToString();
                cmbBoxRole.Text = role;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered: " + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtuser_empID.Text = "";
            txtuserUsername.Text = "";
            txtuserPassword.Text = "";
        }

        private void btnuserClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnuserAdd_Click(object sender, EventArgs e)
        {
            String empid = txtuser_empID.Text;
            String username = txtuserUsername.Text;
            String password = txtuserPassword.Text;

            if (String.IsNullOrEmpty(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_empID, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserPassword, "Empty Field!");
                return;
            }

            try
            {
                using (var db = new EmploNexusO_oEntities())
                {
                    UserAccount nUserAccount = new UserAccount
                    {
                        user_empID = Convert.ToInt32(txtuser_empID.Text),
                        username = txtuserUsername.Text,
                        password = txtuserPassword.Text,
                        roleId = (Int32)cmbBoxRole.SelectedValue,
                    };
                    db.UserAccounts.Add(nUserAccount);
                    db.SaveChanges();
                    loadUser();
                    MessageBox.Show("User Added Successfully!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User not Added Successfully!. \nError :" + ex.Message, "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnuserUpdate_Click(object sender, EventArgs e)
        {
            String empid = txtuser_empID.Text;
            String username = txtuserUsername.Text;
            String password = txtuserPassword.Text;

            if (String.IsNullOrEmpty(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_empID, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserPassword, "Empty Field!");
                return;
            }

            using (var db = new EmploNexusO_oEntities())
            {
                int user_empIDToUpdate = Convert.ToInt32(txtuser_empID.Text);

                UserAccount existingUser = db.UserAccounts.FirstOrDefault(u => u.user_empID == user_empIDToUpdate);
                try
                {
                    if (existingUser != null)
                    {
                        existingUser.username = txtuserUsername.Text;
                        existingUser.password = txtuserPassword.Text;
                        existingUser.roleId = (Int32)cmbBoxRole.SelectedValue;

                        db.SaveChanges();
                        loadUser();
                        MessageBox.Show("User Updated Successfully!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User not Updated Successfully!. \nError :" + ex.Message, "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
            }
        }

        private void btnuserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EmploNexusO_oEntities())
                {
                    int user_empIDToDelete = Convert.ToInt32(txtuser_empID.Text);

                    UserAccount userToDelete = db.UserAccounts.FirstOrDefault(u => u.user_empID == user_empIDToDelete);

                    if (userToDelete != null)
                    {
                        db.UserAccounts.Remove(userToDelete);
                        db.SaveChanges();
                        loadUser();
                        MessageBox.Show("User Deleted Successfully!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User not Deleted Successfully!. \nError :" + ex.Message, "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchEmpID = txtuser_empID.Text.Trim();
                string searchUsername = txtuserUsername.Text.Trim();
                string searchPassword = txtuserPassword.Text.Trim();

                using (var db = new EmploNexusO_oEntities())
                {
                    int? empID = !string.IsNullOrEmpty(searchEmpID) ? (int?)Convert.ToInt32(searchEmpID) : null;

                    var filteredUsers = db.UserAccounts
                        .Where(u =>
                            (empID == null || u.user_empID == empID) &&
                            (string.IsNullOrEmpty(searchUsername) || u.username.Contains(searchUsername)) &&
                            (string.IsNullOrEmpty(searchPassword) || u.password.Contains(searchPassword)))
                        .ToList();

                    dgv_AllUserWdetails.DataSource = filteredUsers;
                    loadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User not Found! Please try Again. \nError :" + ex.Message, "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
