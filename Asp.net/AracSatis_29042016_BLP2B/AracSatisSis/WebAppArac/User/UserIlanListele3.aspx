<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="UserIlanListele3.aspx.cs" Inherits="WebAppArac.User.UserIlanListele3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table,tr,th,td{
            border:1px solid teal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    --REPEATER ÖRNEĞi--
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSourceForRepeater">
       
         <HeaderTemplate>
            <table>
                <tr>
                    <th colspan="9">2.EL ARAÇ İLANLARI</th>
                </tr>
                <tr>
                    <th>İlan Başlığı</th>
                    <th>Marka</th>
                    <th>Model</th>
                    <th>Yakıt Türü</th>
                    <th>Vites Türü</th>
                    <th>Kilometre</th>
                    <th>Fiyat</th>
                    <th>Resim</th>
                    <th>Detay</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><asp:Label ID="labelBaslik"  runat="server" Text='<% # Eval("ilanBasligi") %>'></asp:Label></td>
                <td><asp:Label ID="labelMarka" runat="server" Text='<% # Eval("aracMarka") %>'></asp:Label></td>
                <td><asp:Label ID="labelModel" runat="server" Text='<% # Eval("aracModel") %>'></asp:Label></td>
                <td><asp:Label ID="labelYakit" runat="server" Text='<% # Eval("yakitTuru") %>'></asp:Label></td>
                <td><asp:Label ID="labelVites" runat="server" Text='<% # Eval("vitesTuru") %>'></asp:Label></td>
                <td><asp:Label ID="labelKilometre" runat="server" Text='<% # Eval("kilometre") %>'></asp:Label></td>
                <td><asp:Label ID="labelFiyat" runat="server" Text='<% # Eval("fiyat") %>'></asp:Label></td>
                <td><asp:Image ID="imageIlan" runat="server" ImageUrl='<% # Eval ("resimYol") %>' AlternateText='<% # Eval("alternateText") %>' Width="100px" Height="100px" /></td>
                <td><asp:HyperLink ID="HyperDetay" runat="server" NavigateUrl='<% # Eval("ilanId","IlanDetay.aspx?ilanId={0}") %>'>İLANI İNCELE</asp:HyperLink></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            <tr>
                <th colspan="9">
                    Arel Araç Satış
                </th>
            </tr>
            </table>

        </FooterTemplate>
    </asp:Repeater>
    <asp:SqlDataSource ID="SqlDataSourceForRepeater" runat="server" ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>" SelectCommand="SELECT ilanlar.ilanId, ilanlar.ilanBasligi, ilanlar.modelYili, ilanlar.kilometre, ilanlar.fiyat, aracMarka.aracMarka, aracModel.aracModel, yakitTuru.yakitTuru, vitesTuru.vitesTuru, resimler.resimYol, resimler.alternateText FROM ilanlar INNER JOIN aracModel ON ilanlar.aracModelId = aracModel.aracModelId INNER JOIN aracMarka ON aracModel.aracMarkaId = aracMarka.aracMarkaId INNER JOIN resimler ON ilanlar.ilanId = resimler.ilanId INNER JOIN vitesTuru ON ilanlar.vitesTurId = vitesTuru.vitesTurId INNER JOIN yakitTuru ON ilanlar.yakitTuruId = yakitTuru.yakitTurId WHERE (ilanlar.ilanOnayDurumu = 1)"></asp:SqlDataSource>
    <br />

</asp:Content>
