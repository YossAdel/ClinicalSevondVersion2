using ClinicalInformatics_2023;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalSevondVersion
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorLogin R = new DoctorLogin();
            R.Show();
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            // Hide all 
           doctorSetting1.Hide();
            prescription1.Hide();
            doctorSearch1.Hide();
            doctorSchedule1.Hide();
            dietPlan1.Hide();

        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            doctorSetting1.Hide();
            prescription1.Show();
            doctorSchedule1.Hide();
            dietPlan1.Hide();

            doctorSearch1.Hide();
            prescription1.BringToFront();

        }

        private void prescription1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            doctorSetting1.Hide();
            prescription1.Hide();
            doctorSchedule1.Hide();
            dietPlan1.Hide();

            doctorSearch1.Show();
            doctorSearch1.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            doctorSetting1.Show();
            prescription1.Hide();
            doctorSearch1.Hide();
            doctorSchedule1.Hide();
            dietPlan1.Hide();

            doctorSetting1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            doctorSetting1.Hide();
            prescription1.Hide();
            doctorSearch1.Hide();
            dietPlan1.Hide();

            doctorSchedule1.Show();
            doctorSchedule1.BringToFront();
        }

        private void doctorSchedule1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            doctorSetting1.Hide();
            prescription1.Hide();
            doctorSearch1.Hide();
            doctorSchedule1.Hide();
            dietPlan1.Show();
            dietPlan1.BringToFront();
        }

        private void dietPlan1_Load(object sender, EventArgs e)
        {

        }
    }
}
