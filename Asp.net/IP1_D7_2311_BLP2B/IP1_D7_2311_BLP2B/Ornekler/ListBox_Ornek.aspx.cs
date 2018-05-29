using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_ListBox_Ornek : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        LabelSehir.Text = ListBoxSehirler.SelectedItem.Text
            + "<br> Value: " + ListBoxSehirler.SelectedValue;
    }
    protected void ButtonEkle_Click(object sender, EventArgs e)
    {
        string listText = TextBoxBolumAd.Text;
        string listValue = TextBoxBolumKod.Text;

        ListBoxBolumler.Items.Add(new ListItem(listText, listValue));

    }
    protected void ListBoxBolumler_SelectedIndexChanged(object sender, EventArgs e)
    {
        LabelBolumler.Text = "Bölüm Adı: " +
            ListBoxBolumler.SelectedItem.Text +
            "<br>Bölüm Kodu: " + ListBoxBolumler.SelectedValue;
    }
    protected void ButtonSil_Click(object sender, EventArgs e)
    {
        if(ListBoxBolumler.SelectedIndex != -1)
        {
            ListBoxBolumler.Items.RemoveAt(ListBoxBolumler.SelectedIndex); //belirtilen index değerine sahip Itemi siler.
            //ListBoxBolumler.Items.Remove("Bilgisayar"); //remove edilecek olanın string olarak bildirimi
            //ListBoxBolumler.Items.Remove(ListBoxBolumler.SelectedItem);//remove edilecek olan item direk bildirilir

            //ListBoxBolumler.Items.Clear();//tüm itemları temizler
            
            //ListBoxBolumler.Items.FindByText("Bilgisayar"); //texti bilgisayar olan itemı bulur
            
            //ListBoxBolumler.Items.FindByValue("1030");//value bilgisi 1030 olan itemı bul

            //belirtilen index değerine ekleme işlemi yapar
            //önceki index değerlerinin dolu olması şartı ile
            //aşağıdaki kod 2 indexine aşçılık itemını ekler
            //ListBoxBolumler.Items.Insert(2, "Aşçılık");
            //ListBoxBolumler.Items.Insert(2, new ListItem("Aşçılık", "1040"));
        }
    }
}