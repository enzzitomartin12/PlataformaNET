using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IronMan.LibreriaMVP.Views;
using IronMan.DTO;
using IronMan.Gestores;
using IronMan.LibreriaMVP.Presenters;

public partial class IronManWebMVP : System.Web.UI.Page, IEventosListView
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_Init(object sender, EventArgs e)
    {
        var _eGestor = new EventoGestor();
        var _eventoListPresenter = new EventoListPresenter(this, _eGestor);
        LigarComponentes();
    }

    public event Action EventoSeleccionado;

    public event Action Cerrar;

    public IList<EventoDTO> Eventos
    {
        get { return this.listBoxEventos.DataSource as IList<EventoDTO>; }
    }

    public EventoDTO Evento
    {
        get { return null; }
    }

    public void ListarEventos(IList<IronMan.DTO.EventoDTO> eventos)
    {
        this.listBoxEventos.DataSource = eventos;
    }

    public void MostrarEvento(IronMan.DTO.EventoDTO evento)
    {
        this.txtNombre.Text = evento.Nombre;
        this.txtLugar.Text = evento.Lugar;
        this.txtFecha.Text = evento.Fecha.ToString();
        this.txtComentario.Text = evento.Comentario;
    }

    private void LigarComponentes()
    {
        this.listBoxEventos.SelectedIndexChanged += OnEventoListBoxSelectedIndexChanged;

        this.listBoxEventos.DataTextField = "Nombre";
        this.listBoxEventos.DataValueField = "Id";
        this.listBoxEventos.DataBind(); ;
    }

    private void OnEventoListBoxSelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.EventoSeleccionado != null)
        {
            this.EventoSeleccionado();
        }
    }
}