using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trycatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Sayı Girdiğiniz İçin Teşekkür Ederiz.\nGirilen Sayı:" + s);
            }
            catch
            {
                MessageBox.Show("Oldu Mu Şimdi,Sayı Gircektin Ama.Çok Kırıldım Sana");
            }
        }
    }
}
