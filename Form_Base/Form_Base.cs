using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Dades;

namespace Form_Base
{
    public partial class Form_Base : Form
    {
        public Form_Base()
        {
            InitializeComponent();
            infotabla = obj.PortarTaula(tabla);
            dtgUsers.DataSource = infotabla;
            Info_Textbox();
        }

        Acceso obj = new Acceso();
        DataTable infotabla;
        string tabla = "species";

        private void Info_Textbox()
        {
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    ctr.DataBindings.Add("Text", infotabla, ctr.Tag.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void Actualizar_Base_Click(object sender, EventArgs e)
        {
            obj.Actualitzar();
        }
    }
}
