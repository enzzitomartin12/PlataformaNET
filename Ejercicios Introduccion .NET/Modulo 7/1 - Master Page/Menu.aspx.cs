using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Permissions;
using System.Web.Security;

public partial class Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            #region Variable de sesión

            //Nota: Session almacena datos de tipo object, así que al querer manipularlos hay que convertirlos
            //      en este caso utilizamos el método ToString.
            if (Session["usuario"] != null)
                lbUsuario.Text = Session["usuario"].ToString();

            LlenarGrilla();
            LlenarOpciones();
            #endregion

            #region Variable de Aplicación

            if (Application["global"] == null)
            {
                Application["global"] = "Application Variable";
            }
            lblVariableGlobal.Text = Application["global"].ToString();

            #endregion 

            //if (Cache["archivo"]== null)
            //Cache.Insert("archivo", dato, new System.Web.Caching.CacheDependency("c:\Interfaz-Telefonica.txt"));

        }
    }

    //Autorización Declarativa
    [PrincipalPermission(SecurityAction.Demand, Authenticated=true)]
    public static string DameHora(HttpContext context)
    {
        return DateTime.Now.ToLongTimeString();
    }

    //Autorización Declarativa
    [PrincipalPermission(SecurityAction.Demand, Role="Rol")]
    public void ConsultarDatos()
    { 
        //Autorización Imperativa
        if (User.IsInRole("Administrador"))
        {
            int a = 0;
        }
    }

    private void LlenarGrilla()
    {
        if (ddlRoles.SelectedValue == string.Empty)
            gvUsuarios.DataSource = Membership.GetAllUsers();
        else
        {
            List<string> rol = new List<string>();
            rol.Add(ddlRoles.SelectedValue);
            gvUsuarios.DataSource = FindUsersByRole(rol.ToArray());
        }
            
        gvUsuarios.DataBind();
    }

    private void LlenarOpciones()
    {
        List<ListItem> item = new List<ListItem>();
        item.Add(new ListItem { Value = string.Empty, Text = "<Seleccionar>", Selected = true });
        foreach (string rol in Roles.GetAllRoles())
        {
            item.Add(new ListItem{ Value = rol, Text = rol});
        }

       
        ddlRoles.DataSource = item;
        ddlRoles.DataBind();
    }

    protected void ddlRoles_SelectedIndexChanged(object sender, EventArgs e)
    {
        LlenarGrilla();
    }

    public static MembershipUserCollection FindUsersByRole(string[] roles)
    {
        MembershipUserCollection msc = new MembershipUserCollection();

        roles.Select(role => Roles.GetUsersInRole(role))
        .Aggregate((a, b) => a.Union(b).ToArray())
        .Distinct()
        .Select(user => Membership.GetUser(user))
        .ToList().ForEach(user => msc.Add(user));

        return msc;
    }

}