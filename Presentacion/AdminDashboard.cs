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
        // Variable para almacenar el usuario actual, que en este caso es el administrador.
        private Miembro usuarioActual;

        public AdminDashboard(Miembro miembro)
        {
            InitializeComponent();
            usuarioActual = miembro;
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.Nombre} (Administrador)";
        }

        private void btnGestionarMiembros_Click_1(object sender, EventArgs e)
        {
            MiembrosForm miembrosForm = new MiembrosForm();
            miembrosForm.ShowDialog();
        }

        private void btnGestionarClases_Click_1(object sender, EventArgs e)
        {
            ClasesForm clasesForm = new ClasesForm();
            clasesForm.ShowDialog();
        }

        private void btnGestionarEntrenadores_Click_1(object sender, EventArgs e)
        {
            EntrenadoresForm entrenadoresForm = new EntrenadoresForm();
            entrenadoresForm.ShowDialog();
        }

        private void btnGestionarReservas_Click_1(object sender, EventArgs e)
        {
            ReservaForm reservasForm = new ReservaForm(usuarioActual);
            reservasForm.ShowDialog();
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            ReportesForm reportesForm = new ReportesForm();
            reportesForm.ShowDialog();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
