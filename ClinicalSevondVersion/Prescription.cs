using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalInformatics_2023
{
    public partial class Prescription : UserControl

    {

        int leftcontrol = 17;
        int counter = 1;
        public Prescription()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txdate.Text == "")
            {
                MessageBox.Show("Enter Patient ID");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into prescription values(@PName,@PID,@Notes,@DRID,@Prescription,@Quantity,@Times,@Date)", conn);


                //dataGridView1.DataSource = dt;

                //label6.Text = dt2.ToString();
                cmd.Parameters.AddWithValue("@PName", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@PID", int.Parse(txdate.Text));
                cmd.Parameters.AddWithValue("@Notes", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@DRID", int.Parse(guna2TextBox3.Text));
                cmd.Parameters.AddWithValue("@Prescription", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@Quantity", n1.Value.ToString());
                cmd.Parameters.AddWithValue("@Times", day.Value.ToString());
                cmd.Parameters.AddWithValue("@Date", dateTimePicker3.Value.Date);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added successfully");
                guna2TextBox2.Clear();
            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            n1.Hide();
            gm.Hide();
            label9.Hide();
            day.Hide();
            label6.Hide();
            label7.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "")
            {
                MessageBox.Show("Enter Doctor ID");
            }
            else
            {
                conn.Open();

                SqlCommand cmd2 = new SqlCommand("SELECT Mobile,Name from Drsignup WHERE ID=@ID", conn);
                cmd2.Parameters.AddWithValue("@ID", int.Parse(guna2TextBox3.Text));
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    label7.Show();
                    label6.Show();
                    label7.Text = dr.GetValue(1).ToString();
                    label6.Text = dr.GetValue(0).ToString();
                }
                dr.Close();
                conn.Close();
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "None")
            {
                n1.Hide();
                gm.Hide();
                label9.Hide();
                day.Hide();
            }
            else if (comboBox2.Text== "Deplin" || comboBox2.Text == "Fish oil" || comboBox2.Text == "Leanbean" || comboBox2.Text == "Magnesium" || comboBox2.Text == "Niaspan" || comboBox2.Text == "Phen24" || comboBox2.Text == "PhenQ" || comboBox2.Text == "PrimeShred" ||
                comboBox2.Text == "Trimtone" || comboBox2.Text == "Vasculera" || comboBox2.Text == "Vitamin B12" || comboBox2.Text == "Vitamin B2" || comboBox2.Text == "Vitamin B6" || comboBox2.Text == "Vitamin C"
                || comboBox2.Text == "Vitamin D3" || comboBox2.Text == "Zinc" || comboBox2.Text == "Vitamin D")
            {
                n1.Show();
                gm.Show();
                label9.Show();
                day.Show();
            }
        }
    }
}
