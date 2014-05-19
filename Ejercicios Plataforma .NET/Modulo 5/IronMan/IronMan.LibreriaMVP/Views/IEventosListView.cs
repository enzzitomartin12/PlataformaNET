using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;

namespace IronMan.LibreriaMVP.Views
{
    public interface IEventosListView
    {
        event Action EventoSeleccionado;
        event Action Cerrar;

        IList<EventoDTO> Eventos { get; }
        EventoDTO Evento { get; }

        void ListarEventos(IList<EventoDTO> eventos);
        void MostrarEvento(EventoDTO evento);
    }
}
