<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewMultiview_Ornek.aspx.cs" Inherits="Ornekler_ViewMultiview_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Multiview View Örnekleri<br />
        <br />
        <asp:LinkButton ID="LinkButtonBLP" runat="server" OnClick="LinkButtonBLP_Click">Bilgisayar Programcılığı</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButtonElektronik" runat="server" OnClick="LinkButtonElektronik_Click">Elektronik</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButtonElektrik" runat="server" OnClick="LinkButtonElektrik_Click">Elektrik</asp:LinkButton>
        <br />
        <br />
        Bölüm Seç:
        <asp:DropDownList ID="DropDownListBolumler" runat="server" AutoPostBack="True" Height="19px" OnSelectedIndexChanged="DropDownListBolumler_SelectedIndexChanged" Width="109px">
            <asp:ListItem>Bilgisayar</asp:ListItem>
            <asp:ListItem>Elektronik</asp:ListItem>
            <asp:ListItem>Elektrik</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:MultiView ID="MultiViewBolumler" runat="server">
            <asp:View ID="ViewBlp" runat="server">
                <strong>Bilgisayar Programcılığı</strong><br /> <span style="color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-size: 11px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 14px; orphans: auto; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ac enim eu augue vestibulum aliquet. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aenean iaculis tincidunt lacus at pellentesque. Aenean sed aliquam dui, et aliquam purus. Vivamus vel velit nec nunc finibus condimentum et vitae arcu. Phasellus ut nunc ac purus lobortis elementum quis in erat. Integer eu finibus turpis, a dapibus ex. Pellentesque vitae semper nunc. Donec ac eros sed nunc placerat egestas sed ac est. Suspendisse nec sem vel leo 
                consectetur pulvinar eu eget sem. Ut sem quam, bibendum ac elementum vitae, tincidunt sit amet velit. Proin tincidunt magna eget justo vestibulum, sed auctor ligula vehicula. Aenean sed eros massa. Nunc eget luctus nunc. Etiam ac justo imperdiet, euismod metus sed, aliquam arcu. Ut elementum ultrices libero a semper.</span>
            </asp:View>
            <asp:View ID="ViewEtk" runat="server">

                <strong>Elektronik</strong><br /> <span style="color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-size: 11px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 14px; orphans: auto; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Morbi libero orci, consectetur semper tincidunt ut, porta id ante. Sed imperdiet et leo quis suscipit. Morbi tortor urna, venenatis quis nibh eget, lobortis aliquet nunc. Donec luctus sodales erat, quis faucibus orci fringilla at. Donec varius laoreet urna, eu volutpat magna porta quis. Suspendisse iaculis dictum odio in accumsan. Sed in posuere elit. Nulla sed mi venenatis, tristique orci in, tempor massa. Duis elementum imperdiet porttitor.</span>

            </asp:View>
            <asp:View ID="ViewElk" runat="server">

                <strong>Elektrik</strong><br /> <span style="color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-size: 11px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 14px; orphans: auto; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Aliquam commodo sagittis ex, quis ornare turpis aliquam sed. Maecenas convallis nisl id fringilla tristique. Pellentesque condimentum tellus dignissim sagittis congue. Praesent placerat imperdiet est sollicitudin sodales. Proin ut iaculis orci. Pellentesque in vulputate leo. Nam lacinia tempus vestibulum. Aliquam erat nunc, lacinia quis diam ac, malesuada vestibulum magna. Pellentesque ullamcorper leo velit, sed varius lorem ornare nec.</span>

            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
