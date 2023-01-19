using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RedLine
{
    static class Program
    {
        static readonly Mutex mutex = new Mutex(false, "RedLineInSysTray");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // prevent the program from being run more than once.
            if(!mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                MessageBox.Show("Application already running.  Check the system tray.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RedLine());
            }
            finally
            {
                mutex.ReleaseMutex();
            }

        }
    }
}
