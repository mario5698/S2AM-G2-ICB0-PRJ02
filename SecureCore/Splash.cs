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
    public partial class Splash : Form
    {
        String user;
        int contador = 1;
        public Splash(String user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contador += 1;
            progressBar.Increment(4);
            if (contador == 31)
            {
                Menu menu = new Menu(user);
                this.Hide();
                menu.Show();
                timer.Enabled = false;

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
