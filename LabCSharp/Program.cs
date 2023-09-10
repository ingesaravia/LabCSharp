using System;
using System.Windows.Forms;

namespace LabCSharp
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
            Principal miPrincipal = new Principal();
            //miPrincipal.Width = Screen.PrimaryScreen.Bounds.Width - 100;
            //miPrincipal.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            Application.Run(miPrincipal);
        }
    }
}
