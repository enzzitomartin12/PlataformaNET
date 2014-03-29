using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Juan", "Perez"));
            clientes.Add(new Cliente("Pedro", "Gomez"));
            clientes.Add(new Cliente("Piojo", "Lopez"));

            // Se puede recorrer con un For o con un Foreach
            for (int i = 0; i <= clientes.Count - 1; i++)
            {
                Console.WriteLine(clientes[i].ToString());
            }
            Console.ReadKey();

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Clase Cliente
    /// </summary>
    /// <remarks>
    /// Esta clase se puede clasificar por el campo Apellidos
    /// </remarks>
    public class Cliente : System.IComparable
    {
        public string Nombre;
        public string Apellidos;

        public Cliente(string nombre)
        {
            this.Nombre = nombre;
        }
        public Cliente(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public override string ToString()
        {
            return Apellidos + ", " + Nombre;
        }

        public int CompareTo(object obj)
        {
            if (obj is Cliente)
            {
                Cliente cli = (Cliente)obj;
                return string.Compare(this.Apellidos, cli.Apellidos);
            }
            else
                return 0;
        }
    }
}
