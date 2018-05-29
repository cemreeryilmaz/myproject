using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace superloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = new int[6];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random sayi = new Random();
            int a = 0, sayac = 0;
            a = sayi.Next(1, 50);

            if (sayac == 0)
            {
                listBox1.Items.Add(a);
                sayilar[0] = a;
            }

            do
            {
            tekrar:
                a = sayi.Next(1, 50);

                for (int k = 0; k < listBox1.Items.Count; k++)
                {
                    if (listBox1.Items[k].ToString() == a.ToString())
                    {
                        goto tekrar;
                    }
                }
                listBox1.Items.Add(a);
                sayac++;
               sayilar[sayac] = a;
            } while (sayac != 5);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(sayilar);
            listBox2.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                listBox2.Items.Add(sayilar[i].ToString());
            }
        }
    }
}
