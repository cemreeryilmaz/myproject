<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Jquery5.aspx.cs" Inherits="Jquery5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.12.3.min.js"></script>
    <style>
        #panel{
            width:100px; height:100px;
            background-color:orange;
            border:1px solid black;
            position:absolute;
        }
    </style>
    <script>
        $(document).ready(function () {
            $("#ButtonStartAnimasyon").click(function () {
                $("#panel").animate({
                    width: '250px',
                    height: '300px',
                    opacity: '0.5',
                    left: '250px',
                    top:'250px'
                }, "slow", function () {
                    alert("Animasyon Tamamlandı");
                });
            });
            $("#ButtonStopAnimasyon").click(function () {
                $("#panel").stop();
            });
        });
    </script>
</head>
<body>
    <button id="ButtonStartAnimasyon">Animasyonu Başlat</button>
    <button id="ButtonStopAnimasyon">Animasyonu Durdur</button>
    <br />
    <div id="panel">
    
    </div>
    
</body>
</html>
