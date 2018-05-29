<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadioButtonList_Ornek.aspx.cs" Inherits="Ornekler_RadioButtonList_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Örnek-1</strong><br />
        Cinsiyetiniz<br />
        <asp:RadioButtonList ID="RadioButtonListCinsiyet" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="E">Erkek</asp:ListItem>
            <asp:ListItem Value="K">Kadın</asp:ListItem>
        </asp:RadioButtonList>
    
        <br />
        <asp:Button ID="ButtonGonder" runat="server" OnClick="ButtonGonder_Click" Text="GÖNDER" />
        <br />
        <asp:Label ID="LabelCinsiyet" runat="server"></asp:Label>
        <br />
        <hr />
        <br />
        <strong>Örnek-2<br />
        </strong>Takımınız?<br />
        <asp:RadioButtonList ID="RadioButtonListTakimlar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonListTakimlar_SelectedIndexChanged">
            <asp:ListItem Value="GS">Galatasaray</asp:ListItem>
            <asp:ListItem Value="FB">Fenerbahçe</asp:ListItem>
            <asp:ListItem Value="BJK">Beşiktaş</asp:ListItem>
            <asp:ListItem Value="TS">Trabzonspor</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="LabelTakim" runat="server"></asp:Label>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
