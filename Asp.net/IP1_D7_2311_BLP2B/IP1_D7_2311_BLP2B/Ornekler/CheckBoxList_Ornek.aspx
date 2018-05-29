<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxList_Ornek.aspx.cs" Inherits="Ornekler_CheckBoxList_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Örnek-1</strong><br />
        Bildiğiniz programlama dillerini seçiniz.<br />
        <asp:CheckBoxList ID="CheckBoxListProgramlama" runat="server" RepeatColumns="2">
            <asp:ListItem Value="1">C</asp:ListItem>
            <asp:ListItem Value="2">C++</asp:ListItem>
            <asp:ListItem Value="3">C#</asp:ListItem>
            <asp:ListItem Value="4">Java</asp:ListItem>
            <asp:ListItem Value="5">Visual Basic</asp:ListItem>
            <asp:ListItem Value="6">Python</asp:ListItem>
            <asp:ListItem Value ="7">JavaScript</asp:ListItem>
            <asp:ListItem Value="8">PHP</asp:ListItem>
        </asp:CheckBoxList>
    
        <br />
        <asp:Button ID="ButtonGonder" runat="server" OnClick="ButtonGonder_Click" Text="GÖNDER" />
        <br />
        <asp:Label ID="LabelProgram" runat="server"></asp:Label>
        <br />
        <br />
    <hr />

        <br />
        <strong>Örnek-2 (Runtime)</strong><asp:CheckBoxList ID="CheckBoxListMezeler" runat="server">
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="ButtonSiparis" runat="server" OnClick="ButtonSiparis_Click" Text="SİPARİŞ" />
        <br />
        <asp:Label ID="LabelMezeler" runat="server"></asp:Label>
        <br />
        <hr />
        <br />
        <strong>Örnek-3
        <br />
        Hobileriniz nelerdir?<br />
        <asp:CheckBoxList ID="CheckBoxListHobi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxListHobi_SelectedIndexChanged">
        </asp:CheckBoxList>
        </strong>
        <asp:Label ID="LabelHobiler" runat="server"></asp:Label>
        <br />

    </div>
    </form>
</body>
</html>
