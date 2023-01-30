using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicalSevondVersion
{
    public partial class PatientForm : UserControl
    {
        int leftcontrol = 17;
        int counter = 1;
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void CheckMale_CheckedChanged(object sender, EventArgs e)
        {
            /*var array = new CheckBox[] { CheckMale, ChechFemale };
            foreach (var checkbox in array)
            {
                if (checkbox != sender)
                {
                    checkbox.Checked = false;
                }
            }*/
            if (CheckMale.Checked == true)
            {
                ChechFemale.Checked = false;
            }
        }

        private void ChechFemale_CheckedChanged(object sender, EventArgs e)
        {
            /*var array = new CheckBox[] { CheckMale, ChechFemale };
            foreach (var checkbox in array)
            {
                if (checkbox != sender)
                {
                    checkbox.Checked = false;
                }
            }*/
            if (ChechFemale.Checked == true)
            {
                CheckMale.Checked = false;
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            /*ComboBox t1 = new ComboBox();
            this.Controls.Add(t1);
            t1.Top = 192;
            t1.Left = leftcontrol * 24;
            t1.Location = new System.Drawing.Point(15, 800);
            t1.Text = "Drug " + this.counter.ToString();
            counter = counter + 1;
            leftcontrol = leftcontrol + 1;
            t1.Width = 176;
            t1.Height = 36;
            //t1.Location = new System.Drawing.Point(192, 368);
            t1.Items.Add("a");
            t1.Items.Add("b");

            t1.Items.Add("c");
            t1.Items.Add("d");
            t1.Items.Add("e");
            t1.Items.Add("f");*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckYes1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes1.Checked == true)
            {
                CheckNo1.Checked = false;
            }
        }

        private void CheckNo1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo1.Checked == true)
            {
                CheckYes1.Checked = false;
            }
        }

        private void CheckYes2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes2.Checked == true)
            {
                CheckNo2.Checked = false;
            }
        }

        private void CheckNo2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo2.Checked == true)
            {
                CheckYes2.Checked = false;
            }
        }

        private void CheckYes3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes3.Checked == true)
            {
                CheckNo3.Checked = false;
            }
        }

        private void CheckNo3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo3.Checked == true)
            {
                CheckYes3.Checked = false;
            }
        }

        private void CheckYes4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes4.Checked == true)
            {
                CheckNo4.Checked = false;
            }
        }

        

        private void CheckNo4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo4.Checked == true)
            {
                CheckYes4.Checked = false;
            }
        }

        private void CheckYes5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes5.Checked == true)
            {
                CheckNo5.Checked = false;
            }
        }

        private void CheckNo5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo5.Checked == true)
            {
                CheckYes5.Checked = false;
            }
        }

        private void CheckYes6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes6.Checked == true)
            {
                CheckNo6.Checked = false;
            }
        }

        private void CheckNo6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo6.Checked == true)
            {
                CheckYes6.Checked = false;
            }
        }

        private void CheckYes7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckYes7.Checked == true)
            {
                CheckNo7.Checked = false;
            }
        }
        
        private void CheckNo7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNo7.Checked == true)
            {
                CheckYes7.Checked = false;
            }
        }

        private void CheckHi1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckHi1.Checked == true)
            {
                CheckLow1.Checked = false;
                CheckMed1.Checked = false;
            }
        }

        private void CheckMed1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMed1.Checked == true)
            {
                CheckLow1.Checked = false;
                CheckHi1.Checked = false;
            }
        }

        private void CheckLow1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckLow1.Checked == true)
            {
                CheckMed1.Checked = false;
                CheckHi1.Checked = false;
            }
        }

        private void CheckHi2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckHi2.Checked == true)
            {
                CheckLow2.Checked  = false;
                CheckMed2.Checked = false;
            }
        }

        private void CheckMed2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMed2.Checked == true)
            {
                CheckLow2.Checked = false;
                CheckHi2.Checked = false;
            }
        }

        private void CheckLow2_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckLow2.Checked == true)
            {
                CheckMed2.Checked = false;
                CheckHi2.Checked = false;
            }
        }

        private void firstname_enter(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text=="First Name")
            {
                guna2TextBox1.Text = "";
                guna2TextBox1.ForeColor = Color.Black;
            }
        }

       

        private void firstname_leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = "First Name";
                guna2TextBox1.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondname_enter(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Second Name")
            {
                guna2TextBox2.Text = "";
                guna2TextBox2.ForeColor = Color.Black;
            }
        }

        private void secondname_leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = "Second Name";
                guna2TextBox2.ForeColor = Color.Gray;
            }
        }

        private void email_enter(object sender, EventArgs e)
        {
            if (guna2TextBox5.Text == "someone@example.com")
            {
                guna2TextBox5.Text = "";
                guna2TextBox5.ForeColor = Color.Black;
            }
        }

        private void email_leave(object sender, EventArgs e)
        {
            if (guna2TextBox5.Text == "")
            {
                guna2TextBox5.Text = "someone@example.com";
                guna2TextBox5.ForeColor = Color.Black;
            }
        }

        private void phone_enter(object sender, EventArgs e)
        {
            //eg: 01*********
            if (guna2TextBox3.Text == "eg: 01*********")
            {
                guna2TextBox3.Text = "";
                guna2TextBox3.ForeColor = Color.Black;
            }
        }

        private void phone_leave(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "")
            {
                guna2TextBox3.Text = "eg: 01*********";
                guna2TextBox3.ForeColor = Color.Black;
            }
        }

       
        private void add_enter(object sender, EventArgs e)
        {
            if (Address.Text == "City - Street - Building Number ")
            {
                Address.Text = "";
                Address.ForeColor = Color.Black;
            }
        }

        private void add_leave(object sender, EventArgs e)
        {
            if (Address.Text == "")
            {
                Address.Text = "City - Street - Building Number ";
                Address.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentage = DateTime.Today.Year - guna2DateTimePicker1.Value.Year;
            //SELECT * from form2 where NationalID like 'Adam' AND password like '123456';
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * from form3 WHERE NationalID='" + guna2TextBox6.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("National ID Already Exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            /*for (int i = 0; i < str.Length; i++) {
            char c = str[i];
            Console.WriteLine(c);
             */
            else if (guna2TextBox6.Text == "")
            {
                MessageBox.Show("Missed National ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (guna2TextBox6.Text.Length>14||guna2TextBox6.Text.Length<14)
            {
                MessageBox.Show("Invalid National ID ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(guna2TextBox3.Text.Length > 11 || guna2TextBox3.Text.Length < 11)
            {
                MessageBox.Show("Invalid Phone Number ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (guna2TextBox1.Text == "First Name" || guna2TextBox2.Text == "Second Name" || guna2TextBox3.Text == "eg: 01*********" || guna2TextBox5.Text == "someone@example.com"
                    || Address.Text== "City - Street - Building Number ")
                {
                    MessageBox.Show("Invalid Data");
                }
                else if(terms.Checked == false)
                {
                    MessageBox.Show("Kindly Agree terms");
                }
                else
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insert into form3 values(@NationalID,@FirstName,@SecondName,@Date,@Phone,@Email,@Weight,@Height,@Address,@DiseaseNotFound," +
                        "@BloodType,@Exercise,@chronic," +
                        "@AreYouDietingYes,@AreYouDietingNo,@physicianYes,@physicianNo,@SaltHi,@SaltMed,@SaltLow,@FatHi,@FatMed,@FatLow,@PregnantYes,@PregnantNo,@DcYes,@DcNo," +
                        "@UterineYes,@UterineNo,@BloodyYes,@BloodNo,@FellPainYes,@FellPainNo,@Terms,@Male,@Female,@Age)", conn);
                    //NationalID	FirstName	SecondName	Email	Phone	BirthDate	Address	Male	Female	Weight	Height	BloodType	Exercise	
                    //Diseases	DiseaseNotFound	DietYes	DietYes	PrescriptionYes	PrescriptionNO	SaltHi	SaltMed	SaltLow	FatHi	FatMed	FatLow	
                    //PregnantYes	PregnantNo	DcYes	DcNo	UtirineYes	UterineNo	BloodYes	BloodNo	PainYes	PainNO	Terms	ID
                    cmd.Parameters.AddWithValue("@NationalID", guna2TextBox6.Text);
                    cmd.Parameters.AddWithValue("@FirstName", guna2TextBox1.Text);
                    cmd.Parameters.AddWithValue("@SecondName", guna2TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Date", guna2DateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Phone", guna2TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Email", guna2TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Weight", Address.Text);
                    cmd.Parameters.AddWithValue("@Height", weight.Text);
                    cmd.Parameters.AddWithValue("@Address", height.Text);
                    cmd.Parameters.AddWithValue("@DiseaseNotFound", guna2TextBox7.Text);
                    cmd.Parameters.AddWithValue("@BloodType", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@Exercise", comboBox3.SelectedItem);
                    cmd.Parameters.AddWithValue("@chronic", comboBox2.SelectedItem);

                    cmd.Parameters.AddWithValue("@AreYouDietingYes", CheckYes1.Checked);
                    cmd.Parameters.AddWithValue("@AreYouDietingNo", CheckNo1.Checked);
                    //physician
                    cmd.Parameters.AddWithValue("@physicianYes", CheckYes2.Checked);
                    cmd.Parameters.AddWithValue("@physicianNo", CheckNo2.Checked);
                    cmd.Parameters.AddWithValue("@SaltHi", CheckHi1.Checked);
                    cmd.Parameters.AddWithValue("@SaltMed", CheckMed1.Checked);
                    cmd.Parameters.AddWithValue("@SaltLow", CheckLow1.Checked);
                    cmd.Parameters.AddWithValue("@FatHi", CheckHi2.Checked);
                    cmd.Parameters.AddWithValue("@FatMed", CheckMed2.Checked);
                    cmd.Parameters.AddWithValue("@FatLow", CheckLow1.Checked);
                    cmd.Parameters.AddWithValue("@PregnantYes", CheckYes3.Checked);
                    cmd.Parameters.AddWithValue("@PregnantNo", CheckNo3.Checked);
                    cmd.Parameters.AddWithValue("@DcYes", CheckYes4.Checked);
                    cmd.Parameters.AddWithValue("@DcNo", CheckNo4.Checked);
                    cmd.Parameters.AddWithValue("@UterineYes", CheckYes5.Checked);
                    cmd.Parameters.AddWithValue("@UterineNo", CheckNo5.Checked);
                    //BloodyYes
                    cmd.Parameters.AddWithValue("@BloodyYes", CheckYes6.Checked);
                    cmd.Parameters.AddWithValue("@BloodNo", CheckNo6.Checked);
                    cmd.Parameters.AddWithValue("@FellPainYes", CheckYes7.Checked);
                    cmd.Parameters.AddWithValue("@FellPainNo", CheckNo7.Checked);
                    cmd.Parameters.AddWithValue("@Terms", terms.Checked);
                    cmd.Parameters.AddWithValue("@Male", CheckMale.Checked);
                    cmd.Parameters.AddWithValue("@Female", ChechFemale.Checked);
                    cmd.Parameters.AddWithValue("@Age", currentage.ToString());






                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Added successfully");
                }
                
            }


            /*if (guna2TextBox1.Text == "First Name")
            {

                MessageBox.Show("Enter Name");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into form2 values(@NationalID,@FirstName)", conn);
                //NationalID	FirstName	SecondName	Email	Phone	BirthDate	Address	Male	Female	Weight	Height	BloodType	Exercise	
                //Diseases	DiseaseNotFound	DietYes	DietYes	PrescriptionYes	PrescriptionNO	SaltHi	SaltMed	SaltLow	FatHi	FatMed	FatLow	
                //PregnantYes	PregnantNo	DcYes	DcNo	UtirineYes	UterineNo	BloodYes	BloodNo	PainYes	PainNO	Terms	ID



                cmd.Parameters.AddWithValue("@NationalID", Int64.Parse(guna2TextBox6.Text));
                cmd.Parameters.AddWithValue("@FirstName", guna2TextBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added successfully");
            }*/
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
