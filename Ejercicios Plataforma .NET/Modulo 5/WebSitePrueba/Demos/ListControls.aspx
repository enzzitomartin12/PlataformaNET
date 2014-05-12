<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListControls.aspx.cs" Inherits="Demos_ListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="C#"></asp:ListItem>
            <asp:ListItem Value="Visual Basic"></asp:ListItem>
            <asp:ListItem Value="CSS"></asp:ListItem>
            <asp:ListItem Value="JScript"></asp:ListItem>
        </asp:DropDownList>
    
    </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="C#"></asp:ListItem>
            <asp:ListItem Value="Visual Basic"></asp:ListItem>
            <asp:ListItem Value="CSS"></asp:ListItem>
            <asp:ListItem Value="JScript"></asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        

    &nbsp;<br />
        <br />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        

    </form>
</body>
</html>
