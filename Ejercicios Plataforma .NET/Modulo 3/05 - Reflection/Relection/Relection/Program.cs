using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Ejemplos;

namespace Relection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Validador);
            Console.WriteLine(t.ToString());

            object obj = Activator.CreateInstance(t);
            Console.WriteLine("Se creo {0}", obj);

            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                string retVal = m.ReturnType.FullName;
                ParameterInfo[] pi = m.GetParameters();

                Console.WriteLine("Nombre: {0}, Retorno: {1}", m.Name, retVal);
                foreach (ParameterInfo p in pi)
                {
                    Console.WriteLine("P>:{0}-{1}", p.ParameterType,p.Name);
                }
            }


            MethodInfo metodo = t.GetMethod("OtraOperacion");
            metodo.Invoke(obj, null);

            MethodInfo metododos = t.GetMethod("Operacion");
            var retval = (string)metododos.Invoke(obj, new object[] {34});
            Console.WriteLine("Valor retornado: > {0}:", retval);

            MethodInfo m3 = t.GetMethod("Sumar");
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(3);
            l.Add(7);

            Console.WriteLine(">: {0}", m3.Invoke(obj, new object[] {l}));

            Console.ReadKey();
        }
    }
}
