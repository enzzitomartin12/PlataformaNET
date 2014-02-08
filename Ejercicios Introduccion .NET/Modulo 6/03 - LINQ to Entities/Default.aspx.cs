using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindEntities context = new NorthwindEntities();

        #region forma 1

        var datos = from entidadCustomers in context.Customers
                    where entidadCustomers.Orders.Count() > 10
                    select new
                    {
                        customerId = entidadCustomers.CustomerID,
                        companyName = entidadCustomers.CompanyName,
                        orders = entidadCustomers.Orders.Count()
                    };

        GridView1.DataSource = datos;
        GridView1.DataBind();

        #endregion forma 1

        #region forma 2

        var datos2 = context.Customers.Where(x => x.Orders.Count > 10);

        GridView2.DataSource = datos2;
        GridView2.DataBind();

        #endregion forma 2

        
    }
}