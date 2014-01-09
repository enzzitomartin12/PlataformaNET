using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Threading;
using System.Collections.Generic;

namespace UseWorkflowApplicaton
{

    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            IDictionary<string, object> input = new Dictionary<string, object>()
            { 
                {"Number1", 123},
                {"Number2", 456}
            };

            IDictionary<string, object> output = null;

            WorkflowApplication wfApp = new WorkflowApplication(new Workflow1(), input);
            wfApp.Completed = delegate(WorkflowApplicationCompletedEventArgs e)
            {
                Console.WriteLine("Workflow thread id:" + Thread.CurrentThread.ManagedThreadId);
                output = e.Outputs;
                syncEvent.Set();
            };

            wfApp.Run();
            syncEvent.WaitOne();
            Console.WriteLine(output["Result"].ToString());
            Console.WriteLine("Host thread id:" + Thread.CurrentThread.ManagedThreadId);

            WorkflowInvoker.Invoke(new Workflow1());
            Console.WriteLine("Presione una letra para continuar...");
            Console.ReadKey();
        }
    }
}
