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
    public partial class ReciptionestUpdate : UserControl
    {
        public ReciptionestUpdate()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from reciption_registration WHERE ID='" + textBox2.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE reciption_registration SET Name=@Name,Email=@Email," +
                    "Mobile=@Mobile," +
                    "password=@password WHERE ID=@ID ", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Mobile", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@password", int.Parse(pass.Text));
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

        private void ReciptionestUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
