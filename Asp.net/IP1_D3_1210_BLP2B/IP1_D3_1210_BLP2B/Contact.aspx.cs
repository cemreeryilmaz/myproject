using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ButtonGonder2.Enabled = false;
    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        if(CheckBoxOnay.Checked)
        {           
            LabelSonuc.Text = "<b>Adınız Soyadınız:</b> " + TextBoxAdSoyad.Text + "<br><b>Eposta Adresiniz:</b> " + TextBoxEposta.Text +
                "<br><b>Yorumunuz:</b> " + TextBoxYorum.Text;
            
        }
        else
        {
            LabelSonuc.Text = "Koşulları okuyup onayladığınızı kabul etmelisiniz!";
        }
    }
    protected void CheckBoxOnay2_CheckedChanged(object sender, EventArgs e)
    {
        if(CheckBoxOnay2.Checked)
        {
            ButtonGonder2.Enabled = true;
        }
        else
        {
            ButtonGonder2.Enabled= false;
        }
    }
    protected void ButtonGonder2_Click(object sender, EventArgs e)
    {
        if (CheckBoxOnay2.Checked)
        {
            LabelSonuc.Text = "<b>Adınız Soyadınız:</b> " + TextBoxAdSoyad.Text + "<br><b>Eposta Adresiniz:</b> " + TextBoxEposta.Text +
                "<br><b>Yorumunuz:</b> " + TextBoxYorum.Text;

        }
         
    }
}