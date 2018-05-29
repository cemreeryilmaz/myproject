<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JqueryUI_Uyg2.aspx.cs" Inherits="JqueryUI_Uyg2" %>

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
        #feedback {
            font-size: 1.4em;
        }

        #selectable .ui-selecting {
            background: #FECA40;
        }

        #selectable .ui-selected {
            background: #F39814;
            color: white;
        }

        #selectable {
            list-style-type: none;
            margin: 0;
            padding: 0;
            width: 60%;
        }

            #selectable li {
                margin: 3px;
                padding: 0.4em;
                font-size: 1.4em;
                height: 18px;
            }
    </style>
    <script>
        $(function () {
            $("#selectable").selectable();
        })
    </script>
</head>
<body>
    <ol id="selectable">
        <li class="ui-widget-content">Item 1</li>
        <li class="ui-widget-content">Item 2</li>
        <li class="ui-widget-content">Item 3</li>
        <li class="ui-widget-content">Item 4</li>
        <li class="ui-widget-content">Item 5</li>
        <li class="ui-widget-content">Item 6</li>
        <li class="ui-widget-content">Item 7</li>
    </ol>

</body>
</html>
