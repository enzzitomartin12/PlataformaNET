using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Ftp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constantes
            
            const string ftpstring = "ftp://ftp.rediris.es";
            const string usuario = "anonimous@nadie.com";

            #endregion 

            #region Acceso a un ftp y lectura del mismo

            FtpWebRequest ftprequest = (FtpWebRequest)FtpWebRequest.Create(ftpstring);
            NetworkCredential credencial = new NetworkCredential(usuario, string.Empty);
            ftprequest.Credentials = credencial;
            ftprequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            StreamReader reader = new StreamReader(ftprequest.GetResponse().GetResponseStream());
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.ReadLine();

            #endregion

        }
    }
}
