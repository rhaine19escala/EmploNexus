﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace EmploNexus.Forms
{
    public partial class Frm_OpeningScreen : Form
    {
        public Frm_OpeningScreen()
        {
            InitializeComponent();
        }

        private void Frm_OpeningScreen_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                btnRun.Enabled = true;

                Frm_Login login = new Frm_Login();
                login.Show();
                this.Hide();
            }
            else
            {
                btnRun.Enabled = false;
            }
        }


        private void BtnRun_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            timer1.Enabled = true;
        }

        private void lblCLose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quit EmploNexus?", "EmploNexus: Quit EmploNexus?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
