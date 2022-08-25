using DevExpress.UserSkins;
using sysSales.Main;
using System;
using System.Windows.Forms;

namespace sysSales
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new frmMain());
        }
    }
}