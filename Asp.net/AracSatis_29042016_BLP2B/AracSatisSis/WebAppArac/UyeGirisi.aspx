<%@ Page Title="" Language="C#"  MasterPageFile="~/AracSatis.Master" AutoEventWireup="true" CodeBehind="UyeGirisi.aspx.cs" Inherits="WebAppArac.UyeGirisi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 400px;
    }
    .auto-style3 {
        width: 100px;
    }
    .auto-style5 {
        width: 5px;
    }
    .auto-style7 {
        color: #FFFFFF;
        font-weight: bold;
    }
    .auto-style11 {
        color: #FFFFFF;
        font-weight: bold;
        width: 100px;
    }
    .auto-style13 {
        width: 5px;
        color: #FFFFFF;
        font-weight: bold;
    }
    .auto-style14 {
        width: 281px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PanelLogin" runat="server">
        <table class="auto-style1">
    <tr>
        <td class="auto-style7" colspan="3">ÜYE GİRİŞİ</td>
    </tr>
    <tr>
        <td class="auto-style11">E-Posta Adresi</td>
        <td class="auto-style13">:</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBoxEposta" runat="server" Height="25px" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style11">Şifre</td>
        <td class="auto-style13">:</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBoxSifre" runat="server" Height="25px" TextMode="Password" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style14">
            <asp:Button ID="ButtonGiris" runat="server" Height="44px" OnClick="ButtonGiris_Click" Text="GİRİŞ" Width="104px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style13">&nbsp;</td>
        <td class="auto-style14">
            <asp:CheckBox ID="CheckBoxBeniHatirla" runat="server" style="color: #FFFF99" Text="Beni Hatırla" />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style14">
            <asp:Label ID="LabelMsj" runat="server" style="color: #FF9933"></asp:Label>
        </td>
    </tr>
</table>
    </asp:Panel>
    
</asp:Content>
