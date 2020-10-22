using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Diagnostics;
using System.Runtime.InteropServices;
using ClassConnection;
using System.Data.SqlClient;
=======
using Acceso_Dades;
>>>>>>> 4ba48699e29bad24df9c4f48a4b7c3eae118b942

namespace SecureCore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
<<<<<<< HEAD
=======

>>>>>>> 4ba48699e29bad24df9c4f48a4b7c3eae118b942
        }

        void LogIn(object sender, EventArgs e)
        {
            String message, titulo_Msgbox;
            message = ("Usuario o Contraseña incorrecta");
            titulo_Msgbox ="ERROR";

            MessageBoxButtons botones;

            Acceso acc = new Acceso();
            acc.Verficar_User(txtUsername.Text, txtPassword.Text); 

            if (acc.Verficar_User(txtUsername.Text, txtPassword.Text) == true)
            {
                Splash obj = new Splash(txtUsername.Text);
                this.Hide();
                obj.Show();
            }
            else
            {
                System.IO.Stream str = Properties.Resources.alert;
                SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                botones = MessageBoxButtons.OK;
                MessageBox.Show(message, titulo_Msgbox, botones);
            }
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) LogIn(sender, e);
        }

        private void ShowPassword(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void StartTimer(object sender, MouseEventArgs e)
        {
            timerPassword.Enabled = true;
        }

        private void StopTimer(object sender, MouseEventArgs e)
        {
            timerPassword.Enabled = false;
            txtPassword.PasswordChar = 'Ω';
        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
