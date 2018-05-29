using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace WebAppKitap
{
    public class Kitap
    {
        private int isbn;

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        private string kitapAd;

        public string KitapAd
        {
            get { return kitapAd; }
            set { kitapAd = value; }
        }
        private string yazar;

        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }
        private DateTime basimTarihi;

        public DateTime BasimTarihi
        {
            get { return basimTarihi; }
            set { basimTarihi = value; }
        }
        private string yayinEvi;

        public string YayinEvi
        {
            get { return yayinEvi; }
            set { yayinEvi = value; }
        }
        private double fiyat;

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        private int sayfaSayisi;

        public int SayfaSayisi
        {
            get { return sayfaSayisi; }
            set { sayfaSayisi = value; }
        }
        private string kategori;

        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }
        private string ozet;

        public string Ozet
        {
            get { return ozet; }
            set { ozet = value; }
        }

        public string KitapEkle()
        {
            throw new System.NotImplementedException();
        }

        public string KitapSil()
        {
            throw new System.NotImplementedException();
        }

        public string KitapGuncelle()
        {
            throw new System.NotImplementedException();
        }

        public SqlDataReader KitapListele()
        {
            throw new System.NotImplementedException();
        }
    }
}
