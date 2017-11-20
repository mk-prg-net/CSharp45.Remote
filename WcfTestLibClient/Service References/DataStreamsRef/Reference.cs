﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTestLibClient.DataStreamsRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Filedescriptor", Namespace="http://www.mkoit.de/DataStreams/Filedescriptor")]
    [System.SerializableAttribute()]
    public partial class Filedescriptor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SizeInKBField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double SizeInKB {
            get {
                return this.SizeInKBField;
            }
            set {
                if ((this.SizeInKBField.Equals(value) != true)) {
                    this.SizeInKBField = value;
                    this.RaisePropertyChanged("SizeInKB");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataStreamsRef.IDataStreams")]
    public interface IDataStreams {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/Upload", ReplyAction="http://tempuri.org/IDataStreams/UploadResponse")]
        bool Upload(string filename, byte[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/DownloadData", ReplyAction="http://tempuri.org/IDataStreams/DownloadDataResponse")]
        bool DownloadData(out byte[] data, string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/DownstreamData", ReplyAction="http://tempuri.org/IDataStreams/DownstreamDataResponse")]
        System.IO.Stream DownstreamData(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/GetFileDescriptor", ReplyAction="http://tempuri.org/IDataStreams/GetFileDescriptorResponse")]
        WcfTestLibClient.DataStreamsRef.Filedescriptor GetFileDescriptor(string filename);
        
        // CODEGEN: Der Nachrichtenvertrag wird generiert, da der Wrappernamespace (http://www.mkoit.de/DataStreams/Filedescriptor) von Nachricht "FileNameParamMessage" nicht mit dem Standardwert (http://tempuri.org/) übereinstimmt.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/GetFileDescriptorMessage", ReplyAction="http://tempuri.org/IDataStreams/GetFileDescriptorMessageResponse")]
        WcfTestLibClient.DataStreamsRef.FiledescriptorMessage GetFileDescriptorMessage(WcfTestLibClient.DataStreamsRef.FileNameParamMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/GetAllFileDescriptors", ReplyAction="http://tempuri.org/IDataStreams/GetAllFileDescriptorsResponse")]
        WcfTestLibClient.DataStreamsRef.Filedescriptor[] GetAllFileDescriptors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataStreams/GetAllFileDescriptors_AdminsOnly", ReplyAction="http://tempuri.org/IDataStreams/GetAllFileDescriptors_AdminsOnlyResponse")]
        WcfTestLibClient.DataStreamsRef.Filedescriptor[] GetAllFileDescriptors_AdminsOnly();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileNameParamMessage", WrapperNamespace="http://www.mkoit.de/DataStreams/Filedescriptor", IsWrapped=true)]
    public partial class FileNameParamMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Filename;
        
        public FileNameParamMessage() {
        }
        
        public FileNameParamMessage(string Filename) {
            this.Filename = Filename;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FiledescriptorMessage", WrapperNamespace="http://www.mkoit.de/DataStreams/Filedescriptor", IsWrapped=true)]
    public partial class FiledescriptorMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string UploadDirName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string FileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double SizeInKB;
        
        public FiledescriptorMessage() {
        }
        
        public FiledescriptorMessage(string UploadDirName, string FileName, double SizeInKB) {
            this.UploadDirName = UploadDirName;
            this.FileName = FileName;
            this.SizeInKB = SizeInKB;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataStreamsChannel : WcfTestLibClient.DataStreamsRef.IDataStreams, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataStreamsClient : System.ServiceModel.ClientBase<WcfTestLibClient.DataStreamsRef.IDataStreams>, WcfTestLibClient.DataStreamsRef.IDataStreams {
        
        public DataStreamsClient() {
        }
        
        public DataStreamsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataStreamsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataStreamsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataStreamsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Upload(string filename, byte[] data) {
            return base.Channel.Upload(filename, data);
        }
        
        public bool DownloadData(out byte[] data, string filename) {
            return base.Channel.DownloadData(out data, filename);
        }
        
        public System.IO.Stream DownstreamData(string filename) {
            return base.Channel.DownstreamData(filename);
        }
        
        public WcfTestLibClient.DataStreamsRef.Filedescriptor GetFileDescriptor(string filename) {
            return base.Channel.GetFileDescriptor(filename);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfTestLibClient.DataStreamsRef.FiledescriptorMessage WcfTestLibClient.DataStreamsRef.IDataStreams.GetFileDescriptorMessage(WcfTestLibClient.DataStreamsRef.FileNameParamMessage request) {
            return base.Channel.GetFileDescriptorMessage(request);
        }
        
        public string GetFileDescriptorMessage(string Filename, out string FileName1, out double SizeInKB) {
            WcfTestLibClient.DataStreamsRef.FileNameParamMessage inValue = new WcfTestLibClient.DataStreamsRef.FileNameParamMessage();
            inValue.Filename = Filename;
            WcfTestLibClient.DataStreamsRef.FiledescriptorMessage retVal = ((WcfTestLibClient.DataStreamsRef.IDataStreams)(this)).GetFileDescriptorMessage(inValue);
            FileName1 = retVal.FileName;
            SizeInKB = retVal.SizeInKB;
            return retVal.UploadDirName;
        }
        
        public WcfTestLibClient.DataStreamsRef.Filedescriptor[] GetAllFileDescriptors() {
            return base.Channel.GetAllFileDescriptors();
        }
        
        public WcfTestLibClient.DataStreamsRef.Filedescriptor[] GetAllFileDescriptors_AdminsOnly() {
            return base.Channel.GetAllFileDescriptors_AdminsOnly();
        }
    }
}
