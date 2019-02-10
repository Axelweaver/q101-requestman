using System;
using System.Windows.Forms;

namespace Q101.Requestman
{
    /// <summary>
    /// Main Class Programm
    /// </summary>
    static class Program
    {
        public static string Version => "1.0.0-alpha";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndexForm());
        }
    }
}
