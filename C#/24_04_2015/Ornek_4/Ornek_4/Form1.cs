using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_4
{

    public partial class Form1 : Form
    {
        int saat = 0, dakika = 0, saniye = 0, salise = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasDur_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                btnBasDur.Text = "Başlat";
                btnSıfırla.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                btnBasDur.Text = "Durdur";
                btnSıfırla.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (salise < 99)
                salise++;
            else
            {
                salise = 0;
                if (saniye < 59)
                    saniye++;
                else
                {
                    saniye = 0;
                    if (dakika < 59)
                        dakika++;
                    else
                    {
                        dakika = 0;
                        saat++;
                    }
                }
            }

            lblKrono.Text = ((saat < 10) ? "0" + saat : saat.ToString()) + ":" +
                            ((dakika < 10) ? "0" + dakika : dakika.ToString()) + ":" +
                            ((saniye < 10) ? "0" + saniye : saniye.ToString()) + ":" +
                            ((salise < 10) ? "0" + salise : salise.ToString());
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            lblKrono.Text = "00:00:00:00";
            saat = dakika = saniye = salise = 0;
        }
    }
}
