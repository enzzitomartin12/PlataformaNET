<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Forma 1</td>
                <td>Forma 2</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="CustomerID" HeaderText="customerId" />
                            <asp:BoundField DataField="CompanyName" HeaderText="companyName"/>
                            <asp:TemplateField HeaderText="orders">
                                <ItemTemplate>
                                    <asp:Label runat="server" Text='<%# Eval("Orders.Count") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
