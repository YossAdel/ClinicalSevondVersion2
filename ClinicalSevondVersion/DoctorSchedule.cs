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
    public partial class DoctorSchedule : UserControl
    {
        public DoctorSchedule()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorSchedule_Load(object sender, EventArgs e)
        {
        }
        

        private void DoctorSchedule_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            //SELECT * from Appointment3 WHERE ID ='" + guna2TextBox1.Text + "'AND Date='" + dateTimePicker3.Value.Date + "' AND Time = '" +
          

            
            
            conn.Close();
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Missed ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (dateTimePicker3.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Passed Date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateTimePicker3.Value.Date >= DateTime.Today)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Appointment3 WHERE ID=@ID AND Date ='" + dateTimePicker3.Value.Date + "' ", conn);
                cmd.Parameters.AddWithValue("@ID", guna2TextBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            /*if(guna2TextBox1.Text == "")
            {
                MessageBox.Show("Missed National ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from appointment WHERE DRID=@DRID", conn);
                cmd.Parameters.AddWithValue("@DRID", int.Parse(guna2TextBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }*/

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointment3TableAdapter.FillBy(this.clinicalDataSet.Appointment3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //guna2DataGridView1.Font= new Font("arial",14,FontStyle.Bold);
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.appointment3TableAdapter1.FillBy(this.clinicalDataSet1.Appointment3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointment3TableAdapter1.FillBy1(this.clinicalDataSet1.Appointment3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.appointment3TableAdapter1.FillBy2(this.clinicalDataSet1.Appointment3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
