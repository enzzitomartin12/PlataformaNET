using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.IronManEventoServicio;

namespace IronMan
{
    class Program
    {
        static void Main(string[] args)
        {

            IronManEventoServicio.EventoServicioClient _servicio = new IronManEventoServicio.EventoServicioClient();

            Console.WriteLine(_servicio.ObtenerNombreEvento(1));
            var eventos = _servicio.Listar().ToList();

            foreach (Evento e in eventos)
            {
                Console.WriteLine("> Nombre: {0}", e.Nombre);
                Console.WriteLine("> Lugar: {0}", e.Lugar);
                Console.WriteLine("> Fecha: {0}", e.Fecha.ToString());
                Console.WriteLine("> Comentario: {0}", e.Comentario);
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }

        private void MostarEvento(EventoServicioClient servicio, int Id)
        {
            Console.Clear();
            Console.WriteLine("Obtener un Evento");
            #region Obtener un evento
            var _e = servicio.ObtenerNombreEvento(Id);


            //foreach (Prueba p in _e.Pruebas)
            //{
            //    Console.WriteLine("    >" + p.Tipo);
            //    Console.WriteLine("    >" + p.Distancia);
            //    Console.WriteLine("    >" + p.Evento_Id);
            //    Console.WriteLine("    >" + p.Evento);
            //    Console.WriteLine("    >" + p.EstaHabilitado);
            //    Console.WriteLine("------------------------");
            //}
            #endregion
            Console.ReadKey();
        }

 
    }
}
