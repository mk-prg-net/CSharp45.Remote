using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mko.FileSys
{
    public interface IFile
    {
        string Name { get; set; }
        long SizeInBytes { get; set; }
    }
}
