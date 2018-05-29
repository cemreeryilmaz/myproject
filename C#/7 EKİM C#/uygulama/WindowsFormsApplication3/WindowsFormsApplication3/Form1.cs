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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            int sayi, sayac;
            listBox1.Items.Clear();
            sayi = Convert.ToInt32(Interaction.InputBox("sayı girin", "sayi", "örnek123"));
            sayac = 0;
        a:
            sayac = sayi * sayi;
            listBox1.Items.Add(sayac.ToString());
            if (sayac <= sayi-1)
            {
                goto a;
            }
            else if (sayi==0)
            {
                listBox1.Items.Clear();
                MessageBox.Show("dur");
            }
         




        }
    }
}
