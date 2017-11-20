using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace WcfTestLibClient
{
    public partial class MainFormClient : WinFormTemplate.Form1        
    {
        public MainFormClient()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDownloadVerzeichnis.Text = Properties.Settings.Default.Downloadverzeichnis;
        }

        //----------------------------------------------------------------------------------------------------------
        // Ü: Aufruf von Methoden synchron als auch asynchron

        /// <summary>
        /// Synchroner Start einer WCF- Operation: Der Client blockiert solange, bis der WCF- Dienst auf dem Server
        /// beendet wurde.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLongRunningOpStartSync_Click(object sender, EventArgs e)
        {
            try
            {
                using (var proxy = new CallingPatternsRef.CallingPatternsClient())
                {
                    int delay;
                    if (int.TryParse(tbxLongRunningOpMinExecTime.Text, out delay))
                    {
                        log.Log(mko.Log.RC.CreateStatus("Synchrone Ausführung der Langläuferop startet [" + tbxLongRunningOpMinExecTime.Text + " ms]"));

                        proxy.DelayedReturn(delay);

                        log.Log(mko.Log.RC.CreateStatus("Synchrone Ausführung der Langläufermehtode beendet"));
                    }
                    else
                    {
                        log.Log(mko.Log.RC.CreateError("Die Eingabe für die Verzögerungszeit ist unkorrekt"));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError(ex.Message));
            }
        }

        /// <summary>
        /// Asynchronder Aufruf einer WCF- Operation: Der Client wird unmittelbar nach dem Aufruf der WCF- Methode
        /// fortgesetzt. Durch Polling wird das Ende der Operation bestimmt. Während des Pollings wird die 
        /// verstrichene Zeit durch einen Progress- Bar dargestellt, und die Verarbeitung weiterer GUI- Ereignisse ermöglicht,
        /// um ein "Einfrieren" wie beim synchronen Start zu vermeiden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLongRunningOpStartAsync_Click(object sender, EventArgs e)
        {
            try
            {
                using (var proxy = new CallingPatternsRef.CallingPatternsClient())
                {
                    int delay;
                    if (int.TryParse(tbxLongRunningOpMinExecTime.Text, out delay))
                    {
                        log.Log(mko.Log.RC.CreateStatus("Asynchrone Ausführung der Langläuferop startet [" + tbxLongRunningOpMinExecTime.Text + " ms]"));
                        progressBarLongRunningOp.Minimum = 0;
                        progressBarLongRunningOp.Maximum = delay;
                        progressBarLongRunningOp.Value = 0;

                        IAsyncResult ares = proxy.BeginDelayedReturn(delay, null, null);


                        long oldTicks = DateTime.Now.Ticks;

                        while (!ares.IsCompleted)
                        {
                            Application.DoEvents();

                            long now = DateTime.Now.Ticks;
                            int diff = (int)(now - oldTicks) / 10000;
                            progressBarLongRunningOp.Value = Math.Min(diff, progressBarLongRunningOp.Maximum);

                        }

                        log.Log(mko.Log.RC.CreateStatus("Asynchrone Ausführung der Langläufermehtode beendet"));
                    }
                    else
                    {
                        log.Log(mko.Log.RC.CreateError("Die Eingabe für die Verzögerungszeit ist unkorrekt"));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError(ex.Message));
            }

        }

        void SetLblResult(DateTime d)
        {
            lblResultDelaydReturn.Text = d.ToString("T");
        }

        delegate void DGSet(DateTime d);

        /// <summary>
        /// Callback- Methode für asynchrone Methoden: Wird vom Proxy aufgerufen, wenn der asynchrone Methoden-
        /// aufruf eines Threads endet.
        /// </summary>
        /// <param name="ares"></param>
        void CallBackDelayedReturn(IAsyncResult ares)
        {
            DateTime date = callingProxy.EndDelayedReturn(ares);

            if (lblResultDelaydReturn.InvokeRequired)
            {
                // Der Zugriff auf ein WinFormSteurelement erfolgt nicht aus dem UI- Thread
                // deligieren an den UI- Thread
                lblResultDelaydReturn.Invoke(new DGSet(SetLblResult), new object[] { date });
            }
            else
                lblResultDelaydReturn.Text = date.ToString("T");

            callingProxy.Close();
        }

        CallingPatternsRef.CallingPatternsClient callingProxy;
        IAsyncResult aresDeleayedReturn;
        /// <summary>
        /// Asynchroner Start eines "langlaufenden" WCF- Dienstes. Das Ende des Dienstes muß explizit durch Drücken
        /// des Buttons "btnFertig" sichergestellt werden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            try
            {
                if (callingProxy != null && callingProxy.State != System.ServiceModel.CommunicationState.Closed)
                    throw new Exception("Es wurde bereits ein langlaufender Dienst gestartet. Dieser muß zunächst mit \"Fertig\" beendet werden");

                callingProxy = new CallingPatternsRef.CallingPatternsClient();

                int delay;
                if (int.TryParse(tbxLongRunningOpMinExecTime.Text, out delay))
                {
                    log.Log(mko.Log.RC.CreateStatus("Asynchrone Ausführung der Langläuferop startet [" + tbxLongRunningOpMinExecTime.Text + " ms]. Bitte \"Fertig\" anklicken!"));
                    aresDeleayedReturn = callingProxy.BeginDelayedReturn(delay, null, null);
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim asynchronen Start eines WCF- Dienstes: " + ex.Message));
            }
        }

        /// <summary>
        /// Warten auf das Ende eines langlaufenden asynchron gestarteten Dienstes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFertig_Click(object sender, EventArgs e)
        {
            try
            {
                if (callingProxy != null && callingProxy.State != System.ServiceModel.CommunicationState.Opened)
                    throw new Exception("Es wurde mit Begin noch kein langläufer- Dienst gestatrtet, der mit \"Fertig\" beendet werden kann");

                lblResultDelaydReturn.Text = callingProxy.EndDelayedReturn(aresDeleayedReturn).ToString("T");
                callingProxy.Close();
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Beenden eines asynchronen WCF- Dienstes: " + ex.Message));
            }
        }


        /// <summary>
        /// Asynchroner Start eines langlaufenden WCF- Dienstes. Wenn der Dienst endete, dann wird auf dem Client 
        /// eine Callback- Methode gestartet. Diese ruft das Ergebnis des Dienstes ab und aktualisiert damit Steuer-
        /// elemente in der GUI des Client. Dabei muß berücksichtigt werden, daß GUI- Steuerelemente nur aus dem
        /// UI- Thread heraus aktualisiert werden dürfen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleayedReturnAsyncCallback_Click(object sender, EventArgs e)
        {
            try
            {
                int delay;
                if (int.TryParse(tbxLongRunningOpMinExecTime.Text, out delay))
                {

                    callingProxy = new CallingPatternsRef.CallingPatternsClient();
                    aresDeleayedReturn = callingProxy.BeginDelayedReturn(delay, new AsyncCallback(CallBackDelayedReturn), null);
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Starten eines asynchronen WCF- Dienstes mit Callback: " + ex.Message));

            }
        }


        //------------------------------------------------------------------------------------------------------------
        // Ü:  Up- und Download großer Datenmengen mittels WCF- Dienste

        private void btnOpenUploadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxUploadFilename.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Methode zum Hochladen einer Datei/Blob. 
        /// Für die Übertragung sollte im Client wie im Server das MTOM - Verfahren gewählt werden,
        /// um das Parsen großer Datenmengen durch XML- Parser beim Lesen der Datentelegramme zu vermeiden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUploadFilename.Text) && System.IO.File.Exists(tbxUploadFilename.Text))
            {
                try
                {
                    using (var proxy = new DataStreamsRef.DataStreamsClient())
                    {
                        log.Log(mko.Log.RC.CreateStatus("Upload von " + tbxUploadFilename.Text + " startet"));
                        proxy.Upload(System.IO.Path.GetFileName(tbxUploadFilename.Text), System.IO.File.ReadAllBytes(tbxUploadFilename.Text));
                        log.Log(mko.Log.RC.CreateStatus("Upload von " + tbxUploadFilename.Text + " erfolgreich beendet"));
                    }
                }
                catch (Exception ex)
                {
                    log.Log(mko.Log.RC.CreateError("Beim Hochladen von " + tbxUploadFilename.Text + ": " + ex.Message));
                }
            }
        }

        /// <summary>
        /// Gepufferter Download einer Datei. Dies ist der Standard- Modus, wobei die gesammte Datei /Blob 
        /// in den Arbeitsspeicher vom Client geladen wird. Bei der üppigen Ausstattung mit Arbeitsspeicher 
        /// ist dieser Modus auch noch für Dateien > 1 MB kein Problem und die effizienteste Methode.
        /// Für die Übertragung sollte aber im Client wie im Server das MTOM - Verfahren gewählt werden,
        /// um das Parsen großer Datenmengen durch XML- Parser beim Lesen der Datentelegramme zu vermeiden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxDownloadFilename.Text))
            {
                try
                {
                    using (var proxy = new DataStreamsRef.DataStreamsClient())
                    {
                        log.Log(mko.Log.RC.CreateStatus("Download von " + tbxDownloadFilename.Text + " in " + Properties.Settings.Default.Downloadverzeichnis + " startet"));
                        byte[] data;
                        proxy.DownloadData(out data, tbxDownloadFilename.Text);

                        string fname = Properties.Settings.Default.Downloadverzeichnis + "\\" + tbxDownloadFilename.Text;
                        System.IO.File.WriteAllBytes(fname, data);
                        log.Log(mko.Log.RC.CreateStatus("Download von " + tbxDownloadFilename.Text + " in " + Properties.Settings.Default.Downloadverzeichnis + " erfolgreich beendet"));
                    }
                }
                catch (Exception ex)
                {
                    log.Log(mko.Log.RC.CreateError("Beim Hochladen von " + tbxUploadFilename.Text + ": " + ex.Message));
                }
            }

        }

        /// <summary>
        /// Besipiel für den Download von Blobs über einen WCF- Dienst mittels Streaming. Das Streanming muß in der 
        /// Konfiguration des Clients unter Bindung im Element TransferMode auf Stream eingestellt werden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownloadStream_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxDownloadFilename.Text))
            {
                try
                {
                    using (var proxy = new DataStreamsRef.DataStreamsClient())
                    {
                        log.Log(mko.Log.RC.CreateStatus("Downstream von " + tbxDownloadFilename.Text + " in " + Properties.Settings.Default.Downloadverzeichnis + " startet"));

                        System.IO.Stream downstream = proxy.DownstreamData(tbxDownloadFilename.Text);

                        string fname = Properties.Settings.Default.Downloadverzeichnis + "\\" + tbxDownloadFilename.Text;
                        var fstream = new System.IO.FileStream(fname, System.IO.FileMode.Create);

                        // Hier wird der Datenstrom kontinuierlich auf die Festplatte geleitet
                        downstream.CopyTo(fstream);

                        log.Log(mko.Log.RC.CreateStatus("Downstream von " + tbxDownloadFilename.Text + " in " + Properties.Settings.Default.Downloadverzeichnis + " erfolgreich beendet"));
                    }
                }
                catch (Exception ex)
                {
                    log.Log(mko.Log.RC.CreateError("Beim Hochladen von " + tbxUploadFilename.Text + ": " + ex.Message));
                }
            }
        }


        //-----------------------------------------------------------------------------------------------------------
        // Ü: Aufruf von WCF- DataServices

        class FileView
        {
            public string Name { get; set; }
            public string Dir { get; set; }
        }

        /// <summary>
        /// Ruft einen WCF- Datenservice ab, über den Abfragen an die FileFeatureDB abgesetzt werden können.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllFilesRequery_Click(object sender, EventArgs e)
        {
            try
            {
                var proxy = new FileFeaturesDbDataServiceRef.FileFeaturesDbEntities(new Uri("http://localhost:9091/FileFeaturesDataService.svc/"));

                // Alle Einträge von FileClasses anzeigen
                var alleKlassen = proxy.FileClasses;

                // Aufbereiten des Resultsets zur Anzeige in einem Gridview
                var dsCollAlleKlassen = new System.Data.Services.Client.DataServiceCollection<FileFeaturesDbDataServiceRef.FileClass>(alleKlassen);

                // Ausgabe im GirdView
                grdDataServiceResult.DataSource = dsCollAlleKlassen;

                // Alle Klassen, deren Name mit O beginnt
                var alleMitO = proxy.FileClasses.Where(r => r.name.StartsWith("O"));

                var dsCollAlleKlassenMitO = new System.Data.Services.Client.DataServiceCollection<FileFeaturesDbDataServiceRef.FileClass>(alleMitO);

                grdDataServiceResult.DataSource = dsCollAlleKlassenMitO;


                var lst = new List<FileView>();
                foreach (var r in proxy.Files.Select(r => new FileView { Name = r.filename, Dir = r.Dir.path }))
                {
                    lst.Add(r);
                }
                //var resColl = new System.Data.Services.Client.DataServiceCollection<FileFeaturesDbDataServiceRef.File>(ctx.Files);
                //bindingSource1.DataSource = resColl;

                grdDataServiceResult.DataSource = lst;

            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Abrufen aller Files :" + ex.Message));
            }
        }

        //-----------------------------------------------------------------------------------------------------------
        // Ü: Ferner Datenbankzugriff mit klassischen DataSets


        private void btnFilesDbRequery_Click(object sender, EventArgs e)
        {
            try
            {
                using (var proxy = new DataSetServiceRef.DataSetUploadServiceClient())
                {
                    proxy.DownloadDataSet(out dsFilesDb1);
                    FilesDbDataSetBindingSource.DataSource = dsFilesDb1;
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Abrufen des aktuellen DataSets: " + ex.Message));
            }
        }

        private void btnFilesDbSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (var proxy = new DataSetServiceRef.DataSetUploadServiceClient())
                {
                    proxy.UploadDataSet(dsFilesDb1);
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Aktualisieren des aktuellen DataSets: " + ex.Message));
            }
        }

        //-----------------------------------------------------------------------------------------------------------
        // Ü: Absicherung von WCF- Diensten gegen den Zugriff Unbefugter


        /// <summary>
        /// Abruf der Liste alle hochgeladener Dateien. Dient als Test für die Authentifizierung und Authorisierung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGetUploadFilelist_Click(object sender, EventArgs e)
        {
            try
            {
                using (var LoginDlg = new Login())
                {
                    if (LoginDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        using (var proxy = new DataStreamsRef.DataStreamsClient("NetTcpBinding_IDataStreams"))
                        {
                            try
                            {
                                // Anmeldung 
                                proxy.ClientCredentials.Windows.ClientCredential.Domain = LoginDlg.Domain;
                                proxy.ClientCredentials.Windows.ClientCredential.UserName = LoginDlg.User;
                                proxy.ClientCredentials.Windows.ClientCredential.Password = LoginDlg.Password;
                                proxy.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
                                

                                // Abruf der Liste aller hochgeladener Dateien
                                DataStreamsRef.Filedescriptor[] all = proxy.GetAllFileDescriptors_AdminsOnly();

                                // Darstellung
                                grdUploadedFiles.DataSource = all;
//#if(DEBUG)
                                foreach (DataStreamsRef.Filedescriptor fd in all)
                                {
                                    Debug.WriteLine("Name= " + fd.FileName + ", SizeInKB= " + fd.SizeInKB);
                                }
                            }
                            catch (Exception ex)
                            {
                                log.Log(mko.Log.RC.CreateError("Beim Abruf von btnGetUploadFilelist_Click(inner): " + ex.Message));
                            }
//#endif
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Log(mko.Log.RC.CreateError("Beim Abruf von btnGetUploadFilelist_Click: " + ex.Message));
            }
        }
    }
}
