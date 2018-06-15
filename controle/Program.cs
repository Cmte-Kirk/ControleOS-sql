using System;
using System.Windows.Forms;

namespace ControleProg
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
            var controle = new FrmControle();
            Application.Run(controle);
        }
    }
}
