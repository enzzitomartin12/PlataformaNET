using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace UseVariable
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new Workflow1());
            Console.WriteLine("Presione una letra para continuar...");
            Console.ReadKey();
        }
    }
}
