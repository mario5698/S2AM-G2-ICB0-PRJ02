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
    public partial class usuarios : Form_Base.Form_base
    {
        public usuarios()
        {
            InitializeComponent();
            tabla = "users";
            has_pass = true;
            dtg_head = new string[11] { "Id", "Codigo", "Nombre", "Login", "Contraseña", "Rango",
                "Categoria", "Imagen", "Id Planeta", "Id Specie", "Sal"};
        }
    }
}
