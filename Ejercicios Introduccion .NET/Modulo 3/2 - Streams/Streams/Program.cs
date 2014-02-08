using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string archivo = @"c:\test.txt";
            program.EscribirArchivo(archivo, "Ejemplo de guardar un stream en .net");

            Console.WriteLine(program.LeerArchivo(archivo));
            Console.ReadKey();
        }

        public void EscribirArchivo(string archivo, string dato)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter stream = new StreamWriter(fs);
            stream.Write(dato);
            stream.Close();
            Console.WriteLine("Archivo guardado con éxito.");
        }

        public string LeerArchivo(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

            StreamReader stream = new StreamReader(fs);
            string datos = stream.ReadToEnd();
            stream.Close();

            return datos;
        }
    }
}
