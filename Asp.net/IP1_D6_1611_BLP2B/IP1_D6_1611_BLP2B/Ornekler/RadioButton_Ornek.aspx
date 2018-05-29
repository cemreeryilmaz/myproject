<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadioButton_Ornek.aspx.cs" Inherits="Ornekler_RadioButton_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Radio Button Kontrolü<br />
        <strong>Örnek-1:</strong><br />
        Cinsiyetiniz?<br />
        <asp:RadioButton ID="RadioButtonErkek" runat="server" GroupName="cinsiyet"  Text="Erkek" />
        <br />
        <asp:RadioButton ID="RadioButtonKadin" runat="server" GroupName="cinsiyet" Text="Kadın" />
        <br />
        <asp:Button ID="ButtonGonder" runat="server" OnClick="ButtonGonder_Click" Text="GÖNDER" />
        <br />
        <asp:Label ID="LabelCinsiyet" runat="server"></asp:Label>
    
        <br />
        <br />
        <strong>Örnek-2:</strong><br />
        Takımınız?<br />
        <br />
        <asp:RadioButton ID="RadioButtonGs" runat="server" AutoPostBack="True" GroupName="takim" OnCheckedChanged="RadioButtonGs_CheckedChanged" Text="Galatasaray" />
        <br />
        <asp:RadioButton ID="RadioButtonFb" runat="server" AutoPostBack="True" GroupName="takim" OnCheckedChanged="RadioButtonFb_CheckedChanged" Text="Fenerbahçe" />
        <br />
        <asp:RadioButton ID="RadioButtonBjk" runat="server" AutoPostBack="True" GroupName="takim" Text="Beşiktaş" />
        <br />
        <asp:RadioButton ID="RadioButtonTs" runat="server" AutoPostBack="True" GroupName="takim" Text="Trabzonspor" />
        <br />
        <asp:Label ID="LabelTakimlar" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
