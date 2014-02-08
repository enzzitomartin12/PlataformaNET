using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TipoPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definiciones de Tipo de datos primitivos

            //Tipo de Datos numericos
            //1. Numerico entero

            int numeroEntero; //tamaño = 32
            System.Int32 numeroEntero2; //Definición en la Plataforma .NET

            short numeroCorto;  //tamaño = 16
            long numeroLargo; //tamaño = 64

            //2. Numerico sin signo

            uint numeroEnteroSinSigno; //tamaño = 32
            ushort numeroCortoSinSigno; //tamaño = 16
            ulong numeroLargoSinSigno; //tamaño = 32

            //3. Numerico racional
            float numeroComaFlotantePresicion1; //tamaño = 16
            double numeroComaFlotantePrecision2; //tamaño = 32
            decimal numeroDecimal; // Tamaño = 128  


            //4. Bytes
            byte nByte; //tamaño = 8
            sbyte nByteConSigno; //tamaña = 8

            //5. Caracteres
            char caracter;// tamaño = 16
            string cadenaTexto;

            //6. Booleano
            bool tipoBooleano; //tamaño = 8

            
            //7. Uso de lso tipos definidos en el framework
            System.Int64 numero = 111323241;

            //Conversiones de tipos primitivos
            numeroCorto = 12;
            numeroEntero = numeroCorto;
            numeroEnteroSinSigno = (uint)numeroCorto;
            numeroComaFlotantePrecision2 = numeroCorto;

            numeroLargo = 12L;

            //Funciones de Conversion
            cadenaTexto = Convert.ToString (numero);

            caracter = '3';
            nByte = Convert.ToByte(caracter);

            
            Console.WriteLine("Es numero: " + numero);
            Console.WriteLine("Es texto: " + cadenaTexto);
            Console.ReadLine();



        }
    }
}
