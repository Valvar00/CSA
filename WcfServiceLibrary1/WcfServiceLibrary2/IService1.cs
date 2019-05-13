using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
        [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallbackHandler))]
        public interface ICallbackCalculator
        {
            [OperationContract(IsOneWay = true)]
            void Factorial(double n);
            [OperationContract(IsOneWay = true)]
            void CalcSomething(int sek);
        }
        [ServiceContract]
        public interface ICallbackHandler
        {
            [OperationContract(IsOneWay = true)]
            void FactorialCB(double result);
            [OperationContract(IsOneWay = true)]
            void CalcSomethingCB(string result);
        }
}