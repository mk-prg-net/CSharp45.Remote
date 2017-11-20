//<unit_header>
//----------------------------------------------------------------
//
// Martin Korneffel: IT Beratung/Softwareentwicklung
// Stuttgart, den 15.12.2014
//
//  Projekt.......: CBService
//  Name..........: ICreateCBSys
//  Aufgabe/Fkt...: Dienstvertrag: Erzeugen eines Systems aus Himmelskörpern (z.B. Solarsystem)
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
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CBService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IService1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface ICreateCBSys
    {     

        [OperationContract]
        CreateCBSysWorkFlowStates Begin();

        [OperationContract]
        CreateCBSysWorkFlowStates Cancel();

        [OperationContract]
        CreateCBSysWorkFlowStates Reset();        


        [OperationContract]
        CreateCBSysWorkFlowStates SetCentralBody(CBody CentralBody);

        [OperationContract]
        CreateCBSysWorkFlowStates SetSatellite(CBody Satellite);

        [OperationContract]
        CreateCBSysWorkFlowStates SetLastSatelliteEnd(CBody Satellite);

        [OperationContract]
        CreateCBSysWorkFlowStates CreateCBSys(out CBSys NewCBSys);

    }
}
