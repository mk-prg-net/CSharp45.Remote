using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "HelloService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    /// <summary>
    /// Simpler Dienst, der eine Grußmeldung erzeugt
    /// </summary>
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple,
                     InstanceContextMode=InstanceContextMode.PerCall)]
    public class HelloService : IHelloService
    {
        string IHelloService.SayHello(string myUserName)
        {
            return string.Format("{0:T}: Hello {1}", DateTime.Now, myUserName);
        }
    }
}
