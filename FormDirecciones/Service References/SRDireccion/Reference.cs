﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18034
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormDirecciones.SRDireccion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRDireccion.DireccIpSoap")]
    public interface DireccIpSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento DiagnosticoIpResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DiagnosticoIp", ReplyAction="*")]
        FormDirecciones.SRDireccion.DiagnosticoIpResponse DiagnosticoIp(FormDirecciones.SRDireccion.DiagnosticoIpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DiagnosticoIp", ReplyAction="*")]
        System.Threading.Tasks.Task<FormDirecciones.SRDireccion.DiagnosticoIpResponse> DiagnosticoIpAsync(FormDirecciones.SRDireccion.DiagnosticoIpRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DiagnosticoIpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DiagnosticoIp", Namespace="http://tempuri.org/", Order=0)]
        public FormDirecciones.SRDireccion.DiagnosticoIpRequestBody Body;
        
        public DiagnosticoIpRequest() {
        }
        
        public DiagnosticoIpRequest(FormDirecciones.SRDireccion.DiagnosticoIpRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DiagnosticoIpRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ip;
        
        public DiagnosticoIpRequestBody() {
        }
        
        public DiagnosticoIpRequestBody(int ip) {
            this.ip = ip;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DiagnosticoIpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DiagnosticoIpResponse", Namespace="http://tempuri.org/", Order=0)]
        public FormDirecciones.SRDireccion.DiagnosticoIpResponseBody Body;
        
        public DiagnosticoIpResponse() {
        }
        
        public DiagnosticoIpResponse(FormDirecciones.SRDireccion.DiagnosticoIpResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DiagnosticoIpResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DiagnosticoIpResult;
        
        public DiagnosticoIpResponseBody() {
        }
        
        public DiagnosticoIpResponseBody(string DiagnosticoIpResult) {
            this.DiagnosticoIpResult = DiagnosticoIpResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DireccIpSoapChannel : FormDirecciones.SRDireccion.DireccIpSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DireccIpSoapClient : System.ServiceModel.ClientBase<FormDirecciones.SRDireccion.DireccIpSoap>, FormDirecciones.SRDireccion.DireccIpSoap {
        
        public DireccIpSoapClient() {
        }
        
        public DireccIpSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DireccIpSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DireccIpSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DireccIpSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FormDirecciones.SRDireccion.DiagnosticoIpResponse FormDirecciones.SRDireccion.DireccIpSoap.DiagnosticoIp(FormDirecciones.SRDireccion.DiagnosticoIpRequest request) {
            return base.Channel.DiagnosticoIp(request);
        }
        
        public string DiagnosticoIp(int ip) {
            FormDirecciones.SRDireccion.DiagnosticoIpRequest inValue = new FormDirecciones.SRDireccion.DiagnosticoIpRequest();
            inValue.Body = new FormDirecciones.SRDireccion.DiagnosticoIpRequestBody();
            inValue.Body.ip = ip;
            FormDirecciones.SRDireccion.DiagnosticoIpResponse retVal = ((FormDirecciones.SRDireccion.DireccIpSoap)(this)).DiagnosticoIp(inValue);
            return retVal.Body.DiagnosticoIpResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FormDirecciones.SRDireccion.DiagnosticoIpResponse> FormDirecciones.SRDireccion.DireccIpSoap.DiagnosticoIpAsync(FormDirecciones.SRDireccion.DiagnosticoIpRequest request) {
            return base.Channel.DiagnosticoIpAsync(request);
        }
        
        public System.Threading.Tasks.Task<FormDirecciones.SRDireccion.DiagnosticoIpResponse> DiagnosticoIpAsync(int ip) {
            FormDirecciones.SRDireccion.DiagnosticoIpRequest inValue = new FormDirecciones.SRDireccion.DiagnosticoIpRequest();
            inValue.Body = new FormDirecciones.SRDireccion.DiagnosticoIpRequestBody();
            inValue.Body.ip = ip;
            return ((FormDirecciones.SRDireccion.DireccIpSoap)(this)).DiagnosticoIpAsync(inValue);
        }
    }
}