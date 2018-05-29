using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public partial class Form1 : Form
    {
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sayac_Buttons_Click(object sender, EventArgs e)
        {
            Button tıklanan = (Button)sender;
            if (tıklanan.Name == btnArtır.Name)
                sayac++;
            else if (tıklanan.Name == btnAzalt.Name)
                sayac--;

            label1.Text = "Sayac = " + sayac;
        }

    }
}
