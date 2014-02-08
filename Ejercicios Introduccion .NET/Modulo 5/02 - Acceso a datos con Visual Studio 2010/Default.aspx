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

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataKeyNames="CustomerID" DataSourceID="SqlDataSource1" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" 
                    SortExpression="CustomerID" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" 
                    SortExpression="CompanyName" />
                <asp:BoundField DataField="Address" HeaderText="Address" 
                    SortExpression="Address" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="Data Source=ELVIRAPC\SQLEXPRESS;Initial Catalog=Northwind;User ID=sa;Password=Admin_123" 
            DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = @CustomerID" 
            InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [Address], [Phone]) VALUES (@CustomerID, @CompanyName, @Address, @Phone)" 
            ProviderName="System.Data.SqlClient" 
            SelectCommand="SELECT [CustomerID], [CompanyName], [Address], [Phone] FROM [Customers]" 
            
            UpdateCommand="UPDATE [Customers] SET [CompanyName] = @CompanyName, [Address] = @Address, [Phone] = @Phone WHERE [CustomerID] = @CustomerID" 
            ondeleted="SqlDataSource1_Deleted" oninserted="SqlDataSource1_Inserted" 
            onupdated="SqlDataSource1_Updated">
            <DeleteParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CustomerID" Type="String" />
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CompanyName" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="CustomerID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
