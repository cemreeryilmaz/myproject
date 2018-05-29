using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tetikleyen = (ListBox)sender;
            lstAd.SelectedIndex = lstSoyad.SelectedIndex = lstBirimi.SelectedIndex = tetikleyen.SelectedIndex;

            if(tetikleyen.SelectedIndex != -1)
            {
                txtAd.Text = lstAd.SelectedItem.ToString();
                txtSoyad.Text = lstSoyad.SelectedItem.ToString();
                cbxBirimi.Text = lstBirimi.SelectedItem.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstAd.Items.Add(txtAd.Text);
            lstSoyad.Items.Add(txtSoyad.Text);
            lstBirimi.Items.Add(cbxBirimi.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstAd.SelectedIndex;
            if(index != -1)
            {
                lstAd.Items.RemoveAt(index);
                lstSoyad.Items.RemoveAt(index);
                lstBirimi.Items.RemoveAt(index);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = lstAd.SelectedIndex;
            if (index != -1)
            {
                lstAd.Items.Insert(index, txtAd.Text);
                lstSoyad.Items.Insert(index, txtSoyad.Text);
                lstBirimi.Items.Insert(index, cbxBirimi.Text);

                btnSil.PerformClick();

                lstAd.SelectedIndex = index;
            }
        }
    }
}
