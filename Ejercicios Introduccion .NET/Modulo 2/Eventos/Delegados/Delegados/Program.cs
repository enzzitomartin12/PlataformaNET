using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegados
{
    class Program
    {
        delegate void Saludar(string Nombre);
        
        public Program()
        {
            Saludar Saludo = new Saludar(MostrarSaludo);
            Saludo += new Saludar(SaludoDespedir);
            Saludo("Alejo");
            Saludo -= new Saludar(SaludoDespedir);
            Saludo("Alejo");     
        }

        private void MostrarSaludo (string Nombre)
        {
            Console.WriteLine("Hola {0}", Nombre);
        }

        private void SaludoDespedir(string Nombre)
        {
            Console.WriteLine("Adios {0}", Nombre);
        }
                
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadLine();
        }
    }
}
