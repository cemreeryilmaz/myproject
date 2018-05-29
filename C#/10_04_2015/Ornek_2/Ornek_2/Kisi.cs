using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_2
{
    public enum Cinsiyetler
    {
        Erkek,
        Kadın
    }

    public enum MedeniHaller
    {
        Evli,
        Bekar
    }

    public enum Takımlar
    {
        Fenerbahçe,
        Galatasaray,
        TranzonSpor,
        Beşiktaş,
        Diğer
    }

    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }
        public MedeniHaller MedeniHal { get; set; }
        public Takımlar Takım { get; set; }

        public Kisi(string ad, string soyad, Cinsiyetler cins, MedeniHaller hal, Takımlar takım)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Cinsiyet = cins;
            this.MedeniHal = hal;
            this.Takım = takım;
        }

        public string getAdSoyad()
        {
            return this.Ad + " " + this.Soyad;
        }
    }
}
