using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lst_selectecindexchanged(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;
            lstAd.SelectedIndex = lstBirim.SelectedIndex = lstSoyad.SelectedIndex = lst.SelectedIndex;

            if(lst.SelectedIndex != -1)
            {
                txtAd.Text = lstAd.SelectedItem.ToString();
                txtSoyad.Text = lstSoyad.SelectedItem.ToString();
                cbxBirim.Text = lstBirim.SelectedItem.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstAd.Items.Add(txtAd.Text);
            lstSoyad.Items.Add(txtSoyad.Text);
            lstBirim.Items.Add(cbxBirim.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstAd.SelectedIndex;
            if(index != -1)
            {
                lstAd.Items.RemoveAt(index);
                lstSoyad.Items.RemoveAt(index);
                lstBirim.Items.RemoveAt(index);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
             int index = lstAd.SelectedIndex;
             if (index != -1)
             {
                 lstAd.Items.Insert(index, txtAd.Text);
                 lstSoyad.Items.Insert(index, txtSoyad.Text);
                 lstBirim.Items.Insert(index, cbxBirim.Text);

                 btnSil.PerformClick();

                 lstAd.SelectedIndex = index;
             }
        }
    }
}
