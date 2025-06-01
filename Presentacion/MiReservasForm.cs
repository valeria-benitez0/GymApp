using System;
using System.Linq;
using System.Windows.Forms;
using GymApp.AccesoDatos;
using GymApp.Entidades;
using GymApp.Negocio;

namespace GymApp.Presentacion
{
    public partial class MiReservasForm : Form
    {
        private Miembro usuarioActual;
        private ReservaService reservaService;

        public MiReservasForm(Miembro miembro)
        {
            InitializeComponent();
            usuarioActual = miembro;

            reservaService = new ReservaService(
                new ReservaRepository(),
                new MiembroRepository(),
                new ClaseRepository());

            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                var reservas = reservaService.ObtenerReservasPorMiembro(usuarioActual.UsuarioID).ToList();
                dgvMisReservas.DataSource = reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tus reservas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
    }
}
