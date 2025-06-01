using System;
using System.Linq;
using System.Windows.Forms;
using GymApp.Entidades;
using GymApp.AccesoDatos;
using GymApp.Negocio;

namespace GymApp.Presentacion
{
    public partial class MisReportesForm : Form
    {
        private Miembro usuarioActual;
        private ReservaService reservaService;
        private AccesoService accesoService;

        public MisReportesForm(Miembro miembro)
        {
            InitializeComponent();
            usuarioActual = miembro;

            reservaService = new ReservaService(
                new ReservaRepository(),
                new MiembroRepository(),
                new ClaseRepository());

            accesoService = new AccesoService(new AccesoRepository());

            cmbTipoReporte.Items.Add("Reservas");
            cmbTipoReporte.Items.Add("Asistencias");
            cmbTipoReporte.SelectedIndex = 0;
        }



        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tipo = cmbTipoReporte.SelectedItem.ToString();

                if (tipo == "Reservas")
                {
                    var reservas = reservaService.ObtenerReservasPorMiembro(usuarioActual.UsuarioID).ToList();
                    dgvReporte.DataSource = reservas;
                }
                else if (tipo == "Asistencias")
                {
                    var asistencias = accesoService.ObtenerAccesosPorUsuario(usuarioActual.UsuarioID).ToList();
                    dgvReporte.DataSource = asistencias;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
