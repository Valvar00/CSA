
using System;
using WcfServiceLibrary2;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceHost2
{
    class Program
    {
        private const string UriString2 = "http://localhost:20001/Calc3";
        static void Main(string[] args)
        {
            Uri baseAddress2 = new Uri(UriString2);
            ServiceHost myHost2 = new ServiceHost(typeof(myCallbackCalculator), baseAddress2);
            WSDualHttpBinding myBanding2 = new WSDualHttpBinding();

            try
            {
                ServiceEndpoint endpoint2 = myHost2.AddServiceEndpoint(typeof(ICallbackBank), myBanding2, "CallbackKalkulator");
                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                myHost2.Description.Behaviors.Add(smb2);
                myHost2.Open();
                Console.WriteLine("--->CallbackKalkulator  is  running.");
                Console.WriteLine("--->Calculator is running.");
                Console.WriteLine("--->Press <Enter> to stop.\n");
                Console.ReadLine();
                myHost2.Close();
                Console.WriteLine("--->Service finished to work.");
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception Occured: {0}", ce.Message);
                myHost2.Abort();
            }
        }
    }
}
