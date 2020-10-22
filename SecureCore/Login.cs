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
using System.Diagnostics;
using System.Runtime.InteropServices;
using ClassConnection;
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
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "admin")
            {
                Splash obj = new Splash(txtUsername.Text);
                this.Hide();
                obj.Show();
            }
            else
            {
                VolMax(4);
                System.IO.Stream str = Properties.Resources.alert;
                SoundPlayer snd = new System.Media.SoundPlayer(str);
                
                snd.Play();
                botones = MessageBoxButtons.OK;
                MessageBox.Show(message, titulo_Msgbox, botones);
                VolMin();
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

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void VolMax(int up) { for (int i = 0; i < up; i++) VolUp(); }

        private void VolMin()
        {
            for (int i = 0; i < 100; i++)
            {
               SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
            }
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }
    }
}
