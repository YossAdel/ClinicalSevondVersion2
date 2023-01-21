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
    public partial class ReciptionistRemove : UserControl
    {
        public ReciptionistRemove()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //reciption_registration
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from registration WHERE ID='" + txdate.Text+ "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            
            if ( dt.Rows.Count > 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE reciption_registration WHERE ID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txdate.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully","",MessageBoxButtons.OK);
            }
            else if (txdate.Text == "")
            {
                MessageBox.Show("Missed ID", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Does't exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
