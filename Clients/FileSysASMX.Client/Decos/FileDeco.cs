using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileSysASMX.Client.Decos
{
    public class FileDeco : mko.FileSys.IFile, IDisplayName
    {
        mko.FileSys.IFile _file;

        public FileDeco(mko.FileSys.IFile file)
        {
            _file = file;
        }

        public string DisplayName
        {
            get
            {
                return Path.GetDirectoryName(_file.Name);
            }
        }

        public string Name
        {
            get
            {
                return _file.Name;
            }

            set
            {
                _file.Name = value;
            }
        }

        public long SizeInBytes
        {
            get
            {
                return _file.SizeInBytes;
            }

            set
            {
                _file.SizeInBytes = value;
            }
        }
    }
}
