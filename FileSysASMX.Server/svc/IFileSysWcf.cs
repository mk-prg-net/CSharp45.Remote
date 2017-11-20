using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FileSysASMX.Server.svc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFileSysWcf" in both code and config file together.
    [ServiceContract]
    public interface IFileSysWcf
    {
        [OperationContract]
        mko.FileSys.Dir GetSubDirs(string subDir);
    }
}
