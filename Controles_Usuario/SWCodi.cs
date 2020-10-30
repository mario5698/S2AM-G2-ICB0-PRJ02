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

namespace Controles_Usuario
{
    public partial class SWCodi: UserControl
    {

        testcodi obj = new testcodi();

        public SWCodi()
        {
            InitializeComponent();
            SW_CodiText.Visible = false;
        }



        #region Declarar Variables

        private bool _Requerit;

        private String _codigo;

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

        public String NomCOdi
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
            TXT_SWDesc.Text = obj.getdesc(TXT_SWCodi.Text);

            if (_Requerit && (TXT_SWCodi.Text == ""))
            {
                SW_CodiText.Visible = _Requerit;
            }
            else
            {
                SW_CodiText.Visible = !_Requerit;
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

