using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection cn;

    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection(@"Data Source=ELVIRAPC\SQLEXPRESS;Initial Catalog=Northwind;User ID=sa;Password=Admin_123");

        if (!Page.IsPostBack)
        {
            Bind();
        }
    }

    private void Bind()
    {
        SqlCommand cmd = new SqlCommand("SELECT c.CustomerID, c.CompanyName, c.Phone, c.Address " +
                                            "FROM Customers c");
        cmd.Connection = cn;

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    private void ShowMessage(string msg)
    {
        string alert = string.Format("alert('{0}');", msg);
        this.ClientScript.RegisterStartupScript(this.GetType(), "AlertError", alert, true);
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        SqlCommand updateCmd = new SqlCommand("UPDATE Customers SET CompanyName = @CompanyName, " +
                                              "                     Phone = @Phone, " +
                                              "                     Address = @Address " +
                                              "WHERE CustomerID = @CustomerID");

        updateCmd.Parameters.AddWithValue("@CompanyName", e.NewValues["CompanyName"]);
        updateCmd.Parameters.AddWithValue("@Phone", e.NewValues["Phone"]);
        updateCmd.Parameters.AddWithValue("@Address", e.NewValues["Address"]);
        updateCmd.Parameters.AddWithValue("@CustomerID", e.Keys["CustomerID"]);

        updateCmd.Connection = cn;

        try
        {
            cn.Open();
            GridView1.EditIndex = -1;
            updateCmd.ExecuteNonQuery();
            cn.Close();

            ShowMessage("Actualizado con éxito");
        }
        catch
        {
            ShowMessage("Se ha producido un error al actualizar, la operación fue cancelada");
        }

        Bind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlCommand deleteCmd = new SqlCommand("DELETE Customers " +
                                              "WHERE CustomerID = @CustomerID");

        deleteCmd.Parameters.AddWithValue("@CustomerID", e.Keys["CustomerID"]);

        deleteCmd.Connection = cn;

        try
        {
            cn.Open();
            deleteCmd.ExecuteNonQuery();
            cn.Close();

            ShowMessage("Eliminado con éxito");
        }
        catch
        {
            ShowMessage("Se ha producido un error al eliminar, la operación fue cancelada");
        }

        Bind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand insertCmd = new SqlCommand("INSERT INTO Customers (CompanyName, Phone, Address, CustomerID) " +
                                              "             VALUES (@CompanyName, @Phone, @Address, @CustomerID)");

        insertCmd.Parameters.AddWithValue("@CompanyName", tbCompanyName.Text);
        insertCmd.Parameters.AddWithValue("@Phone", tbPhone.Text);
        insertCmd.Parameters.AddWithValue("@Address", tbAddress.Text);
        insertCmd.Parameters.AddWithValue("@CustomerID", tbCustomerID.Text);

        insertCmd.Connection = cn;

        try
        {
            cn.Open();
            GridView1.EditIndex = -1;
            insertCmd.ExecuteNonQuery();
            cn.Close();

            ShowMessage("Insertado con éxito");

            tbAddress.Text = string.Empty;
            tbCompanyName.Text = string.Empty;
            tbCustomerID.Text = string.Empty;
            tbPhone.Text = string.Empty;
        }
        catch
        {
            ShowMessage("Se ha producido un error al insertar, la operación fue cancelada");
        }
        
        Bind();
    }
}