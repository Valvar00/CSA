using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
        [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
        public class myCallbackCalculator : ICallbackCalculator
        {
            double result;
            ICallbackHandler callback = null;

            public myCallbackCalculator()
            {
                callback = OperationContext.Current.GetCallbackChannel
                <ICallbackHandler>();
            }
            public void CalcSomething(int sek)
            {
                Console.WriteLine("...call  of  CalcSomething({0})", sek);
                if (sek < 10) Thread.Sleep(sek * 1000);
                else
                    Thread.Sleep(1000);
                callback.CalcSomethingCB("Calculatons  lasted  " + (sek + 1) + "  second(s)");
            }
            public void Factorial(double n)
            {
                Console.WriteLine("...call  of  Factorial({0})", n); Thread.Sleep(1000);
                result = 1;
                for (int i = 1; i <= n; i++)
                    result *= i;
                callback.FactorialCB(result);
            }
        }

        class CallbackHandler : ICallbackHandler
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

}
