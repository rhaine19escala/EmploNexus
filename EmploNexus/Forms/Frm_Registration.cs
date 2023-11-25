using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus.AppData;
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;


namespace EmploNexus.Forms
{
    public partial class Frm_Registration : Form
    {
        public string username = String.Empty;
        EmploNexusu_uEntities db;

        public Frm_Registration()
        {
            InitializeComponent();
            //
            db = new EmploNexusu_uEntities();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Roles.ToList();

            cmbBoxRole.ValueMember = "roleId";
            cmbBoxRole.DisplayMember = "roleName";
            cmbBoxRole.DataSource = roles;
        }

        private void ClearInputFields()
        {
            txtEmployeeID.Clear();
            txtpass_word.Clear();
            txtConfirmPassword.Clear();
            txtuser_name.Clear();
        }

        private bool IsValidEmpID(string employeeID)
        {
            // Use \d to match digits, and {8} to specify the length as 8
            string employeeIDPattern = @"^\d{8}$";
            bool isValid = Regex.IsMatch(employeeID, employeeIDPattern);
            return isValid;
        }

        private bool EmpIDExistsInDatabase(string employeeID)
        {
            using (var db = new EmploNexusu_uEntities())
            {
                int empID = Convert.ToInt32(employeeID);
                return db.Employees.Any(e => e.emp_ID == empID);
            }
        }

        private bool UsernameExistsInDatabase(string username)
        {
            using (var db = new EmploNexusu_uEntities())
            {
                return db.UserAccounts.Any(u => u.username == username);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //String cbResultSelected = cbBoxRole.SelectedValue.ToString();
            String empid = txtEmployeeID.Text;
            String username = txtuser_name.Text;
            String password = txtpass_word.Text;
            String repassword = txtConfirmPassword.Text;

            if (!IsValidEmpID(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeID, "Invalid Employee ID Format!");
                return;
            }
            if (EmpIDExistsInDatabase(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeID, $"Employee ID '{empid}' already exists! Please enter a different Employee ID.");
                return;
            }
            if (String.IsNullOrEmpty(empid))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeID, "Empty field");
                return;
            }
            if (UsernameExistsInDatabase(username))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_name, $"Username '{username}' already exists!");
                return;
            }
            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuser_name, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpass_word, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(repassword))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Empty field");
                return;
            }

            if (!password.Equals(repassword))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Password not match");
                return;
            }

            try
            {
                UserAccount nUserAccount = new UserAccount();

                nUserAccount.user_empID = Convert.ToInt32(txtEmployeeID.Text);
                nUserAccount.username = txtuser_name.Text;
                nUserAccount.password = txtpass_word.Text;
                nUserAccount.roleId = (Int32)cmbBoxRole.SelectedValue;

                username = txtuser_name.Text;

                db.UserAccounts.Add(nUserAccount);
                db.SaveChanges();

                ClearInputFields();
                DialogResult answer = MessageBox.Show("Registered Successfully! Proceed to Login?", "EmploNexus: Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                {
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered : " + ex.Message, "EmploNexus: Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void cmbBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBox_useraccIfno_Enter(object sender, EventArgs e)
        {

        }

        private void txtuser_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_word_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
