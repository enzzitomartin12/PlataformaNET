using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace UseOutArgument
{

    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string,object> output= WorkflowInvoker.Invoke(new Workflow1());
            Console.WriteLine(output["OutMessage"]);
            Console.WriteLine("Presione una letra para continuar...");
            Console.ReadKey();
        }
    }
}
