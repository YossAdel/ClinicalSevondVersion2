using Guna.UI2.WinForms;
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
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into prescription values(@PName,@PID,@Notes,@DRID,@Prescription)", conn);
            cmd.Parameters.AddWithValue("@PName", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@PID", int.Parse(txdate.Text));
            cmd.Parameters.AddWithValue("@Notes", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@DRID", int.Parse(guna2TextBox3.Text));
            cmd.Parameters.AddWithValue("@Prescription", guna2ComboBox1.SelectedItem);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added successfully");
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

        }
    }
}
