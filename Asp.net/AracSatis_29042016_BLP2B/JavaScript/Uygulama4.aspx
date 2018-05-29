<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama4.aspx.cs" Inherits="Uygulama4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
    
    </div>
        <script>
            var d = new Date();
            document.getElementById("content").innerHTML =  d.getMonth() +1 + ".Month"
               + " Year: " +d.getFullYear();
        </script>
    </form>
</body>
</html>
