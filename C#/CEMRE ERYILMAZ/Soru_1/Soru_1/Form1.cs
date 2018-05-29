using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbk_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(txtbk.Text);
            if (x>10)
            {
                MessageBox.Show("Girdiginiz Sayi 10'dan Büyüktür..");
            }
            else if(x<10)
            {
                MessageBox.Show("Girdiginiz Sayi 10'dan Küçüktür..");
            }
            else
	        {
                MessageBox.Show("Girdiğiniz Sayi 10 ");
	        }
        }
    }
}
