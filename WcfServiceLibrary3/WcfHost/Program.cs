using System;
using WcfServiceLibrary3;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:10001/Calc");
            ServiceHost myHost = new ServiceHost(typeof(myCalculator), baseAddress);
            try
            {
                WSHttpBinding myBinding = new WSHttpBinding();
                myHost.AddServiceEndpoint(typeof(ICalculator), myBinding, "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                myHost.Description.Behaviors.Add(smb);
                myHost.Open();
                Console.WriteLine("Service Started");
                Console.WriteLine("Press Enter to dismiss");
                Console.WriteLine();
                Console.ReadLine();
                myHost.Close();
            }
            catch (CommunicationException e)
            {
                Console.WriteLine("Exception occured:{0}", e.Message);
                myHost.Abort();
            }
        }
    }
}