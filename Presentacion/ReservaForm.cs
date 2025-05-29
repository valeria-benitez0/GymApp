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
    public partial class ReservaForm : Form
    {
        private Miembro currentMiembro;
        private ReservaService reservaService;
        private IClaseRepository claseRepository;

        public ReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;

            // Se inicializan los servicios y repositorios necesarios.
            reservaService = new ReservaService(new ReservaRepository(), new MiembroRepository(), new ClaseRepository());
            claseRepository = new ClaseRepository();

            // Cargar las clases disponibles en el ComboBox.
            CargarClasesDisponibles();

            dtpFechaReserva.MinDate = DateTime.Now.AddMinutes(30);
        }

        /// Carga en el ComboBox (cmbClases) la lista de clases disponibles.
        private void CargarClasesDisponibles()
        {
            try
            {
                IEnumerable<Clase> clases = claseRepository.ObtenerTodos();
                // Convertir a lista para evitar problemas de enlace
                cmbClases.DataSource = new List<Clase>(clases);
                cmbClases.DisplayMember = "NombreClase";
                cmbClases.ValueMember = "ClaseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las clases: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Evento click del botón "Reservar" que intenta registrar la reserva.
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto Reserva con la información ingresada.
                Reserva nuevaReserva = new Reserva();
                nuevaReserva.UsuarioID = currentMiembro.UsuarioID;

                // Validar que se haya seleccionado una clase
                if (cmbClases.SelectedItem is Clase claseSeleccionada)
                {
                    nuevaReserva.ClaseID = claseSeleccionada.ClaseID;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una clase válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar la fecha y hora de la reserva
                nuevaReserva.FechaReserva = dtpFechaReserva.Value;

                // Registrar la reserva usando el servicio, que realiza validaciones internas.
                int nuevoId = reservaService.RegistrarReserva(nuevaReserva);

                lblMensaje.Text = "Reserva registrada con éxito. ID: " + nuevoId;
                lblMensaje.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al registrar la reserva: " + ex.Message;
                lblMensaje.ForeColor = Color.Red;
            }
        }
        private void ReservaForm_Load(object sender, EventArgs e)
        {

        }

    }
}
