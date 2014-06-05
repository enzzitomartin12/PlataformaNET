using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class CalculadoraServicio : ICalculadoraServicio
    {

        public double Sumar(double operador1, double operador2)
        {
            return (operador1 + operador2);
        }

        public double Restar(double operador1, double operador2)
        {
            return (operador1 - operador2);
        }

        public double Multiplicar(double operador1, double operador2)
        {
            return (operador1 * operador2);
        }

        public double Dividir(double numerador, double denominador)
        {

            return (numerador / denominador);

        }
    }
}
