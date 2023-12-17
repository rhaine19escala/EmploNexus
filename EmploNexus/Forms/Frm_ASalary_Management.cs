using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
        EmploNexusT_TEntities db;
        private PrintDocument printDocument;

        public Frm_ASalary_Management()
        {
            InitializeComponent();
            db = new EmploNexusT_TEntities();
            repo = new UserRepository();

            // Initialize the PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
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
                    txtSalaryID.Text = Convert.ToInt32(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[0].Value).ToString();

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
                txtSalaryID.Clear();
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
                using (var db = new EmploNexusT_TEntities())
                {
                    if (!int.TryParse(txtSalaryID.Text, out int salaryID))
                    {
                        MessageBox.Show("Invalid Salary ID", "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int user_empIDToAdd = Convert.ToInt32(txtempID.Text);
                    decimal newSalaryAmount = Convert.ToDecimal(txtempSalary.Text);
                    DateTime newPayrollDate = payrollDate.Value.Date;

                    bool isDuplicateDate = db.Salaries.Any(u => u.salary_ID == salaryID && u.Salaryemp_ID == user_empIDToAdd && u.salary_PayDate == newPayrollDate);

                    if (!isDuplicateDate)
                    {
                        Salary sal = new Salary
                        {
                            Salaryemp_ID = user_empIDToAdd,
                            salary_Amount = newSalaryAmount,
                            salary_PayDate = newPayrollDate
                        };

                        db.Salaries.Add(sal);
                        db.SaveChanges();
                        loadUser();
                        MessageBox.Show("Salary Info Added Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Salary Info not Added. Duplicate date found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //using (var db = new EmploNexusu_uEntities())
                //{
                //    if (!int.TryParse(txtSalaryID.Text, out int salaryID))
                //    {
                //        MessageBox.Show("Invalid Salary ID", "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }

                //    int user_empIDToAdd = Convert.ToInt32(txtempID.Text);
                //    decimal newSalaryAmount = Convert.ToDecimal(txtempSalary.Text);
                //    DateTime newPayrollDate = payrollDate.Value.Date;

                //    bool isDuplicateDate = db.Salaries.Any(u => u.salary_ID == salaryID && u.Salaryemp_ID == user_empIDToAdd && u.salary_PayDate == newPayrollDate);

                //    if (!isDuplicateDate)
                //    {
                //        db.Database.ExecuteSqlCommand(
                //            "sp_addSalary @Salaryemp_ID, @salary_Amount, @salary_PayDate",
                //            new SqlParameter("@Salaryemp_ID", user_empIDToAdd),
                //            new SqlParameter("@salary_Amount", newSalaryAmount),
                //            new SqlParameter("@salary_PayDate", newPayrollDate)
                //        );

                //        loadUser();
                //        MessageBox.Show("Salary Info Added Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        ClearInputFields();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Salary Info not Added. Duplicate date found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Salary Info not Added Successfully! \nError :" + ex.Message, "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Update this Salary Information?", "EmploNexus: Salary Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using (var db = new EmploNexusT_TEntities())
                    {
                        int salaryID = Convert.ToInt32(txtSalaryID.Text);
                        int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);
                        decimal newSalaryAmount = Convert.ToDecimal(txtempSalary.Text);
                        DateTime newPayrollDate = payrollDate.Value.Date;

                        Salary existingSalary = db.Salaries.SingleOrDefault(u => u.salary_ID == salaryID && u.Salaryemp_ID == user_empIDToUpdate);

                        if (existingSalary != null)
                        {
                            bool isDuplicate = db.Salaries.Any(u => u.salary_ID != salaryID && u.Salaryemp_ID == user_empIDToUpdate && u.salary_PayDate == newPayrollDate);

                            if (!isDuplicate)
                            {
                                existingSalary.salary_Amount = newSalaryAmount;
                                existingSalary.salary_PayDate = newPayrollDate;

                                db.SaveChanges();
                                loadUser();
                                MessageBox.Show("Salary Info Updated Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearInputFields();
                            }
                            else
                            {
                                MessageBox.Show("Salary Info not Updated. Duplicate date found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Salary Info not Updated. No matching record found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    //using (var db = new EmploNexusT_TEntities())
                    //{
                    //    int salaryID = Convert.ToInt32(txtSalaryID.Text);
                    //    int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);
                    //    decimal newSalaryAmount = Convert.ToDecimal(txtempSalary.Text);
                    //    DateTime newPayrollDate = payrollDate.Value.Date;

                    //    bool isDuplicate = db.Salaries.Any(u => u.salary_ID != salaryID && u.Salaryemp_ID == user_empIDToUpdate && u.salary_PayDate == newPayrollDate);

                    //    if (!isDuplicate)
                    //    {
                    //        db.Database.ExecuteSqlCommand(
                    //            "sp_updateSalary @salary_ID, @salary_Amount, @salary_PayDate",
                    //            new SqlParameter("@salary_ID", salaryID),
                    //            new SqlParameter("@salary_Amount", newSalaryAmount),
                    //            new SqlParameter("@salary_PayDate", newPayrollDate)
                    //        );

                    //        loadUser();
                    //        MessageBox.Show("Salary Info Updated Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        ClearInputFields();
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Salary Info not Updated. Duplicate date found!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Salary Info not Updated Successfully! \nError :" + ex.Message, "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this Salary Information?", "EmploNexus: Salary Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    using (var db = new EmploNexusT_TEntities())
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
                    //using (var db = new EmploNexusu_uEntities())
                    //{
                    //    int user_empIDToDelete = Convert.ToInt32(txtempID.Text);

                    //    db.Database.ExecuteSqlCommand(
                    //        "sp_deleteSalary @salary_ID",
                    //        new SqlParameter("@salary_ID", user_empIDToDelete)
                    //    );

                    //    loadUser();
                    //    MessageBox.Show("Salary Info Deleted Successfully!", "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Salary Info not Deleted Successfully! \nError :" + ex.Message, "EmploNexus: Salary Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        public void ClearInputFields()
        {
            errorProvider1.Clear();
            txtSalaryID.Clear();
            txtempID.Clear();
            txtempSalary.Clear();
            payrollDate.Value = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EmploNexusT_TEntities())
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headerFont = new Font("Book Antiqua", 28, FontStyle.Bold);
            Font subheaderFont = new Font("Book Antiqua", 25, FontStyle.Bold);
            Font itemFont = new Font("Book Antiqua", 20, FontStyle.Bold);
            Brush brush = Brushes.Black;

            float startX = 30;
            float startY = 30;
            float lineHeight = itemFont.GetHeight();

            StringBuilder receiptContent = new StringBuilder();
            decimal totalSalary = 0;

            e.Graphics.DrawString("======================================", subheaderFont, brush, startX, startY);
            startY += lineHeight * 2;
            e.Graphics.DrawString("                      EmploNexus", headerFont, brush, startX + 60, startY);
            startY += lineHeight * 2;
            e.Graphics.DrawString("======================================", subheaderFont, brush, startX, startY);
            startY += lineHeight * 2;

            e.Graphics.DrawString($"Date: {DateTime.Now}", itemFont, brush, startX, startY);
            startY += lineHeight;
            String username = UserLogged.GetInstance().UserAccounts.username.ToUpper();
            e.Graphics.DrawString($"Username: {username}", itemFont, brush, startX, startY);
            startY += lineHeight;
            int empID = UserLogged.GetInstance().UserAccounts.user_empID;
            Employee emp = repo.GetEmployeeById(empID);
            if (emp != null)
            {
                string empName = emp.emp_name;
                string email = emp.emp_email;
                e.Graphics.DrawString($"Employee Name: {empName}", itemFont, brush, startX, startY);
                startY += lineHeight;
                e.Graphics.DrawString($"Email: {email}", itemFont, brush, startX, startY);
            }
            startY += lineHeight * 2;
            e.Graphics.DrawString("======================================", subheaderFont, brush, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("EMPLOYEE ID#".PadRight(30), itemFont, brush, 30, startY);
            e.Graphics.DrawString("PAY DATE".PadRight(10), itemFont, brush, startX + 230, startY);
            e.Graphics.DrawString("SALARY".PadRight(10), itemFont, brush, startX + 650, startY);
            startY += lineHeight;
            e.Graphics.DrawString("======================================", subheaderFont, brush, startX, startY);
            startY += lineHeight;

            for (int i = 0; i < dgv_AllSalaryWdetails.RowCount; i++)
            {
                string EmployeeNum = dgv_AllSalaryWdetails.Rows[i].Cells["EMPLOYEE_ID"].Value?.ToString();
                string PayDate = dgv_AllSalaryWdetails.Rows[i].Cells["PAY_DATE"].Value?.ToString();
                string EmpSal = dgv_AllSalaryWdetails.Rows[i].Cells["SALARY"].Value?.ToString();
                if (decimal.TryParse(EmpSal, out decimal salaryAmount))
                {
                    totalSalary += salaryAmount;
                    EmpSal = string.Format(new CultureInfo("en-PH"), "Php {0:N2}", salaryAmount);
                }

                receiptContent.AppendLine($"{EmployeeNum,-15}{PayDate,-40}{EmpSal,-10}");
            }

            float HereX = 30;
            float HereY = 750;

            e.Graphics.DrawString("======================================", subheaderFont, brush, HereX, HereY);
            HereY += lineHeight;
            CultureInfo culture = new CultureInfo("en-PH");
            string formattedTotalSalary = string.Format(culture, "Php {0:N2}", totalSalary);
            e.Graphics.DrawString($"Total Salary: ".PadRight(75) + formattedTotalSalary, itemFont, brush, HereX, HereY);
            HereY += lineHeight;
            e.Graphics.DrawString("======================================", subheaderFont, brush, HereX, HereY);

            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                RectangleF rect = new RectangleF(startX, startY, e.PageBounds.Width - startX * 2, e.PageBounds.Height - startY * 2);

                e.Graphics.DrawString(receiptContent.ToString(), itemFont, brush, rect, format);
            }
            MessageBox.Show("Printed Successfully!", "EmploNexus : Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
