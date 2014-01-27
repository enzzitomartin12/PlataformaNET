    using System;
    using System.Collections.Generic;
    using System.Linq;
using System.Text;
using Prueba;


namespace EjemploATS
{
    class interfaz
    {
        public void cabecera()
        {
            Console.WriteLine("Prueba de Integración EA y VS");
            Console.WriteLine("-----------------------------");
        }
        public void titulo(String tit)
        {
            Console.WriteLine(tit);
            Console.WriteLine("-----------------------------");
        }


        public class Program
        {

            static void Main(string[] args)
            {
                
                interfaz inter = new interfaz();
                gestorEntidades gEntidades = new gestorEntidades();

                inter.cabecera();
                inter.titulo("Crear Abonado");
                Console.Clear();
                inter.titulo("Crear Pedido");
                gEntidades.seleccionarEntidad();

                Console.Read();


            }
        }
    }
}

