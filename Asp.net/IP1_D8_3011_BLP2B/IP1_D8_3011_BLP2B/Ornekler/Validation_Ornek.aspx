<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validation_Ornek.aspx.cs" Inherits="Ornekler_Validation_Orne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 700px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 18px;
        }
        .auto-style4 {
            width: 225px;
        }
        .auto-style5 {
            width: 225px;
            height: 39px;
        }
        .auto-style6 {
            width: 18px;
            height: 39px;
        }
        .auto-style7 {
            height: 39px;
        }
        .auto-style8 {
            width: 400px;
        }
        .auto-style10 {
        }
        .auto-style12 {
            width: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style8">
            <tr>
                <td class="auto-style10" colspan="3"><strong>ÜYE GİRİŞİ</strong></td>
            </tr>
            <tr>
                <td class="auto-style10">E-Posta Adresi</td>
                <td class="auto-style12">:</td>
                <td>
                    <asp:TextBox ID="TextBoxLoginEposta" runat="server" Height="25px" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLoginEposta" runat="server" ControlToValidate="TextBoxLoginEposta" ErrorMessage="Eposta Boş Geçilemez" ForeColor="#CC0000" ValidationGroup="Login">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Şifre</td>
                <td class="auto-style12">:</td>
                <td>
                    <asp:TextBox ID="TextBoxLoginSifre" runat="server" Height="25px" Width="200px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLoginSifre" runat="server" ControlToValidate="TextBoxLoginSifre" ErrorMessage="Şifre Boş Geçilemez" ForeColor="#CC0000" ValidationGroup="Login">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonGiris" runat="server" Text="GİRİŞ" ValidationGroup="Login" />
                </td>
            </tr>
        </table>
    <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummaryOrnek" runat="server" Font-Italic="True" ForeColor="Red" ValidationGroup="Register" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3"><strong>ÜYE KAYIT FORMU</strong></td>
            </tr>
            <tr>
                <td class="auto-style5">Ad</td>
                <td class="auto-style6">:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxAd" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorAd" runat="server" ControlToValidate="TextBoxAd" EnableClientScript="False" ErrorMessage="Ad boş geçilemez!" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Soyad</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBoxSoyad" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorSoyad" runat="server" ControlToValidate="TextBoxSoyad" EnableClientScript="False" ErrorMessage="Soyad Boş Geçilemez!" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">E-Posta</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBoxEposta" runat="server" Height="25px" Width="250px" TextMode="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEposta" runat="server" ControlToValidate="TextBoxEposta" EnableClientScript="False" ErrorMessage="Eposta Boş Geçilemez!" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEposta" runat="server" ControlToValidate="TextBoxEposta" EnableClientScript="False" ErrorMessage="Geçersiz Eposta Adresi" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Register">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Şifre</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBoxSifre" runat="server" Height="25px" TextMode="Password" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorSifre" runat="server" ControlToValidate="TextBoxSifre" EnableClientScript="False" ErrorMessage="Şifre Boş Geçilemez" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidatorSifreUzunluk" runat="server" ControlToValidate="TextBoxSifre" EnableClientScript="False" ErrorMessage="Şifre minimum 8 karakter olmalı" ForeColor="Red" OnServerValidate="CustomValidatorSifreUzunluk_ServerValidate" ValidationGroup="Register">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Şifre Tekrar</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBoxSifreTekrar" runat="server" Height="25px" TextMode="Password" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorSifreTekrar" runat="server" ControlToValidate="TextBoxSifreTekrar" EnableClientScript="False" ErrorMessage="Şifre Tekrar Boş Geçilemez!" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorSifreTekrar" runat="server" ControlToCompare="TextBoxSifre" ControlToValidate="TextBoxSifreTekrar" EnableClientScript="False" ErrorMessage="Şifre Tekrar ile Şifre Eşleşmeli" ForeColor="Red" ValidationGroup="Register">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Şehir</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:DropDownList ID="DropDownListSehirler" runat="server" Height="25px" Width="250px">
                        <asp:ListItem Value="-1">--Şehirler--</asp:ListItem>
                        <asp:ListItem Value="06">Ankara</asp:ListItem>
                        <asp:ListItem Value="01">Adana</asp:ListItem>
                        <asp:ListItem Value="34">İstanbul</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorSehir" runat="server" ControlToValidate="DropDownListSehirler" EnableClientScript="False" ErrorMessage="Şehir Seçmelisiniz!" ForeColor="Red" InitialValue="-1" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Doğum Tarihi</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBoxDogumTarihi" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDogumTarihi" runat="server" ControlToValidate="TextBoxDogumTarihi" EnableClientScript="False" ErrorMessage="Dogum Tarihi Boş Geçilemez" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorDogumTarihi" runat="server" ControlToValidate="TextBoxDogumTarihi" EnableClientScript="False" ErrorMessage="Girilen Doğum Tarihi Tarih Formatında Değil" ForeColor="Red" Operator="DataTypeCheck" Type="Date" ValidationGroup="Register">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Diploma Notu (100&#39;lük Sistem)</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextBoxDiploma" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDiploma" runat="server" ControlToValidate="TextBoxDiploma" EnableClientScript="False" ErrorMessage="Diploma Notunuzu Girmelisiniz" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorDiploma" runat="server" ControlToValidate="TextBoxDiploma" EnableClientScript="False" ErrorMessage="Diploma Notu Değeri 0-100 arasında olmalı" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer" ValidationGroup="Register">Diploma Notu Değeri 0-100 arasında olmalı</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonGonder" runat="server" Text="GÖNDER" OnClick="ButtonGonder_Click" ValidationGroup="Register" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
