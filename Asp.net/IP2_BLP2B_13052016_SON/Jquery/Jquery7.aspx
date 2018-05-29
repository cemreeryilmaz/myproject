<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery7.aspx.cs" Inherits="Jquery7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #content{
            width:50%; height:auto;padding:10px;
            border:1px solid red;
        }
        p{border:1px solid lightgrey; padding:10px;}
    </style>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script>
        $(function () {
            $("#ButtonGetHtml").click(function () {
                alert($("#content").html());

            });
            $("#ButtonGetText").click(function () {
                alert($("#content").text());

            });
            $("#ButtonGetAttr").click(function () {
                alert($("#ornekLink").attr("href"));

            });
        });
    </script>

</head>
<body>
    <button id="ButtonGetHtml">HTML-GET</button>
    <button id="ButtonGetText">TEXT-GET</button>
    <button id="ButtonGetAttr">ATTR-GET</button>
    <br />
    <a id="ornekLink" href="http://www.arel.edu.tr">BAĞLANTI</a>
    <br />
    <div id="content">
     <p>
         The jQuery Bower package contains additional files besides the default
          distribution.<b> In most cases you can ignore these files,</b> however if you
          wish to download the default release on its own you can use Bower to 
         install jQuery from one of the above urls instead of the registered package.
     </p>
    </div>
    
</body>
</html>
