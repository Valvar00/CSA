using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary2
{
        [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
        public class myCallbackCalculator : ICallbackBank
        {
            double balance=10000;
            ICallbackHandler callback = null;

            public myCallbackCalculator()
            {
                callback = OperationContext.Current.GetCallbackChannel
                <ICallbackHandler>();
            }
            public void Balance()
            {
                callback.BalanceCB(balance);
            }

            public void Addition(double n)
            {
                balance += n;
                callback.AdditionCB(balance);
            }

            public void Withdraw(double n)
            {
                double temp = balance;
                balance -= n;
            if (balance > 0)
            {
                callback.WithdrawCB(balance);
            }
            else
            {
                balance = temp;
                callback.WithdrawCB(-1);        
            }
        }
    }

        class CallbackHandler : ICallbackHandler
                {
            public void WithdrawCB(double result)
            {
            if (result == -1)
                Console.WriteLine("Balance after withdraw = {0}$", result);
            else
                Console.WriteLine("Incorrect value");   
            }
            public void AdditionCB(double result)
            {
                Console.WriteLine("  Balance after Addition =  {0}$", result);
            }
            public void BalanceCB(double result)
            {
                Console.WriteLine("  Balance  =  {0}$", result);
            }
        }

}
