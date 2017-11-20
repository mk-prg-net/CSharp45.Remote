using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;



namespace CBService
{

    /// <summary>
    /// Palentensystem als Geschäftsobjekt, das durch den Workflow erzeugt und konfiguriert wird
    /// </summary>
    [DataContract(Namespace="www.mkoit.de/Kepler")]
    public class CBSys
    {
        public CBSys() {
            Satellites = new List<CBody>();
        }

        [DataMember]
        public CBody CentralBody { get; set; }

        [DataMember]
        public List<CBody> Satellites { get; set; }
    }
}
