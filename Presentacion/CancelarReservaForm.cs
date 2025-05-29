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
        private Miembro currentMiembro;
        private ReservaService reservaService;

        // Constructor recibe el miembro actual para filtrar sus reservas.
        public CancelarReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;
            // Se inicializa el servicio, asignando las dependencias necesarias.
            reservaService = new ReservaService(new ReservaRepository(), new MiembroRepository(), new ClaseRepository());

            // Cargar el listado de reservas para el miembro al iniciar
            CargarReservas();
        }

        /// Método que carga o actualiza el DataGridView con las reservas activas del miembro.
        private void CargarReservas()
        {
            try
            {
                IEnumerable<Reserva> reservas = reservaService.ObtenerReservasPorMiembro(currentMiembro.UsuarioID);
                // Convertir a lista para tener un control completo
                dgvReservas.DataSource = reservas.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Verifica que se haya seleccionado una reserva y llama a la lógica de negocio para cancelar la reserva.

        private void btnCancelarReserva_Click_1(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una fila en el DataGridView.
            if (dgvReservas.SelectedRows.Count == 0)
            {
                lblMensaje.Text = "Seleccione una reserva para cancelar";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Se asume que la columna "ReservaID" está presente en el DataGridView.
            int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);

            try
            {
                // Invocar al servicio para cancelar la reserva, lo que aplicará las validaciones (p.ej., 24 horas de anticipación)
                reservaService.CancelarReserva(reservaId);
                lblMensaje.Text = "Reserva cancelada correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                // Actualiza el listado de reservas para reflejar la cancelación.
                CargarReservas();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cancelar la reserva: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarReservas();
        }
        private void CancelarReservaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
