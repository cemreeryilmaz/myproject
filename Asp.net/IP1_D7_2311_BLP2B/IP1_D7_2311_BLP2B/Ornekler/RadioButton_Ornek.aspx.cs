using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_RadioButton_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        if(RadioButtonErkek.Checked)
        {
            LabelCinsiyet.Text = "Cinsiyetiniz: " + RadioButtonErkek.Text;
        }
        else if(RadioButtonKadin.Checked)
        {
            LabelCinsiyet.Text = "Cinsiyetiniz: " + RadioButtonKadin.Text;
        }
    }
    protected void RadioButtonGs_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButtonGs.Checked)
            LabelTakimlar.Text = "Takımınız: Galatasaray";
    }
    protected void RadioButtonFb_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButtonFb.Checked)
            LabelTakimlar.Text = "Takımınız: Fenerbahçe";
    }
}