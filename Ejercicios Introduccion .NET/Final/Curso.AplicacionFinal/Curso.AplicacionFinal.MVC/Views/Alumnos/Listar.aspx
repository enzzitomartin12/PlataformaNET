<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Curso.AplicacionFinal.MVC.AlumnoService.Alumnos>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Lista
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Lista</h2>

<p>
    <%: Html.ActionLink("Create New", "Crear") %>
</p>
<table>
    <tr>
        <th>
            Apellido
        </th>
        <th>
            FechaNac
        </th>
        <th>
            Nombre
        </th>
        <th>
            NroLegajo
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NroLegajo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nombre) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Apellido) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.FechaNac) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Editar", new { id=item.NroLegajo }) %> |
            <%: Html.ActionLink("Details", "Consultar", new { id=item.NroLegajo })%> |
            <%: Html.ActionLink("Delete", "Eliminar", new { id=item.NroLegajo })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
