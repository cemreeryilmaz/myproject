<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMain.Master" AutoEventWireup="true" CodeBehind="IlanDetay.aspx.cs" Inherits="WebAppArac.User.IlanDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 750px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {}
        .auto-style4 {
            width: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSourceDetayForDataList">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td colspan="4">
                        <asp:Label ID="ilanBasligiLabel" runat="server" style="font-weight: 700; color: #800000" Text='<%# Eval("ilanBasligi") %>' />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" rowspan="5" style="vertical-align: top">
                        <table class="auto-style4">
                            <tr>
                                <td>
                                    <asp:Image ID="Image1" ImageUrl='<% #Eval("resimYol") %>' runat="server" Height="250px" Width="350px" />
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td colspan="2"><strong>İlan Sahibi</strong></td>
                </tr>
                <tr>
                    <td>Adı Soyadı</td>
                    <td>
                        <asp:Label ID="adLabel" runat="server" Text='<%# Eval("ad") %>' />
                        &nbsp;<asp:Label ID="soyadLabel" runat="server" Text='<%# Eval("soyad") %>' />
                    </td>
                </tr>
                <tr>
                    <td>E-posta Adresi</td>
                    <td>
                        <asp:Label ID="epostaLabel" runat="server" Text='<%# Eval("eposta") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Cep Telefonu</td>
                    <td class="auto-style2">
                        <asp:Label ID="cepTelefonuLabel" runat="server" Text='<%# Eval("cepTelefonu") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="4"><strong>İlan Bilgileri</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">Marka</td>
                    <td class="auto-style2">
                        <asp:Label ID="aracMarkaLabel" runat="server" Text='<%# Eval("aracMarka") %>' />
                    </td>
                    <td class="auto-style2">Model</td>
                    <td class="auto-style2">
                        <asp:Label ID="aracModelLabel" runat="server" Text='<%# Eval("aracModel") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Fiyat</td>
                    <td>
                        <asp:Label ID="fiyatLabel" runat="server" Text='<%# Eval("fiyat") %>' />
                    </td>
                    <td>Kilometre</td>
                    <td>
                        <asp:Label ID="kilometreLabel" runat="server" Text='<%# Eval("kilometre") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Model Yılı</td>
                    <td>
                        <asp:Label ID="modelYiliLabel" runat="server" Text='<%# Eval("modelYili") %>' />
                    </td>
                    <td>Vites Türü</td>
                    <td>
                        <asp:Label ID="vitesTuruLabel" runat="server" Text='<%# Eval("vitesTuru") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Yakıt Türü</td>
                    <td>
                        <asp:Label ID="yakitTuruLabel" runat="server" Text='<%# Eval("yakitTuru") %>' />
                    </td>
                    <td>Kasa Tipi</td>
                    <td>
                        <asp:Label ID="kasaTipiLabel" runat="server" Text='<%# Eval("kasaTipi") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">İlan tarihi</td>
                    <td>
                        <asp:Label ID="ilanTarihiLabel" runat="server" Text='<%# Eval("ilanTarihi") %>' />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="4"><strong>AÇIKLAMA</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="4">
                        <asp:Label ID="aciklamaLabel" runat="server" Text='<%# Eval("aciklama") %>' />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSourceDetayForDataList" runat="server" 
        ConnectionString="<%$ ConnectionStrings:AracSatisConnectionString %>" 
        SelectCommand="SELECT ilanlar.ilanId, ilanlar.ilanBasligi, ilanlar.modelYili, ilanlar.kilometre, ilanlar.fiyat, ilanlar.aciklama, ilanlar.ilanTarihi, kullanicilar.ad, kullanicilar.soyad, kullanicilar.eposta, kullanicilar.cepTelefonu, aracModel.aracModel, aracMarka.aracMarka, resimler.resimYol, resimler.alternateText, kasaTipi.kasaTipi, yakitTuru.yakitTuru, vitesTuru.vitesTuru FROM ilanlar INNER JOIN aracModel ON ilanlar.aracModelId = aracModel.aracModelId INNER JOIN aracMarka ON aracModel.aracMarkaId = aracMarka.aracMarkaId INNER JOIN kullanicilar ON ilanlar.kullaniciId = kullanicilar.kullaniciId INNER JOIN kasaTipi ON ilanlar.kasaTipiId = kasaTipi.kasaTipiId INNER JOIN resimler ON ilanlar.ilanId = resimler.ilanId INNER JOIN vitesTuru ON ilanlar.vitesTurId = vitesTuru.vitesTurId INNER JOIN yakitTuru ON ilanlar.yakitTuruId = yakitTuru.yakitTurId WHERE ilanOnayDurumu=1 AND ilanlar.ilanId=@ilanId">
        <SelectParameters>
            <asp:QueryStringParameter Name="ilanId"  QueryStringField="ilanId"  />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
</asp:Content>
