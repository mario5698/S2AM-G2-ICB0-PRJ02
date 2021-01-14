using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edi_Proces;

namespace DownloadFromFtp
{
    class Program
    {
        static void Main(string[] args)
        {
            
         Procesar_Edi edi = new Procesar_Edi();

            string conectar, DocumentName;

          //  string descargar;

            Console.WriteLine("You want to connect to the ftp server");
            conectar = (Console.ReadLine()).ToString();
           Console.WriteLine( edi.ConnectFtpserver());
            Console.WriteLine(edi.listdocuments());
            DocumentName =  Console.ReadLine().ToString();

             Console.WriteLine(edi.getFileFromFPTServer(DocumentName));

            Console.ReadKey();







          
        }
    }
}
