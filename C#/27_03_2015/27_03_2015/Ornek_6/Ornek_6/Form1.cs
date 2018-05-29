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
        public Form1()
        {
            InitializeComponent();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tetikleyen = (ListBox)sender;
            lstAd.SelectedIndex = lstSoyad.SelectedIndex = lstYas.SelectedIndex = tetikleyen.SelectedIndex;

            int index = tetikleyen.SelectedIndex;
            if(index != -1)
            {
                txtAd.Text = lstAd.SelectedItem.ToString();
                txtSoyad.Text = lstSoyad.SelectedItem.ToString();
                txtYas.Text = lstYas.SelectedItem.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstAd.Items.Add(txtAd.Text);
            lstSoyad.Items.Add(txtSoyad.Text);
            lstYas.Items.Add(txtYas.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            int index = lstAd.SelectedIndex;
            if (index != -1)
            {
                lstAd.Items.RemoveAt(index);
                lstSoyad.Items.RemoveAt(index);
                lstYas.Items.RemoveAt(index);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = lstAd.SelectedIndex;
            if (index != -1)
            {
                lstAd.Items.Insert(index, txtAd.Text);
                lstSoyad.Items.Insert(index, txtSoyad.Text);
                lstYas.Items.Insert(index, txtYas.Text);
                /*
                lstAd.Items.RemoveAt(index+1);
                lstSoyad.Items.RemoveAt(index+1);
                lstYas.Items.RemoveAt(index+1);
                */
                //sil buttonuna tıklama...
                btnSil.PerformClick();

                lstAd.SelectedIndex = index;
            }
        }
    }
}
