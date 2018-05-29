<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uygulama9-Dom.aspx.cs" Inherits="Uygulama9_Dom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function pGet() {
            var x = document.getElementsByTagName("p");
            alert(x[0].innerHTML);
            x[0].style.color = "red";
        }
    </script>
</head>
<body>
<button id="buttonPGet" onclick="pGet()">İLK PARAGRAF</button>
<p>
Praesent ex lorem, luctus sit amet odio vitae, imperdiet dictum justo. 
     Nulla at mi pellentesque, aliquam dui molestie, varius nisl.
</p>
<p>
Morbi semper laoreet est, quis placerat nibh hendrerit in.
    Nam gravida, elit ac blandit feugiat, sapien dui gravida eros, vitae sodales augue arcu a lorem. 
</p>
<p>
Ut quam mi, dictum mattis orci suscipit, elementum tempus ligula.
     Morbi efficitur vestibulum dolor, ut congue risus malesuada sagittis.
     Phasellus dignissim aliquam dignissim. 
</p>
    
</body>
</html>
