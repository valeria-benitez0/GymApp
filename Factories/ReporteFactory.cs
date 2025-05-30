using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymApp.Entidades;
using GymApp.AccesoDatos;

namespace GymApp.Factories
{
    public static class ReporteFactory
    {
        public static IEnumerable<ReporteAsistenciaDTO> CrearReporteAsistencia(DateTime fechaInicio, DateTime fechaFin, IAccesoRepository repo)
        {
            // Se delega en el repositorio la generación del reporte.
            return repo.GenerarReporteAsistencia(fechaInicio, fechaFin);
        }
    }
}

namespace GymApp.Factories
{
    public static class NotificacionFactory
    {
        public static IEnumerable<NotificacionReservaDTO> CrearNotificaciones(IAccesoRepository repo)
        {
            // Se obtiene la lista de reservas pendientes a notificar.
            return repo.ObtenerNotificacionesReservasPendientes();
        }
    }
}
