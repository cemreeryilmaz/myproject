<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageMap_Ornek.aspx.cs" Inherits="Ornekler_ImageMap_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="ImageMapIphone" runat="server" ImageUrl="~/images/iphone.jpg">
            <asp:CircleHotSpot Radius="15" X="150" Y="150" />
        </asp:ImageMap>
    
    </div>
    </form>
</body>
</html>
