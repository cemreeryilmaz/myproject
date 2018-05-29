<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IlanListele.aspx.cs" Inherits="WebAppArac.Admin.IlanListele" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonListIlanOnayDurumu" runat="server" AutoPostBack="True">
            <asp:ListItem Value="1" Selected="True">Onaylananlar</asp:ListItem>
            <asp:ListItem Value="0">Onaylı Olmayan İlanlar</asp:ListItem>
        </asp:RadioButtonList>
        <br />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ilanId" DataSourceID="SqlDataSourceForGridView" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" PageSize="5">
            <AlternatingRowStyle BackColor="Gainsboro" />
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
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSourceForGridView" runat="server" 
            ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>"
            SelectCommand="SELECT * FROM [ilanlar] WHERE ilanOnayDurumu=@ilanOnayDurumu" 
            UpdateCommand="UPDATE ilanlar SET kullaniciId = @kullaniciId, ilanBasligi = @ilanBasligi, aracTuru = @aracTuru, modelYili = @modelYili, aracModelId = @aracModelId, kilometre = @kilometre, vitesTurId = @vitesTurId, kasaTipiId = @kasaTipiId, yakitTuruId = @yakitTuruId, fiyat = @fiyat, aciklama = @aciklama, ilanTarihi = @ilanTarihi, ilanOnayDurumu = @ilanOnayDurumu WHERE (ilanId = @ilanId)">
            <SelectParameters>
                <asp:ControlParameter Name="ilanOnayDurumu"
                     ControlID="RadioButtonListIlanOnayDurumu" DefaultValue="1" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="kullaniciId" DbType="Int32" />
                <asp:Parameter Name="ilanBasligi" />
                <asp:Parameter Name="aracTuru" />
                <asp:Parameter Name="modelYili" />
                <asp:Parameter Name="aracModelId" />
                <asp:Parameter Name="kilometre" />
                <asp:Parameter Name="vitesTurId" />
                <asp:Parameter Name="kasaTipiId" />
                <asp:Parameter Name="yakitTuruId" />
                <asp:Parameter Name="fiyat" DbType="Double" />
                <asp:Parameter Name="aciklama" />
                <asp:Parameter Name="ilanTarihi" DbType="DateTime" />
                <asp:Parameter Name="ilanOnayDurumu" />
                <asp:Parameter Name="ilanId" />
            </UpdateParameters>

        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
