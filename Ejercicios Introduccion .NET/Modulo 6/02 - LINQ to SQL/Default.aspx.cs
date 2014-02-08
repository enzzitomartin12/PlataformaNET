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
        DataClassesDataContext dc = new DataClassesDataContext();
        var datos = from tablaOrders in dc.Orders
                    group tablaOrders by tablaOrders.CustomerID into g
                    join tablaCustomers in dc.Customers
                    on g.First().CustomerID equals tablaCustomers.CustomerID
                    select new
                    {
                        customerID = tablaCustomers.CustomerID,
                        companyName = tablaCustomers.CompanyName,
                        orders = g.Count()
                    };

        GridView1.DataSource = datos;
        GridView1.DataBind();
    }
}