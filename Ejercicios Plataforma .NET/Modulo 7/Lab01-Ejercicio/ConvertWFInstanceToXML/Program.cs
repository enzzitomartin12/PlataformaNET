using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Text;
using System.Xaml;
using System.Activities.XamlIntegration;
using System.IO;

namespace ConvertWFInstanceToXML
{

    class Program
    {
        static void Main(string[] args)
        {
            //Create a Workflow instance object
            ActivityBuilder ab = new ActivityBuilder();
            ab.Implementation = new Sequence()
            {
                Activities =
                {
                    new WriteLine{Text="Message from Workflow"}
                }
            };

            //Convert Workflow instance to xml string
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            XamlWriter xw = ActivityXamlServices.CreateBuilderWriter(
                            new XamlXmlWriter(sw,new XamlSchemaContext()));

            XamlServices.Save(xw, ab);
            Console.WriteLine(sb.ToString());

            Console.WriteLine("Presione una letra para continuar...");
            Console.ReadKey();
        }
    }
}
