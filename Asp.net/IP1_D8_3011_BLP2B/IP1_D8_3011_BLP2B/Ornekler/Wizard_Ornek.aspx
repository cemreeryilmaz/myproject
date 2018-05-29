<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Wizard_Ornek.aspx.cs" Inherits="Ornekler_Wizard_Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 349px;
        }
        .auto-style2 {
            height: 16px;
        }
        .auto-style4 {
            height: 16px;
            width: 79px;
        }
        .auto-style5 {
            width: 79px;
        }
        .auto-style6 {
            width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Wizard Ornek</strong><br />
        <br />
        <asp:Wizard ID="WizardOzgecmis" runat="server" ActiveStepIndex="2" BackColor="#E6E2D8" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="228px" Width="481px">
            <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
            <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
            <SideBarButtonStyle ForeColor="White" />
            <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" />
            <WizardSteps>
                <asp:WizardStep runat="server" title="Kimlik Bilgileri">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style5">&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5">T.C. Kimlik No</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Ad</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Soyad</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Doğum Tarihi</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Doğum Yeri</td>
                            <td class="auto-style2">:</td>
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5">Baba Adı</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Eğitim Bilgileri">
                    <table class="auto-style6">
                        <tr>
                            <td>Mezun Olduğunuz Lise</td>
                            <td>:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="137px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Mezun Olduğunuz Üniversite</td>
                            <td>:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList2" runat="server" Height="18px" Width="137px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Üniversite Mezuniyet Yılınız</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="İletişim Bilgileri">
                    <table class="auto-style6">
                        <tr>
                            <td class="auto-style2">E-posta adresi</td>
                            <td class="auto-style2">:</td>
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Cep Telefonu</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Ev Telefonu</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>İş Telefonu</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Adres</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>İş Adresi</td>
                            <td>:</td>
                            <td>
                                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
