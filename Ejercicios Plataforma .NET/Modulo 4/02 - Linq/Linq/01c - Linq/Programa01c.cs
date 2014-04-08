using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_4
{
    internal class Programa01c:Programa
    {
        internal override void Ejecutar()
        {
            List<Proyecto> _proyectoList = new List<Proyecto>
            {
                new Proyecto
                {
                    IDProyecto = 10,
                    Nombre = "Sistema A",
                    Descripcion = "Sistema de...",
                    IDCliente = 1
                },
                new Proyecto
                {
                    IDProyecto = 20,
                    Nombre = "Sistema B",
                    Descripcion = "Sistema de tratamiento....",
                    IDCliente = 2
                },
                 new Proyecto
                {
                    IDProyecto = 30,
                    Nombre = "Sistema B",
                    Descripcion = "Sistema de procesamiento...",
                    IDCliente = 1
                }

            };

            //var proyectos = from proy in _proyectoList
            //                where proy.IDCliente == 1
            //                orderby proy.Nombre
            //                select proy;

            //foreach (var proy in proyectos)
            //{
            //    Console.WriteLine("Nombre: {0}, Descripcion: {1}", proy.Nombre, proy.Descripcion);
            //}

            var proyectos = from proy in _proyectoList
                            where proy.IDCliente == 1
                            orderby proy.Nombre
                            select new
                            {
                                Resumen = proy.Nombre + ", " + proy.Descripcion + "\n" + "Cliente: " + proy.IDCliente.ToString()
                            };

            foreach (var proy in proyectos)
            {
                Console.WriteLine(proy.Resumen);
            }
            Console.ReadKey();

        }
    }
}
