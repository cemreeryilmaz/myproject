using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_Image_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonYukle_Click(object sender, EventArgs e)
    {
        ImageOrnek2.ImageUrl = "~/images/Penguins.jpg";
        ImageOrnek2.Width = 300;
        ImageOrnek2.Height = 250;
    }
}