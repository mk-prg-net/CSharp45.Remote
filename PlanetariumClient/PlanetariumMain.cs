using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetariumClient
{
    public partial class PlanetariumMain : WinFormTemplates.WinFormTemplate1
    {
        public PlanetariumMain()
        {
            InitializeComponent();
        }

        CBService.CreateCBSysClient proxy = new CBService.CreateCBSysClient();

        private void btnStartInputBegin_Click(object sender, EventArgs e)
        {
            var stat = proxy.Begin();
            SignalStateOnGui(stat);
        }

        private void SignalStateOnGui(CBService.CreateCBSysWorkFlowStates stat)
        {
            rbtCancel.Checked = false;
            rbtCreateCBSys.Checked = false;
            rbtError.Checked = false;
            rbtFin.Checked = false;
            rbtSelectCentralBody.Checked = false;
            rbtSelectSatellite.Checked = false;
            rbtStart.Checked = false;
            switch (stat)
            {
                case CBService.CreateCBSysWorkFlowStates.Error:
                    rbtError.Checked = true;
                    break;
                case CBService.CreateCBSysWorkFlowStates.Cancel:
                    rbtCancel.Checked = true;
                    break;
                case CBService.CreateCBSysWorkFlowStates.SelectCentralBody:
                    rbtSelectCentralBody.Checked = true;
                    break;
                case CBService.CreateCBSysWorkFlowStates.CreateCBSys:
                    rbtCreateCBSys.Checked = true;
                    break;
                case CBService.CreateCBSysWorkFlowStates.Fin:
                    rbtFin.Checked = true;
                    break;
                case CBService.CreateCBSysWorkFlowStates.SelectSatellite:
                    rbtSelectSatellite.Checked = true;
                    break;
                case CBService.CreateCBSysWorkFlowStates.Start:
                    rbtStart.Checked = true;
                    break;
                default: throw new Exception("Automatenfehler");
            }
        }

        private void btnSetCentralBody_Click(object sender, EventArgs e)
        {
            var centralBody = new CBService.CBody(){ MassInKg = 1000, Name = tbxCentralBodyName.Text};
            var stat = proxy.SetCentralBody(centralBody);
            SignalStateOnGui(stat);
        }

        private void btnSelectCentralBodyInputCancel_Click(object sender, EventArgs e)
        {
            var stat = proxy.Cancel();
            SignalStateOnGui(stat);
        }

        private void btnSelectSatelliteInputAdd_Click(object sender, EventArgs e)
        {
            var satellite = new CBService.CBody() { MassInKg = 1000, Name = tbxSatellite.Text };
            var stat = proxy.SetSatellite(satellite);
            SignalStateOnGui(stat);

        }

        private void btnSelectSatelliteInputAddLast_Click(object sender, EventArgs e)
        {
            var satellite = new CBService.CBody() { MassInKg = 1000, Name = tbxSatellite.Text };
            var stat = proxy.SetLastSatelliteEnd(satellite);
            SignalStateOnGui(stat);

        }

        private void btnSelectSatelliteCancel_Click(object sender, EventArgs e)
        {
            var stat = proxy.Cancel();
            SignalStateOnGui(stat);
        }

        CBService.CBSys NewSys = new CBService.CBSys();

        private void btnCreateCBSysInputCreate_Click(object sender, EventArgs e)
        {
            var stat = proxy.CreateCBSys(out NewSys);
            SignalStateOnGui(stat);

            lblResultCentralBody.Text = NewSys.CentralBody.Name;

            bindingSourceSatellites.DataSource = NewSys.Satellites;
            bindingSourceSatellites.ResetBindings(false);
        }

        private void btnCreateCBSysInputCancel_Click(object sender, EventArgs e)
        {
            var stat = proxy.Cancel();
            SignalStateOnGui(stat);

        }

        private void btnCancelInputReset_Click(object sender, EventArgs e)
        {
            var stat = proxy.Reset();
            SignalStateOnGui(stat);

        }

        private void btnErrorInputReset_Click(object sender, EventArgs e)
        {
            var stat = proxy.Reset();
            SignalStateOnGui(stat);

        }
    }
}
