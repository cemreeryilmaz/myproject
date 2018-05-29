<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownList.aspx.cs" Inherits="Ornekler_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Örnek-1<br />
        </strong>Plakasını öğrenmek istediğini şehri seçin<br />
        <asp:DropDownList ID="DropDownListSehir" runat="server" Height="20px" Width="106px">
            <asp:ListItem Value="01">Adana</asp:ListItem>
            <asp:ListItem Value="02">Adıyaman</asp:ListItem>
            <asp:ListItem Value="03">Artvin</asp:ListItem>
            <asp:ListItem Value="06">Ankara</asp:ListItem>
            <asp:ListItem Value="10">Balıkesir</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Button ID="ButtonGoster" runat="server" OnClick="ButtonGoster_Click" Text="GÖSTER" />
        <br />
        <asp:Label ID="LabelPlaka" runat="server"></asp:Label>
        <br />
    
    <hr />
        <br />
        <strong>Örnek-2</strong><br />
        Okuduğunuz bölümü seçiniz<br />
        <asp:DropDownList ID="DropDownListBolumler" runat="server">
            <asp:ListItem Value="-1">--BÖLÜM SEÇİNİZ--</asp:ListItem>
            <asp:ListItem Value="BLP">Bilgisayar Programcılığı</asp:ListItem>
            <asp:ListItem Value="ELK">Elektrik</asp:ListItem>
            <asp:ListItem Value="ETK">Elektronik</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Button ID="ButtonGonder" runat="server" OnClick="ButtonGonder_Click" Text="GÖNDER" />
        <br />
        <asp:Label ID="LabelBolum" runat="server"></asp:Label>
        <br />
    <hr />
            
        <br />
        <strong>Örnek-3 / ISPOSTBACK / Value ve Text değerlerini ayrı yöneterek dinamik Item Ekleme</strong><br />
        Mezuniyet durumunuzu seçiniz<br />
        <asp:DropDownList ID="DropDownListMezuniyet" runat="server">
        </asp:DropDownList>
&nbsp;<asp:Button ID="ButtonMezuniyet" runat="server" OnClick="ButtonMezuniyet_Click" Text="GÖNDER" />
        <br />
        <asp:Label ID="LabelMezuniyet" runat="server"></asp:Label>
        <br />
        <br />
            <hr />
        <strong>Örnek-4
    </strong>
        <br />
        Tuttuğunuz takımı seçin<br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="-1">--TAKIMLAR--</asp:ListItem>
            <asp:ListItem Value="GS">Galatasaray</asp:ListItem>
            <asp:ListItem Value="FB">Fenerbahçe</asp:ListItem>
            <asp:ListItem Value="BJK">Beşiktaş</asp:ListItem>
            <asp:ListItem Value="TS">Trabzonspor</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="LabelTakim" runat="server"></asp:Label>
        <br />
        <hr />
        <strong>Örnek-5
        <br />
        </strong>
        <asp:DropDownList ID="DropDownListGun" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListAy" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListYil" runat="server">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
