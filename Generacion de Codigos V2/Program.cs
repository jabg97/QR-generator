using Generacion_codigos_V2.Vistas;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Generacion_codigos_V2
{
    static class Program
    {

        public static Hashtable config { get; set; }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainView());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
    }
}
