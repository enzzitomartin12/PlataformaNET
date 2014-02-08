using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploIntegracion;

namespace IntegracionAvion
{
    public class Avion : Vehiculo
    {
        public override void DoblarDerecha()
        {
            Console.WriteLine("El avión dobla a la derecha");
        }
        public override void DoblarIzquierda()
        {
            Console.WriteLine("El avión dobla a la Izquiera");
        }
        public override void AplicarFrenos()
        {
            Console.WriteLine("El avión está frenando");
        }
    }
}
