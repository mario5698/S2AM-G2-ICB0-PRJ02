using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Dades;

namespace Edi_Proces
{
    public partial class Edi : Form
    {
        public Edi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procesar_Edi edi = new Procesar_Edi();
            edi.Split();
        }
    }
}
