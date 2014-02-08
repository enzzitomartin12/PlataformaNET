using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace UseInArgument
{

    class Program
    {
        static void Main(string[] args)
        {
            //IDictionary<string, object> inputDictionary = new Dictionary<string, object>()
            //{
            //    {"Nombre", "Alejo"},
            //    {"Apellido", "Valotto"}
            //};
            //WorkflowInvoker.Invoke(new Workflow1(), inputDictionary);

            WorkflowInvoker.Invoke(new Workflow1()
            {
                Nombre = "Victor",
                Apellido = "Valotto"
            });

            Console.WriteLine("Presione una letra para continuar...");
            Console.ReadKey();
        }
    }
}
