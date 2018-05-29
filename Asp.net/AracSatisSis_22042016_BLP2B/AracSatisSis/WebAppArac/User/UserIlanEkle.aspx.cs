using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DataAccesArac;
using BusinessArac;
using System.Data;

namespace WebAppArac.User
{
    public partial class UserIlanEkle : System.Web.UI.Page
    {
        AracIslemleri aracIslem = new AracIslemleri();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownListAracTur.DataSource = aracIslem.AracTurListele();
                DropDownListAracTur.DataTextField = "aracTuru";
                DropDownListAracTur.DataValueField = "aracTurId";
                DropDownListAracTur.DataBind();

                DropDownListVitesTuru.DataSource = aracIslem.VitesTuruListele();
                DropDownListVitesTuru.DataTextField = "vitesTuru";
                DropDownListVitesTuru.DataValueField = "vitesTurId";
                DropDownListVitesTuru.DataBind();

                DropDownListYakitTuru.DataSource = aracIslem.YakitTuruListele();
                DropDownListYakitTuru.DataTextField = "yakitTuru";
                DropDownListYakitTuru.DataValueField = "yakitTurId";
                DropDownListYakitTuru.DataBind();

                DropDownListKasaTipi.DataSource = aracIslem.KasaTipiListele();
                DropDownListKasaTipi.DataTextField = "kasaTipi";
                DropDownListKasaTipi.DataValueField = "kasaTipiId";
                DropDownListKasaTipi.DataBind();

            }
        }

        protected void DropDownListAracTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aracTurId = int.Parse( DropDownListAracTur.SelectedValue);
            DropDownListMarka.DataSource  = aracIslem.AracMarkaListele(aracTurId);
            DropDownListMarka.DataTextField = "aracMarka";
            DropDownListMarka.DataValueField = "aracMarkaId";
            DropDownListMarka.DataBind();
        }

        protected void DropDownListMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aracMarkaId = int.Parse(DropDownListMarka.SelectedValue);
            DropDownListModel.DataSource = aracIslem.AracModelListele(aracMarkaId);
            DropDownListModel.DataTextField = "aracModel";
            DropDownListModel.DataValueField = "aracModelId";
            DropDownListModel.DataBind();

        }

        protected void ButtonIlanEkle_Click(object sender, EventArgs e)
        {
            IlanIslemleri ilanIslem = new IlanIslemleri();
            Ilan ilan = new Ilan();

            ilan.KullaniciId = int.Parse(Session["KullaniciId"].ToString());
            ilan.IlanBasligi = TextBoxIlanBaslik.Text;
            ilan.AracTuru = int.Parse(DropDownListAracTur.SelectedValue);
            ilan.AracModel = int.Parse(DropDownListModel.SelectedValue);
            ilan.ModelYili = int.Parse(TextBoxModelYili.Text);
            ilan.Kilometre = int.Parse(TextBoxKilometre.Text);
            ilan.VitesTuru = int.Parse(DropDownListVitesTuru.SelectedValue);
            ilan.KasaTipi = int.Parse(DropDownListKasaTipi.SelectedValue);
            ilan.YakitTuru = int.Parse(DropDownListYakitTuru.SelectedValue);
            ilan.Fiyat = Convert.ToDouble(TextBoxFiyat.Text);
            ilan.Aciklama = TextBoxAciklama.Text;
            ilan.IlanTarihi = DateTime.Now;

            if (ilanIslem.IlanEkle(ilan))
                LabelMsj.Text = "İlan Başarıyla Eklendi";
            else
                LabelMsj.Text = "İlan Ekleme Sırasında Hata Meydana Geldi";

        }
    }
}