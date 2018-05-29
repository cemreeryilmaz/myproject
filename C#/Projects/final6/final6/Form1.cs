using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSehir.Items.Add(txtSehir.Text);
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {       
            int index = lstSehir.SelectedIndex;
            if(index > 0)
            {
                lstSehir.Items.Insert(index - 1, lstSehir.SelectedItem);
                lstSehir.Items.RemoveAt(lstSehir.SelectedIndex);
                lstSehir.SelectedIndex = index - 1;
            }
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int index = lstSehir.SelectedIndex;
            if (index != -1 && index < lstSehir.Items.Count - 1)
            {
                lstSehir.Items.Insert(index + 2, lstSehir.SelectedItem);
                lstSehir.Items.RemoveAt(lstSehir.SelectedIndex);
                lstSehir.SelectedIndex = index + 1;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstSehir.SelectedIndex;
            if (index != -1)
                lstSehir.Items.RemoveAt(index);
        }

        private void lstSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSehir.SelectedItem != null)
                txtSehir.Text = lstSehir.SelectedItem.ToString();
        }

    }
}
