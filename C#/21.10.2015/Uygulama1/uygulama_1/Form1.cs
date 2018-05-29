using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tekrar;
            tekrar = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < tekrar; i++)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t=0, sayi,sart;
            do
            {
                sayi = Convert.ToInt32(Interaction.InputBox("Sayi Giriniz"));
                t = t + sayi;
                
            } while (sayi !=0);
            MessageBox.Show("Girilen Sayıların Toplamı = " + t);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = 0, sayi;
            sayi = Convert.ToInt32(Interaction.InputBox("sayi giriniz", "sayi girişi"));
            while (sayi!=0)
            {
                t = t + sayi;
                sayi = Convert.ToInt32(Interaction.InputBox("sayi giriniz", "sayi girişi"));
            }
            MessageBox.Show("Girilen Sayıların Toplamı = " + t);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=9; i++)
            {
                for (int j = 0; j <=9; j++)
                {
                    for (int k = 0; k <=9; k++)
                    {
                        listBox1.Items.Add("i = "+ i.ToString() + " "+"j ="+ j.ToString() + " "+"k = "+ k.ToString());
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi;
                sayi = Convert.ToInt32(Interaction.InputBox("sayi giriniz", "sayi girişi"));

            }
            catch
            {
                MessageBox.Show("Lütfen Sayı Giriniz...!");
                
            }
        }

    }
}
