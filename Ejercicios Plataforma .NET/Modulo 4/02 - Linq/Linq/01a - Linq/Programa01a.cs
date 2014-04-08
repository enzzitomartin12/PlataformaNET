using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Modulo_4
{
    internal class Programa01a:Programa
    {
        internal override void Ejecutar()
        {
            #region Ejemplo Básico de LINQ
            //Lista de strings
            string[] colores =
            {
            "Red",
            "Brown",
            "Orange",
            "Yellow",
            "Black",
            "Green",
            "White",
            "Violet",
            "Blue"
            };

            IEnumerable<string> _resultado = from c in colores
                                            where c.StartsWith("B")
                                            orderby c
                                            select c;

            Console.WriteLine("La lista filtrada es:");
            foreach (string s in _resultado)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
