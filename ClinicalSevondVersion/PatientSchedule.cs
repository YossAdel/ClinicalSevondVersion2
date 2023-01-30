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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            SqlCommand cmd1 = new SqlCommand("SELECT * from Appointment3 WHERE ID ='" + guna2TextBox1.Text + "'AND Date='" + dateTimePicker3.Value.Date + "' AND Time = '" + comboBox2.SelectedItem + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Time Already Reserved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (guna2TextBox1.Text=="" || guna2TextBox2.Text=="" || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Data Missed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Appointment3 values(@ID,@PName,@Date,@Time,@DayOfWeek,@Note)", conn);

                cmd.Parameters.AddWithValue("@ID", guna2TextBox1.Text);
                cmd.Parameters.AddWithValue("@PName", guna2TextBox2.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker3.Value.Date);
                cmd.Parameters.AddWithValue("@Time", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@DayOfWeek", dateTimePicker3.Value.DayOfWeek.ToString());
                cmd.Parameters.AddWithValue("@Note", guna2TextBox3.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                
            }

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
