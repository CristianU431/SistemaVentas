﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWeb.srTrabajos {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srTrabajos.wsTrabajosSoap")]
    public interface wsTrabajosSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(string Job_desc, string Min_lvl, string Max_lvl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(string Job_desc, string Min_lvl, string Max_lvl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(string Job_id, string Job_desc, string Min_lvl, string Max_lvl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(string Job_id, string Job_desc, string Min_lvl, string Max_lvl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(string Job_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(string Job_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsTrabajosSoapChannel : ClienteWeb.srTrabajos.wsTrabajosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsTrabajosSoapClient : System.ServiceModel.ClientBase<ClienteWeb.srTrabajos.wsTrabajosSoap>, ClienteWeb.srTrabajos.wsTrabajosSoap {
        
        public wsTrabajosSoapClient() {
        }
        
        public wsTrabajosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsTrabajosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsTrabajosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsTrabajosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(string Job_desc, string Min_lvl, string Max_lvl) {
            return base.Channel.Agregar(Job_desc, Min_lvl, Max_lvl);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(string Job_desc, string Min_lvl, string Max_lvl) {
            return base.Channel.AgregarAsync(Job_desc, Min_lvl, Max_lvl);
        }
        
        public string[] Actualizar(string Job_id, string Job_desc, string Min_lvl, string Max_lvl) {
            return base.Channel.Actualizar(Job_id, Job_desc, Min_lvl, Max_lvl);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(string Job_id, string Job_desc, string Min_lvl, string Max_lvl) {
            return base.Channel.ActualizarAsync(Job_id, Job_desc, Min_lvl, Max_lvl);
        }
        
        public string[] Eliminar(string Job_id) {
            return base.Channel.Eliminar(Job_id);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(string Job_id) {
            return base.Channel.EliminarAsync(Job_id);
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
    }
}