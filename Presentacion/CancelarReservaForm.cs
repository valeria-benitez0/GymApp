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
using GymApp.Negocio;
using GymApp.AccesoDatos;

namespace GymApp.Presentacion
{
    public partial class CancelarReservaForm : Form
    {
        private ReservaService reservaService;
        private Miembro currentMiembro;

        public CancelarReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;
            reservaService = new ReservaService(new ReservaRepository(), new MiembroRepository(), new ClaseRepository());
            CargarReservas();
        }

        // Método para cargar las reservas activas del miembro en el DataGridView
        private void CargarReservas()
        {
            try
            {
                IEnumerable<Reserva> reservas = reservaService.ObtenerReservasPorMiembro(currentMiembro.UsuarioID);
                dgvReservas.DataSource = new List<Reserva>(reservas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message);
            }
        }

        // Al presionar el botón "Cancelar Reserva"
        private void btnCancelarReserva_Click_1(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada en el DataGridView
            if (dgvReservas.SelectedRows.Count == 0)
            {
                lblMensaje.Text = "Seleccione una reserva para cancelar.";
                return;
            }

            // Suponemos que la columna "ReservaID" está configurada en el DataGridView
            int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);
            try
            {
                // Llamada al servicio para cancelar la reserva (aplica regla de 24 horas, etc.)
                reservaService.CancelarReserva(reservaId);
                lblMensaje.Text = "Reserva cancelada correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                CargarReservas(); // Actualiza el listado de reservas
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cancelar la reserva: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void CancelarReservaForm_Load(object sender, EventArgs e)
        {

        }

    }
}
