using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BusinessArac;
using DataAccesArac;
using System.Data.SqlClient;

namespace WebAppArac
{
    public partial class UyeGirisi : System.Web.UI.Page
    {
        KullaniciIslemleri kullaniciIslem = new KullaniciIslemleri();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciId"] != null)
            {
                PanelLogin.Visible = false;
            }
            else if(Request.Cookies["kullanici"] != null)
            {
                PanelLogin.Visible = false;
            }
        }

        protected void ButtonGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Eposta = TextBoxEposta.Text;
            kullanici.Sifre = TextBoxSifre.Text;

            SqlDataReader drKullanici = kullaniciIslem.KullaniciGiris(kullanici);

            if (drKullanici.HasRows)
            {
                if (drKullanici.Read())
                {
                    if (CheckBoxBeniHatirla.Checked)
                    {
                        Response.Cookies["kullanici"]["kullaniciId"] = drKullanici["kullaniciId"].ToString();
                        Response.Cookies["kullanici"]["ad"] = drKullanici["ad"].ToString();
                        Response.Cookies["kullanici"]["soyad"] = drKullanici["soyad"].ToString();
                        Response.Cookies["kullanici"]["eposta"] = TextBoxEposta.Text;
                        Response.Cookies["kullanici"]["girisZamani"] = DateTime.Now.ToString();
                        Response.Cookies["kullanici"]["yetkiId"] = drKullanici["yetkiId"].ToString();
                        Response.Cookies["kullanici"]["yetki"] = drKullanici["yetki"].ToString();

                        Response.Cookies["kullanici"].Expires = DateTime.Now.AddDays(1);


                    }

                    Session["kullaniciId"] = drKullanici["kullaniciId"].ToString();
                    Session["ad"] = drKullanici["ad"].ToString();
                    Session["soyad"] = drKullanici["soyad"].ToString();
                    Session["eposta"] = TextBoxEposta.Text.Trim();
                    Session["girisZamani"] = DateTime.Now.ToString();

                    Session["yetkiId"] = drKullanici["yetkiId"].ToString();
                    Session["yetki"] = drKullanici["yetki"].ToString();

                    if (Session["yetkiId"].ToString() == "1")
                        Response.Redirect("~/Admin/Admin_AnaSayfa.aspx");
                    else if (Session["yetkiId"].ToString() == "2")
                        Response.Redirect("~/User/UserProfile.aspx");
                }
            }
            else
            {
                LabelMsj.Text = "Hatalı Eposta veya Şifre!";
            }

        }
    }
}