using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    /// <summary>
    /// Der Dienstvertrag wird in Diensten implementiert, um die Übertragung großer Datenmengen 
    /// mit MTOM und STREAMS darzustellen
    /// </summary>
    [ServiceContract]
    public interface IDataStreams
    {
        [OperationContract]        
        bool Upload(string filename, byte[] data);

        [OperationContract]        
        bool DownloadData(string filename, out byte[] data);

        [OperationContract]        
        System.IO.Stream DownstreamData(string filename);

        // Operationen, die Informationen zu den Hochgeladenen Dateien einholen
        [OperationContract]        
        Filedescriptor GetFileDescriptor(string filename);

        [OperationContract]        
        FiledescriptorMessage GetFileDescriptorMessage(FileNameParamMessage filenameMessage);

        [OperationContract]        
        List<Filedescriptor> GetAllFileDescriptors();

        /// <summary>
        /// Zum Test der Authorisierung soll der Zugriff auf folgende Methode nur für 
        /// Admins möglich sein.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Filedescriptor> GetAllFileDescriptors_AdminsOnly();
    }

    [DataContract(Namespace="http://www.mkoit.de/DataStreams/Filedescriptor")]

    public class Filedescriptor
    {
        [DataMember(Name="FileName", Order=1)]
        public string name;

        // Soll auf der Clientseite nicht zu sehen sein
        public long SizeInBytes;

        [DataMember(Order=2)]
        public double SizeInKB
        {
            get
            {
                return SizeInBytes / 1024.0;
            }
            set { }
        }
    }

    [MessageContract(WrapperNamespace = "http://www.mkoit.de/DataStreams/Filedescriptor", ProtectionLevel=System.Net.Security.ProtectionLevel.None)]
    public class FileNameParamMessage
    {
        [MessageBodyMember]
        public string Filename;
    }

    [MessageContract(WrapperNamespace = "http://www.mkoit.de/DataStreams/Filedescriptor", ProtectionLevel=System.Net.Security.ProtectionLevel.None)]
    public class FiledescriptorMessage
    {
        // Headerinformation 
        [MessageHeader]
        public string UploadDirName;


        // Inhalt der Nachricht

        [MessageBodyMember(Name = "FileName", Order = 1)]
        public string name;

        // Soll auf der Clientseite nicht zu sehen sein
        public long SizeInBytes;

        [MessageBodyMember(Order = 2)]
        public double SizeInKB
        {
            get
            {
                return SizeInBytes / 1024.0;
            }
            set { }
        }
    }
}
