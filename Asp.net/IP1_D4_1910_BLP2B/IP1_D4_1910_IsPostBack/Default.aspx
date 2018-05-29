<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Şehirler :
        <asp:DropDownList ID="DropDownListSehirler" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="ButtonSec" runat="server" OnClick="ButtonSec_Click" Text="SEÇ" />
        <br />
        <asp:Label ID="LabelSehir" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
