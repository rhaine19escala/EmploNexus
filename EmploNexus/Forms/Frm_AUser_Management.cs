using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus;
using EmploNexus.AppData;

namespace EmploNexus.Forms
{
    public partial class Frm_AUser_Management : Form
    {
        UserRepository repo;
        private EmploNexusu_uEntities emploNexusEntities;

        public Frm_AUser_Management()
        {
            InitializeComponent();
            emploNexusEntities = new EmploNexusu_uEntities();

        }

        private void Frm_AUser_Management_Load(object sender, EventArgs e)
        {
            emploNexusEntities = new EmploNexusu_uEntities();
            repo = new UserRepository();

            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
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
            dgv_AllUserWdetails.DataSource = repo.GetAllUserRole();
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
                if (e.RowIndex >= 0 && e.RowIndex < dgv_AllUserWdetails.Rows.Count)
                {
                    txtuser_empID.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    txtuserUsername.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[2].Value?.ToString();
                    txtuserPassword.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[3].Value?.ToString();
                    string role = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[4].Value?.ToString();
                    cmbBoxRole.Text = role;
                }
                else
                {
                    MessageBox.Show("Invalid row index selected.", "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered: " + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            errorProvider1.Clear();
            txtuser_empID.Clear();
            txtuserUsername.Clear();
            txtuserPassword.Clear();
            cmbBoxRole.SelectedIndex = 0;
        }

        private void btnuserClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private bool UserEmpIDExists(int userEmpID, DataGridView userAccountsTable)
        {
            foreach (DataGridViewRow row in userAccountsTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    int otherUserEmpID = Convert.ToInt32(row.Cells["EMPLOYEE_ID"].Value);
                    if (otherUserEmpID == userEmpID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool UsernameExists(string username, DataGridView userTable)
        {
            foreach (DataGridViewRow row in userTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    string otherUsername = row.Cells["USERNAME"].Value as string;
                    if (string.Equals(otherUsername, username, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsValidEmpID(string employeeID)
        {
            // Use \d to match digits, and {8} to specify the length as 8
            string employeeIDPattern = @"^\d{8}$";
            bool isValid = Regex.IsMatch(employeeID, employeeIDPattern);
            return isValid;
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
            if (!IsValidEmpID(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_empID, "Invalid Employee ID Format!");
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
            int userEmpID = Convert.ToInt32(empid);
            if (UserEmpIDExists(userEmpID, dgv_AllUserWdetails))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_empID, $"Employee with ID {userEmpID} is already added!");
                return;
            }
            if (UsernameExists(username, dgv_AllUserWdetails))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserUsername, $"Username '{username}' already exists!");
                return;
            }

            try
            {
                using (var db = new EmploNexusu_uEntities())
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
                    ClearInputFields();
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
            if (!IsValidEmpID(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_empID, "Invalid Employee ID Format!");
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

            using (var db = new EmploNexusu_uEntities())
            {              
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Update this user Account?", "EmploNexus: User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        int user_empIDToUpdate = Convert.ToInt32(txtuser_empID.Text);
                        UserAccount existingUser = db.UserAccounts.FirstOrDefault(u => u.user_empID == user_empIDToUpdate);
                        if (existingUser != null)
                        {
                            existingUser.username = txtuserUsername.Text;
                            existingUser.password = txtuserPassword.Text;
                            existingUser.roleId = (Int32)cmbBoxRole.SelectedValue;

                            db.SaveChanges();
                            loadUser();
                            MessageBox.Show("User Updated Successfully!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("User not found!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this user Account?", "EmploNexus: User Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using (var db = new EmploNexusu_uEntities())
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
                            MessageBox.Show("User not found!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
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
            using (var db = new EmploNexusu_uEntities())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtuserSearch.Text))
                    {
                        MessageBox.Show("Please enter a valid Employee ID.", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int user_empIDToSearch = Convert.ToInt32(txtuserSearch.Text);
                        UserAccount existingUser = db.UserAccounts.FirstOrDefault(u => u.user_empID == user_empIDToSearch);
                        if (existingUser != null)
                        {
                            List<vw_all_user_role> foundUserList = new List<vw_all_user_role>
                        {
                            new vw_all_user_role
                            {
                                USER_NO_ = existingUser.userNo,
                                EMPLOYEE_ID = existingUser.user_empID,
                                USERNAME = existingUser.username,
                                PASSWORD = existingUser.password,
                                ROLE = GetRoleString(existingUser.roleId)
                            }
                        };                           
                            dgv_AllUserWdetails.DataSource = foundUserList;
                            MessageBox.Show("Employee ID Found!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtuserSearch.Text = "";
                        }
                        else
                        {
                            loadUser();
                            txtuserSearch.Text = "";
                            MessageBox.Show("Employee ID not found!", "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    loadUser();
                    txtuserSearch.Text = "";
                    MessageBox.Show("Error searching for Employee ID. \nError: " + ex.Message, "EmploNexus: User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetRoleString(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Employee";
                case 2:
                    return "Manager";
                case 3:
                    return "Admin";
                default:
                    return "Employee";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtuserSearch.Text = "";
            loadUser();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_AeAttendance_Management attendance_Management = new Frm_AeAttendance_Management();
            attendance_Management.Show();
            this.Hide();
        }
    }
}
