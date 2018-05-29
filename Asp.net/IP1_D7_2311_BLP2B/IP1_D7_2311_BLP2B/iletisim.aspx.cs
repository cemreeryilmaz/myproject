using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CheckBoxOnay.Checked)
            ButtonGonder.Enabled = true;
        else
            ButtonGonder.Enabled = false;
        //CheckBoxOnay.AutoPostBack = true;
    }
    protected void CheckBoxOnay_CheckedChanged(object sender, EventArgs e)
    {
        if(CheckBoxOnay.Checked)
        {
            ButtonGonder.Enabled = true;
        }
        else
        {
            ButtonGonder.Enabled = false;
        }
    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        LabelMsj.Text = "Adınız Soyadınız: " + TextBoxAdSoyad.Text +
            "<br>E-posta adresiniz: " + TextBoxEposta.Text +
            "<br>Yaşadığınız şehir: " + DropDownListSehirler.SelectedItem.Text+
            "<br>Mesajınız: " + TextBoxMesaj.Text;
    }
}