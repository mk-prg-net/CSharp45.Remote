﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTestLibClient.DataSetServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataSetServiceRef.IDataSetUploadService")]
    public interface IDataSetUploadService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataSetUploadService/UploadDataSet", ReplyAction="http://tempuri.org/IDataSetUploadService/UploadDataSetResponse")]
        bool UploadDataSet(WcfDataSetLib.DsFilesDb dataset);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataSetUploadService/DownloadDataSet", ReplyAction="http://tempuri.org/IDataSetUploadService/DownloadDataSetResponse")]
        bool DownloadDataSet(out WcfDataSetLib.DsFilesDb dataset);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataSetUploadServiceChannel : WcfTestLibClient.DataSetServiceRef.IDataSetUploadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataSetUploadServiceClient : System.ServiceModel.ClientBase<WcfTestLibClient.DataSetServiceRef.IDataSetUploadService>, WcfTestLibClient.DataSetServiceRef.IDataSetUploadService {
        
        public DataSetUploadServiceClient() {
        }
        
        public DataSetUploadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataSetUploadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataSetUploadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataSetUploadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool UploadDataSet(WcfDataSetLib.DsFilesDb dataset) {
            return base.Channel.UploadDataSet(dataset);
        }
        
        public bool DownloadDataSet(out WcfDataSetLib.DsFilesDb dataset) {
            return base.Channel.DownloadDataSet(out dataset);
        }
    }
}