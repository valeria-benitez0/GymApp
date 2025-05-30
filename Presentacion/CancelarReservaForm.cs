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
        private ReservaService reservaService;
        private Miembro currentMiembro;

        public CancelarReservaForm(Miembro miembro)
        {
            InitializeComponent();
            currentMiembro = miembro;
            reservaService = new ReservaService(new ReservaRepository(),
                                                new MiembroRepository(),
                                                new ClaseRepository());
            CargarReservas();
        }

        /// <summary>
        /// Carga las reservas activas del miembro en el DataGridView.
        /// </summary>
        private void CargarReservas()
        {
            try
            {
                // Utilizamos el método del service que retorna reservas activas para el miembro.
                var reservas = reservaService.ObtenerReservasPorMiembro(currentMiembro.UsuarioID);
                dgvReservas.DataSource = reservas.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarReserva_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.SelectedRows.Count == 0)
                {
                    lblMensaje.Text = "Seleccione una reserva a cancelar.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["ReservaID"].Value);

                reservaService.CancelarReserva(reservaId);
                lblMensaje.Text = "Reserva cancelada exitosamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Green;

                CargarReservas();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            CargarReservas();
        }

    }
}
