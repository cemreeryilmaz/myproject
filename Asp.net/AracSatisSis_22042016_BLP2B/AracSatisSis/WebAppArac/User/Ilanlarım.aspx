<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="Ilanlarım.aspx.cs" Inherits="WebAppArac.User.Ilanlarım" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ilanId" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None">
    <AlternatingRowStyle BackColor="PaleGoldenrod" />
    <Columns>
        <asp:BoundField DataField="ilanId" HeaderText="ilanId" InsertVisible="False" ReadOnly="True" SortExpression="ilanId" />
        <asp:BoundField DataField="kullaniciId" HeaderText="kullaniciId" SortExpression="kullaniciId" />
        <asp:BoundField DataField="ilanBasligi" HeaderText="ilanBasligi" SortExpression="ilanBasligi" />
        <asp:BoundField DataField="aracTuru" HeaderText="aracTuru" SortExpression="aracTuru" />
        <asp:BoundField DataField="aracModelId" HeaderText="aracModelId" SortExpression="aracModelId" />
        <asp:BoundField DataField="modelYili" HeaderText="modelYili" SortExpression="modelYili" />
        <asp:BoundField DataField="kilometre" HeaderText="kilometre" SortExpression="kilometre" />
        <asp:BoundField DataField="vitesTurId" HeaderText="vitesTurId" SortExpression="vitesTurId" />
        <asp:BoundField DataField="kasaTipiId" HeaderText="kasaTipiId" SortExpression="kasaTipiId" />
        <asp:BoundField DataField="yakitTuruId" HeaderText="yakitTuruId" SortExpression="yakitTuruId" />
        <asp:BoundField DataField="fiyat" HeaderText="fiyat" SortExpression="fiyat" />
        <asp:BoundField DataField="aciklama" HeaderText="aciklama" SortExpression="aciklama" />
        <asp:BoundField DataField="ilanTarihi" HeaderText="ilanTarihi" SortExpression="ilanTarihi" />
        <asp:CheckBoxField DataField="ilanOnayDurumu" HeaderText="ilanOnayDurumu" SortExpression="ilanOnayDurumu" />
    </Columns>
    <FooterStyle BackColor="Tan" />
    <HeaderStyle BackColor="Tan" Font-Bold="True" />
    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    <SortedAscendingCellStyle BackColor="#FAFAE7" />
    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
    <SortedDescendingCellStyle BackColor="#E1DB9C" />
    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>" SelectCommand="SELECT * FROM [ilanlar] WHERE ([kullaniciId] = @kullaniciId)">
    <SelectParameters>
        <asp:SessionParameter Name="kullaniciId" SessionField="kullaniciId" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
</asp:Content>
