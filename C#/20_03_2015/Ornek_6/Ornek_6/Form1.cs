using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_6
{
    public partial class Form1 : Form
    {
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtır_Click(object sender, EventArgs e)
        {
            if (sayac < 10){
                sayac++;
                if(sayac == 10)
                    btnArtır.Enabled = false;
            }

            if (sayac > 0)
                btnAzalt.Enabled = true;

            lblSayac.Text = "Sayac = " + sayac;
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (sayac > 0)
            {
                sayac--;
                if(sayac == 0)
                    btnAzalt.Enabled = false;
            }

            if (sayac < 10)
                btnArtır.Enabled = true;

            lblSayac.Text = "Sayac = " + sayac;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = "Sayac = " + sayac;

            if (sayac == 0)
                btnAzalt.Enabled = false;
            else if (sayac == 10)
                btnArtır.Enabled = false;
        }
    }
}
