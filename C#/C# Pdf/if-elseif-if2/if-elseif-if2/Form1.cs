using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_elseif_if2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int puan;
            puan = Convert.ToInt32(textBox1.Text);

            if (puan >= 0 && puan< 21)
            {
                MessageBox.Show("Çok Kötü");
            }
            else if (puan >=21 && puan < 41)
            {
                MessageBox.Show("Kötü");
            }
            else if (puan >=41 && puan < 61)
            {
                MessageBox.Show("Orta");   
            }
            else if (puan >=61 && puan <81)
            {
                MessageBox.Show("İyi");
            }
            else if (puan >=81 && puan < 101)
            {
                MessageBox.Show("Çok İyi");
            }
            else
            {
                MessageBox.Show("0 İle 100 Arasında Bir Puan Giriniz...!");
            }
        }
    }
}
