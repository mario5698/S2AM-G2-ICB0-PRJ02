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
            dtgUsers.DataSource = obj.Traer_Datos("users");
            string[] registro = new string[dtgUsers.Rows[0].Cells.Count];
            for (int i = 0; i < registro.Length; i++) registro[i] = dtgUsers.Rows[0].Cells[i].Value.ToString();
            MessageBox.Show(obj.connectionString);
        }

        private void Users_Load(object sender, EventArgs e)
        {
        }
    }
}
