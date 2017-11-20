using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace mko.FileSys
{
    [DataContract]
    [Serializable]
    [XmlInclude(typeof(Dir))]
    [XmlInclude(typeof(File))]
    public class FSysItem : IName
    {
        [DataMember]
        public string Name
        {
            get;
            set;
        }
    }
}
