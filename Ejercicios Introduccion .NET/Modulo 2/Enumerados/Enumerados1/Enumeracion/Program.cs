using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumeracion
{
    //1.Definir la lista de enumerados
    //enum Colores : byte
    //{
    //    Rojo,
    //    Verde,
    //    Azul
    //}

    //2. Nueva definición 
    [Flags()]
    enum Colores : sbyte
    {
        Rojo = 0,
        Verde = 1,
        Azul = 2,
        Amarillo = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            // 1. Declaracion de variables de enumerados
            //Colores MiColorA = Colores.Verde;
            //Colores MiColorB = Colores.Rojo;
            //Console.WriteLine(MiColorA);
            //Console.WriteLine((int)MiColorB);
           

            // 2. Operaciones con Enumerados
            Colores MiColorA = Colores.Verde;
            Colores MiColorB = Colores.Azul;
            Colores MiColorBitWihise = MiColorA | MiColorB;
            Console.WriteLine("Operacion OR: {0} - {1}", MiColorBitWihise, (sbyte)MiColorBitWihise);
            Colores MiColorBitWihiseB = MiColorA & MiColorB;
            Console.WriteLine("Operacion AND: {0} - {1}", MiColorBitWihiseB, (sbyte)MiColorBitWihiseB);
            Console.ReadLine();



        }
    }
}
