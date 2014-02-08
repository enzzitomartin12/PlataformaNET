<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCDemo.Models.Clientes>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDCliente) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IDCliente) %>
                <%: Html.ValidationMessageFor(model => model.IDCliente) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDContacto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IDContacto) %>
                <%: Html.ValidationMessageFor(model => model.IDContacto) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Calle) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Calle) %>
                <%: Html.ValidationMessageFor(model => model.Calle) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Numero) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Numero) %>
                <%: Html.ValidationMessageFor(model => model.Numero) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Piso) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Piso) %>
                <%: Html.ValidationMessageFor(model => model.Piso) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Departamento) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Departamento) %>
                <%: Html.ValidationMessageFor(model => model.Departamento) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Cuidad) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Cuidad) %>
                <%: Html.ValidationMessageFor(model => model.Cuidad) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Provincia) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Provincia) %>
                <%: Html.ValidationMessageFor(model => model.Provincia) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Pais) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Pais) %>
                <%: Html.ValidationMessageFor(model => model.Pais) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Telefono) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Telefono) %>
                <%: Html.ValidationMessageFor(model => model.Telefono) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Web) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Web) %>
                <%: Html.ValidationMessageFor(model => model.Web) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Volver a la lista", "Index") %>
    </div>

</asp:Content>

