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

namespace GoTo
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
            listBox1.Items.Clear();
            sayi = Convert.ToInt32(Interaction.InputBox("Sayı Giriniz = ","Sayı Girişi","Orn:1,2,3,4,5"));
            sayac = 0;
            a:
            sayac = sayac + 2;
            listBox1.Items.Add(sayac.ToString());
            if (sayac < sayi-1)
	        {
		        goto a;
	        }
        }
    }
}
