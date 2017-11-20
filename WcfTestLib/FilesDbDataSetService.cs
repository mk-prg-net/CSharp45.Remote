using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "DataSetUploadService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class FilesDbDataSetService : IDataSetUploadService
    {

        public bool UploadDataSet(WcfDataSetLib.DsFilesDb dataset)
        {
            // Die Daten aus dem Dataset werden mit der Datenbank synchronisiert
            using (var adp = new WcfDataSetLib.DsFilesDbTableAdapters.filesTableAdapter())
            {
                adp.Update(dataset.files);
            }

            return true;
        }

        public bool DownloadDataSet(out WcfDataSetLib.DsFilesDb dataset)
        {
            // Die Daten aus der files- Tabelle in das Dataset laden
            dataset = new WcfDataSetLib.DsFilesDb();

            using (var adp = new WcfDataSetLib.DsFilesDbTableAdapters.filesTableAdapter())
            {
                adp.Fill(dataset.files);
            }

            return true;
        }
    }
}
