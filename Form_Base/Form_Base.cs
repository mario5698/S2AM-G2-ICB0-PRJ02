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
using BlibliotecaG2;
using Controles_Usuario;

namespace Form_Base
{
    public partial class Form_base : Form
    {
        Acceso obj;
        Encrypt cry;
        DataTable infotabla;
        string tabla = "users";
        bool nuevo = false;
        DataRow row;

        public Form_base()
        {
            InitializeComponent();   
        }

        private void Users_Load(object sender, EventArgs e)
        {

            if (DesignMode) return;

            obj = new Acceso();
            cry = new Encrypt(); 
            Portar_Dades();
            Info_Textbox();
           // Dtg_header();
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
        
            nuevo = false;
            obj.Actualitzar();
            Portar_Dades();
            Info_Textbox();
            cancel.Hide();
        }
     
            }
        }
    
