using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppArac.Admin
{
    public partial class Admin_AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullaniciId"] != null)
            {
                if (Session["yetkiId"].ToString() != "1")
                    Response.Redirect("~/UyeGirisi.aspx");
                else
                    LabelAdminUser.Text = "Hoşgeldin " +
                Session["ad"] + " " + Session["soyad"] +
                "<br>Yetki: " + Session["yetki"] +
                "<br>Giris Zamani: " + Session["girisZamani"].ToString();
            }
            else if (Request.Cookies["kullanici"] != null)
            {
                if (Request.Cookies["kullanici"]["yetkiId"].ToString() != "1")
                    Response.Redirect("~/UyeGirisi.aspx");
                else
                    LabelAdminUser.Text = "Hoşgeldin " +
                        Request.Cookies["kullanici"]["ad"] + " " + Request.Cookies["kullanici"]["soyad"] +
                "<br>Yetki: " + Request.Cookies["kullanici"]["yetki"] +
                "<br>Giris Zamani: " + Request.Cookies["kullanici"]["girisZamani"].ToString();

            }
            else
            {
                Response.Redirect("~/UyeGirisi.aspx");
            }
        }
    }
}