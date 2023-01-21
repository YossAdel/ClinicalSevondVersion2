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
    public partial class PatientDashboard : Form
    {
        public PatientDashboard()
        {
            InitializeComponent();
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            // hide all
            view1.Hide();
            addAppointment1.Hide();
            viewAppointment1.Hide();
            doctorSetting1.Hide();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration R = new Registration();
            R.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            view1.Show();
            addAppointment1.Hide();
            viewAppointment1.Hide();
            doctorSetting1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            view1.Hide();
            addAppointment1.Show();
            viewAppointment1.Hide();
            doctorSetting1.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            view1.Hide();
            addAppointment1.Hide();
            viewAppointment1.Show();
            doctorSetting1.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            view1.Hide();
            addAppointment1.Hide();
            viewAppointment1.Hide();
            doctorSetting1.Show();
        }
    }
}
