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
using Patagames.Ocr;
namespace ClinicalSevondVersion
{
    public partial class ReciptionestDashboard : Form
    {
        public ReciptionestDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            doctor4.Show();
            patient1.Hide();
            //doctorUpdate1.Hide();
            doctorSetting1.Hide();
            reciptionist1.Hide();
            ocr1.Hide();

            doctor4.BringToFront();
        }

        private void doctor1_Load(object sender, EventArgs e)
        {
            doctor4.Hide();
           
 
            //doctorUpdate1.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            doctor4.Hide();
            patient1.Show();
            doctorSetting1.Hide();
            reciptionist1.Hide();
            ocr1.Hide();

            patient1.BringToFront();
            //doctorUpdate1.Hide();
        }

        private void ReciptionestDashboard_Load(object sender, EventArgs e)
        {
            //hide all
            doctor4.Hide();
            patient1.Hide();
            doctorSetting1.Hide();
            ocr1.Hide();

            reciptionist1.Hide();
        

        }

        private void patient1_Load(object sender, EventArgs e)
        {
           // this.Hide();
            //PatientForm2 R = new PatientForm2();
            //R.Show();
            //patientForm1.Hide();
            //patientForm21.Hide();
            //patientForm31.Hide();
            //patientForm32.Hide();
        }

        private void doctor3_Load(object sender, EventArgs e)
        {
            doctor3.Hide();
            
        }

        private void patientMain1_Load(object sender, EventArgs e)
        {
          
        }

        private void doctor4_Load(object sender, EventArgs e)
        {
            doctor3.Hide();
            
        }

        private void patient1_Load_1(object sender, EventArgs e)
        {
            //*patient1.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            reciptionist1.Show();
            doctor4.Hide();
            patient1.Hide();
            doctorSetting1.Hide();
            ocr1.Hide();

            reciptionist1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            doctor4.Hide();
            patient1.Hide();
            reciptionist1.Hide();
            doctorSetting1.Show();
            ocr1.Hide();
            doctorSetting1.BringToFront();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration R = new Registration();
            R.Show();
        }

        private void reciptionist1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            doctor4.Hide();
            patient1.Hide();
            reciptionist1.Hide();
            doctorSetting1.Hide();
            ocr1.Show();
            ocr1.BringToFront();
        }

        private void ocr1_Load(object sender, EventArgs e)
        {

        }
    }
}
