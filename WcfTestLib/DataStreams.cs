using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.IO;
using System.Diagnostics;

namespace WcfTestLib
{
    
    /// <summary>
    /// Dienst zum Testen der Übertragung von binärdaten. Damit sich die Clients nicht 
    /// überrennen, wenn sie ein und dieselbe Datei hochladen sollten, wird der Zugriff
    /// vorsorglich serialisiert
    /// </summary>
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Single, InstanceContextMode=InstanceContextMode.Single)]
    public class DataStreams : IDataStreams
    {

        string _root = @"c:\temp";

        // Der Konstruktor definiert das Wurzelverzeichnis, das durch die Dateidown/Uploads
        // manipuliert wird
        public DataStreams(string pathRootDir) {
            _root = pathRootDir;
        }

        public DataStreams()
        {            
        }

        [OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        public bool Upload(string filename, byte[] data)
        {
            string absFilename = _root + "\\" + filename;
            System.IO.File.WriteAllBytes(absFilename, data);

            return true;
        }

        [OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        public bool DownloadData(string filename, out byte[] data)
        {
            string absFilename = _root + "\\" + filename;
            data = System.IO.File.ReadAllBytes(absFilename);

            return true;
        }

        [OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        public System.IO.Stream DownstreamData(string filename)
        {
            string absFilename = _root + "\\" + filename;
            return File.Open(absFilename, FileMode.Open);
        }


        [OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        public Filedescriptor GetFileDescriptor(string filename)
        {
            string absFilename = _root + "\\" + filename;
            if (File.Exists(absFilename))
            {
                var descriptor = new Filedescriptor();

                descriptor.name = filename;
                var finfo = new FileInfo(absFilename);
                descriptor.SizeInBytes = finfo.Length;

                return descriptor;

            }
            else
                throw new FaultException("Die Datei " + filename + " gibt es nicht im Uploadverzeichnis");
        }

        [OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        public FiledescriptorMessage GetFileDescriptorMessage(FileNameParamMessage filenameMessage)
        {
            string absFilename = _root + "\\" + filenameMessage.Filename;
            if (File.Exists(absFilename))
            {
                var descriptor = new FiledescriptorMessage();

                // Im Kopf der Nachricht wird der Pfad des Wurzelverzeichnis an den Client übertragen
                descriptor.UploadDirName = _root;

                descriptor.name = filenameMessage.Filename;
                var finfo = new FileInfo(absFilename);
                descriptor.SizeInBytes = finfo.Length;

                return descriptor;

            }
            else
                throw new FaultException("Die Datei " + filenameMessage.Filename + " gibt es nicht im Uploadverzeichnis");
        }

        //[OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        public List<Filedescriptor> GetAllFileDescriptors()
        {
            var lst = new List<Filedescriptor>();

            //using (((System.Security.Principal.WindowsIdentity)(System.Threading.Thread.CurrentPrincipal.Identity)).Impersonate())
            Debug.WriteLine("Vor Identitätswechsel: Zugriff auf Ressourcen als " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Debug.WriteLine("Impersonation Level in DataStreamsHost:" + ServiceSecurityContext.Current.WindowsIdentity.ImpersonationLevel);
            
            using (ServiceSecurityContext.Current.WindowsIdentity.Impersonate())
            {
                Debug.WriteLine("Nach Identitätswechsel: Zugriff auf Ressourcen als " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                foreach (var file in Directory.GetFiles(_root))
                {
                    lst.Add(GetFileDescriptor(Path.GetFileName(file)));
                }
            }

            Debug.WriteLine("Nach Beenden des Identitätswechsels: Zugriff auf Ressourcen als " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);

            return lst;
        }

        const string Gruppe = "Tracs13\\Administratoren";

        /// <summary>
        /// Zum Test der Authorisierung ist soll der Zugriff auf folgende Methode nur für 
        /// "Testgruppe" möglich sein.
        /// </summary>
        /// <returns></returns>

        //[System.Security.Permissions.PrincipalPermission(System.Security.Permissions.SecurityAction.Demand, Role="Testgruppe")]
        public List<Filedescriptor> GetAllFileDescriptors_AdminsOnly()
        {
            var lst = new List<Filedescriptor>();

            var principal = new System.Security.Principal.WindowsPrincipal(ServiceSecurityContext.Current.WindowsIdentity);

            Debug.WriteLine("Operation wird ausgeführt als: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Debug.WriteLine("Operation wurde aufgerufen von: " + ServiceSecurityContext.Current.WindowsIdentity.Name);
            //Debug.Assert(principal.IsInRole(Gruppe), "Benutzer sollte zu Gruppe der Administratoren gehören, um diese Operation aufzurufen- er tut es aber nicht!");

            var perm = new System.Security.Permissions.PrincipalPermission(principal.Identity.Name, Gruppe);
            //perm.Demand();

            foreach (var file in Directory.GetFiles(_root))
            {
                lst.Add(GetFileDescriptor(Path.GetFileName(file)));
            }

            return lst;
        }
    }
}
