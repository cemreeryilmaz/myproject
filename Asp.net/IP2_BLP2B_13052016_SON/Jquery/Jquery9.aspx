<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery9.aspx.cs" Inherits="Jquery9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
        }

        .auto-style3 {
        }

        .auto-style5 {
            width: 4px;
        }

        #SelectSehir {
            width: 98px;
        }
    </style>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script>
        $(function () {
            $("#SubmitKayitOl").click(function () {
                var Eposta = $("#TextEposta").val();
                var Sifre = $("#PasswordSifre").val();
                var Cinsiyet = $("input[name=cinsiyet]:checked").val();
                var Sehir = $("#SelectSehir option:selected").val();

                alert("Eposta: " + Eposta + "<br>" +
                    "Şifre: " + Sifre + "<br>" +
                    "Cinsiyet: " + Cinsiyet + "<br>" +
                    "Şehir: " + Sehir);
            });
        });
    </script>


</head>
<body>

    <table class="auto-style1">
        <tr>
            <td class="auto-style3" colspan="3">KAYIT FORMU</td>
        </tr>
        <tr>
            <td class="auto-style3">Eposta</td>
            <td class="auto-style5">:</td>
            <td>
                <input id="TextEposta" type="text" /></td>
        </tr>
        <tr>
            <td class="auto-style3">Şifre</td>
            <td class="auto-style5">:</td>
            <td>
                <input id="PasswordSifre" type="password" /></td>
        </tr>
        <tr>
            <td class="auto-style3">Cinsiyet</td>
            <td class="auto-style5">:</td>
            <td>
                <input id="RadioErkek" name="cinsiyet" type="radio" value="E" />Erkek
                <input id="RadioKadin" name="cinsiyet" type="radio" value="K" />Kadın</td>
        </tr>
        <tr>
            <td class="auto-style3">Şehir</td>
            <td class="auto-style5">:</td>
            <td>
                <select id="SelectSehir" name="D1">
                    <option value="06">Ankara</option>
                    <option value="34">İstanbul</option>
                    <option value="35">İzmir</option>
                </select></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                <input id="SubmitKayitOl" type="submit" value="KAYIT OL" /></td>
        </tr>
    </table>

</body>
</html>
