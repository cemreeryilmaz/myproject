using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_CheckBoxList_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CheckBoxListMezeler.Items.Add(new ListItem("Haydari", "1"));
            CheckBoxListMezeler.Items.Add(new ListItem("Patlıcan Ezmesi", "2"));
            CheckBoxListMezeler.Items.Add(new ListItem("Humus", "3"));
            CheckBoxListMezeler.Items.Add(new ListItem("Acılı Ezme", "4"));
            CheckBoxListMezeler.Items.Add(new ListItem("Şakşuka", "5"));

            CheckBoxListMezeler.Items[3].Selected = true;
            CheckBoxListMezeler.Items[3].Enabled = false;

            //örnek-3
            CheckBoxListHobi.Items.Add(new ListItem("Müzik", "1"));
            CheckBoxListHobi.Items.Add(new ListItem("Spor", "2"));
            CheckBoxListHobi.Items.Add(new ListItem("Kitap Okumak", "3"));
            CheckBoxListHobi.Items.Add(new ListItem("Resim", "4"));
        }

    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        LabelProgram.Text = "";
        for (int i = 0; i < CheckBoxListProgramlama.Items.Count; i++)
        {
            if (CheckBoxListProgramlama.Items[i].Selected)
                LabelProgram.Text += CheckBoxListProgramlama.Items[i].Text + 
                    " Value: "+  CheckBoxListProgramlama.Items[i].Value + "<br>";
        }
    }
    protected void ButtonSiparis_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in CheckBoxListMezeler.Items)
        {
            if (item.Selected)
                LabelMezeler.Text += item.Text + "<br>";
        }
    }
    protected void CheckBoxListHobi_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelHobiler.Text = "";
        foreach(ListItem item in CheckBoxListHobi.Items)
        {
            if (item.Selected)
                LabelHobiler.Text += item.Text + "<br>";
        }
    }
}