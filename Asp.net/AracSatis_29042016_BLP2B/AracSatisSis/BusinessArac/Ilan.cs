using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessArac
{
    public class Ilan
    {
        private int ilanId;

        public int IlanId
        {
            get { return ilanId; }
            set { ilanId = value; }
        }
        private int kullaniciId;

        public int KullaniciId
        {
            get { return kullaniciId; }
            set { kullaniciId = value; }
        }
        private string ilanBasligi;

        public string IlanBasligi
        {
            get { return ilanBasligi; }
            set { ilanBasligi = value; }
        }
        private int aracTuru;

        public int AracTuru
        {
            get { return aracTuru; }
            set { aracTuru = value; }
        }
        private int aracModel;

        public int AracModel
        {
            get { return aracModel; }
            set { aracModel = value; }
        }
        private int modelYili;

        public int ModelYili
        {
            get { return modelYili; }
            set { modelYili = value; }
        }
        private int kilometre;

        public int Kilometre
        {
            get { return kilometre; }
            set { kilometre = value; }
        }
        private int vitesTuru;

        public int VitesTuru
        {
            get { return vitesTuru; }
            set { vitesTuru = value; }
        }
        private int kasaTipi;

        public int KasaTipi
        {
            get { return kasaTipi; }
            set { kasaTipi = value; }
        }
        private int yakitTuru;

        public int YakitTuru
        {
            get { return yakitTuru; }
            set { yakitTuru = value; }
        }
        private double fiyat;

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        private string aciklama;

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }
        private DateTime ilanTarihi;

        public DateTime IlanTarihi
        {
            get { return ilanTarihi; }
            set { ilanTarihi = value; }
        }
        private bool ilanOnayDurumu;
    }
}
