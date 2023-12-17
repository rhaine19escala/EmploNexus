using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_EViewSalary : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        private PrintDocument printDocument;

        public Frm_EViewSalary()
        {
            
            InitializeComponent();
            db = new EmploNexusu_uEntities();
            repo = new UserRepository();

            // Initialize the PrintDocument
            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            loadUser();
        }

        private void loadUser()
        {
            int empId = UserLogged.GetInstance().UserAccounts.user_empID;
            dgv_SalaryEmp.DataSource = repo.GetSalary(empId);
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Employee_Dashboard employee_Dashboard = new Frm_Employee_Dashboard();
            employee_Dashboard.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Attendance
            FrmEnAttendance enAttendance = new FrmEnAttendance();
            enAttendance.Show();
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

        private void dgv_SalaryEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_SalaryEmp.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_SalaryEmp.Rows[e.RowIndex].Cells[0].Value).ToString();

                    if (DateTime.TryParse(dgv_SalaryEmp.Rows[e.RowIndex].Cells[1].Value?.ToString(), out DateTime selectedDate))
                    {
                        txtWageDate.Text = selectedDate.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        txtWageDate.Text = DateTime.Today.ToString("MM/dd/yyyy");
                    }

                    if (decimal.TryParse(dgv_SalaryEmp.Rows[e.RowIndex].Cells[2].Value?.ToString(), out decimal salary))
                    {
                        //txtempSalary.Text = salary.ToString("N0");
                        txtempSalary.Text = salary.ToString("C2", CultureInfo.GetCultureInfo("en-PH"));
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

        private void dgv_SalaryEmp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.Value != null)
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
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                e.Value = 0.00m.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                e.FormattingApplied = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUser();
            txtempSalary.Clear();
            txtempID.Clear();
            txtWageDate.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal totalWageAmount = 0;

            foreach (DataGridViewRow row in dgv_SalaryEmp.Rows)
            {
                if (row.Cells["SALARY"].Value != null && decimal.TryParse(row.Cells["SALARY"].Value.ToString(), out decimal salary))
                {
                    totalWageAmount += salary;
                }
            }

            txtTotalWageAmount.Text = totalWageAmount.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
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

            for (int i = 0; i < dgv_SalaryEmp.RowCount; i++)
            {
                string EmployeeNum = dgv_SalaryEmp.Rows[i].Cells["EMPLOYEE_ID"].Value?.ToString();
                string PayDate = dgv_SalaryEmp.Rows[i].Cells["PAY_DATE"].Value?.ToString();
                string EmpSal = dgv_SalaryEmp.Rows[i].Cells["SALARY"].Value?.ToString();
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
