using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;
using IronMan.Repositorio;
using IronMan.Dominio.AccesoDatos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.Dominio.Modelos;

namespace IronMan.Gestores
{
    public class EventoGestor: IGestor<EventoDTO>,IDisposable
    {
        EventoRepositorio _repositorio;
        IronManContext _ctx;
        Evento _evento;

        public EventoGestor()
        {
            var ctx = new IronManContext();
            _ctx = ctx;
            _repositorio = new EventoRepositorio(_ctx);
        }

        public void Guardar(EventoDTO e)
        {
            try
            {
                if (e.Id > 0)
                {
                    Evento _e;
                    _evento = _repositorio.GetPorId(e.Id);
                    _e = DTOaModelo(e);
                    _evento = _e;
                }
                _evento = DTOaModelo(e);
                _repositorio.Guardar(_evento, _evento.Id);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

        }

        public void Habilitar(EventoDTO e)
        {
            _evento = _repositorio.GetPorId(e.Id);
            _evento.EstaHabilitado = e.EstaHabilitado;
            _repositorio.Guardar(_evento, _evento.Id);
            _ctx.SaveChanges();
        }

        public void Deshabilitar(EventoDTO e)
        {
            _evento = _repositorio.GetPorId(e.Id);
            _evento.EstaHabilitado = e.EstaHabilitado;
            _repositorio.Guardar(_evento, _evento.Id);
            _ctx.SaveChanges();
        }

        public EventoDTO Obtener(int id)
        {
            var _e = _repositorio.GetPorId(id);
            return ModeloaDTO(_e);
        }

        public IList<EventoDTO> Listar()
        {
            IQueryable<Evento> _eLista = _repositorio.GetTodos();
            IList<EventoDTO> _eDTOLista = new List<EventoDTO>();
            
            foreach (Evento e in _eLista)
            {
                _eDTOLista.Add(ModeloaDTO(e));

            }
            return _eDTOLista;
        }

        public bool Validar(EventoDTO _eDTO)
        {
 	        throw new NotImplementedException();
        }

        private Evento DTOaModelo(EventoDTO _eDTO)
        {
            var _evento = new Evento();

            _evento.Nombre = _eDTO.Nombre;
            _evento.Lugar = _eDTO.Lugar;
            _evento.Fecha = _eDTO.Fecha;
            _evento.Comentario = _eDTO.Comentario;
            _evento.EstaHabilitado = _eDTO.EstaHabilitado;

            return _evento;
        }

        private EventoDTO ModeloaDTO(Evento _e)
        {
            var _eDTO = new EventoDTO();
            _eDTO.Id = _e.Id;
            _eDTO.Nombre = _e.Nombre;
            _eDTO.Lugar = _e.Lugar;
            _eDTO.Fecha = _e.Fecha;
            _eDTO.Comentario = _e.Comentario;
            _eDTO.EstaHabilitado = _e.EstaHabilitado;

            return _eDTO;
        }

        public void Dispose()
        { 
            GC.SuppressFinalize(this); 
        }
    }
}
