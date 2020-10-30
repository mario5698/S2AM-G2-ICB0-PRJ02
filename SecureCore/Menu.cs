using Acceso_Dades;
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
        // Declaracion de variables 
        bool Hide_Panel = false;
        int Max_Size = 200, Min_Size = 0;
        // Esta variable guardar el formulario en uso y despues poder cambiar el tamaño de este cuando el panel izquierdo se esconda
        Form InUse;
        public Menu(String user)
        {

            InitializeComponent();
            Welcome myForm = new Welcome(user);
            ShowFroms(myForm);
            InUse = myForm;
            lblUser.Text = user;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Hide_panel_left(Hide_Panel);
         
        }

        private void Hide_panel_left(bool  hide_panel) 
        {
            if (hide_panel != true)
            {
                for (int i = Max_Size; i >= Min_Size; i--)
                {
                    pnl_left.Size = new Size(i, pnl_left.Height);
                    InUse.Size = new Size(pnl_rigth.Width - Min_Size, pnl_rigth.Height);
                }
                Hide_Panel = true;
            }
            else
            {
                for (int i = Min_Size; i <= Max_Size; i++)
                {
                    pnl_left.Size = new Size(i, pnl_left.Height);
                    InUse.Size = new Size(pnl_rigth.Width, pnl_rigth.Height);
                }
                Hide_Panel = false;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void btn_Opt2_Click(object sender, EventArgs e)
        {

            MaintenancePage();
        }

        private void btn_Opt4_Click(object sender, EventArgs e)
        {
            Form_Base.Form_Base frm = new Form_Base.Form_Base();
            frm.Show();
        }

        private void btn_Opt3_Click(object sender, EventArgs e)
        {
            MaintenancePage();
        }

        private void pnl_rigth_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaintenancePage()
        {
            Users myForm = new Users();
            ShowFroms(myForm);
            InUse = myForm;

        }
    }
}
