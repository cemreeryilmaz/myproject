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

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                btnBaslat.Text = "Başlat";
                btnSıfırla.Enabled = true;
            }
            else
            {
                btnBaslat.Text = "Durdur";
                btnSıfırla.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            prgDakika.Value = prgDakika.Minimum;
            prgSaniye.Value = prgSaniye.Minimum;
            prgSalise.Value = prgSalise.Minimum;

            lblDakika.Text = lblSaniye.Text = lblSalise.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgSalise.Value < prgSalise.Maximum)
                prgSalise.Value++;
            else
            {
                prgSalise.Value = prgSalise.Minimum;
                if (prgSaniye.Value < prgSaniye.Maximum)
                    prgSaniye.Value++;
                else
                {
                    prgSaniye.Value = prgSaniye.Minimum;
                    if (prgDakika.Value < prgDakika.Maximum)
                        prgDakika.Value++;
                    else
                        prgDakika.Value = prgDakika.Minimum;

                    lblDakika.Text = prgDakika.Value.ToString();
                }
                lblSaniye.Text = prgSaniye.Value.ToString();
            }
            lblSalise.Text = prgSalise.Value.ToString();
        }
    }
}
