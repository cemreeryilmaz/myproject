using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_RadioButtonList_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        LabelCinsiyet.Text = RadioButtonListCinsiyet.SelectedItem.Text
            + "<br>Value: " + RadioButtonListCinsiyet.SelectedValue ;
    }
    protected void RadioButtonListTakimlar_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelTakim.Text = RadioButtonListTakimlar.SelectedItem.Text +
            "<br>Value: " + RadioButtonListTakimlar.SelectedValue;
    }
}