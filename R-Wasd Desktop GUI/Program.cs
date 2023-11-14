using System;
using System.Threading;
using System.Windows.Forms;

namespace R_Wasd_Desktop_GUI
{
    internal static class Program
    {
        // Az alkalmazásban egyedülálló azonosító
        private static readonly string UniqueIdentifier = "YourUniqueIdentifierHere";

        // Mutex példány létrehozása
        private static Mutex mutex = new Mutex(true, UniqueIdentifier);

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmMain());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show("This program already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }*/
    }
}
