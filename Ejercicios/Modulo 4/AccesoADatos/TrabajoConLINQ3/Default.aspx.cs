using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoConLINQ3
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var miContexto = new ProyectosEntities1();

            var datos = from tProyectos in miContexto.Proyectos
                        from tClientes in miContexto.Clientes
                        where tClientes.IDCliente == tProyectos.IDCliente
                        orderby tProyectos.Nombre
                        select new
                        {
                            tProyectos.Nombre,
                            tProyectos.Descripcion,
                            tClientes.Web

                        };
            this.GridView1.DataSource = datos;
            this.GridView1.DataBind();
        }
    }
}
