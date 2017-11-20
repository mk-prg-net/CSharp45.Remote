using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace mko.FileSys
{

    [DataContract]
    [Serializable]
    public class Dir : FSysItem, IDir
    {
        public Dir() { }


        public Dir(string Name)
        {
            this.Name = Name;
        }

        public Dir(IDir dir)
        {
            Name = dir.Name;
            Files = dir.Files;
            SubDirs = dir.SubDirs;
        }

        [DataMember]
        public List<File> Files_ASMX = new List<File>();

        [XmlIgnore]
        [IgnoreDataMember]
        public IEnumerable<IFile> Files
        {
            get
            {
                return Files_ASMX;
            }

            set
            {
                Files_ASMX.Clear();
                Files_ASMX.AddRange(value.Select(r => new File(r)));
            }
        }

        [DataMember]
        public List<Dir> SubDirs_ASMX = new List<Dir>();

        [XmlIgnore]
        [IgnoreDataMember]
        public IEnumerable<IDir> SubDirs
        {
            get
            {
                return SubDirs_ASMX;
            }

            set
            {
                SubDirs_ASMX.Clear();
                SubDirs_ASMX.AddRange(value.Select(r => new Dir(r)));
            }
        }

    }
}
