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
    public partial class EntrenadorNuevoForm : Form
    {
        private EntrenadorService entrenadorService;
        private Entrenador entrenadorActual; // Si es null, es modo "nuevo", de lo contrario, modo edición.

        public EntrenadorNuevoForm()
        {
            InitializeComponent();
            entrenadorService = new EntrenadorService(new EntrenadorRepository());
            lblTitulo.Text = "Nuevo Entrenador";
        }

        public EntrenadorNuevoForm(Entrenador entrenador)
        {
            InitializeComponent();
            entrenadorService = new EntrenadorService(new EntrenadorRepository());
            entrenadorActual = entrenador;
            lblTitulo.Text = "Editar Entrenador";
            CargarDatosEntrenador(entrenadorActual);
        }

        private void CargarDatosEntrenador(Entrenador entrenador)
        {
            txtNombre.Text = entrenador.Nombre;
            txtEspecialidad.Text = entrenador.Especialidad;
            txtDisponibilidad.Text = entrenador.Disponibilidad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios.
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    lblMensaje.Text = "El nombre es obligatorio.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEspecialidad.Text))
                {
                    lblMensaje.Text = "La especialidad es obligatoria.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDisponibilidad.Text))
                {
                    lblMensaje.Text = "La disponibilidad es obligatoria.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (entrenadorActual == null)
                {
                    // Crear un nuevo entrenador.
                    Entrenador nuevoEntrenador = new Entrenador
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Especialidad = txtEspecialidad.Text.Trim(),
                        Disponibilidad = txtDisponibilidad.Text.Trim()
                    };

                    entrenadorService.RegistrarEntrenador(nuevoEntrenador);
                    lblMensaje.Text = "Entrenador registrado con éxito.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    // Actualizar el entrenador existente.
                    entrenadorActual.Nombre = txtNombre.Text.Trim();
                    entrenadorActual.Especialidad = txtEspecialidad.Text.Trim();
                    entrenadorActual.Disponibilidad = txtDisponibilidad.Text.Trim();

                    entrenadorService.ActualizarEntrenador(entrenadorActual);
                    lblMensaje.Text = "Entrenador actualizado correctamente.";
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
    }
}
