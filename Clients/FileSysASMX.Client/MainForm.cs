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
        //SVC.FileSys svcClient = new SVC.FileSys();

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var file = svcClient..GetFileSimple("xxx");

            SuspendLayout();
            
            var dirs = svcClient.GetSubDirs("Reisen");

            Debug.Assert(dirs.SubDirs.Count() == dirs.SubDirs_ASMX.Count());

            DirBindingSource.DataSource = dirs.SubDirs;
            FilesBindingSource.DataSource = dirs.Files;

            ResumeLayout();
            
             
        }

        private void DirBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void grdDirs_SelectionChanged(object sender, EventArgs e)
        {
            if (active)
            {
                var dir = (mko.FileSys.Dir)DirBindingSource.Current;

                var ix = dir.Name.LastIndexOf("Reisen");
                var subDir = dir.Name.Substring(ix);

                var dirs = svcClient.GetSubDirs(subDir);

                DirBindingSource.DataSource = dirs.SubDirs;
                DirBindingSource.ResetBindings(false);
                FilesBindingSource.DataSource = dirs.Files;
                FilesBindingSource.ResetBindings(false);
            }

        }

        private void tabControlBaseFormMain_Enter(object sender, EventArgs e)
        {

        }

        private void tabControlBaseFormMain_Leave(object sender, EventArgs e)
        {

        }
        bool active = false;
        private void grdDirs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            active = true;
        }

        private void grdDirs_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            active = false;
        }
    }
}
