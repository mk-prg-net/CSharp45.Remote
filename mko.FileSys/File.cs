using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;


namespace mko.FileSys
{

    [DataContract]
    public class File : IFile
    {
        public File() { }

        public File(string Name, long SizeInBytes)
        {
            this.Name = Name;
            this.SizeInBytes = SizeInBytes;
        }

        public File(IFile file)
        {
            Name = file.Name;
            SizeInBytes = file.SizeInBytes;
        }

        [DataMember]
        public string Name
        {
            get;
            set;
        }

        [DataMember]
        public long SizeInBytes
        {
            get;
            set;
        }
    }
}
