using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if(!IsPostBack)
        if (Page.IsPostBack == false) 
        {
            DropDownListSehirler.Items.Add("İstanbul");
            DropDownListSehirler.Items.Add("Ankara");
            DropDownListSehirler.Items.Add("Van");
        }
    }
    protected void ButtonSec_Click(object sender, EventArgs e)
    {
        LabelSehir.Text =  DropDownListSehirler.SelectedItem.Text;
    }
}