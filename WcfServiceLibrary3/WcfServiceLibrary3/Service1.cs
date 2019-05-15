using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary3
{
    public class myCalculator : ICalculator
    {
        double balance = 5000;
        public double Show()
        {
            return balance;
        }
        public double Withdraw(double n)
        {
            double k = balance;
            balance -= n;
            if (balance < 0)
            {
                balance = k;
                return -1;
            }
            else
            {
                return balance;
            }
        }
        public double Deposit(double n)
        {
            balance += n;
            return balance;
        }
    }
}