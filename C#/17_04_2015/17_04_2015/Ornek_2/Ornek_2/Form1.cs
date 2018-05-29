using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_1_Click(object sender, EventArgs e)
        {
            cbxSehir.Items.Add(txtSehir.Text);
        }

        private void btnEkle_2_Click(object sender, EventArgs e)
        {
            if(cbxSehir.SelectedIndex != -1)
            {
                //lstSehirler.Items.Add(cbxSehir.Text);
                lstSehirler.Items.Add(cbxSehir.SelectedItem);
            }
        }
    }
}
