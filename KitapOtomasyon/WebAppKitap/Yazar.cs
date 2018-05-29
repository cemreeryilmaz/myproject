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
    public class Yazar
    {
        private int yazarId;

        public int YazarId
        {
            get { return yazarId; }
            set { yazarId = value; }
        }
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
        private char cinsiyet;

        public char Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        private DateTime dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set { dogumTarihi = value; }
        }
        private int ozgecmis;

        public int Ozgecmis
        {
            get { return ozgecmis; }
            set { ozgecmis = value; }
        }

        public string YazarEkle()
        {
            throw new System.NotImplementedException();
        }

        public string YazarSil()
        {
            throw new System.NotImplementedException();
        }

        public string YazarGüncelle()
        {
            throw new System.NotImplementedException();
        }

        public SqlDataAdapter YazarListele()
        {
            throw new System.NotImplementedException();
        }
    }
}
