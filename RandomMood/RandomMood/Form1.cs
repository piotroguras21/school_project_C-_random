using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomMood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, licznik=0;
            Random x = new Random();
            number  = x.Next(5)+1;
            string[] img = new string[5];
            for (int i = 0; i < 5; i++)
            {
                licznik = i + 1;
                img[i] = licznik.ToString() + ".png";
            }
            try
            {
                switch (number)
                {
                    case 1:
                        Image image1 = Image.FromFile(img[0]);
                        pictureBox1.Image = image1;
                        textBox1.Text = "Tired";
                        break;
                    case 2:
                        Image image2 = Image.FromFile(img[1]);
                        pictureBox1.Image = image2;
                        textBox1.Text = "Amusing";
                        break;
                    case 3:
                        Image image3 = Image.FromFile(img[2]);
                        pictureBox1.Image = image3;
                        textBox1.Text = "Fearful";
                        break;
                    case 4:
                        Image image4 = Image.FromFile(img[3]);
                        pictureBox1.Image = image4;
                        textBox1.Text = "Weak";
                        break;
                    case 5:
                        Image image5 = Image.FromFile(img[4]);
                        pictureBox1.Image = image5;
                        textBox1.Text = "Thoughful";
                        break;
                    default: MessageBox.Show("Error"); break;
                }
            }
            catch
            {
                MessageBox.Show("No graphic files");
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
