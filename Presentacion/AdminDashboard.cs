using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.Entidades;

namespace GymApp.Presentacion
{
    public partial class AdminDashboard : Form
    {
        private Miembro usuarioActual;

        public AdminDashboard(Miembro miembro)
        {
            InitializeComponent();
            usuarioActual = miembro;
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.Nombre} (Administrador)";
        }

        // Ejemplo de un evento para el botón "Gestionar Miembros"
        private void btnGestionarMiembros_Click_1(object sender, EventArgs e)
        {
            // Aquí abrirías el formulario para la gestión de miembros
            // Ejemplo:
            // MiembrosForm formMiembros = new MiembrosForm();
            // formMiembros.ShowDialog();
        }


        // Puedes agregar eventos similares para los otros botones.
    }
}
