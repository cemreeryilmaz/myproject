using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSatir.Items.Add(txtMetin.Text);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstSatir.SelectedItem.ToString());

        }

        private void btnsatirsayisi_Click(object sender, EventArgs e)
        {
            lblsatirsayisi.Text = "Satır Sayısı = " + lstSatir.Items.Count.ToString();
        }

        private void btnseciliolanicikart_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Emin misiniz?", "Silme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (soru == DialogResult.Yes)
            {
                lstSatir.Items.RemoveAt(lstSatir.SelectedIndex);
                MessageBox.Show("Silindi..");
            }
            else if (soru == DialogResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi...");
            }

        }
    }
}
