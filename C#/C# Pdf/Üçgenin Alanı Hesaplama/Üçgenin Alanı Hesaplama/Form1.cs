using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Üçgenin_Alanı_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int t, y, a;
            t = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            a = t * y / 2;
            MessageBox.Show("Üçgenin Alanı : " + a);
        }
    }
}
