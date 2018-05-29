<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Sitil1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 6px;
        }
        .auto-style4 {
            width: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="conteyner">
            <div id="header">
    
                HEADER</div>
            <div id="menu">

                <asp:HyperLink ID="HyperLinkDefault" runat="server" NavigateUrl="~/Default.aspx">Ana Sayfa</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLinkHakkimizda" runat="server" NavigateUrl="~/Hakkimizda.aspx">Hakkımızda</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLinkProjeler" runat="server" NavigateUrl="~/Projeler.aspx">Projeler</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLinkReferanslar" runat="server" NavigateUrl="~/Referanslar.aspx">Referanslar</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLinkContact" runat="server" NavigateUrl="~/Contact.aspx">İletişim</asp:HyperLink>

            </div>
            <div id="content">

                <span style="color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans; font-size: 11px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 14px; orphans: auto; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">İLETİŞİM<br />
                <br />
                Adres:
                <br />
                Donec tincidunt pellentesque felis. Integer a ultricies neque. Maecenas euismod erat eget dui lacinia, sed pharetra lacus fringilla. 
                <br />
                <br />
                Phone: +90555666995<br />
                <br />
                Fax: +905556665596<br />
                <br />
                </span>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2" colspan="3">YORUM GÖNDER</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Ad Soyad</td>
                        <td class="auto-style3">:</td>
                        <td>
                            <asp:TextBox ID="TextBoxAdSoyad" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Eposta Adresiniz</td>
                        <td class="auto-style3">:</td>
                        <td>
                            <asp:TextBox ID="TextBoxEposta" runat="server" TextMode="Email" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Yorumunuz</td>
                        <td class="auto-style3">:</td>
                        <td>
                            <asp:TextBox ID="TextBoxYorum" runat="server" Height="100px" TextMode="MultiLine" Width="400px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:CheckBox ID="CheckBoxOnay" runat="server" Text="Şartları okudum ve onayladım, sorumluluk bana ait" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:CheckBox ID="CheckBoxOnay2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBoxOnay2_CheckedChanged" Text="Şartları okudum ve onayladım, sorumluluk bana ait - Örnek2" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Button ID="ButtonGonder" runat="server" OnClick="ButtonGonder_Click" Text="GÖNDER" />
                            <asp:Button ID="ButtonGonder2" runat="server" OnClick="ButtonGonder2_Click" Text="GÖNDER - ÖRNEK2" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Label ID="LabelSonuc" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div id="footer">

                FOOTER</div>
        </div>
    </form>
</body>
</html>
