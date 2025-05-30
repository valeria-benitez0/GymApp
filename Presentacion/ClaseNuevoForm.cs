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
    public partial class ClaseNuevoForm : Form
    {
        private ClaseService claseService;
        private Clase claseActual; // Si es null, es modo "nueva clase". Si no, edición.

        public ClaseNuevoForm()
        {
            InitializeComponent();
            claseService = new ClaseService(new ClaseRepository());
            InicializarControles();
        }

        public ClaseNuevoForm(Clase clase)
        {
            InitializeComponent();
            claseService = new ClaseService(new ClaseRepository());
            claseActual = clase;
            InicializarControles();
            CargarDatosClase(claseActual);
        }

        /// <summary>
        /// Inicializa controles y configura valores por defecto.
        /// </summary>
        private void InicializarControles()
        {
            lblTitulo.Text = (claseActual == null) ? "Nueva Clase" : "Editar Clase";

            // Configurar NumericUpDown para duración y capacidad
            numDuracion.Minimum = 1;
            numDuracion.Maximum = 180;
            numDuracion.Value = 60;

            numCapacidad.Minimum = 1;
            numCapacidad.Maximum = 100;
            numCapacidad.Value = 20;

            // Cargar el ComboBox de Entrenadores (usando un servicio de entrenadores)
            CargarEntrenadores();
        }

        /// <summary>
        /// Carga la lista de entrenadores en el ComboBox.
        /// </summary>
        private void CargarEntrenadores()
        {
            try
            {
                // Suponemos que existe un servicio para entrenadores
                var entrenadorService = new EntrenadorService(new EntrenadorRepository());
                var entrenadores = entrenadorService.ObtenerTodosLosEntrenadores();
                cmbEntrenador.DataSource = entrenadores.ToList();
                cmbEntrenador.DisplayMember = "Nombre";
                cmbEntrenador.ValueMember = "EntrenadorID";    // Usa el ID para guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar entrenadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Si se está editando, carga los datos existentes de la clase.
        /// </summary>
        private void CargarDatosClase(Clase clase)
        {
            cmbNombreClase.Text = clase.NombreClase;
            dtpHorario.Value = clase.Horario;
            numDuracion.Value = clase.Duracion;
            numCapacidad.Value = clase.CapacidadMaxima;
            cmbEntrenador.SelectedValue = clase.EntrenadorID;
        }

        /// <summary>
        /// Guarda o actualiza la clase dependiendo del modo.
        /// </summary>
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validación básica: el nombre es obligatorio.
                if (string.IsNullOrWhiteSpace(cmbNombreClase.Text))
                {
                    lblMensaje.Text = "El nombre de la clase es obligatorio.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (claseActual == null)
                {
                    // Crear una nueva clase.
                    Clase nuevaClase = new Clase
                    {
                        NombreClase = cmbNombreClase.Text.Trim(),
                        Horario = dtpHorario.Value,
                        Duracion = (int)numDuracion.Value,
                        CapacidadMaxima = (int)numCapacidad.Value,
                        EntrenadorID = Convert.ToInt32(cmbEntrenador.SelectedValue)
                    };

                    claseService.RegistrarClase(nuevaClase);
                    lblMensaje.Text = "Clase registrada con éxito.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    // Actualizar la clase existente.
                    claseActual.NombreClase = cmbNombreClase.Text.Trim();
                    claseActual.Horario = dtpHorario.Value;
                    claseActual.Duracion = (int)numDuracion.Value;
                    claseActual.CapacidadMaxima = (int)numCapacidad.Value;
                    claseActual.EntrenadorID = Convert.ToInt32(cmbEntrenador.SelectedValue);

                    claseService.ActualizarClase(claseActual);
                    lblMensaje.Text = "Clase actualizada correctamente.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtNombreClase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
