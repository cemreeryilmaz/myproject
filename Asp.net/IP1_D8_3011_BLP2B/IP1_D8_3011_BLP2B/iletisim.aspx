<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        table, tr,td{
            border:1px solid #808080;
            border-collapse:collapse;
        width: 454px;
    }
 
    .auto-style1 {
        width: 455px;
    }
    .auto-style3 {
        width: 225px;
    }
    .auto-style4 {
        width: 50px;
    }
    .auto-style5 {
        width: 454px;
    }
 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style4" colspan="3">İLETİŞİM FORMU</td>
        </tr>
        <tr>
            <td class="auto-style3">Adınız Soyadınız</td>
            <td class="auto-style4">:</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBoxAdSoyad" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">E-Posta Adresiniz</td>
            <td class="auto-style4">:</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBoxEposta" runat="server" TextMode="Email" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Yaşadığınız Şehir</td>
            <td class="auto-style4">:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownListSehirler" runat="server" Width="250px">
                    <asp:ListItem Value="01">Adana</asp:ListItem>
                    <asp:ListItem Value="02">Adıyaman</asp:ListItem>
                    <asp:ListItem Value="03">Artvin</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mesajınız</td>
            <td class="auto-style4">:</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBoxMesaj" runat="server" Height="200px" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">
                <asp:CheckBox ID="CheckBoxOnay" runat="server" Text="Uyarıları okudum, kabul ediyorum" AutoPostBack="True" OnCheckedChanged="CheckBoxOnay_CheckedChanged" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="ButtonGonder" runat="server" Text="GÖNDER" OnClick="ButtonGonder_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="LabelMsj" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

