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
    public partial class MiembroNuevoForm : Form
    {
        private MiembroService miembroService;
        private Miembro miembroActual; // Si es nulo, estamos en modo "nuevo"; si no, en modo edición.

        public MiembroNuevoForm()
        {
            InitializeComponent();
            miembroService = new MiembroService(new MiembroRepository());
            InicializarControles();
        }

        public MiembroNuevoForm(Miembro miembro)
        {
            InitializeComponent();
            miembroService = new MiembroService(new MiembroRepository());
            miembroActual = miembro;
            InicializarControles();
            CargarDatosMiembro(miembroActual);
        }

        // Método para inicializar propiedades de controles que se requieran.
        private void InicializarControles()
        {
            // Configurar el ComboBox con los tipos de membresía.
            cmbTipoMembresia.Items.Clear();
            cmbTipoMembresia.Items.Add("Básica");
            cmbTipoMembresia.Items.Add("Premium");
            cmbTipoMembresia.SelectedIndex = 0;

            // Configurar el ComboBox para el rol.
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Miembro");
            cmbRol.SelectedIndex = 1;

            // Configurar el DateTimePicker para la fecha de vencimiento de la membresía.
            dtpFechaVencimiento.Value = DateTime.Now.AddMonths(1);

            // Establecer el título según el modo (nuevo o edición)
            lblTitulo.Text = (miembroActual == null) ? "Nuevo Miembro" : "Editar Miembro";
        }

        /// Carga los datos existentes del miembro en el formulario para edición.
        /// <param name="miembro"></param>
        private void CargarDatosMiembro(Miembro miembro)
        {
            txtNombre.Text = miembro.Nombre;
            txtEmail.Text = miembro.Email;
            txtTelefono.Text = miembro.Telefono;
            cmbTipoMembresia.SelectedItem = miembro.TipoMembresia;
            dtpFechaVencimiento.Value = miembro.FechaVencimientoMembresia;
            cmbRol.SelectedItem = miembro.Rol;
            txtPassword.Text = miembro.Password;
            chkActivo.Checked = miembro.Activo;
        }

        /// Evento para guardar los datos del miembro (registrar o actualizar).
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios.
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    lblMensaje.Text = "Complete los campos obligatorios (Nombre, Email y Contraseña).";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (miembroActual == null)
                {
                    Miembro nuevoMiembro = new Miembro
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        TipoMembresia = cmbTipoMembresia.SelectedItem.ToString(),
                        FechaVencimientoMembresia = dtpFechaVencimiento.Value,
                        Rol = cmbRol.SelectedItem.ToString(),
                        Password = txtPassword.Text.Trim(), 
                        Activo = chkActivo.Checked
                    };

                    // Invocar el método de registro.
                    miembroService.RegistrarMiembro(nuevoMiembro);
                    lblMensaje.Text = "Miembro registrado con éxito.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    // Actualizar el miembro existente.
                    miembroActual.Nombre = txtNombre.Text.Trim();
                    miembroActual.Email = txtEmail.Text.Trim();
                    miembroActual.Telefono = txtTelefono.Text.Trim();
                    miembroActual.TipoMembresia = cmbTipoMembresia.SelectedItem.ToString();
                    miembroActual.FechaVencimientoMembresia = dtpFechaVencimiento.Value;
                    miembroActual.Rol = cmbRol.SelectedItem.ToString();
                    miembroActual.Password = txtPassword.Text.Trim();
                    miembroActual.Activo = chkActivo.Checked;

                    miembroService.ActualizarMiembro(miembroActual);
                    lblMensaje.Text = "Miembro actualizado correctamente.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }

                // Cerrar el formulario o limpiar los campos según la lógica deseada.
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void MiembroNuevoForm_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
