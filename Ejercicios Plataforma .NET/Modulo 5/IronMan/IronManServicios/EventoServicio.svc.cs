using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IronMan.Dominio;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManServicios
{

    public class EventoServicio : IEventoServicio
    {
        public string ObtenerNombreEvento(int id)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = new EventoDTO();

            _eDTO = _eGestor.Obtener(id);
            return _eDTO.Nombre;

        }

        public void Guardar(Evento e)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = new EventoDTO();

            _eDTO.Id = e.Id;
            _eDTO.Nombre = e.Nombre;
            _eDTO.Lugar = e.Lugar;
            _eDTO.Fecha = e.Fecha;
            _eDTO.Comentario = e.Comentario;
            _eDTO.EstaHabilitado = e.EstaHabilitado;

            _eGestor.Guardar(_eDTO);
        }

        public void Deshabilitar(Evento e)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = new EventoDTO();

            _eDTO.Id = e.Id;
            _eDTO.Nombre = e.Nombre;
            _eDTO.Lugar = e.Lugar;
            _eDTO.Fecha = e.Fecha;
            _eDTO.Comentario = e.Comentario;
            _eDTO.EstaHabilitado = e.EstaHabilitado;

            _eGestor.Deshabilitar(_eDTO);
        }

        public void Habilitar(Evento e)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = new EventoDTO();

            _eDTO.Id = e.Id;
            _eDTO.Nombre = e.Nombre;
            _eDTO.Lugar = e.Lugar;
            _eDTO.Fecha = e.Fecha;
            _eDTO.Comentario = e.Comentario;
            _eDTO.EstaHabilitado = e.EstaHabilitado;

            _eGestor.Habilitar(_eDTO);
        }


        public Evento Obtener(int id)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = _eGestor.Obtener(id);
            return DTOaEvento(_eDTO);
        }

        public List<Evento> Listar()
        {
            List<Evento> _lista = new List<Evento>();
            EventoGestor _eGestor = new EventoGestor();

            foreach (EventoDTO _eDTO in _eGestor.Listar().ToList())
            {
                _lista.Add(DTOaEvento(_eDTO));
            }
            return _lista;
        }

        private Evento DTOaEvento(EventoDTO _eDTO)
        {
            Evento _e = new Evento();
            _e.Id = _eDTO.Id;
            _e.Nombre = _eDTO.Nombre;
            _e.Lugar = _eDTO.Lugar;
            _e.Fecha = _eDTO.Fecha;
            _e.Comentario = _eDTO.Comentario;
            _e.EstaHabilitado = _eDTO.EstaHabilitado;
            return _e;
        }

    }
}
