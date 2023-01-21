using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalSevondVersion
{
    public partial class DoctorSignUp : UserControl
    {
        public DoctorSignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void DoctorSignUp_Load(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pass.Text == confirm.Text & pass.TextLength > 6 & guna2CheckBox1.Checked == true & textBox1.Text != "" & textBox4.Text != "" & textBox5.Text != "")
            {

                SqlCommand cmd = new SqlCommand("INSERT into Drsignup values (" + "@Name,@Email,@Mobile,@female,@terms,@male,@password" + ")", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Mobile", textBox5.Text);
                cmd.Parameters.AddWithValue("@female", ChechFemale.Checked);
                cmd.Parameters.AddWithValue("@terms", guna2CheckBox1.Checked);
                cmd.Parameters.AddWithValue("@male", CheckMale.Checked);
                cmd.Parameters.AddWithValue("@password", confirm.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Successfully Added");

                //MessageBox.Show("Successfully Added");


            }
            else if (ChechFemale.Checked || CheckMale.Checked == false)
            {
                label11.Text = "Please Choose Gender";
            }
            else if (pass.Text != confirm.Text)
            {
                label12.Text = "Re-confirm Password";
            }

            else if (pass.TextLength < 6)
            {
                label13.Text = "Password is too short";

            }
            else if (guna2CheckBox1.Checked == false)
            {
                label14.Text = "Please check";
            }

        }

        private void CheckMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChechFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox3.Checked)
            {
                confirm.UseSystemPasswordChar = false;
            }
            else
            {
                confirm.UseSystemPasswordChar = true;
            }
        }
    }
}
