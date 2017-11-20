using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormTemplate
{
    public partial class Form1 : Form
    {
        protected mko.Log.LogServer log = new mko.Log.LogServer();

        public Form1()
        {
            InitializeComponent();

            log.registerLogHnd(new mko.Log.WinFormListBoxLogHnd(lbxLog));
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxLog.Items.Add(mko.TraceHlp.FormatInfoMsg(this, "Form_Load", "erfolgreich gestartet"));
        }

        private void btnTabLogGenTestmeldung_Click(object sender, EventArgs e)
        {
            lbxLog.Items.Add(mko.TraceHlp.FormatInfoMsg(this, "btnTabLogGenTestmeldung_Click", "Testmeldung"));

        }

        private void btnTabLogClearLbxLog_Click(object sender, EventArgs e)
        {
            lbxLog.Items.Clear();
        }
    }
}
