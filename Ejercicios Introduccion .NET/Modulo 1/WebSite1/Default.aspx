﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Height="18px" Text="Saludar" 
        Width="247px"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Height="29px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Saludar" 
        Width="127px" />
    <p>
        <asp:Label ID="Label2" runat="server" BackColor="#99CCFF" BorderWidth="2px" 
            Height="146px" Text="Saludo" Width="500px"></asp:Label>
    </p>
    <asp:Calendar ID="Calendar1" runat="server" 
        onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
    </form>
</body>
</html>