using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopyfy_Ransomware
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// Restart and run as admin
            //var exeName = Process.GetCurrentProcess().MainModule.FileName;
            //ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
            //startInfo.Verb = "runas";
            //startInfo.Arguments = "restart";
            //Process.Start(startInfo);
            //Application.Exit();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
