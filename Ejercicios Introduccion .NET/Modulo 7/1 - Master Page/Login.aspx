<%@ Page Language="C#" 
         AutoEventWireup="true" 
         CodeFile="Login.aspx.cs" 
         CodeBehind="~/Login.aspx.cs"
         Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Técnicas avanzadas de ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Login ID="lgCurso" 
                   runat="server" 
                   BackColor="#F7F7DE" 
                   BorderColor="#CCCC99" 
                   BorderStyle="Solid" 
                   BorderWidth="1px" 
                   Font-Names="Verdana" 
                   Font-Size="10pt" 
                   Height="158px" 
                   onauthenticate="lgCurso_Authenticate"
                   DestinationPageUrl="~/Menu.aspx" 
                   Width="339px">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </div>
    </form>
</body>
</html>
