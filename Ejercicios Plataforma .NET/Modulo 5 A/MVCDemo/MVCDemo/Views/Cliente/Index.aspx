<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCDemo.Models.Clientes>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>
    <p>
        <% if (TempData["Resultado"] != null)
        { 
            %><label><%= Html.Encode(TempData["Resultado"].ToString() )%></label><% 
        } 
        %>
    </p>
    <table>
        <tr>
            <th></th>
            <th>
                IDCliente
            </th>
            <th>
                Nombre
            </th>
            <th>
                IDContacto
            </th>
            <th>
                Calle
            </th>
            <th>
                Numero
            </th>
            <th>
                Piso
            </th>
            <th>
                Departamento
            </th>
            <th>
                Cuidad
            </th>
            <th>
                Provincia
            </th>
            <th>
                Pais
            </th>
            <th>
                Telefono
            </th>
            <th>
                Web
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IDCliente }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id=item.IDCliente }) %> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id=item.IDCliente })%>
            </td>
            <td>
                <%: item.IDCliente %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.IDContacto %>
            </td>
            <td>
                <%: item.Calle %>
            </td>
            <td>
                <%: item.Numero %>
            </td>
            <td>
                <%: item.Piso %>
            </td>
            <td>
                <%: item.Departamento %>
            </td>
            <td>
                <%: item.Cuidad %>
            </td>
            <td>
                <%: item.Provincia %>
            </td>
            <td>
                <%: item.Pais %>
            </td>
            <td>
                <%: item.Telefono %>
            </td>
            <td>
                <%: item.Web %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo Cliente", "Create") %>
    </p>

</asp:Content>

