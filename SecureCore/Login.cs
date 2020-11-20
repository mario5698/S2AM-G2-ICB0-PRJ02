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

        private static string generateSalt()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();
            for (int i = 0; i < 5; i++) stringChars[i] = chars[random.Next(chars.Length)];
            return new String(stringChars);
        }

        void LogIn(object sender, EventArgs e)
        {
            generateSalt();
            String message, titulo_Msgbox;
            titulo_Msgbox = "ERROR";
            message = ("Usuario o Contraseña incorrecta");
            MessageBoxButtons botones;
            String user = txtUsername.Text;
            String password = txtPassword.Text;
            string rank = "idUserRank";
            Acceso acc = new Acceso();
            String rango = "";
            string tabla = "users";
            string consulta = "select * from "+ tabla +" where login = '" + user + "' and password = '" + password + "'";

            if (acc.LoginCorrecto(user, password))
            {
                DataSet dts = acc.PortarPerConsulta(consulta, tabla);
                //int usuaris = dts.Tables[tabla].Rows.Count;
                rango = dts.Tables[0].Rows[0][rank].ToString();
                Splash obj = new Splash(user, rango);
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


        private new void Enter(object sender, KeyPressEventArgs e)
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
