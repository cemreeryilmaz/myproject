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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstAd.Items.Add(txtAd.Text);
            lstSoyad.Items.Add(txtSoyad.Text);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tetikleyen = (ListBox)sender;
            lstAd.SelectedIndex = lstSoyad.SelectedIndex = tetikleyen.SelectedIndex;
           
            if(tetikleyen.SelectedIndex != -1)
            {
                txtAd.Text = lstAd.SelectedItem.ToString();
                txtSoyad.Text = lstSoyad.SelectedItem.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstAd.SelectedIndex;
            if (index != -1)
            {
                lstAd.Items.RemoveAt(index);
                lstSoyad.Items.RemoveAt(index);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = lstAd.SelectedIndex;
            if (index != -1)
            {
                lstAd.Items.Insert(index, txtAd.Text);
                lstSoyad.Items.Insert(index, txtSoyad.Text);
                //eskisini sil
                //lstAd.Items.RemoveAt(index);
                //lstSoyad.Items.RemoveAt(index);
                btnSil.PerformClick();//veya sil butonuna tıkla...

                //yenisini seçili hale getir.
                lstAd.SelectedIndex = index;
            }
        }

    }
}
