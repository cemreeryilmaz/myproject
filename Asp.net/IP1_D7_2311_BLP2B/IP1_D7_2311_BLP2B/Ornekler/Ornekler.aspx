<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ornekler.aspx.cs" Inherits="Ornekler_Ornekler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">ÖRNEKLER</td>
        </tr>
        <tr>
            <td class="auto-style2"><a href="DropDownList.aspx">DropDownList</a> </td>
           
        </tr>
        <tr>
            <td class="auto-style2"><a href="CheckBoxList_Ornek.aspx">CheckBoxList</a></td>
           
        </tr>
        <tr>
            <td class="auto-style2"><a href="RadioButtonList_Ornek.aspx">RadioButtonList</a></td>
           
        </tr>
        <tr>
            <td class="auto-style2"><a href="RadioButton_Ornek.aspx">RadioButton</a></td>
           
        </tr>
        <tr>
            <td><a href="ListBox_Ornek.aspx">ListBox</a></td>
           
        </tr>
        <tr>
            <td class="auto-style2"><a href="Panel_Ornek.aspx">Panel</a></td>
           
        </tr>
        <tr>
            <td><a href="ViewMultiview_Ornek.aspx">View - Multiview</a></td>
           
        </tr>
        <tr>
            <td><a href="PlaceHolderDinamikKontrol_Ornek.aspx">PlaceHolder ve Dinamik Kontrol Ekleme(Runtime)</a></td>
           
        </tr>
        <tr>
            <td><a href="Wizard_Ornek.aspx">Wizard</a></td>
           
        </tr>
    </table>
</asp:Content>

