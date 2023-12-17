namespace EmploNexus.Forms
{
    partial class Frm_AtSalary_HERE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AtSalary_HERE));
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnSalaryPersonal = new System.Windows.Forms.Button();
            this.grpbox_Attendance = new System.Windows.Forms.GroupBox();
            this.grpbox_Attendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalary.BackgroundImage")));
            this.btnSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalary.Location = new System.Drawing.Point(23, 28);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(292, 53);
            this.btnSalary.TabIndex = 20;
            this.btnSalary.Text = "SALARY MANAGEMENT";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnSalaryPersonal
            // 
            this.btnSalaryPersonal.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSalaryPersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalaryPersonal.BackgroundImage")));
            this.btnSalaryPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalaryPersonal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryPersonal.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalaryPersonal.Location = new System.Drawing.Point(23, 101);
            this.btnSalaryPersonal.Name = "btnSalaryPersonal";
            this.btnSalaryPersonal.Size = new System.Drawing.Size(292, 53);
            this.btnSalaryPersonal.TabIndex = 21;
            this.btnSalaryPersonal.Text = "SALARY DETAILS";
            this.btnSalaryPersonal.UseVisualStyleBackColor = false;
            this.btnSalaryPersonal.Click += new System.EventHandler(this.btnSalaryPersonal_Click);
            // 
            // grpbox_Attendance
            // 
            this.grpbox_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_Attendance.Controls.Add(this.btnSalaryPersonal);
            this.grpbox_Attendance.Controls.Add(this.btnSalary);
            this.grpbox_Attendance.Location = new System.Drawing.Point(12, 12);
            this.grpbox_Attendance.Name = "grpbox_Attendance";
            this.grpbox_Attendance.Size = new System.Drawing.Size(343, 181);
            this.grpbox_Attendance.TabIndex = 22;
            this.grpbox_Attendance.TabStop = false;
            // 
            // Frm_AtSalary_HERE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmploNexus.Properties.Resources.fabrizio_conti_kXVogATbFgA_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 214);
            this.Controls.Add(this.grpbox_Attendance);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_AtSalary_HERE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Salary Information";
            this.grpbox_Attendance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnSalaryPersonal;
        private System.Windows.Forms.GroupBox grpbox_Attendance;
    }
}