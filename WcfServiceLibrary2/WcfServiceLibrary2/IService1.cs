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
        public interface ICallbackBank
        {
            [OperationContract(IsOneWay = true)]
            void Addition(double n);
            [OperationContract(IsOneWay = true)]
            void Withdraw(double n);
            [OperationContract(IsOneWay = true)]
            void Balance();
        }
        [ServiceContract]
        public interface ICallbackHandler
        {
            [OperationContract(IsOneWay = true)]
            void AdditionCB(double result);
            [OperationContract(IsOneWay = true)]
            void BalanceCB(double result);
            [OperationContract(IsOneWay = true)]
            void WithdrawCB(double result);
    }
}