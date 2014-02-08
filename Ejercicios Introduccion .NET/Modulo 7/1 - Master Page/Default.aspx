<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMenu" Runat="Server">
    <div>
        <asp:LinkButton ID="lnkMenu" runat="server" PostBackUrl="~/Menu.aspx" Text="Volver al Menu" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphContenido" Runat="Server">
    <div>
    
    <table>
        <tr>
            <td><asp:Label ID="lblNombre" runat="server" Text="Nombre" /> </td>
            <td> 
                <asp:TextBox ID="tbNombre" 
                             MaxLength="100"
                             runat="server" /> 
                <asp:RequiredFieldValidator ID="rfvNombre" 
                                            runat="server" 
                                            Display="Dynamic"
                                            ForeColor="Red"
                                            ValidationGroup="Curso"
                                            ControlToValidate="tbNombre" />

                <asp:CustomValidator ID="cvNombre" 
                                     runat="server"
                                     ValidationGroup="Curso"
                                     Display="Dynamic"
                                     ForeColor="Red"
                                     ControlToValidate="tbNombre"  
                                     ClientValidationFunction="caracteresInvalidos"/>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblApellido" runat="server" Text="Apellido" /> </td>
            <td> 
                <asp:TextBox ID="tbApellido" 
                             MaxLength="100"
                             runat="server" /> 
                <asp:RequiredFieldValidator ID="rfvApellido" 
                                            runat="server" 
                                            Display="Dynamic"
                                            ForeColor="Red"
                                            ValidationGroup="Curso"
                                            ControlToValidate="tbApellido" />
                <asp:CustomValidator ControlToValidate="tbApellido"  
                                        ID="cvApellido" 
                                        runat="server"
                                        ValidationGroup="Curso"
                                        ForeColor="Red"
                                        Display="Dynamic"
                                        ClientValidationFunction="caracteresInvalidos"/>
            </td>
        </tr>
        <tr>
            <td> <asp:Label ID="lblCuit" runat="server" Text="CUIT" /> </td>
            <td> 
                <asp:TextBox ID="tbCuit" 
                             MaxLength="11"
                             runat="server" />
                <asp:RequiredFieldValidator ID="rfvCuit" 
                                            runat="server" 
                                            Display="Dynamic"
                                            ValidationGroup="Curso"
                                            ForeColor="Red"
                                            ControlToValidate="tbCuit" />                    
                <asp:CustomValidator ID="cvCuit" 
                                     runat="server" 
                                     Display="Dynamic" 
                                     ForeColor="Red"
                                     EnableClientScript="true" 
                                     ClientValidationFunction="CuitValido" 
                                     ValidationGroup="Curso"
                                     ControlToValidate="tbCuit" />
                <asp:CustomValidator ID="cvCuitCaracteresInvalidos" 
                                     runat="server"
                                     ControlToValidate="tbCuit"  
                                     ValidationGroup="Curso"
                                     ForeColor="Red"
                                     Display="Dynamic"
                                     ClientValidationFunction="caracteresInvalidos"/> 
            </td>
        </tr>
        <tr>
            <td> <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento" /></td>
            <td>
                <asp:TextBox ID="tbFechaNacimiento"
                             runat="server"
                             MaxLength="10" />

                <asp:RegularExpressionValidator ID="revFechaNacimiento" 
                                                Display="Dynamic" 
                                                ControlToValidate="tbFechaNacimiento" 
                                                ValidationGroup="Curso"
                                                ForeColor="Red"
                                                runat="server"/>

            </td>
        </tr>
        <tr>
            <td> <asp:Label ID="lblTipo" runat="server" Text="Tipo" /></td>
            <td>
                <asp:DropDownList ID="ddlTipo"
                                  runat="server">
                    <asp:ListItem Text="<< Seleccionar >>" Value="0" Selected="True"/>
                    <asp:ListItem Text="Empleado" Value="1"/>
                    <asp:ListItem Text="Cliente" Value="2"/>
                    <asp:ListItem Text="Proveedor" Value="3"/>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvTipo" 
                                            runat="server" 
                                            ControlToValidate="ddlTipo" 
                                            Display="Dynamic"
                                            ForeColor="Red"
                                            ValidationGroup="Curso"
                                            InitialValue="0"/>
            </td>
        </tr>
        
    </table>
    <div align="center">
        <asp:Button ID="btnAceptar" 
                    runat="server" 
                    ValidationGroup="Curso" 
                    Text="Aceptar"
                    onclick="btnAceptar_Click"  />
        <asp:Button ID="btnCancelar" 
                    runat="server" 
                    Text="Cancelar"
                    CausesValidation="false" onclick="btnCancelar_Click" />
    </div>
    </div>

    <div align="center">
        <asp:Label ID="lblResultado" runat="server" ForeColor="Red" Font-Bold="True" 
            Font-Size="25px" />
    </div>

    <div>
        <asp:HyperLink ID="hlVolverMenu" 
                        runat="server"
                        Text="Menu"
                        NavigateUrl="~/Menu.aspx" ClientIDMode="Inherit" />
    </div>
</asp:Content>

