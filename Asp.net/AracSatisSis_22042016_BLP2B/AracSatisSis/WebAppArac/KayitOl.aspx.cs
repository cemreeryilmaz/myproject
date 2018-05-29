using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BusinessArac;
using DataAccesArac;

namespace WebAppArac
{
    public partial class KayitOl : System.Web.UI.Page
    {
        SehirIslemleri sehirIslem = new SehirIslemleri();
        KullaniciIslemleri kullaniciIslem = new KullaniciIslemleri();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListIller.DataSource = sehirIslem.IlListele();
                DropDownListIller.DataTextField = "sehir";
                DropDownListIller.DataValueField = "id";
                DropDownListIller.DataBind();
            }
        }

        protected void DropDownListIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Il il = new Il(); //business
            il.Id = Convert.ToInt32(DropDownListIller.SelectedValue);

            //dataaccess
            DropDownListIlceler.DataSource = sehirIslem.IlceListeleByIlId(il);
            DropDownListIlceler.DataTextField = "ilce";
            DropDownListIlceler.DataValueField = "id";
            DropDownListIlceler.DataBind();

        }

        protected void ButtonKullaniciKayit_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = TextBoxAd.Text;
            kullanici.Soyad = TextBoxSoyad.Text;
            kullanici.Eposta = TextBoxEposta.Text;
            kullanici.Sifre = TextBoxSifre.Text;
            kullanici.CepTelefonu = TextBoxCepTelefonu.Text;
            kullanici.IlceId = Convert.ToInt32(DropDownListIlceler.SelectedValue);
            kullanici.KayitTarihi = DateTime.Now;
            kullanici.KullaniciOnayDurumu = true;

            LabelMsj.Text =  kullaniciIslem.KullaniciEkle(kullanici);
 

        }
    }
}