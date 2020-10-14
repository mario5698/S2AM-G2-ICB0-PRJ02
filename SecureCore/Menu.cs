using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCore
{
    public partial class Menu : Form
    {

        bool esconder = false;
        int maxsize = 200, minsize = 0, extencion = 0;
        Form InUse;
        public Menu()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (esconder != true)
            {
                for (int i = maxsize; i >= minsize; i--)
                {
                    pnl_left.Size = new Size(i, pnl_left.Height);
                    InUse.Size = new Size(pnl_rigth.Width - minsize, pnl_rigth.Height);
                }
                esconder = true;
            }
            else
            {
                for (int i = minsize; i <= maxsize; i++)
                {
                    pnl_left.Size = new Size(i, pnl_left.Height);
                     InUse.Size =new Size(pnl_rigth.Width, pnl_rigth.Height);
                }
                esconder = false;
            }
        }


        private void btn_Opt2_Click(object sender, EventArgs e)
        {

            MaintenancePage();
        }

        private void btn_Opt1_Click(object sender, EventArgs e)
        {

            Reto1 myForm = new Reto1();
            ShowFroms(myForm);
            InUse = myForm;
        }

        private void ShowFroms( Form myForm ) 
        {
            pnl_rigth.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
           myForm.Size = new Size(pnl_rigth.Width, pnl_rigth.Height);
            pnl_rigth.Controls.Add(myForm);
            myForm.Show();


        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {
  

        }

        private void pnl_left_Resize(object sender, EventArgs e)
        {
        }

        private void btn_Opt3_Click(object sender, EventArgs e)
        {

        }

        private void MaintenancePage()
        {
            Mantenimiento myForm = new Mantenimiento();
            ShowFroms(myForm);
            InUse = myForm;

        }

    }
}
