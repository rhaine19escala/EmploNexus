using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_EProfile : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        private bool isEditing = false;
        private int loggedInempID;
        private string loggedUsername;

        public Frm_EProfile()
        {    
            InitializeComponent();
            repo = new UserRepository();
            db = new EmploNexusu_uEntities();
            //
            loggedInempID = UserLogged.GetInstance().UserAccounts.user_empID;
            loggedUsername = UserLogged.GetInstance().UserAccounts.username;

            try
            {
                DisplayEmployeeData(loggedInempID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtCurrentDate.Text = currentTime.ToString("D");

            DOB_date.Format = DateTimePickerFormat.Custom;
            DOB_date.CustomFormat = "MM/dd/yyyy";

            DisableStartProfileState();
        }

         private void DisplayEmployeeData(int userEmpId)
        {
            try
            {
                UserAccount user = repo.GetUserByUsername(loggedUsername);

                if (user != null)
                {
                    txtuserUsername.Text = user.username;
                    txtPass.Text = user.password;

                    Employee employee = repo.GetEmployeeById(userEmpId);

                    if (employee != null)
                    {
                        txtempID.Text = employee.emp_ID.ToString();
                        txtempName.Text = employee.emp_name;
                        DOB_date.Value = employee.emp_DOB;
                        txtempEmail.Text = employee.emp_email;

                        txtempGender.Text = GetGenderText(employee.emp_genderId);
                        txtempDepartment.Text = GetDepartmentText(employee.emp_departmentId);
                        txtempPosition.Text = GetPositionText(employee.emp_positionId);
                    }
                    else
                    {
                        MessageBox.Show("Employee details not found!", "EmploNexus: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("User details not found!", "EmploNexus: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetGenderText(int genderId)
        {
            return (genderId == 1) ? "Male" : (genderId == 2) ? "Female" : "Male";
        }

        private string GetDepartmentText(int departmentId)
        {
            switch ((Departments)departmentId)
            {
                case Departments.HR:
                    return "HR";
                case Departments.Finance:
                    return "Finance";
                case Departments.IT:
                    return "IT";
                default:
                    return "HR";
            }
        }

        private string GetPositionText(int positionId)
        {
            switch ((Positions)positionId)
            {
                case Positions.HR_Manager:
                    return "HR Manager";
                case Positions.HR_Generalist:
                    return "HR Generalist";
                case Positions.Financial_Controller:
                    return "Financial Controller";
                case Positions.Accountant:
                    return "Accountant";
                case Positions.IT_Manager:
                    return "IT Manager";
                case Positions.Software_Developer:
                    return "Software Developer";
                default:
                    return "HR Manager";
            }
        }

        private void DisableStartProfileState()
        {
            //Employee Details
            txtempID.Enabled = false;
            txtempName.Enabled = false;
            DOB_date.Enabled = false;
            txtempEmail.Enabled = false;
            txtempGender.Enabled = false;
            txtempDepartment.Enabled = false;
            txtempPosition.Enabled = false;
            //User Account Details
            txtuserUsername.Enabled = false;
            txtPass.Enabled = false;
            checkPass.Enabled = false;
            //Save Button
            btnSAVE.Enabled = false;
        }

        private void DisableEditing()
        {
            //Employee Details
            txtempID.Enabled = false;
            txtempName.Enabled = false;
            DOB_date.Enabled = false;
            txtempEmail.Enabled = false;
            txtempGender.Enabled = false;
            txtempDepartment.Enabled = false;
            txtempPosition.Enabled = false;
            //User Account Details
            txtuserUsername.Enabled = false;
            txtPass.Enabled = false;
            checkPass.Enabled = false;
            //Save Button
            btnSAVE.Enabled = false;

            isEditing = false;
        }

        private void EnableEditing()
        {
            //Employee Details
            txtempID.Enabled = true;
            txtempName.Enabled = true;
            DOB_date.Enabled = true;
            txtempEmail.Enabled = true;
            txtempGender.Enabled = true;
            txtempDepartment.Enabled = true;
            txtempPosition.Enabled = true;
            //User Account Details
            txtuserUsername.Enabled = true;
            txtPass.Enabled = true;
            checkPass.Enabled = true;
            //Save Button
            btnSAVE.Enabled = true;

            isEditing = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Employee Dashboard
            Frm_Employee_Dashboard employee_Dashboard = new Frm_Employee_Dashboard();
            employee_Dashboard.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
            Frm_EViewSalary eViewSalary = new Frm_EViewSalary();
            eViewSalary.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Attendance
            FrmEnAttendance enAttendance = new FrmEnAttendance();
            enAttendance.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                int empId = loggedInempID;
                string newUsername = txtuserUsername.Text;
                string newPass = txtPass.Text;

                string empName = txtempName.Text;
                DateTime dob = DOB_date.Value;
                string empEmail = txtempEmail.Text;
                int genderId = GetGenderId(txtempGender.Text);
                int departmentId = GetDepartmentId(txtempDepartment.Text);
                int positionId = GetPositionId(txtempPosition.Text);

                repo.UpdateUserData(empId, newUsername, newPass);

                repo.UpdateEmployeeData(empId, empName, genderId, dob, empEmail, departmentId, positionId);

                MessageBox.Show("Employee Info updated successfully.", "EmploNexus: Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableEditing();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message, "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetGenderId(string genderText)
        {
            return genderText.ToLower() == "female" ? 2 : 1;
        }

        private int GetDepartmentId(string departmentText)
        {
            switch (departmentText.ToLower())
            {
                case "hr":
                    return (int)Departments.HR;
                case "finance":
                    return (int)Departments.Finance;
                case "it":
                    return (int)Departments.IT;
                default:
                    return (int)Departments.HR;
            }
        }

        private int GetPositionId(string positionText)
        {
            switch (positionText.ToLower())
            {
                case "hr manager":
                    return (int)Positions.HR_Manager;
                case "hr generalist":
                    return (int)Positions.HR_Generalist;
                case "financial controller":
                    return (int)Positions.Financial_Controller;
                case "accountant":
                    return (int)Positions.Accountant;
                case "it manager":
                    return (int)Positions.IT_Manager;
                case "software developer":
                    return (int)Positions.Software_Developer;
                default:
                    return (int)Positions.HR_Manager;
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                DisableEditing();
            }
            else
            {
                EnableEditing();
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }
    }
}
