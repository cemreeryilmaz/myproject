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

namespace DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, t = 0;
            do
            {
                sayi = Convert.ToInt32(Interaction.InputBox("Sayı Giriniz : "));
                t = t + sayi;
            } while (sayi !=0);
            MessageBox.Show("Sıfır Girilene Kadar Ki Sayıların Toplamı = " + t);
        }
    }
}
