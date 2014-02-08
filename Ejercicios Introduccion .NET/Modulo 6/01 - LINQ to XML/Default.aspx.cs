using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XDocument weatherXML = XDocument.Load(@"c:\parana.xml");
        var resultado = from datos in weatherXML.Descendants("forecast_conditions")
                        select new
                        {
                            dayOfWeek = datos.Element("day_of_week").Attribute("data").Value,
                            low = datos.Element("low").Attribute("data").Value,
                            high = datos.Element("high").Attribute("data").Value,
                            icon = datos.Element("icon").Attribute("data").Value,
                            condition = datos.Element("condition").Attribute("data").Value
                        };

        GridView1.DataSource = resultado;
        GridView1.DataBind();
    }
}