<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="UserIlanEkle.aspx.cs" Inherits="WebAppArac.User.UserIlanEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        table,tr,td{padding:5px;}
        .auto-style1 {
            width: 500px;
        }
        .auto-style6 {
            height: 22px;
        }
        .auto-style8 {
            width: 116px;
        }
        .auto-style10 {
            width: 4px;
        }
        .auto-style11 {
            width: 413px;
        }
    .auto-style12 {
        width: 116px;
        height: 34px;
    }
    .auto-style13 {
        width: 4px;
        height: 34px;
    }
    .auto-style14 {
        width: 413px;
        height: 34px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6" colspan="3"><strong>İLAN EKLEME FORMU</strong></td>
        </tr>
        <tr>
            <td class="auto-style8">İlan Başlık</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxIlanBaslik" runat="server" Height="25px" Width="336px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Araç Türü</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:DropDownList ID="DropDownListAracTur" runat="server" Height="25px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownListAracTur_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Marka</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:DropDownList ID="DropDownListMarka" runat="server" Height="25px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownListMarka_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Model</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:DropDownList ID="DropDownListModel" runat="server" Height="25px" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Model Yılı</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxModelYili" runat="server" Height="25px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Kilometre</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxKilometre" runat="server" Height="25px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">Vites Türü</td>
            <td class="auto-style13">:</td>
            <td class="auto-style14">
                <asp:DropDownList ID="DropDownListVitesTuru" runat="server" Height="25px" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Kasa Tipi</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:DropDownList ID="DropDownListKasaTipi" runat="server" Height="25px" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Yakıt Türü</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:DropDownList ID="DropDownListYakitTuru" runat="server" Height="25px" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Fiyat</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxFiyat" runat="server" Height="25px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Açıklama</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:TextBox ID="TextBoxAciklama" runat="server" Height="249px" TextMode="MultiLine" Width="360px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Resim</td>
            <td class="auto-style10">:</td>
            <td class="auto-style11">
                <asp:FileUpload ID="FileUploadResim" runat="server" Width="327px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Button ID="ButtonIlanEkle" runat="server" Height="41px" Text="İLANI EKLE" Width="90px" OnClick="ButtonIlanEkle_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="LabelMsj" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
