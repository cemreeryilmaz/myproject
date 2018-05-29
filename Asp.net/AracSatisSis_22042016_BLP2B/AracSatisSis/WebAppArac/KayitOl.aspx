<%@ Page Title="" Language="C#" MasterPageFile="~/AracSatis.Master" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="WebAppArac.KayitOl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 400px;
    }
    .auto-style2 {
        color: #FFFFFF;
    }
    .auto-style4 {
        width: 4px;
        font-weight: bold;
        color: #FFFFFF;
    }
    .auto-style5 {
        width: 119px;
        font-weight: bold;
        color: #FFFFFF;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2" colspan="3"><strong>ÜYE KAYIT FORMU</strong></td>
    </tr>
    <tr>
        <td class="auto-style5">Ad</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:TextBox ID="TextBoxAd" runat="server" Height="25px" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Soyad</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:TextBox ID="TextBoxSoyad" runat="server" Height="25px" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Eposta</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:TextBox ID="TextBoxEposta" runat="server" Height="25px" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Şifre</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:TextBox ID="TextBoxSifre" runat="server" Height="25px" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Cep Telefonu</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:TextBox ID="TextBoxCepTelefonu" runat="server" Height="25px" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">İl</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:DropDownList ID="DropDownListIller" runat="server" Height="25px" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="DropDownListIller_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">İlçe</td>
        <td class="auto-style4">:</td>
        <td>
            <asp:DropDownList ID="DropDownListIlceler" runat="server" Height="25px" Width="250px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>
            <asp:Button ID="ButtonKullaniciKayit" runat="server" Height="37px" Text="KAYIT OL" Width="96px" OnClick="ButtonKullaniciKayit_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>
            <asp:Label ID="LabelMsj" runat="server" style="font-weight: 700; color: #FFFFCC"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
