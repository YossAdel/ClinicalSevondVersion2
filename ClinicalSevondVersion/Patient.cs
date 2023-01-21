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
    public partial class Patient : UserControl
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            patientForm1.Show();
            patientRemove1.Hide();
            patientUpdate1.Hide();
            patientSchedule1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            patientForm1.Hide();
            patientRemove1.Hide();
            patientUpdate1.Hide();
            patientSchedule1.Hide();
        }

        private void patientForm1_Load(object sender, EventArgs e)
        {
            //*patientForm1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            patientRemove1.Show();
            patientForm1.Hide();
            patientSchedule1.Hide();
            patientUpdate1.Hide();
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            patientRemove1.Hide();
            patientForm1.Hide();
            patientSchedule1.Hide();
            patientUpdate1.Show();
        }

        

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            patientRemove1.Hide();
            patientForm1.Hide();
            patientSchedule1.Show();
            patientUpdate1.Hide();
        }
    }
}
