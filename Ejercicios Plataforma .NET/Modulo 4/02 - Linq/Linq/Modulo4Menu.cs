using System;

namespace Modulo_4
{
	static public class Modulo4Menu
	{

		static public void MostrarMenu()
		{
			int _opcion = -1;

			do
			{
				Console.Clear();
				Console.WriteLine("Programas Demos de la Módulo 3 - La Plataforma de Desarrollo.NET\n");
				Console.WriteLine("Seleccionar un tema:\n");

				Console.WriteLine("1 - LINQ ");
                //Console.WriteLine("2 - Streams");
                //Console.WriteLine("3 - Archivos y Directorios");
                //Console.WriteLine("4 - Acceso a Redes");

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
                    //Modulo4.MostrarTituloDemo("Demo de LINQ - Basicos");
                    //Modulo4.EjecutarPrograma(new Programa01a());
                    //Modulo4.MostrarTituloDemo("Demo de LINQ - Basicos");
                    //Modulo4.EjecutarPrograma(new Programa01b());
                    //Modulo4.MostrarTituloDemo("Demo de LINQ - Basicos");
                    //Modulo4.EjecutarPrograma(new Programa01c());
                    Modulo4.MostrarTituloDemo("Demo de LINQ - Basicos");
					Modulo4.EjecutarPrograma(new Programa01e());
					break;
				case 2:

					break;
				case 3:

					break;
				case 4:

					break;
				}      

			} while (_opcion != 0);
		}

	}

	static internal class Modulo4
	{
		static internal void MostrarTituloDemo(string titulo)
		{
			Console.Clear();
			Console.WriteLine(titulo);
		}

		static internal void EjecutarPrograma (Programa p)
		{
			p.Ejecutar();
		}
	}

	internal abstract class Programa
	{
		internal abstract void Ejecutar();
	}
}

