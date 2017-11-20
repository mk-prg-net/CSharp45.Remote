using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.ServiceModel;

namespace WcfTestLibWinFormHost
{
    public partial class MainFormHost : WinFormTemplates.WinFormTemplate1
    {
        public MainFormHost()
        {
            InitializeComponent();
        }

        ServiceHost HelloHost;
        private void btnStartHosting_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            HelloHost = new ServiceHost(typeof(WcfTestLib.HelloService));
            HelloHost.Open();

            if (HelloHost.State != CommunicationState.Opened)
            {
                log.Log(mko.Log.RC.CreateError("Der HelloHost konnte nicht geöffnet werden"));
                HelloHost.Close();
            }
            else
            {
                btn.Enabled = false;
                btn.BackColor = System.Drawing.Color.Red;
                log.Log(mko.Log.RC.CreateStatus("Der HelloHost wurde geöffnet und wartet auf Anfragen"));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Log(mko.Log.RC.CreateStatus("Das Hosting wird beendet"));
            if (HelloHost != null && HelloHost.State != CommunicationState.Closed)
            {                
                HelloHost.Close(new TimeSpan(0, 1, 0));
                if (HelloHost.State != CommunicationState.Closed)
                {
                    e.Cancel = true;
                    log.Log(mko.Log.RC.CreateError("Der Host kann nicht geschlossen werden"));
                }

            }
        }

        ServiceHost CreatePerCallHost;
        private void btnCreatePerCallStartHosting_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            CreatePerCallHost = new ServiceHost(typeof(WcfTestLib.CreationPatternPerCall));
            CreatePerCallHost.Open();

            if (CreatePerCallHost.State != CommunicationState.Opened)
            {
                log.Log(mko.Log.RC.CreateError("Der CreatePerCallHost konnte nicht geöffnet werden"));
                CreatePerCallHost.Close();
            }
            else
            {
                btn.Enabled = false;
                btn.BackColor = System.Drawing.Color.Red;
                log.Log(mko.Log.RC.CreateStatus("Der CreatePerCallHost wurde geöffnet und wartet auf Anfragen"));
            }
        }

        ServiceHost CreateSingleHost;
        private void btnCreateSingleStartHosting_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            CreateSingleHost = new ServiceHost(typeof(WcfTestLib.CreationPatternSingle));
            CreateSingleHost.Open();

            if (CreateSingleHost.State != CommunicationState.Opened)
            {
                log.Log(mko.Log.RC.CreateError("Der CreateSingleHost konnte nicht geöffnet werden"));
                CreateSingleHost.Close();
            }
            else
            {
                btn.BackColor = System.Drawing.Color.Red;
                log.Log(mko.Log.RC.CreateStatus("Der CreateSingleHost wurde geöffnet und wartet auf Anfragen"));
            }

        }

        ServiceHost CreatePerSessionHost;
        private void btnCreatePerSessionStartHosting_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            CreatePerSessionHost = new ServiceHost(typeof(WcfTestLib.CreationPatternPerSession));
            CreatePerSessionHost.Open();

            if (CreatePerSessionHost.State != CommunicationState.Opened)
            {
                log.Log(mko.Log.RC.CreateError("Der CreatePerSessionHost konnte nicht geöffnet werden"));
                CreatePerSessionHost.Close();
            }
            else
            {
                btn.Enabled = false;
                btn.BackColor = System.Drawing.Color.Red;
                log.Log(mko.Log.RC.CreateStatus("Der CreatePerSessionHost wurde geöffnet und wartet auf Anfragen"));
            }
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        ServiceHost DataStreamsHost;
        private void btnStartDataUpDownload_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;

                // Die Dienstinstanz wird mit dem ausgewählten Verzeichnis konfiguriert
                var DataStreamSingleton = new WcfTestLib.DataStreams(tbxDir.Text);

                DataStreamsHost = new ServiceHost(DataStreamSingleton);
                DataStreamsHost.Open();


                if (DataStreamsHost.State != CommunicationState.Opened)
                {
                    log.Log(mko.Log.RC.CreateError("Der DataStreamsHost konnte nicht geöffnet werden"));
                    DataStreamsHost.Close();
                }
                else
                {
                    btn.BackColor = System.Drawing.Color.Red;
                    log.Log(mko.Log.RC.CreateStatus("Der DataStreamsHost wurde geöffnet und wartet auf Anfragen"));
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Starten des DataStreams- Hosts: " + ex.Message));
            }

        }
    }
}
