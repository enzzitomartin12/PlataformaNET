using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerdos2
{
    
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
            //3. Asignaciones de valores no contemplados en la lista de enumerados
            Colores MiColorA = Colores.Verde;
            Colores MiColorB = Colores.Azul;
            Colores MiColorC = (Colores)3;
            Console.WriteLine(MiColorC);

            //4. Evaluación de contenido de la variable enumerada
            Program p = new Program();
            p.Trabajar(MiColorC);
            Console.ReadLine();
            
        }

        public Program() { }
        public void Trabajar(Colores color)
        {
            if (Enum.IsDefined(typeof(Colores), color)) //
                Console.WriteLine(color);
            else
                Console.WriteLine("Tipo no definido, ERROR!");
            
        }
    }
}
