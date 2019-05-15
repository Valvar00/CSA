using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary3
{

    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double Show();
        [OperationContract]
        double Withdraw(double n);
        [OperationContract]
        double Deposit(double n);
    }
}