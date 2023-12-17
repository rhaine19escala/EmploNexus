using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace EmploNexus.Forms
{
    public partial class Frm_AEmployee_Management : Form
    {
        //String strConnection = @"Data Source=.\sqlexpress;Initial Catalog=EmploNexus;Integrated Security=True";
        UserRepository repo;
        EmploNexusT_TEntities db;

        public Frm_AEmployee_Management()
        {
            InitializeComponent();
            //
            db = new EmploNexusT_TEntities();
        }

        private void Frm_Employee_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            DOB_date.Format = DateTimePickerFormat.Custom;
            DOB_date.CustomFormat = "MM/dd/yyyy";

            dgv_AllEmployeesWdetails.CellFormatting += dgv_AllEmployeesWdetails_CellFormatting;

            repo = new UserRepository();
            loadUser();
            loadCbBoxGender();
            loadCbBoxDepartment();
            loadCbBoxPosition();
        }

        private void loadUser()
        {
            dgv_AllEmployeesWdetails.DataSource = repo.GetEmployeeList();
            dgv_AllEmpID.DataSource = repo.AllEmployeeID();
        }

        public void loadCbBoxGender()
        {
            // SELECT * FROM GENDER
            var gender = db.Genders.ToList();

            cmbBox_empGender.ValueMember = "genderId";
            cmbBox_empGender.DisplayMember = "genderName";
            cmbBox_empGender.DataSource = gender;
        }

        public void loadCbBoxDepartment()
        {
            // SELECT * FROM DEPARTMENT
            var department = db.Departments.ToList();

            cmbBox_empDepartment.ValueMember = "departmentId";
            cmbBox_empDepartment.DisplayMember = "departmentDescription";
            cmbBox_empDepartment.DataSource = department;
        }

        public void loadCbBoxPosition()
        {
            // SELECT * FROM POSITION
            var positions = db.Positions.ToList();

            cmbBox_empPosition.ValueMember = "positionId";
            cmbBox_empPosition.DisplayMember = "positionDescription";
            cmbBox_empPosition.DataSource = positions;
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Admin_Dashboard admin_Dashboard = new Frm_Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_AUser_Management aUser_Management = new Frm_AUser_Management();
            aUser_Management.Show();
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
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(email, emailPattern);
            return isValid;
        }

        private bool IsValidEmpID(string employeeID)
        {
            // Use \d to match digits, and {8} to specify the length as 8
            string employeeIDPattern = @"^\d{8}$";
            bool isValid = Regex.IsMatch(employeeID, employeeIDPattern);
            return isValid;
        }


        private void dgv_AllEmployeesWdetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && e.Value != null)
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

            if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.Value != null)
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

            if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.Value != null)
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

        private void dgv_AllEmployeesWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_AllEmployeesWdetails.Rows.Count)
                {
                    DOB_date.Value = DateTime.Today;
                    txtempID.Text = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[1].Value).ToString();
                    txtempName.Text = dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[2].Value as String;

                    int genderID = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[3].Value);
                    cmbBox_empGender.SelectedValue = genderID;

                    if (dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[4].Value is DateTime selectedDate)
                    {
                        DOB_date.Value = selectedDate;
                    }

                    txtempEmail.Text = dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[5].Value as String;

                    int department = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[6].Value);
                    cmbBox_empDepartment.SelectedValue = department;

                    int position = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[7].Value);
                    cmbBox_empPosition.SelectedValue = position;
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

        private bool EmpIDExistsInOtherTable(int empID, DataGridView otherTable)
        {
            foreach (DataGridViewRow row in otherTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    int otherEmpID = Convert.ToInt32(row.Cells["EMPLOYEE_ID"].Value);
                    if (otherEmpID == empID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void dgv_AllEmpID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DOB_date.Value = DateTime.Today;
                txtempID.Text = Convert.ToInt32(dgv_AllEmpID.Rows[e.RowIndex].Cells[1].Value).ToString();
                txtempName.Clear();
                txtempEmail.Clear();
                cmbBox_empGender.SelectedIndex = 0;
                cmbBox_empDepartment.SelectedIndex = 0;
                cmbBox_empPosition.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnempAdd_Click(object sender, EventArgs e)
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
            if (!IsValidEmpID(emp_id))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, "Invalid Employee ID Format!");
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
            int empID = Convert.ToInt32(emp_id);
            if (EmpIDExistsInOtherTable(empID, dgv_AllEmployeesWdetails))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, $"Employee with ID {empID} is already added!");
                return;
            }

            try
            {
                using (var db = new EmploNexusT_TEntities())
                {
                    Employee emp = new Employee
                    {
                        emp_ID = Convert.ToInt32(txtempID.Text),
                        emp_name = txtempName.Text,
                        emp_genderId = (Int32)cmbBox_empGender.SelectedValue,
                        emp_DOB = DOB_date.Value,
                        emp_email = txtempEmail.Text,
                        emp_departmentId = (Int32)cmbBox_empDepartment.SelectedValue,
                        emp_positionId = (Int32)cmbBox_empPosition.SelectedValue
                    };

                    db.Employees.Add(emp);
                    db.SaveChanges();
                    loadUser();
                    MessageBox.Show("Employee Info Added Successfully!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                }

                //using (var db = new EmploNexusT_TEntities())
                //{
                //    db.Database.ExecuteSqlCommand(
                //        "sp_addEmployee @emp_ID, @emp_name, @emp_genderId, @emp_DOB, @emp_email, @emp_departmentId, @emp_positionId",
                //        new SqlParameter("@emp_ID", Convert.ToInt32(txtempID.Text)),
                //        new SqlParameter("@emp_name", txtempName.Text),
                //        new SqlParameter("@emp_genderId", (Int32)cmbBox_empGender.SelectedValue),
                //        new SqlParameter("@emp_DOB", DOB_date.Value),
                //        new SqlParameter("@emp_email", txtempEmail.Text),
                //        new SqlParameter("@emp_departmentId", (Int32)cmbBox_empDepartment.SelectedValue),
                //        new SqlParameter("@emp_positionId", (Int32)cmbBox_empPosition.SelectedValue)
                //    );

                //    loadUser();
                //    MessageBox.Show("Employee Info Added Successfully!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ClearInputFields();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee Info not Added Successfully!. \nError :" + ex.Message, "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }
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
                            existingUser.emp_DOB = DOB_date.Value;
                            existingUser.emp_email = txtempEmail.Text;
                            existingUser.emp_departmentId = (Int32)cmbBox_empDepartment.SelectedValue;
                            existingUser.emp_positionId = (Int32)cmbBox_empPosition.SelectedValue;

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

                    //int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);

                    //db.Database.ExecuteSqlCommand(
                    //    "sp_updateEmployee @emp_ID, @emp_name, @emp_genderId, @emp_DOB, @emp_email, @emp_departmentId, @emp_positionId",
                    //    new SqlParameter("@emp_ID", user_empIDToUpdate),
                    //    new SqlParameter("@emp_name", txtempName.Text),
                    //    new SqlParameter("@emp_genderId", (Int32)cmbBox_empGender.SelectedValue),
                    //    new SqlParameter("@emp_DOB", DOB_date.Value),
                    //    new SqlParameter("@emp_email", txtempEmail.Text),
                    //    new SqlParameter("@emp_departmentId", (Int32)cmbBox_empDepartment.SelectedValue),
                    //    new SqlParameter("@emp_positionId", (Int32)cmbBox_empPosition.SelectedValue)
                    //);

                    //loadUser();
                    //MessageBox.Show("Employee Info Updated Successfully!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Employee Info not Updated Successfully!. \nError :" + ex.Message, "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                }
            }
        }

        private void btnempDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this Employee Information?", "EmploNexus: Employee Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    using (var db = new EmploNexusT_TEntities())
                    {
                        int user_empIDToDelete = Convert.ToInt32(txtempID.Text);

                        Employee userToDelete = db.Employees.FirstOrDefault(u => u.emp_ID == user_empIDToDelete);

                        if (userToDelete != null)
                        {
                            db.Employees.Remove(userToDelete);
                            db.SaveChanges();
                            loadUser();
                            MessageBox.Show("Employee Info Deleted Successfully!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Employeee Info not found!", "EmploNexus:  Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    //using (var db = new EmploNexusu_uEntities())
                    //{
                    //    int user_empIDToDelete = Convert.ToInt32(txtempID.Text);

                    //    db.Database.ExecuteSqlCommand(
                    //        "sp_deleteEmployee @emp_ID",
                    //        new SqlParameter("@emp_ID", user_empIDToDelete)
                    //    );

                    //    loadUser();
                    //    MessageBox.Show("Employee Info Deleted Successfully!", "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Employee Info not Deleted Successfully!. \nError :" + ex.Message, "EmploNexus: Employee Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                            dgv_AllEmployeesWdetails.DataSource = foundUserList;
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

        private void ClearInputFields()
        {
            errorProvider1.Clear();
            txtempID.Clear();
            txtempName.Clear();
            txtempEmail.Clear();
            cmbBox_empGender.SelectedIndex = 0;
            cmbBox_empDepartment.SelectedIndex = 0;
            cmbBox_empPosition.SelectedIndex = 0;
            DOB_date.Value = DateTime.Today;
        }

        private void btnempClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
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
