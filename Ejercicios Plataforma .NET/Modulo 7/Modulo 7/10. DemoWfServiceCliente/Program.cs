using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoWfServiceCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ServiceReference1.mathClient();
            
            var data = proxy.Sumar(3, 89);

            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
