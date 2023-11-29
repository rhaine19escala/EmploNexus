using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_ASalary_Management : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;

        public Frm_ASalary_Management()
        {
            InitializeComponent();
            db = new EmploNexusu_uEntities();
            repo = new UserRepository();
        }

        private void Frm_ASalary_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            loadUser();
            ConfigurePayrollDate();
        }

        private void ConfigurePayrollDate()
        {
            payrollDate.Validating += payrollDate_Validating;

            payrollDate.Format = DateTimePickerFormat.Custom;
            payrollDate.CustomFormat = "MM/dd/yyyy";
            payrollDate.MinDate = DateTime.Today;
        }

        private void loadUser()
        {
            dgv_AllSalaryWdetails.DataSource = repo.GetEmployeeSalary();
            dgv_allempInfo.DataSource = repo.AllEmployeeInfo();
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Frm_AEmployee_Management aEmployee_Management = new Frm_AEmployee_Management();
            aEmployee_Management.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_AeAttendance_Management attendance_Management = new Frm_AeAttendance_Management();
            attendance_Management.Show();
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

        private void payrollDate_Validating(object sender, CancelEventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.Value < DateTime.Today)
            {
                MessageBox.Show("Please select a date on or after the present date.", "EmploNexus: Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp.Value = DateTime.Today;
            }
        }


        private void dgv_AllSalaryWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_AllSalaryWdetails.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[1].Value).ToString();

                    if (DateTime.TryParse(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[2].Value?.ToString(), out DateTime selectedDate))
                    {
                        payrollDate.Value = selectedDate;
                    }
                    else
                    {
                        payrollDate.Value = DateTime.Today;
                    }

                    if (decimal.TryParse(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[3].Value?.ToString(), out decimal salary))
                    {
                        txtempSalary.Text = salary.ToString("N0");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row index selected.", "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered : " + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_AllSalaryWdetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && e.Value != null)
            {
                string money = e.Value.ToString();
                decimal salary;
                if (decimal.TryParse(money, out salary))
                {
                    CultureInfo peso = new CultureInfo("en-PH");
                    e.Value = salary.ToString("C", peso);
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                e.Value = 0.00m.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                e.FormattingApplied = true;
            }
        }

        private void dgv_allempInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtempID.Text = Convert.ToInt32(dgv_allempInfo.Rows[e.RowIndex].Cells[1].Value).ToString();
                txtempSalary.Clear();
                payrollDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_allempInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && e.Value != null)
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

            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.Value != null)
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

        private bool IsValidEmpID(string employeeID)
        {
            // Use \d to match digits, and {8} to specify the length as 8
            string employeeIDPattern = @"^\d{8}$";
            bool isValid = Regex.IsMatch(employeeID, employeeIDPattern);
            return isValid;
        }

        public bool IsValidSalary(string amount)
        {
            string amountPattern = @"^-?\d{1,3}(,\d{3})*(\.\d{1,2})?$";
            bool isValid = Regex.IsMatch(amount, amountPattern);
            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String emp_id = txtempID.Text;
            String salary = txtempSalary.Text;
            errorProvider1.Clear();

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
            //int empID = Convert.ToInt32(emp_id);
            //if (EmpIDExistsInOtherTable(empID, dgv_AllSalaryWdetails))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtempID, $"Employee with ID {empID} is already added!");
            //    return;
            //}
            if(String.IsNullOrEmpty(salary))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempSalary, "Empty Field!");
                return;
            }
            if(!IsValidSalary(salary))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempSalary, "Salary should be a valid numerical value");
                return;
            }

            try
            {
                using (var db = new EmploNexusu_uEntities())
                {
                    Salary sal = new Salary
                    {
                        Salaryemp_ID = Convert.ToInt32(txtempID.Text),
                        salary_Amount = Convert.ToDecimal(txtempSalary.Text),
                        salary_PayDate = payrollDate.Value
                    };

                    db.Salaries.Add(sal);
                    db.SaveChanges();
                    loadUser();
                    MessageBox.Show("Salary Info Added Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Salary Info not Added Successfully!. \nError :" + ex.Message, "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String emp_id = txtempID.Text;
            String salary = txtempSalary.Text;
            errorProvider1.Clear();

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
            if (String.IsNullOrEmpty(salary))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempSalary, "Empty Field!");
                return;
            }
            if (!IsValidSalary(salary))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempSalary, "Salary should be a valid numerical value");
                return;
            }

            using (var db = new EmploNexusu_uEntities())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Update this Salary Information?", "EmploNexus: Salary Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);
                        Salary existingUser = db.Salaries.FirstOrDefault(u => u.Salaryemp_ID == user_empIDToUpdate);
                        if (existingUser != null)
                        {
                            existingUser.Salaryemp_ID = Convert.ToInt32(txtempID.Text);
                            existingUser.salary_Amount = Convert.ToDecimal(txtempSalary.Text);
                            existingUser.salary_PayDate = payrollDate.Value;

                            db.SaveChanges();
                            loadUser();
                            MessageBox.Show("Salary Info Updated Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Salary Info not found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Salary Info not Updated Successfully!. \nError :" + ex.Message, "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this Salary Information?", "EmploNexus: Salary Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    using (var db = new EmploNexusu_uEntities())
                    {
                        int user_empIDToDelete = Convert.ToInt32(txtempID.Text);

                        Salary userToDelete = db.Salaries.FirstOrDefault(u => u.Salaryemp_ID == user_empIDToDelete);

                        if (userToDelete != null)
                        {
                            db.Salaries.Remove(userToDelete);
                            db.SaveChanges();
                            loadUser();
                            MessageBox.Show("Salary Info Deleted Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Salary Info not found!", "EmploNexus:  Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Salary Info not Deleted Successfully!. \nError :" + ex.Message, "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        public void ClearInputFields()
        {
            errorProvider1.Clear();
            txtempID.Clear();
            txtempSalary.Clear();
            payrollDate.Value = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EmploNexusu_uEntities())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtempSearch.Text))
                    {
                        MessageBox.Show("Please enter a valid Employee ID.", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int user_empIDToSearch = Convert.ToInt32(txtempSearch.Text);
                        Salary existingUser = db.Salaries.FirstOrDefault(u => u.Salaryemp_ID == user_empIDToSearch);
                        if (existingUser != null)
                        {
                            var foundUserList = new List<vw_all_salary>
                            {
                                new vw_all_salary
                                {
                                    SALARY_NO_ = existingUser.salary_ID,
                                    EMPLOYEE_ID = existingUser.Salaryemp_ID,
                                    SALARY = existingUser.salary_Amount,
                                    PAY_DATE = existingUser.salary_PayDate
                                }
                            };

                            dgv_AllSalaryWdetails.DataSource = foundUserList;
                            MessageBox.Show("Employee ID Found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtempSearch.Text = "";
                        }
                        else
                        {
                            loadUser();
                            txtempSearch.Text = "";
                            MessageBox.Show("Employee ID not found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    loadUser();
                    txtempSearch.Text = "";
                    MessageBox.Show($"Error searching for Employee ID. \nError: {ex.Message}", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUser();
        }
    }
}
