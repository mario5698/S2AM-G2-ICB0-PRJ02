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
            Application.Run(new Login());
          //  Application.Run(new TestUserControl());
=======
            //Application.Run(new Menu("admin"));
            Application.Run(new Login());
            Application.Run(new TestUserControl());
>>>>>>> 48150860bbb343072e87e5fbd9dbbb2188dd1d82
        }
    }
}
