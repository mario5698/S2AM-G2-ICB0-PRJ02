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

        public Splash(String user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum) progressBar.Value += 10;
            else
            {
                timer.Enabled = false;
                Menu menu = new Menu(user);
                this.Hide();
                menu.Show();
            }
            
        }
    }
}
