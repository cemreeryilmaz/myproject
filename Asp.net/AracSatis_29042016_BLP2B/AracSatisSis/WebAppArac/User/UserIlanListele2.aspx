<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="UserIlanListele2.aspx.cs" Inherits="WebAppArac.User.UserIlanListele2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    --LİSTVİEW ÖRNEK--
    <br />
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ilanId" DataSourceID="SqlDataSourceForListView" GroupItemCount="3">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color:#FFF8DC;">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="ilanBasligiLabel" runat="server" style="font-weight: 700" Text='<%# Eval("ilanBasligi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="aracMarkaLabel" runat="server" Text='<%# Eval("aracMarka") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="aracModelLabel" runat="server" Text='<%# Eval("aracModel") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("alternateText") %>' Height="150px" ImageUrl='<%# Eval("resimYol") %>' Width="150px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="modelYiliLabel" runat="server" Text='<%# Eval("modelYili") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="yakitTuruLabel" runat="server" Text='<%# Eval("yakitTuru") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="vitesTuruLabel" runat="server" Text='<%# Eval("vitesTuru") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="kilometreLabel" runat="server" Text='<%# Eval("kilometre") %>'></asp:Label>
                            &nbsp;Km.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="fiyatLabel" runat="server" Text='<%# Eval("fiyat") %>'></asp:Label>
                            &nbsp;TL.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:HyperLink ID="HyperLinkDetay" NavigateUrl ='<% # Eval("ilanId","IlanDetay.aspx?ilanId={0}") %>' runat="server">İLANI İNCELE</asp:HyperLink>
                        </td>
                    </tr>
                </table>
                <br />
            </td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">ilanId:
                <asp:Label ID="ilanIdLabel1" runat="server" Text='<%# Eval("ilanId") %>' />
                <br />
                ilanBasligi:
                <asp:TextBox ID="ilanBasligiTextBox" runat="server" Text='<%# Bind("ilanBasligi") %>' />
                <br />
                modelYili:
                <asp:TextBox ID="modelYiliTextBox" runat="server" Text='<%# Bind("modelYili") %>' />
                <br />
                kilometre:
                <asp:TextBox ID="kilometreTextBox" runat="server" Text='<%# Bind("kilometre") %>' />
                <br />
                fiyat:
                <asp:TextBox ID="fiyatTextBox" runat="server" Text='<%# Bind("fiyat") %>' />
                <br />
                aracModel:
                <asp:TextBox ID="aracModelTextBox" runat="server" Text='<%# Bind("aracModel") %>' />
                <br />
                aracMarka:
                <asp:TextBox ID="aracMarkaTextBox" runat="server" Text='<%# Bind("aracMarka") %>' />
                <br />
                resimYol:
                <asp:TextBox ID="resimYolTextBox" runat="server" Text='<%# Bind("resimYol") %>' />
                <br />
                alternateText:
                <asp:TextBox ID="alternateTextTextBox" runat="server" Text='<%# Bind("alternateText") %>' />
                <br />
                vitesTuru:
                <asp:TextBox ID="vitesTuruTextBox" runat="server" Text='<%# Bind("vitesTuru") %>' />
                <br />
                yakitTuru:
                <asp:TextBox ID="yakitTuruTextBox" runat="server" Text='<%# Bind("yakitTuru") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br />
            </td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">ilanBasligi:
                <asp:TextBox ID="ilanBasligiTextBox" runat="server" Text='<%# Bind("ilanBasligi") %>' />
                <br />
                modelYili:
                <asp:TextBox ID="modelYiliTextBox" runat="server" Text='<%# Bind("modelYili") %>' />
                <br />
                kilometre:
                <asp:TextBox ID="kilometreTextBox" runat="server" Text='<%# Bind("kilometre") %>' />
                <br />
                fiyat:
                <asp:TextBox ID="fiyatTextBox" runat="server" Text='<%# Bind("fiyat") %>' />
                <br />
                aracModel:
                <asp:TextBox ID="aracModelTextBox" runat="server" Text='<%# Bind("aracModel") %>' />
                <br />
                aracMarka:
                <asp:TextBox ID="aracMarkaTextBox" runat="server" Text='<%# Bind("aracMarka") %>' />
                <br />
                resimYol:
                <asp:TextBox ID="resimYolTextBox" runat="server" Text='<%# Bind("resimYol") %>' />
                <br />
                alternateText:
                <asp:TextBox ID="alternateTextTextBox" runat="server" Text='<%# Bind("alternateText") %>' />
                <br />
                vitesTuru:
                <asp:TextBox ID="vitesTuruTextBox" runat="server" Text='<%# Bind("vitesTuru") %>' />
                <br />
                yakitTuru:
                <asp:TextBox ID="yakitTuruTextBox" runat="server" Text='<%# Bind("yakitTuru") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br />
            </td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color:#DCDCDC;color: #000000;">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="ilanBasligiLabel" runat="server" style="font-weight: 700" Text='<%# Eval("ilanBasligi") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="aracMarkaLabel" runat="server" Text='<%# Eval("aracMarka") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="aracModelLabel" runat="server" Text='<%# Eval("aracModel") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("alternateText") %>' Height="150px" ImageUrl='<%# Eval("resimYol") %>' Width="150px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="modelYiliLabel" runat="server" Text='<%# Eval("modelYili") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="yakitTuruLabel" runat="server" Text='<%# Eval("yakitTuru") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="vitesTuruLabel" runat="server" Text='<%# Eval("vitesTuru") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="kilometreLabel" runat="server" Text='<%# Eval("kilometre") %>'></asp:Label>
                            &nbsp;Km.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="fiyatLabel" runat="server" Text='<%# Eval("fiyat") %>'></asp:Label>
                            &nbsp;TL.</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:HyperLink ID="HyperLinkDetay" NavigateUrl ='<% # Eval("ilanId","IlanDetay.aspx?ilanId={0}") %>' runat="server">İLANI İNCELE</asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="6">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">ilanId:
                <asp:Label ID="ilanIdLabel" runat="server" Text='<%# Eval("ilanId") %>' />
                <br />
                ilanBasligi:
                <asp:Label ID="ilanBasligiLabel" runat="server" Text='<%# Eval("ilanBasligi") %>' />
                <br />
                modelYili:
                <asp:Label ID="modelYiliLabel" runat="server" Text='<%# Eval("modelYili") %>' />
                <br />
                kilometre:
                <asp:Label ID="kilometreLabel" runat="server" Text='<%# Eval("kilometre") %>' />
                <br />
                fiyat:
                <asp:Label ID="fiyatLabel" runat="server" Text='<%# Eval("fiyat") %>' />
                <br />
                aracModel:
                <asp:Label ID="aracModelLabel" runat="server" Text='<%# Eval("aracModel") %>' />
                <br />
                aracMarka:
                <asp:Label ID="aracMarkaLabel" runat="server" Text='<%# Eval("aracMarka") %>' />
                <br />
                resimYol:
                <asp:Label ID="resimYolLabel" runat="server" Text='<%# Eval("resimYol") %>' />
                <br />
                alternateText:
                <asp:Label ID="alternateTextLabel" runat="server" Text='<%# Eval("alternateText") %>' />
                <br />
                vitesTuru:
                <asp:Label ID="vitesTuruLabel" runat="server" Text='<%# Eval("vitesTuru") %>' />
                <br />
                yakitTuru:
                <asp:Label ID="yakitTuruLabel" runat="server" Text='<%# Eval("yakitTuru") %>' />
                <br />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSourceForListView" runat="server" ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>" SelectCommand="SELECT ilanlar.ilanId, ilanlar.ilanBasligi, ilanlar.modelYili, ilanlar.kilometre, ilanlar.fiyat, aracModel.aracModel, aracMarka.aracMarka, resimler.resimYol, resimler.alternateText, vitesTuru.vitesTuru, yakitTuru.yakitTuru FROM ilanlar INNER JOIN aracModel ON ilanlar.aracModelId = aracModel.aracModelId INNER JOIN aracMarka ON aracModel.aracMarkaId = aracMarka.aracMarkaId INNER JOIN resimler ON ilanlar.ilanId = resimler.ilanId INNER JOIN vitesTuru ON ilanlar.vitesTurId = vitesTuru.vitesTurId INNER JOIN yakitTuru ON ilanlar.yakitTuruId = yakitTuru.yakitTurId WHERE (ilanlar.ilanOnayDurumu = 1)"></asp:SqlDataSource>
    <br />
</asp:Content>
