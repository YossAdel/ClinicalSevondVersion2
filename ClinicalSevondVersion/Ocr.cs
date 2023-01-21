using Patagames.Ocr;
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
    public partial class Ocr : UserControl
    {
        public Ocr()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YOUSSEF-MOHAMED\SQLEXPRESS;Initial Catalog=clinical;Integrated Security=True");

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            String imagelocation = "";
            try
            {
                OpenFileDialog img = new OpenFileDialog();
                img.Filter= "jpg files (*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (img.ShowDialog() == System.Windows.Forms .DialogResult.OK)
                {
             
                    imagelocation=img.FileName;
                    guna2PictureBox1.ImageLocation= imagelocation;

    
                }
                MessageBox.Show("Uploaded");
            }
            catch {
                MessageBox.Show("Choose Image");
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var obj = OcrApi.Create())
            {
                if (guna2PictureBox1.Image == null)
                {
                    MessageBox.Show("Choose Image");
                }
                else
                {
                    obj.Init(Patagames.Ocr.Enums.Languages.English);
                    String plainText = obj.GetTextFromImage(guna2PictureBox1.ImageLocation);
                    textBox1.Text = plainText;
                    conn.Open();
                }
                
                try
                {
                   
                    if (textBox1.Text != "")
                    {
                        SqlCommand cmd = new SqlCommand("insert into Ocr values(@Ocr)", conn);
                        cmd.Parameters.AddWithValue("@Ocr", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Added successfully");
                        
                    }
                }
                catch
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Empty Text Box");
                    }
                   

                }
                


            }
        }
    }
}
