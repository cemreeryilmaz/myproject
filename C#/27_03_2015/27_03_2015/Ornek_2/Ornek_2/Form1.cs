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
        int index = 0;
        List<string> Kisiler = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCount.Text = "Liste Boş";//(index + 1) + "/" + Kisiler.Count;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kisiler.Add(txtAd.Text);

            lblCount.Text = (index + 1) + "/" + Kisiler.Count;
            txtAd.Text = Kisiler[index];
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if(index < Kisiler.Count - 1)
            {
                index++;
                lblCount.Text = (index+1) + "/" + Kisiler.Count;
                txtAd.Text = Kisiler[index];
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                index--;
                lblCount.Text = (index + 1) + "/" + Kisiler.Count;
                txtAd.Text = Kisiler[index];
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kisiler.RemoveAt(index);

            if (Kisiler.Count > 0)
            {
                if (index == Kisiler.Count)
                    index--;
                lblCount.Text = (index + 1) + "/" + Kisiler.Count;
                txtAd.Text = Kisiler[index];
            }
            else
            {
                txtAd.Text = "";
                lblCount.Text = "ListeBoş";
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(Kisiler.Count>0)
                Kisiler[index] = txtAd.Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Kisiler.Clear();
            lblCount.Text = "Liste Boş";
            index = 0;
            txtAd.Text = "";
        }
    }
}
