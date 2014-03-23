using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int _opcion = -1;
            Modulo2 _miModulo = new Modulo2();

            do
            {
                Console.Clear();
                Console.WriteLine("Programas Demos de la Módulo 2 - La Plataforma de Desarrollo.NET\n");
                Console.WriteLine("Seleccionar un tema:\n");

                Console.WriteLine("1 - Tipos Primitivos");
                Console.WriteLine("2 - Tipos Valor / Referencia");
                Console.WriteLine("3 - Lista de Tipos");
                Console.WriteLine("4 - Declaracion de Constantes y Variables");
                Console.WriteLine("5 - Enumerados");
                Console.WriteLine("6 - Matrices y Arreglos");
                Console.WriteLine("7 - Estructuras");
                Console.WriteLine("8 - Clases");
                Console.WriteLine("9 - Clase Object");
                Console.WriteLine("10 - Ambito");
                Console.WriteLine("11 - Clase Abstracta");
                Console.WriteLine("12 - Interfaces");
                Console.WriteLine("13 - Excepciones");
                Console.WriteLine("14 - Eventos y Delegados");

                Console.WriteLine("0 - Salir");

                try
                {
                    _opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingreso incorrecto. Intente de Nuevo");
                    _opcion = -1;
                }

                switch (_opcion)
                {
                    case 1:
                        _miModulo.MostrarTituloDemo("Demo de Tipos Primitivos");
                        _miModulo.EjecutarPrograma(new Programa01());
                        break;
                    case 2:
                        _miModulo.MostrarTituloDemo("Demo de Tipos Valor y Referencia");
                        _miModulo.EjecutarPrograma(new Programa02());
                        break;
                    case 3:
                        _miModulo.MostrarTituloDemo("Demo de Tipos Valor y Referencia - 2");
                        _miModulo.EjecutarPrograma(new Programa03());
                        break;
                    case 4:
                        _miModulo.MostrarTituloDemo("Demo de Declaracion de Constantes y Variables");
                        _miModulo.EjecutarPrograma(new Programa04());
                        break;
                    case 5:
                        _miModulo.MostrarTituloDemo("Demo de Enumeración - Caso A");
                        _miModulo.EjecutarPrograma(new Programa05a());
                        _miModulo.MostrarTituloDemo("Demo de Enumeración - Caso B");
                        _miModulo.EjecutarPrograma(new Programa05b());
                        break;
                    case 6:
                        _miModulo.MostrarTituloDemo("Demo de Matrices y Arreglos");
                        _miModulo.EjecutarPrograma(new Programa06());
                        break;
                    case 7:
                        _miModulo.MostrarTituloDemo("Demo de Estructuras - A");
                        _miModulo.EjecutarPrograma(new Programa07a());
                        _miModulo.MostrarTituloDemo("Demo de Estructuras - B");
                        _miModulo.EjecutarPrograma(new Programa07b());
                        break;
                    case 8:
                        _miModulo.MostrarTituloDemo("Demo de Clases - Definición");
                        _miModulo.EjecutarPrograma(new Programa08a());
                        _miModulo.MostrarTituloDemo("Demo de Clases - Instaciación");
                        _miModulo.EjecutarPrograma(new Programa08b());
                        break;
                    case 9:
                        _miModulo.MostrarTituloDemo("Demo de Clase Object");
                        _miModulo.EjecutarPrograma(new Programa09());
                        break;
                    case 10:
                        _miModulo.MostrarTituloDemo("Demo de Ambito - A");
                        _miModulo.EjecutarPrograma(new Programa10a());
                        _miModulo.MostrarTituloDemo("Demo de Ambito - B");
                        _miModulo.EjecutarPrograma(new Programa10b());
                        break;
                    case 11:
                        _miModulo.MostrarTituloDemo("Demo de Clase Abstracta");
                        _miModulo.EjecutarPrograma(new Programa11());
                        break;
                    case 12:
                        _miModulo.MostrarTituloDemo("Demo de Interfaces - Usuario");
                        _miModulo.EjecutarPrograma(new Programa12a());
                        _miModulo.MostrarTituloDemo("Demo de Interfaces - Framework");
                        _miModulo.EjecutarPrograma(new Programa12b());
                        break;
                    case 13:
                        _miModulo.MostrarTituloDemo("Demo de Exepciones - A");
                        _miModulo.EjecutarPrograma(new Programa13a());
                        _miModulo.MostrarTituloDemo("Demo de Exepciones - B");
                        _miModulo.EjecutarPrograma(new Programa13b());
                        _miModulo.MostrarTituloDemo("Demo de Exepciones - C");
                        _miModulo.EjecutarPrograma(new Programa13c());
                        break;
                    case 14:
                        _miModulo.MostrarTituloDemo("Demo de Eventos");
                        _miModulo.EjecutarPrograma(new Programa14a());
                        _miModulo.MostrarTituloDemo("Demo de Delegados");
                        _miModulo.EjecutarPrograma(new Programa14b());
                        break;
                }      

            } while (_opcion != 0);

        }
    }

    internal class Modulo2
    {
        internal void MostrarTituloDemo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
        }

        internal void EjecutarPrograma (Programa p)
        {
            p.Ejecutar();
        }
    }

    internal abstract class Programa
    {
        internal abstract void Ejecutar();
    }

}
