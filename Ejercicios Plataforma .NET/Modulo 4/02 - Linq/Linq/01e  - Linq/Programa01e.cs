using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_4
{
    class Programa01e:Programa
    {
        internal override void Ejecutar()
        {
            Proyectos _proy = new Proyectos();
            var ctx = new ProyectosDataContext();
            ManejadorProyectos ManProyectos = new ManejadorProyectos();

            Console.WriteLine("Lista los Proyectos Actuales");
            foreach (var p in  ManProyectos.ObtenerLista(ctx))
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Inserta un nuevo");
            _proy.ID = 9;
            _proy.Titulo = "Reproductor de ....";
            _proy.IDCliente = 1;
            ManProyectos.GuardarProyecto(ctx, _proy);
            foreach (var p in ManProyectos.ObtenerLista(ctx))
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Modifica un proyecto");
            _proy.ID = 6;
            _proy.Titulo = "Generador de ....";
            _proy.IDCliente = 1;
            ManProyectos.ActualizarProyecto(ctx, _proy);
            foreach (var p in ManProyectos.ObtenerLista(ctx))
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Elimina un proyecto");
            ManProyectos.EliminarProyecto(ctx, 3);
            foreach (var p in ManProyectos.ObtenerLista(ctx))
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
