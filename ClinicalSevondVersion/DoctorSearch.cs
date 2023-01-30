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
    public partial class DoctorSearch : UserControl
    {
        public DoctorSearch()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from form3 WHERE NationalID='" + guna2TextBox1.Text + "'", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            conn.Close();
            if (dt1.Rows.Count > 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from form3 WHERE NationalID=@NationalID", conn);
                cmd.Parameters.AddWithValue("@NationalID", guna2TextBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                
                conn.Close();

            }
            else if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Missed ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Does't exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DoctorSearch_Load(object sender, EventArgs e)
        {

        }

        private void doctorSchedule1_Load(object sender, EventArgs e)
        {

        }
    }
}
