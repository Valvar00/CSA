﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceClient2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICallbackBank", CallbackContract=typeof(WcfServiceClient2.ServiceReference1.ICallbackBankCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICallbackBank {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/Addition")]
        void Addition(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/Addition")]
        System.Threading.Tasks.Task AdditionAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/Withdraw")]
        void Withdraw(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/Withdraw")]
        System.Threading.Tasks.Task WithdrawAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/Balance")]
        void Balance();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/Balance")]
        System.Threading.Tasks.Task BalanceAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICallbackBankCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/AdditionCB")]
        void AdditionCB(double result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/BalanceCB")]
        void BalanceCB(double result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallbackBank/WithdrawCB")]
        void WithdrawCB(double result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICallbackBankChannel : WcfServiceClient2.ServiceReference1.ICallbackBank, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CallbackBankClient : System.ServiceModel.DuplexClientBase<WcfServiceClient2.ServiceReference1.ICallbackBank>, WcfServiceClient2.ServiceReference1.ICallbackBank {
        
        public CallbackBankClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CallbackBankClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CallbackBankClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CallbackBankClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CallbackBankClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Addition(double n) {
            base.Channel.Addition(n);
        }
        
        public System.Threading.Tasks.Task AdditionAsync(double n) {
            return base.Channel.AdditionAsync(n);
        }
        
        public void Withdraw(double n) {
            base.Channel.Withdraw(n);
        }
        
        public System.Threading.Tasks.Task WithdrawAsync(double n) {
            return base.Channel.WithdrawAsync(n);
        }
        
        public void Balance() {
            base.Channel.Balance();
        }
        
        public System.Threading.Tasks.Task BalanceAsync() {
            return base.Channel.BalanceAsync();
        }
    }
}
