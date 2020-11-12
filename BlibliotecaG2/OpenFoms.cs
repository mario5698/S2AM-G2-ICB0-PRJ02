using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace BlibliotecaG2
{
    public class OpenForm : Button
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OpenForm
            // 
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenForm_MouseClick);
            this.ResumeLayout(false);

        }


        private String _Classe;
        private String _NomForm;



        public String NomForm
        {
            get { return _NomForm; }
            set { _NomForm = value; }
        }



        public String Classe
        {
            get { return _Classe; }
            set { _Classe = value; }
        }



        private void OpenForm_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
