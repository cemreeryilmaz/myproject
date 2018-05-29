using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessArac
{
    public class Kullanici
    {
        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        private string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private string eposta;

        public string Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }
        private string sifre;

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        private string cepTelefonu;

        public string CepTelefonu
        {
            get { return cepTelefonu; }
            set { cepTelefonu = value; }
        }
        private int ilceId;

        public int IlceId
        {
            get { return ilceId; }
            set { ilceId = value; }
        }
        private DateTime kayitTarihi;

        public DateTime KayitTarihi
        {
            get { return kayitTarihi; }
            set { kayitTarihi = value; }
        }
        private bool kullaniciOnayDurumu;

        public bool KullaniciOnayDurumu
        {
            get { return kullaniciOnayDurumu; }
            set { kullaniciOnayDurumu = value; }
        }

        private int kullaniciId;

        public int KullaniciId
        {
            get { return kullaniciId; }
            set { kullaniciId = value; }
        }
    }
}
