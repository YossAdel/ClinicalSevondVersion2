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
    public partial class Doctor : UserControl
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            //hideall
            doctorRemove1.Hide();
            doctorUpdate1.Hide();
            viewDoctorSchedule1.Hide();
            doctorSignUp1.Hide();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            doctorSignUp1.Show();
            doctorRemove1.Hide();
            doctorUpdate1.Hide();
            viewDoctorSchedule1.Hide();



        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            doctorSignUp1.Hide();
            doctorRemove1.Show();
            doctorUpdate1.Hide();
            viewDoctorSchedule1.Hide();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            doctorSignUp1.Hide();
            doctorRemove1.Hide();
            doctorUpdate1.Show();
            viewDoctorSchedule1.Hide();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            doctorSignUp1.Hide();
            doctorRemove1.Hide();
            doctorUpdate1.Hide();
            viewDoctorSchedule1.Show();
        }

        private void doctorRemove1_Load(object sender, EventArgs e)
        {

        }

        private void doctorUpdate1_Load(object sender, EventArgs e)
        {

        }

        private void viewDoctorSchedule1_Load(object sender, EventArgs e)
        {

        }

        private void doctorSignUp1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
