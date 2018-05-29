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
    public class YayinEvi
    {
        private int yayinEviId;

        public int YayinEviId
        {
            get { return yayinEviId; }
            set { yayinEviId = value; }
        }
        private string yayinEviAd;

        public string YayinEviAd
        {
            get { return yayinEviAd; }
            set { yayinEviAd = value; }
        }
        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        private string adres;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public string YayinEviEkle()
        {
            throw new System.NotImplementedException();
        }

        public string YayiEviSil()
        {
            throw new System.NotImplementedException();
        }

        public string YayinEviGüncelle()
        {
            throw new System.NotImplementedException();
        }

        public SqlDataReader YayinEviListele()
        {
            throw new System.NotImplementedException();
        }
    }
}
