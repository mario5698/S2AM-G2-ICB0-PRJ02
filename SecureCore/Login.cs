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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void LogIn(object sender, EventArgs e)
        {
            String message, titulo_Msgbox;
            message = ("Usuario o Contraseña incorrecta");
            titulo_Msgbox ="ERROR";
            MessageBoxButtons botones;
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "admin")
            {
                Menu obj = new Menu();
                this.Close();
                obj.Show();
            }
            else
            {

                botones = MessageBoxButtons.YesNo;
                MessageBox.Show(message, titulo_Msgbox, botones);
            }
          
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
