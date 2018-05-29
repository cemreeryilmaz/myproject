<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JqueryUI_Uyg1.aspx.cs" Inherits="JqueryUI_Uyg1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/jquery-ui.min.css" rel="stylesheet" />
    <link href="Styles/jquery-ui.structure.min.css" rel="stylesheet" />
    <link href="Styles/jquery-ui.theme.min.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script src="Scripts/jquery-ui.min.js"></script>
    
    <style>
        #panel{width:200px; height:200px; border:1px solid black;}
    </style>
    <script>
        $(function () {
            $("#panel").draggable();
        });
    </script>
</head>
<body>
 <div id="panel">

 </div>

</body>
</html>
