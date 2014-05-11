<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeInline.aspx.cs" Inherits="Demos_CodeInline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <script runat="server">
            protected void Page_Load(object sender, EventArgs e)
            {
                Label1.Text = "Hola Inline , el dia y la hora es: " + DateTime.Now.ToString();
            }
        </script>
    </div>
    </form>
</body>
</html>
