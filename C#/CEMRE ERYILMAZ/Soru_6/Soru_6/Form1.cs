using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, ortalama;
            vize = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            ortalama = vize * 40 / 100 + final * 60 / 100;

            if (ortalama >= 50 && ortalama <100)
            {
                MessageBox.Show("GEÇTİ");
            }
            else if (ortalama <50)
            {
                MessageBox.Show("KALDI");
            }
            else
            {
                MessageBox.Show("0-100 ARASINDA NOT GİRİNİZ...");
            }

        }
    }
}
