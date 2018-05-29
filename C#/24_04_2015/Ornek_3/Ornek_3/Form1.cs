using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasDur_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
            {
                timer1.Enabled = true; //timer çalıştır
                btnBasDur.Text = "Durdur";//btnBasDur'da Durdur Yaz
                btnSıfırla.Enabled = false;//btnSıfırla Pasif
            }
            else
            {
                timer1.Enabled = false;//timer durdur
                btnBasDur.Text = "Başlat";//btnBasDur'da Başlat Yaz
                btnSıfırla.Enabled = true;//btnSıfırla Aktif
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgBarSaniye.Value < prgBarSaniye.Maximum)
                prgBarSaniye.Value++;
            else
            {
                prgBarSaniye.Value = prgBarSaniye.Minimum;
                if (prgBarDakika.Value < prgBarDakika.Maximum)
                    prgBarDakika.Value++;
                else
                {
                    prgBarDakika.Value = 0;
                    if (prgBarSaat.Value < prgBarSaat.Maximum)
                        prgBarSaat.Value++;
                    else
                        prgBarSaat.Value = prgBarSaat.Minimum;
                    lblSaat.Text = prgBarSaat.Value.ToString();
                }
                lblDakika.Text = prgBarDakika.Value.ToString();
            }
            lblSaniye.Text = prgBarSaniye.Value.ToString();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            prgBarSaat.Value = prgBarSaat.Minimum;
            prgBarDakika.Value = prgBarDakika.Minimum;
            prgBarSaniye.Value = prgBarSaniye.Minimum;

            lblSaat.Text = prgBarSaat.Value.ToString();
            lblDakika.Text = prgBarDakika.Value.ToString();
            lblSaniye.Text = prgBarSaniye.Value.ToString();
        }
    }
}
