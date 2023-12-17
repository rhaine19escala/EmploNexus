namespace EmploNexus.Forms
{
    partial class Frm_Attendance_HERE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Attendance_HERE));
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnAttendancePersonal = new System.Windows.Forms.Button();
            this.grpbox_Attendance = new System.Windows.Forms.GroupBox();
            this.grpbox_Attendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.BackgroundImage")));
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnAttendance.Location = new System.Drawing.Point(23, 28);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(292, 53);
            this.btnAttendance.TabIndex = 20;
            this.btnAttendance.Text = "ATTENDANCE MANAGEMENT";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnAttendancePersonal
            // 
            this.btnAttendancePersonal.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAttendancePersonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendancePersonal.BackgroundImage")));
            this.btnAttendancePersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendancePersonal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendancePersonal.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnAttendancePersonal.Location = new System.Drawing.Point(23, 101);
            this.btnAttendancePersonal.Name = "btnAttendancePersonal";
            this.btnAttendancePersonal.Size = new System.Drawing.Size(292, 53);
            this.btnAttendancePersonal.TabIndex = 21;
            this.btnAttendancePersonal.Text = "ATTENDANCE DETAILS";
            this.btnAttendancePersonal.UseVisualStyleBackColor = false;
            this.btnAttendancePersonal.Click += new System.EventHandler(this.btnAttendancePersonal_Click);
            // 
            // grpbox_Attendance
            // 
            this.grpbox_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_Attendance.Controls.Add(this.btnAttendancePersonal);
            this.grpbox_Attendance.Controls.Add(this.btnAttendance);
            this.grpbox_Attendance.Location = new System.Drawing.Point(12, 12);
            this.grpbox_Attendance.Name = "grpbox_Attendance";
            this.grpbox_Attendance.Size = new System.Drawing.Size(343, 181);
            this.grpbox_Attendance.TabIndex = 22;
            this.grpbox_Attendance.TabStop = false;
            // 
            // Frm_Attendance_HERE
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
            this.Name = "Frm_Attendance_HERE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploNexus: Attendance Information";
            this.grpbox_Attendance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnAttendancePersonal;
        private System.Windows.Forms.GroupBox grpbox_Attendance;
    }
}