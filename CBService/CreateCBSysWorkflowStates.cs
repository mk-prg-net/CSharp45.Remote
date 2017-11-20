//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 15.12.2014
//
//  Projekt.......: CBService
//  Name..........: CreateCBSysWorkflowState.cs
//  Aufgabe/Fkt...: DAtenvertrag: alle Zusände, die ein Workflow zum erstellen eines 
//                  Himmelskörpersystems durchläuft.
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
using System.Runtime.Serialization;
using System.ServiceModel;

using System.Threading.Tasks;

namespace CBService
{
    [DataContract(Namespace = "www.mkoit.de/Kepler")]
    public enum CreateCBSysWorkFlowStates
    {
        [EnumMember]
        Start,

        [EnumMember]
        SelectCentralBody,

        [EnumMember]
        SelectSatellite,

        [EnumMember]
        CreateCBSys,

        [EnumMember]
        Fin,

        [EnumMember]
        Cancel,

        [EnumMember]
        Error
    }

}
