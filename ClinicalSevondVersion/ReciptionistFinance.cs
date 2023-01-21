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
    public partial class ReciptionistFinance : UserControl
    {
        public ReciptionistFinance()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             total.Text = (float.Parse(Dr.Text) + float.Parse(nursing.Text) + float.Parse(medicine.Text) + float.Parse(therapeutic.Text) + float.Parse(others.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into finance values(@Dr,@medicine,@nursing,@threra,@other,@total,@PatientID,@PatientName)", conn);
            
            cmd.Parameters.AddWithValue("@Dr", float.Parse(Dr.Text));
            cmd.Parameters.AddWithValue("@medicine", float.Parse(medicine.Text));
            cmd.Parameters.AddWithValue("@nursing", float.Parse(nursing.Text));
            cmd.Parameters.AddWithValue("@threra", float.Parse(therapeutic.Text));
            cmd.Parameters.AddWithValue("@other", float.Parse(others.Text));
            cmd.Parameters.AddWithValue("@total", float.Parse(total.Text));
            cmd.Parameters.AddWithValue("@PatientID", int.Parse(PID.Text));
            cmd.Parameters.AddWithValue("@PatientName", Name.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            

            MessageBox.Show("Added successfully");

        }
    }
}
