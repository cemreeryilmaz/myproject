<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery8.aspx.cs" Inherits="Jquery8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script>
        $(function () {
            $("#ButtonSetHtml").click(function () {
                $("#content").html("<p>Bu içerik sonradan eklendi!</p>");

            });
            $("#ButtonSetText").click(function () {
                $("#content").text("<p>Bu içerik sonradan eklendi!</p>");

            });
            $("#ButtonSetAttr").click(function () {
                $("#ornekLink").attr("href", "http://www.arel.edu.tr");

            });
        });
    </script>
</head>
<body>
   <button id="ButtonSetHtml">HTML-SET</button>
   <button id="ButtonSetText">TEXT-SET</button>
   <button id="ButtonSetAttr">ATTR-SET</button>
    <br />
    <a id="ornekLink" href="http://www.google.com">BAĞLANTI</a>
    <div id="content">
      ....İçerik içerik içerik...
    </div>
   
</body>
</html>
