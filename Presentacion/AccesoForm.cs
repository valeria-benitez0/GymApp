using GymApp.Entidades;
using GymApp.Negocio;
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

namespace GymApp.Presentacion
{
    public partial class AccesoForm : Form
    {
        private AccesoService accesoService;

        public AccesoForm()
        {
            InitializeComponent();
            // Instanciamos el repositorio y el servicio.
            IAccesoRepository accesoRepo = new AccesoRepository();
            accesoService = new AccesoService(accesoRepo);
        }

        // Evento para registrar un acceso.
        private void btnRegistrarAcceso_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que el usuario ingrese un ID válido.
                if (!int.TryParse(txtUsuarioID.Text, out int usuarioId))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Se puede obtener el ID de la clase desde un TextBox o ComboBox.
                if (!int.TryParse(txtClaseID.Text, out int claseId))
                {
                    MessageBox.Show("Por favor, ingrese un ID de clase válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string estado = cmbEstadoAcceso.Text; // Por ejemplo, "Permitido" o "Denegado"

                // Creamos el objeto acceso.
                Acceso nuevoAcceso = new Acceso
                {
                    UsuarioID = usuarioId,
                    ClaseID = claseId,
                    EstadoAcceso = estado,
                    FechaAcceso = DateTime.Now
                };

                int idAcceso = accesoService.RegistrarAcceso(nuevoAcceso);
                MessageBox.Show("Acceso registrado con éxito. ID: " + idAcceso, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrando acceso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
