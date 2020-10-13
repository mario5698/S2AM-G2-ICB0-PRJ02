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
        public Splash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum) progressBar.Value += 10;
            else
            {
                timer.Enabled = false;
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            
        }
    }
}
