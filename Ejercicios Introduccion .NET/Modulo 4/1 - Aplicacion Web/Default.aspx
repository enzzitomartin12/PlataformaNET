<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Default.aspx.cs" CodeFile="~/Default.aspx.cs" Inherits="_Default"  %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
        ForeColor="Red" Text="¡Bienvenido a ASP.NET WEB !"></asp:Label>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Width="328px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Saludar" 
            onclick="Button1_Click1" />
    </p>
    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
