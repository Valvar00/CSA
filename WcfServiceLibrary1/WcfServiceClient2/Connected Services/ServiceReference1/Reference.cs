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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/addCNum", ReplyAction="http://tempuri.org/ICalculator/addCNumResponse")]
        WcfServiceLibrary1.ComplexNum addCNum(WcfServiceLibrary1.ComplexNum n1, WcfServiceLibrary1.ComplexNum n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/addCNum", ReplyAction="http://tempuri.org/ICalculator/addCNumResponse")]
        System.Threading.Tasks.Task<WcfServiceLibrary1.ComplexNum> addCNumAsync(WcfServiceLibrary1.ComplexNum n1, WcfServiceLibrary1.ComplexNum n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Function1", ReplyAction="http://tempuri.org/ICalculator/Function1Response")]
        void Function1(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Function1", ReplyAction="http://tempuri.org/ICalculator/Function1Response")]
        System.Threading.Tasks.Task Function1Async(string s1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Function2")]
        void Function2(string s2);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculator/Function2")]
        System.Threading.Tasks.Task Function2Async(string s2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : WcfServiceClient2.ServiceReference1.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<WcfServiceClient2.ServiceReference1.ICalculator>, WcfServiceClient2.ServiceReference1.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfServiceLibrary1.ComplexNum addCNum(WcfServiceLibrary1.ComplexNum n1, WcfServiceLibrary1.ComplexNum n2) {
            return base.Channel.addCNum(n1, n2);
        }
        
        public System.Threading.Tasks.Task<WcfServiceLibrary1.ComplexNum> addCNumAsync(WcfServiceLibrary1.ComplexNum n1, WcfServiceLibrary1.ComplexNum n2) {
            return base.Channel.addCNumAsync(n1, n2);
        }
        
        public void Function1(string s1) {
            base.Channel.Function1(s1);
        }
        
        public System.Threading.Tasks.Task Function1Async(string s1) {
            return base.Channel.Function1Async(s1);
        }
        
        public void Function2(string s2) {
            base.Channel.Function2(s2);
        }
        
        public System.Threading.Tasks.Task Function2Async(string s2) {
            return base.Channel.Function2Async(s2);
        }
    }
}