using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Xml.Serialization;

using System.IO;

namespace FileSysASMX.Server.svc
{
    /// <summary>
    /// Summary description for FileSys
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]    
    public class FileSys : System.Web.Services.WebService
    {

        const string BaseDir = @"C:\Users\marti_000\Documents\prj\Bildergalerie";

        [WebMethod]        
        public mko.FileSys.Dir GetSubDirs(string subDir)
        {
            var subDirAbs = Path.Combine(BaseDir, subDir);
            mko.TraceHlp.ThrowArgExIfNot(Directory.Exists(subDirAbs), $"Directory {Path.Combine(BaseDir, subDir)} does not exists");

            var dir = new mko.FileSys.Dir();

            dir.SubDirs = Directory.GetDirectories(subDirAbs).Select(r => new mko.FileSys.Dir(r));
            dir.Files = Directory.GetFiles(subDirAbs).Select(r => new mko.FileSys.File(r, new FileInfo(r).Length));

            return dir;
        }

        [WebMethod]
        //[XmlInclude(typeof(mko.FileSys.Dir[]))]
        //[XmlInclude(typeof(mko.FileSys.File[]))]
        public List<mko.FileSys.FSysItem> GetSubDirItems(string subDir)
        {
            var subDirAbs = Path.Combine(BaseDir, subDir);
            mko.TraceHlp.ThrowArgExIfNot(Directory.Exists(subDirAbs), $"Directory {Path.Combine(BaseDir, subDir)} does not exists");

            var SubDirs = Directory.GetDirectories(subDirAbs).Select(r => new mko.FileSys.Dir(r));
            var Files = Directory.GetFiles(subDirAbs).Select(r => new mko.FileSys.File(r, new FileInfo(r).Length));

            var list = new List<mko.FileSys.FSysItem>((SubDirs.ToArray<mko.FileSys.FSysItem>().Concat(Files.ToArray<mko.FileSys.FSysItem>())));
            return list;

        }


        [WebMethod]
        public mko.FileSys.FileSimple GetFileSimple(string name)
        {
            return new mko.FileSys.FileSimple() { Name = "Hallo", SizeInBytes = 123456789 };
        }

    }
}
