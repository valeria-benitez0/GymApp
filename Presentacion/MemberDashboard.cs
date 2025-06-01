using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.AccesoDatos;
using GymApp.Entidades;
using GymApp.Negocio;
using System.Configuration;

namespace GymApp.Presentacion
{
    public partial class MemberDashboard : Form
    {
        private Miembro usuarioActual;
        private ReservaService reservaService;

        public MemberDashboard(Miembro miembro)
        {
            InitializeComponent();
            usuarioActual = miembro;
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.Nombre}";

            // Mostrar información adicional opcional
            lblInfoMiembro.Text = $"Tipo de Membresía: {usuarioActual.TipoMembresia}\n" +
                                  $"Vencimiento: {usuarioActual.FechaVencimientoMembresia.ToShortDateString()}";

            // Inicializar el ReservaService para poder obtener las reservas del usuario
            reservaService = new ReservaService(new ReservaRepository(), new MiembroRepository(), new ClaseRepository());

            // Cargar inicialmente el listado de reservas
            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                var reservas = reservaService.ObtenerReservasPorMiembro(usuarioActual.UsuarioID);
                dgvReservas.DataSource = reservas.ToList(); // Conversión a lista en caso de que se retorne IEnumerable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message);
            }
        }


        private void btnRefrescarReservas_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void btnVerClases_Click_1(object sender, EventArgs e)
        {
        ReservaForm reservaForm = new ReservaForm(usuarioActual);
            reservaForm.ShowDialog();
        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            // Se abre el formulario de reserva para que el usuario registre una nueva reserva.
        ReservaForm reservaForm = new ReservaForm(usuarioActual);
            reservaForm.ShowDialog();

            // Puedes agregar código para actualizar el dgvReservas tras la operación.
        }

        private void btnCancelarReserva_Click_1(object sender, EventArgs e)
        {
        // Abre el formulario que lista las reservas para cancelar la seleccionada.
        CancelarReservaForm cancelarForm = new CancelarReservaForm(usuarioActual);
            cancelarForm.ShowDialog();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnMisReportes_Click(object sender, EventArgs e)
        {
            MisReportesForm reportesForm = new MisReportesForm(usuarioActual);
            reportesForm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerMisReservas_Click(object sender, EventArgs e)
        {
            MiReservasForm MiReservaForm = new MiReservasForm(usuarioActual);
            MiReservaForm.ShowDialog();
        }
    }
}
