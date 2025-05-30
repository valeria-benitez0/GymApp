using GymApp.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
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
            Application.Run(new Presentacion.LoginForm());
            //var conn = GymConnection.GetInstance().Connection;
            //MessageBox.Show(conn.ConnectionString); // si falla aquí, el problema es la conexión

        }
    }
}
