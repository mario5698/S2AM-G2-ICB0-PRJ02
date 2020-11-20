using Acceso_Dades;
using BlibliotecaG2;
using Controles_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Users : Form
    {
        Acceso obj;
        Encrypt cry;
        DataTable infotabla;
        string tabla = "users";
        bool nuevo = false;
        DataRow row;

        public Users()
        {
            InitializeComponent();
            obj = new Acceso();
            cry = new Encrypt();
            Portar_Dades();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Info_Textbox();
            Dtg_header();
            cancel.Hide();
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
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.BackColor = Color.PaleGreen;
                    ctr.ForeColor = Color.FromArgb(50, 60, 70);
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("Text", infotabla, ((SWTextbox)ctr).Nom_BBDD.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!nuevo)
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            cancel.Show();
            row = infotabla.NewRow();
            nuevo = true;
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    user_id_swtxb.Text = "0";
                    specie_id_swtxb.Text = "1";
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
            bool vacios = false;
            if (nuevo)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SWTextbox))
                    {
                        if (((SWTextbox)ctr).obligatorio && ctr.Text == string.Empty)
                        {
                            vacios = true;
                        }
                        else
                        {
                            row[((SWTextbox)ctr).Nom_BBDD.ToString()] = ctr.Text;
                        }
                    }
                }
                if (!vacios)
                {
                    

                    row["salt"] = "saladito, bien fresco, chopeadito";
                    row["Password"] = "ignorame soy un hash";
                    infotabla.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("CAMPOS OBLIGATORIOS VACIOS O TIPO DE DATO INCORRECTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            nuevo = false;
            obj.Actualitzar();
            Portar_Dades();
            Info_Textbox();
            cancel.Hide();
        }

        private void specie_id_swtxb_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse((specie_id_swtxb.Text), out int outbound))
            {
                if (outbound <= 0 || outbound > 17)
                {
                    MessageBox.Show("DATO FUERA DE RANGO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    specie_id_swtxb.Text = string.Empty;
                }
            }
        }
    }
}

