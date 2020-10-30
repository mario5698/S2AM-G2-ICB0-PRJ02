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
        DataTable infotabla;
        string tabla = "users";
        bool nuevo = false;
        DataRow row;
        public Users()
        {
            InitializeComponent();
            infotabla = obj.PortarTaula(tabla);
            dtgUsers.DataSource = infotabla;
        }

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
            if (!nuevo)
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }


        private void Users_Load(object sender, EventArgs e)
        {
            Info_Textbox();
            cancel.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                foreach (Control ctr in panel1.Controls)
                {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        row[ctr.Tag.ToString()] = ctr.Text;
                    }
                }
                infotabla.Rows.Add(row);
            }
            obj.Actualitzar();
        }

        private void add_Click(object sender, EventArgs e)
        {
            cancel.Show();
            row = infotabla.NewRow();
            nuevo = true;
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    txb1.Text = "AUTO";
                }
            }
        }
<<<<<<< HEAD

        private void cancel_Click(object sender, EventArgs e)
        {
            Info_Textbox();
            cancel.Hide();
        }
=======
>>>>>>> fce938f036f64483f2b1c2f2401f05d506a63f51
    }
}

