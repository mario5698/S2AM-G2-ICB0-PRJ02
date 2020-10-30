using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menu("admin"));
<<<<<<< HEAD
            Application.Run(new Login());
=======
            Application.Run(new TestUserControl());
>>>>>>> fce938f036f64483f2b1c2f2401f05d506a63f51
        }
    }
}
