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
        private IClaseRepository claseRepository;

        public ReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;
            // Inicialización directa para ejemplificar (idealmente, usar inyección de dependencias)
            reservaService = new ReservaService(new ReservaRepository(), new MiembroRepository(), new ClaseRepository());
            claseRepository = new ClaseRepository();
            CargarClasesDisponibles();

            // Configurar el DateTimePicker (por ejemplo, que la fecha mínima sea ahora + 1 hora)
            dtpFechaReserva.Value = DateTime.Now.AddHours(1);
        }

        // Carga las clases disponibles en el ComboBox
        private void CargarClasesDisponibles()
        {
            try
            {
                IEnumerable<Clase> clases = claseRepository.ObtenerTodos();
                // Convertir a lista y asignar propiedades del ComboBox
                cmbClases.DataSource = new List<Clase>(clases);
                cmbClases.DisplayMember = "NombreClase"; // Se mostrará el nombre de la clase
                cmbClases.ValueMember = "ClaseID";         // Valor interno: el ID de la clase
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clases: " + ex.Message);
            }
        }

        // Evento click del botón "Reservar"
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva nuevaReserva = new Reserva();
                nuevaReserva.UsuarioID = currentMiembro.UsuarioID;

                // Validar que se haya seleccionado una clase
                if (cmbClases.SelectedItem is Clase selectedClase)
                {
                    nuevaReserva.ClaseID = selectedClase.ClaseID;
                }
                else
                {
                    MessageBox.Show("Seleccione una clase válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar la fecha y hora seleccionadas
                nuevaReserva.FechaReserva = dtpFechaReserva.Value;

                // Invocar el servicio que registra la reserva; este método realiza las validaciones internas.
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
