using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mko.FileSys
{
    public interface IDir
    {
        string Name { get; set; }

        IEnumerable<IDir> SubDirs { get; set; }

        IEnumerable<IFile> Files { get; set; }
    }
}
