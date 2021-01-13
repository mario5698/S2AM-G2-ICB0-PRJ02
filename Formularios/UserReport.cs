using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class UserReport : Form
    {
        int idUser;

        public UserReport(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            // pasar el servidor
            // pasar credenciales
            // configurar el  Selection Formula

            ReportDocument cryRpt = new ReportDocument();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();


            cryRpt.Load("../Formularios/report.rpt");
            //crConnectionInfo.ServerName = "tcp:storm.ddns.net,1450";
            crConnectionInfo.ServerName = "ATHERIS\\SQLEXPRESS";
            //crConnectionInfo.UserID = "ATHERIS\\Snake";
            crConnectionInfo.IntegratedSecurity = true;
            //crConnectionInfo.Password = "9Yn3TAQxx3W5U9DL";
            crConnectionInfo.DatabaseName = "SecureCore";

            Tables CrTables = cryRpt.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            cryRpt.RecordSelectionFormula = "{Command.idUser} = " + idUser;
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }
    }
}
