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
    public partial class AddAppointment : UserControl
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            String x = display.Text = dateTimePicker1.Value.ToLongDateString();
            String y = display2.Text = dateTimePicker2.Value.ToShortTimeString();
            String z = display3.Text = textBox1.Text.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void display2_Click(object sender, EventArgs e)
        {
        }
    }
}
