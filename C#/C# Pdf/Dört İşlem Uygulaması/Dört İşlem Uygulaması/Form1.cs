using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dört_İşlem_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 + sayi2;

            //label4.Text = sonuc.ToString();

            label4.Text = "Sonuç: " + sayi1.ToString() + " + " +sayi2.ToString() + " = " + sonuc.ToString();


        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 - sayi2;

            //label4.Text = sonuc.ToString();

            label4.Text = "Sonuç: " + sayi1.ToString() + " - " + sayi2.ToString() + " = " + sonuc.ToString();

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 * sayi2;

            //label4.Text = sonuc.ToString();

            label4.Text = "Sonuç: " + sayi1.ToString() + " * " + sayi2.ToString() + " = " + sonuc.ToString();

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;

            //label4.Text = sonuc.ToString();

            label4.Text = "Sonuç: " + sayi1.ToString() + " / " + sayi2.ToString() + " = " + sonuc.ToString();

        }
    }
}
