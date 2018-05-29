using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ornekler_DropDownList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        //if (Page.IsPostBack == false)
        if(!IsPostBack)
        {
            /*Örnek3*/
            //dropdownlist dinamik olarak item ekleme bu yöntemde value ile text aynıdır
            //DropDownListMezuniyet.Items.Add("Ön Lisans");
            //DropDownListMezuniyet.Items.Add("Lisans");
            //DropDownListMezuniyet.Items.Add("Yüksek Lisans");
            //DropDownListMezuniyet.Items.Add("Doktora");

            /*Örnek3*/
            //eğer ben value ve text değerlerini ayrı yönetmek istiyorsak
            DropDownListMezuniyet.Items.Add(new ListItem("Ön Lisans", "1"));
            DropDownListMezuniyet.Items.Add(new ListItem("Lisans", "2"));
            DropDownListMezuniyet.Items.Add(new ListItem("Yüksek Lisans", "3"));
            DropDownListMezuniyet.Items.Add(new ListItem("Doktora", "4"));

            #region Ornek5
                DropDownListGun.Items.Add(new ListItem("--GÜN--","-1"));
                DropDownListAy.Items.Add(new ListItem("--AY--","-1"));
                DropDownListYil.Items.Add(new ListItem("--YIL--","-1"));

                string[] aylar = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};

             
                for (int i = 1 ; i <= 31; i++)
                {
                    DropDownListGun.Items.Add(i.ToString());
                }

                for (int i = 0; i < aylar.Length; i++)
                {
                    DropDownListAy.Items.Add(new ListItem(aylar[i].ToString(),(i+1).ToString()));
                }
                for (int i = 0; i <= 100; i++)
                {
                    DropDownListYil.Items.Add((DateTime.Now.Year - i).ToString());
                }
            #endregion

            #region Ornek6
                DropDownListIller.Items.Add(new ListItem("İLLER", "-1"));
                DropDownListIller.Items.Add(new ListItem("İstanbul", "34"));
                DropDownListIller.Items.Add(new ListItem("Ankara", "06"));
            #endregion

        }
    }
    protected void ButtonGoster_Click(object sender, EventArgs e)
    {
        LabelPlaka.Text =DropDownListSehir.SelectedItem.Text +
            " Şehrinin Plakası : "+ DropDownListSehir.SelectedValue;
        //value bilgisini almanın diğer yolu
        //DropDownListSehir.SelectedItem.Value
    }
    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        //if(DropDownListBolumler.SelectedIndex == -1)
        if(DropDownListBolumler.SelectedValue == "-1")
        {
            LabelBolum.Text = "Lütfen Bölüm Seçiniz!";
        }
        else
        {
            LabelBolum.Text = "Bölümünüz: " + DropDownListBolumler.SelectedItem.Text +
                "<br>Bölüm Kodunuz: " + DropDownListBolumler.SelectedValue;
        }
    }
    protected void ButtonMezuniyet_Click(object sender, EventArgs e)
    {
        LabelMezuniyet.Text = "Mezuniyetiniz: " + DropDownListMezuniyet.SelectedItem.Text +
            "<br>Value Değeri: " + DropDownListMezuniyet.SelectedValue;

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "-1")
            LabelTakim.Text = "Lütfen tuttuğunuz takımı seçiniz";
        else
            LabelTakim.Text = "Takım : " + DropDownList1.SelectedItem.Text;
    }
    protected void DropDownListIller_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownListIlceler.Items.Clear(); 
        

        if(DropDownListIller.SelectedValue == "34")
        {
            DropDownListIlceler.Items.Add(new ListItem("Kadıköy", "3401"));
            DropDownListIlceler.Items.Add(new ListItem("Üsküdar", "3402"));

        }
        else if(DropDownListIller.SelectedValue == "06")
        {
            DropDownListIlceler.Items.Add(new ListItem("Çankaya", "0601"));
            DropDownListIlceler.Items.Add(new ListItem("Pursaklar", "0602"));

        }
        else if(DropDownListIller.SelectedValue == "-1")
        {
            DropDownListIlceler.Items.Add("İlçeler");
        }
    }
}