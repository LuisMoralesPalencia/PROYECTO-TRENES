using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_TRENES.InicioYRegistro;
using PROYECTO_TRENES.Modulo_Usuarios;

namespace PROYECTO_TRENES
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicioSesion());
            //Application.Run(new FormRellenarDatosBoleto());
            //Application.Run(new FormResumenBoleto());
        }
    }
}
