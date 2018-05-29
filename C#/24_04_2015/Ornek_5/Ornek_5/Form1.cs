using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_5
{
    public partial class Form1 : Form
    {
        DateTime baslangıcZamanı;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasDur_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnBasDur.Text = "Başlat";
            }
            else
            {
                timer1.Enabled = true;
                baslangıcZamanı = DateTime.Now;
                btnBasDur.Text = "Durdur";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan gecenSure = DateTime.Now.Subtract(baslangıcZamanı);

            lblKrono.Text = ((gecenSure.Hours<10)? "0"+gecenSure.Hours : gecenSure.Hours.ToString()) + ":" +
                            ((gecenSure.Minutes<10)? "0"+gecenSure.Minutes : gecenSure.Minutes.ToString()) + ":" +
                            ((gecenSure.Seconds<10)? "0"+gecenSure.Seconds : gecenSure.Seconds.ToString()) + ":" +
                            ((gecenSure.Milliseconds/10 <10)? "0"+gecenSure.Milliseconds/10 : (gecenSure.Milliseconds/10).ToString());
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {

        }
    }
}
