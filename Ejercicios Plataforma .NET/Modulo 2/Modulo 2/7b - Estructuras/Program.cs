using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{

    class Program
    {

        static void Main(string[] args)
        {
            Persona p = new Persona("Alejo", "Valotto", 5, genero.Masculino);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
