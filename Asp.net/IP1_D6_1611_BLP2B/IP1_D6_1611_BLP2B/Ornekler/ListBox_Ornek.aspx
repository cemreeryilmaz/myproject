<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListBox_Ornek.aspx.cs" Inherits="Ornekler_ListBox_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ListBox Kontrolü<br />
        <br />
        <strong>Örnek-1</strong><br />
        Şehirler:<br />
        <asp:ListBox ID="ListBoxSehirler" runat="server" Height="74px" Width="97px">
            <asp:ListItem Value="06">Ankara</asp:ListItem>
            <asp:ListItem Value="34">İstanbul</asp:ListItem>
            <asp:ListItem Value="35">İzmir</asp:ListItem>
            <asp:ListItem Value="65">Van</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="ButtonGonder" runat="server" OnClick="ButtonGonder_Click" Text="GÖNDER" />
&nbsp;<br />
        <asp:Label ID="LabelSehir" runat="server"></asp:Label>
        <br />
        <hr /><br />
        <strong>Örnek-2:</strong><br />
        <strong>Bölümler</strong><br />
        Bölüm Adı: <asp:TextBox ID="TextBoxBolumAd" runat="server"></asp:TextBox>
        <br />
        Bölüm Kodu:
        <asp:TextBox ID="TextBoxBolumKod" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="ButtonEkle" runat="server" OnClick="ButtonEkle_Click" Text="EKLE" />
        <br />
        <asp:ListBox ID="ListBoxBolumler" runat="server" AutoPostBack="True" Height="69px" OnSelectedIndexChanged="ListBoxBolumler_SelectedIndexChanged" Width="92px"></asp:ListBox>
        <br />
        <asp:Button ID="ButtonSil" runat="server" OnClick="ButtonSil_Click" Text="SEÇİLENİ SİL" />
        <br />
        <asp:Label ID="LabelBolumler" runat="server"></asp:Label>
        <br />
        <hr /><br />
        Ödev:<br />
        <br />
    
    </div>
    </form>
</body>
</html>
