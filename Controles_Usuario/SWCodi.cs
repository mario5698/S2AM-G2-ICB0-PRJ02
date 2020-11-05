using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Dades;
using BlibliotecaG2;

namespace Controles_Usuario
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
            SW_CodiText.Visible = false;
        }

        #region Declarar Variables

        private bool _Requerit;

        private String _NomCodi;

        private String _NomTaula;

        private String _NomDesc;

        private String _NomId;

        private String _FormCS;

        private String _ClasseCs;

        private String _ControlID;

        #endregion

        #region propfulls 


        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }
        
        public String NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        public String NomCodi
        {
            get { return _NomCodi; }
            set { _NomCodi = value; }
        }

        public String NomDesc   
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }

        public String NomId 
        {
            get { return _NomId; }
            set { _NomId = value; }
        }
        
        public String FormCS
        {
            get { return _FormCS; }
            set { _FormCS = value; }
        }

        public String ClasseCS
        {
            get { return _ClasseCs; }
            set { _ClasseCs = value; }
        }

        public String ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }


        #endregion

        private void TXT_SWCodi_Leave(object sender, EventArgs e)
        {
            Acceso acc = new Acceso();

            string consulta = "select * from " + _NomTaula + " where " + _NomCodi + "= '" + TXT_SWCodi.Text + "'";
            DataSet dts = acc.PortarPerConsulta(consulta);

            if (dts.Tables[0].Rows.Count > 0)
            {
                TXT_SWDesc.Text = dts.Tables[0].Rows[0][_NomDesc].ToString();
            }
            else
            {
                TXT_SWDesc.Text = "Unknow Data";
            }

        }

        private void TXT_SWDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_SWCodi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

