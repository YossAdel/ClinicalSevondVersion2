using ClinicalSevondVersion;
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
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace ClinicalInformatics_2023
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void Registration_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name from registration ", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr["Name"].ToString());

            }
            textBox1.AutoCompleteMode= AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main M= new Main();
            M.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp S = new SignUp();
            S.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String username, userpassword;
            username = textBox1.Text;
            userpassword = textBox2.Text;
            try
            {
                String querry = "SELECT * fROM registration WHERE Name = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    userpassword = textBox2.Text;

                    this.Hide();
                    ReciptionestDashboard D = new ReciptionestDashboard();
                    D.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
