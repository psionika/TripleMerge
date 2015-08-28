using System;
using System.Windows.Forms;

namespace TripleMerge
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
            using (var formMain = new FormMain())
            {
                Application.Run(formMain);
            }
        }
    }
}
