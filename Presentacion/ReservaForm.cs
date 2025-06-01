using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GymApp.Entidades;
using GymApp.Negocio;
using GymApp.AccesoDatos;

namespace GymApp.Presentacion
{
    public partial class ReservaForm : Form
    {
        private ReservaService reservaService;
        private Miembro usuarioActual;

        // Constructor principal (sin parámetros) que inicializa los servicios
        public ReservaForm() : this(
            new ReservaService(
                new ReservaRepository(),
                new MiembroRepository(),
                new ClaseRepository()))
        {
        }


        // Constructor para inyección de dependencias
        public ReservaForm(ReservaService servicio)
        {
            InitializeComponent();
            this.reservaService = servicio;
            CargarClases();
        }

        // NUEVO: Constructor que recibe un Miembro
        public ReservaForm(Miembro miembroActual) : this()
        {
            this.usuarioActual = miembroActual;
            txtUsuarioID.Text = usuarioActual.UsuarioID.ToString(); // Prellenar campo
            txtUsuarioID.Visible = false; // Ocultar si ya no es necesario
            lblUsuarioID.Visible = false; // Si tienes un label asociado, también ocultarlo
        }

        private void CargarClases()
        {
            try
            {
                IClaseRepository claseRepo = new ClaseRepository();
                var listaClases = claseRepo.ObtenerTodos().ToList();
                cmbClases.DataSource = listaClases;
                cmbClases.DisplayMember = "NombreClase";
                cmbClases.ValueMember = "ClaseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las clases: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Se usa el UsuarioID del miembro logueado
                int usuarioId = usuarioActual.UsuarioID;
                int claseId = Convert.ToInt32(cmbClases.SelectedValue);
                DateTime fechaReserva = dtpFechaReserva.Value;

                Reserva nuevaReserva = new Reserva
                {
                    UsuarioID = usuarioId,
                    ClaseID = claseId,
                    FechaReserva = fechaReserva,
                    Estado = "Activa"
                };

                int nuevoId = reservaService.RegistrarReserva(nuevaReserva);
                MessageBox.Show("Reserva registrada correctamente. ID: " + nuevoId,
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarReservas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar reserva: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarReservas()
        {
            try
            {
                int usuarioId = usuarioActual.UsuarioID;
                var reservas = reservaService.ObtenerReservasPorMiembro(usuarioId).ToList();
                dgvReservas.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona una reserva para cancelar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);
                reservaService.CancelarReserva(reservaId);
                MessageBox.Show("Reserva cancelada correctamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la reserva: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
