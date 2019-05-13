
using System;
using WcfServiceLibrary1;
using WcfServiceLibrary2;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient2.ServiceReference1;
using WcfServiceClient2.ServiceReference2;
using System.Threading;


namespace WcfServiceClient2
{
    class CallbackHandler : ICallbackCalculatorCallback
    {
        public void FactorialCB(double result)
        {
            //tu  mozna  wykorzystać  result
            Console.WriteLine("  Factorial  =  {0}", result);
        }
        public void CalcSomethingCB(string info)
        {
            //tu  mozna  wykorzystać  info
            Console.WriteLine("  Calculations:  {0}", info);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client1 = new CalculatorClient("WSHttpBinding_ICalculator");
            ComplexNum lz1 = new ComplexNum(1.2,3.4);
            ComplexNum lz2 = new ComplexNum(1.2,3.4);
            Console.WriteLine("\nClient1");
            Console.WriteLine("...called addCNum(...)");
            ComplexNum result1 = client1.addCNum(lz1, lz2);
            Console.WriteLine("addCNum(...) = ({0},{1})", result1.realPart, result1.imagPart);
            Console.WriteLine("Client1 - STOP");
            Console.WriteLine("...call  of  function  1:");
            client1.Function1("Client1");
            Thread.Sleep(10);
            Console.WriteLine("...continue  after  function  1  call");
            Console.WriteLine("...call  of  function  2:");
            client1.Function2("Client1");
            Thread.Sleep(10);
            Console.WriteLine("...continue  after  function  2  call");
            Console.WriteLine("...call  of  function  1:");
            client1.Function1("Client1");
            Thread.Sleep(10);
            Console.WriteLine("...continue  after  function  1  call");
            client1.Close();
            Console.WriteLine("CLIENT1  -  STOP");
            Console.WriteLine("\nCLIENT2:");
            CallbackHandler myCallbackHandler = new CallbackHandler();
            InstanceContext instanceContext = new InstanceContext(myCallbackHandler);
            CallbackCalculatorClient client2 = new CallbackCalculatorClient(instanceContext);
            double value1 = 10;
            Console.WriteLine("...call  of  Factorial({0})...", value1);
            client2.Factorial(value1);
            value1 = 20;
            Console.WriteLine("...call  of  Factorial({0})...", value1);
            client2.Factorial(value1);
            int value2 = 2;
            Console.WriteLine("...call  of  calculation  of  something...");
            client2.CalcSomething(value2); Console.WriteLine("...now  I’m  waiting  for  results");
            Thread.Sleep(5000);
            client2.Close();
            Console.WriteLine("CLIENT2  -  STOP");
        }

    }
}
