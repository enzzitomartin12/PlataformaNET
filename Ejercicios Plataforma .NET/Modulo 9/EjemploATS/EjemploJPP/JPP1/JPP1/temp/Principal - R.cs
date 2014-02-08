using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JPP1
{
    class Principal
    {
        

        static void Main(string[] args)
        {//Muestra Menu Inicial
            int opcion;
            //GestorAbonado unGestorAbonado = new GestorAbonado();

            Console.Clear();
            Console.WriteLine("Ejemplo de Aplicacion");
            Console.WriteLine("---------------------");

            Console.WriteLine("Seleccionar");
            Console.WriteLine("Tratar Abonado: 1");
            Console.WriteLine("Tratar Pedido: 2");
            Console.WriteLine("Salir: 0");

            Console.Write("Opcion:");
            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion != 0)
            {

                if (opcion == 1)
                {
                    Console.WriteLine("Abonado");
                    //unGestorAbonado.crearAbonado();
                    //unGestorAbonado.llenarAbonado();
                    //unGestorAbonado.mostrarAbonado();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Pedido");
                    Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("Ejemplo de Aplicacion");
                Console.WriteLine("---------------------");

                Console.WriteLine("Seleccionar");
                Console.WriteLine("Tratar Abonado: 1");
                Console.WriteLine("Tratar Pedido: 2");
                Console.WriteLine("Salir: 0");

                Console.Write("Opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
