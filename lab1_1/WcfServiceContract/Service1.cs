using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class myCalculator : ICalculator
    {
        double balance = 10000;
        public double Deposit(double n1)
        {
            Console.WriteLine("Deposit has been performed");
            balance = balance + n1;
            return balance;
        }
        public double Withdraw(double n1)
        {
            double temp = balance;
            Console.WriteLine("Withdraw has been performed");
            balance = balance - n1;
            if (balance > 0)
            {
                return balance;
            }
            else
            {
                balance = temp;
                return -1;
            }
        }
        public double Show()
        {
            Console.WriteLine("Show balance has been performed");
            return balance;
        }
    }
}
