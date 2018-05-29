using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtır_Click(object sender, EventArgs e)
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

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (prgBarSaniye.Value > prgBarSaniye.Minimum)
                prgBarSaniye.Value--;
            else
            {
                prgBarSaniye.Value = prgBarSaniye.Maximum;
                if (prgBarDakika.Value > prgBarDakika.Minimum)
                    prgBarDakika.Value--;
                else
                {
                    prgBarDakika.Value = prgBarDakika.Maximum;
                    if (prgBarSaat.Value > prgBarSaat.Minimum)
                        prgBarSaat.Value--;
                    else
                        prgBarSaat.Value = prgBarSaat.Maximum;
                    lblSaat.Text = prgBarSaat.Value.ToString();
                }
                lblDakika.Text = prgBarDakika.Value.ToString();
            }
            lblSaniye.Text = prgBarSaniye.Value.ToString();
        }
    }
}
