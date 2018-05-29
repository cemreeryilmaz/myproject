<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageButton_Ornek.aspx.cs" Inherits="Ornekler_ImageButton_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButtonOrnek" runat="server" ImageUrl="~/images/button_img.png" OnClick="ImageButtonOrnek_Click" Width="75px" />
    
    </div>
    </form>
</body>
</html>
