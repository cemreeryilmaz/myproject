using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DöngüUygulamaları_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            string metin;
            sayi = Convert.ToInt32(textBox1.Text);
            metin = textBox2.Text;
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(metin);
            }
        }
    }
}
