using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ambito2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            
        }
    }

    public class Persona
    {
        protected string nombre = string.Empty;
    }

    public class cliente : Persona
    {
        public cliente()
        {
            this.nombre = "Sin nombre";
        }
    }
}
