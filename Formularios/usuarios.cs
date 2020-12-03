using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class usuarios : Form_Base.Form_base
    {
        DataGridView dtgUsers;
        public usuarios()
        {
            InitializeComponent();
            tabla = "users";
            has_pass = true;

            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(DataGridView))
                {
                    dtgUsers = (DataGridView) ctr;
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }


        protected void OpenImage()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                byte[] imgBytes = imageToByteArray(img);
                infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"] = imgBytes;

                foreach (Control ctr in Controls)
                {
                    if (ctr.GetType() == typeof(PictureBox))
                    {
                        ctr.BackgroundImage = img;
                    }
                }
            }
        }

    }
}
