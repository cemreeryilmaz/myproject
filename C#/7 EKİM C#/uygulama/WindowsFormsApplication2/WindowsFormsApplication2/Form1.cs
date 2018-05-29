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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (a>=0&&a<21)
            {
                MessageBox.Show("çök kötü");
            }
            else if (a>=21 && a<41)
            {
                MessageBox.Show("kötü");
            }
            else if (a >= 41 && a < 61)
            {
                MessageBox.Show("orta");
            }
            else if (a >= 61 && a < 81)
            {
                MessageBox.Show("iyi");
            }
            else if (a >= 81 && a < 101)
            {
                MessageBox.Show("çok iyi");
            }
            else
            {
                MessageBox.Show("0-100 arasında gir");
            }
        }

        private void btncıkar_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(numericUpDown1.Value.ToString());
            switch (i)
            {
                case 1:
                   MessageBox.Show("pazartesi");
                   break;
                case 2:
                   MessageBox.Show("salı");
                   break;
                case 3:
                   MessageBox.Show("çarşamba");
                   break;
                case 4:
                   MessageBox.Show("perşembe");
                   break;
                case 5:
                   MessageBox.Show("cuma");
                   break;
                case 6:
                   MessageBox.Show("cumartesi");
                   break;
                case 7:
                   MessageBox.Show("pazar");
                   break;

            
            }
        }

        private void btngir_Click(object sender, EventArgs e)
        {
            int sayi, sayac;
            listBox1.Items.Clear();
            sayi = Convert.ToInt32(Interaction.InputBox("sayı girin","sayi","örnek123"));
            sayac = 0;
            a:
            sayac = sayac + 2;
            listBox1.Items.Add(sayac.ToString());
            if (sayac<sayi-1)
            {
                goto a;
            }


        }
    }
}
