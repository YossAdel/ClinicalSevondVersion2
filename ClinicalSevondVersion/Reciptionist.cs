using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalSevondVersion
{
    public partial class Reciptionist : UserControl
    {
        public Reciptionist()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reciptionSignUp1.Show();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Show();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Reciptionist_Load(object sender, EventArgs e)
        {
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void Reciptionist_Load_1(object sender, EventArgs e)
        {
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Show();
            reciptionistRemove1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           /* reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();*/
        }

        private void Reciptionist_Load_2(object sender, EventArgs e)
        {
            //
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void Reciptionist_Load_3(object sender, EventArgs e)
        {
            //hideall
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void Reciptionist_Load_4(object sender, EventArgs e)
        {
            //hideall true
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }

        private void Reciptionist_Load_5(object sender, EventArgs e)
        {
            // 
            reciptionSignUp1.Hide();
            reciptionestUpdate1.Hide();
            reciptionistFinance1.Hide();
            reciptionistRemove1.Hide();
        }
    }
}
