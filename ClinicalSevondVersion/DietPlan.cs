using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ClinicalSevondVersion
{
    public partial class DietPlan : UserControl
    {
        public DietPlan()
        {
            InitializeComponent();
            
        }
        double skimmed_milk = 83;
        double whole_milk = 150;
        double low_milk = 100;
        double coffee = 0;
        double green_tea = 2;
        double red_tea = 2;
        double oat = 3.78;
        double nuts = 6.07;
        double cheese = 1.03;
        double chia = 73;
        double liteyogurt = 70;
        double fullfatyogurt = 149;
        double boiledegg = 155;
        double omletteegg = 183;
        double banana = 90;
        double apple = 52;
        double cbean = 0.88;




        private void all()
        {
            cup.Hide();
            cup2.Hide();
            cup3.Hide();
            cup4.Hide();
            cup5.Hide();

            spoon.Hide();
            spoon2.Hide();
            spoon3.Hide();
            spoon4.Hide();
            spoon5.Hide();

            gram.Hide();
            gram2.Hide();
            gram3.Hide();
            gram4.Hide();
            gram5.Hide();


            skimmed.Hide();
            skimmed2.Hide();
            skimmed3.Hide();
            skimmed4.Hide();
            skimmed5.Hide();

            whole.Hide();
            whole2.Hide();
            whole3.Hide();
            whole4.Hide();
            whole5.Hide();

            low.Hide();
            low2.Hide();
            low3.Hide();
            low4.Hide();
            low5.Hide();

            boiled.Hide();
            boiled2.Hide();
            boiled3.Hide();
            boiled4.Hide();
            boiled5.Hide();

            omelette.Hide();
            omelette2.Hide();
            omelette3.Hide();
            omelette4.Hide();
            omelette5.Hide();

            full.Hide();
            full2.Hide();
            full3.Hide();
            full4.Hide();
            full5.Hide();

            lite.Hide();
            lite2.Hide();
            lite3.Hide();
            lite4.Hide();
            lite5.Hide();





        }
        private void first()
        {
            cup.Hide();
            spoon.Hide();
            gram.Hide();
            skimmed.Hide();
            whole.Hide();
            low.Hide();
            lite.Hide();
            full.Hide();
            omelette.Hide();
            boiled.Hide();
        }
        private void third()
        {
            cup3.Hide();
            spoon3.Hide();
            gram3.Hide();
            skimmed3.Hide();
            whole3.Hide();
            low3.Hide();
            lite3.Hide();
            full3.Hide();
            omelette3.Hide();
            boiled3.Hide();
        }
        private void fourth()
        {
            cup4.Hide();
            spoon4.Hide();
            gram4.Hide();
            skimmed4.Hide();
            whole4.Hide();
            low4.Hide();
            lite4.Hide();
            full4.Hide();
            omelette4.Hide();
            boiled4.Hide();
        }
        private void second()
        {
            cup2.Hide();
            spoon2.Hide();
            gram2.Hide();
            skimmed2.Hide();
            whole2.Hide();
            low2.Hide();
            lite2.Hide();
            full2.Hide();
            omelette2.Hide();
            boiled2.Hide();
        }
        private void fifth()
        {
            cup5.Hide();
            spoon5.Hide();
            gram5.Hide();
            skimmed5.Hide();
            whole5.Hide();
            low5.Hide();
            lite5.Hide();
            full5.Hide();
            omelette5.Hide();
            boiled5.Hide();
        }
        private void malecal()
        {
            double BMR = 66.5 + (13.75 * int.Parse(weight.Text)) + (5.003 * int.Parse(Height.Text)) - (6.75 * int.Parse(age.Text));
            double v = Math.Round(BMR);
            total.Text = v.ToString();


           
            double result = double.Parse(weight.Text) / (double.Parse(Height.Text)/100* double.Parse(Height.Text)/100) ;
            //bmi = (weight * 703) / (height * height);
            T1.Show();
            T6.Show();
            T2.Show();
            
            T6.Text = result.ToString("#.#") + " kg/m2 ";

            if (result < 16)
            {
                T2.Text = "Severe Thinness";
                T2.ForeColor= Color.Red;
            }
            else if (result > 16 && result<17)
            {

                T2.Text = "Moderate Thinness";
                T2.ForeColor = Color.DeepPink;
            }
            else if (result > 17 && result < 18.5)
            {

                T2.Text = "Mild Thinness";
                T2.ForeColor = Color.Yellow;
            }
            else if (result > 18.5 && result < 25)
            {

                T2.Text = "Normal";
                T2.ForeColor = Color.Green;
            }
            else if (result > 25 && result < 30)
            {

                T2.Text = "Overweight";
                T2.ForeColor = Color.Yellow;
            }
            
            else if (result > 30 && result < 35)
            {
                T2.Text = "Obese Class I";
                T2.ForeColor = Color.DeepPink;
            }
            else if (result > 35 && result < 40)
            {
                T2.Text = "Obese Class II";
                T2.ForeColor = Color.Red;
            }
            else if (result > 40)
            {
                T2.Text = "Obese Class III";
                T2.ForeColor = Color.DarkRed;
            }



        }
        private void femalecal()
        {
            double BMR = 655.1 + (9.563 * int.Parse(weight.Text)) + (1.850 * int.Parse(Height.Text)) - (4.676 * int.Parse(age.Text));
            double v = Math.Round(BMR);
            total.Text = v.ToString();
            double result = double.Parse(weight.Text) / (double.Parse(Height.Text) / 100 * double.Parse(Height.Text) / 100);

            T1.Show();
            T6.Show();
            T2.Show();

            T6.Text = result.ToString("#.#") + " kg/m2 ";

            if (result < 16)
            {
                T2.Text = "Severe Thinness";
                T2.ForeColor = Color.Red;
            }
            else if (result > 16 && result < 17)
            {

                T2.Text = "Moderate Thinness";
                T2.ForeColor = Color.DeepPink;
            }
            else if (result > 17 && result < 18.5)
            {

                T2.Text = "Mild Thinness";
                T2.ForeColor = Color.Yellow;
            }
            else if (result > 18.5 && result < 25)
            {

                T2.Text = "Normal";
                T2.ForeColor = Color.Green;
            }
            else if (result > 25 && result < 30)
            {

                T2.Text = "Overweight";
                T2.ForeColor = Color.Yellow;
            }

            else if (result > 30 && result < 35)
            {
                T2.Text = "Obese Class I";
                T2.ForeColor = Color.DeepPink;
            }
            else if (result > 35 && result < 40)
            {
                T2.Text = "Obese Class II";
                T2.ForeColor = Color.Red;
            }
            else if (result > 40)
            {
                T2.Text = "Obese Class III";
                T2.ForeColor = Color.DarkRed;
            }

        }

        private void appear()
        {
            String meal = c1.Text;

            switch(meal)
            {
                case "None":
                    first();
                    break;

                case "Chia Seeds":
                    first();
                    spoon.Show();
                    break;
            
                case "Coffee":
                    first();
                    cup.Show();
                    break;
                case "Milk":
                    first();
                    cup.Show();
                    skimmed.Show();
                    whole.Show();
                    low.Show();
                    break;
                case "Red Tea":
                    first();
                    cup.Show();
                    break;
                case "Green Tea":
                    first();
                    cup.Show();
                    break;

                case "Quraish cheese":
                    first();
                    gram.Show();
                    break;
                case "Oat":
                    first();
                    gram.Show();
                    break;
                case "Nuts":
                    first();
                    gram.Show();
                    break;
                case "Bean":
                    first();
                    gram.Show();
                    break;
                case "Yogurt":
                    first();
                    lite.Show();
                    full.Show();
                    break;
                case "Apple":
                    first();
                    break;
                case "Bananas":
                    first();
                    break;
                case "Eggs":
                    first();
                    omelette.Show();
                    boiled.Show();
                    break;

            }
        }
        private void appear2()
        {
            String meal = c2.Text;

            switch (meal)
            {
                case "None":
                    second();
                    break;

                case "Chia Seeds":
                    second();
                    spoon2.Show();
                    break;

                case "Coffee":
                    second();
                    cup2.Show();
                    break;
                case "Milk":
                    second();
                    cup2.Show();
                    skimmed2.Show();
                    whole2.Show();
                    low2.Show();
                    break;
                case "Red Tea":
                    second();
                    cup2.Show();
                    break;
                case "Green Tea":
                    second();
                    cup2.Show();
                    break;

                case "Quraish cheese":
                    second();
                    gram2.Show();
                    break;
                case "Oat":
                    second();
                    gram2.Show();
                    break;
                case "Nuts":
                    second();
                    gram2.Show();
                    break;
                case "Bean":
                    second();
                    gram2.Show();
                    break;
                case "Yogurt":
                    second();
                    lite2.Show();
                    full2.Show();
                    break;
                case "Apple":
                    second();
                    break;
                case "Bananas":
                    second();
                    break;
                case "Eggs":
                    second();
                    omelette2.Show();
                    boiled2.Show();
                    break;

            }

        }
        private void appear3() {

            String meal = c3.Text;

            switch (meal)
            {
                case "None":
                    third();
                    break;

                case "Chia Seeds":
                    third();
                    spoon3.Show();
                    break;

                case "Coffee":
                    third();
                    cup3.Show();
                    break;
                case "Milk":
                    third();
                    cup3.Show();
                    skimmed3.Show();
                    whole3.Show();
                    low3.Show();
                    break;
                case "Red Tea":
                    third();
                    cup3.Show();
                    break;
                case "Green Tea":
                    third();
                    cup3.Show();
                    break;

                case "Quraish cheese":
                    third();
                    gram3.Show();
                    break;
                case "Oat":
                    third();
                    gram3.Show();
                    break;
                case "Nuts":
                    third();
                    gram3.Show();
                    break;
                case "Bean":
                    third();
                    gram3.Show();
                    break;
                case "Yogurt":
                    third();
                    lite3.Show();
                    full3.Show();
                    break;
                case "Apple":
                    third(); ;
                    break;
                case "Bananas":
                    third();
                    break;
                case "Eggs":
                    third();
                    boiled3.Show();
                    omelette3.Show();
                    break;

            }

        }
        private void appear4()
        {
            String meal = c4.Text;

            switch (meal)
            {
                case "None":
                    fourth();
                    break;

                case "Chia Seeds":
                    fourth();
                    spoon4.Show();
                    break;

                case "Coffee":
                    fourth();
                    
                    cup4.Show();
                    break;
                case "Milk":
                    fourth();

                    cup4.Show();
                    skimmed4.Show();
                    whole4.Show();
                    low4.Show();
                    break;
                case "Red Tea":
                    fourth();

                    cup4.Show();
                    break;
                case "Green Tea":
                    fourth();

                    cup4.Show();
                    break;

                case "Quraish cheese":
                    fourth();

                    gram4.Show();
                    break;
                case "Oat":
                    fourth();

                    gram4.Show();
                    break;
                case "Nuts":
                    fourth();

                    gram4.Show();
                    break;
                case "Bean":
                    fourth();

                    gram4.Show();
                    break;
                case "Yogurt":
                    fourth();
                    lite4.Show();
                    full4.Show();
                    

                    break;
                case "Apple":
                    fourth();

                    break;
                case "Bananas":
                    fourth();

                    break;
                case "Eggs":
                    fourth();
                    boiled4.Show();
                    omelette4.Show();
                   

                    break;

            }
        }
        private void appear5()
        {
            String meal = c5.Text;

            switch (meal)
            {
                case "None":
                    fifth();
                    break;

                case "Chia Seeds":
                    fifth();
                    spoon5.Show();
                    break;

                case "Coffee":
                    fifth();
                    cup5.Show();
                    break;
                case "Milk":
                    fifth();
                    cup5.Show();
                    skimmed5.Show();
                    whole5.Show();
                    low5.Show();
                    break;
                case "Red Tea":
                    fifth();
                    cup5.Show();
                    break;
                case "Green Tea":
                    fifth();
                    cup5.Show();
                    break;

                case "Quraish cheese":
                    fifth();
                    gram5.Show();
                    break;
                case "Oat":
                    fifth();
                    gram5.Show();
                    break;
                case "Nuts":
                    fifth();
                    gram5.Show();
                    break;
                case "Bean":
                    fifth();
                    gram5.Show();
                    break;
                case "Yogurt":

                    fifth();
                    lite5.Show();
                    full5.Show();
                    break;
                case "Apple":
                    fifth();
                    break;
                case "Bananas":
                    fifth();
                    break;
                case "Eggs":
                    fifth();
                    omelette5.Show();
                    boiled5.Show();
                    break;

            }
        }
        private void DietPlan_Load(object sender, EventArgs e)
        {
            all();
            
            T1.Hide();
            T2.Hide();

            T6.Hide();
          
          



        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            //int calories =  int.Parse(textBox1.Text) * 89;
            //total.Text = calories.ToString();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            //int calories = int.Parse(n2.Text
               // ) * 89;
            //total.Text = calories.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            appear();
        }

        private void Units2_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            appear2();

        }

        private void weight_enter(object sender, EventArgs e)
        {
            //
            if (weight.Text == "Weight")
            {
                weight.Text = "";
                weight.ForeColor = Color.Black;
            }
        }

        private void weight_leave(object sender, EventArgs e)
        {
            //
            if (weight.Text == "")
            {
                weight.Text = "Weight";
                weight.ForeColor = Color.Gray;
            }
        }

        private void height_enter(object sender, EventArgs e)
        {
            //
            if (Height.Text == "Height")
            {
                Height.Text = "";
                Height.ForeColor = Color.Black;
            }
        }

        private void height_leave(object sender, EventArgs e)
        {
            if (Height.Text == "")
            {
                Height.Text = "Height";
                Height.ForeColor = Color.Gray;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void age_enter(object sender, EventArgs e)
        {
            if (age.Text == "Age")
            {
                age.Text = "";
                age.ForeColor = Color.Black;
            }
        }

        private void age_leave(object sender, EventArgs e)
        {
            if (age.Text == "")
            {
                age.Text = "Age";
                age.ForeColor = Color.Gray;
            }
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            /*if (male.Checked == true)
            {
                

                double BMR = 66.5 + (13.75 * int.Parse(weight.Text)) + (5.003 * int.Parse(Height.Text)) - (6.75 * int.Parse(age.Text));
                total.Text = BMR.ToString();
            }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        //double hinm = double.Parse(Height.Text) / 100;
        //double BMI = double.Parse(weight.Text) / hinm * hinm;
        //double BMI = 120;
        private void total1_Click(object sender, EventArgs e)
        {

            if (male.Checked == false && Female.Checked == false)
            {
                MessageBox.Show("Choose gender");
            }
            else
            {
                if (male.Checked == true)
                {
                    /*
                     * BMR = 66.5 + (13.75 * weight in kg) + (5.003 * height in cm) - (6.75 * age) */

                    malecal();


                }
                else
                {
                    //BMR = 655.1 + (9.563 * weight in kg) + (1.850 * height in cm) - (4.676 * age)
                    femalecal();
                }

            }
            


        }
        private void num(object sender, KeyPressEventArgs e) {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        private void only_num(object sender, KeyPressEventArgs e)
        {
            num(sender,e);
        }

        private void h_num(object sender, KeyPressEventArgs e)
        {
            num(sender, e);
        }

        private void a_num(object sender, KeyPressEventArgs e)
        {
            num(sender, e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            appear3();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            appear4();
        }

        private void whole_CheckedChanged(object sender, EventArgs e)
        {
            if (whole.Checked == true)
            {
                skimmed.Checked = false;
                low.Checked = false;
            }
        }

        private void low_CheckedChanged(object sender, EventArgs e)
        {
            if (low.Checked == true)
            {
                whole.Checked = false;
                skimmed.Checked = false;
            }
        }

        private void skimmed_CheckedChanged(object sender, EventArgs e)
        {

            if (skimmed.Checked == true)
            {
                whole.Checked = false;
                low.Checked = false;
            }
        }

        private void whole2_CheckedChanged(object sender, EventArgs e)
        {
            if (whole2.Checked == true)
            {
                skimmed2.Checked = false;
                low2.Checked = false;
            }
        }

        private void low2_CheckedChanged(object sender, EventArgs e)
        {

            if (low2.Checked == true)
            {
                whole2.Checked = false;
                skimmed2.Checked = false;
            }
        }
        private void skimmed2_CheckedChanged(object sender, EventArgs e)
        {
            if (skimmed2.Checked == true)
            {
                whole2.Checked = false;
                low2.Checked = false;
            }
        }

        private void whole3_CheckedChanged(object sender, EventArgs e)
        {
            if (whole3.Checked == true)
            {
                skimmed3.Checked = false;
                low3.Checked = false;
            }
        }

        private void whole4_CheckedChanged(object sender, EventArgs e)
        {
            if (whole4.Checked == true)
            {
                skimmed4.Checked = false;
                low4.Checked = false;
            }

        }

        private void whole5_CheckedChanged(object sender, EventArgs e)
        {
            if (whole5.Checked == true)
            {
                skimmed5.Checked = false;
                low5.Checked = false;
            }
        }

        private void low3_CheckedChanged(object sender, EventArgs e)
        {

            if (low3.Checked == true)
            {
                whole3.Checked = false;
                skimmed3.Checked = false;
            }
        }

        private void low4_CheckedChanged(object sender, EventArgs e)
        {

            if (low4.Checked == true)
            {
                whole4.Checked = false;
                skimmed4.Checked = false;
            }
        }

        private void low5_CheckedChanged(object sender, EventArgs e)
        {
            if (low5.Checked == true)
            {
                whole5.Checked = false;
                skimmed5.Checked = false;
            }

        }

        private void skimmed3_CheckedChanged(object sender, EventArgs e)
        {

            if (skimmed3.Checked == true)
            {
                whole3.Checked = false;
                low3.Checked = false;
            }
        }

        private void skimmed4_CheckedChanged(object sender, EventArgs e)
        {

            if (skimmed4.Checked == true)
            {
                whole4.Checked = false;
                low4.Checked = false;
            }
        }

        private void skimmed5_CheckedChanged(object sender, EventArgs e)
        {

            if (skimmed5.Checked == true)
            {
                whole5.Checked = false;
                low5.Checked = false;
            }
        }

        private void omelette_CheckedChanged(object sender, EventArgs e)
        {
            if (omelette.Checked == true)
            {
                boiled.Checked = false;
                
            }
        }

        private void omelette2_CheckedChanged(object sender, EventArgs e)
        {
            if (omelette2.Checked == true)
            {
                boiled2.Checked = false;

            }
        }

        private void omelette3_CheckedChanged(object sender, EventArgs e)
        {
            if (omelette3.Checked == true)
            {
                boiled3.Checked = false;

            }
        }

        private void omelette4_CheckedChanged(object sender, EventArgs e)
        {
            if (omelette4.Checked == true)
            {
                boiled4.Checked = false;

            }
        }

        private void omelette5_CheckedChanged(object sender, EventArgs e)
        {
            if (omelette5.Checked == true)
            {
                boiled5.Checked = false;

            }
        }

        private void boiled_CheckedChanged(object sender, EventArgs e)
        {
            if (boiled.Checked == true)
            {
                omelette.Checked = false;

            }
        }

        private void boiled2_CheckedChanged(object sender, EventArgs e)
        {
            if (boiled2.Checked == true)
            {
                omelette2.Checked = false;

            }
        }

        private void boiled3_CheckedChanged(object sender, EventArgs e)
        {
            if (boiled3.Checked == true)
            {
                omelette3.Checked = false;

            }
        }

        private void boiled4_CheckedChanged(object sender, EventArgs e)
        {
            if (boiled4.Checked == true)
            {
                omelette4.Checked = false;

            }
        }

        private void boiled5_CheckedChanged(object sender, EventArgs e)
        {
            if (boiled5.Checked == true)
            {
                omelette5.Checked = false;

            }
        }

        private void lite_CheckedChanged(object sender, EventArgs e)
        {
            if (lite.Checked == true)
            {
                full.Checked = false;

            }
        }

        private void lite2_CheckedChanged(object sender, EventArgs e)
        {
            if (lite2.Checked == true)
            {
                full2.Checked = false;

            }
        }

        private void lite3_CheckedChanged(object sender, EventArgs e)
        {
            if (lite3.Checked == true)
            {
                full3.Checked = false;

            }
        }

        private void lite4_CheckedChanged(object sender, EventArgs e)
        {
            if (lite4.Checked == true)
            {
                full4.Checked = false;

            }
        }

        private void lite5_CheckedChanged(object sender, EventArgs e)
        {
            if (lite5.Checked == true)
            {
                full5.Checked = false;

            }
        }

        private void full_CheckedChanged(object sender, EventArgs e)
        {
            if (full.Checked == true)
            {
                lite.Checked = false;

            }
        }

        private void full2_CheckedChanged(object sender, EventArgs e)
        {
            if (full2.Checked == true)
            {
                lite2.Checked = false;

            }
        }

        private void full3_CheckedChanged(object sender, EventArgs e)
        {
            if (full3.Checked == true)
            {
                lite3.Checked = false;

            }
        }

        private void full4_CheckedChanged(object sender, EventArgs e)
        {
            if (full4.Checked == true)
            {
                lite4.Checked = false;

            }
        }

        private void full5_CheckedChanged(object sender, EventArgs e)
        {
            if (full5.Checked == true)
            {
                lite5.Checked = false;

            }
        }

        private void c5_SelectedIndexChanged(object sender, EventArgs e)
        {
            appear5();
        }

        private void c4_SelectedIndexChanged(object sender, EventArgs e)
        {
            appear4();
        }

        private void c5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            appear5();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            /*
       
        
       
        double banana = 90;
        double apple = 52;*/
        }
        double totalcal = 0;
        double totalcal1 = 0;
        /*None
        Chia Seeds
Oat
Yogurt
Eggs
Bananas
Coffee
Milk
Red Tea
Green Tea
Nuts
Apple
Quraish cheese
Bean*/
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //c1
            if(c1.Text == "Nuts" || c1.Text == "Oat" || c1.Text == "Chia Seeds" || c1.Text == "Eggs" || c1.Text == "Bananas" || c1.Text == "Coffee" || c1.Text == "Red Tea" || c1.Text == "Green Tea" || c1.Text == "Apple" || c1.Text == "Quraish cheese" || c1.Text == "Bean" || c1.Text == "Milk" || c1.Text == "Yogurt") 
            { 
                if (c1.Text == "Nuts")
                {
                    totalcal =  nuts*int.Parse(n1.Text);
                }
                else if (c1.Text == "Oat")
                {
                    totalcal = oat * int.Parse(n1.Text);
                }
                else if(c1.Text == "Chia Seeds")
                {
                    totalcal = chia * int.Parse(n1.Text);
                }
                else if (c1.Text == "Eggs")
                {
                    if (c1.Text == "Eggs" && omelette.Checked==true)
                    {
                        totalcal = omletteegg * int.Parse(n1.Text);
                    }
                    else
                    {
                        totalcal = boiledegg * int.Parse(n1.Text);
                    }
                    
                }
                else if (c1.Text == "Bananas")
                {
                    totalcal = banana * int.Parse(n1.Text);
                    
                }
                else if (c1.Text == "Coffee")
                {
                    totalcal = coffee * int.Parse(n1.Text);

                }
                else if (c1.Text == "Red Tea")
                {
                    totalcal = red_tea * int.Parse(n1.Text);

                }
                else if (c1.Text == "Green Tea")
                {
                    totalcal = green_tea * int.Parse(n1.Text);

                }
                else if (c1.Text == "Quraish cheese")
                {
                    totalcal = cheese * int.Parse(n1.Text);

                }
                else if (c1.Text == "Apple")
                {
                    totalcal = apple * int.Parse(n1.Text);

                }
                else if (c1.Text == "Bean")
                {
                    totalcal = cbean * int.Parse(n1.Text);

                }
                else if (c1.Text == "Milk")
                { 
                    if (skimmed.Checked == true)
                    {
                        totalcal = skimmed_milk * int.Parse(n1.Text);
                    }
                    else if (whole.Checked == true)
                    {
                        totalcal = whole_milk * int.Parse(n1.Text);
                    }
                    else if (low.Checked == true)
                    {
                        totalcal = low_milk * int.Parse(n1.Text);
                    }
                }
                else if(c1.Text == "Yogurt")
                {
                    if (lite.Checked == true)
                    {
                        totalcal = liteyogurt * int.Parse(n1.Text);
                    }
                    else if (full.Checked==true)
                    {
                        totalcal = fullfatyogurt * int.Parse(n1.Text);
                    }
                }

            }
            taken.Text = totalcal.ToString();
            //c2
            if (c2.Text == "Nuts" || c2.Text == "Oat" || c2.Text == "Chia Seeds" || c2.Text == "Eggs" || c2.Text == "Bananas" || c2.Text == "Coffee" || c2.Text == "Red Tea" || c2.Text == "Green Tea" || c2.Text == "Apple" || c2.Text == "Quraish cheese" || c2.Text == "Bean" || c2.Text == "Milk" || c2.Text == "Yogurt")
            {
                if (c2.Text == "Nuts")
                {
                    totalcal = nuts * int.Parse(n2.Text) + totalcal;
                }
                else if (c2.Text == "Oat")
                {
                    totalcal = oat * int.Parse(n2.Text)+totalcal;
                }
                else if (c2.Text == "Chia Seeds")
                {
                    totalcal = chia * int.Parse(n2.Text) + totalcal;
                }
                else if (c2.Text == "Eggs")
                {
                    if (c2.Text == "Eggs" && omelette2.Checked == true)
                    {
                        totalcal = omletteegg * int.Parse(n2.Text) + totalcal;
                    }
                    else if(c2.Text == "Eggs" && boiled2.Checked == true)
                    {
                        totalcal = boiledegg * int.Parse(n2.Text) + totalcal;
                    }

                }
                else if (c2.Text == "Bananas")
                {
                    totalcal = banana * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Coffee")
                {
                    totalcal = coffee * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Red Tea")
                {
                    totalcal = red_tea * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Green Tea")
                {
                    totalcal = green_tea * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Quraish cheese")
                {
                    totalcal = cheese * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Apple")
                {
                    totalcal = apple * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Bean")
                {
                    totalcal = cbean * int.Parse(n2.Text) + totalcal;

                }
                else if (c2.Text == "Milk")
                {
                    if (skimmed2.Checked == true)
                    {
                        totalcal = skimmed_milk * int.Parse(n2.Text) + totalcal;
                    }
                    else if (whole2.Checked == true)
                    {
                        totalcal = whole_milk * int.Parse(n2.Text) + totalcal;
                    }
                    else if (low2.Checked == true)
                    {
                        totalcal = low_milk * int.Parse(n2.Text) + totalcal;
                    }
                }
                else if (c2.Text == "Yogurt")
                {
                    if (lite2.Checked == true)
                    {
                        totalcal = liteyogurt * int.Parse(n2.Text) + totalcal;
                    }
                    else if (full2.Checked == true)
                    {
                        totalcal = fullfatyogurt * int.Parse(n2.Text) + totalcal;
                    }
                }

            }
            taken.Text = totalcal.ToString();

            //c3
            if (c3.Text == "Nuts" || c3.Text == "Oat" || c3.Text == "Chia Seeds" || c3.Text == "Eggs" || c3.Text == "Bananas" || c3.Text == "Coffee" || c3.Text == "Red Tea" || c3.Text == "Green Tea" || c3.Text == "Apple" || c3.Text == "Quraish cheese" || c3.Text == "Bean" || c3.Text == "Milk" || c3.Text == "Yogurt")
            {
                if (c3.Text == "Nuts")
                {
                    totalcal = nuts * int.Parse(n3.Text) + totalcal;
                }
                else if (c3.Text == "Oat")
                {
                    totalcal = oat * int.Parse(n3.Text) + totalcal;
                }
                else if (c3.Text == "Chia Seeds")
                {
                    totalcal = chia * int.Parse(n3.Text) + totalcal;
                }
                else if (c3.Text == "Eggs")
                {
                    if (c3.Text == "Eggs" && omelette3.Checked == true)
                    {
                        totalcal = omletteegg * int.Parse(n3.Text) + totalcal;
                    }
                    else if (c3.Text == "Eggs" && boiled3.Checked == true)
                    {
                        totalcal = boiledegg * int.Parse(n3.Text) + totalcal;
                    }

                }
                else if (c3.Text == "Bananas")
                {
                    totalcal = banana * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Coffee")
                {
                    totalcal = coffee * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Red Tea")
                {
                    totalcal = red_tea * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Green Tea")
                {
                    totalcal = green_tea * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Quraish cheese")
                {
                    totalcal = cheese * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Apple")
                {
                    totalcal = apple * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Bean")
                {
                    totalcal = cbean * int.Parse(n3.Text) + totalcal;

                }
                else if (c3.Text == "Milk")
                {
                    if (skimmed3.Checked == true)
                    {
                        totalcal = skimmed_milk * int.Parse(n3.Text) + totalcal;
                    }
                    else if (whole3.Checked == true)
                    {
                        totalcal = whole_milk * int.Parse(n3.Text) + totalcal;
                    }
                    else if (low3.Checked == true)
                    {
                        totalcal = low_milk * int.Parse(n3.Text) + totalcal;
                    }
                }
                else if (c3.Text == "Yogurt")
                {
                    if (lite3.Checked == true)
                    {
                        totalcal = liteyogurt * int.Parse(n3.Text) + totalcal;
                    }
                    else if (full3.Checked == true)
                    {
                        totalcal = fullfatyogurt * int.Parse(n3.Text) + totalcal;
                    }
                }

            }
            taken.Text = totalcal.ToString();

            //c4
            if (c4.Text == "Nuts" || c4.Text == "Oat" || c4.Text == "Chia Seeds" || c4.Text == "Eggs" || c4.Text == "Bananas" || c4.Text == "Coffee" || c4.Text == "Red Tea" || c4.Text == "Green Tea" || c4.Text == "Apple" || c4.Text == "Quraish cheese" || c4.Text == "Bean" || c4.Text == "Milk" || c4.Text == "Yogurt")
            {
                if (c4.Text == "Nuts")
                {
                    totalcal = nuts * int.Parse(n4.Text) + totalcal;
                }
                else if (c4.Text == "Oat")
                {
                    totalcal = oat * int.Parse(n4.Text) + totalcal;
                }
                else if (c4.Text == "Chia Seeds")
                {
                    totalcal = chia * int.Parse(n4.Text) + totalcal;
                }
                else if (c4.Text == "Eggs")
                {
                    if (c4.Text == "Eggs" && omelette4.Checked == true)
                    {
                        totalcal = omletteegg * int.Parse(n4.Text) + totalcal;
                    }
                    else if (c4.Text == "Eggs" && boiled4.Checked == true)
                    {
                        totalcal = boiledegg * int.Parse(n4.Text) + totalcal;
                    }

                }
                else if (c4.Text == "Bananas")
                {
                    totalcal = banana * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Coffee")
                {
                    totalcal = coffee * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Red Tea")
                {
                    totalcal = red_tea * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Green Tea")
                {
                    totalcal = green_tea * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Quraish cheese")
                {
                    totalcal = cheese * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Apple")
                {
                    totalcal = apple * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Bean")
                {
                    totalcal = cbean * int.Parse(n4.Text) + totalcal;

                }
                else if (c4.Text == "Milk")
                {
                    if (skimmed4.Checked == true)
                    {
                        totalcal = skimmed_milk * int.Parse(n4.Text) + totalcal;
                    }
                    else if (whole4.Checked == true)
                    {
                        totalcal = whole_milk * int.Parse(n4.Text) + totalcal;
                    }
                    else if (low4.Checked == true)
                    {
                        totalcal = low_milk * int.Parse(n4.Text) + totalcal;
                    }
                }
                else if (c4.Text == "Yogurt")
                {
                    if (lite4.Checked == true)
                    {
                        totalcal = liteyogurt * int.Parse(n4.Text) + totalcal;
                    }
                    else if (full4.Checked == true)
                    {
                        totalcal = fullfatyogurt * int.Parse(n4.Text) + totalcal;
                    }
                }

            }
            taken.Text = totalcal.ToString();

            //c5
            if (c5.Text == "Nuts" || c5.Text == "Oat" || c5.Text == "Chia Seeds" || c5.Text == "Eggs" || c5.Text == "Bananas" || c5.Text == "Coffee" || c5.Text == "Red Tea" || c5.Text == "Green Tea" || c5.Text == "Apple" || c5.Text == "Quraish cheese" || c5.Text == "Bean" || c5.Text == "Milk" || c5.Text == "Yogurt")
            {
                if (c5.Text == "Nuts")
                {
                    totalcal = nuts * int.Parse(n5.Text) + totalcal;
                }
                else if (c5.Text == "Oat")
                {
                    totalcal = oat * int.Parse(n5.Text) + totalcal;
                }
                else if (c5.Text == "Chia Seeds")
                {
                    totalcal = chia * int.Parse(n5.Text) + totalcal;
                }
                else if (c5.Text == "Eggs")
                {
                    if (c5.Text == "Eggs" && omelette5.Checked == true)
                    {
                        totalcal = omletteegg * int.Parse(n5.Text) + totalcal;
                    }
                    else if (c5.Text == "Eggs" && boiled5.Checked == true)
                    {
                        totalcal = boiledegg * int.Parse(n5.Text) + totalcal;
                    }

                }
                else if (c5.Text == "Bananas")
                {
                    totalcal = banana * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Coffee")
                {
                    totalcal = coffee * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Red Tea")
                {
                    totalcal = red_tea * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Green Tea")
                {
                    totalcal = green_tea * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Quraish cheese")
                {
                    totalcal = cheese * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Apple")
                {
                    totalcal = apple * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Bean")
                {
                    totalcal = cbean * int.Parse(n5.Text) + totalcal;

                }
                else if (c5.Text == "Milk")
                {
                    if (skimmed5.Checked == true)
                    {
                        totalcal = skimmed_milk * int.Parse(n5.Text) + totalcal;
                    }
                    else if (whole5.Checked == true)
                    {
                        totalcal = whole_milk * int.Parse(n5.Text) + totalcal;
                    }
                    else if (low5.Checked == true)
                    {
                        totalcal = low_milk * int.Parse(n5.Text) + totalcal;
                    }
                }
                else if (c5.Text == "Yogurt")
                {
                    if (lite5.Checked == true)
                    {
                        totalcal = liteyogurt * int.Parse(n5.Text) + totalcal;
                    }
                    else if (full5.Checked == true)
                    {
                        totalcal = fullfatyogurt * int.Parse(n5.Text) + totalcal;
                    }
                }

            }
            taken.Text = totalcal.ToString();
            if (total.Text == "")
            {
                MessageBox.Show("Calculate your calories first");
            }
            else
            {
                remain.Text = (double.Parse(total.Text) - double.Parse(taken.Text)).ToString();

            }
        }

        private void remain_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void T6_Click(object sender, EventArgs e)
        {

        }

        private void T1_Click(object sender, EventArgs e)
        {

        }
    }
}
