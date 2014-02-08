using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoIL
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            StringBuilder s = new StringBuilder();

            for (i = 32; i <= 255; i++)
                s.Append(char.ConvertFromUtf32(i));
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
