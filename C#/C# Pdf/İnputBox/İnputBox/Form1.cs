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

namespace İnputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(Interaction.InputBox("Sayı Giriniz", "Sayı Girişi", "orn:1,2,-4,0 vb", 45, 45));
            MessageBox.Show("Girilen Sayı = " + sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = Interaction.InputBox("Metin Giriniz", "Metin Girişi", "orn:orcun,gorsel programlama vb");
            MessageBox.Show("Girilen Metin = " + metin);
        }
    }
}
