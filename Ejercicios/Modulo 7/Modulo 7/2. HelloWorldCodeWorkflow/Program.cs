using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Activities.Statements;

namespace HelloWorldCodeWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new HelloWorkflow());
            Console.WriteLine("Presione una letra para continuar...");
            Console.ReadKey();
        }

        public class HelloWorkflow : Activity
        {
            public HelloWorkflow()
            {
                this.Implementation = () => new Sequence
                {
                    Activities = {
                                    new WriteLine(){Text="Hola Workflow 4 - Soy una actividad Codificada"}
                                 }
                };
            }
        }
    }
}
