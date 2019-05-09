using System;
using WcfService;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceHost
{
    class Program
    {
        private const string UriString = "http://localhost:10004/Calc";

        static void Main(string[] args)
        {
            Uri baseAddress = new Uri(UriString);
            Console.WriteLine("This is URI {0}",baseAddress);
            ServiceHost myhost = new ServiceHost(typeof(myCalculator), baseAddress);
            try
            {
                WSHttpBinding myBandig = new WSHttpBinding();
                myhost.AddServiceEndpoint(typeof(ICalculator), myBandig, "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                myhost.Description.Behaviors.Add(smb);
                myhost.Open();
                Console.WriteLine("Service started.");
                Console.WriteLine("Press <Enter> to dismiss");
                Console.WriteLine();
                Console.ReadLine();
                myhost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception occured:{0}", ce.Message);
                myhost.Abort();
            }
        }
    }
}
