<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery4.aspx.cs" Inherits="Jquery4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
        #content{
            width:50%; height:auto;
            border:1px solid black;
            padding:10px; background-color:yellow;
        }
    </style>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script>
        $(function () {
            $("#ButtonGizle").click(function () {
                $("#content").fadeOut("slow");
            });
            $("#ButtonGoster").click(function () {
                $("#content").fadeIn("slow");
            });
            $("#ButtonGizleGoster").click(function () {
                $("#content").fadeToggle("slow");
            });
        });
    </script>
</head>
<body>
    <button id="ButtonGizle" >GİZLE</button>
    <button id="ButtonGoster" >GÖSTER</button>
    <button id="ButtonGizleGoster" >GİZLE/GÖSTER</button>
    <div id="content">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
        Aliquam elit nibh, venenatis sit amet tristique a,
        facilisis non urna. Vestibulum cursus vulputate 
        ante non blandit. Duis sodales condimentum libero,
        non blandit lorem tincidunt ut. Integer volutpat
        blandit felis eget rutrum. 
    </div>
</body>
</html>
