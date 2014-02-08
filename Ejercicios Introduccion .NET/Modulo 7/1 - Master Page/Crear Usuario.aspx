<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Crear Usuario.aspx.cs" Inherits="Crear_Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMenu" Runat="Server">
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" 
        oncontinuebuttonclick="CreateUserWizard1_ContinueButtonClick">
        <WizardSteps>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>

    <div>
        <asp:HyperLink ID="hlVolverMenu" 
                        runat="server"
                        Text="Menu"
                        NavigateUrl="~/Menu.aspx" ClientIDMode="Inherit" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" Runat="Server">
</asp:Content>

