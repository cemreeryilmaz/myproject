<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama2.aspx.cs" Inherits="Script_Uygulama2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
    
    </div>
    <script>
        var ad = "Ahmet", soyad = "Çetin";
        var yas = 20;
        var durum = true;
        var sonuc, text="", sayi=null;


        document.getElementById("content").innerHTML =
            "Ad: " + ad + " Tip: "+ typeof ad +"<br>" +
            "Soyad: " +soyad + " Tip: " + typeof soyad + "<br>" +
            "Yaş: " + yas+ " Tip: "+ typeof yas + "<br>" +
            "Durum: " + durum + " Tip: "+ typeof durum + "<br>" +
            "Sonuc: " + sonuc + " Tip: "+ typeof sonuc + "<br>"+
            "Text: " + text + " Tip: "+ typeof text + "<br>"+
            "Sayı: " + sayi + " Tip: "+ typeof sayi + "<br>";

        
    </script>
    </form>
</body>
</html>
