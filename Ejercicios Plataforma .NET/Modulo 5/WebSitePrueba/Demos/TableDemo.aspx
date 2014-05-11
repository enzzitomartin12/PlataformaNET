<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableDemo.aspx.cs" Inherits="Demos_TableDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 199px;
        }
        .auto-style3 {
            width: 199px;
        }
        .auto-style4 {
            list-style-type: upper-roman;
        }
    </style>
</head>
<body>
    <table style="width:100%;">
        <tr>
            <td class="auto-style2">Lista con Viñetas</td>
            <td class="auto-style1">
                <ul>
                    <li>Boca</li>
                    <li>River</li>
                    <li>Patronato</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Lista Numerada</td>
            <td>
                <ol class="auto-style4">
                    <li>Coldplay</li>
                    <li>Norah Jones</li>
                    <li>Bruno Mars</li>
                </ol>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Link</td>
            <td>I<a href="http://www.ole.com.ar">r al sitio de Ole</a></td>
        </tr>
    </table>
</body>
</html>
