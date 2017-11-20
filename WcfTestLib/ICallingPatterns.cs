using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IService1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract(SessionMode=SessionMode.Required, Namespace="http://www.mkoit.de/ICallingPatterns")]
    public interface ICallingPatterns
    {
        /// <summary>
        /// Aufruf endet frühstens nach delayInMs. Kann zum testen asynchroner Aufrufmuster als auch 
        /// Timeouts verwendet werden.
        /// </summary>
        /// <param name="delayInMs">Verzögerungszeit in ms</param>
        /// <returns></returns>
        [OperationContract]
        DateTime DelayedReturn(int delayInMs);

        // Im Folgenden wird durch den Dienst ein Interface für einen schnellen Zähler angeboten,
        // mit dem relative Vergleiche des Laufzeitverhaltens bei verschiedenen WCF- Konfigurationen
        // möglich sind

        /// <summary>
        /// Startet einen schnellen Zähler in einem niederpriorisierten Thread
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void StartFastAsyncCounter();

        /// <summary>
        /// Stoppt den schnellen Zähler
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void StopFastAsyncCounter();

        /// <summary>
        /// Setzt den schnellen Zähler auf 0 zurück
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void ResetFastAsyncCounter();

        /// <summary>
        /// Liest den aktuellen Zählerstand aus
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        long GetFastAsyncCounterValue();
        
    }
}
