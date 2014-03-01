using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefinicionClases
{
    class Program
    {
        static void Main(string[] args)
        {
            MiPrimeraClase objMiPrimeraClase = new MiPrimeraClase();
            Console.WriteLine(objMiPrimeraClase.nombre);
            Console.ReadLine();
                        
            objMiPrimeraClase.edad = 51;
            Console.WriteLine("Nombre: " + objMiPrimeraClase.nombre);
            Console.WriteLine("Edad: " + objMiPrimeraClase.edad);
            Console.ReadLine();

            Console.WriteLine("Llama MyInfo");
            objMiPrimeraClase.MiInfo();
            Console.ReadLine();

            Console.WriteLine("Llama MyInfo(nombre,edad)");
            Console.WriteLine(objMiPrimeraClase.MiInfo("Franco",12));
            Console.ReadLine();

            objMiPrimeraClase.listarDocentes();
            Console.ReadLine();
            
        }
    }

    class MiPrimeraClase
    {
        //Miembro de la clase
        //1. Campos o artibutos
        public string nombre = "Victor";

        //2. Propiedad
        private int _edad = 0;

        public int edad
        {
            get
            {
                return _edad;
;
            }
            set
            {
                _edad = value;
            }
        }

        //3. Metodos
        public void MiInfo()
        {
            Console.WriteLine(nombre + " tiene " + edad + " años.");
        }

        public string MiInfo(string nombre, int edad)
        {
            return nombre + " tiene " + edad + " años.";
        }

        //4. Propiedad Indexador 
        private string[] _nombreDocentes = new string[] { "Diego", "Marcos", "Victor" };
        public string this[int index]
        {
            get 
            {
                return _nombreDocentes[index];
            }
            set
            {
                _nombreDocentes[index] = value;
            }
        }

        public void listarDocentes()
        {
            foreach (string i in _nombreDocentes)
            {
                Console.WriteLine(i);
            }
         }

    }
}
