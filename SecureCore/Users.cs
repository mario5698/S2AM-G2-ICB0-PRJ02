using Acceso_Dades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCore
{
    public partial class Users : Form
    {
        Acceso obj = new Acceso();
        DataTable info_tabla;
        string tabla = "users";
        public Users()
        {
            InitializeComponent();
            info_tabla = obj.Traer_Tabla(tabla);
            dtgUsers.DataSource = info_tabla;
        }

        private void Info_Textbox()
        {
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    ctr.DataBindings.Add("Text", info_tabla, ctr.Tag.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }


        private void Users_Load(object sender, EventArgs e)
        {
            Info_Textbox();
            obj.Store();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.Actualizar_BBDD();

        }
    }
}
