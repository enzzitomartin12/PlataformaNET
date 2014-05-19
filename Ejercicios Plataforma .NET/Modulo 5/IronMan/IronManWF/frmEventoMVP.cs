using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronMan.LibreriaMVP.Views;
using IronMan.DTO;

namespace IronManWF
{
    public partial class frmEventoMVP : Form, IEventosListView
    {

        public frmEventoMVP()
        {
            InitializeComponent();
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
            get { return  this.listBoxEventos.SelectedItem as EventoDTO; }
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
            this.btnCerrar.Click += OnCloseButtonClick;
            this.listBoxEventos.SelectedIndexChanged += OnEventoListBoxSelectedIndexChanged;

            this.listBoxEventos.DisplayMember = "Nombre";
            this.listBoxEventos.ValueMember = "Id";
        }

        private void OnEventoListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.EventoSeleccionado != null)
            {
                this.EventoSeleccionado();
            }
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            if (this.Cerrar != null)
            {
                this.Cerrar();
            }
        }
    }
}
