using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void ShowMessage(string msg)
    {
        string alert = string.Format("alert('{0}');", msg);
        this.ClientScript.RegisterStartupScript(this.GetType(), "AlertError", alert, true);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataSource1.InsertParameters["CustomerID"].DefaultValue = tbCustomerID.Text;
        SqlDataSource1.InsertParameters["CompanyName"].DefaultValue = tbCompanyName.Text;
        SqlDataSource1.InsertParameters["Address"].DefaultValue = tbAddress.Text;
        SqlDataSource1.InsertParameters["Phone"].DefaultValue = tbPhone.Text;

        tbAddress.Text = string.Empty;
        tbCompanyName.Text = string.Empty;
        tbCustomerID.Text = string.Empty;
        tbPhone.Text = string.Empty;

        SqlDataSource1.Insert();
    }

    protected void SqlDataSource1_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
        if (e.Exception == null)
        {
            ShowMessage("Insertado con éxito");
        }
        else
        {
            ShowMessage("Se ha producido un error al insertar, la operación fue cancelada");
            e.ExceptionHandled = true;
        }
    }

    protected void SqlDataSource1_Updated(object sender, SqlDataSourceStatusEventArgs e)
    {
        if (e.Exception == null)
        {
            ShowMessage("Actualizado con éxito");
        }
        else
        {
            ShowMessage("Se ha producido un error al actualizar, la operación fue cancelada");
            e.ExceptionHandled = true;
        }
    }

    protected void SqlDataSource1_Deleted(object sender, SqlDataSourceStatusEventArgs e)
    {
        if (e.Exception == null)
        {
            ShowMessage("Eliminado con éxito");
        }
        else
        {
            ShowMessage("Se ha producido un error al eliminar, la operación fue cancelada");
            e.ExceptionHandled = true;
        }
    }
}