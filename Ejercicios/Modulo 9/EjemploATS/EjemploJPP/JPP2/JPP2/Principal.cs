using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JPP2;


namespace JPP2 {
	public class Principal {

		public Principal(){

		}

		~Principal(){

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="args"></param>
		private static void Main(string[] args){
            GestorIU miIU = new GestorIU();
            miIU.SeleccionarEntidad();
		}

	}//end Principal

}//end namespace JPP2