﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j ;
            int res;

            try 
            {
                Console.Write("Un numero:");
                i = Convert.ToInt32 (Console.ReadLine());
                Console.Write("Otro numero:");
                j = Convert.ToInt32 (Console.ReadLine());
                res = i/j;
                Console.WriteLine(res.ToString());
            }

            catch  (FormatException)
            {
		            Console.WriteLine ("El ingreso de datos no está en el formato correcto");
            }

            catch  (DivideByZeroException ex)
            {
		            Console.WriteLine ("Division por 0. Error");
            }

            catch (Exception ex)
            {
	            Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadLine();

        }
    }
}