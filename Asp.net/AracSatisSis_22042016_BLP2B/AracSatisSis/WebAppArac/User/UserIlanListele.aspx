<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="UserIlanListele.aspx.cs" Inherits="WebAppArac.User.UserIlanListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
        ---GRİDVİEW ÖRNEĞİ--<br /><br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ilanId,resimId,Expr2,Expr3,Expr4,Expr5,yakitTurId" DataSourceID="SqlDataSourceForGridView" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ilanId" HeaderText="ilanId" InsertVisible="False" ReadOnly="True" SortExpression="ilanId" Visible="False" />
            <asp:BoundField DataField="kullaniciId" HeaderText="kullaniciId" SortExpression="kullaniciId" Visible="False" />
            <asp:BoundField DataField="ilanBasligi" HeaderText="ilanBasligi" SortExpression="ilanBasligi" />
            <asp:BoundField DataField="aracTuru" HeaderText="aracTuru" SortExpression="aracTuru" Visible="False" />
            <asp:BoundField DataField="aracModelId" HeaderText="aracModelId" SortExpression="aracModelId" Visible="False" />
            <asp:BoundField DataField="modelYili" HeaderText="modelYili" SortExpression="modelYili" />
            <asp:BoundField DataField="kilometre" HeaderText="kilometre" SortExpression="kilometre" />
            <asp:BoundField DataField="vitesTurId" HeaderText="vitesTurId" SortExpression="vitesTurId" Visible="False" />
            <asp:BoundField DataField="kasaTipiId" HeaderText="kasaTipiId" SortExpression="kasaTipiId" Visible="False" />
            <asp:BoundField DataField="yakitTuruId" HeaderText="yakitTuruId" SortExpression="yakitTuruId" Visible="False" />
            <asp:BoundField DataField="fiyat" HeaderText="fiyat" SortExpression="fiyat" />
            <asp:BoundField DataField="aciklama" HeaderText="aciklama" SortExpression="aciklama" Visible="False" />
            <asp:BoundField DataField="ilanTarihi" HeaderText="ilanTarihi" SortExpression="ilanTarihi" />
            <asp:CheckBoxField DataField="ilanOnayDurumu" HeaderText="ilanOnayDurumu" SortExpression="ilanOnayDurumu" Visible="False" />
            <asp:BoundField DataField="resimId" HeaderText="resimId" InsertVisible="False" ReadOnly="True" SortExpression="resimId" Visible="False" />
            <asp:BoundField DataField="alternateText" HeaderText="alternateText" SortExpression="alternateText" Visible="False" />
            <asp:BoundField DataField="vitesTuru" HeaderText="vitesTuru" SortExpression="vitesTuru" />
            <asp:BoundField DataField="aracModel" HeaderText="aracModel" SortExpression="aracModel" />
            <asp:BoundField DataField="aracMarkaId" HeaderText="aracMarkaId" SortExpression="aracMarkaId" Visible="False" />
            <asp:BoundField DataField="aracMarka" HeaderText="aracMarka" SortExpression="aracMarka" />
            <asp:BoundField DataField="kasaTipi" HeaderText="kasaTipi" SortExpression="kasaTipi" />
            <asp:BoundField DataField="yakitTurId" HeaderText="yakitTurId" InsertVisible="False" ReadOnly="True" SortExpression="yakitTurId" Visible="False" />
            <asp:BoundField DataField="yakitTuru" HeaderText="yakitTuru" SortExpression="yakitTuru" />
            <asp:ImageField DataAlternateTextField="alternateText" DataImageUrlField="resimYol" HeaderText="Resim">
                <ControlStyle Height="100px" Width="100px" />
            </asp:ImageField>
            <asp:HyperLinkField 
                DataNavigateUrlFields="ilanId" 
                DataNavigateUrlFormatString="ilanDetay.aspx?ilanId={0}" HeaderText="DETAY" Text="İNCELE" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>aaaa</asp:ListItem>
                        <asp:ListItem>bbbb</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceForGridView" runat="server" ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>" SelectCommand="SELECT ilanlar.ilanId, ilanlar.kullaniciId, ilanlar.ilanBasligi, ilanlar.aracTuru, ilanlar.aracModelId, ilanlar.modelYili, ilanlar.kilometre, ilanlar.vitesTurId, ilanlar.kasaTipiId, ilanlar.yakitTuruId, ilanlar.fiyat, ilanlar.aciklama, ilanlar.ilanTarihi, ilanlar.ilanOnayDurumu, resimler.resimId, resimler.resimYol, resimler.ilanId AS Expr1, resimler.alternateText, vitesTuru.vitesTurId AS Expr2, vitesTuru.vitesTuru, aracModel.aracModelId AS Expr3, aracModel.aracModel, aracModel.aracMarkaId, aracMarka.aracMarkaId AS Expr4, aracMarka.aracMarka, kasaTipi.kasaTipiId AS Expr5, kasaTipi.kasaTipi, yakitTuru.yakitTurId, yakitTuru.yakitTuru FROM ilanlar INNER JOIN aracModel ON ilanlar.aracModelId = aracModel.aracModelId INNER JOIN kasaTipi ON ilanlar.kasaTipiId = kasaTipi.kasaTipiId INNER JOIN resimler ON ilanlar.ilanId = resimler.ilanId INNER JOIN vitesTuru ON ilanlar.vitesTurId = vitesTuru.vitesTurId INNER JOIN yakitTuru ON ilanlar.yakitTuruId = yakitTuru.yakitTurId INNER JOIN aracMarka ON aracModel.aracMarkaId = aracMarka.aracMarkaId WHERE (ilanlar.ilanOnayDurumu = 1)">
    </asp:SqlDataSource>
    <br />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSourceForDataList" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyField="ilanId" GridLines="Both" RepeatColumns="3">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <ItemStyle BackColor="White" ForeColor="#003399" Width="200px" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="ilanBasligiLabel" runat="server" Text='<%# Eval("ilanBasligi") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Image ID="Image1" runat="server" AlternateText='<%# Eval("alternateText") %>' Height="150px" ImageUrl='<%# Eval("resimYol") %>' Width="150px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="kilometreLabel" runat="server" Text='<%# Eval("kilometre") %>' />
                        &nbsp;Km.</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="fiyatLabel" runat="server" Text='<%# Eval("fiyat") %>' />
                        &nbsp;TL.</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:HyperLink 
                            ID="HyperLink1" runat="server"
                            NavigateUrl='<% #Eval("ilanId","IlanDetay.aspx?ilanId={0}") %>'
                             style="font-style: italic">İLANI İNCELE</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSourceForDataList" runat="server" 
        ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>" 
        SelectCommand="SELECT ilanlar.ilanId, ilanlar.kullaniciId, ilanlar.ilanBasligi, ilanlar.aracTuru, ilanlar.aracModelId, ilanlar.modelYili, ilanlar.kilometre, ilanlar.vitesTurId, ilanlar.kasaTipiId, ilanlar.yakitTuruId, ilanlar.fiyat, ilanlar.aciklama, ilanlar.ilanTarihi, ilanlar.ilanOnayDurumu, resimler.resimId, resimler.resimYol, resimler.alternateText FROM ilanlar INNER JOIN resimler ON ilanlar.ilanId = resimler.ilanId WHERE (ilanlar.ilanOnayDurumu = 1)">
    </asp:SqlDataSource>
<br />
</asp:Content>
