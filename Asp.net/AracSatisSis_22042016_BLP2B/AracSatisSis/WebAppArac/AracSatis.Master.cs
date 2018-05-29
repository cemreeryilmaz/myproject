using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppArac
{
    public partial class AracSatis : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["kullaniciId"] != null )
            {
                LabelUserName.Text = "Hoşgeldin " + Session["ad"] +
                " " + Session["soyad"];
            }
            else if( Request.Cookies["kullanici"] != null)
            {
                LabelUserName.Text = "Hoşgeldin " + Request.Cookies["kullanici"]["ad"] +
                    " " + Request.Cookies["kullanici"]["soyad"];
            }
            else
            {
                LabelUserName.Text = "Henüz giriş yapmadınız.";
                LinkButtonLogout.Visible = false;
            }

        }

        protected void LinkButtonLogout_Click(object sender, EventArgs e)
        {
           if(Session["kullaniciId"] != null)
           {
               Session.RemoveAll();
               Session.Clear();
              
           }
           if(Request.Cookies["kullanici"] != null)
           {
               Response.Cookies["kullanici"].Expires = DateTime.Now.AddDays(-1);
              
           }
           Response.Redirect("UyeGirisi.aspx");
        }

       
    }
}