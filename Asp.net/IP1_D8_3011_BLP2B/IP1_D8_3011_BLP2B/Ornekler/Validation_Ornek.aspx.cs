using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_Validation_Orne : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidatorSifreUzunluk_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (args.Value.Length >= 8)
            args.IsValid = true;
        else
            args.IsValid = false;
    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            Response.Write("Sayfa Geçerli");
        }
        else
        {
            Response.Write("Sayfa Geçersiz");
        }
    }
}