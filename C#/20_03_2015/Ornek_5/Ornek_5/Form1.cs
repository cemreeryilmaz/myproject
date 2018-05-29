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
        int sayac = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtır_Click(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text = "Sayac = " + sayac;
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = "Sayac = " + sayac;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = "Sayac = " + sayac;
        }
    }
}
