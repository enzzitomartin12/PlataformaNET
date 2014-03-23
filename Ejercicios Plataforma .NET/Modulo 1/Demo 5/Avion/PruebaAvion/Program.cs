using System;
using IntegracionAvion;

namespace IntegracionAvion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Avion miAvion = new Avion ();

			miAvion.DoblarDerecha ();
			miAvion.AplicarFrenos ();
			miAvion.DoblarIzquierda ();

			Console.ReadLine ();
		}
	}
}
