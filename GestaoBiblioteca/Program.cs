using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca
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

            // Efetuar autenticação
            Application.Run(new GUI.FormAutenticacao());

            // Executar a form principal
            Application.Run(new FormPrincipal());
        }
    }
}
