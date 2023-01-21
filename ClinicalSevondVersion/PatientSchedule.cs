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

namespace ClinicalSevondVersion
{
    public partial class PatientSchedule : UserControl
    {
        public PatientSchedule()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from appointment WHERE Time ='" + comboBox2.SelectedItem + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            // conn.Close();

            //conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * from appointment WHERE Date ='" + dateTimePicker3.Value.Date + "'", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);

            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            SqlCommand cmd3 = new SqlCommand("SELECT * from appointment WHERE DRID ='" + int.Parse(guna2TextBox1.Text) + "'", conn);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            conn.Close();



            if (dt.Rows.Count > 0 || dt1.Rows.Count > 1 || dt3.Rows.Count > 2)
            {
                MessageBox.Show("Time Already Reserved \n Pick another", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Missed National ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into appointment values(@PName,@DRName,@DRID,@Notes,@Date,@Time)", conn);
                cmd.Parameters.AddWithValue("@PName", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@DRName", txdate.Text);
                cmd.Parameters.AddWithValue("@DRID", int.Parse(guna2TextBox1.Text));
                cmd.Parameters.AddWithValue("@Notes", guna2TextBox3.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker3.Value.Date);
                cmd.Parameters.AddWithValue("@Time", comboBox2.SelectedItem);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added successfully");

            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
