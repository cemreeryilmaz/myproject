using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_ImageButton_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButtonOrnek_Click(object sender, ImageClickEventArgs e)
    {
        Response.Write("Image Button kontrolüne tıklandı...");
    }
}