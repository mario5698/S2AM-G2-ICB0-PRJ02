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
        public Users()
        {
            InitializeComponent();
            Acceso obj = new Acceso();
            DataTable info_tabla = obj.Traer_Tabla("factories");
            dtgUsers.DataSource = info_tabla;

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            DataTable t = info_tabla;
            textBox1.DataBindings.Add("Text", t, "idFactory");
            textBox1.Validated += new System.EventHandler(this.ValidarTextBox);
            textBox2.DataBindings.Add("Text", t, "codeFactory");
            textBox2.Validated += new System.EventHandler(this.ValidarTextBox);
           
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        private void Users_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      //  private void Crear_Textbox()
        //{
          //  for
        //}
    }
}
