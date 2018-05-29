<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama6.aspx.cs" Inherits="Uygulama6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script>
         function ogrenciGet() {
             var ogrenci = {
                 ad: "Ahmet",
                 soyad: "Akın",
                 no: "151030105",
                 bolum: "Bilgisayar",
                 yas: 17,
                 tamIsım: function () {
                     return this.ad + " " + this.soyad;
                 }
             };

             document.getElementById("content").innerHTML =
                 "Ad: " + ogrenci.ad + "<br>" +
                 "Soyad: " + ogrenci.soyad + "<br>" +
                 "No: " + ogrenci.no + "<br>" +
                 "Bölüm: " + ogrenci.bolum + "<br>" +
                 "Yaş: " + ogrenci.yas + "<br>" +
                 "Tam İsim: " + ogrenci.tamIsım();
         }
    </script>
</head>
<body>
    
    <div id="content">
      
    </div>
    <button id="buttonGet" onclick="ogrenciGet()" >BİLGİ GETİR</button>
   

    
</body>
</html>
