using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCore
{
    public partial class Menu : Form
    {

        bool esconder=false;
        int maxsize=200, minsize=0;
        public Menu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {


            if (esconder != true)
            {

                for (int i =maxsize;i>=minsize;i--)
                {
                    panel4.Size = new Size(i, panel4.Height);
                }
                //panel4.Size = new Size(0, panel4.Height);
                esconder = true;
            }
            else
            {
                for (int i = minsize; i <= maxsize; i++)
                {
                    panel4.Size = new Size(i, panel4.Height);
                }
                esconder = false;
            }

           

        }

        private void btn_Opt2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Opt1_Click(object sender, EventArgs e)
        {

            Reto1 myForm = new Reto1();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel5.Controls.Add(myForm);
            myForm.Show();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
          //  panel5.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void btn_Opt3_Click(object sender, EventArgs e)
        {

        }
    }
}
