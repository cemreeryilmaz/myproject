<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KayitOl.aspx.cs" Inherits="KayitOl" %>

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
        .auto-style7 {
            width: 85px;
        }
        .auto-style9 {
            width: 4px;
        }
        .auto-style10 {
            width: 334px;
        }
        #Select1 {
            width: 127px;
        }
        #SelectSehir {
            width: 80px;
        }
    </style>

    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script src="Scripts/jquery.json.js"></script>

    <script>
        $(document).ready(function () {
            $("#SubmitKayitOl").click(function () {
                var Ad = $("#TextAd").val();
                var Soyad = $("#TextSoyad").val();
                var Eposta = $("#TextEposta").val();
                var Sifre = $("#PasswordSifre").val();
                var Cinsiyet = $("input[name=cinsiyet]:checked").val();
                var Sehir = $("#SelectSehir option:selected").val();

                var KullanicilarJSON = {
                    ad: Ad, soyad: Soyad, eposta: Eposta,
                    sifre: Sifre, cinsiyet: Cinsiyet, sehir: Sehir
                };

                $.ajax({
                    type: "POST",
                    url: "KayitOl.aspx/KullaniciEkle",
                    data: $.toJSON(KullanicilarJSON),
                    dataType: "json",
                    contentType: "application/json; charset=utf-8",
                    success: function (msj) {
                        alert(msj.d);
                    },
                    error: function () {
                        alert("HATA");
                    }
                });
            });
        });
    </script>

</head>
<body>
     
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="3"><strong>KAYIT FORMU</strong></td>
            </tr>
            <tr>
                <td class="auto-style7">Ad</td>
                <td class="auto-style9">:</td>
                <td class="auto-style10">
                    <input id="TextAd" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style7">Soyad</td>
                <td class="auto-style9">:</td>
                <td class="auto-style10">
                    <input id="TextSoyad" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style7">Eposta</td>
                <td class="auto-style9">:</td>
                <td class="auto-style10">
                    <input id="TextEposta" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style7">Şifre</td>
                <td class="auto-style9">:</td>
                <td class="auto-style10">
                    <input id="PasswordSifre" type="password" /></td>
            </tr>
            <tr>
                <td class="auto-style7">Cinsiyet</td>
                <td class="auto-style9">:</td>
                <td class="auto-style10">
                    <input id="RadioErkek" name="cinsiyet" type="radio" value="E" />Erkek
                    <input id="RadioKadin" name="cinsiyet" type="radio" value="K" />Kadın</td>
            </tr>
            <tr>
                <td class="auto-style7">Şehir</td>
                <td class="auto-style9">:</td>
                <td class="auto-style10">
                    <select id="SelectSehir" name="D1">
                        <option value="06">Ankara</option>
                        <option value="34">İstanbul</option>
                        <option value="35">İzmir</option>
                    </select></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <input id="SubmitKayitOl" type="submit" value="KAYIT OL" /></td>
            </tr>
        </table>
    
    </div>
  
</body>
</html>
