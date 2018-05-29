<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama5.aspx.cs" Inherits="Uygulama5" %>

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
                var bolumler = ["Bilgisayar", "Elektronik", "Elektrik", "Makine"];
                var text = "<ul>", i;

                for (i = 0; i < bolumler.length; i++) {
                    text += "<li>" + bolumler[i] + "</li>";
                }
                text += "</ul>";

                document.getElementById("content").innerHTML = text;
    </script>
    </form>
</body>
</html>
