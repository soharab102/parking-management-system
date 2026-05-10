using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking_management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            // Application.Run(new register());

            Application.Run(new login());

            //Application.Run(new dashboard());
            // Application.Run(new Form1());
            //Application.Run(new delete());
            //Application.Run(new add());
           // Application.Run(new update());

        }
    }
}
