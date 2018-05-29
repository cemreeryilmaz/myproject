<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Panel_Ornek.aspx.cs" Inherits="Ornekler_Panel_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 387px;
        }
        .auto-style3 {
        }
        .auto-style6 {
            width: 14px;
        }
        .auto-style7 {
            width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Panel Kontrolü<br />
        <asp:Button ID="ButtonGoster" runat="server" OnClick="ButtonGoster_Click" Text="GÖSTER" />
&nbsp;<asp:Button ID="ButtonGizle" runat="server" OnClick="ButtonGizle_Click" Text="GİZLE" />
        <br />
        <br />
        <asp:Panel ID="PanelIcerik" runat="server" BackColor="#999999" 
            BorderColor="#333333" BorderStyle="Solid" 
            BorderWidth="1px" Height="300px" Width="400px">
            <p style="text-align: justify; font-size: 11px; line-height: 14px; margin: 0px 0px 14px; padding: 0px; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis at nisl ligula. Donec vitae purus sodales, efficitur diam vitae, ultricies sem. Fusce quis orci sit amet tellus elementum semper. Nam id iaculis urna, vel bibendum risus. Mauris consequat, eros vel eleifend pharetra, ipsum elit imperdiet dolor, id sollicitudin lorem velit in felis. Nulla quis risus ac justo pellentesque ultricies eget vel orci. Sed sollicitudin metus sed sem porta facilisis. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Duis eu nisl justo. Maecenas a lacus mauris. Phasellus eget efficitur justo.</p>
            <p style="text-align: justify; font-size: 11px; line-height: 14px; margin: 0px 0px 14px; padding: 0px; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
                Etiam a risus at magna sollicitudin placerat. Quisque tempor vel risus ac vehicula. Morbi eget diam vel libero euismod ornare. Nam fringilla ante vel justo tempor pulvinar sed vel dui. Vestibulum non velit consequat, sollicitudin dolor et, varius justo. Sed risus nunc, condimentum sed malesuada non, pulvinar eu mauris. Suspendisse potenti. Nullam accumsan orci mauris, et placerat enim dapibus in. Aenean viverra cursus nisl, eget dignissim eros pretium vel. Sed quis augue et ipsum accumsan dapibus quis in felis. Vivamus dictum, ex eu molestie convallis, odio dui blandit diam, a mattis felis nisi ac nulla. Ut in nisi a purus sodales gravida non ut metus.</p>
            <p style="text-align: justify; font-size: 11px; line-height: 14px; margin: 0px 0px 14px; padding: 0px; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
                &nbsp;</p>

        </asp:Panel>
    
        <hr />
        <strong>Örnek-2

    </strong>
        <br />
        Cinsiyetiniz:<asp:RadioButtonList ID="RadioButtonListCinsiyet" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonListCinsiyet_SelectedIndexChanged" RepeatDirection="Horizontal">
            <asp:ListItem Value="E">Erkek</asp:ListItem>
            <asp:ListItem Value="K">Kadın</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="PanelAskerlik" runat="server">
            Askerlik Durumu:
            <asp:DropDownList ID="DropDownListAskerlik" runat="server">
                <asp:ListItem>Tecilli</asp:ListItem>
                <asp:ListItem>Muaf</asp:ListItem>
                <asp:ListItem>Yapıldı</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        <br />
        <hr />
        <strong>Örnek-3

        </strong>

        <br />
        <asp:Panel ID="PanelLogin" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="3">Üye Giriş</td>
                </tr>
                <tr>
                    <td class="auto-style3">E-Posta Adresi</td>
                    <td class="auto-style6">:</td>
                    <td>
                        <asp:TextBox ID="TextBoxEposta" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Şifre</td>
                    <td class="auto-style6">:</td>
                    <td>
                        <asp:TextBox ID="TextBoxSifre" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        <asp:Button ID="ButtonGiris" runat="server" OnClick="ButtonGiris_Click" Text="GİRİŞ" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        <asp:Label ID="LabelMsj" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>

        <asp:Panel ID="PanelUser" runat="server">
            <table class="auto-style7">
                <tr>
                    <td>
                        <asp:Label ID="LabelUsername" runat="server"></asp:Label>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelLoginTime" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="ÇIKIŞ" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
