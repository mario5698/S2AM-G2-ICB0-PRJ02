using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BlibliotecaG2
{
    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.GotFocus += new System.EventHandler(this.SWTextbox_Enter);
            this.LostFocus += new System.EventHandler(this.SWTextbox_leave);
            this.ResumeLayout(false);
            }

        #region Declaracion Variables
        public enum TipusDada
        {
            Text,
            Data,
            Codi
        }
        bool _Foranea,_Obligatorio; 
        private TipusDada _DadaPermesa;
        string _datos;
        String _NombreBBDD;

        #endregion

        #region Entrada Eventos
        public bool obligatorio
        {
            get { return _Obligatorio; }
            set { _Obligatorio = value; }
        }

        public String Nom_BBDD
        {
            get { return _NombreBBDD; }
            set { _NombreBBDD = value; }
        }

        public bool Foranea
        {
            get { return _Foranea; }
            set { _Foranea = value; }
        }

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set{ _DadaPermesa = value;}
        }

        public String dada
        {
            get { return _datos; }
            set { _datos = value; }
        }
        #endregion 



        #region Validacion de entrada
        private void SWTextbox_Validate()
        {
            if (_DadaPermesa == TipusDada.Data)
            {
                DateTime _val;
                bool fecha = DateTime.TryParse(_datos, out _val);
            
                if (!fecha)
                {                  
                  MessageBox.Show("data invalida");
                }
            }
            else if (_DadaPermesa == TipusDada.Codi)
            {
                Regex rx = new Regex(@"^[A-Z]{4}-\d{3}/[1,3,5,7,9][A-Z]{1}$");
                if (obligatorio)
                {
                    MatchCollection matches = rx.Matches(_datos);
                    if (matches.Count == 0)
                    {
                        String mensaje = "El campo esta vacio o los datos introducidos con Incorrectos";
                        ShowAlert(mensaje);
                    }
                }   
            }
        }
        #endregion


        private void ShowAlert(String informacion)
        {
            NotifyIcon n = new NotifyIcon();
            n.BalloonTipTitle = "Error de " + _DadaPermesa;
            n.BalloonTipText = informacion;
            n.Icon = SystemIcons.Warning;
            n.BalloonTipIcon = ToolTipIcon.Warning;
            n.Visible = true;
            n.ShowBalloonTip(50000);
            n.Dispose();

        }

        private void SWTextbox_leave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            if (_Obligatorio && (_datos == ""))
            {
                String mensaje = "Este campo es obligatorio";
                ShowAlert(mensaje);
            }
            else
            {
                SWTextbox_Validate();
            }
        }
        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
