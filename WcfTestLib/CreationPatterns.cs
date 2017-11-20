using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTestLib
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "CreationPatterns" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class CreationPatterns : ICreationPatterns
    {
        int _count = 0;

        void ICreationPatterns.ResetCounter()
        {
            _count = 0;
        }

        int ICreationPatterns.NextValue()
        {
            return _count++;
        }

        const string NameOfSessionCounter = "CreationPatternsCounter";
        void ICreationPatterns.ResetAspNetSessionCounter()
        {
            System.Web.HttpContext.Current.Session[NameOfSessionCounter] = (int)0;
        }

        int ICreationPatterns.NextAspNetSessionValue()
        {
            int counter = (int)System.Web.HttpContext.Current.Session[NameOfSessionCounter];
            counter++;
            System.Web.HttpContext.Current.Session[NameOfSessionCounter] = counter;
            return counter;
        }
    }
}
