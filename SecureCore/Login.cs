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
            String message;
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "admin")
            {
                message = "OK";
            }
            else
            {
                message = "NOT OK";
            }
            MessageBox.Show(message);
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
