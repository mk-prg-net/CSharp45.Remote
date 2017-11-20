using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSysASMX.Client
{
    public partial class MainForm : mko.WinForm.FormWithTabControl
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SVC.FileSysWcfClient svcClient = new SVC.FileSysWcfClient();
        ASMX.FileSysSoapClient asmxClient = new ASMX.FileSysSoapClient();

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var file = svcClient..GetFileSimple("xxx");

            SuspendLayout();

            var dirs = svcClient.GetSubDirs("Reisen");

            Debug.Assert(dirs.SubDirs.Count() == dirs.SubDirs_ASMX.Count());

            DirBindingSource.DataSource = dirs.SubDirs.Select(r => new Decos.DirDeco(r));
            FilesBindingSource.DataSource = dirs.Files.Select(r => new Decos.FileDeco(r));


            var dirsAsmx = asmxClient.GetSubDirs("Reisen");

            var items = asmxClient.GetSubDirItems("Reisen");

            ResumeLayout();


        }

        private void DirBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void grdDirs_SelectionChanged(object sender, EventArgs e)
        {            
            if (grdDirs.SelectedRows.Count > 0)
            {
                if (DirBindingSource.Current != null)
                {
                    var dir = (mko.FileSys.IDir)DirBindingSource.Current;

                    var ix = dir.Name.LastIndexOf("Reisen");
                    var subDir = dir.Name.Substring(ix);

                    var dirs = svcClient.GetSubDirs(subDir);

                    //DirBindingSource.DataSource = dirs.SubDirs;
                    //DirBindingSource.ResetBindings(false);
                    FilesBindingSource.DataSource = dirs.Files.Select(r => new Decos.FileDeco(r));
                    FilesBindingSource.ResetBindings(false);
                } else
                {
                    var dirs = svcClient.GetSubDirs("Reisen");

                    DirBindingSource.DataSource = dirs.SubDirs.Select(r => new Decos.DirDeco(r));
                    FilesBindingSource.DataSource = dirs.Files.Select(r => new Decos.FileDeco(r));

                }
            }

        }

        private void grdDirs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void grdDirs_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dir = (mko.FileSys.IDir)DirBindingSource.Current;

                var ix = dir.Name.LastIndexOf("Reisen");
                var subDir = dir.Name.Substring(ix);

                var dirs = svcClient.GetSubDirs(subDir);

                DirBindingSource.DataSource = dirs.SubDirs.Select(r => new Decos.DirDeco(r));
                DirBindingSource.ResetBindings(false);

                FilesBindingSource.DataSource = dirs.Files.Select(r => new Decos.FileDeco(r));
                FilesBindingSource.ResetBindings(false);
            }
        }
    }
}
