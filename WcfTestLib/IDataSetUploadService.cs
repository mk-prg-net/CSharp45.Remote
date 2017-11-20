using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IDataSetUploadService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface IDataSetUploadService
    {
        /// <summary>
        /// Ein Dataset wird zur Verarbeitung hochgeladen
        /// </summary>
        /// <param name="dataset"></param>
        /// <returns></returns>
        [OperationContract]
        bool UploadDataSet(WcfDataSetLib.DsFilesDb dataset);

        /// <summary>
        /// Ein Dataset wird vom Server neu heruntergeladen
        /// </summary>
        /// <param name="dataset"></param>
        /// <returns></returns>
        [OperationContract]
        bool DownloadDataSet(out WcfDataSetLib.DsFilesDb dataset);
    }
}
