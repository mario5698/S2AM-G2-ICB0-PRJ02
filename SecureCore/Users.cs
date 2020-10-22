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
            DataTable tabla = obj.Traer_Datos();
            
            dtgUsers.DataSource = tabla;

            textBox10.DataBindings.Clear();
            DataTable t = tabla;
            textBox1.DataBindings.Add("Text", t, "idUser");
            textBox1.Validated += new System.EventHandler(this.ValidarTextBox);
            textBox2.DataBindings.Add("Text", t, "CodeUser");
            textBox2.Validated += new System.EventHandler(this.ValidarTextBox);
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        private void Users_Load(object sender, EventArgs e)
        {
        }
        private void Blindings(DataTable tabla)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
