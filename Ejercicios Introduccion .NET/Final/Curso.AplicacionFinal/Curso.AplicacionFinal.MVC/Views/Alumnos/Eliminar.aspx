<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Curso.AplicacionFinal.MVC.AlumnoService.Alumnos>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Eliminar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Eliminar</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Alumnos</legend>

    <div class="display-label">NroLegajo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NroLegajo) %>
    </div>

    <div class="display-label">Nombre</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nombre) %>
    </div>

    <div class="display-label">Apellido</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Apellido) %>
    </div>

    <div class="display-label">FechaNac</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.FechaNac) %>
    </div>

    

    
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Listar") %>
    </p>
<% } %>

</asp:Content>
