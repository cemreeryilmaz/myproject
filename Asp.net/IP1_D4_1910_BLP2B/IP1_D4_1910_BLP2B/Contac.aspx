<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contac.aspx.cs" Inherits="Contac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
    .auto-style2 {
        width: 500px;
    }
    .auto-style3 {
    }
    .auto-style4 {
        width: 159px;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    İLETİŞİM SAYFASI</p>
<table class="auto-style2">
    <tr>
        <td class="auto-style3" colspan="3">İLETİŞİM FORMU</td>
    </tr>
    <tr>
        <td class="auto-style4">Adınız Soyadınız</td>
        <td>:</td>
        <td>
            <asp:TextBox ID="TextBoxAd" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">E-Posta Adresiniz</td>
        <td>:</td>
        <td>
            <asp:TextBox ID="TextBoxEposta" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">Mesajınız</td>
        <td>:</td>
        <td>
            <asp:TextBox ID="TextBoxMesaj" runat="server" Height="121px" TextMode="MultiLine" Width="279px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="ButtonGonder" runat="server" Text="GÖNDER" />
        </td>
    </tr>
</table>
</asp:Content>

