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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sayac;
            lstgoster.Items.Clear();
            sayi = Convert.ToInt32(Interaction.InputBox(" ","Sayi Giriniz","123456"));
            sayac = 0;
            a:
            sayac = sayac +1;
            lstgoster.Items.Add(sayac.ToString());
            if (sayac<sayi-1)
	        {
		          goto a;
	        }
        }

    }
}
