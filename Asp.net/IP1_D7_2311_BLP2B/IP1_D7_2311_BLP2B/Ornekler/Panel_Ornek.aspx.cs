using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_Panel_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PanelIcerik.Visible = false;
        PanelAskerlik.Visible = false;

        #region Ornek3
        PanelUser.Visible = false;

        #endregion
    }
    protected void ButtonGoster_Click(object sender, EventArgs e)
    {
        PanelIcerik.Visible = true;
    }
    protected void ButtonGizle_Click(object sender, EventArgs e)
    {
        PanelIcerik.Visible = false;
    }
    protected void RadioButtonListCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
    {
       
            if (RadioButtonListCinsiyet.SelectedValue == "E")
                PanelAskerlik.Visible = true;
            else if (RadioButtonListCinsiyet.SelectedValue == "K")
                PanelAskerlik.Visible = false;
      
    }
    protected void ButtonGiris_Click(object sender, EventArgs e)
    {
        if (TextBoxEposta.Text == "admin@mail.com" && TextBoxSifre.Text == "admin")
        {
            PanelLogin.Visible = false;
            PanelUser.Visible = true;
            LabelUsername.Text = "Hoşgeldin admin";
            LabelLoginTime.Text = "Giriş zamanı:  " + DateTime.Now.ToString();
        }
        else
        {
            LabelMsj.Text = "Hatalı eposta veya şifre";
                
        }

    }
    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        LabelLoginTime.Text = "";
        LabelUsername.Text = "";
        LabelMsj.Text = "";

        PanelUser.Visible = false;
        PanelLogin.Visible = true;
    }
}