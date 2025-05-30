using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.Negocio;
using GymApp.AccesoDatos;

namespace GymApp.Presentacion
{
    public partial class ReportesForm : Form
    {
        private AccesoService accesoService;

        public ReportesForm()
        {
            InitializeComponent();
            // Instanciamos el repositorio y el servicio.
            IAccesoRepository accesoRepo = new AccesoRepository();
            accesoService = new AccesoService(accesoRepo);
        }

        // Evento para generar el reporte de asistencia.
        private void btnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;
                var reporte = accesoService.ObtenerReporteAsistencia(fechaInicio, fechaFin).ToList();
                dgvReporteAsistencia.DataSource = reporte;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generando reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para ver las notificaciones de reservas pendientes.
        private void btnVerNotificaciones_Click_1(object sender, EventArgs e)
        {
            try
            {
                var notificaciones = accesoService.ObtenerNotificacionesPendientes().ToList();
                dgvNotificaciones.DataSource = notificaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obteniendo notificaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
