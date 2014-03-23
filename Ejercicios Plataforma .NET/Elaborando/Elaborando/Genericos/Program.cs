using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ArrayList();
            lista.Add(44);
            lista.Add("Hola");

            //int i1 = (int)lista[0];

            foreach (object i2 in lista)
            {
                Console.WriteLine(i2);
            }

            var listaInt = new List<int>();
            listaInt.Add(44);
            listaInt.Add(55);

            //int i1 = (int)lista[0];

            foreach (object i2 in listaInt)
            {
                Console.WriteLine(i2);
            }


            Console.ReadLine();
        }
    }
}
