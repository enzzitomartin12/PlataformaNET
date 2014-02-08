<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Curso.AplicacionFinal.MVC.AlumnoService.Alumnos>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edicion
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edicion</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Alumnos</legend>

        <div class="display-label">NroLegajo</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.NroLegajo) %>
        </div>
        
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nombre) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nombre) %>
            <%: Html.ValidationMessageFor(model => model.Nombre) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Apellido) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Apellido) %>
            <%: Html.ValidationMessageFor(model => model.Apellido) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.FechaNac) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.FechaNac) %>
            <%: Html.ValidationMessageFor(model => model.FechaNac) %>
        </div>



        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Listar") %>
</div>

</asp:Content>
