<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama1.aspx.cs" Inherits="Uyuglt" %>

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
        document.getElementById("content").innerHTML = "Merhaba-innerHTML";
        alert("Merhaba-alert");
        document.write("Merhaba-document.write");
        console.log("Merhaba-console");
    </script>  
    </form>
</body>
</html>
