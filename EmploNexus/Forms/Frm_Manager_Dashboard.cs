﻿using System;
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
    public partial class Frm_Manager_Dashboard : Form
    {
        public Frm_Manager_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Manager_Dashboard_Load(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            txtName_User.Text = frm.user_Name;

            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }
    }
}
