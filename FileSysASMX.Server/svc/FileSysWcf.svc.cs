using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using mko.FileSys;

using System.IO;


namespace FileSysASMX.Server.svc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FileSysWcf" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FileSysWcf.svc or FileSysWcf.svc.cs at the Solution Explorer and start debugging.
    public class FileSysWcf : IFileSysWcf
    {
        const string BaseDir = @"C:\Users\marti_000\Documents\prj\Bildergalerie";

        public mko.FileSys.Dir GetSubDirs(string subDir)
        {
            var subDirAbs = Path.Combine(BaseDir, subDir);
            mko.TraceHlp.ThrowArgExIfNot(Directory.Exists(subDirAbs), $"Directory {Path.Combine(BaseDir, subDir)} does not exists");

            var dir = new mko.FileSys.Dir();

            dir.SubDirs = Directory.GetDirectories(subDirAbs).Select(r => new mko.FileSys.Dir(r));
            dir.Files = Directory.GetFiles(subDirAbs).Select(r => new mko.FileSys.File(r, new FileInfo(r).Length));

            return dir;
        }

    }
}
