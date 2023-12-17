using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_MViewEmployee : Form
    {
        UserRepository repo;
        EmploNexusT_TEntities db;

        public Frm_MViewEmployee()
        {      
            InitializeComponent();
            db = new EmploNexusT_TEntities();
            repo = new UserRepository();
        }

        private void Frm_MViewEmployee_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            loadUser();
            loadCbBoxGender();
        }

        private void loadUser()
        {
            int empId = UserLogged.GetInstance().UserAccounts.user_empID;
            dgv_EmployeeManage.DataSource = repo.GetEmployeesInSameDepartment(empId, GetLoggedInUserDepartmentId());         
        }

        private int GetLoggedInUserDepartmentId()
        {
            int empId = UserLogged.GetInstance().UserAccounts.user_empID;

            var loggedInUser = db.Employees.FirstOrDefault(e => e.emp_ID == empId);

            if (loggedInUser != null)
            {
                int departID = loggedInUser.emp_departmentId;
                return departID;
            }
            return 1;
        }

        public void loadCbBoxGender()
        {
            // SELECT * FROM GENDER
            var gender = db.Genders.ToList();

            cmbBox_empGender.ValueMember = "genderId";
            cmbBox_empGender.DisplayMember = "genderName";
            cmbBox_empGender.DataSource = gender;
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_Manager_Dashboard manager_Dashboard = new Frm_Manager_Dashboard();
            manager_Dashboard.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Profile
            Frm_MProfile mProfile = new Frm_MProfile();
            mProfile.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
            Frm_MViewSalary mViewSalary = new Frm_MViewSalary();
            mViewSalary.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //View Attendance
            Frm_MAttendance mAttendance = new Frm_MAttendance();
            mAttendance.Show();
            this.Hide();
        }

        private void dgv_EmployeeManage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.Value != null)
            {
                string stringValue = e.Value.ToString();
                int genderValue;
                if (int.TryParse(stringValue, out genderValue))
                {
                    if (genderValue == 1)
                    {
                        e.Value = "Male";
                    }
                    else if (genderValue == 2)
                    {
                        e.Value = "Female";
                    }
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.Value != null)
            {
                string stringValue = e.Value.ToString();
                int departmentvalue;
                if (int.TryParse(stringValue, out departmentvalue))
                {
                    if (departmentvalue == 1)
                    {
                        e.Value = "HR";
                    }
                    else if (departmentvalue == 2)
                    {
                        e.Value = "Finance";
                    }
                    else if (departmentvalue == 3)
                    {
                        e.Value = "IT";
                    }
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.Value != null)
            {
                string stringValue = e.Value.ToString();
                int positionvalue;
                if (int.TryParse(stringValue, out positionvalue))
                {
                    if (positionvalue == 1)
                    {
                        e.Value = "HR Manager";
                    }
                    else if (positionvalue == 2)
                    {
                        e.Value = "HR Generalist";
                    }
                    else if (positionvalue == 3)
                    {
                        e.Value = "Financial Controller";
                    }
                    else if (positionvalue == 4)
                    {
                        e.Value = "Accountant";
                    }
                    else if (positionvalue == 5)
                    {
                        e.Value = "IT Manager";
                    }
                    else if (positionvalue == 6)
                    {
                        e.Value = "Software Developer";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgv_EmployeeManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_EmployeeManage.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_EmployeeManage.Rows[e.RowIndex].Cells[0].Value).ToString();
                    txtempName.Text = dgv_EmployeeManage.Rows[e.RowIndex].Cells[1].Value as String;

                    int genderID = Convert.ToInt32(dgv_EmployeeManage.Rows[e.RowIndex].Cells[2].Value);
                    cmbBox_empGender.SelectedValue = genderID;

                    txtempEmail.Text = dgv_EmployeeManage.Rows[e.RowIndex].Cells[3].Value as String;
                    Department();
                    JobPosition();
                }
                else
                {
                    MessageBox.Show("Invalid row index selected.", "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Department()
        {
            int selectedRowIndex = dgv_EmployeeManage.SelectedCells[0].RowIndex;
            int columnIndex = 4;
            object formattedValue = dgv_EmployeeManage.Rows[selectedRowIndex].Cells[columnIndex].FormattedValue;
            txtDepartment.Text = formattedValue.ToString();
        }

        private void JobPosition()
        {
            int selectedRowIndex = dgv_EmployeeManage.SelectedCells[0].RowIndex;
            int columnIndex = 5;
            object formattedValue = dgv_EmployeeManage.Rows[selectedRowIndex].Cells[columnIndex].FormattedValue;
            txtPosition.Text = formattedValue.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EmploNexusT_TEntities())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtempSearch.Text))
                    {
                        MessageBox.Show("Please enter a valid Employee ID.", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int user_empIDToSearch = Convert.ToInt32(txtempSearch.Text);
                        Employee existingUser = db.Employees.FirstOrDefault(u => u.emp_ID == user_empIDToSearch);
                        if (existingUser != null)
                        {
                            var foundUserList = new List<vw_all_employee>
                            {
                                new vw_all_employee
                                {
                                    EMPLOYEE_NO_ = existingUser.emp_No,
                                    EMPLOYEE_ID = existingUser.emp_ID,
                                    EMPLOYEE_NAME = existingUser.emp_name,
                                    GENDER = existingUser.emp_genderId,
                                    BIRTHDATE = existingUser.emp_DOB,
                                    EMAIL = existingUser.emp_email,
                                    DEPARTMENT = existingUser.emp_departmentId,
                                    JOB_POSITION = existingUser.emp_positionId
                                }
                            };

                            dgv_EmployeeManage.DataSource = foundUserList;
                            MessageBox.Show("Employee ID Found!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtempSearch.Text = "";
                        }
                        else
                        {
                            loadUser();
                            txtempSearch.Clear();
                            MessageBox.Show("Employee ID not found!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    loadUser();
                    txtempSearch.Clear();
                    MessageBox.Show($"Error searching for Employee ID. \nError: {ex.Message}", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUser();
            ClearInputFields();
        }

        private void btnempClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtempID.Clear();
            txtempName.Clear();
            txtempEmail.Clear();
            txtDepartment.Clear();
            txtPosition.Clear();
            cmbBox_empGender.SelectedIndex = 0;       
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(email, emailPattern);
            return isValid;
        }

        private void btnempUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            String emp_id = txtempID.Text;
            String emp_name = txtempName.Text;
            String emp_email = txtempEmail.Text;

            if (String.IsNullOrEmpty(emp_id))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(emp_name))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempName, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(emp_email))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempEmail, "Empty Field!");
                return;
            }
            if (!IsValidEmail(emp_email))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempEmail, "Invalid Email Format!");
                return;
            }

            using (var db = new EmploNexusT_TEntities())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Update this Employee Information?", "EmploNexus: Employee Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);
                        Employee existingUser = db.Employees.FirstOrDefault(u => u.emp_ID == user_empIDToUpdate);
                        if (existingUser != null)
                        {
                            existingUser.emp_name = txtempName.Text;
                            existingUser.emp_genderId = (Int32)cmbBox_empGender.SelectedValue;
                            existingUser.emp_email = txtempEmail.Text;

                            db.SaveChanges();
                            loadUser();
                            MessageBox.Show("Employee Info Updated Successfully!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Employee Info not found!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Employee Info not Updated Successfully!. \nError :" + ex.Message, "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                }
            }
        }
    }
}
