<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Módulo 5 - Acceso a datos manual</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    Customer ID
                </td>
                <td>
                    Company Name
                </td>
                <td>
                    Phone
                </td>
                <td>
                    Address
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="tbCustomerID" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:TextBox ID="tbCompanyName" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
                </td>                
                <td>
                    <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Guardar" 
                        onclick="Button1_Click" />
                </td>
            </tr>
        </table>

        <br />

        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" DataKeyNames="CustomerID">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
