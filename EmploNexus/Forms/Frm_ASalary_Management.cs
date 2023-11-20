using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
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

            payrollDate.Format = DateTimePickerFormat.Custom;
            payrollDate.CustomFormat = "MM/dd/yyyy";
        }

        private void loadUser()
        {
            dgv_AllSalaryWdetails.DataSource = repo.GetEmployeeSalary();
        }

        private void dgv_AllSalaryWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtpayrollID.Text = Convert.ToInt32(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[0].Value).ToString();
                txtempID.Text = Convert.ToInt32(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[1].Value).ToString();
                txtempName.Text = dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[2].Value as String;

                if (DateTime.TryParse(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[3].Value.ToString(), out DateTime selectedDate))
                {
                    payrollDate.Value = selectedDate;
                }
                else
                {
                    payrollDate.Value = DateTime.Now;
                }

                decimal salary = Convert.ToDecimal(dgv_AllSalaryWdetails.Rows[e.RowIndex].Cells[4].Value);
                CultureInfo peso = new CultureInfo("en-PH");
                txtempSalary.Text = salary.ToString("C", peso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
