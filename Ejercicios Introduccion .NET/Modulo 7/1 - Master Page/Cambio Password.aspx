<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cambio Password.aspx.cs" Inherits="Cambio_Password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMenu" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" Runat="Server">
    <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F7DE" 
        BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" 
        Font-Names="Verdana" Font-Size="10pt" 
        oncontinuebuttonclick="ChangePassword1_ContinueButtonClick">
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
    </asp:ChangePassword>

    <div>
        <asp:HyperLink ID="hlVolverMenu" 
                        runat="server"
                        Text="Menu"
                        NavigateUrl="~/Menu.aspx" ClientIDMode="Inherit" />
    </div>
</asp:Content>

