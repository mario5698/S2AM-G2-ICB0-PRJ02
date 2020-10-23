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
<<<<<<< HEAD
            //Application.Run(new Menu("admin"));
            Application.Run(new Login());
=======
            Application.Run(new Login());
            //Application.Run(new Login());
>>>>>>> dcf73996837e36ddae85def7be6efcc44915369d
        }
    }
}
