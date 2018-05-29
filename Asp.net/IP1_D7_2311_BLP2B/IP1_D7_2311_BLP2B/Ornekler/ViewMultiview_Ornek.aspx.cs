using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_ViewMultiview_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //MultiViewBolumler.ActiveViewIndex = -1;
    }
    protected void LinkButtonBLP_Click(object sender, EventArgs e)
    {
        MultiViewBolumler.ActiveViewIndex = 0;
    }
    protected void LinkButtonElektronik_Click(object sender, EventArgs e)
    {
        MultiViewBolumler.ActiveViewIndex = 1;
    }
    protected void LinkButtonElektrik_Click(object sender, EventArgs e)
    {
        MultiViewBolumler.ActiveViewIndex = 2;
    }
    protected void DropDownListBolumler_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiViewBolumler.ActiveViewIndex = DropDownListBolumler.SelectedIndex;
    }
}