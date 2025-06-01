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
            //var conn = GymConnection.GetInstance().Connection;
            //MessageBox.Show("Conexión: " + conn.ConnectionString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Presentacion.LoginForm());

        }
    }
}
