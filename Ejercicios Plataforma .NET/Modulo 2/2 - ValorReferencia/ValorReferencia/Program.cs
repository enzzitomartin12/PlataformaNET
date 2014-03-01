using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Declaración por valor
            int numeroEntero;
            numeroEntero = 10; //Se asigna el valor 10 a la variable entera 
            
            int numeroEnteroB;
            
            numeroEnteroB = numeroEntero; //Se asigna el valor contenido en una variabla a otra
            Console.WriteLine("num 1 {0} - num 2 {1}", numeroEntero, numeroEnteroB);

            //2. Declaracion por referencia
            object tipoRef;
            
            tipoRef = numeroEntero; //Se asigna la dirección de memoria de la variable numeroEntero
            object tipoRefB;
            tipoRefB = tipoRef;

            Console.WriteLine("objeto {0}", tipoRef);
            Console.WriteLine(tipoRef.GetType());

            tipoRef = "Hola";
            Console.WriteLine("objeto {0}", tipoRef);
            Console.WriteLine(tipoRef.GetType());

            Console.ReadLine();

        }
    }
}
