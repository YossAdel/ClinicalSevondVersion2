using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ClinicalInformatics_2023
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration R = new Registration();
            R.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*conn.Close();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            ChechFemale.Checked= false;
            CheckMale.Checked= false;
            guna2CheckBox1.Checked= false;
            textBox3.Clear();
            textBox2.Clear();*/

           

            if (textBox3.Text == textBox2.Text & textBox3.TextLength>6 & guna2CheckBox1.Checked==true & textBox1.Text!=""& textBox4.Text != "" & textBox5.Text != "")
            {

                SqlCommand cmd = new SqlCommand("INSERT into registration values (@Name,@Email,@Mobile,@female,@terms,@male,@password)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Mobile", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@female", ChechFemale.Checked);
                cmd.Parameters.AddWithValue("@terms", guna2CheckBox1.Checked);
                cmd.Parameters.AddWithValue("@male", CheckMale.Checked);
                cmd.Parameters.AddWithValue("@password", textBox3.Text);
                cmd.ExecuteNonQuery();
                

                //MessageBox.Show("Successfully Added");
                this.Hide();
                Registration  R= new Registration();
                R.Show();
                
            }

            else if (textBox3.TextLength<6) {
                label8.Text = "Password is too short";
                
            }
            else if (guna2CheckBox1.Checked==false)
            {
                label10.Text = "Please check";
            }
            else if (ChechFemale.Checked || CheckMale.Checked == false)
            {
                label9.Text = "Please Choose Gender";
            }
            else
            {
                label7.Text = "Re-confirm Password";
            }




        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox3.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
