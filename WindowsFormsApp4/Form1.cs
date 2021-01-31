using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HOŞ GELDİNİZ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }
            if (sayac == 0)
            {
                label1.Text = "Sayı Asaldır.";
            }
            else
            {
                label1.Text = "Sayı Asal Değil";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi, faktoriyel = 1, karekok;

            sayi = Convert.ToDouble(textBox2.Text); 
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i; 
            }

            label2.Text = faktoriyel.ToString(); 

            karekok = Math.Sqrt(sayi); 
            label2.Text = karekok.ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi, sonuc = 1;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            label2.Text = sonuc.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }   }

