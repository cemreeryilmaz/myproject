using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final1
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
                btnBaslat.Text = "Baslat";
                timer1.Enabled = false;
                btnTemizle.Enabled = true;
            }
            else
            {
                btnBaslat.Text = "Durdur";
                btnTemizle.Enabled = false;
                timer1.Enabled = true;
            }             
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PBsalise.Value < PBsalise.Maximum)
                PBsalise.Value++;
            else
            {
                PBsalise.Value = PBsalise.Minimum;
                if (PBsaniye.Value < PBsaniye.Maximum)
                    PBsaniye.Value++;
                else
                {
                    PBsaniye.Value = PBsaniye.Minimum;
                    if (PBdakika.Value < PBdakika.Maximum)
                        PBdakika.Value++;
                    else
                        PBdakika.Value = PBdakika.Minimum;

                    lblDakika.Text = PBdakika.Value.ToString();
                }

                lblSaniye.Text = PBsaniye.Value.ToString();
            }
            lblSalise.Text = PBsalise.Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblDakika.Text = lblSaniye.Text = lblSalise.Text = "0";

            PBdakika.Value = PBdakika.Minimum;
            PBsaniye.Value = PBsaniye.Minimum;
            PBsalise.Value = PBsalise.Minimum;
        }
    }
}
