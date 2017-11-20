using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CBService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class CreateCBSys : ICreateCBSys
    {
        CreateCBSysWorkFlowStates ActiveState = CreateCBSysWorkFlowStates.Start;

        CBSys Sys = new CBSys();

        public CreateCBSysWorkFlowStates Begin()
        {
            if (ActiveState != CreateCBSysWorkFlowStates.Start && ActiveState != CreateCBSysWorkFlowStates.Fin && ActiveState != CreateCBSysWorkFlowStates.Cancel)
                return CreateCBSysWorkFlowStates.Error;

            ActiveState = CreateCBSysWorkFlowStates.SelectCentralBody;

            Sys = new CBSys();

            return ActiveState;
            
        }

        public CreateCBSysWorkFlowStates Cancel()
        {
            ActiveState = CreateCBSysWorkFlowStates.Cancel;
            return ActiveState;
        }

        public CreateCBSysWorkFlowStates Reset()
        {
            ActiveState = CreateCBSysWorkFlowStates.Fin;
            return ActiveState;
        }

        public CreateCBSysWorkFlowStates SetCentralBody(CBody CentralBody)
        {
            if (ActiveState != CreateCBSysWorkFlowStates.SelectCentralBody)
            {
                ActiveState = CreateCBSysWorkFlowStates.Error;
                return ActiveState;
            }


            Sys.CentralBody = CentralBody;
            ActiveState = CreateCBSysWorkFlowStates.SelectSatellite;
            return ActiveState;
        }

        public CreateCBSysWorkFlowStates SetSatellite(CBody Satellite)
        {
            if (ActiveState != CreateCBSysWorkFlowStates.SelectSatellite)
            {
                ActiveState = CreateCBSysWorkFlowStates.Error;
                return ActiveState;
            }

            Sys.Satellites.Add(Satellite);

            ActiveState = CreateCBSysWorkFlowStates.SelectSatellite;
            return ActiveState;
        }

        public CreateCBSysWorkFlowStates SetLastSatelliteEnd(CBody Satellite)
        {
            if (ActiveState != CreateCBSysWorkFlowStates.SelectSatellite)            
            {
                ActiveState = CreateCBSysWorkFlowStates.Error;
                return ActiveState;
            }

            Sys.Satellites.Add(Satellite);

            ActiveState = CreateCBSysWorkFlowStates.CreateCBSys;
            return ActiveState;
        }

        CreateCBSysWorkFlowStates ICreateCBSys.CreateCBSys(out CBSys NewCBSys)
        {
            NewCBSys = Sys;
            if (ActiveState == CreateCBSysWorkFlowStates.CreateCBSys)
            {
                ActiveState = CreateCBSysWorkFlowStates.Fin;
            }
            else
            {
                ActiveState = CreateCBSysWorkFlowStates.Error;
            }

            return ActiveState;
        }
    }
}
