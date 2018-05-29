<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama7.aspx.cs" Inherits="Uygulama7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        var ogrenciJSON = [{
            "no": "151030106",
            "ad": "Emre",
            "soyad": "Çetin",
            "bolum": "Bilgisayar"
        }, {
            "no": "151030107",
            "ad": "Filiz",
            "soyad": "Akın",
            "bolum": "Bilgisayar"
        }];

        function ogrenciGet() {
            document.getElementById("content").innerHTML=
                ogrenciJSON[0].ad + "<br>"+
                ogrenciJSON[0].soyad + "<br>"+
                ogrenciJSON[0].no + "<br>"+
                ogrenciJSON[0].bolum ;
        }
    </script>
</head>
<body>
    <button id="ButtonOgrenci" onclick="ogrenciGet()">ÖĞRENCİ BİLGİSİ GETİR</button>
    <div id="content">

    
    </div>

</body>
</html>
