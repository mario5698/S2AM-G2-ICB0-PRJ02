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
            Application.Run(new Login());
<<<<<<< HEAD
            //Application.Run(new Menu("admin"));
=======
>>>>>>> 4ba48699e29bad24df9c4f48a4b7c3eae118b942
        }
    }
}
