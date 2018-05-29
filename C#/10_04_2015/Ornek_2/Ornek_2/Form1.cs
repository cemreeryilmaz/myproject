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
        List<Kisi> Kisiler = new List<Kisi>();

        private void Listele()
        {
            lstAdSoyad.Items.Clear();
            /*
            for (int i = 0; i < Kisiler.Count; i++)
            {
                Kisi kisi = Kisiler[i];
            }*/
            foreach(Kisi kisi in Kisiler)
            {
                lstAdSoyad.Items.Add(kisi.getAdSoyad());
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Cinsiyetler cins =(rdErkek.Checked)?Cinsiyetler.Erkek : Cinsiyetler.Kadın;
            MedeniHaller hal = (rdEvli.Checked) ? MedeniHaller.Evli : MedeniHaller.Bekar;
            Takımlar takım = (rdFenerbahce.Checked) ? Takımlar.Fenerbahçe : (rdGalatasaray.Checked) ? Takımlar.Galatasaray : (rdBesiktas.Checked) ? Takımlar.Beşiktaş : (rdTrabzon.Checked) ? Takımlar.TranzonSpor : Takımlar.Diğer;
            
            Kisi kisi = new Kisi(txtAd.Text, txtSoyad.Text, cins, hal, takım);
            Kisiler.Add(kisi);
            Listele();
        }

        private void lstAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstAdSoyad.SelectedIndex != -1)
            {
                Kisi kisi = Kisiler[lstAdSoyad.SelectedIndex];

                txtAd.Text = kisi.Ad;
                txtSoyad.Text = kisi.Soyad;

                if (kisi.Cinsiyet == Cinsiyetler.Erkek)
                    rdErkek.Checked = true;
                else
                    rdKadın.Checked = true;

                if (kisi.MedeniHal == MedeniHaller.Bekar)
                    rdBekar.Checked = true;
                else
                    rdEvli.Checked = true;

                switch (kisi.Takım)
                {
                    case Takımlar.Fenerbahçe:
                        rdFenerbahce.Checked = true;
                        break;
                    case Takımlar.Galatasaray:
                        rdGalatasaray.Checked = true;
                        break;
                    case Takımlar.TranzonSpor:
                        rdTrabzon.Checked = true;
                        break;
                    case Takımlar.Beşiktaş:
                        rdBesiktas.Checked = true;
                        break;
                    case Takımlar.Diğer:
                        rdDiger.Checked = true;
                        break;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lstAdSoyad.SelectedIndex != -1)
            {
                Kisiler.RemoveAt(lstAdSoyad.SelectedIndex);
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstAdSoyad.SelectedIndex != -1)
            {
                Cinsiyetler cins = (rdErkek.Checked) ? Cinsiyetler.Erkek : Cinsiyetler.Kadın;
                MedeniHaller hal = (rdEvli.Checked) ? MedeniHaller.Evli : MedeniHaller.Bekar;
                Takımlar takım = (rdFenerbahce.Checked) ? Takımlar.Fenerbahçe : (rdGalatasaray.Checked) ? Takımlar.Galatasaray : (rdBesiktas.Checked) ? Takımlar.Beşiktaş : (rdTrabzon.Checked) ? Takımlar.TranzonSpor : Takımlar.Diğer;

                //Kisi kisi = new Kisi(txtAd.Text, txtSoyad.Text, cins, hal, takım);
                //Kisiler[lstAdSoyad.SelectedIndex] = kisi;
                
                //veya...
                Kisiler[lstAdSoyad.SelectedIndex].Ad = txtAd.Text;
                Kisiler[lstAdSoyad.SelectedIndex].Soyad = txtSoyad.Text;
                Kisiler[lstAdSoyad.SelectedIndex].Cinsiyet = cins;
                Kisiler[lstAdSoyad.SelectedIndex].MedeniHal = hal;
                Kisiler[lstAdSoyad.SelectedIndex].Takım = takım;

                Listele();
            }
        }
    }
}
