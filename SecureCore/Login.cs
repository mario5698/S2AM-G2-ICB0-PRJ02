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
        Encrypt cry;

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
            cry = new Encrypt();
            String rango = "";
            string tabla = "users";
            string consulta = "select * from "+ tabla +" where login = '" + user + "' and password = '" + password + "'";

            string query = "select * from " + tabla + " where login = '" + user + "'";
            DataSet set = acc.PortarPerConsulta(query, tabla);

            string salDB = set.Tables[0].Rows[0]["salt"].ToString();
            string passwordDB = set.Tables[0].Rows[0]["Password"].ToString();

            byte[] bSal = cry.StringToBytes(salDB);
            byte[] bPass = cry.StringToBytes(passwordDB);

            MessageBox.Show(
                "Sal BD" + Environment.NewLine + salDB + Environment.NewLine +
                "Sal LOCAL" + Environment.NewLine + cry.BytesToString(bSal)
                );

            byte[] prueba = cry.Hash(txtPassword.Text, bSal);

            MessageBox.Show(
                "Password BD:" + Environment.NewLine + passwordDB + Environment.NewLine +
                "Password LO:" + Environment.NewLine + cry.BytesToString(prueba)
                );

            bool log = cry.BytesToString(prueba) == passwordDB;

            //bool log = cry.VerificarPass(txtPassword.Text, bSal, bPass);

            MessageBox.Show(log.ToString());


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
