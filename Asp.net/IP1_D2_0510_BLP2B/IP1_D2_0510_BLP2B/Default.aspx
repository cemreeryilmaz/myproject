<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 630px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style7 {
            width: 103px;
            height: 32px;
        }
        .auto-style8 {
            width: 14px;
            height: 32px;
        }
        .auto-style9 {
            height: 32px;
        }
        .auto-style12 {
            width: 158px;
            height: 32px;
        }
        .auto-style13 {
            height: 40px;
            width: 1px;
        }
        .auto-style15 {
            width: 10px;
            height: 32px;
        }
        .auto-style16 {
            width: 1px;
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" colspan="3"><strong>ZATEN ÜYEYİM</strong></td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style4" colspan="3"><strong>ÜYE DEĞİLİM AMA OLABİLİRİM</strong></td>
            </tr>
            <tr>
                <td class="auto-style7">E-Posta Adresi</td>
                <td class="auto-style15">:</td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBoxEpostaGiris" runat="server" BorderStyle="Solid" BorderWidth="1px" TextMode="Email"></asp:TextBox>
                </td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style7">Ad</td>
                <td class="auto-style8">:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxAd" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Şifre</td>
                <td class="auto-style15">:</td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBoxSifreGiris" runat="server" 
                        BorderStyle="Solid" 
                        BorderWidth="1px" 
                        MaxLength="16" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style7">Soyad</td>
                <td class="auto-style8">:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxSoyad" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style12">
                    <asp:CheckBox ID="CheckBoxBeniUnutma" runat="server" Text="Beni Unutma" />
                </td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style7">Eposta Adresi</td>
                <td class="auto-style8">:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxEposta" runat="server" 
                        BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style15"></td>
                <td class="auto-style12">
                    <asp:Button ID="ButtonGiris" runat="server" Text="GİRİŞ" />
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style7">Şifre</td>
                <td class="auto-style8">:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxSifre" runat="server" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style12">
                    <asp:Label ID="LabelGirisMsj" runat="server"></asp:Label>
                </td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style7">Doğum Tarihi</td>
                <td class="auto-style8">:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxDogumTarihi" runat="server" BorderStyle="Solid" BorderWidth="1px" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style15"></td>
                <td class="auto-style12">
                    &nbsp;</td>
                <td class="auto-style16"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Button ID="ButtonKaydet" runat="server" Text="KAYIT OL" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="LabelMsj" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
