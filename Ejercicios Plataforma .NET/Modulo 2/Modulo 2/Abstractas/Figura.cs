using System;

namespace Abstractas
{
	public abstract class Figura
	{
		public Figura ()
		{
			Console.WriteLine ("Figura Creada");
		}

		public abstract decimal CalcularPerimetro ();


		public abstract decimal CalcularArea ();


		public virtual void InformarDatosGeometricos(){

			Console.WriteLine (this.GetType ());
		}
	}
		
	public class Triangulo:Figura
	{
		public override decimal CalcularArea ()
		{
			throw new NotImplementedException ();
		}

		public override decimal CalcularPerimetro ()
		{
			throw new NotImplementedException ();
		}

	}

}

