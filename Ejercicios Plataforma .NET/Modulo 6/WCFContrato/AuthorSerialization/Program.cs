using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using AuthorServiceLibrary;
using System.IO;

namespace AuthorSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].Equals("ds"))
                Deserialize();
            else
                Serialize();
        }

        static void Serialize()
        {
            Author author = new Author();
            author.FirstName = "Akshay";
            author.LastName = "Patel";
            author.StartDate = DateTime.Now;
            author.ArticleName = "WCF - Serialization - Day 6";
            using (FileStream fs = new FileStream("author.xml", FileMode.Create))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(Author));
                dcSerializer.WriteObject(fs, author);
            }
        }

        static void Deserialize()
        {
            using (FileStream fs = new FileStream("author.xml", FileMode.Open))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(Author));
                Author author = dcSerializer.ReadObject(fs) as Author;
                Console.WriteLine("Name: {0}, Article: {1}", author.FirstName, author.ArticleName);
            }
        }
    }
}
