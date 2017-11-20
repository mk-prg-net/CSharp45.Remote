using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "ICreationPatterns" sowohl im Code als auch in der Konfigurationsdatei ändern.
    // Mit SessionMode.Required wird gefordert, das der Host den Kontext des Dienstes in einem Sitzungszustand sichern darf.
    // Wenn kein Sitzungszustand möglich ist, dann eben nicht.
    [ServiceContract(SessionMode=SessionMode.Required)]
    public interface ICreationPatterns
    {
        [OperationContract(IsInitiating=true, IsTerminating=false)]
        void StartNewSession();

        [OperationContract(IsTerminating=true, IsInitiating = false)]
        void TerminateSession();

        [OperationContract(IsTerminating = false, IsInitiating = false)]
        void ResetCounter();

        [OperationContract(IsTerminating = false, IsInitiating = true)]
        int NextValue();

        [OperationContract(IsTerminating = false, IsInitiating = false)]
        void ResetAspNetSessionCounter();

        [OperationContract(IsTerminating = false, IsInitiating = false)]
        int NextAspNetSessionValue();

    }
}
