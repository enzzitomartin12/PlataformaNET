using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace WorkflowConsoleDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            string o;
            Console.WriteLine("Ejemplo de Windows Workflow Foundation");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Workflow Simple");
            Console.WriteLine("2. Workflow Simple: Secuencia + Flujo");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion >");
            o = Console.ReadLine();

            switch (o)
            {
                case "1":
                    {
                        Console.Clear();
                        WorkflowInvoker.Invoke(new Workflow1());
                        Console.ReadLine();
                        break;
                    }
                case "2":
                    WorkflowInvoker.Invoke(new SegundoWorkflow());
                    Console.ReadLine();
                    break;
           }
            
        }
    }
}
