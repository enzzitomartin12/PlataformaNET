using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace DebugWFProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new Workflow1()
            {

                InMessage = "In Message"
            });
        }
    }
}
