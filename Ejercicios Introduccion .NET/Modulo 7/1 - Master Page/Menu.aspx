<%@ Page Title="" 
    Language="C#" 
    MasterPageFile="~/MasterPage.master" 
    AutoEventWireup="true" 
    CodeFile="Menu.aspx.cs" 
    Inherits="Menu"
     %>
<%--<%@ OutputCache Duration="60" Location="Server" VaryByParam="none" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMenu" Runat="Server">
    <div><asp:Label ID="lblHola" runat="server" Text="Hola " /> <asp:Label ID="lbUsuario" runat="server" /></div>
    <div><asp:Label ID="lblVariableGlobalText" runat="server" Text="Variable Global: " /> <asp:Label ID="lblVariableGlobal" runat="server" /></div>
    <div align="center"> <asp:Label ID="lblMenu" runat="server" Text="Menu" /> </div>
    <ul>
        <li>
            <asp:HyperLink ID="hlFormulario" 
                            runat="server"
                            Text="Formulario"
                            NavigateUrl="~/Default.aspx" ClientIDMode="Inherit" />
        </li>
        <li>
            <asp:HyperLink ID="hlAgregarUsuarios" 
                            runat="server"
                            Text="Agregar Usuario"
                            NavigateUrl="~/Crear Usuario.aspx" ClientIDMode="Inherit" />
        </li>
        <li>
            <asp:HyperLink ID="hlCambioPassword" 
                            runat="server"
                            Text="Cambiar Password"
                            NavigateUrl="~/Cambio Password.aspx" ClientIDMode="Inherit" />
        </li>
    </ul>
    
    <div><asp:Substitution ID="subHora" runat="server" MethodName="DameHora" /></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" Runat="Server">
    <asp:DropDownList ID="ddlRoles" runat="server" AutoPostBack="true"
         OnSelectedIndexChanged="ddlRoles_SelectedIndexChanged" />
    <asp:GridView ID="gvUsuarios" runat="server">
    </asp:GridView>
</asp:Content>

