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
        private ReservaService reservaService;
        private Miembro currentMiembro;
        // Para listar clases, podemos usar directamente el repositorio o, idealmente, un servicio de clases.
        private ClaseRepository claseRepository;

        public ReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;
            // Inicializamos el repositorio y servicio. (En un proyecto real, se emplea inyección de dependencias.)
            reservaService = new ReservaService(new ReservaRepository(), new MiembroRepository(), new ClaseRepository());
            claseRepository = new ClaseRepository();
            CargarClasesDisponibles();
            // Configurar el DateTimePicker (opcionalmente, se puede fijar un formato o valor predeterminado)
            dtpFechaReserva.Value = DateTime.Now.AddHours(1);
        }

        // Carga las clases disponibles en el ComboBox.
        private void CargarClasesDisponibles()
        {
            try
            {
                IEnumerable<Clase> clases = claseRepository.ObtenerTodos();
                // Asumimos que "Clase" tiene las propiedades ClaseID y NombreClase.
                cmbClases.DataSource = new List<Clase>(clases);
                cmbClases.DisplayMember = "NombreClase";
                cmbClases.ValueMember = "ClaseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clases: " + ex.Message);
            }
        }

        // Evento clic del botón Reservar
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo objeto Reserva
                Reserva nuevaReserva = new Reserva();
                nuevaReserva.UsuarioID = currentMiembro.UsuarioID;

                // Obtener el ID de la clase seleccionada en el ComboBox
                if (cmbClases.SelectedItem is Clase selectedClase)
                {
                    nuevaReserva.ClaseID = selectedClase.ClaseID;
                }
                else
                {
                    MessageBox.Show("Seleccione una clase válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Establecer la fecha de la reserva basándose en el DateTimePicker; en un escenario real,
                // se podría validar esta fecha contra el horario programado de la clase.
                nuevaReserva.FechaReserva = dtpFechaReserva.Value;

                // Llamar al Servicio de Reserva: esto aplicará todas las validaciones (como vigencia de membresía y cupos disponibles)
                int nuevaReservaId = reservaService.RegistrarReserva(nuevaReserva);
                lblMensaje.Text = "Reserva registrada correctamente, ID: " + nuevaReservaId;
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al registrar la reserva: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ReservaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
