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
        private ClaseService claseService;
        private Miembro currentMiembro;

        public ReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;
            reservaService = new ReservaService(new ReservaRepository(),
                                                new MiembroRepository(),
                                                new ClaseRepository());
            claseService = new ClaseService(new ClaseRepository());
            CargarClasesDisponibles();

            dtpFechaReserva.MinDate = DateTime.Now.AddMinutes(30);
        }

        private void CargarClasesDisponibles()
        {
            try
            {
                // Obtenemos todas las clases; se podrían filtrar por disponibilidad.
                var clases = claseService.ObtenerTodasLasClases();
                cmbClases.DataSource = clases.ToList();
                cmbClases.DisplayMember = "NombreClase";
                cmbClases.ValueMember = "ClaseID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clases: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClases.SelectedItem == null)
                {
                    lblMensaje.Text = "Seleccione una clase.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                // Se crea un objeto Reserva y se asigna la información.
                Reserva nuevaReserva = new Reserva();
                nuevaReserva.UsuarioID = currentMiembro.UsuarioID;
                nuevaReserva.ClaseID = (int)cmbClases.SelectedValue;
                // Se utiliza el valor del DateTimePicker.
                nuevaReserva.FechaReserva = dtpFechaReserva.Value;

                // Registrar la reserva (se realizan las validaciones internas en el service).
                int nuevoId = reservaService.RegistrarReserva(nuevaReserva);

                lblMensaje.Text = "Reserva registrada exitosamente. ID: " + nuevoId;
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
