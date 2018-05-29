using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    public enum Cinsiyetler
    {
        ERKEK,
        KADIN
    }

    public enum MedeniHaller
    {
        BEKAR,
        EVLİ
    }

    public enum Takımlar
    {
        FB,
        GS,
        BŞK,
        DİĞER
    }

    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }
        public MedeniHaller MedeniHal { get; set; }
        public Takımlar Takım { get; set; }

        public Kisi()//Kisi kisi = new Kisi();
        {
            this.Ad = "";
            //diğerleride boşaltılabilir...
        }

        //Kisi kisi = new Kisi("Adı","Soyadı", Cinsiyetler.ERKEK, MedeniHaller.BEKAR, Takımlar.FB);
        public Kisi(string ad, string soyad, Cinsiyetler cinsiyet, MedeniHaller medenihal, Takımlar takım)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Cinsiyet = cinsiyet;
            this.MedeniHal = medenihal;
            this.Takım = takım;
        }

        public string getAdSoyad()
        {
            return this.Ad + " " + this.Soyad;
        }
    }
}
