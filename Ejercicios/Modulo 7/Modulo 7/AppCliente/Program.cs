using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ServiceReference1.ServiceClient();
            string data = proxy.GetData(42);

            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
