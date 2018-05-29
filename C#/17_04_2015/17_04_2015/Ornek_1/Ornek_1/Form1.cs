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
        List<Kisi> Kisiler = new List<Kisi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            Cinsiyetler cinsiyet = (rdErkek.Checked) ? Cinsiyetler.ERKEK : Cinsiyetler.KADIN;
            MedeniHaller medenihal = (rdBekar.Checked) ? MedeniHaller.BEKAR : MedeniHaller.EVLİ;
            //Takımlar takım = (rdFener.Checked) ? Takımlar.FB : (rdGalata.Checked) ? Takımlar.GS : (rdBeşik.Checked) ? Takımlar.BŞK : Takımlar.DİĞER;
            Takımlar takım;
            if (rdFener.Checked)
                takım = Takımlar.FB;
            else if (rdGalata.Checked)
                takım = Takımlar.GS;
            else if (rdBeşik.Checked)
                takım = Takımlar.BŞK;
            else
                takım = Takımlar.DİĞER;

            Kisi kisi = new Kisi(ad, soyad, cinsiyet, medenihal, takım);
            Kisiler.Add(kisi);
            lstKisiler.Items.Add(kisi.getAdSoyad());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstKisiler.SelectedIndex != -1)
            {
                Kisi kisi = Kisiler[lstKisiler.SelectedIndex];
                txtAd.Text = kisi.Ad;
                txtSoyad.Text = kisi.Soyad;
               /*
                rdErkek.Checked = kisi.Cinsiyet == Cinsiyetler.ERKEK;
                rdKadın.Checked = kisi.Cinsiyet == Cinsiyetler.KADIN;*/

                /*
                if (kisi.Cinsiyet == Cinsiyetler.ERKEK)
                    rdErkek.Checked = true;
                else
                    rdKadın.Checked = true;*/

                switch (kisi.Cinsiyet)
                {
                    case Cinsiyetler.ERKEK:
                        rdErkek.Checked = true;
                        break;
                    case Cinsiyetler.KADIN:
                        rdKadın.Checked = true;
                        break;
                }

                rdBekar.Checked = (kisi.MedeniHal == MedeniHaller.BEKAR);
                rdEvli.Checked = (kisi.MedeniHal == MedeniHaller.EVLİ);

                rdFener.Checked = (kisi.Takım == Takımlar.FB);
                rdGalata.Checked = (kisi.Takım == Takımlar.GS);
                rdBeşik.Checked = (kisi.Takım == Takımlar.BŞK);
                rdDiger.Checked = (kisi.Takım == Takımlar.DİĞER);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lstKisiler.SelectedIndex != -1)
            {
                //Kisiler.RemoveAt(lstKisiler.SelectedIndex);
                Kisiler.Remove(Kisiler[lstKisiler.SelectedIndex]);

                //lstKisiler.Items.RemoveAt(lstKisiler.SelectedIndex);
                lstKisiler.Items.Remove(lstKisiler.SelectedItem); 
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex != -1)
            {
                /*
                Kisiler[lstKisiler.SelectedIndex].Ad = txtAd.Text;
                Kisiler[lstKisiler.SelectedIndex].Soyad = txtSoyad.Text;
                Kisiler[lstKisiler.SelectedIndex].Cinsiyet = (rdErkek.Checked) ? Cinsiyetler.ERKEK : Cinsiyetler.KADIN;
                Kisiler[lstKisiler.SelectedIndex].MedeniHal = (rdBekar.Checked) ? MedeniHaller.BEKAR : MedeniHaller.EVLİ;
                Kisiler[lstKisiler.SelectedIndex].Takım = (rdFener.Checked) ? Takımlar.FB : (rdGalata.Checked) ? Takımlar.GS : (rdBeşik.Checked) ? Takımlar.BŞK : Takımlar.DİĞER;

                lstKisiler.Items.Insert(lstKisiler.SelectedIndex, Kisiler[lstKisiler.SelectedIndex].getAdSoyad());
                lstKisiler.Items.RemoveAt(lstKisiler.SelectedIndex);*/
                
                Kisi kisi = new Kisi(txtAd.Text, 
                                     txtSoyad.Text, 
                                     (rdErkek.Checked) ? Cinsiyetler.ERKEK : Cinsiyetler.KADIN, 
                                     (rdBekar.Checked) ? MedeniHaller.BEKAR : MedeniHaller.EVLİ, 
                                     (rdFener.Checked) ? Takımlar.FB : (rdGalata.Checked) ? Takımlar.GS : (rdBeşik.Checked) ? Takımlar.BŞK : Takımlar.DİĞER);

                Kisiler[lstKisiler.SelectedIndex] = kisi;

                lstKisiler.Items.Insert(lstKisiler.SelectedIndex, kisi.getAdSoyad());
                lstKisiler.Items.RemoveAt(lstKisiler.SelectedIndex);
               

            }
        }
    }
}
