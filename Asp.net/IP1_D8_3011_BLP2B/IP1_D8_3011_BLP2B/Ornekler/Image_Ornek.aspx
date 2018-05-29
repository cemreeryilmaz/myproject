<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_Ornek.aspx.cs" Inherits="Ornekler_Image_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 10px">
    <form id="form1" runat="server">
    <div>
    
        Image Kontrolü<br />
        <br />
        <asp:Image ID="ImageOrnek" runat="server" Height="250px" ImageUrl="~/images/Desert.jpg" Width="250px" />
        <br />
        <br />
        <asp:Button ID="ButtonYukle" runat="server" OnClick="ButtonYukle_Click" Text="Resim Yükle" />
        <br />
        <asp:Image ID="ImageOrnek2" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>
