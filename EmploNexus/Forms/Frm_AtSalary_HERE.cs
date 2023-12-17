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
    public partial class Frm_AtSalary_HERE : Form
    {
        public Frm_AtSalary_HERE()
        {
            InitializeComponent();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
        }

        private void btnSalaryPersonal_Click(object sender, EventArgs e)
        {
            Frm_ApersonalSalary apersonalSalary = new Frm_ApersonalSalary();
            apersonalSalary.Show();
            this.Hide();
        }
    }
}
