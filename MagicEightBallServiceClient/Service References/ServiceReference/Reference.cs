﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicEightBallServiceClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ghostmonk.com", ConfigurationName="ServiceReference.IEightBall")]
    public interface IEightBall {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ghostmonk.com/IEightBall/ObtainAnswer", ReplyAction="http://www.ghostmonk.com/IEightBall/ObtainAnswerResponse")]
        string ObtainAnswer(string userQuestion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEightBallChannel : MagicEightBallServiceClient.ServiceReference.IEightBall, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EightBallClient : System.ServiceModel.ClientBase<MagicEightBallServiceClient.ServiceReference.IEightBall>, MagicEightBallServiceClient.ServiceReference.IEightBall {
        
        public EightBallClient() {
        }
        
        public EightBallClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EightBallClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EightBallClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EightBallClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ObtainAnswer(string userQuestion) {
            return base.Channel.ObtainAnswer(userQuestion);
        }
    }
}