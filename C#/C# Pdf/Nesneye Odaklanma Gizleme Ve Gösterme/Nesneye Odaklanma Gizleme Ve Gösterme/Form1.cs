using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Odaklanma_Gizleme_Ve_Gösterme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnİsimOdakla_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void btnSoyadOdakla_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, " + textBox1.Text.ToString() + " " + textBox2.Text.ToString());
        }

        private void btnArmutAktif_Click(object sender, EventArgs e)
        {
            btnElma.Show();
            btnArmut.Hide();
        }

        private void btnElmaAktif_Click(object sender, EventArgs e)
        {
            btnArmut.Show();
            btnElma.Hide();
        }
    }
}
