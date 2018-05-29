<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery3.aspx.cs" Inherits="Jquery3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #headPanel,#Panel{
            width:50%; height:auto;
            padding:20px;
            background-color:orange;
            border:1px solid black;
            text-align:center;
        }
        #Panel{
            display:none;
        }
    </style>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script>
        $(function () {
            $("#headPanel").click(function () {
                //$("#Panel").slideDown("slow");
                $("#Panel").slideToggle("slow");
            });
        });
    </script>
</head>
<body>
    <div id="headPanel">
     Bilgisayar Programcılığı
    </div>
    <div id="Panel">
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
        Aliquam elit nibh, venenatis sit amet tristique a, 
        facilisis non urna. Vestibulum cursus vulputate ante 
        non blandit. Duis sodales condimentum libero, non blandit lorem tincidunt ut. Integer volutpat blandit felis eget rutrum. 
    </div>
  
</body>
</html>
