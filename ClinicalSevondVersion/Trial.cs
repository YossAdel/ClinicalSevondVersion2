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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicalSevondVersion
{
    public partial class Trial : Form
    {
        public Trial()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            int currentage = DateTime.Today.Year- dateTimePicker1.Value.Year;
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from app4 WHERE Time ='" + comboBox1.SelectedItem + "'AND Time2='"+dateTimePicker1.Value.Date+"' AND ID = '"+ textBox1.Text+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            /*SqlCommand cmd2 = new SqlCommand("SELECT * from app3 WHERE Time2 ='" + dateTimePicker1.Value.Date + "'", conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);*/
            conn.Close();

            if (dt.Rows.Count >0)
            {
                MessageBox.Show("555555");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into app4 values(@Time,@Time2,@ID,@Dayofweek,@age)", conn);

                cmd.Parameters.AddWithValue("@Time", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@Time2", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Dayofweek", dateTimePicker1.Value.DayOfWeek.ToString());
                cmd.Parameters.AddWithValue("@age", currentage.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added successfully");
            }
            


        }
    }
}
