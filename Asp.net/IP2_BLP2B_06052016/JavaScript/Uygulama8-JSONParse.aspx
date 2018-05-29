<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama8-JSONParse.aspx.cs" Inherits="Uygulama_8_JSONParse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        var OgrenciBilgi =  '{ "ogrenciJSON" :  [{'+
            '"no": "151030106", "ad": "Emre", "soyad": "Çetin", "bolum": "Bilgisayar" },'+
            '{"no": "151030107","ad": "Filiz","soyad": "Akın", "bolum": "Bilgisayar"'+
        '}] }';

        var veri = JSON.parse(OgrenciBilgi);

        function ogrenciGet() {
            document.getElementById("content").innerHTML =
               veri.ogrenciJSON[0].ad + "<br>" +
               veri.ogrenciJSON[0].soyad + "<br>" +
               veri.ogrenciJSON[0].no + "<br>" +
               veri.ogrenciJSON[0].bolum;
        }
    </script>
</head>
<body>
    <button id="ButtonOgrenci" onclick="ogrenciGet()">ÖĞRENCİ BİLGİSİ GETİR</button>
    <div id="content">
    </div>

</body>
</html>
