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
using Acceso_Dades;
using System.Data.SqlClient;

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

            Acceso acc = new Acceso();



            string consulta = "select * from users where login = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";

            if (acc.Verficar_User(consulta))
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
