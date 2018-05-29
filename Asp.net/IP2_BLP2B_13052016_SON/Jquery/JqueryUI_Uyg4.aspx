<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JqueryUI_Uyg4.aspx.cs" Inherits="JqueryUI_Uyg4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link href="Styles/jquery-ui.min.css" rel="stylesheet" />
    <link href="Styles/jquery-ui.structure.min.css" rel="stylesheet" />
    <link href="Styles/jquery-ui.theme.min.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <script src="Scripts/jquery-ui.min.js"></script>

    <script>
        $(function () {
            $("#TextDateMezuniyet").datepicker();
        });
    </script>
</head>
<body>
  Mezuniyet Tarihi: <input type="text" id="TextDateMezuniyet" />
</body>
</html>
