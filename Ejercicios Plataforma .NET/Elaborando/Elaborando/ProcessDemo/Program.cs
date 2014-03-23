using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] p = Process.GetProcesses("systme-machine");

            foreach (Process a in p)
            {
                Console.WriteLine("Procesos corriendo\n");
                string str = string.Format("PID::{0}\tNombre::{1}", a.Id, a.ProcessName);
                Console.WriteLine(str);
                Console.ReadKey();
            }

            Console.ReadLine();
        }
    }
}
