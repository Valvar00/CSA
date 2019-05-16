
using System;
using WcfServiceLibrary2;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient2.ServiceReference1;
using System.Threading;


namespace WcfServiceClient2
{
    class CallbackHandler : ICallbackBankCallback
    {
        public void BalanceCB(double result)
        {
            Console.WriteLine("  Factorial  =  {0}");
        }
        public void AdditionCB(double result)
        {
            Console.WriteLine("  Calculations:  {0}",result);
        }
        public void WithdrawCB(double result)
        {
            Console.WriteLine("  Calculations:  {0}", result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CallbackHandler myCallbackHandler = new CallbackHandler();
            InstanceContext instanceContext = new InstanceContext(myCallbackHandler);
            CallbackBankClient client2 = new CallbackBankClient(instanceContext);
            Console.WriteLine("...call  of  Factorial()...");
            client2.Balance();
            Console.WriteLine("...call  of  Factorial()...");
            client2.Addition(10000);
            Console.WriteLine("...call  of  calculation  of  something...");
            client2.Withdraw(10000);
            Console.WriteLine("...now  I’m  waiting  for  results");
            client2.Withdraw(20000);
            Thread.Sleep(5000);
            client2.Close();
            Console.WriteLine("CLIENT2  -  STOP");
        }

    }
}
