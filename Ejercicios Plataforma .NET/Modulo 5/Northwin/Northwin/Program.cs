using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Dominio.Models;

namespace Northwin
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new northwindContext())
            {
                var prod = from p in ctx.Products
                           select p;

                foreach (Product p in prod){
                    Console.WriteLine(p.ProductName);
                }
            }
        }
    }
}
