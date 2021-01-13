using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Dades;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.Shared;

namespace Formularios
{
    public partial class usuarios : Form_Base.Form_base
    {
        DataGridView dtgUsers;
        Acceso con = new Acceso();
        public usuarios()
        {
            InitializeComponent();
            tabla = "users";
            has_pass = true;
            dtg_head = new string[11] { "Id", "Codigo", "Nombre", "Login", "Contraseña", "Sal",
                "Rango", "Id Categoria", "Imagen", "Id Planeta", "Id Specie"};

            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(DataGridView))
                {
                    dtgUsers = (DataGridView) ctr;
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenImage(nuevo);
        }

        private void OpenImage(bool nuevo)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                byte[] imgBytes = imageToByteArray(img);

                if(nuevo) row["photo"] = imgBytes;
                else infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"] = imgBytes;

                foreach (Control ctr in Controls)
                {
                    if (ctr.GetType() == typeof(PictureBox))
                    {
                        ctr.BackgroundImage = img;
                    }
                }
            }
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void swCodi2_Load(object sender, EventArgs e)
        {

        }

        private void swCodi1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl10_Click(object sender, EventArgs e)
        {

        }

        private void lbl8_Click(object sender, EventArgs e)
        {

        }

        private void lbl9_Click(object sender, EventArgs e)
        {

        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void specie_id_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void planet_id_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void user_id_category_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void id_user_rank_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void login_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_cod_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_name_swtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();

            cryRpt.Load("../Formularios/report.rpt");
            crConnectionInfo.ServerName = "ATHERIS\\SQLEXPRESS";
            crConnectionInfo.IntegratedSecurity = true;
            crConnectionInfo.DatabaseName = "SecureCore";
            Tables CrTables = cryRpt.Database.Tables;

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            cryRpt.RecordSelectionFormula = "{Command.idUser} = " + int.Parse(infotabla.Rows[dtgUsers.CurrentRow.Index][0].ToString());
            
            int printerId = 0;
            do printerId++;
            while (PrinterSettings.InstalledPrinters[printerId] != "Microsoft Print to PDF");

            cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\Users\Snake\Desktop\Card.pdf");
            
        }
    }
}
