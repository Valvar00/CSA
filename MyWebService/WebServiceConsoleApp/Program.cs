using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceConsoleApp.ServiceReference1;

namespace WebServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceClient Client = new WebServiceClient();
            Console.WriteLine(Client.Factorial(3));
            Client.Close();
        }
    }
}
