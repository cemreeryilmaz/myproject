using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string durum;
            int yıl = 0;
            if (radioButton1.Checked==true)
            {
                durum = "Yapıldı";
            }
            else if (radioButton2.Checked==true)
            {
                durum = "Yapmadı";
            }
            else 
            {
                durum = "Tecilli";
                yıl = Convert.ToInt16(textBox1.Text);
            }
            if (yıl == 0)
            {
                MessageBox.Show("Askerlik Durumu: "+durum);
            }
            else
            {
                MessageBox.Show("Askerlik Durumu: "+durum + "\nTecil Bitim Yılı: "+yıl.ToString()); 
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked==true)
            {
                textBox1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
