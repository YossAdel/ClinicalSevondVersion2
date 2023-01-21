using ClinicalInformatics_2023;
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
    public partial class ReciptionSignUp : UserControl
    {
        public ReciptionSignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = "pass";
            if (pass.Text == confirm.Text & pass.TextLength > 6 & guna2CheckBox1.Checked == true & textBox1.Text != "" & textBox4.Text != "" & textBox5.Text != "" )
            {

                SqlCommand cmd = new SqlCommand("INSERT into reciption_registration values (" + "@Name,@Email,@Mobile,@female,@terms,@male,@password" +")", conn);
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
                

            }
            else if (ChechFemale.Checked || CheckMale.Checked == false)
            {
                label9.Text = "Please Choose Gender";
            }
            else if (pass.Text != confirm.Text)
            {
                label7.Text = "Re-confirm Password";
            }

            else if (pass.TextLength < 6)
            {
                label10.Text = "Password is too short";

            }
            else if (guna2CheckBox1.Checked == false)
            {
                label8.Text = "Please check";
            }
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            pass.Text = "";
            confirm.Text = "";
            guna2CheckBox2.Checked = false;
            guna2CheckBox3.Checked= false;
            ChechFemale.Checked= false;
            CheckMale.Checked= false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
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
