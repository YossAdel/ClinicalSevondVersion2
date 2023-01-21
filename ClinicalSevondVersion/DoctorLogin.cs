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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            String email, userpassword;
            email = textBox1.Text;
            userpassword = textBox2.Text;
            try
            {
                String querry = "SELECT * fROM Drsignup WHERE Name = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email = textBox1.Text;
                    userpassword = textBox2.Text;

                    this.Hide();
                    DoctorDashboard D = new DoctorDashboard();
                    D.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Email or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                //MessageBox.Show("Invalid username or password");
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
