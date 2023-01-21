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
    public partial class ViewDoctorSchedule : UserControl
    {
        public ViewDoctorSchedule()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from appointment WHERE  Date='" + dateTimePicker1.Value.Date + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Passed Date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if ( dt.Rows.Count > 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from appointment WHERE Date=@Date", conn);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);

                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else 
            {
                MessageBox.Show("No reservations for this day", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void ViewDoctorSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
