<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery1.aspx.cs" Inherits="Jquery1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        p{
            width:50%; height:auto;
            border:1px solid black;
            padding:10px;
        }
    </style>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <%--   <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>--%>
    <script>
        $(document).ready(function () {
            $("p").click(function () {
                alert("Tıkladığın element gizlenecek!");
                $(this).hide();
            });
        });
    </script>

</head>
<body>
    <p>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam elit nibh, venenatis sit amet tristique a, facilisis non urna. Vestibulum cursus vulputate ante non blandit. Duis sodales condimentum libero, non blandit lorem tincidunt ut. Integer volutpat blandit felis eget rutrum. 
    </p>

</body>
</html>
