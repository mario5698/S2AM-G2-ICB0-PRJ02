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
            dtgUsers.DataSource = obj.Traer_Datos();
        }

        private void Users_Load(object sender, EventArgs e)
        {
        }
    }
}
