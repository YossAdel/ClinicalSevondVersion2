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
    public partial class PatientUpdate : UserControl
    {
        public PatientUpdate()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from form3 WHERE NationalID='" + textBox2.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE form3 SET FirstName=@FirstName,SecondName=@SecondName,Email=@Email," +
                    "Phone=@Phone," +
                    "Weight=@Weight,Height=@Height WHERE NationalID=@NationalID ", conn);
                cmd.Parameters.AddWithValue("@FirstName", textBox3.Text);
                cmd.Parameters.AddWithValue("@SecondName", textBox1.Text);
                cmd.Parameters.AddWithValue("@NationalID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Phone", textBox5.Text);
                cmd.Parameters.AddWithValue("@Weight", pass.Text);
                cmd.Parameters.AddWithValue("@Height", textBox6.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated successfully");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Missed ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Does't exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
