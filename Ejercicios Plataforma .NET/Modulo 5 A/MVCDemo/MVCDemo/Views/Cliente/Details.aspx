<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCDemo.Models.Clientes>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalles</h2>

    <fieldset>
        <legend>Campos</legend>
        
        <div class="display-label">IDCliente</div>
        <div class="display-field"><%: Model.IDCliente %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">IDContacto</div>
        <div class="display-field"><%: Model.IDContacto %></div>
        
        <div class="display-label">Calle</div>
        <div class="display-field"><%: Model.Calle %></div>
        
        <div class="display-label">Numero</div>
        <div class="display-field"><%: Model.Numero %></div>
        
        <div class="display-label">Piso</div>
        <div class="display-field"><%: Model.Piso %></div>
        
        <div class="display-label">Departamento</div>
        <div class="display-field"><%: Model.Departamento %></div>
        
        <div class="display-label">Cuidad</div>
        <div class="display-field"><%: Model.Cuidad %></div>
        
        <div class="display-label">Provincia</div>
        <div class="display-field"><%: Model.Provincia %></div>
        
        <div class="display-label">Pais</div>
        <div class="display-field"><%: Model.Pais %></div>
        
        <div class="display-label">Telefono</div>
        <div class="display-field"><%: Model.Telefono %></div>
        
        <div class="display-label">Web</div>
        <div class="display-field"><%: Model.Web %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Editar", "Edit", new { id=Model.IDCliente }) %> |
        <%: Html.ActionLink("Volver a la lista", "Index") %>
    </p>

</asp:Content>

