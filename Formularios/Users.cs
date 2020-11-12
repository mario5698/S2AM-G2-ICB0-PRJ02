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
            Portar_Dades();
        }

        private void Portar_Dades()
        {
            infotabla = obj.PortarTaula(tabla);
            dtgUsers.DataSource = infotabla;
        }


        private void Dtg_header()
        {
            dtgUsers.Columns[0].HeaderText = "ID";
            dtgUsers.Columns[1].HeaderText = "U_CODE";
            dtgUsers.Columns[2].HeaderText = "U_NAME";
            dtgUsers.Columns[3].HeaderText = "LOGIN";
            dtgUsers.Columns[4].HeaderText = "PASS";
            dtgUsers.Columns[5].HeaderText = "U_ID_RANK";
            dtgUsers.Columns[6].HeaderText = "U_ID_CATEG";
            dtgUsers.Columns[7].HeaderText = "PHOTO";
            dtgUsers.Columns[8].HeaderText = "PLANET_ID";
            dtgUsers.Columns[9].HeaderText = "SPECIE_ID";
        }

        private void Info_Textbox()
        {
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
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
            Dtg_header();
            cancel.Hide();
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
                    txb1.Text = "0";
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Info_Textbox();
            cancel.Hide();
        }

        private void Actualizar_Base_Click(object sender, EventArgs e)
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
            nuevo = false;
            obj.Actualitzar();
            Portar_Dades();
            Info_Textbox();
            cancel.Hide();
        }
    }
}

