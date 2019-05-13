
using System;
using WcfServiceLibrary1;
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
        private const string UriString1 = "http://localhost:10006/Calc1";
        private const string UriString2 = "http://localhost:20006/Calc2";
        static void Main(string[] args)
        {
            Uri baseAddress1 = new Uri(UriString1);
            ServiceHost myhost1 = new ServiceHost(typeof(MyCalculator), baseAddress1);
            Uri baseAddress2 = new Uri(UriString2);
            ServiceHost myHost2 = new ServiceHost(typeof(myCallbackCalculator), baseAddress2);
            WSDualHttpBinding myBanding2 = new WSDualHttpBinding();

            try
            {
                ServiceEndpoint endpoint2 = myHost2.AddServiceEndpoint(typeof(ICallbackCalculator), myBanding2, "CallbackKalkulator");
                ServiceEndpoint endpoint1 = myhost1.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                myHost2.Description.Behaviors.Add(smb2);
                myhost1.Description.Behaviors.Add(smb);
                myhost1.Open();
                myHost2.Open();
                Console.WriteLine("--->CallbackKalkulator  is  running.");
                Console.WriteLine("--->Calculator is running.");
                Console.WriteLine("--->Press <Enter> to stop.\n");
                Console.ReadLine();
                myhost1.Close();
                myHost2.Close();
                Console.WriteLine("--->Service finished to work.");
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception Occured: {0}", ce.Message);
                myhost1.Abort();
                myHost2.Abort();
            }
        }
    }
}
