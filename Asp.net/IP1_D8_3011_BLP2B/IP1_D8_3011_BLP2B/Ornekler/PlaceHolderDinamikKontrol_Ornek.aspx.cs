using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_PlaceHolderDinamikKontrol_Ornek : System.Web.UI.Page
{
    TextBox txtAd = new TextBox();
    Label lbl = new Label();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label lblAd = new Label();
        lblAd.ID = "LabelAd";
        lblAd.Text = "Ad: ";
        
      
        txtAd.ID = "TextBoxAd";
        txtAd.Width = 200;
        txtAd.Height = 25;

        Button btn = new Button();
        btn.ID = "ButtonGonder";
        btn.Text = "GÖNDER";
        btn.Width = 80;
        btn.Height = 30;
        btn.Click += btn_Click;


        
        lbl.ID = "LabelSonuc";
        lbl.Text = "";

        PlaceHolder1.Controls.Add(lblAd);
        PlaceHolder1.Controls.Add(txtAd);
        PlaceHolder1.Controls.Add(btn);
        PlaceHolder1.Controls.Add(new LiteralControl("<br>"));
        PlaceHolder1.Controls.Add(lbl);

    }

    void btn_Click(object sender, EventArgs e)
    {
        lbl.Text = txtAd.Text;
    }

   
    protected void ButtonEkle_Click(object sender, EventArgs e)
    {
        //TextBox txtAd = new TextBox();
        //PlaceHolder1.Controls.Add(txtAd);
    }
}