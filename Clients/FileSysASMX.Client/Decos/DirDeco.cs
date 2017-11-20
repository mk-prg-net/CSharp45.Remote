using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mko.FileSys;

using System.IO;

namespace FileSysASMX.Client.Decos
{
    public class DirDeco : mko.FileSys.IDir, IDisplayName
    {
        mko.FileSys.IDir _dir;

        public DirDeco(mko.FileSys.IDir dir)
        {
            _dir = dir;
        }

        public string DisplayName
        {
            get
            {
                return Path.GetFileName(_dir.Name);
            }
        }

        public IEnumerable<IFile> Files
        {
            get
            {
                return _dir.Files.Select(r => new FileDeco(r));
            }

            set
            {
                _dir.Files = value;
            }
        }

        public string Name
        {
            get
            {
                return _dir.Name;
            }

            set
            {
                _dir.Name = value;
            }
        }

        public IEnumerable<IDir> SubDirs
        {
            get
            {
                return _dir.SubDirs.Select(r => new DirDeco(r));
            }

            set
            {
                _dir.SubDirs = value;
            }
        }
    }
}
