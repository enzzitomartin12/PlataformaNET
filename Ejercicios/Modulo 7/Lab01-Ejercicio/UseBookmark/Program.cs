using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Threading;

namespace UseBookmark
{

    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent syncEvent = new AutoResetEvent(false);
            string bookmarkName = "GreetingBookmark";

            WorkflowApplication wfApp = new WorkflowApplication(new Workflow1()
            {
                BookmarkNameInArg = bookmarkName
            });

            wfApp.Completed = delegate(
            WorkflowApplicationCompletedEventArgs e)
            {
                syncEvent.Set();
            };

            wfApp.Run();
            wfApp.ResumeBookmark(bookmarkName, Console.ReadLine());
            syncEvent.WaitOne();
        }
    }
}
