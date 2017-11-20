//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 15.12.2014
//
//  Projekt.......: CBService
//  Name..........: CBody.cs
//  Aufgabe/Fkt...: Datenvertrag: Klasse der Himmelkörper
//                  
//
//
//
//
//<unit_environment>
//------------------------------------------------------------------
//  Zielmaschine..: PC 
//  Betriebssystem: Windows XP mit .NET 2.0
//  Werkzeuge.....: Visual Studio 2005
//  Autor.........: Martin Korneffel (mko)
//  Version 1.0...: 
//
// </unit_environment>
//
//<unit_history>
//------------------------------------------------------------------
//
//  Version.......: 1.1
//  Autor.........: Martin Korneffel (mko)
//  Datum.........: 
//  Änderungen....: 
//
//</unit_history>
//</unit_header>        
        

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;


namespace CBService
{
    // Verwenden Sie einen Datenvertrag, wie im folgenden Beispiel dargestellt, um Dienstvorgängen zusammengesetzte Typen hinzuzufügen.
    // Sie können im Projekt XSD-Dateien hinzufügen. Sie können nach dem Erstellen des Projekts dort definierte Datentypen über den Namespace "CBService.ContractType" direkt verwenden.
    [DataContract(Namespace = "www.mkoit.de/Kepler")]
    public class CBody
    {

        [DataMember]
        public string Name
        {
            get;
            set;
        }

        [DataMember]
        double MassInKg { get; set; }
    }

}
