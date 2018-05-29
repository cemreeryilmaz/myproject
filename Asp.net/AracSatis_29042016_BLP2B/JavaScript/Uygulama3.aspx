<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama3.aspx.cs" Inherits="Uygulama3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <button id="butonMesaj" onclick="mesajGoster('Filiz')">MESAJ</button>
    <div id="content">
    
    </div>
        <script>
            function mesajGoster(isim) {
                alert("Hoşgeldin " + isim);
            }

            function topla(sayi1, sayi2) {
                var sonuc = sayi1 + sayi2;
                return sonuc;
            }

            document.getElementById("content").innerHTML = "Sonuç: " + topla(10, 15);
        </script>
    </form>
</body>
</html>
