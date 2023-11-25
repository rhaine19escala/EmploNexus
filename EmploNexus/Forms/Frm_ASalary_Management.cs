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

        public Frm_ASalary_Management()
        {
            InitializeComponent();
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

        private void Frm_ASalary_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            repo = new UserRepository();
            loadUser();
            payrollDate.Validating += payrollDate_Validating;

            payrollDate.Format = DateTimePickerFormat.Custom;
            payrollDate.CustomFormat = "MM/dd/yyyy";
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

        private void loadUser()
        {
            dgv_AllSalaryWdetails.DataSource = repo.GetEmployeeSalary();
            dgv_allempInfo.DataSource = repo.AllEmployeeInfo();
        }

        private void dgv_AllSalaryWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtempID.Text = Convert.ToInt32(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[1].Value).ToString();

                if (DateTime.TryParse(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[2].Value.ToString(), out DateTime selectedDate))
                {
                    payrollDate.Value = selectedDate;
                }
                else
                {
                    payrollDate.Value = DateTime.Now;
                }

                decimal salary = Convert.ToDecimal(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[3].Value);
                CultureInfo peso = new CultureInfo("en-PH");
                txtempSalary.Text = salary.ToString("C", peso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmpID(string employeeID)
        {
            // Use \d to match digits, and {8} to specify the length as 8
            string employeeIDPattern = @"^\d{8}$";
            bool isValid = Regex.IsMatch(employeeID, employeeIDPattern);
            return isValid;
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
    }
}
